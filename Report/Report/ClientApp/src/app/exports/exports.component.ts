import { Component, OnInit } from '@angular/core';
import {
  NgbDateStruct,
  NgbDateParserFormatter,
  NgbDate,
} from '@ng-bootstrap/ng-bootstrap';
import { ExportHistoryEntry } from '../models/ExportHistoryEntry';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ApiService } from '../services/api.service';
import { Place } from '../models/Place';

@Component({
  selector: 'app-exports',
  templateUrl: './exports.component.html',
  styleUrls: ['./exports.component.css'],
})
export class ExportsComponent implements OnInit {
  form!: FormGroup;

  startDate!: NgbDateStruct;
  endDate!: NgbDateStruct;
  ExportHistory: ExportHistoryEntry[] = []

  places: Place[] = [];
  selectedPlace!: number;
  constructor(
    private apiService: ApiService,
    public formatter: NgbDateParserFormatter,
    private formBuilder: FormBuilder
  ) {
    this.form = this.formBuilder.group({
      places: [''],
    });
    this.getPlaces();
  }

  getPlaces() {
    this.apiService.getAllPlaces().subscribe((data: Array<Place>) => {
      this.places = data;
    });
  }
  submit() {
    let startDate = NgbDate.from(this.startDate);
    let endDate = NgbDate.from(this.endDate);
    if (startDate == null || endDate == null) {
      alert('Wrong date');
      return;
    }
    if(startDate?.after(endDate)){
      alert("Wrong date range");
      return;
    }
    if(!this.selectedPlace){
      alert("Select place");
      return;
    }
    this.loadExportHistory();
  }

  loadExportHistory(){
    this.apiService.getExportHistory(this.selectedPlace, 
      this.formatter.format(this.startDate), 
      this.formatter.format(this.endDate)).subscribe((data: Array<ExportHistoryEntry>) => {
      this.ExportHistory = data;
      console.log(data)
    });
  }

  ngOnInit(): void {}
}
