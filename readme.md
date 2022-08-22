<!-- readme.md v1.6.9.5
Foundations (FND)
created: 17 Jul 2017
updated: 17 Aug 2022 -->

<!--this file: CC BY-ND 4.0 by zer0Kerbal-->

[![Foundations][MOD:shd:latest]][MOD:forum] [![KSP version][KSP:shd]][KSP:url[![License][LIC:shd]][LIC:url
[![Curseforge][CURSFG:shd]][CURSFG:url] [![GitHub][GITHUB:shd]][GITHUB:url] [![SpaceDock][SPCDCK:shd]][SPCDCK:url] [![CKAN][CKAN:shd]][ckan 
[![Pages][MOD:pages:shd]][MOD:pages]



# Foundations (FND)

An addon for Kerbal Space Program which allows establishing a connection between parts and the ground. Prevents ground constructions from float/sliding away :)



## By [`zer0Kerbal`][zer0Kerbal], originally by [`Sparkle`][sparkle]

adopted with *express* permission and brought to you by *KerbSimpleCo*

<img src="https://raw.githubusercontent.com/zer0Kerbal/Foundations/master/img/HeroLogo_1920x1920.png" alt="Foundations Hero" width="50%" height="50%">

### Preamble by [`Sparkle`][sparkle]

> Foundations is a mod which lets you anchor structures to the ground, just like a [real building](https://en.wikipedia.org/wiki/Foundation_(engineering)). It's goal is to help you set up more permanent buildings at your mun bases, around Kerbin or anywhere else that has land.


### How do I use it?  

The mod currently adds two new parts to the structural tab. These parts are based on the stock structural panels and are intended to be the foundation of any structures you want to build. Right clicking on them while they are touching the ground will give you the option to attach them, fixing them in place.

### Parts (two)  

###### `Foundation Structural (M-1x1)`:  
> ![Foundation Structural (M-1x1]:][IMG:part:0] ![PartInfo][IMG:partinfo:0

###### `Foundation Structural (M-2x2]`:  
> ![Foundation Structural (M-2x2):][IMG:part:1] ![PartInfo][IMG:partinfo:1 

### Attach/Detach action:

> ![Foundations PAW/RMB][IMG:action:0

### Why do I want this?  

> Jeb wants this because he's clumsy with his EVA suit and every time he bumps the fuel depot on Gilly it flies away...  
> ![example image needed][IMG:hero:1]

> Bill wants this because his new crane slides around when he tries to pick up that 30 ton fuel tank...
> ![example image needed][IMG:hero:2]

> Bob wants this because he's designed his ultimate kethane refinery for the Mun base and he needs it to stay put when Jeb tries to refuel his Mundozer...
> ![Mundozer example image needed][IMG:hero:3

> Why does Val want this? best answer (subjective) with image goes here-> 
> ![Val wants...][IMG:hero:4]

### Frequently Asked Questions (FAQs)

##### How solid are the foundations?  

  > The foundations are implemented using a physics joint and are intended to behave somewhat like real foundations. That means for reasonable loads they will be very solid but for larger loads, particularly unbalanced ones, you're going to need to think just a little more. I put together some examples [here example image needed][IMG:hero:5]. One of my main concerns was making sure they save and reload without any movement or slippage.

##### Will the foundations break?  

  > The joint holding them in place does have break forces set on it so yes. They are set high enough that you should be doing something quite unreasonable before this happens, and will probably break something else first. The larger foundation has relatively larger break forces as well.  

##### How do I get my structure to the right place?  

  > Currently that is entirely up to you. At my Gilly base gravity is so low I use RCS to fly my bases[them] into place Starcraft 2 style. On planets with more gravity you could use a large rover, or rockets, or winch it there with KAS or... be creative! If you have any ideas about such functionality that would work well in the mod do leave a suggestion.  

##### Can I make my own foundation parts?  

  > If you're familiar with part config files this is very easy. Note that any parts you make are your responsibility and I wont be officially supporting them. Look in `*GameData/KGEx/Foundations/Parts/foundation-1x1.cfg*` to see how the parts are put together, all that makes it a foundation part is the MODULE block at the end. Try something crazy like adding the module to landing legs... actually that sounds awesome, be right back... Submit your parts for possible future inclusion!

##### What are your future plans?  

  > I would like to create some more visually effective parts, particularly ones that deal nicely with building on sloped surfaces. Other than that I'm open to suggestions and Github PR's... where do you want this to go?
> * KIS/KAS patches  
> * Breaking Ground integration ()
> * Additional Localizations  
> * Additional Mod Integrations

### See More

* See our [Parts Catalog][MOD:parts] for part pictures
* For more images, see our [Marketing Slicks][MOD:markt]
* Discussions and news on this mod: See [Discussions][MOD:discu] or [KSP Forums][MOD:forum]
* Changelog Summary for more details of changes: See [ChangeLog][MOD:chlog]
* Known Issues for more details of feature requests and known issues : See [Known Issues][MOD:issue]
* GitHub Pages : See [Pages][MOD:pages]



### Help Wanted

> * Compatibility patches
> * Contracts for these glorious parts
> * Variant Textures
> * Marketing Images and Videos such as hero shots, animated gifs, short highlight
> * Have a request? Glad to have them, kindly submit through [GitHub][MOD:issue].

---

### Localization

>* ![English][EN] English
>* ![Français][FR][FR] French (Français)
>* ***your translation here***
>
> HELP WANTED - See the [README in the Localization folder][lreadme] or the [Quickstart Guide][qstart] for instructions for adding or improving translations. [GitHub][GitHub:url] push is the best way to contribute. *Additions and corrections welcome!*

---

### Installation Directions [^1]

***Use***
  CurseForge/OverWolf App (currently does not install dependencies)
  <a href="https://download.curseforge.com/">
    <img src="https://www.overwolf.com/brand-guidelines/img/logo2.svg" alt="CurseForge/OverWolf App" width="15%" height="15%">
</a>

I take no part, nor am I interested in maintaining the [CKAN][ckan] mod metadata for my mods.

[CKAN][ckan] is a great mod for those that can't use zip tools.

If you are having issues please let the [CKAN][ckan] people know and refer to the [CKAN][ckan] thread.

My support of [CKAN][ckan] extends as far as me checking the checkbox in Spacedock when I upload.

Beware, [CKAN][ckan] *can* really mess up though it tries very, very, very hard not to.

or [![CKAN][CKAN:img]][ckan]

### Dependencies

* [Kerbal Space Program][KSP:url] [![Kerbal Space Program][KSP:shd]][KSP:url] [^2]

## Recommends

* Either [^3]
  * [Module Manager][mm]
  * [Module Manager /L][mml]

### Supports

* [On Demand Fuel Cells (ODFC)][ODFC]
* [GPO (Goo Pumps & Oils') Speed Pump (GPO)][GPO]

### Suggests  

* [SimpleConstructon! (SCON!)][SCON]
* [SimpleLogistics! (SLOG!)][SLOG]
* [Not So SimpleConstructon! (NSSC)][NSSC]
* [Keridian Dynamics Vessel Assembly (KDVA)][KDVA]
* [The Gold Standard! (GOLD)][GOLD]
* [Stork Delivery System (SDS)][SDS]
* [KaboOom! (BOOM][BOOM] another way to not go to space today  

* [Komplexity (KPLX)][KPLX]
* [MoarKerbals(MOAR)][MK]
* [Biomatic (BIO)][BIO]
* [KGEx (KGX)][KGX]

### Tags

parts, physics, plugin, config

<div style="border:0.5px solid Tomato; background-color: #BADA55; color: #FF0000; text-align:center">
  <p><b>red box below is a link to forum post on how to get support</b></p>
  <a href="https://forum.kerbalspaceprogram.com/index.php?/topic/83212-*">
    <p><img src="https://i.postimg.cc/vHP6zmrw/image.png" alt="How to get support"></p></a>
  <p style="color: #000000;">Be Kind: Lithobrake, not jakebrake! Keep your Module Manager up to date</p>
</div>

### Credits and Special Thanks

* [Sparkle][sparkle] for developing this glorious addon!
* [4x4cheesecake][4x4cheesecake] ] for continuing where [Sparkle][sparkle] left off
> [`Lisias`][lisias] for the Brazilian-Portuguese (br-pt.cfg) localization!
> @IBM Watson for French, Italian, Japanese, Korean, Swedish, and Norwegian localization (corrections solicited and welcome!)
* see [Attribution.md][MOD:attr] for more comprehensive list

### Legal Mumbo Jumbo (License *provenance*)

#### Current (2) - [`zer0Kerbal`][zer0Kerbal]

> Forum: [Thread][MOD:forum] - Source: [GitHub][GITHUB:url
> License: [![License][LIC:shd]][LIC:url] ![License][LIC:log]
>
> ##### Disclaimer(s)
>
> ***All bundled mods are distributed under their own licenses***> ***All art assets (textures, models, animations, sounds) are distributed under their own licenses***

##### see [Notices.md][MOD:notic] for more *legal mumbo jumbo*

#### Original (1) - Author: [`4x4cheesecake`][4x4cheesecake]

> Forum: [Thread][MOD:1:thread] - Download: [CurseForge][MOD:1:dnload] - Source: [CurseForge][MOD:1:source
> License: [![License][LIC:1:shd]][LIC:1:url] ![License][LIC:1:log]

#### Original (0) - Author: [`Sparkle`][sparkle]

> Forum: [Thread][MOD:0:thread] - Download: [File][MOD:0:dnload] - Source: [File][MOD:0:source
> License: [![License][LIC:0:shd]][LIC:0:url] ![License][LIC:0:log]

---

### DONATIONS: How to support this and other great mods by [`zer0Kerbal`][zer0Kerbal]
> ***Completely voluntary, absolutely amazing, and really does help me out a lot!***
> quote from <a href="https://forum.kerbalspaceprogram.com/index.php?/profile/32393-*/"><img border="0" alt="cybutek" src="https://kerbal-forum-uploads.s3.us-west-2.amazonaws.com/monthly_2020_06/kappa-kerbal-anarchy.thumb.png.673a2f6f7b36cc60a35c24efef217246.png" width="25px" height="25px"> cybutek</a> creator of <a href="https://forum.kerbalspaceprogram.com/index.php?/topic/17833-130-*/" alt="Kerbal Engineer Redux (KER)"> Kerbal Engineer</a>

[![Support][PAYPAL:img]][PAYPAL:url] [![Github Sponsor][GSPONS:img]][GSPONS:url] [![Patreon][PATREON:img]][PATREON:url] [![Buy zer0Kerbal a snack][BMCC:img]][BMCC:url]

*and it is true.*
<!-- mod links -->
[MOD:attr]: https://zer0kerbal.github.io/Foundations/Attributions "Attribution"
[MOD:chlog]: https://raw.githubusercontent.com/zer0Kerbal/Foundations/master/changelog.md  "Changelog"
[MOD:contr]: https://github.com/zer0Kerbal/.github/blob/master/.github/CONTRIBUTING.md "Contributing"
[MOD:discu]: https://github.com/zer0Kerbal/Foundations/discussions "Discussions"
[MOD:forum]: https://forum.kerbalspaceprogram.com/index.php?/topic/209463-*/ "Foundations Forum Thread"
[MOD:issue]: https://github.com/zer0Kerbal/Foundations/issues "Issues"
[MOD:licns]: https://github.com/zer0Kerbal/Foundations/blob/master/LICENSE "Github License"
[MOD:markt]: https://zer0kerbal.github.io/Foundations/Marketing "Marketing Slicks"
[MOD:notic]: https://zer0kerbal.github.io/Foundations/Notices "Notices"
[MOD:parts]: https://zer0kerbal.github.io/Foundations/PartsCatalog "Parts Catalog"
[MOD:pages]: https://zer0kerbal.github.io/Foundations "GitHub Pages"

<!--- mod -->
[MOD:shd:latest]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/Foundations/master/json/mod.json

[MOD:pages:shd]: https://img.shields.io/badge/GitHub-Pages-white?style=plastic&labelColor=9cf&logoColor=181717&logo=github "GitHub IO"

<!--- mod provenance -->
[MOD:1:dnload]: https://github.com/4x4cheesecake/Foundations-Revived "File"
[MOD:1:source]: https://github.com/4x4cheesecake/Foundations-Revived "File"
[MOD:1:thread]: https://forum.kerbalspaceprogram.com/index.php?/topic/51430-*/ "KSP Forum"

[MOD:0:dnload]: http://happyminion.com/files/Foundations-0.2.zip "File"
[MOD:0:source]: http://happyminion.com/files/Foundations-0.2.zip "File"
[MOD:0:thread]: https://forum.kerbalspaceprogram.com/index.php?/topic/51430-*/ "KSP Forum"

<!--- license provenance -->
[LIC:1:url]: https://mit-license.org/ "Expat-MIT"
[LIC:1:log]: https://i.postimg.cc/bvjfsMP5/MIT-17x17.png "Expat-MIT"
[LIC:1:shd]: https://img.shields.io/badge/License-Expat/MIT-3DA639?labelColor=white&logoColor=3DA639&logo=OpenSourceInitiative&style=plastic "Expat-MIT"

[LIC:0:url]: https://mit-license.org/ "Expat-MIT"
[LIC:0:log]: https://i.postimg.cc/bvjfsMP5/MIT-17x17.png "Expat-MIT"
[LIC:0:shd]: https://img.shields.io/badge/License-Expat/MIT-3DA639?labelColor=white&logoColor=3DA639&logo=OpenSourceInitiative&style=plastic "Expat-MIT"

[LIC:url]: https://www.gnu.org/licenses/gpl-2.0-standalone.html "GPL-2.0"
[LIC:log]: https://i.postimg.cc/9FrwMgK6/GPL-17x17.png "GPL-2.0"
[LIC:shd]: https://img.shields.io/badge/License-GPL--2.0-A42E2B?style=plastic&labelColor=white&logoColor=A42E2B&logo=gnu "GPL-2.0"

<!--- CKAN -->
[CKAN:img]: https://i.postimg.cc/x8XSVg4R/sj507JC.png "CKAN"
[ckan]: http://forum.kerbalspaceprogram.com/index.php?/topic/197082-*/ "CKAN"
[CKAN:shd]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/Foundations/master/json/ckan.json "CKAN"

<!--- release links -->
[CURSFG:url]: https://www.curseforge.com/kerbal/ksp-mods/Foundations "Curseforge"
[CURSFG:shd]: https://img.shields.io/badge/CurseForge-Link-CCFF00.svg?labelColor=6441A4&style=plastic&logo=curseforge "Curseforge"

[GITHUB:url]: https://github.com/zer0Kerbal/Foundations/ "GitHub"
[GITHUB:shd]: https://img.shields.io/badge/Github-Link-CCFF00.svg?labelColor=181717&style=plastic&logo=github "GitHub"

[SPCDCK:url]: http://spacedock.info/mod/3091 "SpaceDock"
[SPCDCK:shd]:  https://img.shields.io/badge/SpaceDock-Link-CCFF00.svg?labelColor=181717&style=plastic&logo=data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiPz4KPCEtLSBHZW5lcmF0b3I6IEFkb2JlIElsbHVzdHJhdG9yIDE5LjAuMCwgU1ZHIEV4cG9ydCBQbHVnLUluIC4gU1ZHIFZlcnNpb246IDYuMDAgQnVpbGQgMCkgIC0tPgo8c3ZnIHZlcnNpb249IjEuMSIgaWQ9IkxheWVyXzEiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgeG1sbnM6eGxpbms9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkveGxpbmsiIHg9IjBweCIgeT0iMHB4IgoJIHZpZXdCb3g9IjAgMCA1MDAgNTAwIiBzdHlsZT0iZW5hYmxlLWJhY2tncm91bmQ6bmV3IDAgMCA1MDAgNTAwOyIgeG1sOnNwYWNlPSJwcmVzZXJ2ZSI+CjxzdHlsZSB0eXBlPSJ0ZXh0L2NzcyI+Cgkuc3Qwe2ZpbGw6IzFBMUExQTt9Cgkuc3Qxe2ZpbGw6IzA1Nzg5Mzt9Cgkuc3Qye2ZpbGw6IzA3QUNEMjt9Cjwvc3R5bGU+CjxwYXRoIGlkPSJYTUxJRF8xXyIgY2xhc3M9InN0MCIgZD0iTTQwMCwwLjZIMTAwYy01NSwwLTEwMCw0NS0xMDAsMTAwVjQwMGMwLDU1LDQ1LDEwMCwxMDAsMTAwaDMwMGM1NSwwLDEwMC00NSwxMDAtMTAwVjEwMC42CglDNTAwLDQ1LjYsNDU1LDAuNiw0MDAsMC42eiIvPgo8ZyBpZD0iWE1MSURfNl8iPgoJPGcgaWQ9IlhNTElEXzlfIj4KCQk8cGF0aCBpZD0iWE1MSURfMTdfIiBjbGFzcz0ic3QxIiBkPSJNMTgzLjMsMTY1LjljNi40LTMuNiwxNi45LTMuNiwyMy4zLDBMNDY3LjQsMzE0YzYuNCwzLjYsNi40LDkuNiwwLDEzLjJMMjA2LjYsNDc0LjQKCQkJYy02LjQsMy42LTE3LjcsNi42LTI1LDYuNmgtNDQuOGMtNy40LDAtOC4xLTMtMS43LTYuNmwyNjEtMTQ3LjJjNi40LTMuNiw2LjQtOS42LDAtMTMuMkwxNzEsMTg2Yy02LjQtMy42LTYuNC05LjYsMC0xMy4yCgkJCUwxODMuMywxNjUuOXoiLz4KCTwvZz4KCTxnIGlkPSJYTUxJRF84XyI+CgkJPHBhdGggaWQ9IlhNTElEXzE2XyIgY2xhc3M9InN0MiIgZD0iTTMxOC44LDE5Yy03LjQsMC0xOC42LDIuOC0yNSw2LjRMMzMsMTczLjRjLTYuNCwzLjYtNi40LDkuNSwwLDEzLjFsMjYwLjcsMTQ3LjEKCQkJYzYuNCwzLjYsMTYuOSwzLjYsMjMuMywwbDEyLjMtN2M2LjQtMy42LDYuNC05LjUsMC0xMy4ybC0yMjUuMS0xMjdjLTYuNC0zLjYtNi40LTkuNSwwLTEzLjJMMzY1LjYsMjUuNGM2LjQtMy42LDUuNi02LjQtMS43LTYuNAoJCQlIMzE4Ljh6Ii8+Cgk8L2c+CjwvZz4KPC9zdmc+Cg==  "SpaceDock"

<!-- Kerbal Space Program -->
[KSP:url]: https://kerbalspaceprogram.com/ "Kerbal Space Program"
[KSP:shd]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/Foundations/master/json/ksp.json&logo=data:image/webp;base64,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 "Kerbal Space Program"

<!-- links to add-ons/mods -->
[GPO]: https://forum.kerbalspaceprogram.com/index.php?/topic/207732-*/ "GPO SpeedPump (GPO)"
[ODFC]: https://forum.kerbalspaceprogram.com/index.php?/topic/187625-*/ "On Demand Fuel Cells (ODFC)"

[atp]: https://forum.kerbalspaceprogram.com/index.php?/topic/138433-*/ "JSI Advanced Transparent Pods"
[b9ps]: https://forum.kerbalspaceprogram.com/index.php?/topic/140541-*/ "B9 Part Switch"
[fs]: https://github.com/snjo/Firespitter/ "Firespitter"
[far]: https://forum.kerbalspaceprogram.com/index.php?/topic/179445-*/ "FAR"
[kas]: http://forum.kerbalspaceprogram.com/index.php?/topic/142594-*/ "Kerbal Attachment System"
[kis]: http://forum.kerbalspaceprogram.com/index.php?/topic/149848-*/ "Kerbal Inventory System"
[kjr]: https://forum.kerbalspaceprogram.com/index.php?/topic/184206-*/ "Kerbal Joint Reinforcement"
[kurs]: https://github.com/linuxgurugamer/DockingCam "KURS style docking camera"
[mas]:  https://forum.kerbalspaceprogram.com/index.php?/topic/160856-*/ "MOARdV's Avionics System"
[mm]: https://forum.kerbalspaceprogram.com/index.php?/topic/50533-*/ "Module Manager"
[mml]: https://github.com/net-lisias-ksp/ModuleManager "Module Manager /L"
[restock]: https://forum.kerbalspaceprogram.com/index.php?/topic/182679-*/ "Restock"
[rpm]: https://forum.kerbalspaceprogram.com/index.php?/topic/105821-*/ "Raster Prop Monitor"
[twk]: https://forum.kerbalspaceprogram.com/index.php?/topic/179030-*/ "TweakScale"


[MK]: https://forum.kerbalspaceprogram.com/index.php?/topic/191525*-/ "MoarKerbals"
[B9S]: https://forum.kerbalspaceprogram.com/index.php?/topic/190870*-/ "B9 Stock Switches"
[BIO]: https://forum.kerbalspaceprogram.com/index.php?/topic/191426*-/ "Biomatic"
[SDS]: https://forum.kerbalspaceprogram.com/index.php?/topic/191719*-/ "Stork Delivery System (SDS)"
[BOOM]: https://forum.kerbalspaceprogram.com/index.php?/topic/192938*-/ "KaboOom!"
[GOLD]: https://forum.kerbalspaceprogram.com/index.php?/topic/203990*-/ "[The Gold Standard! (GOLD)"
[KDVA]: http://forum.kerbalspaceprogram.com/index.php?/topic/202945*-/ "Keridian Dynamics Vessel Assembly (KDVA)"
[KGX]: https://forum.kerbalspaceprogram.com/index.php?/topic/192696*-/ "KGEx (KGX)"
[KPLX]: https://forum.kerbalspaceprogram.com/index.php?/topic/202749*-/ "Komplexity (KMPX)"
[NSSC]: https://forum.kerbalspaceprogram.com/index.php?/topic/191504*-/ "Not So SimpleConstructon!"
[SCON!]: https://forum.kerbalspaceprogram.com/index.php?/topic/191424*-/ "SimpleConstructon!"
[SLIF!]: https://forum.kerbalspaceprogram.com/index.php?/topic/191526*-/ "SimpleLife!"
[SLOG!]: https://forum.kerbalspaceprogram.com/index.php?/topic/191045*-/ "SimpleLogistics!"

<!-- financial support -->
[PAYPAL:img]: https://img.shields.io/badge/Buy%20me%20some%20-LFO-BADA55?style=for-the-badge&logo=paypal&labelColor=FFDD00/ "PayPal"
[PAYPAL:url]: https://www.paypal.com/donate?hosted_button_id=DC22YHMEJREKL/ "PayPal"
[PATREON:img]: https://img.shields.io/badge/Patreon%20-Patreonize-FF424D?style=for-the-badge&logo=patreon/ "Patreon"
[PATREON:url]: https://www.patreon.com/bePatron?u=23390503/ "Patreon"
[GSPONS:img]: https://img.shields.io/badge/Github%20-Sponsor-EA4AAA?style=for-the-badge&logo=githubsponsors/ "Github Sponsors"
[GSPONS:url]: https://github.com/sponsors/zer0Kerbal/ "Github Sponsors"
[BMCC:img]: https://img.shields.io/badge/Buy%20Me%20a%20-Snack!-FFDD00?style=for-the-badge&logo=buymeacoffee/ "Buy Me A Snack"
[BMCC:url]: https://buymeacoffee.com/zer0Kerbal/ "Buy Me A Snack"

<!-- Localization -->
[lreadme]: https://github.com/zer0Kerbal/zer0Kerbal/blob/master/Localization/readme.md "Localization Readme"
[qstart]: https://github.com/zer0Kerbal/zer0Kerbal/blob/master/Localization/quickstart.md "Quickstart"
[EN]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/EN.png "English"
[BR]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/BR.png "Português Brasil"
[CN]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/CH.png "中文"
[DE]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/DE.png "Deutsch"
[ES]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/ES.png "Español"
[FR]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/FR.png "Français"
[IT]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/IT.png "Italiano"
[JA]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/JA.png "日本語"
[KO]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/KO.png "한국어"
[MX]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/MX.png "Mexicano Español"
[NL]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/NL.png "Dutch"
[NO]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/NO.png "Norsk"
[PO]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/PO.png "Polski"
[RU]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/RU.png "Русский"
[SW]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/SW.png "Svenska"
[TR]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/TR.png "Türk"
[TW]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/master/img/TW.png "国语"

[curseforge]: https://www.curseforge.com/members/zer0kerbal/projects
[reddit]: https://www.reddit.com/user/zer0Kerbal
[twitch]: https://www.twitch.tv/zer0kerbal
[twitter]: https://twitter.com/zer0Kerbal
[youtube]: https://www.youtube.com/channel/UCp9c8IaK4Gjgfj3O9QxrbDw

[Sparkle]: https://forum.kerbalspaceprogram.com/index.php?/profile/91081-*/ "Sparkle"
[4x4cheesecake]: https://forum.kerbalspaceprogram.com/index.php?/profile/187982-*/ "4x4cheesecake"
[lisias]: https://forum.kerbalspaceprogram.com/index.php?/profile/187168-*/ "Lisias"
[zer0Kerbal]: https://forum.kerbalspaceprogram.com/index.php?/profile/190933-*/ "zer0Kerbal"

---

#### Connect with me

Track progress: issues [here][MOD:issue] and projects [here](https://github.com/zer0Kerbal/Foundations/projects/) along with **[The Short List](https://github.com/users/zer0Kerbal/projects/27)**

[<img align="left" alt="zer0Kerbal | kerbalspaceprogram.com" width="32px" src="https://cdn.icon-icons.com/icons2/1381/PNG/32/kerbalspaceprogram_93898.png" />][zer0Kerbal] [<img align="left" alt="zer0Kerbal | CurseForge" width="32px" src="https://cdn.jsdelivr.net/npm/simple-icons@v3/icons/curseforge.svg" />][curseforge] [<img align="left" alt="zer0Kerbal | reddit" width="32px" src="https://cdn.icon-icons.com/icons2/1945/PNG/512/iconfinder-reddit-4661631_122483.png" />][reddit] [<img align="left" alt="zer0Kerbal | Patreon" width="32px" src="https://cdn.icon-icons.com/icons2/2429/PNG/512/patreon_logo_icon_147253.png" />][PATREON:url] [<img align="left" alt="zer0Kerbal | YouTube" width="32px" src="https://cdn.icon-icons.com/icons2/836/PNG/512/Youtube_icon-icons.com_66802.png" />][youtube] [<img align="left" alt="zer0Kerbal | Twitch" width="32px" src="https://cdn.icon-icons.com/icons2/2699/PNG/512/twitch_logo_icon_170383.png" />][twitch] [<img align="left" alt="zer0Kerbal | PayPal" width="32px" src="https://cdn.icon-icons.com/icons2/2699/PNG/512/paypal_logo_icon_168055.png" />][PAYPAL:url] [<img align="left" alt="zer0Kerbal | Buy Me a Coffee" width="32px" src="https://www.buymeacoffee.com/assets/img/bmc-meta-new/new/favicon.ico" />][BMCC:url] [<img align="left" alt="zer0Kerbal | Twitter" width="32px" src="https://cdn.icon-icons.com/icons2/836/PNG/32/Twitter_icon-icons.com_66803.png" />][twitter]</br>

<!-- footnotes -->
[^1]: this isn't a mod. ;P  
[^2]: ***may*** work on other versions (YMMV)  
[^3]: *Be Kind: Lithobrake, not jakebrake! Keep your Module Manager up to date!*  

[IMG:hero:0]: https://i.imgur.com/DVDdgU1.png
[IMG:hero:1]: https://i.imgur.com/y0vd6WS.png


<!-- images -->
[IMG:part:0]: https://github.com/zer0Kerbal/Foundations/blob/master/GameData/KGEx/Foundations/Parts/@thumbs/foundations-1x1_icon.png?raw=true "Foundation Structural (M-1x1)"
[IMG:partinfo:0]: https://github.com/zer0Kerbal/Foundations/blob/master/img/1x1.png?raw=true "Foundation Structural (M-1x1)"
[IMG:part:1]: https://github.com/zer0Kerbal/Foundations/blob/master/GameData/KGEx/Foundations/Parts/@thumbs/foundations-2x2_icon.png?raw=true "Foundation Structural (M-2x2)"
[IMG:partinfo:1]: https://github.com/zer0Kerbal/Foundations/blob/master/img/2x2.png?raw=true "Foundation Structural (M-2x2)"
[IMG:action:0]: https://github.com/zer0Kerbal/Foundations/blob/master/img/attach.png?raw=true "Foundations PAW/RMB"

[IMG:hero:0]: https://media.forgecdn.net/avatars/429/347/637664091078128669.png
[IMG:hero:1]: https://via.placeholder.com/540x240png/000000/ffffff?text=Jeb%20wants%20this
[IMG:hero:2]: https://via.placeholder.com/540x240png/000000/ffffff?text=Bill%20wants%20this
[IMG:hero:3]: https://raw.githubusercontent.com/zer0Kerbal/Foundations/master/img/M%C3%BCnDozer.png "Bob wants his MünDozer to not float away"
[IMG:hero:4]: https://via.placeholder.com/540x240png/000000/ffffff?text=Val%20wants%20this
[IMG:hero:5]: https://via.placeholder.com/540x240png/000000/ffffff?text=Val%20wants%20this
[IMG:hero:6]: https://via.placeholder.com/800x400png/21970f/ff0000?text=Foundations

