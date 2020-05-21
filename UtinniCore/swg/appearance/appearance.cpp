#include "appearance.h"

namespace swg::cellProperty
{
using pGetParentCell = DWORD(__thiscall*)(utinni::CellProperty* pThis);
using pSetPortalTransitions = void(__cdecl*)(bool enabled);

pGetParentCell getParentCell = (pGetParentCell)0x00B22C00;
pSetPortalTransitions setPortalTransitions = (pSetPortalTransitions)0x00B2A990;
}

namespace swg::portalPropertyTemplate
{
using pGetCrc = int(__thiscall*)(utinni::PortalPropertyTemplate* pThis);
using pGetCellCount = int(__thiscall*)(utinni::PortalPropertyTemplate* pThis);
using pGetExteriorAppearanceName = const char* (__thiscall*)(utinni::PortalPropertyTemplate* pThis);

pGetCrc getCrc = (pGetCrc)0x00B47BD0;
pGetCellCount getCellCount = (pGetCellCount)0x00B47BE0;
pGetExteriorAppearanceName getExteriorAppearanceName = (pGetExteriorAppearanceName)0x00B47C90;
}

namespace swg::portalPropertyTemplateList
{
using pGetPobByCrcString = utinni::PortalPropertyTemplate* (__cdecl*)(utinni::PersistentCrcString* pobCrcString);
pGetPobByCrcString getPobByCrcString = (pGetPobByCrcString)0x00B497E0;
}

namespace utinni
{
DWORD CellProperty::getParentCell()
{
    return swg::cellProperty::getParentCell(this);
}

void CellProperty::setPortalTransitions(bool enabled)
{
    swg::cellProperty::setPortalTransitions(enabled);
}

int PortalPropertyTemplate::getCrc()
{
    return swg::portalPropertyTemplate::getCrc(this);
}

int PortalPropertyTemplate::getCellCount()
{
    return swg::portalPropertyTemplate::getCellCount(this);
}

const char* PortalPropertyTemplate::getExteriorAppearanceName()
{
    return swg::portalPropertyTemplate::getExteriorAppearanceName(this);
}

PortalPropertyTemplate* PortalPropertyTemplateList::getPobByCrcString(PersistentCrcString* pobCrcString)
{
    return swg::portalPropertyTemplateList::getPobByCrcString(pobCrcString);
}
}