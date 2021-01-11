import { Component, OnInit } from '@angular/core';
import { MaterialSubType } from '../../models/material-subtype';

@Component({
  selector: 'app-material-subtypes',
  templateUrl: './material-subtypes.component.html',
  styleUrls: ['./material-subtypes.component.css']
})
export class MaterialSubTypesComponent implements OnInit {
  materialSubTypes: MaterialSubType[] = [{ id: 1, name: "PET", materialTypeId: 1, materialTypeName:"Пластик", image: "", description: "" },
    { id: 2, name: "Полипропилен (PP)", materialTypeId: 1, materialTypeName: "Пластик", image: "", description: "" }]
  constructor() { }

  ngOnInit() {
  }

}
