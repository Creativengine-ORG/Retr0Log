-- premake5.lua
workspace "Retr0Log"
   configurations { "Debug", "Release" }

    project "Retr0Log"
       kind "SharedLib"
       language "C#"
       targetdir "bin/%{cfg.buildcfg}"

       files { "**.cs" }

       filter "configurations:Debug"
          defines { "DEBUG" }
          symbols "On"

       filter "configurations:Release"
          defines { "NDEBUG" }
          optimize "On"

    project "Example"
        kind "ConsoleApp"
        language "C#"
        targetdir "bin/%{cfg.buildcfg}"
        links { "Retr0Log" }

       files { "**.cs" }

       filter "configurations:Debug"
          defines { "DEBUG" }
          symbols "On"

       filter "configurations:Release"
          defines { "NDEBUG" }
          optimize "On"
