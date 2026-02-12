﻿using NLog;
string path = Directory.GetCurrentDirectory() + "//nlog.xml";

// create instance of Logger
var logger = LogManager.Setup().LoadConfigurationFromFile(path).GetCurrentClassLogger();

logger.Info("Program started");

Console.WriteLine("Hello World!");

logger.Info("Program ended");
