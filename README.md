# Bulma Umbraco 8 starter kit / theme
A free starter kit / theme based on the Bulma CSS framework for Umbraco 8 from Matt Barlow of https://jacker.io. Contains homepage, products, product detail, blog, blog detail, generic and contact page templates. This theme will get you started easily and quickly with developing your own website using Umbraco 8. 

It has the following content templates:

* Homepage
* Products listing page
* Product detail page
* People listing page
* Generic content page
* Blog listing page
* Blog detail page
* Contact page

## Important:

Change the ModelsMode in the web.config to Dll models and allow the site to work.

```
<add key="Umbraco.ModelsBuilder.Enable" value="true" />
<add key="Umbraco.ModelsBuilder.ModelsMode" value="Dll" />
```

Also don't forget to publish the content, the easiest way to do this is to publish the home node with descendants, then check the include drafts, so you don't have to go in and publish it all individually. 

Umbraco-Package-Url:
https://our.umbraco.com/packages/starter-kits/bulma-starter-kit/

Demonstration:
https://bulma.jacker.io/

## Preview:

![https://raw.githubusercontent.com/mjbarlow/Umbraco-8-Bulma-Starter-Kit/master/free-umbraco-bulma-theme.jpg](https://raw.githubusercontent.com/mjbarlow/Umbraco-8-Bulma-Starter-Kit/master/free-umbraco-bulma-theme.jpg)


## Release Notes:

**v1.0.8** (07/01/2020)
* Added XML sitemaps
* Added next / prev blog navigation 
* Added related blog articles
* Added code block type
* Added blog in-page navigation
* Added robots.txt
* Hooked up the category tags

**v1.0.7** (24/10/2019)
* Changed models mode to DLL (to separate models DLL from the project DLL)
 
**V1.0.6** (24/10/2019)
* Upgraded for compatibility with Umbraco v8.2.0

**V1.0.5** (06/05/2019)
* Fixed tags / incorrect title
* Updated homepage  - added icon CTAs / links / images
* Updated people section design 
* Built out content pages  - added title, rich text, images, cta, quote, icons list
* Added example pages with new content
* Updated blog posts - same content structure as content pages
* Added the ability to add nested content before / after main content 
 
**V1.0.4** (22/04/2019)
* Added responsive images
* Add new footer section and app settings section
* Add Font Awesome Links

**v1.0.3** (09/04/2019)
* Made nested content simpler
* Updated homepage template and sections
* Fixed install issue
* Added JS responsive menu
* Add a "columns picker" property editor

**v1.0.2** (31.03.2019):
* New contact page template
* Remove macros and grid - use elements and nested content

**v1.0.1** (22.03.2019):
* initial release



