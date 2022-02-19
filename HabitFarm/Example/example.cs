
// *** DICTIONARY ***//
// // Ways to build a dictionary
  // // 1. 
  // Dictionary<TimeOfDay, Dictionary<string, object>> greetingsConfig = new Dictionary<TimeOfDay, Dictionary<string, object>>()
  // {
  //   { TimeOfDay.Morning, new Dictionary<string,object>()
  //     {
  //       {"Greeting", "Good morning"},
  //       {"TimeStart", new TimeSpan(5, 0, 0)},
  //     }
  //   },
  //   { TimeOfDay.Afternoon, new Dictionary<string,object>()
  //     {
  //       {"Greeting", "Good afternoon"},
  //       {"TimeStart", new TimeSpan(12, 0, 0)},
  //     }
  //   },
  //   { TimeOfDay.Evening, new Dictionary<string,object>()
  //     {
  //       {"Greeting", "Good evening"},
  //       {"TimeStart", new TimeSpan(18, 0, 0)},
  //     }
  //   },
  //   { TimeOfDay.Night, new Dictionary<string, object>()
  //     {
  //       {"Greeting", "Good night"},
  //       {"TimeStart", new TimeSpan(21, 0, 0)},
  //     }
  //   },
  // };
  //
  // // 2. 
  // var Greetings2 = new Dictionary<string, string>();
  // Greetings2["Morning"] = "Good morning";
  // Greetings2["Afternoon"] = "Good afternoon";
  // Greetings2["Evening"] = "Good evening";
  // Greetings2["Night"] = "Good night";
  //
  // // 3.
  // var greetings3 = new Dictionary<string, string>();
  // greetings3.Add("morning", "Good morning");
  // greetings3.Add("afternoon", "Good afternoon");
  // greetings3.Add("evening", "Good evening");
  // greetings3.Add("night", "Good night");
  //
  // bool isMorning = currentTime >= (TimeSpan)greetingsConfig[TimeOfDay.Morning]["TimeStart"] && currentTime < (TimeSpan)greetingsConfig[TimeOfDay.Afternoon]["TimeStart"];
  // bool isAfternoon = currentTime >= (TimeSpan)greetingsConfig[TimeOfDay.Afternoon]["TimeStart"] && currentTime < (TimeSpan)greetingsConfig[TimeOfDay.Evening]["TimeStart"];
  // bool isEvening = currentTime >= (TimeSpan)greetingsConfig[TimeOfDay.Evening]["TimeStart"] && currentTime < (TimeSpan)greetingsConfig[TimeOfDay.Night]["TimeStart"];
  // bool isNight = currentTime >= (TimeSpan)greetingsConfig[TimeOfDay.Night]["TimeStart"] && currentTime < (TimeSpan)greetingsConfig[TimeOfDay.Morning]["TimeStart"];

// *** ENUM ***
// to get keys in enum
// foreach(string keyInEnum in Enum.GetNames(typeof(ValidKey)))
// {
//   Console.WriteLine(keyInEnum);
// }