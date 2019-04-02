function getCurrentScreenSize() {
    var head = document.getElementsByTagName( 'head' )[ 0 ];
    var computed;
    if ( window.getComputedStyle ) {
        computed = window.getComputedStyle( head, null );
    } else if ( document.documentElement.currentStyle ) {
        computed = head.currentStyle;
    }
    var size = computed.fontSize;
    size = parseInt( size, 10 );
    var screenDef;
    if ( size === 10 ) {
        // small screen
        screenDef = 'ss';
    } else if ( size === 20 ) {
        // midi screen
        screenDef = 'ms';
    } else if ( size === 30 ) {
        // large screen
        screenDef = 'ls';
    } else if ( size === 40 ) {
        screenDef = 'xls';
    }
    return screenDef;
}
module.exports = getCurrentScreenSize;