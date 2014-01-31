UrlRewriteToPublic
==================

Example of using URL Rewrite in IIS to remap reqquests for static files to a folder called "public", e.g. http://site.com/foo.html -> http://site.com/public/foo.html. The user never sees the change, this is an internal rewrite. 

It doesn't affect requests that aren't to physical files or directories, e.g. http://site.com/some-route doesn't get changed and will enter the application this way.

This is common on other platforms and is a nice approach to clearly indicating which files in your site's source are intended for serving directly.
