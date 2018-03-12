### Employee Search

##### Bad

If we want to extend the EmployeeSearch with another condition, we're forced to modify the current 
implementation of EmployeeSearch. So extension can come only by modification and as such OCP is 
violated.

##### Good

OCP is typically implemented with the Strategy and Template pattern. This one is the Template 
solution. EmployeeSearch can be extended by implementing  a class deriving from ISearchCondition. 