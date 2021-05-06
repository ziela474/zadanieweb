import { Injectable } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { environment } from "./../../environments/environment";
import { Observable } from "rxjs";
import { Place } from "../models/Place";
import { ExportHistoryEntry } from "../models/ExportHistoryEntry";

@Injectable({
  providedIn: "root",
})
export class ApiService {
  getAllPlacesEndpoint = "/api/Report/GetAllPlaces";
  getExportHistoryEndpoint = "/api/Report/GetExportHistory";
  constructor(private http: HttpClient) {}

  httpOptions = {
    headers: new HttpHeaders({
      "Content-Type": "application/json",
    }),
  };
  getAllPlaces(): Observable<Place[]> {
    let url = environment.apiUrl + this.getAllPlacesEndpoint;
    console.log(url);
    return this.http.get<Place[]>(url);
  }

  getExportHistory(
    placeId: number,
    startDate: string,
    endDate: string
  ): Observable<ExportHistoryEntry[]> {
    let url =
      environment.apiUrl +
      this.getExportHistoryEndpoint +
      `?placeId=${placeId}&startDate=${startDate}&endDate=${endDate}`;
      console.log(url);
    return this.http.get<ExportHistoryEntry[]>(url);
  }
}