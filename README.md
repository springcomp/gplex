## Welcome to the adaptation of GPLEX for dotnet core.

Project based on [Gardens Point LEX] (https://gplex.codeplex.com/)

#### How to use

For use in dotnet core projects you need add next text in csproj

```
  <Target Name="ScannerGenerator" BeforeTargets="BeforeBuild" Condition=" '$(IsCrossTargetingBuild)' != 'true' " Inputs="input.lex" Outputs="output.s.cs">
    <Exec Command="dotnet gplex /out:output.s.cs input.lex" WorkingDirectory="$(MSBuildProjectDirectory)" />
  </Target>

  <Target Name="ParserGenerator" BeforeTargets="BeforeBuild" Condition=" '$(IsCrossTargetingBuild)' != 'true' " Inputs="input.y" Outputs="output.p.cs">
    <Exec Command="dotnet gppg /gplex /nolines /out:output.p.cs input.y" WorkingDirectory="$(MSBuildProjectDirectory)" />
  </Target>

  <ItemGroup>
    <DotNetCliToolReference Include="Springcomp.GPLEX" Version="1.0.0-preview" />
    <DotNetCliToolReference Include="Springcomp.GPPG" Version="1.0.0-preview" />
  </ItemGroup>


```