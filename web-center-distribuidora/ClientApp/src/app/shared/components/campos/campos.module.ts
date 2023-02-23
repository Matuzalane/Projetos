import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

import { InputDateComponent } from './input-date/input-date.component';
import { InputNumberComponent } from './input-number/input-number.component';
import { InputSelectComponent } from './input-select/input-select.component';
import { InputTextComponent } from './input-text/input-text.component';
import { InputTextAreaComponent } from './input-text-area/input-text-area.component';
import { IconComponent } from './icon/icon.component';

import { MaterialModule } from '../../material/material.module';



@NgModule({
  declarations: [
    InputDateComponent,
    InputNumberComponent,
    InputSelectComponent,
    InputTextComponent,
    InputTextAreaComponent,
    IconComponent
  ],
  imports: [
    CommonModule,
    FormsModule,
    MaterialModule
  ],
  exports: [
    InputDateComponent,
    InputNumberComponent,
    InputSelectComponent,
    InputTextComponent,
    InputTextAreaComponent,
    IconComponent
  ]
})
export class CamposModule { }
