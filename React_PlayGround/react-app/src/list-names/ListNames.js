export function ListNames(names){
    const namesItems = names.map(n => <li key={n}>{n}</li>);
    return(
        <ul>
            {namesItems}
        </ul>
    );
}