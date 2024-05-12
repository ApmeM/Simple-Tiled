# Simple Tiled

## Introduction

Easy to use library to create and read [tiled](https://www.mapeditor.org/) maps.

All processes are based on XmlSerializer.

## Usage example

To create map fill necessary fields in `TmxMap` object and call `TiledHelper.Write` to any Stream you wish.

    TiledHelper.Write(CreateMap(), File.OpenWrite("./result.tmx"));


To read existing map file you need to get stream with the data and call `TiledHelper.Read`

    TmxMap map = TiledHelper.Read(File.OpenRead("./result.tmx"));


More detailed example can be found in [Beasts and bumpkins](https://github.com/ApmeM/BeastsAndBumpkinsParser/blob/main/src/files/map/MAPFile.cs) repository.