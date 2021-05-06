export class Place {
    id: number;
    name : string;
}

export class ExportHistoryEntry {
    id: number;
    name: string;
    user: string;
    place: Place;
    exportDateTime: Date;

}