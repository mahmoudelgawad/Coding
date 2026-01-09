// export default function TabButton(props)
export default function TabButton({children, onSelect})
{
  console.log('TabButton will render');
  return <li><button onClick={onSelect}>{children}</button></li>
}