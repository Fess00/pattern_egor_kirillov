using pattern_egor_kirillov.Bridge.Logger;
using pattern_egor_kirillov.Bridge.Visualization;
using pattern_egor_kirillov.Decorator;

ErrorLogger logger = new("Standart error message...", 216);
FileLog fileLog = new(logger);
fileLog.Log();

UpperCaseLogger reversed = new(logger);
ConsoleLog consoleLog = new(reversed);
consoleLog.Log();
