@rem EXPORT INTERFACE BATCH FILE
if [%1]==[] (
	mkdir "../exportedInterfaces"
	XComponent.XCTools.exe --Debug --exportInterface -env=Dev -output="../exportedInterfaces" -project="../Test_Model.xcml"
) else (
	XComponent.XCTools.exe --Debug --exportInterface -env=Dev -output=%1 -project="../Test_Model.xcml"
)