export const implement = ()=>{
    //#with parentheses will called immediately
    //setTimeout(removeULItems(),6000);

    setTimeout(removeULItems,6000);
};

const removeULItems = ()=>{
    //# DOM abbreviation for (Document Object Model)
    //# select/get first element in the current document 
    const list = document.querySelector('ul');
    list.remove();
    console.log("UL items removed!");
};