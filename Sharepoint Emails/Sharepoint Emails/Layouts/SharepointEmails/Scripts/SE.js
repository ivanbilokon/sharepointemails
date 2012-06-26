﻿function OpenPreviewDialog() {
    ExecuteOrDelayUntilScriptLoaded(function () {
        var regex = new RegExp("[\\?&]"+"ID"+"=([^&#]*)");
        var qs = regex.exec(window.location.href);
        var options = SP.UI.$create_DialogOptions();
        alert(qs[1]);
        options.url = SP.Utilities.Utility.getLayoutsPageUrl('SharepointEmails/PreviewPage.aspx');
        options.url += "?Source=" + document.URL+"&ID="+qs[1];
        /*alert('Navigating to dialog at: ' + options.url);*/
        options.width = 400;
        options.height = 300;
        options.title = 'Preview';
        SP.UI.ModalDialog.showModalDialog(options);
    }, "sp.js")
}
