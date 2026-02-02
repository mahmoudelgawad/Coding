// export default function TabButton(props)
export default function TabButton({children, onSelect, isSelected})
{
  console.log('TabButton will render');
  return <li><button className={isSelected ? 'active' : undefined} onClick={onSelect}>{children}</button></li>
}