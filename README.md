## **Overview**
The Daily Health Monitor is a Windows Forms application. It is designed to view, edit and search employee health records. 

**Special Requirements:**
1. One health record includes following information: Gin Number, first name, last name, date, visited Hubei recently or not, has abnormal symptom or not, body temperature. 
2. Gin Number, which is a positive integer, represents employee's identity. One Gin Number can be only associated with one name. 
One employee has up to one health record at each day. 
3. Body Temperature should not exceed the reasonable range (between 35 and 42 degrees). 
4. The person is considered a suspected case if he/she visited Hubei recently or has abnormal symptom, or his/her body temperature is more than 37.3 degrees.

**Functions added up to May 5th, 2020:**
1. Display health records in data grid view and sort health record by Gin Number, first name, last name or date
2. Open health records from CSV file
3. Save health records as CSV file
4. Add new health record 
5. Edit existed health record 
6. Update Gin Number and name of a employee in health records
7. Delete existed health record
8. Delete all health records displayed in data grid view
9. Group health records by year, month, date in Treeview
10. Group health records by last name, gin number and name in Treeview
11. Filter health record by Gin Number
12. Filter health record by Date
13. Filter health record by visited Hubei or not
14. Filter health record by has abnormal symptom or not
15. Filter health record by suspected case
15. Remind user current status

## **File Structure**

#### **Data Model:** 

[EmployeeHealthRecord](https://github.com/SZ559/HealthInformationWindowsApp/tree/master/EmployeeHealthRecord/EmployeeHealthRecord)

#### **GUI:** 

[WindowsAppGUI](https://github.com/SZ559/HealthInformationWindowsApp/tree/master/WindowsAppGUI)
+ Main Menu Form: [MainMenuForm.cs](https://github.com/SZ559/HealthInformationWindowsApp/blob/master/WindowsAppGUI/MainMenuForm.cs)
+ Form for adding new health record and editing existed health record: [FormForAddAndEdit.cs](https://github.com/SZ559/HealthInformationWindowsApp/blob/master/WindowsAppGUI/FormForAddAndEdit.cs)
+ Form for displaying health records with conflict date when updating Gin Number and name of a employee in health records: [OverlappedHealthInformationForm.cs]( https://github.com/SZ559/HealthInformationWindowsApp/blob/master/WindowsAppGUI/OverlappedHealthInformationForm.cs)
+ Helper Methods: [Filter.cs](https://github.com/SZ559/HealthInformationWindowsApp/blob/master/WindowsAppGUI/Filter.cs)
[DataGridViewSetting.cs](https://github.com/SZ559/HealthInformationWindowsApp/blob/master/WindowsAppGUI/DataGridViewSetting.cs)
#### **Helper Methods:** 
+ [FileOperation](https://github.com/SZ559/HealthInformationWindowsApp/tree/master/FileOperation)
+ [FormatValidator](https://github.com/SZ559/HealthInformationWindowsApp/tree/master/FormatValidator)

#### **Test Data:** 

+ [datafile](https://github.com/SZ559/HealthInformationWindowsApp/tree/master/datafile)

#### **Test Cases Design:** 

+ [Daily Health Monitor Test Cases Design] (https://github.com/SZ559/HealthInformationWindowsApp/blob/master/Daily%20Health%20Monitor%20Test%20Cases%20Design.jpg)

#### **Unit Test Reports for Data Model:** 
+ [UnitTestReport]
(https://github.com/SZ559/HealthInformationWindowsApp/tree/master/UnitTestReport)

#### **User Guide:** 
+ [User Guide.pptx]
(https://github.com/SZ559/HealthInformationWindowsApp/tree/master/User%20Guide)

## **Environment**
+ OS: Windows 10 Pro, 64-bit Operating System

## **Programming Language**
+ C# (.Net Framework, Visual Studio Community 2019)

## **Library**
+ System.Collections.Generic
+ System.Data
+ System.Linq
+ System.Windows.Forms
+ Xunit





