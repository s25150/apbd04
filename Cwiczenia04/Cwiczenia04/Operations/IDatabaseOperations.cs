namespace Cwiczenia04.Operations;

public interface IDatabaseOperations
{
//checkIDs
//checkIfOrderExists
//checkIfAlreadyMade
//updateColumn
//InsertProductWarehouse
//getPrimaryKey

/*1. Sprawdzamy, czy produkt o podanym identyfikatorze istnieje. Następnie sprawdzamy,
czy magazyn o podanym identyfikatorze istnieje.
Wartośćilości przekazana w żądaniu powinna być większa niż 0.
2. Możemy dodać produkt do magazynu tylko wtedy, gdy istnieje zamówienie zakupu produktu w tabeli Order.
Dlatego sprawdzamy, czy wtabeli Order istnieje rekord z IdProduktu i Ilością (Amount), które
odpowiadają naszemu żądaniu. Data utworzenia zamówienia powinna
być wcześniejsza niż data utworzenia w żądaniu.
3. Sprawdzamy, czy to zamówienie zostało przypadkiem zrealizowane.
Sprawdzamy, czy nie ma wiersza z danym IdOrder w tabeliProduct_Warehouse.
4. Aktualizujemy kolumnę FullfilledAt zamówienia na aktualną datę igodzinę. (UPDATE)
5. Wstawiamy rekord do tabeli Product_Warehouse. Kolumna Price
powinna odpowiadać cenie produktu pomnożonej przez kolumnę Amount
z naszego zamówienia. Ponadto wstawiamy wartość CreatedAt zgodnie
z aktualnym czasem. (INSERT)
6. W wyniku operacji zwracamy wartość klucza głównego wygenerowanego
dla rekordu wstawionego do tabeli Product_Warehouse.*/
}