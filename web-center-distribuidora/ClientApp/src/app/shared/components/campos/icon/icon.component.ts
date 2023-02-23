import { Component } from '@angular/core';

@Component({
  selector: 'app-icon',
  templateUrl: './icon.component.html',
  styleUrls: ['./icon.component.css']
})
export class IconComponent {
  link!: string;
  linkId?: string;

  fontIcon!: string;
  title!: string;
  subtitle?: string;

  eventCount: number = 0; 
}
