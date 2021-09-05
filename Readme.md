<!-- Readme.md v1.5.1.0
Foundations (FND)  
created: 11 Aug 2018
updated: 31 Aug 2021 -->

## Download on [Curseforge][CURSFG:url] or [Github][GITHUB:url] or [SpaceDock][SPCDCK:url]. Also available on [CKAN][CKAN:url].  

# KerbGuise Experimental engineering (KGEx)

#### Brings you:

# Foundations (FND)  

## An addon for Kerbal Space Program which allows establishing a connection between parts and the ground. Prevents ground constructions from float/sliding away :)  

### Preamble by [@Sparkle][LINK:sparkle]: 
> Foundations is a mod which lets you anchor structures to the ground, just like a [real building](https://en.wikipedia.org/wiki/Foundation_(engineering)). It's goal is to help you set up more permanent buildings at your mun bases, around Kerbin or anywhere else that has land.

#### Adopted by [@zer0Kerbal][LINK:zer0kerbal], originally by [@Sparkle][LINK:sparkle], and updated by [@4x4cheesecake][LINK:4x4cheesecake]  

![Mod Version][MOD:shld:latest] ![KSP version][KSP:shld]  [![License GPLv3][LICENSE:shld]][LICENSE:url] [![GPLv3 Logo][LICENSE:logo]][LICENSE:url]  

[![Curseforge][CURSFG:shld]][CURSFG:url] [![CKAN][CKAN:shd]][CKAN:url] [![GitHub][GITHUB:shld]][GITHUB:url] [![SpaceDock][SPCDCK:shld]][SPCDCK:url]  
 
![Code][CODE:shld] ![KSP-AVC][AVC:shld] ![Validate AVC .version files][AVCVLD:shld] 


***

![Foundations (FND)][IMG:hero:0]  

***
  
### How do I use it?  

The mod currently adds two new parts to the structural tab. These parts are based on the stock structural panels and are intended to be the foundation of any structures you want to build. Right clicking on them while they are touching the ground will give you the option to attach them, fixing them in place.

###### `Foundation Structural (M-1x1)`:  
> ![Foundation Structural (M-1x1]:][IMG:part:0] ![PartInfo][IMG:partinfo:0]  
  
###### `Foundation Structural (M-2x2]`:  
> ![Foundation Structural (M-2x2):][IMG:part:1] ![PartInfo][IMG:partinfo:1]   
  
Attach/Detach action:

> ![Foundations PAW/RMB][IMG:action:0]  
  
### Why do I want this?  

> Jeb wants this because he's clumsy with his EVA suit and every time he bumps the fuel depot on Gilly it flies away...  
> ![example image needed][IMG:hero:1]

> Bill wants this because his new crane slides around when he tries to pick up that 30 ton fuel tank...
> ![example image needed][IMG:hero:2]

> Bob wants this because he's designed his ultimate kethane refinery for the Mun base and he needs it to stay put when Jeb tries to refuel his Mundozer...
> ![Mundozer example image needed][IMG:hero:3]  

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
  
***  
  
### How to support this and many other mods by [`@zer0kerbal`][LINK:zer0Kerbal]  

> Right now I need your feedback to help me decide on future direction for this and other mods. What can you build with it? What do you want to build that you can't? What parts should I provide and what features should they have? I would love to see some screenshots of your creations and hear your ideas. 

> Bonus points if you build me a Mundozer!

[![Support][PAYPAL:img]][PAYPAL:url] [![Patreon][PATREON:img]][PATREON:url] [![Github Sponsor][GSPONS:img]][GSPONS:url] [![Buy zer0Kerbal a snack][BMCC:img]][BMCC:url] 
   
*** 

### Discussions: 

*See [Discussions][MOD:disc] or [KSP Forums][MOD:threads] for discussions and news on this mod* 

*** 

### Localization  
  
> *Additions and corrections solicited and welcome!*  
  
- [x]  [![American English][EN]][EN] [American English][EN] <en-us.cfg>  
- [ ]  [![Brasil][BR]][BR] [Brazilian][BR] <pt-br.cfg>  
- [ ]  [![中文][CN]][CN] [Chinese (中文)][CN] <zh-cn.cfg>  
- [ ]  [![Deutsch][DE]][DE] [German (Deutsch)][DE]  
- [ ]  [![Español][ES]][ES] [Spanish (Español)][ES]  
- [ ]  [![Français][FR]][FR] [French (Français)][FR] <fr-fr.cfg>  
- [ ]  [![Italiano][IT]][IT] [Italian (Italiano)][IT] <it-it.cfg>  
- [ ]  [![日本語][JA]][JA] [Japanese(日本語)][JA] <ja.cfg>  
- [ ]  [![한국어][KO]][KO] [Korean (한국어)][KO] <ko.cfg>  
- [ ]  [![Mexicano][ME]][ME] [Mexican (Mexicano)][ME] <es-mx.cfg>  
- [ ]  [![Dutch][NL]][NL] [Dutch][NL] <nl-nl.cfg>  
- [ ]  [![Norsk][NO]][NO] [Norwegian (Norsk)][NO] <no-no.cfg>  
- [ ]  [![Polski][PO]][PO] [Polish (Polski)][PO] <pl.cfg>  
- [ ]  [![Русский][RU]][RU] [Russian (Русский)][RU] <ru.cfg>  
- [ ]  [![Svenska][SW]][SW] [Swedish (Svenska)][SW] <sw-sw.cfg>  
- [ ]  [![国语][TW]][TW] [Taiwanese (国语)][TW] <zh-tw.cfg>  

See the [README in the Localization folder][LINK:localization] for instructions for adding or improving translations for languages other than English. GitHub push is the best way to contribute.

***  
  
### Installation Directions:

- Use CKAN  
![][CKAN:img]

### Changelog Summary

- *See [ChangeLog][MOD:clog] for full details of mod changes*

### Known Issues

- *See [Known Issues][MOD:known] for full details of feature requests, and known issues*
-  landing gear with MODULE[Foundations] can be retracted while it's Foundations is still attached to the ground. `'Jeb, I think we're stuck....'` [(Issue #11)](https://github.com/zer0Kerbal/Foundations/issues/11)  
  
### Dependencies

- [x]  [Kerbal Space Program][KSP:url] [![][KSP:shld]][KSP:url]  ***may*** work on other versions (YMMV)  


### Recommends  

- [x]  [Module Manager][thread:mm]  

### Suggests  

- [x]  [SimpleConstructon! (SCON!)][thread:SCON!]  
- [x]  [SimpleLogistics! (SLOG!)][thread:SLOG!]  
- [x]  [Not So SimpleConstructon! (NSSC)][thread:NSSC]  
- [x]  [Keridian Dynamics Vessel Assembly (KDVA)][thread:KDVA]  
- [x]  [The Gold Standard! (GOLD)][thread:GOLD]  
- [x]  [Stork Delivery System (SDS)][thread:SDS]
- [x]  [Komplexity (KPLX)][thread:KPLX]  
- [x]  [KaboOom! (BOOM}][thread:BOOM] another way to not go to space today  
- [x]  [Solar Science (SOLS}][thread:SOLS]  
- [x]  [Stock Inline Lights {SIL}][thread:SIL]  
- [x]  [Mini Sample Return Capsule (MSRC)][thread:MSRC] 
- [x]  [Pteron (MSRV)][thread:MSRV] 
- [x]  [Solar Science (SOLS)][thread:SOLS]  
- [x]  [Jack-O-Lantern {JACK}][thread:JACK]  
- [x]  [MoarKerbals(MOAR)][thread:MK]  
- [x]  [On Demand Fuel Cells {ODFC)}][thread:ODFC]  
- [x]  [Field Training Facility (FTF)][thread:FTF]  
- [x]  [Field Training Lab (FTL)][thread:FTL]  
- [x]  [Docking Port Descriptions(DPD)][thread:DPD]  
- [x]  [PicoPort Shielded (PPS)][thread:PPS]  
- [x]  [Transparent Command Pods) (TCP)][thread:TCP]  
- [x]  [More Hitchhikers) (MHH)][thread:MHH]  
- [x]  [Biomatic (BIO)][thread:BIO]
- [x]  [B9 Stock Switches (B9S][thread:B9S]
- [x]  [Oh Scrap!][thread:OHS]:  
- [x]  [ScrapYard][thread:SYD]:  
- [x]  [DaMichel's AeroRadial (DAR)][thread:DAR]  
- [x]  [DaMichel's CargoBays (DCB)][thread:DCB]  
- [x]  [DaMichel's Fuselage (DMF)][thread:DMF]  
- [x]  [DaMichel's Spherical Tanks (DST)][thread:DST]  
- [x]  [Simple Cargo Solutions (SCS)][thread:SCS]
- [x]  [KerGuise Experimental Engineering (KGEx)][thread:KGEX]
- [x]  [Kerbal Changelog][thread:kcl]  
- [x]  [Community Resource Pack][thread:crp]  
  
### Supports  

- [x]  [Kerbal Change Log][thread:kcl]  
- [x]  [TweakScale][thread:tweakscale]  

### Conflicts

- [x]  none known

### Replaces

- none

### Tags

- physics, parts, addon

*** 

<div style="border:0.5px solid Tomato; background-color: lightgrey; color: #FF0000; text-align:center">
<p><b>*red box below is a link to forum post on how to get support*</b>  
<a href = "https://forum.kerbalspaceprogram.com/index.php?/topic/83212-*">
  <img src = "https://i.postimg.cc/vHP6zmrw/image.png" alt="How to get support"></br></p></a></div>
  
<p style="border:0.5px solid Tomato; background-color: lightgrey; color: #FF0000; text-align:center">Kerbal Space Program 1.12.2 — Unity 2019.2.2f1 — .NET Framework 4.7.2
</p>

[![][UTUBE:img]][UTUBE:url]

<details>
  <summary>Embedded Kottabo Youtube Video</summary>
    <iframe width="649" height="365" src="https://www.youtube.com/embed/cJjIAE0RoK0" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>
</details>
  
#### Credits
> [`@Sparkle`][LINK:sparkle] for developing this mod
> [`@4x4cheesecake`][Link:4x4cheesecake] for adopting and continuing this mod
> [`@Lisias`][LINK:lisias] for the Brazilian-Portuguese (br-pt.cfg) localization!
> @IBM Watson for French, Italian, Japanese, Korean, Swedish, and Norwegian localization (corrections solicited and welcome!)

***
 
### Legal Mumbo Jumbo (License)

#### Current

Forum: [Thread][MOD:thread]  
Source: [GitHub][GITHUB:url]  
License: ![License Expat/MIT][LICENSE:shld]][LICENSE:url] [![][LICENSE:logo] ][LICENSE:url]  
> *** All bundled mods are distributed under their own licenses***  
> *** All art assets (textures, models, animations) are distributed under their own licenses***  

### Original 

[Thread][MOD:original:thread]  
[Download][MOD:original:download]  
Source: [GitHub][MOD:original:source]  
License: ![License Expat/MIT][LICENSE:shld]][LICENSE:url] [![][LICENSE:logo] ][LICENSE:url]    
 
<!-- graphical links to downloads -->
[![][CURSFG:img]][CURSFG:url] [![][GITHUB:img]][GITHUB:url] [![][SPCDCK:img]][SPCDCK:url]  

*Be Kind: Lithobrake, not jakebrake! Keep your Module Manager up to date*

###### v0.1.3.37 original: 11 Aug 2018 0K updated: 31 Aug 2021 zed'K

<!-- graphical links to downloads -->
[![][image:rel-github]][MOD:rel-github] [![][image:rel-spacedock]][MOD:rel-spacedock] [![][image:rel-curseforge]][MOD:rel-curseforge]  

*Be Kind: Lithobrake, not jakebrake! Keep your Module Manager up to date*

###### v2.0.1.0 original: 01 Oct 2019 zed'K | updated: 16 Mar 2020 zed'K

<!-- graphical links to downloads -->
[MOD:wiki]: https://github.com/zer0Kerbal/Foundations/ "Wiki"  
[MOD:clog]: https://raw.githubusercontent.com/zer0Kerbal/Foundations/master/Changelog.cfg "Changelog"  
[MOD:disc]: https://github.com/zer0Kerbal/Foundations/discussions "Discussions"  
[MOD:known]: https://github.com/zer0Kerbal/Foundations/wiki/Known-Issues "Known Issues"  

[MOD:thread]: https://forum.kerbalspaceprogram.com/index.php?/topic/191045-* "Mod Forum Thread"  

[MOD:issues]: https://github.com/zer0Kerbal/Foundations/issues
[MOD:contrib]: https://github.com/zer0Kerbal/Foundations/blob/master/.github/CONTRIBUTING.md "Contributing"  
[LINK:localization]: https://github.com/zer0Kerbal/Foundations/blob/master/GameData/Foundations/Localization/readme.md "Localization"  
[MOD:license]: https://github.com/zer0Kerbal/Foundations/blob/master/LICENSE
[MOD:issues]:  https://github.com/zer0Kerbal/Foundations/wiki/Known-Issues
  
[MOD:shld:latest]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/Foundations/master/json/mod.json  

[CODE:shld]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/Foundations/master/json/code.json  

<!--- original mod -->
[MOD:original:source]:     https://github.com/4x4cheesecake/Foundations
[MOD:original:thread]:     https://forum.kerbalspaceprogram.com/index.php?/topic/51430-*
[MOD:original:download]:   https://github.com/4x4cheesecake/Foundations/releases/latest

[GITHUB:url]: https://github.com/zer0Kerbal/Foundations/releases/latest "GitHub"

<!--- license  -->
[LICENSE:url]: https://opensource.org/licenses/MIT "Expat-MIT"  
[LICENSE:logo]: https://i.postimg.cc/bvjfsMP5/MIT-17x17.png "Expat-MIT"
[LICENSE:shld]:  https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/Foundations/master/json/license.json&logo=data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABEAAAARCAYAAAA7bUf6AAAACXBIWXMAAA7EAAAOxAGVKw4bAAAF+mlUWHRYTUw6Y29tLmFkb2JlLnhtcAAAAAAAPD94cGFja2V0IGJlZ2luPSLvu78iIGlkPSJXNU0wTXBDZWhpSHpyZVN6TlRjemtjOWQiPz4gPHg6eG1wbWV0YSB4bWxuczp4PSJhZG9iZTpuczptZXRhLyIgeDp4bXB0az0iQWRvYmUgWE1QIENvcmUgNS42LWMxNDUgNzkuMTYzNDk5LCAyMDE4LzA4LzEzLTE2OjQwOjIyICAgICAgICAiPiA8cmRmOlJERiB4bWxuczpyZGY9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkvMDIvMjItcmRmLXN5bnRheC1ucyMiPiA8cmRmOkRlc2NyaXB0aW9uIHJkZjphYm91dD0iIiB4bWxuczp4bXA9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC8iIHhtbG5zOmRjPSJodHRwOi8vcHVybC5vcmcvZGMvZWxlbWVudHMvMS4xLyIgeG1sbnM6cGhvdG9zaG9wPSJodHRwOi8vbnMuYWRvYmUuY29tL3Bob3Rvc2hvcC8xLjAvIiB4bWxuczp4bXBNTT0iaHR0cDovL25zLmFkb2JlLmNvbS94YXAvMS4wL21tLyIgeG1sbnM6c3RFdnQ9Imh0dHA6Ly9ucy5hZG9iZS5jb20veGFwLzEuMC9zVHlwZS9SZXNvdXJjZUV2ZW50IyIgeG1wOkNyZWF0b3JUb29sPSJBZG9iZSBQaG90b3Nob3AgQ0MgMjAxOSAoV2luZG93cykiIHhtcDpDcmVhdGVEYXRlPSIyMDIwLTA0LTA1VDIxOjM5OjE3LTA1OjAwIiB4bXA6TW9kaWZ5RGF0ZT0iMjAyMC0wNC0wNVQyMTo0MDozNy0wNTowMCIgeG1wOk1ldGFkYXRhRGF0ZT0iMjAyMC0wNC0wNVQyMTo0MDozNy0wNTowMCIgZGM6Zm9ybWF0PSJpbWFnZS9wbmciIHBob3Rvc2hvcDpDb2xvck1vZGU9IjMiIHBob3Rvc2hvcDpJQ0NQcm9maWxlPSJzUkdCIElFQzYxOTY2LTIuMSIgeG1wTU06SW5zdGFuY2VJRD0ieG1wLmlpZDpjOWUxZTY1Yi03Y2IxLTQ4NGQtYTIyZi1kNWZlZGVmNTUzYjAiIHhtcE1NOkRvY3VtZW50SUQ9ImFkb2JlOmRvY2lkOnBob3Rvc2hvcDo1YmY2YjU0MC02M2EyLTlkNDYtODU3OC1jOWRjYjA4ZWQ3NjMiIHhtcE1NOk9yaWdpbmFsRG9jdW1lbnRJRD0ieG1wLmRpZDowNjk0NThmNi0xZTRiLWNjNDYtYjYzOC00YTBmYTRjNjMxYzQiPiA8eG1wTU06SGlzdG9yeT4gPHJkZjpTZXE+IDxyZGY6bGkgc3RFdnQ6YWN0aW9uPSJjcmVhdGVkIiBzdEV2dDppbnN0YW5jZUlEPSJ4bXAuaWlkOjA2OTQ1OGY2LTFlNGItY2M0Ni1iNjM4LTRhMGZhNGM2MzFjNCIgc3RFdnQ6d2hlbj0iMjAyMC0wNC0wNVQyMTozOToxNy0wNTowMCIgc3RFdnQ6c29mdHdhcmVBZ2VudD0iQWRvYmUgUGhvdG9zaG9wIENDIDIwMTkgKFdpbmRvd3MpIi8+IDxyZGY6bGkgc3RFdnQ6YWN0aW9uPSJzYXZlZCIgc3RFdnQ6aW5zdGFuY2VJRD0ieG1wLmlpZDpjOWUxZTY1Yi03Y2IxLTQ4NGQtYTIyZi1kNWZlZGVmNTUzYjAiIHN0RXZ0OndoZW49IjIwMjAtMDQtMDVUMjE6NDA6MzctMDU6MDAiIHN0RXZ0OnNvZnR3YXJlQWdlbnQ9IkFkb2JlIFBob3Rvc2hvcCBDQyAyMDE5IChXaW5kb3dzKSIgc3RFdnQ6Y2hhbmdlZD0iLyIvPiA8L3JkZjpTZXE+IDwveG1wTU06SGlzdG9yeT4gPC9yZGY6RGVzY3JpcHRpb24+IDwvcmRmOlJERj4gPC94OnhtcG1ldGE+IDw/eHBhY2tldCBlbmQ9InIiPz77pP21AAACXUlEQVQ4y4VUPWhiQRB+ihAFhShqY4JNGksbe8H6TtDGFMJxFqnuijss5bCQ2CtWamFjIYKIjZw/RAk2FoIgWpjEnCeIohfxB39mb2Z5inhJbmDYnZ1vvpmdN/sE4V85Q/2MmpJIJE2lUjmglWzx/Ez4jzhRey6Xi6XTafb4+MjG4zFfyaZz8ou4V+XbxcUFq1QqTBR4RbmfcIQ/Jfig1+vZbrc7BJMcExzbo9GIER7jPu4J5Kjzfr/PCWq1Gmw2Gw6eTqfw/PwMLy8v3F6tVkTA9/V6nUgWYrzwxev1ssFgwLCBgDZcXV3Ber0Gh8PBbalUCoVCAe7v70Gj0eyTMLvdTkRfiaSUz+fZ5eUl2Gw2GA6HHLxYLOD8/Bxub28hGAyCTqeDeDwOlIh8VE0ulyOSkoBN+hWJRJhMJoPtdgvdbhdarRZgf8BgMEA0GoVwOMwJE4kEaLVaWC6XnASvyrDKvmA2m+exWIzJ5XLu8Pl8/Artdhvwk/I9aTabhXK5DAqF4tDg2WzG0F4IarX6d7PZpLIgFApxJ+0pwGKxgMfjOTSTKiEfzg1vtljJgHpy1+v1WDKZ5ACVSsWzPT09AX5G8Pv9h8yZTOZQmdVqhVQqRcnviMTrdrv5dGGDIRAIwMPDAw+qVqt8v5fJZALFYpGCodPpMKfTSSReIlGhbrEHb03pgeT4DGeICLZiPJdro9HI5vM5Ow08lr2PcISnuNPR/2EymVij0Xj37ZCfcIR/6xF+Qh3f3NywUqnEXzBOLl/JpnPyi7h3RY36HfUn/kv6OHB/aCVbPFefBvwFqoJzo/34MwsAAAAASUVORK5CYII= "GPLv3"

[LICENSE:orig:url]:  https://opensource.org/licenses/MIT "Expat-MIT"  
[LICENSE:orig:logo]:https://i.postimg.cc/bvjfsMP5/MIT-17x17.png "Expat-MIT"  
[LICENSE:orig:shld]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/Foundations/master/json/license.json&logo=creativecommons&logoColor=white "Expat-MIT"  


[AVC:shld]:     https://img.shields.io/badge/KSP-AVC--supported-brightgreen.svg?style=plastic
[AVCVLD:shld]:    https://github.com/zer0Kerbal/Foundations/workflows/Validate%20AVC%20.version%20files/badge.svg

<!--- Support --->
[SUPPORT:img]:    https://i.postimg.cc/vHP6zmrw/image.png
[SUPPORT:thread]: https://forum.kerbalspaceprogram.com/index.php?/topic/83212-*

<!--- CKAN -->
[CKAN:img]: https://i.postimg.cc/x8XSVg4R/sj507JC.png  
[CKAN:url]: http://forum.kerbalspaceprogram.com/index.php?/topic/90246-*  
[CKAN:shd]: https://img.shields.io/badge/CKAN-Indexed-blue.svg?labelColor=black&style=plastic "CKAN"  

<!--- release links -->
[CURSFG:url]: https://www.curseforge.com/kerbal/ksp-mods/Foundations  
[CURSFG:img]: https://i.postimg.cc/RZNyB5vP/Download-On-Curse.png  
[CURSFG:shld]: https://img.shields.io/badge/CurseForge-Listed-blue.svg?labelColor=black&style=plastic&logo=curseforge "Curseforge"  

[GITHUB:url]:  https://github.com/zer0Kerbal/Foundations/  
[GITHUB:img]: https://i.imgur.com/RE4Ppr9.png  
[GITHUB:shld]: https://img.shields.io/badge/Github-Indexed-blue.svg?labelColor=black&style=plastic&logo=github "GitHub"  

[SPCDCK:url]: http://spacedock.info/mod/2312  
[SPCDCK:img]: https://i.imgur.com/m0a7tn2.png  
[SPCDCK:shld]: https://img.shields.io/badge/SpaceDock-Listed-blue.svg?labelColor=black&style=plastic&logo=data:image/svg+xml;base64,PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiPz4KPCEtLSBHZW5lcmF0b3I6IEFkb2JlIElsbHVzdHJhdG9yIDE5LjAuMCwgU1ZHIEV4cG9ydCBQbHVnLUluIC4gU1ZHIFZlcnNpb246IDYuMDAgQnVpbGQgMCkgIC0tPgo8c3ZnIHZlcnNpb249IjEuMSIgaWQ9IkxheWVyXzEiIHhtbG5zPSJodHRwOi8vd3d3LnczLm9yZy8yMDAwL3N2ZyIgeG1sbnM6eGxpbms9Imh0dHA6Ly93d3cudzMub3JnLzE5OTkveGxpbmsiIHg9IjBweCIgeT0iMHB4IgoJIHZpZXdCb3g9IjAgMCA1MDAgNTAwIiBzdHlsZT0iZW5hYmxlLWJhY2tncm91bmQ6bmV3IDAgMCA1MDAgNTAwOyIgeG1sOnNwYWNlPSJwcmVzZXJ2ZSI+CjxzdHlsZSB0eXBlPSJ0ZXh0L2NzcyI+Cgkuc3Qwe2ZpbGw6IzFBMUExQTt9Cgkuc3Qxe2ZpbGw6IzA1Nzg5Mzt9Cgkuc3Qye2ZpbGw6IzA3QUNEMjt9Cjwvc3R5bGU+CjxwYXRoIGlkPSJYTUxJRF8xXyIgY2xhc3M9InN0MCIgZD0iTTQwMCwwLjZIMTAwYy01NSwwLTEwMCw0NS0xMDAsMTAwVjQwMGMwLDU1LDQ1LDEwMCwxMDAsMTAwaDMwMGM1NSwwLDEwMC00NSwxMDAtMTAwVjEwMC42CglDNTAwLDQ1LjYsNDU1LDAuNiw0MDAsMC42eiIvPgo8ZyBpZD0iWE1MSURfNl8iPgoJPGcgaWQ9IlhNTElEXzlfIj4KCQk8cGF0aCBpZD0iWE1MSURfMTdfIiBjbGFzcz0ic3QxIiBkPSJNMTgzLjMsMTY1LjljNi40LTMuNiwxNi45LTMuNiwyMy4zLDBMNDY3LjQsMzE0YzYuNCwzLjYsNi40LDkuNiwwLDEzLjJMMjA2LjYsNDc0LjQKCQkJYy02LjQsMy42LTE3LjcsNi42LTI1LDYuNmgtNDQuOGMtNy40LDAtOC4xLTMtMS43LTYuNmwyNjEtMTQ3LjJjNi40LTMuNiw2LjQtOS42LDAtMTMuMkwxNzEsMTg2Yy02LjQtMy42LTYuNC05LjYsMC0xMy4yCgkJCUwxODMuMywxNjUuOXoiLz4KCTwvZz4KCTxnIGlkPSJYTUxJRF84XyI+CgkJPHBhdGggaWQ9IlhNTElEXzE2XyIgY2xhc3M9InN0MiIgZD0iTTMxOC44LDE5Yy03LjQsMC0xOC42LDIuOC0yNSw2LjRMMzMsMTczLjRjLTYuNCwzLjYtNi40LDkuNSwwLDEzLjFsMjYwLjcsMTQ3LjEKCQkJYzYuNCwzLjYsMTYuOSwzLjYsMjMuMywwbDEyLjMtN2M2LjQtMy42LDYuNC05LjUsMC0xMy4ybC0yMjUuMS0xMjdjLTYuNC0zLjYtNi40LTkuNSwwLTEzLjJMMzY1LjYsMjUuNGM2LjQtMy42LDUuNi02LjQtMS43LTYuNAoJCQlIMzE4Ljh6Ii8+Cgk8L2c+CjwvZz4KPC9zdmc+Cg==  "SpaceDock" 

<!-- Kerbal Space Program -->
[KSP:url]:      http://kerbalspaceprogram.com/ "Kerbal Space Program"  
[KSP:shld]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/Foundations/master/json/ksp.json&logo=data:image/webp;base64,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 "Kerbal Space Program"  


<!-- zer0Kerbal mods -->
[thread:MK]: https://forum.kerbalspaceprogram.com/index.php?/topic/191525-* "MoarKerbals" 
[thread:B9S]: https://forum.kerbalspaceprogram.com/index.php?/topic/190870-* "B9 Stock Switches"  
[thread:BIO]: https://forum.kerbalspaceprogram.com/index.php?/topic/191426-* "Biomatic"  
[thread:DAR]: https://forum.kerbalspaceprogram.com/index.php?/topic/191719-* "DaMichel's AeroRadial"  
[thread:DCB]: https://forum.kerbalspaceprogram.com/index.php?/topic/191719-* "DaMichel's CargoBays"  
[thread:DMF]: https://forum.kerbalspaceprogram.com/index.php?/topic/191719-* "DaMichel's Fuselage"  
[thread:DPD]: https://forum.kerbalspaceprogram.com/index.php?/topic/192184-* "Docking Port Descriptions"
[thread:DST]: https://forum.kerbalspaceprogram.com/index.php?/topic/191719-* "DaMichel's Spherical Tanks"  
[thread:FTF]: https://forum.kerbalspaceprogram.com/index.php?/topic/188841-* "Field Training Facility"
[thread:FTL]: https://forum.kerbalspaceprogram.com/index.php?/topic/188841-* "Field Training Lab"
[thread:JET]: http://forum.kerbalspaceprogram.com/index.php?/topic/138441-* "Jettison"  
[thread:MHH]: https://forum.kerbalspaceprogram.com/index.php?/topic/188246-* "More Hitchhikers"
[thread:NUK]: https://forum.kerbalspaceprogram.com/index.php?/topic/21466-* "Nuke Tiny Parts"  
[thread:OHS]: https://forum.kerbalspaceprogram.com/index.php?/topic/192360-* "Oh Scrap!"
[thread:PPS]: https://forum.kerbalspaceprogram.com/index.php?/topic/192187-*  "Shielded PicoPort"  
[thread:SCS]: https://github.com/zer0Kerbal/SimpleCargo "Simple Cargo Solutions (SCS)" 
[thread:SDS]: https://forum.kerbalspaceprogram.com/index.php?/topic/191719-* "Stork Delivery System (SDS)"  
[thread:SIL]: https://forum.kerbalspaceprogram.com/index.php?/topic/193050-* "Stock Inline Lights"  
[thread:SYD]: https://forum.kerbalspaceprogram.com/index.php?/topic/192360-* "ScrapYard"  
[thread:TCP]: https://forum.kerbalspaceprogram.com/index.php?/topic/187495-* "Transparent Command Pods"  
[thread:BOOM]: https://forum.kerbalspaceprogram.com/index.php?/topic/192938-* "KaboOom!" 
[thread:GOLD]: https://forum.kerbalspaceprogram.com/index.php?/topic/203990-* "[The Gold Standard! (GOLD)"  
[thread:JACK]: https://forum.kerbalspaceprogram.com/index.php?/topic/189466-* "Jack-O'-Lantern"  
[thread:KDVA]: http://forum.kerbalspaceprogram.com/index.php?/topic/202945-* "Keridian Dynamics Vessel Assembly (KDVA)" 
[thread:KGEX]: https://forum.kerbalspaceprogram.com/index.php?/topic/192696-* "KerGuise Experimental Engineering"  
[thread:KPLX]: https://forum.kerbalspaceprogram.com/index.php?/topic/202749-* "Komplexity (KMPX)"  
[thread:MSRC]: https://forum.kerbalspaceprogram.com/index.php?/topic/204186-* "Mini Sample Return Capsule"  
[thread:MSRV]: https://forum.kerbalspaceprogram.com/index.php?/topic/192742-* "Pteron (MSRV)"  
[thread:NSSC]: https://forum.kerbalspaceprogram.com/index.php?/topic/191504-* "Not So SimpleConstructon!" 
[thread:ODFC]: https://forum.kerbalspaceprogram.com/index.php?/topic/187625-* "On Demand Fuel Cells"
[thread:SILP]: https://forum.kerbalspaceprogram.com/index.php?/topic/193051-* "Stock Inline Lights Patches"
[thread:SOLS]: https://forum.kerbalspaceprogram.com/index.php?/topic/192489-* "Solar Science (SOLS)"  
[thread:SCON!]: https://forum.kerbalspaceprogram.com/index.php?/topic/191424-* "SimpleConstructon!"  
[thread:SLIF!]: https://forum.kerbalspaceprogram.com/index.php?/topic/191526-* "SimpleLife!"
[thread:SLOG!]: https://forum.kerbalspaceprogram.com/index.php?/topic/191045-* "SimpleLogistics!"  

[thread:mm]:  https://forum.kerbalspaceprogram.com/index.php?/topic/50533-* "Module Manager"
[thread:kcl]: https://forum.kerbalspaceprogram.com/index.php?/topic/179207-* "Kerbal Changelog"
[thread:twk]: https://forum.kerbalspaceprogram.com/index.php?/topic/179030-* "TweakScale"
[thread:crp]: https://forum.kerbalspaceprogram.com/index.php?/topic/83007-* "Community Resource Pack"

<!--- statics -->
[LINK:zer0Kerbal]:     https://forum.kerbalspaceprogram.com/index.php?/profile/190933-zer0kerbal/  "zer0Kerbal (zed'K)"  
[LINK:sparkle]: https://forum.kerbalspaceprogram.com/index.php?/profile/91081-sparkle/ "Sparkle"  
[LINK:4x4cheesecake]: https://forum.kerbalspaceprogram.com/index.php?/profile/187982-4x4cheesecake/ "4x4cheesecake"  
[LINK:lisias]: https://forum.kerbalspaceprogram.com/index.php?/profile/187168-lisias/ "Lisias"  

<!-- financial support -->
[PAYPAL:img]: https://img.shields.io/badge/Buy%20me%20some%20-LFO-00457C?style=for-the-badge&logo=paypal&labelColor=FFDD00 "PayPal"  
[PAYPAL:url]: https://www.paypal.com/donate?hosted_button_id=R9ACWD7VREBCY "PayPal"  

[PATREON:img]: https://img.shields.io/badge/Patreon%20-be%20a%20Patron-FF424D?style=for-the-badge&logo=patreon "Patreon"  
[PATREON:url]: https://www.patreon.com/bePatron?u=23390503 "Patreon"  

[GSPONS:img]: https://img.shields.io/badge/Github%20-Sponsor-EA4AAA?style=for-the-badge&logo=githubsponsors "Github Sponsors"  
[GSPONS:url]: https://github.com/sponsors/zer0Kerbal "Github Sponsors"  

[BMCC:img]: https://img.shields.io/badge/Buy%20Me%20a%20-Snack!-FFDD00?style=for-the-badge&logo=buymeacoffee "Buy Me A Snack"  
[BMCC:url]: https://buymeacoffee.com/zer0Kerbal "Buy Me A Snack"  

[EN]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/American-flag-sm.png "American English"  
[BR]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Brazilian-flag-sm.png "Brasil"    
[CN]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Chinese-flag-sm.png "中文"  
[DE]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/German-flag-sm.png "Deutsch"  
[ES]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Spanish-flag-sm.png "Español"  
[FR]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/French-flag-sm.png "Français"  
[IT]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Italian-flag-sm.png "Italiano"  
[JA]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Japanese-flag-sm.png "日本語"  
[KO]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/South-Korean-flag-sm.png "한국어"  
[ME]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Mexican-flag-sm.png "Mexicano"  
[NL]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Dutch-flag-sm.png "Dutch"  
[NO]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Norwegian-flag-sm.png "Norsk"    
[PO]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Polish-flag-sm.png "Polski"  
[RU]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Russian-flag-sm.png "Русский"  
[SW]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Swedish-flag-sm.png "Svenska"  
[TW]: https://raw.githubusercontent.com/zer0Kerbal/zer0Kerbal/zed'K/Localization/img/Taiwanese-flag-sm.png "国语"

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

 

<!-- youtube links -->
[UTUBE:img]:  http://img.youtube.com/vi/cJjIAE0RoK0/0.jpg  
[UTUBE:url]: http://www.youtube.com/watch?v=cJjIAE0RoK0 "Kottabo Talks SimpleLogistics"  


<!--
this file: GPLv2
zer0Kerbal-->