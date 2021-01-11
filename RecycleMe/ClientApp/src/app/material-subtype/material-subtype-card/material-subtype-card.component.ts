import { Component, Input, OnInit } from '@angular/core';
import { MaterialSubType } from '../../models/material-subtype';

@Component({
  selector: 'app-material-subtype-card',
  templateUrl: './material-subtype-card.component.html',
  styleUrls: ['./material-subtype-card.component.css']
})
export class MaterialSubTypeCardComponent implements OnInit {
  @Input()
  materialSubType: MaterialSubType;

  constructor() { }

  ngOnInit() {
  }

}
