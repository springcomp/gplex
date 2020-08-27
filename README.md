## Welcome to the adaptation of GPLEX for dotnet core.

Project based on [Gardens Point LEX] (https://gplex.codeplex.com/)

#### How to use

For use in dotnet core projects, first install the appropriate dotnet CLI local tools in the project folder:

```
dotnet new tool-manifest
dotnet tool install Springcomp.GPLEX --version 1.0.0-preview-4
dotnet tool install Springcomp.GPPG --version 1.0.0-preview-3
```

Then, you need add next text in csproj to perform the conversion.

```
  <Target Name="ScannerGenerator" BeforeTargets="BeforeBuild" Condition=" '$(IsCrossTargetingBuild)' != 'true' " Inputs="input.lex" Outputs="output.s.cs">
    <Exec Command="dotnet gplex /out:output.s.cs input.lex" WorkingDirectory="$(MSBuildProjectDirectory)" />
  </Target>

  <Target Name="ParserGenerator" BeforeTargets="BeforeBuild" Condition=" '$(IsCrossTargetingBuild)' != 'true' " Inputs="input.y" Outputs="output.p.cs">
    <Exec Command="dotnet gppg /gplex /nolines /out:output.p.cs input.y" WorkingDirectory="$(MSBuildProjectDirectory)" />
  </Target>


```
