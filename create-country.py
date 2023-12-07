import os
import re
from pathlib import Path

with open("country_list", "w") as file:
    lines = []
    count = 0
    for filename in os.listdir("Flags"):
        continent = []
        match filename:
            case "NorthAmerica":
                index = "0"
            case "Europe":
                index = "1"
            case "Africa":
                index = "2"
            case "SouthAmerica":
                index = "3"
            case "Oceania":
                index = "4"
            case "Asia":
                index = "5"
        for flag in os.listdir("Flags/"+filename):
            name = Path(flag).stem
            name = re.sub(r"(\w)([A-Z])", r"\1 \2", name)
            print(name)
            s = "new Country(\""+name+"\", new BitmapImage(new Uri(@\"/GeographyApp;component/Photos/Flags/"+filename+"/"+flag+"\", UriKind.Relative)), new BitmapImage(), Continents["+index+"], false, false);\n"
            continent.append(s)
        continent.sort()
        continent.append("\n")
        lines.append(continent)
    for cont in lines:
        file.writelines(cont)
