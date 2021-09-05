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

### Parts (two)  

###### `Foundation Structural (M-1x1)`:  
> ![Foundation Structural (M-1x1]:][IMG:part:0] ![PartInfo][IMG:partinfo:0]  

###### `Foundation Structural (M-2x2]`:  
> ![Foundation Structural (M-2x2):][IMG:part:1] ![PartInfo][IMG:partinfo:1]   

### Attach/Detach action:

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
  - KIS/KAS patches  
  - Breaking Ground integration () 
  - Additional Localizations  
  - Additional Mod Integrations

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

<p style="border:0.5px solid Tomato; background-color: lightgrey; color: #FF0000; text-align:center">Kerbal Space Program 1.12.2 — 2019.4.18f1 LTS — .NET Framework 4.7.2
</p>

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
[LICENSE:orig:shld]: https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/zer0Kerbal/Foundations/master/json/license.json&logo=creativecommons&logoColor=white&logo=data:image/svg+xml;base64,iVBORw0KGgoAAAANSUhEUgAAAQAAAAEACAYAAABccqhmAAAABmJLR0QA/wD/AP+gvaeTAAAgAElEQVR4nO2deXhV1bn/P5lDGBJJAggoIaECCWEKcwIEmaGVi7VYBtvbarVSe3u19zr8+rS3T3tr7Wy12qdOvSCipVZUREMrIJAEkJlADCZAgDAFwpwEEpL9+2MTDCHJOfustfc+J+f9PM96xOTs715w1vuu+X1DEIKNW679NwLocO3PZ6/9txa45HiNBNcIcbsCghKxQFKjEt+oJDb6c2cgxqL2BeAMUA5UNCkngdJr5RBwxfe/guAm4gD8n1AgBRgEpANpQDKmwd/S8mOOYQDHgYNACbAH2AUUACdcrJfgBeIA/I87gNHAGGAIpsFb7b39hVPAbmAHsAHYeO1ngp8gDsBdQoEM4E5Mgx+NOXRvy3yO6Qg2AKsxpxGCS4gDcJ5EYAow/dp/27rBe6II+AjIAdYDl92tTnAhDsAZhgJfAWZi9vih7lbHb6kCPgFWXCtHXa2NICgwDPgV5uKYIcVyqQfygf8Eelr8txcEVxgMPI25Gu62AbWlUoe5ZvB94Favvw1BcIBY4GFgK+4bSjCUGuBdzOlUmBffjyDYwhjgr0Al7htFsJYjwM+AXh6+K0HQQgSwAHNf2+3GL+WLUgf8A8hs+asTBN+JA57AXJV2u7FLab1sBr6GTA8EDXQFfod5Lt7thi3FWtkPfBeIvOlbFQQPJGBu4V3C/YYsRa0cBL4NhCMIHrgF+DlwEfcbrhS9pRi4D5kaCM0QDjyGeS/e7YYqxd6yF/PuhYAcBQaYhjnPT3W7IrqJjo4mPj6e+Ph4IiMjiYuLAyAqKoqYmBsvGJ4/f576+nquXr3KxYsXqaqqoqKigoqKCurq6tyovt0sBx7HPLQVtASzA0jFNPxpblfEF6KiokhJSSEpKYlevXrRq1cvkpKSSEpK4tZbbyU+Pp727dtredfZs2c5ffo0x48fp7S0lIMHD1JaWsqBAwcoLS2lrKyM+vp6Le9ymBrgecxp33mX6+IKwegAooD/BzxJgKwQ9+7dm/T0dAYMGMCgQYNIT0/nS1/6EuHh/rGuVVlZyd69e9m9ezcFBQUUFBSwa9cuzpw543bVvOUY8D3ME4ZBRbA5gCzgJaC/2xVpiXbt2jFs2DDGjBlzvSQkJLhdLZ8oKSkhLy+P/Px88vPzKSws9PeRwjvAI5gRjoKCYHEAnYBfYu4L+9VV3LCwMDIzM5k2bRrZ2dkMGzaMiIgIt6tlC+fOnSM3N5dVq1aRk5NDSYlfTr/PYa4NvIK5aCgEONOAw7i/+ny9xMbGGvfdd5/x1ltvGRUVFUawUlxcbDz//PPG5MmTjbCwMNe/lyZlDdDb51YnuE57zOF+Pe43JqNjx47G/Pnzjffee8+4fPmy27bnd5SXlxt//vOfjQkTJviTM7gIfEelEQruMBzYh8sNKCQkxJgwYYKxZMkSo6qqym0bCxiOHj1qPPPMM0afPn3cdgANZTnm6VDBzwnDXOGvwcUG07VrV+OJJ54wiouL3balgKa+vt5Ys2aNMX/+fCMqKsptJ3AMM4aj4Kf0xAwq6VojGT16tLFs2TKjpqbGbdtpc1RUVBi//vWvjdtuu81NJ1AP/IEA2T4OJiZgZrBxvFGEhoYad999t5GXl+e2jQQFNTU1xuuvv24MHjzYTUeQD/TQ0XAFNUKA/8LMaedoI4iOjjYeeeQRY//+/W7bRNCyevVqY9q0aW45gRPAeC2tWPCJDsDfcfiLj4yMNB5++GHjyJEjbrd/4Rq5ubnGxIkT3XACtZiXyASH6YWZg86xLzs8PNx44IEHjNLSUrfbu9ACa9euNbKystxwBK9jHjEXHGA45lFNx77g2bNny4p+APHRRx8ZqampTjuBTzCzMAs28m84GKVnyJAhxtq1a91uz4IP1NbWGi+88IKRkJDgpBMowszkLNjAfwJXceCLvPXWW41XX33VqKurc7sdC4qcPXvWePTRR43w8HCnnEA5MEpryxd4Gge+vNDQUGPhwoXG2bNn3W63gmb27NljZGZmOuUEKpFDQ1oIAf6IA19a//79jQ0bNrjdTgUbqaurM/70pz8ZnTp1csIJXMGcsgo+EsYXVzJtK2FhYcaPfvQjuaATRBw5csSp8wO1wHzNdhEUhANLsfkLSkpKMnJzc91uj4IL1NfXG88995wRHR1ttxOoAx7UbSBtmTAcMP558+YZ586dc7sdCi6zZ88eY+DAgXY7gXrM3ASCB0KAV7Hxy4iJiTEWL17sdrsT/IjLly8bCxcutNsJXAW+rt1i2hjPYeOXkJKSYuzcudPt9ib4KYsWLTLatWtnpxOoAWbZYDdtgl9jo/HPnDlTtvcEj+zYscPo3bu3nU7gCrJFeBNPYtM/eEhIiPHTn/5UDvUIXlNRUWFMnz7dTidQCYy0w5ACkbuw6YRfdHS08fe//93t9iQEIFevXjUeeeQRO53ACcwgNq7idqLEkcAKbLhJlZiYSE5ODlOnTtUtLQQBoaGhzJgxg7i4OD7++GMMw9D9ig7AZMwdryu6xb3FzbwAfTAjqyTqFu7bty8rV64kJUXuZQjqvPvuuyxYsIDKyko75NcA0zEXCB3HLQcQB2zBdAJaycrK4r333qNzZ7mZKehjy5YtfPnLX6a8vNwO+cXAN+0Q9oQbWXIigH9gg/FPmTKFVatWifEL2hk+fDjr1q2je/fudsh/A3Mh3HHccAC/xYb87LNmzeL999+/Ke21IOiiX79+5Obm0ru3LQmDfgHMsEO4NZyeAtyHOdzRyty5c1m8eLHfZMsV2jZHjx5l0qRJFBUV6ZY+BwwD9usWbgknHcBgIA/Q2kV/+9vf5qWXXiIszO0NDSGYKC8vZ9KkSRQUFOiW3g2MBqp0CzeHUw6gM7AVzckW586dy+uvvy7GL7hCeXk5Y8eO5fPPP9ct/SYwT7doczixBhACvIFm4589e7YYv+AqXbp0YfXq1XasCcwF/kO3aHM4MQJ4DPidTsFp06bx3nvvERkpGZoE99m/fz/Z2dmUlZXplL2CGVtwp07RptjtAAYDm9GYS23ChAl88MEHstov+BVFRUWMGzeOU6dO6ZQtxAyDb9t6gJ1TgBjMob82409PT2f58uVi/ILf0a9fP1asWKG7baZibpvbhp0O4LeYfwEtJCYmsnLlSmJjY3VJCoJWRo4cydKlSwkJ0Tqw/i7wFZ2CjbFrBW06ZhplLf8SMTExrFq1itRUbf5EEGyhX79+REVFsXr1al2SIcAk4K/YMBWwwwF0AD7CPO+vhSVLlsitPiFgyMrKorS0lF27dumSbI+ZjvwdXYIN2DEFeBq4XZfYo48+ypw5c3TJCYIjvPjiiwwZMkSn5Hxgmk5B0L8LMBrIRZNjGT9+PKtXr5a9fiEgKS0tZdiwYVRUVOiSPAQMwMyPqQWdlhUFrAS66BDr3r07a9asoUOHDjrkBMFx4uLiGDRoEEuXLtUVUCQOc4qdo0MM9DqAx9EU9jg0NJR3332XtLQ0HXKC4Bp9+vShqqqKvLw8XZLDMKNondAhpmsK0AMzNbKW7vrxxx/nV7/6lQ4pQXCdmpoaxowZw7Zt23RJbgDGY8YWVEKXA/g/NEU0ycjIID8/X475Cm2KoqIihg0bpjOs2Bzg76oiOqYAI4Dn0eBM2rdvT05ODl27dlWvlSD4EQkJCSQkJPDBBx/okhwJ/AUzorbPqDqAEOBt4DZFHQD++Mc/Mn36dB1SguB3ZGRksH37dl3Xh2MxLwytVxFR7bXnAH9T1ABg7NixrFu3TvcxSkHwK8rKykhLS+PChQs65CqBFOCkrwIqI4AwYBkawnpHR0fz4YcfkpCQoColCH5Np06diIuLY+XKlTrkIoFwYJWvAioHduYB/RWev85PfvIT+vbtq0NKEPye7373u2RlZWmTw9yF8wlfx9vhmNt+ypk3Bg0axJYtW4iIiFCVEoSAoaioiMGDB3PlipakQC8C3/PlQV+nAPejYdsvJCSE5cuX06tXL1UpQQgoEhISqKmpYf16pTW8BgYBSzCjClvClxFAOFACKFvtN77xDRYtWqQqIwgBSVVVFf379+fw4cM65F4CHrL6kC8jgHuAB3x47gY6dOjA8uXL6dSpk6qUIAQkERERdO3alXfe0XLLNxV4GXNnwGt8WQTUksLoySefpEcPn9cuBKFNMHfuXDIzM3VItQO+b/Uhq1OAbGCt1Zc0pXfv3hQWFhIdHa0qJQgBz9atWxk5ciT19fWqUqcxY3FUe/uA1SnA88AdFp+5CRuCJQhCwNK9e3dKSkrYvXu3qlQM5qGgT719wMoIIBXYY/GZm0hPT2fnzp2EhrqRl1QQ/JOSkhL69+/P1atKR/vBXKDvC3g1nLAyAvgFkOFLjRrzl7/8hf79tZwfEoQ2Q+fOnTly5Ajbt29XlgJ2APu8+bC3vXkCcBhzocFnMjIy2LJli5z3F4RmOHToEHfccQc1NTWqUp8AE7z5oLfj8G+gaPwAP/vZz8T4BaEFevXqxQMPKO+wg7lY71UMfW+sMQQzRVE/hQoxYsQINm/erCIhCG2eo0ePkpycrGMU8CzwqKcPeTMCyELR+AF++MMfqkoIQpunR48efP3rWkJr3ocZqLdVvBkBvA4sUKlJSkoKRUVFhIeHq8gIQlCwd+9e0tPTdUQSnge82doHPFnkLcBXVWvxgx/8wLLxP/744yxdulT11TfQt29fnSmblHjsscdYtmyZVs1p06bxyiuvWH5O9d/61Vdf9Zi56eWXX+bQoUM+v6MtcO+995Kenu7xc2lpaUyZMoVVq3y+5t/Ad/DgADzxMGbkUZ9L+/btjfPnzxtWuf/++5Xe21wJCQkxTp8+bbkudpCcnKz97zdr1iyf6qL6b718+XKP78jMzNT+9w208uabb3r9naxYsULHO+vxcGnP0xrA1zz83iP33nuv31z4MQyDdevWuV0NysrKOHDggNvVEPyY6dOn07NnT1WZEDzYcGsOoBtm7HElNG1raGPt2rVuV4FPPvnE7SoIfk5YWBjf+ta3dEjd29ovW3MAX/Pwe4+kp6czevRoFQnt+IMD8IdRiOD/3H///TqOzA+jlchdrakrp+T9zne+oyqhnb1791JeXu5qHWQEIHhDr169mDJlig6pFm25JQfQExij8sbw8HBd+5nacdMAjx07RklJiWvvFwKLBQuUduAbsOwAprfyO6+YMGECiYnKEcNtwc1pgPT+ghXuuusuHXEzBtNC8p6WjHyG6hvvvbfVtQdXcdMByPxfsELHjh2ZMUPZHAGaPajRnAOIACaqvCkiIoLZs2erSNjKvn37OH78uCvvlhGAYBVNnWmzXqQ5B5AFdFR50+TJk+ncubOKhO24MQo4ceKErrxwQhAxc+ZM2rdvrypzJ2bnfgPNOQDl7Jxf+5ry+SHbcaMnlt5f8IX27dvrSJobC9wUfbQ5BzBZ5S0hISG6ti5sxY0RgDgAwVc0rQNMavqDpg4gFvB8W6EVhgwZQvfu3VUkHKGkpISysjJH3ykLgIKvTJ06VUcwnbFNf9DUAYxCLWNwQPT+DTg5Cjh58iRFRUWOvU9oW3Tv3p1BgwapygzHzCh8naYOQOnwD5gLFoGCkw5Aen9BlWnTpqlKtAOGNv5BUweglLM4NjbW787+t4aTDiDY5/+5ubkYhmFb2bJli1L9pk6damv9DMNQPhmraR3ghoXAxg4gHBihopydnU1YmNIMQom4uDiiojxGQbpOaWkppaWl9lWoEVZGANHR0XTsqLQTK7RBRo0aRUxMjKpMiw6gP9BBRXnMGOUZhBJXr15l6NChnj/YCCdGAadOnaKwsNDrzw8dOlRHggihjREREcGIEUp9NDTp5Bs7gMGqyllZSjMIZaqqqhg1apSlZ5xwAFbn/yNGjODy5cs21UYIZDQkEu2BmTwEuNEBKG3/RUdHW+59dVNfX8/gwdb8mBMOwOr8X1NASKENoimT8HVb1+YAMjIy/CLb78CBAy19vqyszPbruVZHAGlpaTbVRAh0Ro8erSNIyPVesrGSNctpgibPpEznzp3p0aOHpWfsHAWcPn2avXv3ev35+Ph4unbtalt9hMAmLi5ORwdx0wggEVA6vuf28L+ByspKy1uRdm7RrV+/3tJwfvjw4VRVVdlWHyHwychQztF7kwNQzvzjTbxzJ/DFAdg5ArDqXEaMGCEOQGgVDbZ23d4bHECyilq7du3o27evUo10UVVVZdkBHD9+nH37vMqmbBlfHMCVK1dsqYvQNtDgADphjvqvO4A+KmqpqamuHgBqzOXLlxk6dCiRkZGeP9wIO0YBFRUV7Nmzx9IzsgUoeELTaDsFvnAASSpK/jL8B9MBREVFWZ4n2eEArM7/k5KSSExMlBGA0CrdunXTEW+zN2hyAP3791etjDYajMfqroQdC4FWt/8aDjGJAxA8kZqaqiqhzwEkJSk9rpUG47F6KrG8vNzSdp03WHUqI0eOBMQBCJ7p3bu3qkQSmA4gEsUtwORkpTVErTQYjy+3EnVOA86ePUtBQYGlZxrqXFNTo60eQttEpwPojWIOAA2V0UaDA+jSpQspKS1mRGoWnQ5g/fr11NfXe/35qKgohgwZAogDEDyjodO9vgjYbMIAb2nXrh3x8fGqldFG4+Gz1VHAunXrtJ3Btzr/z8jIuL5zITcBBU9oyBzcE0wHoBS/OyEhQbUiWmnce1p1ABUVFezevVtLPazO/xvXVRyA4AkNuwCRQKdQrh0I8JW25ABAz27A+fPn2bVrl6VnGsdSqKurU66D0LbRNOpODAWUlPxp+A9QW1t7/c8DBw60nFBBxzqA1fk/3OgArD4rBB+a7K6zsgPwtwxAjY0nLCzs+taat/hivE2xOv9PTk6mW7du1/9fYgEInoiIiKBTp06qMuoOoEuXLqqV0EpT47V6IOjs2bPs3LlTqQ5WpxFN6ygOQPAGDesAXUKBOBWFDh2Uwghqp6kD8CVOoco04MKFC5YdSNNDS+IABG+Ii1MyXYCOoYBSmNHY2FjVStiKLxFUVBzAhg0bLC/ijRs3zuf3CcFLu3btVCU6hdJMxtC2RGxsrOUIKr4YcQNWh/+JiYn066ccjkEIQjSEBiMUMx+Az2iIU247VnvYCxcusG3bNp/eZXUBUHp/wVc0nBfpFgooJR6PiPD/AcT48eMtP+PLNODixYts377d0jPZ2dmW3yMIAPn5+aoSk5XHEOHhSgMIR8jOzracWdUXB5Cbm2t56jBhwgTL7xEETaSGAko5qKwetHGDxMREBgwYYOmZ3NzcGw4VeYPV+X/Xrl0lBLjgKqHARRWByspKTVWxF6s9bWVlpeWEk1bn/9L7C26jPAUIlIsrd955p+VnrPToly5dsrxwKA5AcJnCUECpC7c6THaL8ePH23oeIC8vz7Iz9MUpCUIDVo+5N8O/QgGlLjxQYtjHxcVdD7jhLXl5eV4H57A6/7/tttvo00cpGLMQ5ERFRalKnAgFAqML14DVHre6uprNmzd79VmZ/wtOo+PWaCig1IWfP39euRJO4YvReTMNqKysZOvWrZZ0ZfgvqFJdXa0qcSEUOKeicOnSJdVKOMbYsWMtH1zyxgHk5+dbXgsRByCocu6ckukCXAwFTqsolJeXq1bCMTp06MDw4cMtPbNx40aPmXqszv9TUlK47TalUIyCwKlTp1QlykOBMyoKZ84oPe44VqcBV65cYePGja1+xqoDkN5fUKW2tpYLFy6oypwJBSpUFCoqlB53HF+Mb/369S3+zpcDQ+IABFU02V1FKKA0jjh9WmkG4ThjxoyxvH2yYcOGFn/ny5Fh2QEQVNHkAE4rjwACzQFER0dbjha8adOmFi/5WL00lJqaSteuXS09IwhN0TD/r+HaLsARFZXq6uo2Pw2orKyksLCw2d9Z3f+X4b+ggyNHlMwWrtl9KFAKKJ0oOHDggGplHMWXIXhz8/zq6mo5/y+4wsGDB1UlDoDpAGqAYy5XxlFGjhxp+Rpzcw5gy5Ytlub/oaGhEgBE0IIGmyuFL24DlioplSo97jgRERGWw4U35wA2bdpkSWPQoEF+l0dBCEz8ygF89tlninVxHqtz8YKCgpsuBnk6H9AUGf4LumhpTcoC16cAoOgACgoKVCvjOFaNsaam5qZ8f95eFGpAFgAFHZw4cULHLkApfOEASlSUCgsLAyYwSAMZGRmWcxo0ngYcOnSI48ePe/1seHi4RAAWtKCpwy2BLxzAfhWl6upqPv/8c+UaOUlYWJhlg2zsAKxGZM3IyKBjR6Xwi4IAaHEAF7h2B6jBAexTVQyGaUDjLT+r838Z/gu60GBrRQ1/aHAAp4CjKopW4+H7A1aNsrCw8Pod7E8//dTWdwlCS/iatKYR1z1IaHM/9IW8vDyVx11h4MCBlvKs19XVsWvXLmpqaiwlAI2MjLS87SgIzXHu3Dn27t2rKnN9NVubA9i2bZvHe/P+RkhIiOWDOVu3bmXXrl1cuXLF62dGjRqlI5GjILBx40YdocB2N/xBmwO4fPlyUEwDtm7dKtt/gmvk5ubqkGl2CmAtqX0zaKqco1hdCNyyZYvl+b8cABJ0oWGqfZRGQYAaJ/b7DLgEdPBVORDXAfr370+3bt04ceKEV58vKiri4kXvkynFxMQwatQoX6snCNepqamxHHymGW7ovRqPAK42/aVV1q1bF3AHgsBaD11fX2/pKmZmZiaRkZG+VEsQbmDjxo068nDc0Es3TZWjNIY/f/685Qsy/oCdc3QZ/gu6yMnJ0SHTqgNQHsOvXLlSVcJx7HQAsgAo6OKjjz5SlagGblipb+oANgPWEtw34Z///KfK466QnJzM7bffrl23U6dODBs2TLuuEHwcO3aM3bt3e/5g62zBjP9xnaYO4DyK24E7duzg2DGl+CKuYEdPPXbsWMLCwrTrCsFHTk4OhmGoytwU3ba5dLmrVN5gGIauuYqj2DFXl+G/oAsNw3+AfzX9gXYHAPD222+rSjiOHcYqDkDQQWVlpQ4HcB646Qprcw4gF/O6oM98/PHHARcpuGfPnlrTdXfu3JlBgwZp0xOClxUrVlBZWakqs5pmMoE35wBqgTUqb6qtrWX58uUqEq6gs8fOzs4mJCREm54QvCxbtkyHTLNDiOYcAMCHqm/729/+pirhODodgAz/BR1cuHBB1/y/2al9Sw7gIxRzBaxduzagMgeD3oVAOQAk6OD999/Xcct2Jy0kAGrJAZTRzIKBFerq6njrrbdUJBynS5cupKWlKet069aN1NRUDTUSgp033nhDh0yLc4iWHECrD3nLK6+8oirhODp6bun9BR2UlpbqOljnkwP4O4rTgIKCAsux89xGx9xdHICgg9dee01H8I+ttBL0tzUHcAKwlvmyGV5++WVVCUfJzs4mNLS1fxbPyAKgoMrVq1f561//qkOq1dV4Ty1deRqwbNkyLlxQOlbgKLfccovS/v3tt99OSkqKxhoJwUhOTg5lZWWqMgbmSL5FPDmAv2HeIPKZyspKFi1apCLhOCo9uAz/BR386U9/0iGzBjjU2gc8OYCzgPK53meffTagAoWoGLEM/wVV9uzZo2vx71VPH/Bmsqs8iT9w4ADvvPOOqoxjjBs3jvDwcM8fbAZxAIIqv/nNb3Tc/KsAPBqdNw5gA40yifjK7373O1UJx+jYsaNP9/j79OlDz549baiRECwcPXpU1/mZxYDH2PXeLncrjwI+/fRTPvxQ+YSxY/gyDZDeX1Dl6aefvikNvY94dQjHWwewGMXFQIAf//jHOoY2juCLMYsDEFQoLS3VdXjuE6DQmw966wBOA0t8rU0D27dvD5hbgr5E85UdAEGFn//857p6/2e9/aCVEy/PYu4rKvE///M/Ok432U67du0sxfNPS0ujS5cuNtZIaMuUlJSwePFiLVLACm8/bPXC+grgyxafuYk33niDefPmqcoIwnWOHTvGSy+95PPzffr0YcGCBRprZI377ruPJUuUB9kA3we8PkRg1QFkA2stPnMTvXv3prCwkOjoaFUpQQh4tm7dysiRI3WMjE8Dt2Nhvc5qyNpS4C7gVovP3cC5c+eIjo5m3LhxKjKCEPAYhsGcOXM4fPiwDrnfA5ZOEPkSs2oOHi4YeEOHDh0oKiqiR48eqlKCELAsXbqU+fPn65CqBnoBp6w85EvQ+n3AN4A4H569Tk1NDadOnWL27NkqMoIQsFRVVTFr1ixdl+Vew4fLe77ce70K/MKH525iyZIlAZlLUBB08Mwzz+i48Qdmtp9f+vKgr2FrwzHTiSvH0R44cCBbt24lIiJCVUoQAoaioiIGDx7MlSseT+t6w4vA93x50Ne8VfXAOUB5/H7y5EmioqJkQVAIGgzD4O677+bgwYM65Kox1+Uu+vKwSuD6MMw8gv0VNACIjo5m586d9O3bV1VKEPyeP//5zyxcuFCX3B+Ax3x9WDVzhZYdAYCsrCzWr18vyTSENk1ZWRlpaWm6Fv4qgWTA5/j7qqlrC4GpgPId2MOHD9OlSxeGDx+uKiUIfsv8+fMpKFBKwN2Y/6WFjD/eoqO7HQ5s1qEVExPDtm3b6Nevn3qtBMHPeOmll3jooYd0yR0G+gJKWUN0jbf/D/imDqGMjAzy8/Mt38QTBH+mqKiIjIwMqqqqdEnOwUPAT29QnQI0sBl4CFC22uPHj3PlyhUmT56sXitB8ANqamqYMWOGruO+YEbp+m8dQrocwCXMq8KTdIht2rSJrKwskpOTdcgJgqs89dRT/OMf/9AlV4e5/X5Ch5jOJfdIYDugnlwP6N69Ozt27JA79kJAk5OTw4wZM3RGwnoWeFSXmO49t9FALr4dMb6JcePGsXr1ap8j9AqCmxw8eJBhw4Zx5swZXZKlQDrmiFsLuqYADZQB8cBIHWKHDh3i0qVLTJ06VYecIDhGVVUVU6dO1XXar4GvYx7B14ZuBwDmCGA+ircFG9i0aRP9+vVjwIABOuQEwRHuv/9+Xck9Gngd+MMjre8AAAk9SURBVK1OQdA/BWhgGvChLv2YmBjWrFnDyJFaBhaCYCvPPPMMTz31lE7Jcsy1tdM6RcE+BwDmDaWHdYklJiayceNGSbwp+DVvvvkm8+fP17noZ2BG4fpAl2Bj7HQA7TBzk6fqEkxPT2fDhg3ExsbqkhQEbWzevJk777xT52EfULjq6w1237wZhHlIKEqX4Pjx4/nwww+JiYnRJSkIyhQWFpKdnc2pU5YicnmUBYahISlPS9ixCNiYk0AV5oUhLRw6dIht27YxZ84cwsLsrr4geKakpISJEydy4oSWszkNXMFcSzuqU7QpTljQJswLQ1/SJbh//3727t3LPffcQ2ioliMHguATZWVlTJgwgSNHjuiWfgwLCT58xanL97dgrgdoPds7b948Fi9eLCMBwRXKy8vJysqiuLhYt/QbgCNZSpyynMvAOsxowtqC/xUUFHD06FFmzpwpIwHBUcrLy5k0aRKffab1XA7ALuDfgFrdws3hZNd5EvMO8906RXfs2EFxcTGzZs0SJyA4QllZGXfeeSeFhV4l4LXCWWAiChF+rOL02Hk35nTA+6ybXrBnzx52797N7Nmz5d6AYCsHDhwgOzubkpIS3dJ1wD3AFt3CreFGAL5wYBVwp27hSZMm8d5778kWoWALn332GZMmTeLYsWN2yD8J/MoO4dZwKwJnLOaioHJegaZkZmby/vvv07lzZ93SQhDz6aefMnPmTE6f1n4aF8yIWt+yQ9gTbk2azwPTsZjHzBvy8vIYNWoU+/fv1y0tBCnLly8nOzvbLuNfgxlNyxXcXDUrAb6CeVBIK8XFxYwaNYr8/Hzd0kKQ8fvf/5577rmH6mpbDuMVYC6K19ghHijchZlv0NBdoqOjjWXLlhmCYJWrV68aCxcu1N4mG5UjaAinr4o/nKDZh5nWSHvUj6tXr/L2229jGAbjxo2TpCOCV1RUVPDVr36Vt956y65XVAGTgc/tekEg8kvs87bGjBkzjDNnzrjdsQh+zrZt24ykpCQ7e/7LaAqe2xZ5DhudQHJysrFjxw6325jgp7z22mtGdHS0ncZ/BXPKK7RACPAqNjqBmJgYY9GiRW63NcGPqK6uNh588EE7Dd/AXOe6V7vFtEHCgDex98sw5s2bZ5w7d87ttie4zO7du420tDS7jb8e+LZuQ2nLRABLsdkJ9OrVy1i/fr3bbVBwgfr6euMPf/iD3UP+hp7/Qd0GEgyEAa9gsxMICwsznnrqKaO6utrtNik4xOHDh40pU6bYbfgG5o2+eZrtIqgIwcyEYvuX1bdvXxkNtHHq6uqM5557zujYsaMTxn8ZmKXXHIKX/8UBJxASEmI89NBDxtmzZ91uq4JmCgoKjFGjRjlh+AZm5h7Z6tPMf2DTicGmJSEhwXjhhReM2tpat9utoMipU6eMhQsXGuHh4U4Z/0k0ZcYSbuYuvshEbHsZPHiwsXbtWrfbsOADtbW1xgsvvGDExcU5ZfgGZtqu3hrbu9AMw4DjOPelGrNnzzb27dvndpsWvGTlypVGamqqk4ZvAGsxg90IDnA7sAcHv+Dw8HDj3//9340DBw643b6FFvj444+NzMxMpw3fABYBkboat+AdHYBlOPxlR0REGA8++KBx+PBht9u7cI3169cb48ePd8Pwa4D/1NSeBR8IAX6Iud/q6JcfGRlpPPzww0ZxcbHb7T9o+de//mVMnDjRDcM3MKehY7W0YkGZbMzVV8cbQmhoqHH33XcbeXl5bttDUFBTU2O8/vrrxuDBg90yfAPIBbpraLeCRnoAn+BeozBGjBhhLFu2zKipqXHbTtocFRUVxjPPPGPcdtttbhp+PfBbNOa2EPQSihldtQYXHUHXrl2NJ554wvj888/dtpuApr6+3li9erUxf/58Iyoqyk3DNzBz9MnhngBhOGakIVcbTUhIiJGdnW0sWbLEqKqqctueAoajR48av/zlL42UlBS3jb6hLAfi1Zqk4DTtgb9gDtvcbkBGx44djblz5xrvvvuucfnyZbdtzO8oLy83XnzxRSM7O9sICwtz/fu6Vi4C31FphIL7TAUO4X5jul46depkLFiwwHjrrbeMiooKt23PNYqLi43nn3/emDhxoj8ZfUP5mCA41RcsUTI7YsYcfBh3Q6HfRFhYGCNGjGD69OlMnDiRjIwMoqKi3K6WLZw5c4b8/HxWrVpFTk6OHem1dHAO+C/gNUxH0KYJFgfQwBjgJSDN7Yq0RFRUFMOHDyczM5MxY8YwevRoEhMT3a6WTxQXF5Ofn09+fj65ubl89tlnGIZf29TbwPeBE25XxCmCzQGAeWTzSeBHBMjxzaSkJNLT0xkwYACDBg0iPT2dO+64w28SoV66dIk9e/ZQUFBAQUEBe/bsYdeuXZw5c8btqnlLGfA94H23K+I0wegAGuiLGWxkmtsV8YXIyEiSk5NJSkq6qdx6663Ex8fTvn17Le86e/Ysp0+f5ujRo5SWllJaWsrBgwev/7esrMzfe/aWqAH+gBlv4pLLdXGFYHYADUwDfgekul0R3URHRxMfH098fDxRUVHExsYCEBMTc9M6w6VLl6itraWuro4LFy5QVVVFRUUFFRUV1NXVuVF9u1kOPI6Zok4IcsKBhZjJSt1efZZib9mOeXRcEG4iDvgpZvZitxuqFL1lHzAfP9sFEvyTzsDTmAdB3G64UtTKfuCbmKM8QbBEIublDxkRBF4pBh5ALu4IGuiEeTjkMO43bCmtlzzgbmSoL9hABLAA2IH7DV3KF6UO+AfmQS9BcIQxwF9xMEqxlJvKEeBnQC8P35Ug2EYs8F1gK+4bRDCUGuBdYAZm+jhB8BsGAr/AXIBy21DaUqkD1gOPAF29/jYEwUWGAr8CDuC+AQViqcdc0PsBZrg3wQbkKLAzDMHMajQTyEBWqFuiCjOu4/vAB5hhuAQbEQfgPInAFGD6tf8G5l1ffRQBHwE5mMP8y+5WJ7gQB+AuoZgjgnFAJpBF23cI+zCH9nnAGqDU1doEOeIA/I87gNHXylDMW4p67vU6zylgN+YFnFxg47WfCX6COAD/JxRIBgYBA66V3kAS/hGpth44htmTfw7sBQowDf+ke9USvEEcQGATi+kIGkp8o5LY6M+dgRiL2heAM5g99mmgolE5iWnwpZgBV6/4/lcQ3OT/A1aRDZxEiAhTAAAAAElFTkSuQmCC


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
<!-- 
[UTUBE:img]:  http://img.youtube.com/vi/cJjIAE0RoK0/0.jpg
[UTUBE:url]: http://www.youtube.com/watch?v=cJjIAE0RoK0 "Kottabo Talks SimpleLogistics"
 -->

<!--
this file: GPLv2
zer0Kerbal-->