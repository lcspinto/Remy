﻿
using System.Collections.Generic;
using CommandLine;
using CommandLine.Text;

namespace Ainsley.Console
{
    public class Options
    {
        [Option('f', "configfile", Required = false, HelpText = "The YAML configuration file to use.")]
        public string ConfigFile { get; set; }

        [Option('v', "verbose", Required = false, HelpText = "Verbose output (warnings and info).")]
        public bool Verbose { get; set; }

        [Usage(ApplicationAlias = "ainsley")]
        public static IEnumerable<Example> Examples
        {
            get
            {
                yield return new Example("No args (looks for ainsley.yml in the same directory)", new Options { ConfigFile = "" });
                yield return new Example("Specify a config file:", new Options { ConfigFile = "myconfig.yml" });
                yield return new Example("Config file from a url", new Options { ConfigFile = "http://www.example.com/ainsley.yml" });
            }
        }
    }
}
