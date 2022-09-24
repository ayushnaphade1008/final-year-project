import requests
import sys
import os
import csv
import json
import collections

def saveCSV(op_data):
    try:
        header_fields = [x for x in op_data[0].keys()]

        csv_file_name = os.path.basename(filename.replace('pdf','csv'))
        if multiple_files:
            csv_file_path = r"C:\DocumentAnalyzer\AnalyzedData\CSV\analyzed_data.csv"
        else:
            csv_file_path = f"C:\DocumentAnalyzer\AnalyzedData\CSV\{csv_file_name}"
        
        with open(csv_file_path, "a" if multiple_files else "w", newline='', encoding='utf-8') as csv_file:
          writer = csv.DictWriter(csv_file, fieldnames=header_fields)

          csv_file.seek(0, 2)

          if csv_file.tell() == 0:
              writer.writeheader()

          writer.writerows(op_data)
        csv_file.close()
    except Exception as e:
        print(e)
    else:
        print('Saved as CSV')
        

def saveJSON(op_data):
    try:
        json_file_name = os.path.basename(filename.replace('pdf','json'))
        for json_data in op_data:
            if multiple_files:
                json_file_path = r"C:\DocumentAnalyzer\AnalyzedData\JSON\analyzed_data.json"
            else:
                json_file_path = f"C:\DocumentAnalyzer\AnalyzedData\JSON\{json_file_name}"
            with open(json_file_path, "a" if multiple_files else "w") as outfile:
                json.dump(json_data, outfile)

    except Exception as e:
        print(e)
    else:
        print('Saved as JSON')
 
 
def saveRawText(op_data: dict):
    try:
        text_file_name = os.path.basename(filename.replace('pdf','txt'))
        for json_data in op_data:
            if multiple_files:
                raw_text_path = r"C:\DocumentAnalyzer\AnalyzedData\RawText\analyzed_data.txt"
            else:
                raw_text_path = f"C:\DocumentAnalyzer\AnalyzedData\RawText\{text_file_name}"
            with open(raw_text_path, "a" if multiple_files else "w") as outfile:
                for k,v in op_data.items():
                    outfile.writelines(k)
                    outfile.writelines(v)

    except Exception as e:
        print(e)
    else:
        print('Saved as RawText')
        
  
def saveXML(op_data:dict):
    import xml.etree.cElementTree as e
    xml_file_name = os.path.basename(filename.replace('pdf','xml'))
    xml_path = f"C:\DocumentAnalyzer\AnalyzedData\XML\{xml_file_name}"
    
    r = e.Element("Invoive Data")
    for k,v in op_data.items():
        e.SubElement(r,k).text = v

    a = e.ElementTree(r)
    a.write(xml_path)
    

def saveText(text_data: str):
    text_file_name = os.path.basename(filename.replace('pdf','txt'))
    raw_text_path = f"C:\DocumentAnalyzer\AnalyzedData\RawText\{text_file_name}"
    with open(raw_text_path, "w") as outfile:
        outfile.writelines(text_data)
        outfile.close()
    
    
def getRequest(stri):
    stri = stri.replace(':','')
    raw_req = stri.split('_')
    output_request = {raw_req[0].replace('{',''): raw_req[1], raw_req[2]: raw_req[3], raw_req[4]: raw_req[5].replace('}','')}
    return output_request
        
        
try:
    if not os.path.exists("C:\DocumentAnalyzer\AnalyzedData\CSV"):
        os.makedirs("C:\DocumentAnalyzer\AnalyzedData\CSV")
    if not os.path.exists("C:\DocumentAnalyzer\AnalyzedData\JSON"):
        os.makedirs("C:\DocumentAnalyzer\AnalyzedData\JSON")
    if not os.path.exists("C:\DocumentAnalyzer\AnalyzedData\RawText"):
        os.makedirs("C:\DocumentAnalyzer\AnalyzedData\RawText")
    if not os.path.exists("C:\DocumentAnalyzer\AnalyzedData\Word"):
        os.makedirs("C:\DocumentAnalyzer\AnalyzedData\Word")
    
    url = "https://wdjok0jhb9.execute-api.us-east-2.amazonaws.com/AWS_Doc_Analyzer/upload-pdf"

    # getting filename
    filename = sys.argv[1]
    
    multiple_files = False
    
    try:
        # getting keys
        analysing_keys = sys.argv[2] 
        if analysing_keys == 'None':
            analysing_keys = False
        else:
            analysing_keys = sys.argv[2].split(',')
            analysing_keys = [x.replace('_', ' ').strip() for x in analysing_keys]
    except:
        analysing_keys = False
               
    with open(filename, 'rb') as f:
        data = f.read()

    requested_data = getRequest(sys.argv[3])
    if requested_data['Output'] == 'multiple':
        multiple_files = True
    
    payload=data
    headers = {
      'Content-Type': 'application/pdf',
      'x-api-key': 'HLUhV6DxBG8lDXzaE4KebQgfDdEiIC21olssDPIb'
    }
    
    param_url = url + f"?analyze_type={requested_data['Type']}"
    
    response = requests.request("POST", param_url, headers=headers, data=payload)
except Exception as e:
    print("Error: ", e)
else:
    if not analysing_keys:
    # when no keys are available
        try:
            op_data = json.loads(response.text)
            # sort according to keys
            export_data = collections.OrderedDict(sorted(op_data.items()))
            if requested_data['Format'] == 'json':
                saveJSON([export_data])
            elif requested_data['Format'] == 'csv':
                saveCSV([export_data])  
            elif requested_data['Format'] == 'rawtext':
                if requested_data['Type'] == 'text':
                    saveText(export_data['DocText'])
                else:
                    saveRawText(export_data)
        except Exception as e:
            print(e)
        else:
            print('True')
    else:
        # when keys are available
        try:
            raw_op_data = json.loads(response.text)
            
            extracted_data = {}
            for k, v in raw_op_data.items():
                k = k.lower().strip().replace('_',' ')
                v = v.lower().strip()
                for key in analysing_keys:
                    key = key.replace('_',' ')
                    if key.lower() in k:
                        extracted_data[k] = v
            # sort according to keys
            export_data = collections.OrderedDict(sorted(extracted_data.items()))

            if requested_data['Format'] == 'json':
                saveJSON([export_data])
            elif requested_data['Format'] == 'csv':
                saveCSV([export_data])  
            else:
                saveXML(export_data)
        except Exception as e:
            print(e)
        else:
            print('True')