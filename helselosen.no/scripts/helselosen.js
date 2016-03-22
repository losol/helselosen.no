window.onload=function(){
    var $myGroup = $('#navigationbar');
    $myGroup.on('show.bs.collapse', '.collapse', function() {
      $myGroup.find('.collapse.in').collapse('hide');
    });

}
