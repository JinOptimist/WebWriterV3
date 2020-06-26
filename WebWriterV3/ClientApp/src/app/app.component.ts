import { Component } from '@angular/core';
import FroalaEditor from 'froala-editor';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
  title = 'app';

  ngOnInit() {
    this.insertDropdown();
  }

  insertDropdown() {
    FroalaEditor.DefineIcon('Boom', { NAME: 'plus', SVG_KEY: 'add' });
    FroalaEditor.RegisterCommand('Boom', {
      title: 'Add tips to mind block',
      type: 'button',
      focus: false,
      undo: false,
      refreshAfterCallback: true,
      callback() {
        let text = this.selection.text();
        this.html.insert(`<a href='#' class="tips">${text}</a>`);
      }
    });
  }
}
