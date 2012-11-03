## Overview

This demonstrates a static wrapper class around [log4net](http://logging.apache.org/log4net/). A static wrapper allows programs to use the logging framework's capabilities without having to include boilerplate declarations throughout the code. Writing to the log is just a call to one of the static logging methods exposed by the wrapper.

    Log.Debug("Hello world.");

The logging system can be configured in the usual log4net fashion.
