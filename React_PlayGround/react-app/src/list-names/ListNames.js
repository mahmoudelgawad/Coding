export function ListNames(names){
    const namesItems = names.map(n => <li>{n}</li>);
    return(
        <ul>
            {namesItems}
        </ul>
    );
}