import { Component, OnInit } from '@angular/core';
import { MaterialType } from '../../models/material-type';

@Component({
  selector: 'app-material-types',
  templateUrl: './material-types.component.html',
  styleUrls: ['./material-types.component.css']
})
export class MaterialTypesComponent implements OnInit {
  materialTypes: MaterialType[] = [{ id: 1, name: "Пластик", image: "", description:"" },
  { id: 2, name: "Металл", image: "", description: "" }]
  constructor() { }

  ngOnInit() {
  }

}
