using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using MVVMDatabinding;
using RRUI;
using RRUI.Data;
using RRUI.Dialogs;
using RRUI.Framework;
using RRUI.Framework.Views;
using RRUI.Navigation;
using RecRoom.AppUI.Data;
using RecRoom.Attributes;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.EventSystems;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.Scripting;
using UnityEngine.Serialization;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DisallowMultipleComponent]
public class SpriteFill : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	[GKBMICLOBGF(CGAFHOMJNOP.Self, false, false, false)]
	private SpriteRenderer spriteRenderer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private Sprite originalSprite;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Sprite CINKPFGPLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private float fillAmount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[SerializeField]
	private bool fillClockwise;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	private int fillOrigin;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	private AnimationCurve progressCurve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[Range(0f, 1f)]
	private float OJJMAOOKOKE;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static Vector3[] MCMNGHEILLC;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static Vector3[] DNFAIKCFOEA;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static List<Vector2> GBBBANMBAAP;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static List<ushort> HODKOFDKAJF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public float DEHGNAPBDNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xC8D960", Offset = "0xC8C160", VA = "0x180C8D960")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7D727D0", Offset = "0x7D70FD0", VA = "0x187D727D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool NFLDHBDDEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xDF5EA0", Offset = "0xDF46A0", VA = "0x180DF5EA0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7D72850", Offset = "0x7D71050", VA = "0x187D72850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int ABHGGFIHIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA46F30", Offset = "0xA45730", VA = "0x180A46F30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7D72860", Offset = "0x7D71060", VA = "0x187D72860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7D72620", Offset = "0x7D70E20", VA = "0x187D72620")]
	public void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7D72300", Offset = "0x7D70B00", VA = "0x187D72300")]
	public void ForceRegenerateSprite()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7D725E0", Offset = "0x7D70DE0", VA = "0x187D725E0")]
	private void OKOJLIPHHAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7D72270", Offset = "0x7D70A70", VA = "0x187D72270")]
	private void EOJEEBBHILK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7D72540", Offset = "0x7D70D40", VA = "0x187D72540")]
	private Vector4 KAOEBNCIINC(Sprite LMNKBMBBAAB)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7D723E0", Offset = "0x7D70BE0", VA = "0x187D723E0")]
	private Sprite HJJMLEMDGJD(Sprite FNFJALHKEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7D71690", Offset = "0x7D6FE90", VA = "0x187D71690")]
	private void DCFFJNMFGEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
	public SpriteFill()
	{
	}
}
namespace _LogRegistration.RecRoom_AppUI_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : HJMIPPBHOKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7D68BC0", Offset = "0x7D673C0", VA = "0x187D68BC0", Slot = "4")]
		public override void KELFLPPCOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_AppUI_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7D785F0", Offset = "0x7D76DF0", VA = "0x187D785F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2731690", Offset = "0x272FE90", VA = "0x182731690")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JIAOGBBBDKD
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PJEGDFJANGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string DBKNDJMEDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string PJEGNFPPICA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string DOEKGOJGHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string AACDHNMNMAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string JMBHDFNHNJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class RRUIGameObjectLayoutElement : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		protected float width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		protected float height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		protected bool FKLEMMENCIB;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool NEAIEFNBCHM
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4D0", Offset = "0xA2BCD0", VA = "0x180A2D4D0", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA2D370", Offset = "0xA2BB70", VA = "0x180A2D370", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public virtual float LLHNOIJGDIM
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x11223F0", Offset = "0x1120BF0", VA = "0x1811223F0", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public virtual float EFFPFBJNKOM
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xDD27A0", Offset = "0xDD0FA0", VA = "0x180DD27A0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xC8B0A0", Offset = "0xC898A0", VA = "0x180C8B0A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xC8B0A0", Offset = "0xC898A0", VA = "0x180C8B0A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7D6CFD0", Offset = "0x7D6B7D0", VA = "0x187D6CFD0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7D6CF90", Offset = "0x7D6B790", VA = "0x187D6CF90", Slot = "8")]
		public virtual bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
		public RRUIGameObjectLayoutElement()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[ExecuteInEditMode]
	public class RRUIGameObjectLayoutGroup : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum LayoutDirection
		{
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			Vertical,
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			Horizontal
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public enum LayoutAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			Start,
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			Center,
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			End
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private float padding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private LayoutDirection layoutDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private LayoutAnchor layoutAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private RRUIGameObjectLayoutElement centerElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private List<RRUIGameObjectLayoutElement> EICDKEMMBJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int IIOFEHBJEBH;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7D6E7D0", Offset = "0x7D6CFD0", VA = "0x187D6E7D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7D6E700", Offset = "0x7D6CF00", VA = "0x187D6E700")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7D6E700", Offset = "0x7D6CF00", VA = "0x187D6E700")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7D6D8A0", Offset = "0x7D6C0A0", VA = "0x187D6D8A0")]
		private void AFCEEKCPKLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7D6DFE0", Offset = "0x7D6C7E0", VA = "0x187D6DFE0")]
		private float JLEKGCNDJOE()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7D6DDD0", Offset = "0x7D6C5D0", VA = "0x187D6DDD0")]
		private bool IDLDOOFJAII([Out] float JMMHEDLEDHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7D6DCA0", Offset = "0x7D6C4A0", VA = "0x187D6DCA0")]
		private bool DGHFPAEPJIO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7D6D1C0", Offset = "0x7D6B9C0", VA = "0x187D6D1C0")]
		private void ACLPHPMGJCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7D6E010", Offset = "0x7D6C810", VA = "0x187D6E010")]
		private void OPGGFFJADON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7D6DB90", Offset = "0x7D6C390", VA = "0x187D6DB90")]
		private void DFCADGNKGKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7D6E710", Offset = "0x7D6CF10", VA = "0x187D6E710")]
		public void RebuildLayout()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7D6E7E0", Offset = "0x7D6CFE0", VA = "0x187D6E7E0")]
		public RRUIGameObjectLayoutGroup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class RRUIGameObjectSpriteLayoutElement : RRUIGameObjectLayoutElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private SpriteRenderer spriteRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private Sprite DIANDCJOIKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool FONFBAJDDFD;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool NEAIEFNBCHM
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7D6E9B0", Offset = "0x7D6D1B0", VA = "0x187D6E9B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override float LLHNOIJGDIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7D6EA90", Offset = "0x7D6D290", VA = "0x187D6EA90", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override float EFFPFBJNKOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7D6E8F0", Offset = "0x7D6D0F0", VA = "0x187D6E8F0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7D6E870", Offset = "0x7D6D070", VA = "0x187D6E870", Slot = "8")]
		public override bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
		public RRUIGameObjectSpriteLayoutElement()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RRUIGameObjectTextLayoutElement : RRUIGameObjectLayoutElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private TextMeshPro textComponent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private bool FONFBAJDDFD;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool NEAIEFNBCHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7D6EC30", Offset = "0x7D6D430", VA = "0x187D6EC30", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override float LLHNOIJGDIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7D6ED10", Offset = "0x7D6D510", VA = "0x187D6ED10", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override float EFFPFBJNKOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7D6EBD0", Offset = "0x7D6D3D0", VA = "0x187D6EBD0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7D6EB50", Offset = "0x7D6D350", VA = "0x187D6EB50", Slot = "8")]
		public override bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
		public RRUIGameObjectTextLayoutElement()
		{
		}
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RRUIBinder]
	public class AccountBadgeIconBinder : BaseBinder<AccountBadgeIconType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private AccountBadgeIconView accountBadgeView;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7D5E940", Offset = "0x7D5D140", VA = "0x187D5E940", Slot = "20")]
		protected override void OnDataUpdated(AccountBadgeIconType dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7D5E9E0", Offset = "0x7D5D1E0", VA = "0x187D5E9E0")]
		public AccountBadgeIconBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AccountRoleIconViewBinder : BaseBinder<AccountRoleIconType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private AccountRoleView accountRoleView;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7D60360", Offset = "0x7D5EB60", VA = "0x187D60360", Slot = "20")]
		protected override void OnDataUpdated(AccountRoleIconType dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7D60400", Offset = "0x7D5EC00", VA = "0x187D60400")]
		public AccountRoleIconViewBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RRUIBinder]
	public class CardHighlightStyleAspectRatioBinder : BaseBinder<HighlightStyle>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public class HighlightStyleAspectRatio
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public HighlightStyle Style;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public float AspectRatio;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x2789110", Offset = "0x2787910", VA = "0x182789110")]
			public HighlightStyleAspectRatio()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private AspectRatioFitter aspectRatioFitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private RecNetRawImage recNetRawImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		private List<HighlightStyleAspectRatio> aspectRatios;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7D65C50", Offset = "0x7D64450", VA = "0x187D65C50", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7D65F50", Offset = "0x7D64750", VA = "0x187D65F50", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7D65D50", Offset = "0x7D64550", VA = "0x187D65D50")]
		protected void OnImageLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "20")]
		protected override void OnDataUpdated(HighlightStyle dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7D66050", Offset = "0x7D64850", VA = "0x187D66050")]
		public CardHighlightStyleAspectRatioBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[RRUIBinder]
	public class CarouselHeightBinder : BaseBinder<float?>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[SerializeField]
		private List<LayoutElement> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		private LayoutElementSizeBinder.LayoutElementSizeTarget targetSize;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7D66090", Offset = "0x7D64890", VA = "0x187D66090", Slot = "15")]
		public override void Bind(GameObject bindingObject, bool isListItem, int listItemIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7D661B0", Offset = "0x7D649B0", VA = "0x187D661B0", Slot = "20")]
		protected override void OnDataUpdated(float? dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7D664A0", Offset = "0x7D64CA0", VA = "0x187D664A0")]
		public CarouselHeightBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[RRUIBinder]
	public class CarouselItemSizeBinder : BaseBinder<float?>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7D664E0", Offset = "0x7D64CE0", VA = "0x187D664E0", Slot = "20")]
		protected override void OnDataUpdated(float? dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7D66590", Offset = "0x7D64D90", VA = "0x187D66590")]
		public CarouselItemSizeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[RRUIBinder]
	public class CarouselItemWidthHeightBinder : BaseBinder<Vector2>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7D665D0", Offset = "0x7D64DD0", VA = "0x187D665D0", Slot = "20")]
		protected override void OnDataUpdated(Vector2 dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7D66680", Offset = "0x7D64E80", VA = "0x187D66680")]
		public CarouselItemWidthHeightBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[RRUIBinder]
	public class CarouselRowCountBinder : BaseBinder<int>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7D666C0", Offset = "0x7D64EC0", VA = "0x187D666C0", Slot = "20")]
		protected override void OnDataUpdated(int dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7D66760", Offset = "0x7D64F60", VA = "0x187D66760")]
		public CarouselRowCountBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[RRUIBinder]
	public class ConditionalPrefabSpawnBinder : BaseBinder<bool>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private struct <LoadPrefab>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public ConditionalPrefabSpawnBinder <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7D769A0", Offset = "0x7D751A0", VA = "0x187D769A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private MultiPrefabSpawner prefabSpawner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		private AssetReference prefabReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		private bool prependSpawnedObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[SerializeField]
		private bool invert;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private OBKOLGEFKBC<GameObject> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7D667A0", Offset = "0x7D64FA0", VA = "0x187D667A0", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7D669D0", Offset = "0x7D651D0", VA = "0x187D669D0", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7D66B70", Offset = "0x7D65370", VA = "0x187D66B70", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7D66920", Offset = "0x7D65120", VA = "0x187D66920")]
		[AsyncStateMachine(typeof(<LoadPrefab>d__8))]
		private void LoadPrefab()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		private void OnPopulateInstance(GameObject instance, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		private void OnCleanupInstance(GameObject instance, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7D66D30", Offset = "0x7D65530", VA = "0x187D66D30")]
		public ConditionalPrefabSpawnBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[RRUIBinder]
	public class HideableBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private Hideable hideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private bool invert;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7D66D70", Offset = "0x7D65570", VA = "0x187D66D70", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7D66E10", Offset = "0x7D65610", VA = "0x187D66E10")]
		public HideableBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RRUIBinder]
	public class HtmlColorStringToColorBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private List<Image> targetList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Color htmlColor;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7D66E50", Offset = "0x7D65650", VA = "0x187D66E50", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7D67010", Offset = "0x7D65810", VA = "0x187D67010")]
		public HtmlColorStringToColorBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[RRUIBinder]
	public class HydrationStateBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private List<HydrateBase> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private bool invert;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7D67050", Offset = "0x7D65850", VA = "0x187D67050", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7D67180", Offset = "0x7D65980", VA = "0x187D67180")]
		public HydrationStateBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[RRUIBinder]
	public class ImageKeyBinder : BaseBinder<string>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private struct <LoadImage>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public ImageKeyBinder <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public AssetReference assetReference;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private AsyncOperationHandle<Sprite> <handle>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private TaskAwaiter<Sprite> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7D766F0", Offset = "0x7D74EF0", VA = "0x187D766F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private Image targetImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private AssetReferenceLookup imageKeyLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private AssetReference currentAsset;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7D672A0", Offset = "0x7D65AA0", VA = "0x187D672A0", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7D67450", Offset = "0x7D65C50", VA = "0x187D67450", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7D67400", Offset = "0x7D65C00", VA = "0x187D67400")]
		private void ReleaseAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7D671C0", Offset = "0x7D659C0", VA = "0x187D671C0")]
		[AsyncStateMachine(typeof(<LoadImage>d__6))]
		private void LoadImage(AssetReference assetReference)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7D674B0", Offset = "0x7D65CB0", VA = "0x187D674B0")]
		public ImageKeyBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[RRUIBinder]
	public class ImposterImageBinder : BaseBinder<NGCIPJABEMC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private ImposterRawImage imposterImage;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7D674F0", Offset = "0x7D65CF0", VA = "0x187D674F0", Slot = "20")]
		protected override void OnDataUpdated(NGCIPJABEMC dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7D67580", Offset = "0x7D65D80", VA = "0x187D67580")]
		public ImposterImageBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[RRUIBinder]
	public class InfiniteListBinder : BaseBinder<DataList>, FPAIJMBGOKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		protected InfiniteListViewControllerBase infiniteList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		protected GameObject defaultPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private int sourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int listId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private HashSet<int> loadedItems;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int ItemCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xC94200", Offset = "0xC92A00", VA = "0x180C94200", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x141EEA0", Offset = "0x141D6A0", VA = "0x18141EEA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public LBOAOFAOKMM<int> OnItemAtIndexLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xA35020", Offset = "0xA33820", VA = "0x180A35020", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IReadOnlyCollection<LLINMGCFLII> VisibleItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7D681E0", Offset = "0x7D669E0", VA = "0x187D681E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7D67620", Offset = "0x7D65E20", VA = "0x187D67620", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7D676B0", Offset = "0x7D65EB0", VA = "0x187D676B0", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7D67B90", Offset = "0x7D66390", VA = "0x187D67B90")]
		protected void RefreshActiveItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7D67A90", Offset = "0x7D66290", VA = "0x187D67A90", Slot = "27")]
		public virtual void OnItemVisible(InfiniteListDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7D67A00", Offset = "0x7D66200", VA = "0x187D67A00", Slot = "28")]
		public virtual void OnItemRefresh(InfiniteListDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7D67800", Offset = "0x7D66000", VA = "0x187D67800", Slot = "29")]
		public virtual void OnItemHidden(InfiniteListDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA35070", Offset = "0xA33870", VA = "0x180A35070", Slot = "30")]
		public virtual GameObject GetPrefabForIndex(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7D675C0", Offset = "0x7D65DC0", VA = "0x187D675C0", Slot = "31")]
		public virtual bool IsItemLoaded(InfiniteListDataItem item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7D67910", Offset = "0x7D66110", VA = "0x187D67910")]
		protected void OnItemLoaded(DataListItemBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7D680E0", Offset = "0x7D668E0", VA = "0x187D680E0")]
		public InfiniteListBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[RRUIBinder]
	public class LimitedCapacityListBinder : BaseBinder<DataList>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		protected List<BaseLocalViewModel> limitedListObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		private GameObject overflowIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private TMP_Text overflowText;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7D68720", Offset = "0x7D66F20", VA = "0x187D68720", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7D68B80", Offset = "0x7D67380", VA = "0x187D68B80")]
		public LimitedCapacityListBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[RRUIBinder]
	public class MultiPrefabSpawnerListBinder : BaseBinder<DataList>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		private MultiPrefabSpawner multiPrefabSpawner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private GameObject defaultPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private int sourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int listId;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7D68DB0", Offset = "0x7D675B0", VA = "0x187D68DB0", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7D68C50", Offset = "0x7D67450", VA = "0x187D68C50", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7D69000", Offset = "0x7D67800", VA = "0x187D69000", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7D68E40", Offset = "0x7D67640", VA = "0x187D68E40", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7D68EF0", Offset = "0x7D676F0", VA = "0x187D68EF0", Slot = "21")]
		protected virtual void OnInstanceCleanupEvent(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7D68F60", Offset = "0x7D67760", VA = "0x187D68F60", Slot = "22")]
		protected virtual void OnInstanceSpawnedEvent(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7D69140", Offset = "0x7D67940", VA = "0x187D69140")]
		public MultiPrefabSpawnerListBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class PageNavigationHelper : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private Uri destinationUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[SerializeField]
		private string analyticsButtonName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private RRUIButton button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7D696A0", Offset = "0x7D67EA0", VA = "0x187D696A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7D69900", Offset = "0x7D68100", VA = "0x187D69900")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7D69840", Offset = "0x7D68040", VA = "0x187D69840")]
		public void NavigateToPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7D69B70", Offset = "0x7D68370", VA = "0x187D69B70")]
		public void SetUriData(string uriDataKey, int data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7D69A70", Offset = "0x7D68270", VA = "0x187D69A70")]
		public void SetUriData(string uriDataKey, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7D69AF0", Offset = "0x7D682F0", VA = "0x187D69AF0")]
		public void SetUriData(string uriDataKey, float data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7D699E0", Offset = "0x7D681E0", VA = "0x187D699E0")]
		public void SetUriData(string uriDataKey, Guid data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7D69BF0", Offset = "0x7D683F0", VA = "0x187D69BF0")]
		public PageNavigationHelper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class PageNavigationHelperUriDataBinder : BaseBinder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private PageNavigationHelper target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private string uriDataKey;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7D69190", Offset = "0x7D67990", VA = "0x187D69190", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7D69650", Offset = "0x7D67E50", VA = "0x187D69650")]
		public PageNavigationHelperUriDataBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RRUIBinder]
	public class PlayerColorSpriteBinder : BaseBinder<IPlayerColor>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private SpriteRenderer target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[SerializeField]
		private IPlayerUIBridge.PlayerColorType _colorType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		private Color defaultColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[SerializeField]
		[IKNPDEEBCLA("_colorType", new object[] { 3, 5 })]
		private Color customColor;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7D69C40", Offset = "0x7D68440", VA = "0x187D69C40", Slot = "20")]
		protected override void OnDataUpdated(IPlayerColor dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7D69DE0", Offset = "0x7D685E0", VA = "0x187D69DE0")]
		public PlayerColorSpriteBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[RRUIBinder]
	public class PlayerColorTextBinder : BaseBinder<IPlayerColor>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		private TMP_Text target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		private IPlayerUIBridge.PlayerColorType _colorType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[SerializeField]
		private Color defaultColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[SerializeField]
		[IKNPDEEBCLA("_colorType", new object[] { 3, 5 })]
		private Color customTextColor;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7D69E30", Offset = "0x7D68630", VA = "0x187D69E30", Slot = "20")]
		protected override void OnDataUpdated(IPlayerColor dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7D69FF0", Offset = "0x7D687F0", VA = "0x187D69FF0")]
		public PlayerColorTextBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[RRUIBinder]
	public class RecNetRawImageBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		private RecNetRawImage target;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7D6ED70", Offset = "0x7D6D570", VA = "0x187D6ED70", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7D6EE00", Offset = "0x7D6D600", VA = "0x187D6EE00")]
		public RecNetRawImageBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[RRUIBinder]
	public class RoomSourceUriLinkButtonBinder : BaseBinder<RoomListQueryData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[SerializeField]
		private Button button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		private Uri targetUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private bool useQueryDataInUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[IKNPDEEBCLA("useQueryDataInUri")]
		[SerializeField]
		private bool overrideQueryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		private RoomListQueryData queryDataOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SerializeField]
		private bool overrideLoadSceneSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[SerializeField]
		[IKNPDEEBCLA("overrideLoadSceneSource")]
		private PBGECCHHBDA loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7D71170", Offset = "0x7D6F970", VA = "0x187D71170", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7D71570", Offset = "0x7D6FD70", VA = "0x187D71570", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "20")]
		protected override void OnDataUpdated(RoomListQueryData dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7D71300", Offset = "0x7D6FB00", VA = "0x187D71300")]
		private void OnButtonClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7D71650", Offset = "0x7D6FE50", VA = "0x187D71650")]
		public RoomSourceUriLinkButtonBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[RRUIBinder]
	public class StringToWidgetWrapperBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		private WidgetWrapperViewModel widgetWrapper;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7D72890", Offset = "0x7D71090", VA = "0x187D72890", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7D72950", Offset = "0x7D71150", VA = "0x187D72950")]
		public StringToWidgetWrapperBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[RRUIBinder]
	public class VirtualizedScrollRectListBinder : BaseBinder<DataList>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int sourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private int listId;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7D77CC0", Offset = "0x7D764C0", VA = "0x187D77CC0", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7D77F30", Offset = "0x7D76730", VA = "0x187D77F30", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7D77FC0", Offset = "0x7D767C0", VA = "0x187D77FC0", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7D78330", Offset = "0x7D76B30", VA = "0x187D78330", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7D78230", Offset = "0x7D76A30", VA = "0x187D78230", Slot = "21")]
		protected virtual void OnItemVisible(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7D78190", Offset = "0x7D76990", VA = "0x187D78190", Slot = "22")]
		protected virtual void OnItemRefresh(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7D78070", Offset = "0x7D76870", VA = "0x187D78070", Slot = "23")]
		protected virtual void OnItemInvisible(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7D780E0", Offset = "0x7D768E0", VA = "0x187D780E0")]
		private void OnItemLoaded(DataListItemBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7D785A0", Offset = "0x7D76DA0", VA = "0x187D785A0")]
		public VirtualizedScrollRectListBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface IIconConfig
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		AssetReferenceT<Sprite> BackgroundFillIcon
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		AssetReferenceT<Sprite> BackgroundOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		AssetReferenceT<Sprite> BadgeIcon
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		AssetReferenceT<Sprite> BadgeOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface IIconData<T> where T : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetConfig(T enumValue, [Out] IIconConfig config);
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public abstract class EnumIconDataViewBase<T, U> : MonoBehaviour where T : Enum where U : IIconData<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private T defaultIconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		private U iconData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[Header("Image Targets")]
		[SerializeField]
		protected List<Image> backgroundOutlineImageTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		protected List<Image> backgroundFillImageTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		protected List<Image> iconOutlineImageTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		protected List<Image> iconFillImageTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		[Header("Sprite Renderer Targets")]
		protected List<SpriteRenderer> backgroundOutlineSpriteRendererTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		protected List<SpriteRenderer> backgroundFillSpriteRendererTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		protected List<SpriteRenderer> iconOutlineSpriteRendererTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		protected List<SpriteRenderer> iconFillSpriteRendererTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private T iconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private bool iconTypeSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private List<OBKOLGEFKBC<Sprite>> resourceHandles;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x47ACAB0", Offset = "0x47AB2B0", VA = "0x1847ACAB0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x47ABA50", Offset = "0x47AA250", VA = "0x1847ABA50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x47ABFD0", Offset = "0x47AA7D0", VA = "0x1847ABFD0")]
		private void ReleaseSpriteHandles()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x47AC2F0", Offset = "0x47AAAF0", VA = "0x1847AC2F0")]
		public void SetIconType(T newIconType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x47ACB70", Offset = "0x47AB370", VA = "0x1847ACB70")]
		private void UpdateIcons()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x47ABAD0", Offset = "0x47AA2D0", VA = "0x1847ABAD0")]
		private void LoadAndSetupSprite(AssetReference spriteReference, List<Image> imageTargets, List<SpriteRenderer> spriteRendererTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x47AC510", Offset = "0x47AAD10", VA = "0x1847AC510")]
		private void SetImageTargetsToIcon(List<Image> targets, Sprite icon)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x47AC6F0", Offset = "0x47AAEF0", VA = "0x1847AC6F0")]
		private void SetSpriteRendererTargetsToIcon(List<SpriteRenderer> targets, Sprite icon)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x47AD160", Offset = "0x47AB960", VA = "0x1847AD160")]
		protected EnumIconDataViewBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public abstract class BaseBindableObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public string ObjectName
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<string> OnObjectChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x7D65AF0", Offset = "0x7D642F0", VA = "0x187D65AF0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x7D65BA0", Offset = "0x7D643A0", VA = "0x187D65BA0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7D65AD0", Offset = "0x7D642D0", VA = "0x187D65AD0")]
		protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		protected BaseBindableObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface IInterfacesTeamHelper
	{
		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		bool RRUIPerfEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		double RRUIPerfSlowFramesSec
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public interface IMakerPenHUDBridge
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		bool IsUndoAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool IsRedoAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		KECNPIDOCPH UndoStackEntriesChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		bool OnCreateMode
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool OnSelectMode
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool OnCloneMode
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool OnConfigMode
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(Slot = "19")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool IsRRUIPageContainerEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool InTransformModeAndMoveOn
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		bool InTransformModeAndRotateOn
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool InTransformModeAndScaleOn
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		bool IsDeleteAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool IsRecolorMode
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool ShowColorPicker
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		LBOAOFAOKMM<bool> ColorPickerToggled
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool IsPrecisionModifierModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool PaletteIsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(Slot = "45")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		bool IsPaletteSearchOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(Slot = "66")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		string CurrentPaletteSearchString
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(Slot = "70")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		CategoriesNestedListConfig Config
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "75")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		bool IsCursorActive
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "76")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		LBOAOFAOKMM<bool> CursorActiveChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "77")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		bool IsInSubMenu
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(Slot = "79")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		LBOAOFAOKMM<bool> IsInSubMenuChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(Slot = "80")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action CurrentModeChanged;

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action CurrentSelectionChanged;

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		event Action PrecisionModifierModeActiveChanged;

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		event Action<int> ColorPickerCardSelected;

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		event Action OnConfigure;

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		event Action HotbarSelectionCleared;

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event Action<bool> PaletteToggled;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action PaletteNeedsVisualRefresh;

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event Action<int> PaletteObjectSelectedToggled;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<int> PaletteObjectFavoriteToggled;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action<int> PaletteObjectActionButtonClicked;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action<string, JPAJCKBNNJE> PaletteSwitchToObjectsCategoryRequested;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action PaletteSwitchToFavoritesCategoryRequested;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action PaletteSwitchToRoomInventionsCategoryRequested;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action<bool> PaletteToggledToOpen;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action<string> SearchStringChanged;

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void TriggerUndo();

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TriggerRedo();

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void GoToCreateMode();

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void GoToSelectMode();

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void ToggleCloneMode();

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void ToggleMoveMode();

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void ToggleRotateMode();

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ToggleScaleMode();

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void ToggleConfigMode();

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void DeleteCurrentSelection();

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void HideRRUIPageContainer();

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		void PressRecolorButton();

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "26")]
		void ExitRecolorMode();

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void ChangeColor(Enum shapeColor, int index);

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "40")]
		void OnConfigButtonPressed();

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "43")]
		void SelectHotbarSlot(int index);

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "44")]
		void RemoveHotbarItem(int index);

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "48")]
		void TogglePalette(bool open);

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "53")]
		void PaletteObjectToggleSelected(int gridIndex);

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(Slot = "56")]
		void PaletteObjectToggleFavorited(int gridIndex);

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void PaletteObjectClickActionButton(int gridIndex);

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(Slot = "69")]
		void TogglePaletteSearch();

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "73")]
		void SetSearchString(string newSearchString);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "74")]
		void CategoryFilterChanged(CategoriesFilter filter);

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(Slot = "78")]
		void EndCursor();
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public enum MenuType
	{
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		AppNav,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		Watch
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public interface IMenuManager
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		Guid WatchMenuUnifiedSessionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		LBOAOFAOKMM<Guid> WatchMenuUnifiedSessionIdChangedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		MenuType LastClosedMenuType
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		float LastClosedMenuTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class InterfacesTeamHelper : IInterfacesTeamHelper
	{
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private static string RRUI_PERF_EXPERIMENT_NAME;

		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private static string RRUI_PERF_ENABLED_PARAMETER_NAME;

		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private static string RRUI_PERF_SLOW_FRAMES_PARAMETER_NAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private OKNMANBEBON statSigProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private bool? rruiPerfEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private double? slowFramesSec;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool RRUIPerfEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x7D68400", Offset = "0x7D66C00", VA = "0x187D68400", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public double RRUIPerfSlowFramesSec
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x7D68590", Offset = "0x7D66D90", VA = "0x187D68590", Slot = "5")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7D68230", Offset = "0x7D66A30", VA = "0x187D68230")]
		[NOOFMBJKOEL.LBENCLOPAFN.ODLCBGDPONC]
		internal static void InitializeOnLoad(OIKNHNBNAFI container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xA2D2A0", Offset = "0xA2BAA0", VA = "0x180A2D2A0")]
		[UnityEngine.Scripting.Preserve]
		internal InterfacesTeamHelper([FAPODKMFODF(null)][NotNull] OKNMANBEBON statSigProvider)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public interface IOrderedRenderable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool RenderInCarouselOrder
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		bool AllowRender
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool HasRefreshed
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		bool RequiresRefresh
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public interface IRRUIvNextBridge
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		BLIFBLCKHPP CurrentPlatformType
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		bool InVRDisplayMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		bool InScreensDisplayMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		Guid ScreensMenuUnifiedSessionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		bool IsDebugBuild
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		long LocalRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		APAMIKOGBPP LocalRoomDetails
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		bool CurrentRoomInstanceIsPrivate
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool Discovery_ShouldDefaultPublicInstance
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		bool Discovery_ShouldDefaultPrivateInstance
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		int Discovery_NewDataTokenThresholdDays
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		bool Discovery_ShowPublishStateDataToken
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		string Discovery_StoreItemCardVariant
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		int Discovery_LimitedBadgeThresholdDays
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		bool Discovery_LimitedBadgeQolDetails
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		bool Discovery_LimitedBadgeEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		bool WatchMenuProjector_IsWatchOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool WatchMenuProject_IsUIOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(Slot = "19")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		bool WatchMenuProjector_IsMenuAnimationVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		bool ToolMenuProjector_IsMenuOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		bool ToolMenuProjector_IsMenuAnimationVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		int UnreadWatchNotificationCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		bool HideWatchNavBar
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(Slot = "24")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		Camera UICamera
		{
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		Camera ScreenModeCamera
		{
			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		KECNPIDOCPH BrowserModel_RequestAppNavMenu
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "48")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "16")]
		Vector2? Discovery_GetHighlightStyleCardOverride(HighlightStyle style);

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "17")]
		string TimeSpanExtensions_GetFormatedTimeString(TimeSpan timeSpan, bool useShortUnits);

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "27")]
		void OpenWatchMenu();

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "28")]
		void CloseWatchMenu();

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void CloseActiveToolMenu();

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(Slot = "30")]
		void NavigateToLink(LinkInfo linkInfo, bool isPortalButton = false);

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(Slot = "31")]
		void GuaranteeWatchStateAndGoTo(BrowserModel browserModel, Route route);

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void GuaranteeWatchStateAndGoTo(BrowserModel browserModel, Uri uri);

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void OpenLegacyUI(LegacyUIType legacyUIType);

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "34")]
		void NavigateToUriWithRoomSourceData(BrowserModel browserModel, Uri destination, RoomListQueryData queryData, bool useLoadSceneSourceOverride = false, PBGECCHHBDA sourceOverride = PBGECCHHBDA.NOT_SET);

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "35")]
		string GetFriendlyListNameFromRoomsConfig(RoomListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "36")]
		string GetSourceStringForQueryData(RoomListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "37")]
		bool PopulateRoomListQueryDataFromSourceInfo(string source, string sourceMetadata, RoomListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "38")]
		HighlightStyle GetHighlightStyleFromDiscoveryTeamHelper(string sourceLabelText, [Optional] string sizePerPlatformFromMetadata);

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "39")]
		Task LogImpressionEvent(LNIJEOMEBOK.LFGHOPIMKAN impressionEvent);

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "40")]
		bool IsBrowserModelOnRootScreen(BrowserModel browserModel);

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "41")]
		bool TryGetMenuOpenAction([Out] LBOAOFAOKMM<bool> menuOpenAction);

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "42")]
		void TryTrackLatencyForBrowserRoute(string routeString);

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Task<bool> ShowRoomPlayActionDialog(long roomId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "44")]
		Task<NKDJCGCAECB> ShowChooseSubRoomDialog(APAMIKOGBPP roomDetails, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "45")]
		void ForceAcceptRoomWarnings(MBPHGEGJLJE room);

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "46")]
		Task ShowTwoButtonMessageDialog(DialogListModel dialogListModel, KJPLBIBNPIL dialogData, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "47")]
		void Discovery_HackyTryShowUpdateTheAppDialog(BrowserModel browserModel);

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "49")]
		Task EvictAllFromDorm();

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "50")]
		void ShowRoomReportDialog(long roomId, string sanitizedFriendlyName);

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "51")]
		void ApplyBrowserModelImpressionData(ImpressionTracker impressionTracker, BrowserModel browserModel, string nullBrowserRouteProperty = "appnav/quickaccess");

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "52")]
		Task<RenderTexture> GenerateTextureForLocalAvatarAsync(CancellationToken token, int width = -1, int height = -1);

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "53")]
		void AddNotificationRestriction(object token);

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void RemoveNotificationRestriction(object token);

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "55")]
		void OpenManageRRPlusMembershipPage();

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "56")]
		bool CanLocalPlayerChatWith(OJOHBAGDGLP account);

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(Slot = "57")]
		void GoToChatPage(int accountId, NBOCKIDFMHH chatTelemetrySource);
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public interface IRRUIvNextConsumableBridge
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public enum ConsumableCategory
		{
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			All,
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			Food,
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			Other
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<OIKCNNCCGJE, bool> OnActiveConsumableChanged;

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event Action<OIKCNNCCGJE, bool> OnPurchasedConsumableChanged;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		List<OIKCNNCCGJE> GetLatestPurchasedNonTransferableConsumables(ConsumableCategory category);

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UseConsumable(OIKCNNCCGJE consumable);

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "6")]
		NGCIPJABEMC GetConsumableImposterRequest(OIKCNNCCGJE consumable);

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool IsConsumableSpawned(OIKCNNCCGJE consumable);

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "8")]
		int GetTotalConsumableCount(OIKCNNCCGJE consumable);
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public interface IRRUIvNextRoomCategoryBridge
	{
		[Cpp2IlInjected.Token(Token = "0x17000059")]
		string DefaultGameConfigKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		bool ShouldHideShowMeAllRooms
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		bool ShouldHideChipBar
		{
			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SelectRoomCategory(JIAOGBBBDKD category, Route route, PBGECCHHBDA loadSceneSource, BrowserModel browserModel);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<IReadOnlyList<JIAOGBBBDKD>> GetRoomCategoriesForPageSource(CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<(IReadOnlyList<JIAOGBBBDKD>, string)> GetRoomCategoriesForCuratedList(string sourceMetadata, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IReadOnlyList<JIAOGBBBDKD> GetRoomCategoriesForConfig(string gameConfigKey);
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[ViewModel]
	public class PlayerNametagViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct <OnReputationUpdated>d__76 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public PlayerNametagViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public int accountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private TaskAwaiter<MCCMLEDNIMG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0x7D76EE0", Offset = "0x7D756E0", VA = "0x187D76EE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private struct <OnAccountUpdated>d__77 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public PlayerNametagViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public int accountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private TaskAwaiter<KDEGGCDDKFJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x7D76C40", Offset = "0x7D75440", VA = "0x187D76C40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private struct <GetPlayerInfo>d__80 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public PlayerNametagViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public IPlayerUIBridge player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private APAMIKOGBPP <details>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private GDIAGMILAGG <progression>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private TaskAwaiter<APAMIKOGBPP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			private TaskAwaiter<KDEGGCDDKFJ> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private TaskAwaiter<GDIAGMILAGG> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			private TaskAwaiter<bool> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x7D74FA0", Offset = "0x7D737A0", VA = "0x187D74FA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool canShowNametag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private string playerDisplayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private string playerCustomEmoji;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private AccountRoleIconType playerRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private AccountBadgeIconType roleBadgeIconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private AccountBadgeIconType cheerBadgeIconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private string playerLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private bool isBroadcasting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private string developerLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private bool inCallWithLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private bool muted;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA2")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private bool blocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA3")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private bool inAPartyWithLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private IPlayerColor playerColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private IPlayerUIBridge playerUIBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private CancellationTokenSource tokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private string accountLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private bool isInfluencer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private IRoomQueryManager roomQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private IAccountQueryManager accountQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private KDEGGCDDKFJ account;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private DataItem<bool> CanShowNametagDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private DataItem<string> PlayerDisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private DataItem<string> PlayerCustomEmojiDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private DataItem<bool> HasCustomEmojiDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private DataItem<AccountRoleIconType> PlayerRoleTypeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private DataItem<AccountBadgeIconType> RoleBadgeIconTypeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private DataItem<AccountBadgeIconType> CheerBadgeIconTypeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private DataItem<string> PlayerLevelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private DataItem<bool> IsBroadcastingDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private DataItem<bool> ShowDeveloperLabelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private DataItem<string> DeveloperLabelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private DataItem<bool> InCallWithLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private DataItem<bool> MutedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private DataItem<bool> BlockedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private DataItem<bool> InAPartyWithLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private DataItem<IPlayerColor> PlayerColorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private DataItemAction OpenPlayerProfileDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		[BindableData(0, null, DataPermissions.ReadOnly)]
		public bool CanShowNametag
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4B0", Offset = "0xA2BCB0", VA = "0x180A2D4B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x7D6CA40", Offset = "0x7D6B240", VA = "0x187D6CA40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		[BindableData(1, "Display name of the associated player", DataPermissions.ReadOnly)]
		public string PlayerDisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0xA27510", Offset = "0xA25D10", VA = "0x180A27510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x7D6CE00", Offset = "0x7D6B600", VA = "0x187D6CE00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		[BindableData(2, "Player-set custom emoji", DataPermissions.ReadOnly)]
		public string PlayerCustomEmoji
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0xA274C0", Offset = "0xA25CC0", VA = "0x180A274C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x7D6CD90", Offset = "0x7D6B590", VA = "0x187D6CD90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		[BindableData(3, "Whether a custom emoji is set", DataPermissions.ReadOnly)]
		public bool HasCustomEmoji
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x7D6C2C0", Offset = "0x7D6AAC0", VA = "0x187D6C2C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		[BindableData(5, "The role of this player in the current room", DataPermissions.ReadOnly)]
		public AccountRoleIconType PlayerRoleType
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0xE433D0", Offset = "0xE41BD0", VA = "0x180E433D0")]
			get
			{
				return default(AccountRoleIconType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x7D6CEF0", Offset = "0x7D6B6F0", VA = "0x187D6CEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		[BindableData(6, "The badge the player has selected", DataPermissions.ReadOnly)]
		public AccountBadgeIconType RoleBadgeIconType
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0xEDDBA0", Offset = "0xEDC3A0", VA = "0x180EDDBA0")]
			get
			{
				return default(AccountBadgeIconType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x7D6CF40", Offset = "0x7D6B740", VA = "0x187D6CF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		[BindableData(15, "The active cheer this player has", DataPermissions.ReadOnly)]
		public AccountBadgeIconType CheerBadgeIconType
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xC94200", Offset = "0xC92A00", VA = "0x180C94200")]
			get
			{
				return default(AccountBadgeIconType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x7D6CAA0", Offset = "0x7D6B2A0", VA = "0x187D6CAA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		[BindableData(7, "Player level (room level if room has progression)", DataPermissions.ReadOnly)]
		public string PlayerLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xA35020", Offset = "0xA33820", VA = "0x180A35020")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x7D6CE70", Offset = "0x7D6B670", VA = "0x187D6CE70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		[BindableData(8, "Whether the player is broadcasting", DataPermissions.ReadOnly)]
		public bool IsBroadcasting
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xA58640", Offset = "0xA56E40", VA = "0x180A58640")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x7D6CC60", Offset = "0x7D6B460", VA = "0x187D6CC60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		[BindableData(9, "Whether the player is a developer", DataPermissions.ReadOnly)]
		public bool ShowDeveloperLabel
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x7D6C2E0", Offset = "0x7D6AAE0", VA = "0x187D6C2E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		[BindableData(10, "Player level (room level if room has progression)", DataPermissions.ReadOnly)]
		public string DeveloperLabel
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xA34FB0", Offset = "0xA337B0", VA = "0x180A34FB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0x7D6CB00", Offset = "0x7D6B300", VA = "0x187D6CB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		[BindableData(11, "Whether this player is in a call with the local player", DataPermissions.ReadOnly)]
		public bool InCallWithLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xCFC160", Offset = "0xCFA960", VA = "0x180CFC160")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x7D6CC00", Offset = "0x7D6B400", VA = "0x187D6CC00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		[BindableData(12, "Whether this player is muted by the local player", DataPermissions.ReadOnly)]
		public bool Muted
		{
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xDD1680", Offset = "0xDCFE80", VA = "0x180DD1680")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x7D6CCC0", Offset = "0x7D6B4C0", VA = "0x187D6CCC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		[BindableData(13, "Whether this player has been blocked by local player", DataPermissions.ReadOnly)]
		public bool Blocked
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0x74986A0", Offset = "0x7496EA0", VA = "0x1874986A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x7D6C9E0", Offset = "0x7D6B1E0", VA = "0x187D6C9E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		[BindableData(14, "Whether this player is in a party", DataPermissions.ReadOnly)]
		public bool InAPartyWithLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x7D632A0", Offset = "0x7D61AA0", VA = "0x187D632A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x7D6CBA0", Offset = "0x7D6B3A0", VA = "0x187D6CBA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		[BindableData(16, "Player color defined by legacy scripts", DataPermissions.ReadOnly)]
		public IPlayerColor PlayerColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0xA2B840", Offset = "0xA2A040", VA = "0x180A2B840")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x7D6CD20", Offset = "0x7D6B520", VA = "0x187D6CD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x7D6C9A0", Offset = "0x7D6B1A0", VA = "0x187D6C9A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7D6C0E0", Offset = "0x7D6A8E0", VA = "0x187D6C0E0")]
		public void Set(IPlayerUIBridge player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7D6A040", Offset = "0x7D68840", VA = "0x187D6A040")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x7D6B780", Offset = "0x7D69F80", VA = "0x187D6B780")]
		private void OnBroadcastingStateChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7D6B8C0", Offset = "0x7D6A0C0", VA = "0x187D6B8C0")]
		private void OnDeveloperDisplayChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7D6B820", Offset = "0x7D6A020", VA = "0x187D6B820")]
		private void OnCallStatusChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7D6BAD0", Offset = "0x7D6A2D0", VA = "0x187D6BAD0")]
		private void OnPartyStatusChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7D6BA30", Offset = "0x7D6A230", VA = "0x187D6BA30")]
		private void OnNametagVisibilityChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7D6BE70", Offset = "0x7D6A670", VA = "0x187D6BE70")]
		private void OnRelationshipChanged(int? playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7D6BD70", Offset = "0x7D6A570", VA = "0x187D6BD70")]
		private void OnProgressionUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7D6C020", Offset = "0x7D6A820", VA = "0x187D6C020")]
		[AsyncStateMachine(typeof(<OnReputationUpdated>d__76))]
		private void OnReputationUpdated(int accountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7D6B6C0", Offset = "0x7D69EC0", VA = "0x187D6B6C0")]
		[AsyncStateMachine(typeof(<OnAccountUpdated>d__77))]
		private void OnAccountUpdated(int accountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7D6C300", Offset = "0x7D6AB00", VA = "0x187D6C300")]
		private void UpdateRoleBadge()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7D6BC90", Offset = "0x7D6A490", VA = "0x187D6BC90")]
		private void OnPlayerColorUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7D6A8D0", Offset = "0x7D690D0", VA = "0x187D6A8D0")]
		[AsyncStateMachine(typeof(<GetPlayerInfo>d__80))]
		private void GetPlayerInfo(IPlayerUIBridge player, long roomId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		[BindableAction(100, "Opens the player profile page")]
		private void OpenPlayerProfile()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7D6A9C0", Offset = "0x7D691C0", VA = "0x187D6A9C0")]
		private static AccountRoleIconType GetRoleIconType(IPlayerUIBridge player, BAMAEEMHEMC role)
		{
			return default(AccountRoleIconType);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x7D6AAA0", Offset = "0x7D692A0", VA = "0x187D6AAA0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7D6A5F0", Offset = "0x7D68DF0", VA = "0x187D6A5F0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7D6C430", Offset = "0x7D6AC30", VA = "0x187D6C430")]
		public PlayerNametagViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public enum RecRoomPlusOfferType
	{
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		SimpleBenefitList,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		LimitedTimeSignOnItemBonus
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[ViewModel]
	public class RecRoomPlusOfferViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private struct <FetchBenefitData>d__49 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public RecRoomPlusOfferViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private TaskAwaiter<List<RecRoomPlusBenefitData>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x7D731C0", Offset = "0x7D719C0", VA = "0x187D731C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private struct <FetchStoreItemOffers>d__50 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public RecRoomPlusOfferViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public WidgetSourceData sourceData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private CancellationToken <token>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private TaskAwaiter<IReadOnlyList<DJANCJIHPPH>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private TaskAwaiter<LOHEAGHOKGM.CDLEBGGLNLN> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private TaskAwaiter<IReadOnlyList<PNBLFFBKHJH>> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private IEnumerator<PNBLFFBKHJH> <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private PNBLFFBKHJH <item>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private ADAGNOEBGPC <giftDrop>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private TaskAwaiter<bool> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x7D73400", Offset = "0x7D71C00", VA = "0x187D73400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		private RecRoomPlusOfferType offerType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		private int maxLimitedTimeOfferItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		private Uri offerItemDetailsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		private ImpressionTracker bannerContentsImpressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private bool subscriptionActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private string offerDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private string offerIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private string offerImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private bool useImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private int offerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int activeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private IRecRoomPlusDataManager rrplusManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private IStoreItemQueryManager storeItemListQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private IRRUIvNextStoreItemBridge vNextStoreItemBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private IAccountQueryManager accountQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private IRecRoomPlusDataManager rrPlusDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private List<RecRoomPlusBenefitData> benefitData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private StoreItemListQueryData wishlistQueryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private StoreItemListQueryData configuredQueryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private string widgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private List<int> wishlistItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private string nonWishlistSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private Dictionary<int, PNBLFFBKHJH> storeItemLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private DataItem<bool> SubscriptionActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private DataItem<string> OfferDescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private DataItem<string> OfferIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private DataItem<string> OfferImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private DataItem<bool> UseImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private DataItem<int> OfferIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private DataItemAction RefreshOfferDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private DataItemAction ViewOfferItemDetailsDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool SubscriptionActive
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xC6D850", Offset = "0xC6C050", VA = "0x180C6D850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x7D70500", Offset = "0x7D6ED00", VA = "0x187D70500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string OfferDescription
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xA35020", Offset = "0xA33820", VA = "0x180A35020")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x7D70FF0", Offset = "0x7D6F7F0", VA = "0x187D70FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string OfferIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xA8DF30", Offset = "0xA8C730", VA = "0x180A8DF30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x7D71070", Offset = "0x7D6F870", VA = "0x187D71070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public string OfferImage
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xA34FB0", Offset = "0xA337B0", VA = "0x180A34FB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x7D710F0", Offset = "0x7D6F8F0", VA = "0x187D710F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool UseImage
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0xCFC160", Offset = "0xCFA960", VA = "0x180CFC160")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(RVA = "0x7D70590", Offset = "0x7D6ED90", VA = "0x187D70590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public int OfferId
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0x147F400", Offset = "0x147DC00", VA = "0x18147F400")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x7D704A0", Offset = "0x7D6ECA0", VA = "0x187D704A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x7D70FB0", Offset = "0x7D6F7B0", VA = "0x187D70FB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7D6F960", Offset = "0x7D6E160", VA = "0x187D6F960")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7D700D0", Offset = "0x7D6E8D0", VA = "0x187D700D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7D6F8B0", Offset = "0x7D6E0B0", VA = "0x187D6F8B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7D705F0", Offset = "0x7D6EDF0", VA = "0x187D705F0")]
		private void UpdateUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7D6EE40", Offset = "0x7D6D640", VA = "0x187D6EE40")]
		[AsyncStateMachine(typeof(<FetchBenefitData>d__49))]
		private void FetchBenefitData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x7D6EEF0", Offset = "0x7D6D6F0", VA = "0x187D6EEF0")]
		[AsyncStateMachine(typeof(<FetchStoreItemOffers>d__50))]
		private void FetchStoreItemOffers(WidgetSourceData sourceData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7D6FA40", Offset = "0x7D6E240", VA = "0x187D6FA40")]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7D6FAE0", Offset = "0x7D6E2E0", VA = "0x187D6FAE0")]
		[BindableAction(100, null)]
		private void RefreshOffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7D6FD40", Offset = "0x7D6E540", VA = "0x187D6FD40")]
		private void RefreshUIContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7D6FF10", Offset = "0x7D6E710", VA = "0x187D6FF10")]
		private void SetUpImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7D709B0", Offset = "0x7D6F1B0", VA = "0x187D709B0")]
		[BindableAction(101, null)]
		private void ViewOfferItemDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7D6F180", Offset = "0x7D6D980", VA = "0x187D6F180", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7D6EFE0", Offset = "0x7D6D7E0", VA = "0x187D6EFE0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7D70C00", Offset = "0x7D6F400", VA = "0x187D70C00")]
		public RecRoomPlusOfferViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public enum AccountBadgeIconType
	{
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		Party,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		RRPlus,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		Influencer,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		Developer,
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		Cheer_Helpful,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		Cheer_General,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		Cheer_Sportsmanship,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		Cheer_GreatHost,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		Cheer_Creative,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		League
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class AccountBadgeIconConfig : IIconConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public AccountBadgeIconType IconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[SerializeField]
		private AssetReferenceT<Sprite> backgroundFillIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[SerializeField]
		private AssetReferenceT<Sprite> backgroundOutlineIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[FormerlySerializedAs("BadgeIcon")]
		[SerializeField]
		private AssetReferenceT<Sprite> badgeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[SerializeField]
		private AssetReferenceT<Sprite> badgeOutlineIcon;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public AssetReferenceT<Sprite> BackgroundFillIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public AssetReferenceT<Sprite> BackgroundOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public AssetReferenceT<Sprite> BadgeIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public AssetReferenceT<Sprite> BadgeOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public AccountBadgeIconConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CreateAssetMenu(fileName = "AccountBadgeIconData", menuName = "Rec Room/App UI/Account/Account Badge Icon Data")]
	public class AccountBadgeIconData : ScriptableObject, IIconData<AccountBadgeIconType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public List<AccountBadgeIconConfig> Config;

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7D5EA20", Offset = "0x7D5D220", VA = "0x187D5EA20", Slot = "4")]
		public bool TryGetConfig(AccountBadgeIconType iconType, [Out] IIconConfig config)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xC33770", Offset = "0xC31F70", VA = "0x180C33770")]
		public AccountBadgeIconData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class AccountBadgeIconView : EnumIconDataViewBase<AccountBadgeIconType, AccountBadgeIconData>
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7D5EB80", Offset = "0x7D5D380", VA = "0x187D5EB80")]
		public AccountBadgeIconView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public enum AccountRoleIconType
	{
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		Banned,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		Host,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		Moderator,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		Contributor,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		CoOwner,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		TemporaryCoOwner,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		Creator,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		RoomLevel
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class AccountRoleIconConfig : IIconConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public AccountRoleIconType IconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[SerializeField]
		private AssetReferenceT<Sprite> backgroundFillIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[SerializeField]
		private AssetReferenceT<Sprite> backgroundOutlineIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[SerializeField]
		private AssetReferenceT<Sprite> badgeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[SerializeField]
		private AssetReferenceT<Sprite> badgeOutlineIcon;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public AssetReferenceT<Sprite> BackgroundFillIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public AssetReferenceT<Sprite> BackgroundOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public AssetReferenceT<Sprite> BadgeIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60001DA")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public AssetReferenceT<Sprite> BadgeOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60001DB")]
			[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public AccountRoleIconConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CreateAssetMenu(fileName = "AccountRoleIconData", menuName = "RecRoom/App UI/Account Role Icon Data")]
	public class AccountRoleIconData : ScriptableObject, IIconData<AccountRoleIconType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		private List<AccountRoleIconConfig> iconConfigList;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7D60200", Offset = "0x7D5EA00", VA = "0x187D60200", Slot = "4")]
		public bool TryGetConfig(AccountRoleIconType iconType, [Out] IIconConfig config)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xC33770", Offset = "0xC31F70", VA = "0x180C33770")]
		public AccountRoleIconData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class AccountRoleView : EnumIconDataViewBase<AccountRoleIconType, AccountRoleIconData>
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7D60440", Offset = "0x7D5EC40", VA = "0x187D60440")]
		public AccountRoleView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[ViewModel]
	public class AccountListViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private AccountListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		private Uri viewAllFriendsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		private Uri viewHereNowUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private DataList<int> _accountList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private bool _isEmpty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private string _displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private string _emptyText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private IAccountQueryManager _accountQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private IRRUIvNextBridge _vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private BrowserModel _browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private bool _isSubscribed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private DataItem<bool> IsEmptyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private DataItem<string> EmptyTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private DataItemList AccountListDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private DataItemAction GoToViewAllPageDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public AccountListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0xA274B0", Offset = "0xA25CB0", VA = "0x180A274B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x7D60100", Offset = "0x7D5E900", VA = "0x187D60100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<int> AccountList
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0xA35070", Offset = "0xA33870", VA = "0x180A35070")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x7D5FFA0", Offset = "0x7D5E7A0", VA = "0x187D5FFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0xC6D850", Offset = "0xC6C050", VA = "0x180C6D850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x7D5F590", Offset = "0x7D5DD90", VA = "0x187D5F590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		[BindableData(2, "The name of the list that can be shown on the UI, e.g. as a carousel title", DataPermissions.ReadOnly)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0xA35020", Offset = "0xA33820", VA = "0x180A35020")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x7D60000", Offset = "0x7D5E800", VA = "0x187D60000")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		[BindableData(3, "The text to show if the list is empty", DataPermissions.ReadOnly)]
		public string EmptyText
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0xA8DF30", Offset = "0xA8C730", VA = "0x180A8DF30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x7D60080", Offset = "0x7D5E880", VA = "0x187D60080")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x7D5FF60", Offset = "0x7D5E760", VA = "0x187D5FF60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7D5F320", Offset = "0x7D5DB20", VA = "0x187D5F320")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x7D5F300", Offset = "0x7D5DB00", VA = "0x187D5F300", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x7D5F6C0", Offset = "0x7D5DEC0", VA = "0x187D5F6C0")]
		private void UpdateList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x7D5ED00", Offset = "0x7D5D500", VA = "0x187D5ED00")]
		[BindableAction(100, null)]
		private void GoToViewAllPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x7D5F3D0", Offset = "0x7D5DBD0", VA = "0x187D5F3D0")]
		private bool TrySubscribe()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x7D5F4B0", Offset = "0x7D5DCB0", VA = "0x187D5F4B0")]
		private bool TryUnsubscribe()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x7D5EE90", Offset = "0x7D5D690", VA = "0x187D5EE90", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x7D5EBC0", Offset = "0x7D5D3C0", VA = "0x187D5EBC0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7D5FD00", Offset = "0x7D5E500", VA = "0x187D5FD00")]
		public AccountListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[ViewModel]
	public class AccountViewModel : RRUIBaseLocalViewModel, ILoadable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct <FetchAccountData>d__96 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400016F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000171")]
			public AccountViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000172")]
			private CancellationToken <token>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000173")]
			private CancellationTokenSource <cts>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000174")]
			private TaskAwaiter<KDEGGCDDKFJ> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000175")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x7D72990", Offset = "0x7D71190", VA = "0x187D72990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct <UpdateAccountProgression>d__97 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000176")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000177")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000178")]
			public AccountViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000179")]
			private TaskAwaiter<GDIAGMILAGG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x7D773A0", Offset = "0x7D75BA0", VA = "0x187D773A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private struct <UpdatePresence>d__99 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017C")]
			public AccountViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			private TaskAwaiter<string> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x7D77680", Offset = "0x7D75E80", VA = "0x187D77680", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x7D77C60", Offset = "0x7D76460", VA = "0x187D77C60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		private Uri profilePageUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[SerializeField]
		private NBOCKIDFMHH chatTelemetrySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private JFNOPIFJHHB partyJoinedSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private int accountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private string profileImageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private string username;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private int level;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private float progressInLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private string presence;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private bool _canLocalPlayerGoTo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private bool isFriendOfLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA2")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private bool canSendOrAcceptFriendRequest;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA3")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private bool canLocalPlayerInviteToParty;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private bool isLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA5")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private bool canLocalPlayerChatWith;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA6")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private bool canInviteToJoinLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA7")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private bool isInSameRoomAsLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private bool isFriendOfLocalPlayerAndIsInSameRoomAsLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private bool isFriendOfLocalPlayerAndIsNotInSameRoomAsLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAA")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private bool isBlocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private DCKMHKINNFJ sessionManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private IAccountQueryManager accountQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private IRRUIvNextAccountBridge vNextAccountBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private IRRUIvNextSocialBridge vNextSocialBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private KDEGGCDDKFJ account;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private DataItem<int> AccountIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private DataItem<string> ProfileImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private DataItem<string> UsernameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private DataItem<int> LevelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private DataItem<float> ProgressInLevelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private DataItem<string> PresenceDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private DataItem<bool> CanLocalPlayerGoToDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private DataItem<bool> IsFriendOfLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private DataItem<bool> CanSendOrAcceptFriendRequestDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private DataItem<bool> CanInviteToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private DataItem<bool> IsLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private DataItem<bool> CanLocalPlayerChatWithDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private DataItem<bool> CanInviteToJoinLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private DataItem<bool> IsInSameRoomAsLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private DataItem<bool> IsFriendOfLocalPlayerAndIsInSameRoomAsLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private DataItem<bool> IsFriendOfLocalPlayerAndIsNotInSameRoomAsLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private DataItem<bool> IsBlockedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private DataItemAction GoToProfilePageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private DataItemAction GoToChatPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private DataItemAction InviteToMyLocationDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private DataItemAction GoToLocationDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private DataItemAction InviteToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private DataItemAction SendFriendRequestDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0xA50730", Offset = "0xA4EF30", VA = "0x180A50730")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x7D63230", Offset = "0x7D61A30", VA = "0x187D63230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0xA35070", Offset = "0xA33870", VA = "0x180A35070")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x7D635C0", Offset = "0x7D61DC0", VA = "0x187D635C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string ProfileImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0xA35010", Offset = "0xA33810", VA = "0x180A35010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x7D644F0", Offset = "0x7D62CF0", VA = "0x187D644F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public string Username
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0xA35020", Offset = "0xA33820", VA = "0x180A35020")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x7D64570", Offset = "0x7D62D70", VA = "0x187D64570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public int Level
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0xA35050", Offset = "0xA33850", VA = "0x180A35050")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x7D63650", Offset = "0x7D61E50", VA = "0x187D63650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public float ProgressInLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x1447160", Offset = "0x1445960", VA = "0x181447160")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x7D63080", Offset = "0x7D61880", VA = "0x187D63080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		[BindableData(6, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public string Presence
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xA34FB0", Offset = "0xA337B0", VA = "0x180A34FB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x7D64470", Offset = "0x7D62C70", VA = "0x187D64470")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		[BindableData(7, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanLocalPlayerGoTo
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xCFC160", Offset = "0xCFA960", VA = "0x180CFC160")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x7D63100", Offset = "0x7D61900", VA = "0x187D63100")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		[BindableData(8, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsFriendOfLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xDD1680", Offset = "0xDCFE80", VA = "0x180DD1680")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x7D63160", Offset = "0x7D61960", VA = "0x187D63160")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		[BindableData(9, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanSendOrAcceptFriendRequest
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x74986A0", Offset = "0x7496EA0", VA = "0x1874986A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x7D631D0", Offset = "0x7D619D0", VA = "0x187D631D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		[BindableData(10, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanInviteToParty
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x7D632A0", Offset = "0x7D61AA0", VA = "0x187D632A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x7D632B0", Offset = "0x7D61AB0", VA = "0x187D632B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		[BindableData(11, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0xF0DFD0", Offset = "0xF0C7D0", VA = "0x180F0DFD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x7D63310", Offset = "0x7D61B10", VA = "0x187D63310")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		[BindableData(12, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanLocalPlayerChatWith
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x182EFA0", Offset = "0x182D7A0", VA = "0x18182EFA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x7D63370", Offset = "0x7D61B70", VA = "0x187D63370")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		[BindableData(13, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanInviteToJoinLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xECA5A0", Offset = "0xEC8DA0", VA = "0x180ECA5A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x7D633D0", Offset = "0x7D61BD0", VA = "0x187D633D0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		[BindableData(14, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsInSameRoomAsLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x6E9ED00", Offset = "0x6E9D500", VA = "0x186E9ED00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x7D63430", Offset = "0x7D61C30", VA = "0x187D63430")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		[BindableData(15, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsFriendOfLocalPlayerAndIsInSameRoomAsLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0xA8DF40", Offset = "0xA8C740", VA = "0x180A8DF40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x7D634A0", Offset = "0x7D61CA0", VA = "0x187D634A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		[BindableData(16, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsFriendOfLocalPlayerAndIsNotInSameRoomAsLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0xA8DF50", Offset = "0xA8C750", VA = "0x180A8DF50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x7D63500", Offset = "0x7D61D00", VA = "0x187D63500")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		[BindableData(17, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsBlocked
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0xA8DF70", Offset = "0xA8C770", VA = "0x180A8DF70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x7D63560", Offset = "0x7D61D60", VA = "0x187D63560")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x7D64330", Offset = "0x7D62B30", VA = "0x187D64330", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0xB42260", Offset = "0xB40A60", VA = "0x180B42260", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0xB41160", Offset = "0xB3F960", VA = "0x180B41160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x7D642F0", Offset = "0x7D62AF0", VA = "0x187D642F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<ILoadable> Loaded
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x7D64230", Offset = "0x7D62A30", VA = "0x187D64230", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x7D643B0", Offset = "0x7D62BB0", VA = "0x187D643B0", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x7D60480", Offset = "0x7D5EC80", VA = "0x187D60480", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7D62900", Offset = "0x7D61100", VA = "0x187D62900", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7D62B40", Offset = "0x7D61340", VA = "0x187D62B40")]
		private void OnRelationshipUpdated(int? accountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7D62B30", Offset = "0x7D61330", VA = "0x187D62B30")]
		private void OnPlayerPresenceUpdated(int accountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x7D62B20", Offset = "0x7D61320", VA = "0x187D62B20")]
		private void OnPartyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x7D62730", Offset = "0x7D60F30", VA = "0x187D62730")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x7D60820", Offset = "0x7D5F020", VA = "0x187D60820")]
		[AsyncStateMachine(typeof(<FetchAccountData>d__96))]
		private void FetchAccountData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x7D636B0", Offset = "0x7D61EB0", VA = "0x187D636B0")]
		[AsyncStateMachine(typeof(<UpdateAccountProgression>d__97))]
		private void UpdateAccountProgression()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x7D639A0", Offset = "0x7D621A0", VA = "0x187D639A0")]
		private void UpdateRelationship()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x7D638D0", Offset = "0x7D620D0", VA = "0x187D638D0")]
		[AsyncStateMachine(typeof(<UpdatePresence>d__99))]
		private Task UpdatePresence()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7D63760", Offset = "0x7D61F60", VA = "0x187D63760")]
		private void UpdateCanInviteToParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x7D63800", Offset = "0x7D62000", VA = "0x187D63800")]
		private void UpdateIsFriendAndInSameRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x7D62BB0", Offset = "0x7D613B0", VA = "0x187D62BB0")]
		private void ResetAccountData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7D60FA0", Offset = "0x7D5F7A0", VA = "0x187D60FA0")]
		[BindableAction(100, null)]
		private void GoToProfilePage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7D60CA0", Offset = "0x7D5F4A0", VA = "0x187D60CA0")]
		[BindableAction(101, null)]
		private void GoToChatPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x7D62570", Offset = "0x7D60D70", VA = "0x187D62570")]
		[BindableAction(102, null)]
		private void InviteToMyLocation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x7D60E50", Offset = "0x7D5F650", VA = "0x187D60E50")]
		[BindableAction(103, null)]
		private void GoToLocation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7D62660", Offset = "0x7D60E60", VA = "0x187D62660")]
		[BindableAction(104, null)]
		private void InviteToParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x7D63020", Offset = "0x7D61820", VA = "0x187D63020")]
		[BindableAction(105, null)]
		private void SendFriendRequest()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7D61180", Offset = "0x7D5F980", VA = "0x187D61180", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7D608D0", Offset = "0x7D5F0D0", VA = "0x187D608D0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x7D63B50", Offset = "0x7D62350", VA = "0x187D63B50")]
		public AccountViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[ViewModel]
	public class AppNavButtonViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct <FetchLocalAccountInfo>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public AppNavButtonViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			private TaskAwaiter<KDEGGCDDKFJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x7D8AC50", Offset = "0x7D89450", VA = "0x187D8AC50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[SerializeField]
		private string buttonIdentifierOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[SerializeField]
		private DataResolver activeIdentifierResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[SerializeField]
		private DataResolver targetIdentifierResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private bool buttonPanelActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private string buttonIconId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private bool useProfilePictureAsIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private string profilePictureName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private string buttonIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private IAccountQueryManager accountManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private DataItem<bool> ButtonPanelActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private DataItem<string> ButtonIconIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private DataItem<bool> UseProfilePictureAsIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private DataItem<string> ProfilePictureNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private DataItemAction RequestChangePanelDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		[BindableData(0, null, DataPermissions.ReadOnly)]
		public bool ButtonPanelActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0xCD1980", Offset = "0xCD0180", VA = "0x180CD1980")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x7D65990", Offset = "0x7D64190", VA = "0x187D65990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		[BindableData(1, null, DataPermissions.ReadOnly)]
		public string ButtonIconId
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0xA35010", Offset = "0xA33810", VA = "0x180A35010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0x7D65910", Offset = "0x7D64110", VA = "0x187D65910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		[BindableData(2, null, DataPermissions.ReadOnly)]
		public bool UseProfilePictureAsIcon
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0xD9B8E0", Offset = "0xD9A0E0", VA = "0x180D9B8E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x7D65A70", Offset = "0x7D64270", VA = "0x187D65A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		[BindableData(3, null, DataPermissions.ReadOnly)]
		public string ProfilePictureName
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xA8DF30", Offset = "0xA8C730", VA = "0x180A8DF30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x7D659F0", Offset = "0x7D641F0", VA = "0x187D659F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x7D65890", Offset = "0x7D64090", VA = "0x187D65890", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x7D65850", Offset = "0x7D64050", VA = "0x187D65850", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7D645F0", Offset = "0x7D62DF0", VA = "0x187D645F0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7D654C0", Offset = "0x7D63CC0", VA = "0x187D654C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7D65270", Offset = "0x7D63A70", VA = "0x187D65270", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x7D64E10", Offset = "0x7D63610", VA = "0x187D64E10")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7D647B0", Offset = "0x7D62FB0", VA = "0x187D647B0")]
		[AsyncStateMachine(typeof(<FetchLocalAccountInfo>d__28))]
		private void FetchLocalAccountInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7D64D50", Offset = "0x7D63550", VA = "0x187D64D50")]
		private void OnActiveIdentifierUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x7D65380", Offset = "0x7D63B80", VA = "0x187D65380")]
		private void OnTargetIdentifierUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7D65440", Offset = "0x7D63C40", VA = "0x187D65440")]
		[BindableAction(100, null)]
		private void RequestChangePanel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7D64700", Offset = "0x7D62F00", VA = "0x187D64700")]
		private void ConfigureImpressions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7D649A0", Offset = "0x7D631A0", VA = "0x187D649A0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7D64860", Offset = "0x7D63060", VA = "0x187D64860")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7D65620", Offset = "0x7D63E20", VA = "0x187D65620")]
		public AppNavButtonViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public class AppNavMenu : MonoBehaviour, IAppNavMenu
	{
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private sealed class <WaitForOpenMenu>d__80 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public AppNavMenu <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			private float <watchOpenStart>5__2;

			[Cpp2IlInjected.Token(Token = "0x170000B1")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002AC")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B2")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002AE")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
			[DebuggerHidden]
			public <WaitForOpenMenu>d__80(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x7D8FF60", Offset = "0x7D8E760", VA = "0x187D8FF60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x7D90370", Offset = "0x7D8EB70", VA = "0x187D90370", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class <WaitForCloseMenu>d__81 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public AppNavMenu <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000B3")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002B2")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B4")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002B4")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
			[DebuggerHidden]
			public <WaitForCloseMenu>d__81(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x7D8FDC0", Offset = "0x7D8E5C0", VA = "0x187D8FDC0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x7D8FF10", Offset = "0x7D8E710", VA = "0x187D8FF10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private sealed class <WaitToOpenWatch>d__82 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001BD")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001BE")]
			public AppNavMenu <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000B5")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002B8")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000B6")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002BA")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
			[DebuggerHidden]
			public <WaitToOpenWatch>d__82(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x7D90800", Offset = "0x7D8F000", VA = "0x187D90800", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x7D90890", Offset = "0x7D8F090", VA = "0x187D90890", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public const string AppNavLayerName = "interfaces_2025q1_appnav";

		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public const string UseAppNavParameterName = "use_app_nav_forship";

		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public const string UXFlowLayerName = "interfaces_widgetwatch_ux_flow";

		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public const string RetainUIStateParameterName = "enable_retain_ui_state";

		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public const string ShowWatchButtonParameterName = "show_watch_button_in_menus";

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public const string PortalButtonsAsTabsParameterName = "portal_buttons_act_like_tabs";

		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public const string RetainUIStateDurationParameterName = "retain_ui_state_duration";

		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public const string AlwaysPresentPortalParameterName = "portal_always_present";

		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public static readonly KECNPIDOCPH InitializedEvent;

		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private static AppNavMenu instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[SerializeField]
		private Canvas menuCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		private HydrateBase appNavHydration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private AppNavViewModel appNavViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private AppNavPanelSwitcher panelSwitcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private CanvasScreenSizeRefitter canvasScreenSizeRefitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private PlatformDependentCanvasSizeConfig canvasSizeConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private LongPressInteractable backgroundInteractable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private float forceWatchCloseDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private Coroutine transitionCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private OKNMANBEBON statsig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private Transform originalParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private bool isGoingBack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private FHOMLAFAIFF<object> disableAppNavTokens;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public KECNPIDOCPH BeforeAppNavOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public KECNPIDOCPH AfterAppNavOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public KECNPIDOCPH AfterAppNavClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public KECNPIDOCPH OnShouldUseAppNavChanged;

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public static bool ShouldRetainUIState
		{
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x7D7A840", Offset = "0x7D79040", VA = "0x187D7A840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public static bool PortalButtonsActAsTabs
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0x7D7A340", Offset = "0x7D78B40", VA = "0x187D7A340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public static float RetainUIStateDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x7D7A4D0", Offset = "0x7D78CD0", VA = "0x187D7A4D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public static bool ShouldShowWatchButtonInMenus
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x7D7AA70", Offset = "0x7D79270", VA = "0x187D7AA70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		private static bool showWatchButtonInMenus
		{
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x7D7AE30", Offset = "0x7D79630", VA = "0x187D7AE30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public static bool ShouldRetainUIStateAndResetAfterDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x7D7A7D0", Offset = "0x7D78FD0", VA = "0x187D7A7D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public static bool UseAlwaysPresentPortalPanel
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x7D7ACA0", Offset = "0x7D794A0", VA = "0x187D7ACA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public static AppNavMenu Instance
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x7D7A2F0", Offset = "0x7D78AF0", VA = "0x187D7A2F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public bool ShouldUseAppNav
		{
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x7D7AC50", Offset = "0x7D79450", VA = "0x187D7AC50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public bool CanOpenAppNavWhenWatchIsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xD9B8E0", Offset = "0xD9A0E0", VA = "0x180D9B8E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x11C77A0", Offset = "0x11C5FA0", VA = "0x1811C77A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool IsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0xD9B8F0", Offset = "0xD9A0F0", VA = "0x180D9B8F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xD99E60", Offset = "0xD98660", VA = "0x180D99E60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool IsTransitionActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x26DDB30", Offset = "0x26DC330", VA = "0x1826DDB30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x1601860", Offset = "0x1600060", VA = "0x181601860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public bool ShouldOpenLastActivePanel
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x1601F10", Offset = "0x1600710", VA = "0x181601F10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x16016C0", Offset = "0x15FFEC0", VA = "0x1816016C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool IsToolMenuOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x1601F20", Offset = "0x1600720", VA = "0x181601F20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x15FD7C0", Offset = "0x15FBFC0", VA = "0x1815FD7C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public bool WasOpenOnNavigation
		{
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0xFA4450", Offset = "0xFA2C50", VA = "0x180FA4450")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0xFA4B90", Offset = "0xFA3390", VA = "0x180FA4B90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7D78F90", Offset = "0x7D77790", VA = "0x187D78F90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7D79A30", Offset = "0x7D78230", VA = "0x187D79A30")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7D797D0", Offset = "0x7D77FD0", VA = "0x187D797D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7D78E30", Offset = "0x7D77630", VA = "0x187D78E30")]
		public void AddAppNavRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7D79BE0", Offset = "0x7D783E0", VA = "0x187D79BE0")]
		public void RemoveAppNavRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7D79A70", Offset = "0x7D78270", VA = "0x187D79A70")]
		public void OpenMenuWithPreviousPanel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7D79A80", Offset = "0x7D78280", VA = "0x187D79A80", Slot = "5")]
		public void OpenMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7D79700", Offset = "0x7D77F00", VA = "0x187D79700", Slot = "6")]
		public void CloseMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7D79B50", Offset = "0x7D78350", VA = "0x187D79B50", Slot = "7")]
		public void OpenWatch()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7D79B30", Offset = "0x7D78330", VA = "0x187D79B30")]
		public void OpenPage(string pageIdentifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7D79FB0", Offset = "0x7D787B0", VA = "0x187D79FB0")]
		[IteratorStateMachine(typeof(<WaitForOpenMenu>d__80))]
		private IEnumerator WaitForOpenMenu()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7D79F30", Offset = "0x7D78730", VA = "0x187D79F30")]
		[IteratorStateMachine(typeof(<WaitForCloseMenu>d__81))]
		private IEnumerator WaitForCloseMenu()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7D7A030", Offset = "0x7D78830", VA = "0x187D7A030")]
		[IteratorStateMachine(typeof(<WaitToOpenWatch>d__82))]
		private IEnumerator WaitToOpenWatch()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7D79E90", Offset = "0x7D78690", VA = "0x187D79E90")]
		private void SetMenuClosedState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7D79D40", Offset = "0x7D78540", VA = "0x187D79D40")]
		private void SetCanvasSize(Vector2 size)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7D7A160", Offset = "0x7D78960", VA = "0x187D7A160")]
		public AppNavMenu()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class AppNavPanel : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private sealed class <RegisterAfterOneFrame>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public AppNavPanel <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000B9")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BA")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002C7")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
			[DebuggerHidden]
			public <RegisterAfterOneFrame>d__10(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x7D8E130", Offset = "0x7D8C930", VA = "0x187D8E130", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0x7D8E1F0", Offset = "0x7D8C9F0", VA = "0x187D8E1F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private string panelIdentifierOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private HydrateBase hydration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private AppNavPanelSwitcher panelSwitcher;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public string Identifier
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public HydrateBase Hydration
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7D7BCA0", Offset = "0x7D7A4A0", VA = "0x187D7BCA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7D7BA50", Offset = "0x7D7A250", VA = "0x187D7BA50")]
		[IteratorStateMachine(typeof(<RegisterAfterOneFrame>d__10))]
		private IEnumerator RegisterAfterOneFrame()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7D7BAD0", Offset = "0x7D7A2D0", VA = "0x187D7BAD0")]
		public void SetIdentifier(string identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7D7BD90", Offset = "0x7D7A590", VA = "0x187D7BD90")]
		public AppNavPanel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public class AppNavPanelSwitcher : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private sealed class <SwapPanels>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public AppNavPanelSwitcher <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public string targetIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			private bool <startedSwapWithValidCurrentPanel>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			private AppNavPanel <targetPanel>5__3;

			[Cpp2IlInjected.Token(Token = "0x170000BC")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002D9")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BD")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
			[DebuggerHidden]
			public <SwapPanels>d__24(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x7D8E240", Offset = "0x7D8CA40", VA = "0x187D8E240", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x7D8E7D0", Offset = "0x7D8CFD0", VA = "0x187D8E7D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private sealed class <WaitThenClose>d__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public AppNavPanelSwitcher <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000BE")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BF")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
			[DebuggerHidden]
			public <WaitThenClose>d__25(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x7D903C0", Offset = "0x7D8EBC0", VA = "0x187D903C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x7D90650", Offset = "0x7D8EE50", VA = "0x187D90650", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private sealed class <OpenTopLevelOnly>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001DF")]
			public AppNavPanelSwitcher <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000C0")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002E5")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C1")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002E7")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
			[DebuggerHidden]
			public <OpenTopLevelOnly>d__26(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x7D8DFE0", Offset = "0x7D8C7E0", VA = "0x187D8DFE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x7D8E0E0", Offset = "0x7D8C8E0", VA = "0x187D8E0E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class <CloseTopLevelOnly>d__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001E0")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001E1")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001E2")]
			public AppNavPanelSwitcher <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000C2")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002EB")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C3")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002ED")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
			[DebuggerHidden]
			public <CloseTopLevelOnly>d__27(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A630", Offset = "0x7D88E30", VA = "0x187D8A630", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A740", Offset = "0x7D88F40", VA = "0x187D8A740", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		[SerializeField]
		private float initialWaitBeforeCloseTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		[SerializeField]
		private float initialOpenHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[SerializeField]
		private CanvasScreenSizeRefitter screenSizeRefitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[SerializeField]
		private HydrateBase topLevelHydration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[SerializeField]
		private float topLevelHydrationDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		[SerializeField]
		private DataResolver currentPanelResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		[SerializeField]
		private DataResolver targetPanelResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private Dictionary<string, AppNavPanel> panelLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private string currentPanelIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		private AppNavPanel currentPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		private Coroutine panelSwitchCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private Coroutine initialOpenCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private Vector3 cachedInitialPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public KECNPIDOCPH AllPanelsClosed;

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool SwitchingPanels
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x6E01400", Offset = "0x6DFFC00", VA = "0x186E01400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7D7AFC0", Offset = "0x7D797C0", VA = "0x187D7AFC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B6C0", Offset = "0x7D79EC0", VA = "0x187D7B6C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x17360C0", Offset = "0x17348C0", VA = "0x1817360C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B120", Offset = "0x7D79920", VA = "0x187D7B120")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B2C0", Offset = "0x7D79AC0", VA = "0x187D7B2C0")]
		public void RegisterPanel(AppNavPanel panel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B7E0", Offset = "0x7D79FE0", VA = "0x187D7B7E0")]
		public void UnregisterPanel(AppNavPanel panel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B1D0", Offset = "0x7D799D0", VA = "0x187D7B1D0")]
		private void OnTargetPanelUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B3B0", Offset = "0x7D79BB0", VA = "0x187D7B3B0")]
		private void RequestTargetPanel(string identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B750", Offset = "0x7D79F50", VA = "0x187D7B750")]
		[IteratorStateMachine(typeof(<SwapPanels>d__24))]
		private IEnumerator SwapPanels(string targetIdentifier)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B880", Offset = "0x7D7A080", VA = "0x187D7B880")]
		[IteratorStateMachine(typeof(<WaitThenClose>d__25))]
		private IEnumerator WaitThenClose()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B240", Offset = "0x7D79A40", VA = "0x187D7B240")]
		[IteratorStateMachine(typeof(<OpenTopLevelOnly>d__26))]
		private IEnumerator OpenTopLevelOnly()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B0A0", Offset = "0x7D798A0", VA = "0x187D7B0A0")]
		[IteratorStateMachine(typeof(<CloseTopLevelOnly>d__27))]
		private IEnumerator CloseTopLevelOnly()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B900", Offset = "0x7D7A100", VA = "0x187D7B900")]
		public AppNavPanelSwitcher()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public class AppNavTutorial : TutorialHighlightTargeter
	{
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public const string ShowAppNavTutorialParameterName = "enable_app_nav_tutorial";

		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private const string tutorialCompletionKey = "AppNavTutorialCompleted";

		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private const string tutorialSoftExitKey = "AppNavTutorialSoftExit";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[SerializeField]
		private UITutorialData tutorialDataRecord;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[SerializeField]
		private AppNavMenu appNavMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		[SerializeField]
		private string idOfOpenAppNavStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		[SerializeField]
		private string idOfWidgetStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[SerializeField]
		private string idOfPortalStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[SerializeField]
		private int allowedSoftExits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private Tutorial tutorial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private NHOAHDCMOCH preferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private OKNMANBEBON statsig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private bool canShowTutorial;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public static AppNavTutorial Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x7D7D190", Offset = "0x7D7B990", VA = "0x187D7D190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x7D7D1D0", Offset = "0x7D7B9D0", VA = "0x187D7D1D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7D7BE00", Offset = "0x7D7A600", VA = "0x187D7BE00", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7D7CD90", Offset = "0x7D7B590", VA = "0x187D7CD90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C830", Offset = "0x7D7B030", VA = "0x187D7C830")]
		public void StartTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7D7CDD0", Offset = "0x7D7B5D0", VA = "0x187D7CDD0")]
		public void StopTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C370", Offset = "0x7D7AB70", VA = "0x187D7C370")]
		private void OnCanUseAppNavChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C4C0", Offset = "0x7D7ACC0", VA = "0x187D7C4C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C4B0", Offset = "0x7D7ACB0", VA = "0x187D7C4B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C3E0", Offset = "0x7D7ABE0", VA = "0x187D7C3E0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C2F0", Offset = "0x7D7AAF0", VA = "0x187D7C2F0")]
		private void OnAppNavOpened()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C280", Offset = "0x7D7AA80", VA = "0x187D7C280")]
		private void OnAppNavClosed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C4D0", Offset = "0x7D7ACD0", VA = "0x187D7C4D0")]
		private void OnStepChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C050", Offset = "0x7D7A850", VA = "0x187D7C050")]
		private void ClearTutorialEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C7E0", Offset = "0x7D7AFE0", VA = "0x187D7C7E0")]
		private void OnTutorialStarted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x7D7C6C0", Offset = "0x7D7AEC0", VA = "0x187D7C6C0")]
		private void OnTutorialExited()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x7D7D0E0", Offset = "0x7D7B8E0", VA = "0x187D7D0E0")]
		public AppNavTutorial()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[ViewModel]
	public class AppNavViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private struct <FetchPanelIds>d__48 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400020E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			public AppNavViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			private CancellationToken <token>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			private TaskAwaiter<List<string>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000212")]
			private string <newDefault>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			private List<string>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			private string <panelId>5__5;

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x7D8AEB0", Offset = "0x7D896B0", VA = "0x187D8AEB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x7D8B620", Offset = "0x7D89E20", VA = "0x187D8B620", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private const string UnifiedUISessionIdKey = "unified_ui_session_id";

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		private float reopenToLastPanelThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private string activePanelIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private string nextPanelIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private DataList<string> widgetPanelIdentifiers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private float availableHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private Guid sessionGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private bool portalPanelAlwaysPresent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private bool portalPanelAlwaysPresentForTouch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private bool portalPanelAlwaysPresentForScreens;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		private FKEACPHKBJP analyticsHelper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		private IMenuManager menuManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private string defaultPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private float lastCloseTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private DataItem<string> ActivePanelIdentifierDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private DataItem<string> NextPanelIdentifierDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private DataItem<float> AvailableHeightDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private DataItem<Guid> SessionGuidDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private DataItem<bool> PortalPanelAlwaysPresentDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private DataItem<bool> PortalPanelAlwaysPresentForTouchDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private DataItem<bool> PortalPanelAlwaysPresentForScreensDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private DataItemList WidgetPanelIdentifiersDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private DataItemAction CloseDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string ActivePanelIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0xA27510", Offset = "0xA25D10", VA = "0x180A27510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x7D7EC70", Offset = "0x7D7D470", VA = "0x187D7EC70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string NextPanelIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0xA274C0", Offset = "0xA25CC0", VA = "0x180A274C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x7D7ED20", Offset = "0x7D7D520", VA = "0x187D7ED20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public DataList<string> WidgetPanelIdentifiers
		{
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0xA35070", Offset = "0xA33870", VA = "0x180A35070")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x7D7F320", Offset = "0x7D7DB20", VA = "0x187D7F320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public float AvailableHeight
		{
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x178BE10", Offset = "0x178A610", VA = "0x18178BE10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x7D7ED90", Offset = "0x7D7D590", VA = "0x187D7ED90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public Guid SessionGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x7D7EE00", Offset = "0x7D7D600", VA = "0x187D7EE00")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x7D7EE10", Offset = "0x7D7D610", VA = "0x187D7EE10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public bool PortalPanelAlwaysPresent
		{
			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x1CFCFC0", Offset = "0x1CFB7C0", VA = "0x181CFCFC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x7D7EE90", Offset = "0x7D7D690", VA = "0x187D7EE90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool PortalPanelAlwaysPresentForTouch
		{
			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x7C80080", Offset = "0x7C7E880", VA = "0x187C80080")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x7D7EAE0", Offset = "0x7D7D2E0", VA = "0x187D7EAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		[BindableData(7, null, DataPermissions.ReadWrite)]
		public bool PortalPanelAlwaysPresentForScreens
		{
			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x1D1F2F0", Offset = "0x1D1DAF0", VA = "0x181D1F2F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x7D7EB40", Offset = "0x7D7D340", VA = "0x187D7EB40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		public string PreviousPanelIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0xABDCA0", Offset = "0xABC4A0", VA = "0x180ABDCA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0xABDC80", Offset = "0xABC480", VA = "0x180ABDC80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x7D7F2E0", Offset = "0x7D7DAE0", VA = "0x187D7F2E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x7D7D220", Offset = "0x7D7BA20", VA = "0x187D7D220", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x7D7E450", Offset = "0x7D7CC50", VA = "0x187D7E450")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x7D7E4A0", Offset = "0x7D7CCA0", VA = "0x187D7E4A0")]
		public void Open(string panelIdentifier = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x7D7D6C0", Offset = "0x7D7BEC0", VA = "0x187D7D6C0")]
		[BindableAction(100, null)]
		public void Close()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x7D7D920", Offset = "0x7D7C120", VA = "0x187D7D920")]
		[AsyncStateMachine(typeof(<FetchPanelIds>d__48))]
		private Task FetchPanelIds()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x7D7E910", Offset = "0x7D7D110", VA = "0x187D7E910")]
		private void SetAlwaysPortalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7D7DBC0", Offset = "0x7D7C3C0", VA = "0x187D7DBC0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x7D7DA00", Offset = "0x7D7C200", VA = "0x187D7DA00")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7D7EEF0", Offset = "0x7D7D6F0", VA = "0x187D7EEF0")]
		public AppNavViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[ViewModel]
	public class DevToolsViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private Uri debugToolsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		private Uri testCaseManagementUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[SerializeField]
		private Uri bugReportingUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[SerializeField]
		private Uri componentLibraryUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private bool canAccessDevTools;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private bool developerToolsActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private bool shouldShowDebugTools;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private DataItem<bool> CanAccessDevToolsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private DataItem<bool> DeveloperToolsActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private DataItem<bool> ShouldShowDebugToolsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private DataItemAction OpenDebugToolsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private DataItemAction OpenTestCaseManagementDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private DataItemAction OpenBugReportingDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private DataItemAction OpenComponentLibraryDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool CanAccessDevTools
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0xC6D850", Offset = "0xC6C050", VA = "0x180C6D850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x7D7FEE0", Offset = "0x7D7E6E0", VA = "0x187D7FEE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool DeveloperToolsActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0xE8A080", Offset = "0xE88880", VA = "0x180E8A080")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x7D7FF40", Offset = "0x7D7E740", VA = "0x187D7FF40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public bool ShouldShowDebugTools
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0xE8A090", Offset = "0xE88890", VA = "0x180E8A090")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x7D7FFA0", Offset = "0x7D7E7A0", VA = "0x187D7FFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x7D80350", Offset = "0x7D7EB50", VA = "0x187D80350", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x7D7F380", Offset = "0x7D7DB80", VA = "0x187D7F380", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x7D7FD00", Offset = "0x7D7E500", VA = "0x187D7FD00")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x7D80000", Offset = "0x7D7E800", VA = "0x187D80000")]
		private void UpdateBasedOnLocalAccount()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x7D7FE20", Offset = "0x7D7E620", VA = "0x187D7FE20")]
		[BindableAction(100, null)]
		private void OpenDebugTools()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x7D7FE80", Offset = "0x7D7E680", VA = "0x187D7FE80")]
		[BindableAction(101, null)]
		private void OpenTestCaseManagement()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x7D7FD60", Offset = "0x7D7E560", VA = "0x187D7FD60")]
		[BindableAction(102, null)]
		private void OpenBugReporting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x7D7FDC0", Offset = "0x7D7E5C0", VA = "0x187D7FDC0")]
		[BindableAction(103, null)]
		private void OpenComponentLibrary()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x7D7F780", Offset = "0x7D7DF80", VA = "0x187D7F780", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x7D7F600", Offset = "0x7D7DE00", VA = "0x187D7F600")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x7D80160", Offset = "0x7D7E960", VA = "0x187D80160")]
		public DevToolsViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public interface IAppNavMenu
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[ViewModel]
	public class PortalButtonViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		[SerializeField]
		private UILinkLookup routeLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private PortalButtonConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private IRRUIvNextStoreItemBridge storeBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private LinkInfo linkInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		private string iconName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private DataItem<string> IconNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private DataItemAction OpenRouteDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x7D85660", Offset = "0x7D83E60", VA = "0x187D85660", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xA35020", Offset = "0xA33820", VA = "0x180A35020")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x7D856E0", Offset = "0x7D83EE0", VA = "0x187D856E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string IconName
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0xA8DF30", Offset = "0xA8C730", VA = "0x180A8DF30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x7D85760", Offset = "0x7D83F60", VA = "0x187D85760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x7D85620", Offset = "0x7D83E20", VA = "0x187D85620", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x7D85330", Offset = "0x7D83B30", VA = "0x187D85330")]
		[BindableAction(2, null)]
		public void OpenRoute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x7D84900", Offset = "0x7D83100", VA = "0x187D84900", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x7D84D60", Offset = "0x7D83560", VA = "0x187D84D60")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x7D84A80", Offset = "0x7D83280", VA = "0x187D84A80", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x7D84990", Offset = "0x7D83190", VA = "0x187D84990")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x7D854C0", Offset = "0x7D83CC0", VA = "0x187D854C0")]
		public PortalButtonViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[ViewModel]
	public class PortalPanelViewModel : RRUIBaseGlobalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private struct <FetchPortalPanelData>d__25 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000240")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000241")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000242")]
			public PortalPanelViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000243")]
			private TaskAwaiter<PortalPanelConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x7D8B680", Offset = "0x7D89E80", VA = "0x187D8B680", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x7D8BA90", Offset = "0x7D8A290", VA = "0x187D8BA90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		[CompilerGenerated]
		private struct <WaitThenUpdateBackplate>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000244")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000245")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000246")]
			public PortalPanelViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000247")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x7D906A0", Offset = "0x7D8EEA0", VA = "0x187D906A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private CancellationTokenSource cancellationTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		[SerializeField]
		private List<RectTransform> backplateRects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		[SerializeField]
		private Vector2 verticalBackplatePadding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		[SerializeField]
		private RectTransform sectionParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		[SerializeField]
		private RectTransform trayButtonParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private DataList<PortalButtonGroupConfig> sections;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private bool hasWidget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private string widgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private bool portalPanelOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private DataItem<bool> HasWidgetDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private DataItem<string> WidgetIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		private DataItem<bool> PortalPanelOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private DataItemList SectionsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private DataItemAction TogglePanelStateDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<PortalButtonGroupConfig> Sections
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xA27510", Offset = "0xA25D10", VA = "0x180A27510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x7D86B90", Offset = "0x7D85390", VA = "0x187D86B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool HasWidget
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xDC2EA0", Offset = "0xDC16A0", VA = "0x180DC2EA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x7D86130", Offset = "0x7D84930", VA = "0x187D86130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string WidgetId
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0xA35070", Offset = "0xA33870", VA = "0x180A35070")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x7D86190", Offset = "0x7D84990", VA = "0x187D86190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool PortalPanelOpen
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0xC6D850", Offset = "0xC6C050", VA = "0x180C6D850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x7D86200", Offset = "0x7D84A00", VA = "0x187D86200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x7D86B50", Offset = "0x7D85350", VA = "0x187D86B50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x7D857E0", Offset = "0x7D83FE0", VA = "0x187D857E0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x7D860B0", Offset = "0x7D848B0", VA = "0x187D860B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x7D86080", Offset = "0x7D84880", VA = "0x187D86080", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x7D85990", Offset = "0x7D84190", VA = "0x187D85990")]
		[AsyncStateMachine(typeof(<FetchPortalPanelData>d__25))]
		private Task FetchPortalPanelData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x7D867F0", Offset = "0x7D84FF0", VA = "0x187D867F0")]
		[AsyncStateMachine(typeof(<WaitThenUpdateBackplate>d__26))]
		private void WaitThenUpdateBackplate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x7D86330", Offset = "0x7D84B30", VA = "0x187D86330")]
		private void UpdateBackplateRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x7D860C0", Offset = "0x7D848C0", VA = "0x187D860C0")]
		[BindableAction(100, null)]
		private void TogglePanelState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x7D85BA0", Offset = "0x7D843A0", VA = "0x187D85BA0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x7D85A60", Offset = "0x7D84260", VA = "0x187D85A60")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x7D868A0", Offset = "0x7D850A0", VA = "0x187D868A0")]
		public PortalPanelViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[ViewModel]
	public class PortalSectionViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private PortalButtonGroupConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private string sectionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private string iconName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		private DataList<PortalButtonConfig> buttons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private DataItem<string> SectionNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private DataItem<string> IconNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private DataItemList ButtonsDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x7D876A0", Offset = "0x7D85EA0", VA = "0x187D876A0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string SectionName
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0xA27510", Offset = "0xA25D10", VA = "0x180A27510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x7D87340", Offset = "0x7D85B40", VA = "0x187D87340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string IconName
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0xA274C0", Offset = "0xA25CC0", VA = "0x180A274C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x7D873B0", Offset = "0x7D85BB0", VA = "0x187D873B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public DataList<PortalButtonConfig> Buttons
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0xA35070", Offset = "0xA33870", VA = "0x180A35070")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x7D87720", Offset = "0x7D85F20", VA = "0x187D87720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x7D87660", Offset = "0x7D85E60", VA = "0x187D87660", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x7D87010", Offset = "0x7D85810", VA = "0x187D87010")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7D86CE0", Offset = "0x7D854E0", VA = "0x187D86CE0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x7D86BF0", Offset = "0x7D853F0", VA = "0x187D86BF0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7D874F0", Offset = "0x7D85CF0", VA = "0x187D874F0")]
		public PortalSectionViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[ViewModel]
	public class WidgetPanelViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		[CompilerGenerated]
		private struct <FetchWidgetData>d__19 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400025F")]
			public WidgetPanelViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			private int <currentCount>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			private TaskAwaiter<List<string>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x7D8BAF0", Offset = "0x7D8A2F0", VA = "0x187D8BAF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x7D8C230", Offset = "0x7D8AA30", VA = "0x187D8C230", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		[SerializeField]
		private float defaultHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		[SerializeField]
		private int maximumWidgetCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		[SerializeField]
		private WidgetPrefabMapping widgetPrefabMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		[SerializeField]
		private AppNavPanel panel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		[SerializeField]
		private DataResolver availableHeightResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private string panelId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private float maxHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private float currentHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private List<string> tempList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private DataList<string> widgetIdList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private DataItemList WidgetIdListDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x7D91550", Offset = "0x7D8FD50", VA = "0x187D91550", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<string> WidgetIdList
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0xA8E350", Offset = "0xA8CB50", VA = "0x180A8E350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x7D915D0", Offset = "0x7D8FDD0", VA = "0x187D915D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x7D91510", Offset = "0x7D8FD10", VA = "0x187D91510", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7D90930", Offset = "0x7D8F130", VA = "0x187D90930", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7D911D0", Offset = "0x7D8F9D0", VA = "0x187D911D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7D91030", Offset = "0x7D8F830", VA = "0x187D91030", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x7D90C00", Offset = "0x7D8F400", VA = "0x187D90C00")]
		[AsyncStateMachine(typeof(<FetchWidgetData>d__19))]
		public Task FetchWidgetData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7D90F30", Offset = "0x7D8F730", VA = "0x187D90F30")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7D90B20", Offset = "0x7D8F320", VA = "0x187D90B20")]
		private void CheckIfShouldFetchData(string changedPanelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x7D90BA0", Offset = "0x7D8F3A0", VA = "0x187D90BA0")]
		private void DoFetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x7D90ED0", Offset = "0x7D8F6D0", VA = "0x187D90ED0")]
		private void OnAvailableHeightUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7D90D80", Offset = "0x7D8F580", VA = "0x187D90D80", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x7D90CD0", Offset = "0x7D8F4D0", VA = "0x187D90CD0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7D91390", Offset = "0x7D8FB90", VA = "0x187D91390")]
		public WidgetPanelViewModel()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class WidgetInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public string Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public AssetReference WidgetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public float MaxHeight;

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7D908E0", Offset = "0x7D8F0E0", VA = "0x187D908E0")]
		public WidgetInfo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CreateAssetMenu(fileName = "WidgetPrefabMapping", menuName = "RecRoom/UI/App Nav/Widget Prefab Mapping")]
	public class WidgetPrefabMapping : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public List<WidgetInfo> widgetPrefabs;

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7D91640", Offset = "0x7D8FE40", VA = "0x187D91640")]
		public bool TryGetReference(string widgetId, [Out] AssetReference reference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7D917D0", Offset = "0x7D8FFD0", VA = "0x187D917D0")]
		public bool TryGetWidgetHeight(string widgetId, [Out] float height)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xC33770", Offset = "0xC31F70", VA = "0x180C33770")]
		public WidgetPrefabMapping()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[ViewModel]
	public class WidgetWrapperViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private struct <UpdateWidget>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000275")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000276")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000277")]
			public string widgetId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000278")]
			public WidgetWrapperViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000279")]
			private string <typeId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400027A")]
			private AssetReference <reference>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400027B")]
			private AsyncOperationHandle<GameObject> <refHandle>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400027C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x7D8F470", Offset = "0x7D8DC70", VA = "0x187D8F470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x7D8FD60", Offset = "0x7D8E560", VA = "0x187D8FD60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class <MonitorWidgetForSizeChanges>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400027D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400027E")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400027F")]
			public WidgetWrapperViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000280")]
			private RectTransform <widgetTransform>5__2;

			[Cpp2IlInjected.Token(Token = "0x170000EE")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003B8")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000EF")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003BA")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
			[DebuggerHidden]
			public <MonitorWidgetForSizeChanges>d__23(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x7D8C290", Offset = "0x7D8AA90", VA = "0x187D8C290", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x7D8C5E0", Offset = "0x7D8ADE0", VA = "0x187D8C5E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public const string WIDGET_ID_PROPERTY = "widget_id";

		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public const string WIDGET_TYPE_PROPERTY = "widget_type_id";

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		[SerializeField]
		private WidgetPrefabMapping prefabMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		[SerializeField]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		[SerializeField]
		private DataResolver sessionIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		[SerializeField]
		private bool forceWidgetToFitWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private string widgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private AssetReference widgetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private GameObject instantiatedWidget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private ImpressionTracker widgetImpressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private Vector2 cachedWidgetSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private Coroutine widgetSizeCheckCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private DataItem<string> WidgetIdDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string WidgetId
		{
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0xA35010", Offset = "0xA33810", VA = "0x180A35010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x7D92280", Offset = "0x7D90A80", VA = "0x187D92280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x7D92200", Offset = "0x7D90A00", VA = "0x187D92200", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x7D921C0", Offset = "0x7D909C0", VA = "0x187D921C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x7D91950", Offset = "0x7D90150", VA = "0x187D91950", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7D91EB0", Offset = "0x7D906B0", VA = "0x187D91EB0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x7D91E60", Offset = "0x7D90660", VA = "0x187D91E60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x7D91CA0", Offset = "0x7D904A0", VA = "0x187D91CA0")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x7D91FB0", Offset = "0x7D907B0", VA = "0x187D91FB0")]
		[AsyncStateMachine(typeof(<UpdateWidget>d__22))]
		public Task UpdateWidget(string widgetId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x7D91C20", Offset = "0x7D90420", VA = "0x187D91C20")]
		[IteratorStateMachine(typeof(<MonitorWidgetForSizeChanges>d__23))]
		private IEnumerator MonitorWidgetForSizeChanges()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x7D91F50", Offset = "0x7D90750", VA = "0x187D91F50")]
		private void ReleaseWidgetReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x7D91AD0", Offset = "0x7D902D0", VA = "0x187D91AD0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x7D91A20", Offset = "0x7D90220", VA = "0x187D91A20")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x7D920C0", Offset = "0x7D908C0", VA = "0x187D920C0")]
		public WidgetWrapperViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[ViewModel]
	public class AccountsWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private struct <OnWidgetIdChanged>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000288")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000289")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400028A")]
			public AccountsWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400028B")]
			private TaskAwaiter<AccountListQueryData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x7D8CA60", Offset = "0x7D8B260", VA = "0x187D8CA60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private IAppNavDataManager _appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private IRRUIvNextAccountBridge _vNextAccountBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		[SerializeField]
		private AccountListViewModel accountListViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private AccountListQueryData _queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private DataItem<AccountListQueryData> QueryDataDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public AccountListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0xA35010", Offset = "0xA33810", VA = "0x180A35010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x7D78CF0", Offset = "0x7D774F0", VA = "0x187D78CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x7D78DF0", Offset = "0x7D775F0", VA = "0x187D78DF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7D787C0", Offset = "0x7D76FC0", VA = "0x187D787C0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7D78B90", Offset = "0x7D77390", VA = "0x187D78B90", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7D78C40", Offset = "0x7D77440", VA = "0x187D78C40")]
		[AsyncStateMachine(typeof(<OnWidgetIdChanged>d__10))]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7D78A40", Offset = "0x7D77240", VA = "0x187D78A40", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7D78990", Offset = "0x7D77190", VA = "0x187D78990")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7D78D60", Offset = "0x7D77560", VA = "0x187D78D60")]
		public AccountsWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[ViewModel]
	public class LocalPlayerWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private struct <FetchDataAsync>d__40 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002AB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002AC")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002AD")]
			public LocalPlayerWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002AE")]
			private TaskAwaiter<KDEGGCDDKFJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A790", Offset = "0x7D88F90", VA = "0x187D8A790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private const int INVALID_TOKEN_BALANCE = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		[SerializeField]
		private AccountViewModel accountViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		[SerializeField]
		private bool manuallySetWidgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		[SerializeField]
		private Uri profilePageUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		[SerializeField]
		private LinkInfo profileLinkInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		[SerializeField]
		private Uri notificationsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		[SerializeField]
		private LinkInfo notificationsLinkInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		[SerializeField]
		private Uri settingsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		[SerializeField]
		private LinkInfo settingsLinkInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		[SerializeField]
		private Uri rrPlusSubscriptionUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private string profilePictureName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private string userName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private bool hasUnreadNotifications;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private long tokenBalance;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private bool hasRecRoomPlus;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private IAccountQueryManager accountManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private IRecRoomPlusDataManager rrPlusDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private int localPlayerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private DataItem<string> ProfilePictureNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private DataItem<string> UserNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private DataItem<bool> HasUnreadNotificationsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private DataItem<long> TokenBalanceDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		private DataItem<bool> HasRecRoomPlusDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private DataItemAction GoToProfilePageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private DataItemAction GoToNotificationsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private DataItemAction GoToSettingsPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private DataItemAction GoToRRPlusPageDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string ProfilePictureName
		{
			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0xA2B840", Offset = "0xA2A040", VA = "0x180A2B840")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0x7D81C30", Offset = "0x7D80430", VA = "0x187D81C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0xDF01C0", Offset = "0xDEE9C0", VA = "0x180DF01C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x7D81BA0", Offset = "0x7D803A0", VA = "0x187D81BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string UserName
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0xABDC30", Offset = "0xABC430", VA = "0x180ABDC30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x7D81CB0", Offset = "0x7D804B0", VA = "0x187D81CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool HasUnreadNotifications
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0xF77E80", Offset = "0xF76680", VA = "0x180F77E80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x7D81740", Offset = "0x7D7FF40", VA = "0x187D81740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public long TokenBalance
		{
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0xABDCA0", Offset = "0xABC4A0", VA = "0x180ABDCA0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003D2")]
			[Cpp2IlInjected.Address(RVA = "0x7D817A0", Offset = "0x7D7FFA0", VA = "0x187D817A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public bool HasRecRoomPlus
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0xDFA140", Offset = "0xDF8940", VA = "0x180DFA140")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x7D816B0", Offset = "0x7D7FEB0", VA = "0x187D816B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x7D81B60", Offset = "0x7D80360", VA = "0x187D81B60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7D80390", Offset = "0x7D7EB90", VA = "0x187D80390", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x7D81540", Offset = "0x7D7FD40", VA = "0x187D81540")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x7D805E0", Offset = "0x7D7EDE0", VA = "0x187D805E0")]
		[AsyncStateMachine(typeof(<FetchDataAsync>d__40))]
		private void FetchDataAsync()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x7D815F0", Offset = "0x7D7FDF0", VA = "0x187D815F0")]
		private void RefreshTokenBalance()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7D80990", Offset = "0x7D7F190", VA = "0x187D80990")]
		[BindableAction(100, null)]
		private void GoToProfilePage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7D80880", Offset = "0x7D7F080", VA = "0x187D80880")]
		[BindableAction(101, null)]
		private void GoToNotifications()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7D80BD0", Offset = "0x7D7F3D0", VA = "0x187D80BD0")]
		[BindableAction(102, null)]
		private void GoToSettingsPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x7D80A90", Offset = "0x7D7F290", VA = "0x187D80A90")]
		[BindableAction(103, null)]
		private void GoToRRPlusPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x7D80CE0", Offset = "0x7D7F4E0", VA = "0x187D80CE0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x7D80690", Offset = "0x7D7EE90", VA = "0x187D80690")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7D81800", Offset = "0x7D80000", VA = "0x187D81800")]
		public LocalPlayerWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[ViewModel]
	public class MyDormWidgetViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		[SerializeField]
		private Uri thisRoomUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private IRoomLoadManager roomLoadManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private DataItemAction OpenThisRoomPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private DataItemAction GoToRecCenterDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private DataItemAction EvictAllDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0xA27510", Offset = "0xA25D10", VA = "0x180A27510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x7D82730", Offset = "0x7D80F30", VA = "0x187D82730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x7D82A10", Offset = "0x7D81210", VA = "0x187D82A10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7D81D30", Offset = "0x7D80530", VA = "0x187D81D30", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7D827A0", Offset = "0x7D80FA0", VA = "0x187D827A0")]
		private void UpdateUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7D82670", Offset = "0x7D80E70", VA = "0x187D82670")]
		[BindableAction(100, null)]
		private void OpenThisRoomPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7D82180", Offset = "0x7D80980", VA = "0x187D82180")]
		[BindableAction(101, null)]
		private void GoToRecCenter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x7D81F60", Offset = "0x7D80760", VA = "0x187D81F60")]
		[BindableAction(102, null)]
		private void EvictAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x7D82610", Offset = "0x7D80E10", VA = "0x187D82610")]
		private void OnJoinRoomResponse(JDDBDBPJKDB result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x7D822D0", Offset = "0x7D80AD0", VA = "0x187D822D0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x7D82070", Offset = "0x7D80870", VA = "0x187D82070")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x7D828B0", Offset = "0x7D810B0", VA = "0x187D828B0")]
		public MyDormWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[ViewModel]
	public class PartyWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct <OnPartyChanged>d__39 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002D6")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002D7")]
			public PartyWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002D8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0x7D8C630", Offset = "0x7D8AE30", VA = "0x187D8C630", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct <UpdatePartyData>d__40 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002DA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			public PartyWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			private TaskAwaiter<List<int>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x7D8EC50", Offset = "0x7D8D450", VA = "0x187D8EC50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0x7D8F410", Offset = "0x7D8DC10", VA = "0x187D8F410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		[SerializeField]
		private Uri createPartyUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		[SerializeField]
		private Uri managePartyUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		[SerializeField]
		private Uri openPartyChatUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		[SerializeField]
		private float notInPartyHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		[SerializeField]
		private float inPartyHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private bool inParty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private bool partyChatAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private bool canGoToParty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x83")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private bool canAddToParty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private DataList<int> partyMembers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private int partyMemberCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		private bool hasUnreadPartyChatMessages;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		private IRRUIvNextSocialBridge socialBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private bool updatePending;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private bool updateQueued;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private DataItem<bool> InPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private DataItem<bool> PartyChatAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private DataItem<bool> CanGoToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private DataItem<bool> CanAddToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private DataItem<int> PartyMemberCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private DataItem<bool> HasUnreadPartyChatMessagesDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private DataItemList PartyMembersDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private DataItemAction CreateOrJoinPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private DataItemAction OpenPartyChatDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private DataItemAction GoToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private DataItemAction AddToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private DataItemAction ManagePartyDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool InParty
		{
			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0xC6D850", Offset = "0xC6C050", VA = "0x180C6D850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x7D841F0", Offset = "0x7D829F0", VA = "0x187D841F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool PartyChatAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x6000401")]
			[Cpp2IlInjected.Address(RVA = "0xE8A080", Offset = "0xE88880", VA = "0x180E8A080")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0x7D84250", Offset = "0x7D82A50", VA = "0x187D84250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public bool CanGoToParty
		{
			[Cpp2IlInjected.Token(Token = "0x6000403")]
			[Cpp2IlInjected.Address(RVA = "0xE8A090", Offset = "0xE88890", VA = "0x180E8A090")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000404")]
			[Cpp2IlInjected.Address(RVA = "0x7D842B0", Offset = "0x7D82AB0", VA = "0x187D842B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool CanAddToParty
		{
			[Cpp2IlInjected.Token(Token = "0x6000405")]
			[Cpp2IlInjected.Address(RVA = "0x1447100", Offset = "0x1445900", VA = "0x181447100")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x7D84310", Offset = "0x7D82B10", VA = "0x187D84310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public DataList<int> PartyMembers
		{
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0xA35020", Offset = "0xA33820", VA = "0x180A35020")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0x7D84890", Offset = "0x7D83090", VA = "0x187D84890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public int PartyMemberCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xA35050", Offset = "0xA33850", VA = "0x180A35050")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x7D84370", Offset = "0x7D82B70", VA = "0x187D84370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool HasUnreadPartyChatMessages
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x1CFCFC0", Offset = "0x1CFB7C0", VA = "0x181CFCFC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x7D840C0", Offset = "0x7D828C0", VA = "0x187D840C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0x7D84850", Offset = "0x7D83050", VA = "0x187D84850", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x7D82B20", Offset = "0x7D81320", VA = "0x187D82B20", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x7D83C30", Offset = "0x7D82430", VA = "0x187D83C30", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x7D83D90", Offset = "0x7D82590", VA = "0x187D83D90")]
		[AsyncStateMachine(typeof(<OnPartyChanged>d__39))]
		private void OnPartyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0x7D843D0", Offset = "0x7D82BD0", VA = "0x187D843D0")]
		[AsyncStateMachine(typeof(<UpdatePartyData>d__40))]
		private Task UpdatePartyData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0x7D83FB0", Offset = "0x7D827B0", VA = "0x187D83FB0")]
		private void SetHeight()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x7D83E40", Offset = "0x7D82640", VA = "0x187D83E40")]
		private void OnPartyChatUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x7D82DD0", Offset = "0x7D815D0", VA = "0x187D82DD0")]
		[BindableAction(100, null)]
		private void CreateOrJoinParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x7D83EE0", Offset = "0x7D826E0", VA = "0x187D83EE0")]
		[BindableAction(101, null)]
		private void OpenPartyChat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x7D830D0", Offset = "0x7D818D0", VA = "0x187D830D0")]
		[BindableAction(102, null)]
		private void GoToParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x7D82A50", Offset = "0x7D81250", VA = "0x187D82A50")]
		[BindableAction(103, null)]
		private void AddToParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x7D83B60", Offset = "0x7D82360", VA = "0x187D83B60")]
		[BindableAction(104, null)]
		private void ManageParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x7D83190", Offset = "0x7D81990", VA = "0x187D83190", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x7D82EA0", Offset = "0x7D816A0", VA = "0x187D82EA0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x7D844A0", Offset = "0x7D82CA0", VA = "0x187D844A0")]
		public PartyWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public class RoomCarouselWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct <OnWidgetIdChanged>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002E4")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002E5")]
			public RoomCarouselWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002E6")]
			private string <widgetId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002E7")]
			private WidgetSourceData <widgetSourceData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002E8")]
			private TaskAwaiter<IReadOnlyList<DJANCJIHPPH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0x7D8D890", Offset = "0x7D8C090", VA = "0x187D8D890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		[SerializeField]
		private RoomListViewModel roomListViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private RoomListQueryData queryData;

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x7D87780", Offset = "0x7D85F80", VA = "0x187D87780", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(RVA = "0x7D87950", Offset = "0x7D86150", VA = "0x187D87950", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(RVA = "0x7D87A00", Offset = "0x7D86200", VA = "0x187D87A00")]
		[AsyncStateMachine(typeof(<OnWidgetIdChanged>d__7))]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x7D87AB0", Offset = "0x7D862B0", VA = "0x187D87AB0")]
		public RoomCarouselWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[ViewModel]
	public class RoomCategoryCarouselWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct <OnWidgetIdChanged>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002F0")]
			public RoomCategoryCarouselWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002F1")]
			private string <widgetId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002F2")]
			private WidgetSourceData <widgetSourceData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002F3")]
			private TaskAwaiter<IReadOnlyList<DJANCJIHPPH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0x7D8D320", Offset = "0x7D8BB20", VA = "0x187D8D320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		[SerializeField]
		private RoomCategoryListViewModel categoryListViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000438")]
			[Cpp2IlInjected.Address(RVA = "0x7D87F00", Offset = "0x7D86700", VA = "0x187D87F00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(RVA = "0x7D87B30", Offset = "0x7D86330", VA = "0x187D87B30", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x7D87D90", Offset = "0x7D86590", VA = "0x187D87D90", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x7D87E40", Offset = "0x7D86640", VA = "0x187D87E40")]
		[AsyncStateMachine(typeof(<OnWidgetIdChanged>d__6))]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x7D87D80", Offset = "0x7D86580", VA = "0x187D87D80", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x7D87D00", Offset = "0x7D86500", VA = "0x187D87D00")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x7D87EF0", Offset = "0x7D866F0", VA = "0x187D87EF0")]
		public RoomCategoryCarouselWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[ViewModel]
	public class StoreItemsWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private struct <OnWidgetIdChanged>d__21 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000302")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000303")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000304")]
			public StoreItemsWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000305")]
			private TaskAwaiter<IReadOnlyList<DJANCJIHPPH>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000453")]
			[Cpp2IlInjected.Address(RVA = "0x7D8CDE0", Offset = "0x7D8B5E0", VA = "0x187D8CDE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private struct <TryLoadingFromActiveSourceList>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			public StoreItemsWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			private TaskAwaiter<IReadOnlyList<DJANCJIHPPH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x7D8E820", Offset = "0x7D8D020", VA = "0x187D8E820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x7D8EBE0", Offset = "0x7D8D3E0", VA = "0x187D8EBE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private struct <OnQueryDataLoaded>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public StoreItemsWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x7D8C8B0", Offset = "0x7D8B0B0", VA = "0x187D8C8B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		[SerializeField]
		private int maxItemsInList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private IRRUIvNextBridge _vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private IRRUIvNextStoreItemBridge storeBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private IAppNavDataManager _appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private BrowserModel _browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private List<WidgetSourceData> sourceList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private int activeSectionIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private WidgetSourceData widgetSourceData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		[SerializeField]
		private StoreItemListViewModel storeItemListViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private StoreItemListQueryData _queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private DataItem<StoreItemListQueryData> QueryDataDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private DataItemAction GoToStorePageDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		private MBPHGEGJLJE Room
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0x7D89390", Offset = "0x7D87B90", VA = "0x187D89390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		private bool CanShowRelatedStoreItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0x7D891A0", Offset = "0x7D879A0", VA = "0x187D891A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public StoreItemListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0xDF01C0", Offset = "0xDEE9C0", VA = "0x180DF01C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0x7D89050", Offset = "0x7D87850", VA = "0x187D89050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600044C")]
			[Cpp2IlInjected.Address(RVA = "0x7D89350", Offset = "0x7D87B50", VA = "0x187D89350", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600044D")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x7D882D0", Offset = "0x7D86AD0", VA = "0x187D882D0")]
		[BindableAction(100, null)]
		private void GoToStorePage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x7D87F40", Offset = "0x7D86740", VA = "0x187D87F40", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x7D886A0", Offset = "0x7D86EA0", VA = "0x187D886A0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x7D88870", Offset = "0x7D87070", VA = "0x187D88870")]
		[AsyncStateMachine(typeof(<OnWidgetIdChanged>d__21))]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x7D88B30", Offset = "0x7D87330", VA = "0x187D88B30")]
		[AsyncStateMachine(typeof(<TryLoadingFromActiveSourceList>d__22))]
		private Task<bool> TryLoadingFromActiveSourceList()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(RVA = "0x7D88920", Offset = "0x7D87120", VA = "0x187D88920")]
		private bool TryLoadSection(DJANCJIHPPH section)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000449")]
		[Cpp2IlInjected.Address(RVA = "0x7D88A60", Offset = "0x7D87260", VA = "0x187D88A60")]
		private bool TryLoadSource(string source, string sourceMetadata)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x7D88C20", Offset = "0x7D87420", VA = "0x187D88C20")]
		private bool TrySetQueryData(string source, string sourceMetadata)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x7D887C0", Offset = "0x7D86FC0", VA = "0x187D887C0")]
		[AsyncStateMachine(typeof(<OnQueryDataLoaded>d__26))]
		private void OnQueryDataLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044E")]
		[Cpp2IlInjected.Address(RVA = "0x7D884A0", Offset = "0x7D86CA0", VA = "0x187D884A0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(RVA = "0x7D88200", Offset = "0x7D86A00", VA = "0x187D88200")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000450")]
		[Cpp2IlInjected.Address(RVA = "0x7D890C0", Offset = "0x7D878C0", VA = "0x187D890C0")]
		public StoreItemsWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[ViewModel]
	public class ThisRoomWidgetViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		[SerializeField]
		private Uri thisRoomUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private bool canReportRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private IRoomLoadManager roomLoadManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private DataItem<bool> CanReportRoomDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private DataItemAction OpenThisRoomPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private DataItemAction GoToDormDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private DataItemAction ReportRoomDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private DataItemAction GoToRecCenterDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0xA27510", Offset = "0xA25D10", VA = "0x180A27510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A1E0", Offset = "0x7D889E0", VA = "0x187D8A1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool CanReportRoom
		{
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0xDC2EA0", Offset = "0xDC16A0", VA = "0x180DC2EA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A250", Offset = "0x7D88A50", VA = "0x187D8A250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000464")]
			[Cpp2IlInjected.Address(RVA = "0x7D8A5F0", Offset = "0x7D88DF0", VA = "0x187D8A5F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000465")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x7D893D0", Offset = "0x7D87BD0", VA = "0x187D893D0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A2B0", Offset = "0x7D88AB0", VA = "0x187D8A2B0")]
		private void UpdateUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x7D89F00", Offset = "0x7D88700", VA = "0x187D89F00")]
		[BindableAction(100, null)]
		private void OpenThisRoomPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x7D897B0", Offset = "0x7D87FB0", VA = "0x187D897B0")]
		[BindableAction(101, null)]
		private void GoToDorm()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x7D89FC0", Offset = "0x7D887C0", VA = "0x187D89FC0")]
		[BindableAction(102, null)]
		private void ReportRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x7D89860", Offset = "0x7D88060", VA = "0x187D89860")]
		[BindableAction(103, null)]
		private void GoToRecCenter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x7D89EA0", Offset = "0x7D886A0", VA = "0x187D89EA0")]
		private void OnJoinRoomResponse(JDDBDBPJKDB result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x7D899D0", Offset = "0x7D881D0", VA = "0x187D899D0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x7D89650", Offset = "0x7D87E50", VA = "0x187D89650")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x7D8A400", Offset = "0x7D88C00", VA = "0x187D8A400")]
		public ThisRoomWidgetViewModel()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class AssetReferenceInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		public string Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		public AssetReference Asset;

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x7D92300", Offset = "0x7D90B00", VA = "0x187D92300")]
		public AssetReferenceInfo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CreateAssetMenu(fileName = "AssetReferenceLookup", menuName = "RecRoom/UI/Asset Reference Lookup")]
	public class AssetReferenceLookup : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		[SerializeField]
		private List<AssetReferenceInfo> assetReferences;

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x7D92350", Offset = "0x7D90B50", VA = "0x187D92350")]
		public bool TryGetAssetReference(string assetId, [Out] AssetReference assetReference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0xC33770", Offset = "0xC31F70", VA = "0x180C33770")]
		public AssetReferenceLookup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[ViewModel]
	public class StoreItemListViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private struct <FetchData>d__35 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			public StoreItemListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			private TaskAwaiter<IReadOnlyList<PNBLFFBKHJH>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000491")]
			[Cpp2IlInjected.Address(RVA = "0x7DAA6C0", Offset = "0x7DA8EC0", VA = "0x187DAA6C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000492")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private static readonly List<GNKIJBCJIGH> ImmediateUnifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		public KECNPIDOCPH OnDataFetched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private BrowserModel _browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private IRRUIvNextBridge _vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private IRRUIvNextStoreItemBridge _vNextStoreItemBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private IStoreItemQueryManager _storeItemListQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private CancellationTokenSource _cancellationTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private bool _waitingForQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private int _minItemsCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		[SerializeField]
		private StoreItemListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private DataList<GNKIJBCJIGH> _storeItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private string _displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private bool _isEmptyOrBelowMinimum;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private DataItem<StoreItemListQueryData> QueryDataDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private DataItem<bool> IsEmptyOrBelowMinimumDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private DataItemList StoreItemIdsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private DataItemAction GoToViewMorePageDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		public int MinItemsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000470")]
			[Cpp2IlInjected.Address(RVA = "0x58DAB50", Offset = "0x58D9350", VA = "0x1858DAB50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000471")]
			[Cpp2IlInjected.Address(RVA = "0x7DA7BE0", Offset = "0x7DA63E0", VA = "0x187DA7BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		[BindableData(0, "The query data used to retrieve the store item list", DataPermissions.ReadOnly)]
		public StoreItemListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x6000474")]
			[Cpp2IlInjected.Address(RVA = "0xA34FB0", Offset = "0xA337B0", VA = "0x180A34FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public DataList<GNKIJBCJIGH> StoreItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0xA8E350", Offset = "0xA8CB50", VA = "0x180A8E350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0x7DA7C10", Offset = "0x7DA6410", VA = "0x187DA7C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		[BindableData(2, "The name of the list that can be shown on the UI, e.g. as a carousel title", DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0xA2B840", Offset = "0xA2A040", VA = "0x180A2B840")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0x7DA7B60", Offset = "0x7DA6360", VA = "0x187DA7B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool IsEmptyOrBelowMinimum
		{
			[Cpp2IlInjected.Token(Token = "0x6000479")]
			[Cpp2IlInjected.Address(RVA = "0xFA4450", Offset = "0xFA2C50", VA = "0x180FA4450")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600047A")]
			[Cpp2IlInjected.Address(RVA = "0x7DA76B0", Offset = "0x7DA5EB0", VA = "0x187DA76B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0x7DA7B20", Offset = "0x7DA6320", VA = "0x187DA7B20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x7DA6EF0", Offset = "0x7DA56F0", VA = "0x187DA6EF0")]
		public void SetDiscoverySectionId(string sectionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x7DA6FA0", Offset = "0x7DA57A0", VA = "0x187DA6FA0")]
		public void SetParentTabName(string parentTabName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x7DA6650", Offset = "0x7DA4E50", VA = "0x187DA6650")]
		[BindableAction(100, null)]
		private void GoToViewMorePage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x7DA61C0", Offset = "0x7DA49C0", VA = "0x187DA61C0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x7DA7630", Offset = "0x7DA5E30", VA = "0x187DA7630")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x7DA6E50", Offset = "0x7DA5650", VA = "0x187DA6E50", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x7DA7130", Offset = "0x7DA5930", VA = "0x187DA7130")]
		public void SetQueryData(StoreItemListQueryData listQueryData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x7DA7050", Offset = "0x7DA5850", VA = "0x187DA7050")]
		public void SetPropertiesToDefaults()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x7DA62C0", Offset = "0x7DA4AC0", VA = "0x187DA62C0")]
		[AsyncStateMachine(typeof(<FetchData>d__35))]
		public void FetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x7DA64B0", Offset = "0x7DA4CB0", VA = "0x187DA64B0")]
		private string GetDisplayName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x7DA7260", Offset = "0x7DA5A60", VA = "0x187DA7260")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x7DA6980", Offset = "0x7DA5180", VA = "0x187DA6980", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x7DA6370", Offset = "0x7DA4B70", VA = "0x187DA6370")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x7DA7870", Offset = "0x7DA6070", VA = "0x187DA7870")]
		public StoreItemListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[ViewModel]
	public class StoreItemViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		[CompilerGenerated]
		private struct <FetchStoreItemData>d__54 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public StoreItemViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			private TaskAwaiter<PNBLFFBKHJH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0x7DABA90", Offset = "0x7DAA290", VA = "0x187DABA90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private static BMELPJIFPCL Log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private BrowserModel _browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		private IRRUIvNextBridge _vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private IRRUIvNextStoreItemBridge _vNextStoreItemBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private Uri itemDetailsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private string _thumbnailImageFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private string costText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private bool isOnSale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private string saleText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private bool isLimitedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private string limitedTimeText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private bool isOwned;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private bool isRecRoomPlusExclusive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private GNKIJBCJIGH storeItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private long price;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private DataItem<string> ThumbnailImageFilenameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private DataItem<string> CostTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private DataItem<bool> IsOnSaleDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		private DataItem<string> SaleTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private DataItem<bool> IsLimitedTimeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private DataItem<string> LimitedTimeTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private DataItem<bool> IsOwnedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private DataItem<bool> IsRecRoomPlusExclusiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private DataItem<GNKIJBCJIGH> StoreItemIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private DataItem<long> PriceDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private DataItemAction GoToDetailsPageDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000493")]
			[Cpp2IlInjected.Address(RVA = "0x7DAA110", Offset = "0x7DA8910", VA = "0x187DAA110", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string ThumbnailImageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x6000494")]
			[Cpp2IlInjected.Address(RVA = "0xA35010", Offset = "0xA33810", VA = "0x180A35010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0x7DAA640", Offset = "0x7DA8E40", VA = "0x187DAA640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		[BindableData(1, "The sanitized, friendly name of the store item", DataPermissions.ReadOnly)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0xA35020", Offset = "0xA33820", VA = "0x180A35020")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000497")]
			[Cpp2IlInjected.Address(RVA = "0x7DAA210", Offset = "0x7DA8A10", VA = "0x187DAA210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		[BindableData(2, "The price of the item (including strikethrough for discounts or 'Owned' if owned)", DataPermissions.ReadOnly)]
		public string CostText
		{
			[Cpp2IlInjected.Token(Token = "0x6000498")]
			[Cpp2IlInjected.Address(RVA = "0xA8DF30", Offset = "0xA8C730", VA = "0x180A8DF30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000499")]
			[Cpp2IlInjected.Address(RVA = "0x7DAA190", Offset = "0x7DA8990", VA = "0x187DAA190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		[BindableData(3, "Whether or not the item is currently on sale (has a discount)", DataPermissions.ReadOnly)]
		public bool IsOnSale
		{
			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0xECB790", Offset = "0xEC9F90", VA = "0x180ECB790")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x7DAA2F0", Offset = "0x7DA8AF0", VA = "0x187DAA2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		[BindableData(4, "Text to show on the sale banner", DataPermissions.ReadOnly)]
		public string SaleText
		{
			[Cpp2IlInjected.Token(Token = "0x600049C")]
			[Cpp2IlInjected.Address(RVA = "0xA8E350", Offset = "0xA8CB50", VA = "0x180A8E350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0x7DAA490", Offset = "0x7DA8C90", VA = "0x187DAA490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		[BindableData(5, "Whether or not to show the 'Limited Time' banner", DataPermissions.ReadOnly)]
		public bool IsLimitedTime
		{
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0xA8DF40", Offset = "0xA8C740", VA = "0x180A8DF40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0x7DAA290", Offset = "0x7DA8A90", VA = "0x187DAA290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		[BindableData(6, "Text to show on the 'Limited Time' banner", DataPermissions.ReadOnly)]
		public string LimitedTimeText
		{
			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0xDF01C0", Offset = "0xDEE9C0", VA = "0x180DF01C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0x7DAA410", Offset = "0x7DA8C10", VA = "0x187DAA410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		[BindableData(7, "Whether or not the player owns this item", DataPermissions.ReadOnly)]
		public bool IsOwned
		{
			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xCF2CA0", Offset = "0xCF14A0", VA = "0x180CF2CA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x7DAA350", Offset = "0x7DA8B50", VA = "0x187DAA350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		[BindableData(8, "Whether or not to show the 'Rec Room Plus Exclusive' icon", DataPermissions.ReadOnly)]
		public bool IsRecRoomPlusExclusive
		{
			[Cpp2IlInjected.Token(Token = "0x60004A4")]
			[Cpp2IlInjected.Address(RVA = "0xA8F4E0", Offset = "0xA8DCE0", VA = "0x180A8F4E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A5")]
			[Cpp2IlInjected.Address(RVA = "0x7DAA3B0", Offset = "0x7DA8BB0", VA = "0x187DAA3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		[BindableData(9, "The ID used to retrieve the IStoreItem from RecNet", DataPermissions.ReadWrite)]
		public GNKIJBCJIGH StoreItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60004A6")]
			[Cpp2IlInjected.Address(RVA = "0x7DA90E0", Offset = "0x7DA78E0", VA = "0x187DA90E0")]
			get
			{
				return default(GNKIJBCJIGH);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A7")]
			[Cpp2IlInjected.Address(RVA = "0x7DAA510", Offset = "0x7DA8D10", VA = "0x187DAA510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		[BindableData(10, "The price of the item after any applicable discounts", DataPermissions.ReadWrite)]
		public long Price
		{
			[Cpp2IlInjected.Token(Token = "0x60004A8")]
			[Cpp2IlInjected.Address(RVA = "0xA2B7D0", Offset = "0xA29FD0", VA = "0x180A2B7D0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x7DA9130", Offset = "0x7DA7930", VA = "0x187DA9130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x7DAA0D0", Offset = "0x7DA88D0", VA = "0x187DAA0D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x7DA8030", Offset = "0x7DA6830", VA = "0x187DA8030")]
		[BindableAction(100, null)]
		private void GoToDetailsPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x7DA7C80", Offset = "0x7DA6480", VA = "0x187DA7C80", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x7DA8B80", Offset = "0x7DA7380", VA = "0x187DA8B80")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AD")]
		[Cpp2IlInjected.Address(RVA = "0x7DA7D50", Offset = "0x7DA6550", VA = "0x187DA7D50")]
		[AsyncStateMachine(typeof(<FetchStoreItemData>d__54))]
		private void FetchStoreItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AE")]
		[Cpp2IlInjected.Address(RVA = "0x7DA91A0", Offset = "0x7DA79A0", VA = "0x187DA91A0")]
		private void UpdateStoreItemData(PNBLFFBKHJH storeItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x7DA8E60", Offset = "0x7DA7660", VA = "0x187DA8E60")]
		private void ResetStoreItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x7DA8CE0", Offset = "0x7DA74E0", VA = "0x187DA8CE0")]
		private void RecordImpressionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B3")]
		[Cpp2IlInjected.Address(RVA = "0x7DA81F0", Offset = "0x7DA69F0", VA = "0x187DA81F0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B4")]
		[Cpp2IlInjected.Address(RVA = "0x7DA7E00", Offset = "0x7DA6600", VA = "0x187DA7E00")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B5")]
		[Cpp2IlInjected.Address(RVA = "0x7DA9CC0", Offset = "0x7DA84C0", VA = "0x187DA9CC0")]
		public StoreItemViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	public enum CarouselType
	{
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		Room,
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		Event,
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		Club,
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		Invention,
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		StoreItem,
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		CustomAvatarItem,
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		Account
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	public enum HighlightStyle
	{
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		Scale150,
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		Portrait,
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		Scale75,
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		Scale100,
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		FitPerRow4,
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		FitPerRow5,
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		FitPerRow6
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[CreateAssetMenu(fileName = "CarouselDisplayConfig", menuName = "RecRoom/UI/CarouselDisplayConfig")]
	public class CarouselDisplayConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		public struct HighlightCardDataObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			public DMGJGGMGIKH platformMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			public float cardWidth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public float cardHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			public HighlightStyle HighlightStyle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public bool VR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			[ReadOnlyField]
			[Tooltip("Carousel height is driven by the card height. Multi-row room carousels will add one 'Card Height' height per row.")]
			public float carouselHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public int cardLimit;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000084")]
		public struct CardDataObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			[ReadOnlyField]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			public CarouselType CarouselType;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public float carouselTitleHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			public float cardMetadataHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			[Tooltip("Carousel height is driven by the card height. Multi-row room carousels will add one 'Default Card Height' height per row.")]
			[ReadOnlyField]
			public float defaultCarouselHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			public float defaultCardWidth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			public float defaultCardHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			public int defaultCardLimitWithScroll;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			public int defaultCardLimitWithNoScroll;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			public RectOffset singleRowCarouselPadding;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			public RectOffset multiRowCarouselPadding;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			[FormerlySerializedAs("rowBottomPadding")]
			[Tooltip("Keep this in sync with the 'item spacing' value in Virtualized Scroll Rect List")]
			public int rowPaddingBottom;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		public struct DiscoveryVariantOverrides
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public string variantName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public int cardHeight;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		[SerializeField]
		public List<Uri> Uris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		[SerializeField]
		public bool allowCarouselHighlightingOnConfiguredUris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		[SerializeField]
		public bool allowEnforcingOrderedRenderingOnConfiguredUris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		[SerializeField]
		[Tooltip("Multiplies the number of cards per row by this factor as part of MaximumResultCount. This way, if carousel content is deduplicated, there will still be cards to fill in the empty space left in the carousel.")]
		private int dedupingMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036B")]
		[FormerlySerializedAs("minItemsToFetchPerRow")]
		[Tooltip("Puts a lower bound on number of fetched items as part of MaximumResultCount. This way, if carousel content is deduplicated, there will still be cards to fill in the empty space left in the carousel.")]
		[SerializeField]
		private int minItemsToFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		[SerializeField]
		private CardDataObject[] defaultCardList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		[SerializeField]
		private HighlightCardDataObject[] highlightRoomListConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		[SerializeField]
		private DiscoveryVariantOverrides[] discoveryVariantOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		private IRRUIvNextBridge VNextBridge
		{
			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0x7D93490", Offset = "0x7D91C90", VA = "0x187D93490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004C8")]
		[Cpp2IlInjected.Address(RVA = "0x7D93320", Offset = "0x7D91B20", VA = "0x187D93320")]
		public bool IsAnyConfiguredUriActive(BrowserModel browserModel)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004C9")]
		[Cpp2IlInjected.Address(RVA = "0x7D92AB0", Offset = "0x7D912B0", VA = "0x187D92AB0")]
		public float GetCardWidth(HighlightStyle highlightStyle, CarouselType carouselType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CA")]
		[Cpp2IlInjected.Address(RVA = "0x7D926B0", Offset = "0x7D90EB0", VA = "0x187D926B0")]
		public float GetCardHeight(HighlightStyle highlightStyle, CarouselType carouselType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CB")]
		[Cpp2IlInjected.Address(RVA = "0x7D92BF0", Offset = "0x7D913F0", VA = "0x187D92BF0")]
		public float GetCarouselHeight(HighlightStyle highlightStyle, CarouselType carouselType, int numRows = 1, bool addPadding = true)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CC")]
		[Cpp2IlInjected.Address(RVA = "0x7D92E50", Offset = "0x7D91650", VA = "0x187D92E50")]
		public RectOffset GetCarouselPadding(CarouselType carouselType, int numRows)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004CD")]
		[Cpp2IlInjected.Address(RVA = "0x7D92970", Offset = "0x7D91170", VA = "0x187D92970")]
		public int GetCardLimitPerRow(bool isHorizontalScrollEnabled, HighlightStyle highlightStyle, CarouselType carouselType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CE")]
		[Cpp2IlInjected.Address(RVA = "0x7D932F0", Offset = "0x7D91AF0", VA = "0x187D932F0")]
		public int GetTotalCardLimit(bool isHorizontalScrollEnabled, HighlightStyle highlightStyle, CarouselType carouselType, int maxRows = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004CF")]
		[Cpp2IlInjected.Address(RVA = "0x7D93240", Offset = "0x7D91A40", VA = "0x187D93240")]
		public int GetMinItemsToFetch(bool isHorizontalScrollEnabled, HighlightStyle highlightStyle, CarouselType carouselType, int maxRows = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D0")]
		[Cpp2IlInjected.Address(RVA = "0x7D92F40", Offset = "0x7D91740", VA = "0x187D92F40")]
		private HighlightCardDataObject GetFilteredDataObject(HighlightStyle highlightStyle)
		{
			return default(HighlightCardDataObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D1")]
		[Cpp2IlInjected.Address(RVA = "0x7D924E0", Offset = "0x7D90CE0", VA = "0x187D924E0")]
		private HighlightCardDataObject ApplyGameConfigOverrides(HighlightCardDataObject cardDataObject)
		{
			return default(HighlightCardDataObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60004D2")]
		[Cpp2IlInjected.Address(RVA = "0x7D93470", Offset = "0x7D91C70", VA = "0x187D93470")]
		public CarouselDisplayConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[ViewModel]
	public class CarouselViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private const int defaultMinItemsToFetch = 20;

		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private const int defaultCardLimitPerRow = 5;

		[Cpp2IlInjected.Token(Token = "0x4000391")]
		public const string HighlightStyleDefault = "highlight_default";

		[Cpp2IlInjected.Token(Token = "0x4000392")]
		public const string HighlightStyleScale150 = "highlight_scale_150";

		[Cpp2IlInjected.Token(Token = "0x4000393")]
		public const string HighlightStylePortrait = "highlight_portrait";

		[Cpp2IlInjected.Token(Token = "0x4000394")]
		public const string HighlightStyleScale75 = "highlight_scale_75";

		[Cpp2IlInjected.Token(Token = "0x4000395")]
		public const string HighlightStyleScale100 = "highlight_scale_100";

		[Cpp2IlInjected.Token(Token = "0x4000396")]
		public const string HighlightStyleFitPerRow4 = "highlight_fitperrow_4";

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		public const string HighlightStyleFitPerRow5 = "highlight_fitperrow_5";

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		public const string HighlightStyleFitPerRow6 = "highlight_fitperrow_6";

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		[SerializeField]
		private CarouselType carouselType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		[SerializeField]
		private CarouselDisplayConfig displayConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		[SerializeField]
		private DataResolver carouselListResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		[SerializeField]
		private DMGJGGMGIKH hidePageButtonsOnThesePlatforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private bool allowHorizontalScroll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private int rowCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private float? heightOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private float? widthOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private string backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private HighlightStyle highlightStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private Vector2 cardSizeOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private DiscoveryDisplayMetadata displayMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private string sourceLabelText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private int maxRowCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private int maxResultCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private DataItem<bool> AllowHorizontalScrollDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private DataItem<int> RowCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private DataItem<float?> HeightOverrideDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private DataItem<float?> WidthOverrideDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private DataItem<string> BackgroundColorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private DataItem<HighlightStyle> HighlightStyleDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		private DataItem<Vector2> CardSizeOverrideDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool AllowHorizontalScroll
		{
			[Cpp2IlInjected.Token(Token = "0x60004E3")]
			[Cpp2IlInjected.Address(RVA = "0xE435E0", Offset = "0xE41DE0", VA = "0x180E435E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E4")]
			[Cpp2IlInjected.Address(RVA = "0x7D94B80", Offset = "0x7D93380", VA = "0x187D94B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		[BindableData(1, "Number of rows in the carousel", DataPermissions.ReadWrite)]
		public int RowCount
		{
			[Cpp2IlInjected.Token(Token = "0x60004E5")]
			[Cpp2IlInjected.Address(RVA = "0xC94200", Offset = "0xC92A00", VA = "0x180C94200")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0x7D94BE0", Offset = "0x7D933E0", VA = "0x187D94BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		[BindableData(2, "The height override value, or null if there isn't one", DataPermissions.ReadWrite)]
		public float? HeightOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60004E7")]
			[Cpp2IlInjected.Address(RVA = "0x7D94C40", Offset = "0x7D93440", VA = "0x187D94C40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004E8")]
			[Cpp2IlInjected.Address(RVA = "0x7D950F0", Offset = "0x7D938F0", VA = "0x187D950F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		[BindableData(3, "The width override value, or null if there isn't one. Typically used for card width.", DataPermissions.ReadWrite)]
		public float? WidthOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60004E9")]
			[Cpp2IlInjected.Address(RVA = "0x7BFB390", Offset = "0x7BF9B90", VA = "0x187BFB390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004EA")]
			[Cpp2IlInjected.Address(RVA = "0x7D95180", Offset = "0x7D93980", VA = "0x187D95180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		[BindableData(4, "Background color of the carousel", DataPermissions.ReadWrite)]
		public string BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x60004EB")]
			[Cpp2IlInjected.Address(RVA = "0xA34FB0", Offset = "0xA337B0", VA = "0x180A34FB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004EC")]
			[Cpp2IlInjected.Address(RVA = "0x7D94FE0", Offset = "0x7D937E0", VA = "0x187D94FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		[BindableData(5, "Card Highlight Style", DataPermissions.ReadWrite)]
		public HighlightStyle HighlightStyle
		{
			[Cpp2IlInjected.Token(Token = "0x60004ED")]
			[Cpp2IlInjected.Address(RVA = "0xA34F50", Offset = "0xA33750", VA = "0x180A34F50")]
			get
			{
				return default(HighlightStyle);
			}
			[Cpp2IlInjected.Token(Token = "0x60004EE")]
			[Cpp2IlInjected.Address(RVA = "0x7D94AF0", Offset = "0x7D932F0", VA = "0x187D94AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		[BindableData(6, "The card width and height override value, or null if there isn't one. Used when overriding width alone is insufficient.", DataPermissions.ReadWrite)]
		public Vector2 CardSizeOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60004EF")]
			[Cpp2IlInjected.Address(RVA = "0x7D94B50", Offset = "0x7D93350", VA = "0x187D94B50")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0x7D95060", Offset = "0x7D93860", VA = "0x187D95060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		public int NumItemsToFetch
		{
			[Cpp2IlInjected.Token(Token = "0x60004F1")]
			[Cpp2IlInjected.Address(RVA = "0xC31B10", Offset = "0xC30310", VA = "0x180C31B10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004F2")]
			[Cpp2IlInjected.Address(RVA = "0xC31040", Offset = "0xC2F840", VA = "0x180C31040")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		public int MaxItemsToDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x60004F3")]
			[Cpp2IlInjected.Address(RVA = "0x1124DB0", Offset = "0x11235B0", VA = "0x181124DB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0x7D94FA0", Offset = "0x7D937A0", VA = "0x187D94FA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60004FC")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x7D93510", Offset = "0x7D91D10", VA = "0x187D93510", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x7D94A40", Offset = "0x7D93240", VA = "0x187D94A40", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x7D93790", Offset = "0x7D91F90", VA = "0x187D93790")]
		public void ConfigureCarousel(DiscoveryDisplayMetadata displayMetadata, string sourceLabelText)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x7D935D0", Offset = "0x7D91DD0", VA = "0x187D935D0")]
		private int CalculateNumItemsToFetch()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x7D94150", Offset = "0x7D92950", VA = "0x187D94150")]
		private HighlightStyle GetHighlightStyle()
		{
			return default(HighlightStyle);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x7D949B0", Offset = "0x7D931B0", VA = "0x187D949B0")]
		private void OnCarouselListUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x7D93990", Offset = "0x7D92190", VA = "0x187D93990")]
		private void FinishCarouselInit(int totalNumCards)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x7D94230", Offset = "0x7D92A30", VA = "0x187D94230", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x7D93FD0", Offset = "0x7D927D0", VA = "0x187D93FD0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FF")]
		[Cpp2IlInjected.Address(RVA = "0x7D94C80", Offset = "0x7D93480", VA = "0x187D94C80")]
		public CarouselViewModel()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	public class DiscoveryDisplayMetadata : BaseDiscoveryDisplayMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		public string DisplayTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		public bool supportsDedupe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		public int numRows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		public string sizePerPlatform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		public string backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		public bool horizontalScrollEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		public int itemCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		public string cardStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		public int minItemsToShowSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		public string textColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		public bool showNewThisSessionForSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		public string sessionSectionIdOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		public string descriptionText;

		[Cpp2IlInjected.Token(Token = "0x600050E")]
		[Cpp2IlInjected.Address(RVA = "0x7D9BC90", Offset = "0x7D9A490", VA = "0x187D9BC90")]
		public DiscoveryDisplayMetadata()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[ViewModel]
	public class ConsumableListViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		[SerializeField]
		private IRRUIvNextConsumableBridge.ConsumableCategory listType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		[SerializeField]
		private Route shopRoute;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private IRRUIvNextConsumableBridge consumableBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private IRRUIvNextStoreItemBridge storeBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private DataList<OIKCNNCCGJE> consumableList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private DataItemList ConsumableListDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private DataItemAction OpenShopDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<OIKCNNCCGJE> ConsumableList
		{
			[Cpp2IlInjected.Token(Token = "0x600050F")]
			[Cpp2IlInjected.Address(RVA = "0xA35020", Offset = "0xA33820", VA = "0x180A35020")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0x7D99980", Offset = "0x7D98180", VA = "0x187D99980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x7D99940", Offset = "0x7D98140", VA = "0x187D99940", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x7D993D0", Offset = "0x7D97BD0", VA = "0x187D993D0")]
		[BindableAction(1, null)]
		public void OpenShop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x7D98D50", Offset = "0x7D97550", VA = "0x187D98D50", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x7D992B0", Offset = "0x7D97AB0", VA = "0x187D992B0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x7D99280", Offset = "0x7D97A80", VA = "0x187D99280")]
		private void OnActiveConsumableChanged(OIKCNNCCGJE consumable, bool isActive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000515")]
		[Cpp2IlInjected.Address(RVA = "0x7D993C0", Offset = "0x7D97BC0", VA = "0x187D993C0")]
		private void OnPurchasedConsumableChanged(OIKCNNCCGJE consumable, bool added)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000516")]
		[Cpp2IlInjected.Address(RVA = "0x7D994E0", Offset = "0x7D97CE0", VA = "0x187D994E0")]
		private void RefreshConsumableList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x7D99080", Offset = "0x7D97880", VA = "0x187D99080", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051A")]
		[Cpp2IlInjected.Address(RVA = "0x7D98FB0", Offset = "0x7D977B0", VA = "0x187D98FB0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0x7D99810", Offset = "0x7D98010", VA = "0x187D99810")]
		public ConsumableListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[ViewModel]
	public class ConsumableViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private IRRUIvNextConsumableBridge consumableBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private OIKCNNCCGJE consumable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private NGCIPJABEMC mainImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private bool isActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		private DataItem<NGCIPJABEMC> MainImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		private DataItem<int> CountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		private DataItem<bool> IsActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		private DataItemAction UseConsumableDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x600051E")]
			[Cpp2IlInjected.Address(RVA = "0x7D9AC30", Offset = "0x7D99430", VA = "0x187D9AC30", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public NGCIPJABEMC MainImage
		{
			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0xA274C0", Offset = "0xA25CC0", VA = "0x180A274C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0x7D9A740", Offset = "0x7D98F40", VA = "0x187D9A740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(RVA = "0xE433D0", Offset = "0xE41BD0", VA = "0x180E433D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(RVA = "0x7D9A7A0", Offset = "0x7D98FA0", VA = "0x187D9A7A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool IsActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000523")]
			[Cpp2IlInjected.Address(RVA = "0xE435E0", Offset = "0xE41DE0", VA = "0x180E435E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000524")]
			[Cpp2IlInjected.Address(RVA = "0x7D9A7F0", Offset = "0x7D98FF0", VA = "0x187D9A7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600052C")]
			[Cpp2IlInjected.Address(RVA = "0x7D9ABF0", Offset = "0x7D993F0", VA = "0x187D9ABF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600052D")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x7D9A850", Offset = "0x7D99050", VA = "0x187D9A850")]
		[BindableAction(0, null)]
		public void UseConsumable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x7D999F0", Offset = "0x7D981F0", VA = "0x187D999F0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x7D9A190", Offset = "0x7D98990", VA = "0x187D9A190", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x7D9A040", Offset = "0x7D98840", VA = "0x187D9A040")]
		private void OnActiveConsumableChanged(OIKCNNCCGJE consumable, bool isActive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x7D9A660", Offset = "0x7D98E60", VA = "0x187D9A660", Slot = "14")]
		public override void SetBindingData(int sourceId, int itemId, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x7D9A250", Offset = "0x7D98A50", VA = "0x187D9A250")]
		private void RefreshData(OIKCNNCCGJE config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x7D9A080", Offset = "0x7D98880", VA = "0x187D9A080")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052E")]
		[Cpp2IlInjected.Address(RVA = "0x7D99C40", Offset = "0x7D98440", VA = "0x187D99C40", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052F")]
		[Cpp2IlInjected.Address(RVA = "0x7D99B30", Offset = "0x7D98330", VA = "0x187D99B30")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x7D9AA70", Offset = "0x7D99270", VA = "0x187D9AA70")]
		public ConsumableViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	public class GlobalDataViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		private int localAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		private long localRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		private long localRoomEventId;

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public int LocalAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000537")]
			[Cpp2IlInjected.Address(RVA = "0xA46F30", Offset = "0xA45730", VA = "0x180A46F30")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0x7D9C2D0", Offset = "0x7D9AAD0", VA = "0x187D9C2D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public long LocalRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000539")]
			[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600053A")]
			[Cpp2IlInjected.Address(RVA = "0x7D9C380", Offset = "0x7D9AB80", VA = "0x187D9C380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public long LocalRoomEventId
		{
			[Cpp2IlInjected.Token(Token = "0x600053B")]
			[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600053C")]
			[Cpp2IlInjected.Address(RVA = "0x7D9C320", Offset = "0x7D9AB20", VA = "0x187D9C320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x7D9C150", Offset = "0x7D9A950", VA = "0x187D9C150")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x7D9BCA0", Offset = "0x7D9A4A0", VA = "0x187D9BCA0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x7D9BE00", Offset = "0x7D9A600", VA = "0x187D9BE00")]
		private void OnLocalAccountUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x7D9BF50", Offset = "0x7D9A750", VA = "0x187D9BF50")]
		private void OnLocalRoomChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x7D9C2B0", Offset = "0x7D9AAB0", VA = "0x187D9C2B0")]
		public GlobalDataViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class LongPressInteractable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		[SerializeField]
		protected float longPressDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public KECNPIDOCPH OnLongClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public KECNPIDOCPH OnShortClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		protected float pressStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		protected bool pointerInside;

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0xDF60B0", Offset = "0xDF48B0", VA = "0x180DF60B0", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x7D9C400", Offset = "0x7D9AC00", VA = "0x187D9C400", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x7D9C3E0", Offset = "0x7D9ABE0", VA = "0x187D9C3E0", Slot = "6")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x7D9C410", Offset = "0x7D9AC10", VA = "0x187D9C410", Slot = "7")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000546")]
		[Cpp2IlInjected.Address(RVA = "0x7D9C470", Offset = "0x7D9AC70", VA = "0x187D9C470")]
		public LongPressInteractable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[ViewModel]
	public class CategoriesNestedItem : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private IMakerPenHUDBridge hudBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private int absoluteIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private CategoriesNestedListItem item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private string text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private bool isExpanded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private Sprite activeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private int depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private DataItem<string> TextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private DataItem<bool> IsExpandedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private DataItem<Sprite> ActiveIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private DataItem<int> DepthDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private DataItemAction SelectItemDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		private CategoriesNestedListConfig config
		{
			[Cpp2IlInjected.Token(Token = "0x6000547")]
			[Cpp2IlInjected.Address(RVA = "0x7D962D0", Offset = "0x7D94AD0", VA = "0x187D962D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0x7D96250", Offset = "0x7D94A50", VA = "0x187D96250", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0xA35070", Offset = "0xA33870", VA = "0x180A35070")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600054C")]
			[Cpp2IlInjected.Address(RVA = "0x7D95ED0", Offset = "0x7D946D0", VA = "0x187D95ED0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool IsExpanded
		{
			[Cpp2IlInjected.Token(Token = "0x600054D")]
			[Cpp2IlInjected.Address(RVA = "0xC6D850", Offset = "0xC6C050", VA = "0x180C6D850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600054E")]
			[Cpp2IlInjected.Address(RVA = "0x7D95F40", Offset = "0x7D94740", VA = "0x187D95F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public Sprite ActiveIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000550")]
			[Cpp2IlInjected.Address(RVA = "0xA35020", Offset = "0xA33820", VA = "0x180A35020")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000551")]
			[Cpp2IlInjected.Address(RVA = "0x7D96320", Offset = "0x7D94B20", VA = "0x187D96320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public int Depth
		{
			[Cpp2IlInjected.Token(Token = "0x6000552")]
			[Cpp2IlInjected.Address(RVA = "0xA35050", Offset = "0xA33850", VA = "0x180A35050")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(RVA = "0x7D95FB0", Offset = "0x7D947B0", VA = "0x187D95FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000555")]
			[Cpp2IlInjected.Address(RVA = "0x7D96210", Offset = "0x7D94A10", VA = "0x187D96210", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x7D95210", Offset = "0x7D93A10", VA = "0x187D95210", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x7D95B80", Offset = "0x7D94380", VA = "0x187D95B80", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x7D95BB0", Offset = "0x7D943B0", VA = "0x187D95BB0")]
		[BindableAction(2, null)]
		public void SelectItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x7D958A0", Offset = "0x7D940A0", VA = "0x187D958A0")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x7D953A0", Offset = "0x7D93BA0", VA = "0x187D953A0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x7D95260", Offset = "0x7D93A60", VA = "0x187D95260")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x7D96010", Offset = "0x7D94810", VA = "0x187D96010")]
		public CategoriesNestedItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[ViewModel]
	public class CategoriesNestedList : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private IMakerPenHUDBridge hudBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private DataList<int> activeIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private DataItemList ActiveIndicesDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		private CategoriesNestedListConfig config
		{
			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0x7D98240", Offset = "0x7D96A40", VA = "0x187D98240")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<int> ActiveIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000563")]
			[Cpp2IlInjected.Address(RVA = "0xA27510", Offset = "0xA25D10", VA = "0x180A27510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000564")]
			[Cpp2IlInjected.Address(RVA = "0x7D98290", Offset = "0x7D96A90", VA = "0x187D98290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0x7D98210", Offset = "0x7D96A10", VA = "0x187D98210", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000569")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x7D97890", Offset = "0x7D96090", VA = "0x187D97890", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x7D97D70", Offset = "0x7D96570", VA = "0x187D97D70", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x7D97F90", Offset = "0x7D96790", VA = "0x187D97F90")]
		private void OnIndexStateChanged(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x7D97C20", Offset = "0x7D96420", VA = "0x187D97C20", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0x7D97B70", Offset = "0x7D96370", VA = "0x187D97B70")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x7D98130", Offset = "0x7D96930", VA = "0x187D98130")]
		public CategoriesNestedList()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[ViewModel]
	public class ColorPickerCardViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private string colorName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public Enum shapeColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private bool isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private DataItem<int> IndexDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private DataItem<string> ColorNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private DataItem<Color> ColorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private DataItem<bool> IsSelectedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private DataItemAction SelectDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		[BindableData(1, "Which slot in the hotbar this represents", DataPermissions.ReadOnly)]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000571")]
			[Cpp2IlInjected.Address(RVA = "0xF79070", Offset = "0xF77870", VA = "0x180F79070")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0x7D98CA0", Offset = "0x7D974A0", VA = "0x187D98CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		[BindableData(2, "Color Name", DataPermissions.ReadOnly)]
		public string ColorName
		{
			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0xA274C0", Offset = "0xA25CC0", VA = "0x180A274C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0x7D98B70", Offset = "0x7D97370", VA = "0x187D98B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		[BindableData(3, "Color", DataPermissions.ReadOnly)]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x11AEDA0", Offset = "0x11AD5A0", VA = "0x1811AEDA0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0x7D98BE0", Offset = "0x7D973E0", VA = "0x187D98BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		[BindableData(5, "IsSelected", DataPermissions.ReadOnly)]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6000578")]
			[Cpp2IlInjected.Address(RVA = "0xA58640", Offset = "0xA56E40", VA = "0x180A58640")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0x7D98CF0", Offset = "0x7D974F0", VA = "0x187D98CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600057A")]
			[Cpp2IlInjected.Address(RVA = "0x7D98B30", Offset = "0x7D97330", VA = "0x187D98B30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600057B")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x7D98910", Offset = "0x7D97110", VA = "0x187D98910")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000570")]
		[Cpp2IlInjected.Address(RVA = "0x7D98810", Offset = "0x7D97010", VA = "0x187D98810", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000577")]
		[Cpp2IlInjected.Address(RVA = "0x7D98840", Offset = "0x7D97040", VA = "0x187D98840")]
		[BindableAction(4, "Selects Color")]
		public void Select()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057C")]
		[Cpp2IlInjected.Address(RVA = "0x7D98430", Offset = "0x7D96C30", VA = "0x187D98430", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x7D982F0", Offset = "0x7D96AF0", VA = "0x187D982F0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057E")]
		[Cpp2IlInjected.Address(RVA = "0x7D98960", Offset = "0x7D97160", VA = "0x187D98960")]
		public ColorPickerCardViewModel()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class CategoriesNestedListItem : ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public string Text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public bool IsExpanded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public Sprite ExpandedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public Sprite CollapsedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public CategoriesFilter Filter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		[Header("All children of the same parent should have both icons set, or none")]
		public List<CategoriesNestedListItem> Children;

		[Cpp2IlInjected.Token(Token = "0x6000583")]
		[Cpp2IlInjected.Address(RVA = "0x7D97530", Offset = "0x7D95D30", VA = "0x187D97530", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000584")]
		[Cpp2IlInjected.Address(RVA = "0x7D977E0", Offset = "0x7D95FE0", VA = "0x187D977E0")]
		public CategoriesNestedListItem()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public struct CategoriesFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public CategoriesFilterType filterType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		[Tooltip("Metadata for filterType = PaletteSearchFilter")]
		public string paletteSearchFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		[Tooltip("Metadata for paletteSortOption = SortOption")]
		public JPAJCKBNNJE paletteSortOption;
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public enum CategoriesFilterType
	{
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		PaletteSearchFilter,
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		Favorites,
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		RoomInventions
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[CreateAssetMenu(fileName = "CategoriesNestedListConfig", menuName = "RRUI/MakerPenHUD/Nested List/Categories Nested List Config")]
	public class CategoriesNestedListConfig : ScriptableObject, OGHNBHJOLCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		[SerializeField]
		private List<CategoriesNestedListItem> nestedListItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private List<CategoriesNestedListItem> clonedNestedListItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private List<int> activeIndices;

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		public List<CategoriesNestedListItem> ListItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000585")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000586")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		public LBOAOFAOKMM<int> OnIndexExpanded
		{
			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0xA2D540", Offset = "0xA2BD40", VA = "0x180A2D540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		public LBOAOFAOKMM<int> OnIndexCollapsed
		{
			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0xA2D5F0", Offset = "0xA2BDF0", VA = "0x180A2D5F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4F0", Offset = "0xA2BCF0", VA = "0x180A2D4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		public LBOAOFAOKMM<int> OnIndexSelected
		{
			[Cpp2IlInjected.Token(Token = "0x600058B")]
			[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0xA2D480", Offset = "0xA2BC80", VA = "0x180A2D480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x7D965B0", Offset = "0x7D94DB0", VA = "0x187D965B0", Slot = "6")]
		public List<int> GetActiveIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x7D96F70", Offset = "0x7D95770", VA = "0x187D96F70")]
		private void SetActiveIndices()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x7D96600", Offset = "0x7D94E00", VA = "0x187D96600", Slot = "7")]
		public int GetDepth(int idx)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x7D96920", Offset = "0x7D95120", VA = "0x187D96920", Slot = "8")]
		public bool IsChild(int parentIdx, int childIdx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x7D969D0", Offset = "0x7D951D0", VA = "0x187D969D0", Slot = "9")]
		public bool IsExpanded(int idx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x7D96A30", Offset = "0x7D95230", VA = "0x187D96A30", Slot = "10")]
		public bool IsParent(int childIdx, int parentIdx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x7D96EB0", Offset = "0x7D956B0", VA = "0x187D96EB0")]
		public void Select(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x7D964C0", Offset = "0x7D94CC0", VA = "0x187D964C0")]
		public void Expand(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x7D963D0", Offset = "0x7D94BD0", VA = "0x187D963D0")]
		public void Collapse(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x7D96B30", Offset = "0x7D95330", VA = "0x187D96B30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x7D966F0", Offset = "0x7D94EF0", VA = "0x187D966F0")]
		private bool IconsSetConsistently(List<CategoriesNestedListItem> items)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x7D96AE0", Offset = "0x7D952E0", VA = "0x187D96AE0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x7D97430", Offset = "0x7D95C30", VA = "0x187D97430")]
		public CategoriesNestedListConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[ViewModel]
	public class CreateModeHotbarSlotViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private Texture cachedTextureForNextUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private bool setImageNextUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private Texture image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private bool isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private bool isImageSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private bool isPaletteOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x83")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private bool? isSelectedAndPaletteNotOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private DataItem<int> IndexDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private DataItem<Texture> ImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private DataItem<bool> IsSelectedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private DataItem<bool> IsImageSetDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private DataItem<bool> IsPaletteOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private DataItem<bool> IsSelectedAndPaletteNotOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private DataItemAction SelectDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		[BindableData(1, "Which slot in the hotbar this represents", DataPermissions.ReadOnly)]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0xA50790", Offset = "0xA4EF90", VA = "0x180A50790")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x7D9BAB0", Offset = "0x7D9A2B0", VA = "0x187D9BAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		[BindableData(2, "The image that should be displayed for this hotbar item", DataPermissions.ReadOnly)]
		public Texture Image
		{
			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0xA35070", Offset = "0xA33870", VA = "0x180A35070")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600059F")]
			[Cpp2IlInjected.Address(RVA = "0x7D9B9A0", Offset = "0x7D9A1A0", VA = "0x187D9B9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		[BindableData(3, "Whether or not this is selected", DataPermissions.ReadOnly)]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60005A0")]
			[Cpp2IlInjected.Address(RVA = "0xC6D850", Offset = "0xC6C050", VA = "0x180C6D850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0x7D9BC10", Offset = "0x7D9A410", VA = "0x187D9BC10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		[BindableData(5, "Whether or not the Image property is set", DataPermissions.ReadOnly)]
		public bool IsImageSet
		{
			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0xE8A080", Offset = "0xE88880", VA = "0x180E8A080")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0x7D9BB00", Offset = "0x7D9A300", VA = "0x187D9BB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		[BindableData(6, "Whether or not the palette is open", DataPermissions.ReadOnly)]
		public bool IsPaletteOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60005A4")]
			[Cpp2IlInjected.Address(RVA = "0xE8A090", Offset = "0xE88890", VA = "0x180E8A090")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005A5")]
			[Cpp2IlInjected.Address(RVA = "0x7D9B460", Offset = "0x7D99C60", VA = "0x187D9B460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		[BindableData(7, "Whether or not this is selected", DataPermissions.ReadOnly)]
		public bool IsSelectedAndPaletteNotOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60005A6")]
			[Cpp2IlInjected.Address(RVA = "0x7D9B650", Offset = "0x7D99E50", VA = "0x187D9B650")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x7D9BB60", Offset = "0x7D9A360", VA = "0x187D9BB60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0x7D9B960", Offset = "0x7D9A160", VA = "0x187D9B960", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005A8")]
		[Cpp2IlInjected.Address(RVA = "0x7D9B4E0", Offset = "0x7D99CE0", VA = "0x187D9B4E0")]
		[BindableAction(4, "Selects this hotbar item")]
		public void Select()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A9")]
		[Cpp2IlInjected.Address(RVA = "0x7D9B560", Offset = "0x7D99D60", VA = "0x187D9B560")]
		public void SetImageInNextUpdate(Texture t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x7D9B580", Offset = "0x7D99D80", VA = "0x187D9B580")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x7D9B6F0", Offset = "0x7D99EF0", VA = "0x187D9B6F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x7D9B370", Offset = "0x7D99B70", VA = "0x187D9B370", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x7D9B460", Offset = "0x7D99C60", VA = "0x187D9B460")]
		private void OnPaletteToggled(bool isOpen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x7D9AE30", Offset = "0x7D99630", VA = "0x187D9AE30", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x7D9ACB0", Offset = "0x7D994B0", VA = "0x187D9ACB0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x7D9B730", Offset = "0x7D99F30", VA = "0x187D9B730")]
		public CreateModeHotbarSlotViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[ViewModel]
	public class MakerPenHUDCreateToolbarViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		[SerializeField]
		private GameObject palettePanelGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private bool paletteActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private bool paletteIsOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private DataItem<bool> PaletteIsOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private DataItem<bool> CreateModeRecolorIsAvailableDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private DataItemAction ClickPaletteButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private DataItemAction ClickRecolorButtonDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		[BindableData(3, "True if the palette is currently open", DataPermissions.ReadOnly)]
		public bool PaletteIsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60005BE")]
			[Cpp2IlInjected.Address(RVA = "0xCD1980", Offset = "0xCD0180", VA = "0x180CD1980")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005BF")]
			[Cpp2IlInjected.Address(RVA = "0x7D9CDC0", Offset = "0x7D9B5C0", VA = "0x187D9CDC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		[BindableData(4, "Recolor in create mode is not yet supported", DataPermissions.ReadOnly)]
		public bool CreateModeRecolorIsAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x60005C0")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60005C1")]
			[Cpp2IlInjected.Address(RVA = "0x7D9CD80", Offset = "0x7D9B580", VA = "0x187D9CD80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x7D9C530", Offset = "0x7D9AD30", VA = "0x187D9C530", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x7D9CB00", Offset = "0x7D9B300", VA = "0x187D9CB00", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x7D9C610", Offset = "0x7D9AE10", VA = "0x187D9C610")]
		[BindableAction(1, "Invoked when the palette button is clicked")]
		public void ClickPaletteButton()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x7D9CBD0", Offset = "0x7D9B3D0", VA = "0x187D9CBD0")]
		private void OnPaletteToggled(bool open)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		[BindableAction(2, "Invoked when the recolor button is clicked")]
		public void ClickRecolorButton()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C3")]
		[Cpp2IlInjected.Address(RVA = "0x7D9C7F0", Offset = "0x7D9AFF0", VA = "0x187D9C7F0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x7D9C6E0", Offset = "0x7D9AEE0", VA = "0x187D9C6E0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x7D9CC40", Offset = "0x7D9B440", VA = "0x187D9CC40")]
		public MakerPenHUDCreateToolbarViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[ViewModel]
	public class MakerPenHUDPaletteObjectViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		[FormerlySerializedAs("Index")]
		public int ObjectIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private bool favorited;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6D")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private bool canBeFavorited;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private Texture iconTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private bool isIconTextureSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private string objectName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private bool selected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private bool showActionButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private string actionButtonText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private bool setNameNextUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private bool setIconNextUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private Texture2D cachedIconTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private string cachedName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private DataItem<bool> FavoritedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private DataItem<bool> CanBeFavoritedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private DataItem<Texture> IconTextureDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private DataItem<bool> IsIconTextureSetDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		private DataItem<string> ObjectNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		private DataItem<bool> SelectedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		private DataItem<bool> ShowActionButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private DataItem<string> ActionButtonTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private DataItemAction ClickObjectDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private DataItemAction ClickFavoriteDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		private DataItemAction ClickActionButtonDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		[BindableData(1, "Whether or not the user has favorited this object", DataPermissions.ReadOnly)]
		public bool Favorited
		{
			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0xF64210", Offset = "0xF62A10", VA = "0x180F64210")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x7D9DEF0", Offset = "0x7D9C6F0", VA = "0x187D9DEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		[BindableData(8, "Whether or not the user can set this object as a favorite", DataPermissions.ReadOnly)]
		public bool CanBeFavorited
		{
			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0xF62020", Offset = "0xF60820", VA = "0x180F62020")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x7D9DE90", Offset = "0x7D9C690", VA = "0x187D9DE90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		[BindableData(2, "The image to use for the icon for the object", DataPermissions.ReadOnly)]
		public Texture IconTexture
		{
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0xA274C0", Offset = "0xA25CC0", VA = "0x180A274C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0x7D9DF50", Offset = "0x7D9C750", VA = "0x187D9DF50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		[BindableData(7, "True if the icon texture is set", DataPermissions.ReadOnly)]
		public bool IsIconTextureSet
		{
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0xCD1980", Offset = "0xCD0180", VA = "0x180CD1980")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x7D9E050", Offset = "0x7D9C850", VA = "0x187D9E050")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		[BindableData(5, "The name of the object to display", DataPermissions.ReadOnly)]
		public string ObjectName
		{
			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0xA35010", Offset = "0xA33810", VA = "0x180A35010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x7D9E0B0", Offset = "0x7D9C8B0", VA = "0x187D9E0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		[BindableData(6, "Whether or not the object is selected by the user", DataPermissions.ReadOnly)]
		public bool Selected
		{
			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0xD9B8E0", Offset = "0xD9A0E0", VA = "0x180D9B8E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0x7D9E130", Offset = "0x7D9C930", VA = "0x187D9E130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		[BindableData(9, "Whether or not to show the action button", DataPermissions.ReadOnly)]
		public bool ShowActionButton
		{
			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0xD9B8F0", Offset = "0xD9A0F0", VA = "0x180D9B8F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0x7D9E190", Offset = "0x7D9C990", VA = "0x187D9E190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		[BindableData(10, "Text to populate the action button", DataPermissions.ReadOnly)]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x60005D6")]
			[Cpp2IlInjected.Address(RVA = "0xA8DF30", Offset = "0xA8C730", VA = "0x180A8DF30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005D7")]
			[Cpp2IlInjected.Address(RVA = "0x7D9DE10", Offset = "0x7D9C610", VA = "0x187D9DE10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60005E0")]
			[Cpp2IlInjected.Address(RVA = "0x7D9DDD0", Offset = "0x7D9C5D0", VA = "0x187D9DDD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60005E1")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x7D9CEC0", Offset = "0x7D9B6C0", VA = "0x187D9CEC0")]
		[BindableAction(3, "Call when the object is clicked")]
		public void ClickObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x7D9CE70", Offset = "0x7D9B670", VA = "0x187D9CE70")]
		[BindableAction(4, "Call when the favorite button is clicked")]
		public void ClickFavorite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x7D9CE20", Offset = "0x7D9B620", VA = "0x187D9CE20")]
		[BindableAction(11, "Called when the action button is clicked")]
		public void ClickActionButton()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x7D9D990", Offset = "0x7D9C190", VA = "0x187D9D990")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x7D9D970", Offset = "0x7D9C170", VA = "0x187D9D970")]
		public void SetNameInNextUpdate(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x7D9D950", Offset = "0x7D9C150", VA = "0x187D9D950")]
		public void SetIconInNextUpdate(Texture2D icon)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(RVA = "0x7D9D9E0", Offset = "0x7D9C1E0", VA = "0x187D9D9E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x7D9D910", Offset = "0x7D9C110", VA = "0x187D9D910", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x7D9D120", Offset = "0x7D9B920", VA = "0x187D9D120", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x7D9CF10", Offset = "0x7D9B710", VA = "0x187D9CF10")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x7D9DAB0", Offset = "0x7D9C2B0", VA = "0x187D9DAB0")]
		public MakerPenHUDPaletteObjectViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[ViewModel]
	public class MakerPenHUDPaletteSearchViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private DataItem<string> PaletteSearchStringDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		[BindableData(1, "The current search string fed to the palette population logic", DataPermissions.ReadWrite)]
		public string PaletteSearchString
		{
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x7D9E440", Offset = "0x7D9CC40", VA = "0x187D9E440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0x7D9E490", Offset = "0x7D9CC90", VA = "0x187D9E490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x7D9E580", Offset = "0x7D9CD80", VA = "0x187D9E580", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x7D9E1F0", Offset = "0x7D9C9F0", VA = "0x187D9E1F0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x7D98810", Offset = "0x7D97010", VA = "0x187D98810", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x7D9E2F0", Offset = "0x7D9CAF0", VA = "0x187D9E2F0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x7D9E240", Offset = "0x7D9CA40", VA = "0x187D9E240")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x7D9E4F0", Offset = "0x7D9CCF0", VA = "0x187D9E4F0")]
		public MakerPenHUDPaletteSearchViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[ViewModel]
	public class MakerPenHUDPaletteViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private DataItem<bool> IsPaletteSearchOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		private DataItemAction TogglePaletteSearchDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700016E")]
		[BindableData(2, "Is the palette search currently opened or closed", DataPermissions.ReadOnly)]
		public bool IsPaletteSearchOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x7D9E8E0", Offset = "0x7D9D0E0", VA = "0x187D9E8E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x7D9E9F0", Offset = "0x7D9D1F0", VA = "0x187D9E9F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x7D9E5B0", Offset = "0x7D9CDB0", VA = "0x187D9E5B0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x7D98810", Offset = "0x7D97010", VA = "0x187D98810", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x7D9E870", Offset = "0x7D9D070", VA = "0x187D9E870")]
		[BindableAction(1, "Toggle Search bar open/closed")]
		public void TogglePaletteSearch()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x7D9E6C0", Offset = "0x7D9CEC0", VA = "0x187D9E6C0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x7D9E600", Offset = "0x7D9CE00", VA = "0x187D9E600")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x7D9E930", Offset = "0x7D9D130", VA = "0x187D9E930")]
		public MakerPenHUDPaletteViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[ViewModel]
	public class MakerPenHUDSelectToolbarViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		private bool isDeleteAllow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private bool onCloneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6A")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private bool inTransformModeAndMoveOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6B")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private bool inTransformModeAndRotateOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private bool inTransformModeAndScaleOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6D")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private bool isRecolorModeActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6E")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private bool isPrecisionModifierModeActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6F")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private bool showEditColorPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private bool isEditColorPanelHiddenWhenRecolorModeActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x71")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private bool onConfigMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x72")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private bool isRRUIPageContainerEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private DataItem<bool> IsDeleteAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private DataItem<bool> OnCloneModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private DataItem<bool> InTransfromModeAndMoveOnDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private DataItem<bool> InTransformModeAndRotateOnDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private DataItem<bool> InTransformModeAndScaleOnDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private DataItem<bool> IsRecolorModeActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private DataItem<bool> IsPrecisionModifierModeActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private DataItem<bool> ShowEditColorPanelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private DataItem<bool> IsEditColorPanelHiddenWhenRecolorModeActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private DataItem<bool> OnConfigModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private DataItem<bool> IsRRUIPageContainerEnabledDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private DataItemAction ToggleCloneModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private DataItemAction ToggleMoveModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private DataItemAction ToggleRotateModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private DataItemAction ToggleScaleModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private DataItemAction DeleteSelectionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private DataItemAction ToggleRecolorModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private DataItemAction ExitRecolorModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private DataItemAction ToggleConfigModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private DataItemAction HideRRUIPageContainerDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		[BindableData(6, "Is Delete Allowed", DataPermissions.ReadWrite)]
		public bool IsDeleteAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x6000609")]
			[Cpp2IlInjected.Address(RVA = "0xA927A0", Offset = "0xA90FA0", VA = "0x180A927A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600060A")]
			[Cpp2IlInjected.Address(RVA = "0x7DA08A0", Offset = "0x7D9F0A0", VA = "0x187DA08A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		[BindableData(7, "OnCloneMode", DataPermissions.ReadWrite)]
		public bool OnCloneMode
		{
			[Cpp2IlInjected.Token(Token = "0x600060B")]
			[Cpp2IlInjected.Address(RVA = "0x13EAC70", Offset = "0x13E9470", VA = "0x1813EAC70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600060C")]
			[Cpp2IlInjected.Address(RVA = "0x7DA0960", Offset = "0x7D9F160", VA = "0x187DA0960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		[BindableData(8, "In Transfrom Mode And Move On", DataPermissions.ReadWrite)]
		public bool InTransfromModeAndMoveOn
		{
			[Cpp2IlInjected.Token(Token = "0x600060D")]
			[Cpp2IlInjected.Address(RVA = "0x202C710", Offset = "0x202AF10", VA = "0x18202C710")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x7DA09C0", Offset = "0x7D9F1C0", VA = "0x187DA09C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		[BindableData(9, "In Transform Mode And Rotate On", DataPermissions.ReadWrite)]
		public bool InTransformModeAndRotateOn
		{
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0x7490950", Offset = "0x748F150", VA = "0x187490950")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000610")]
			[Cpp2IlInjected.Address(RVA = "0x7DA0A20", Offset = "0x7D9F220", VA = "0x187DA0A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000175")]
		[BindableData(10, "In Transform Mode And Scale On", DataPermissions.ReadWrite)]
		public bool InTransformModeAndScaleOn
		{
			[Cpp2IlInjected.Token(Token = "0x6000611")]
			[Cpp2IlInjected.Address(RVA = "0xF64210", Offset = "0xF62A10", VA = "0x180F64210")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000612")]
			[Cpp2IlInjected.Address(RVA = "0x7DA0A80", Offset = "0x7D9F280", VA = "0x187DA0A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000176")]
		[BindableData(11, "Is Recolor Tool Currently Active", DataPermissions.ReadWrite)]
		public bool IsRecolorModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000613")]
			[Cpp2IlInjected.Address(RVA = "0xF62020", Offset = "0xF60820", VA = "0x180F62020")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000614")]
			[Cpp2IlInjected.Address(RVA = "0x7DA0700", Offset = "0x7D9EF00", VA = "0x187DA0700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		[BindableData(12, "Is Transform Tool Active", DataPermissions.ReadWrite)]
		public bool IsPrecisionModifierModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000615")]
			[Cpp2IlInjected.Address(RVA = "0x7DA0760", Offset = "0x7D9EF60", VA = "0x187DA0760")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000616")]
			[Cpp2IlInjected.Address(RVA = "0x7DA0770", Offset = "0x7D9EF70", VA = "0x187DA0770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		[BindableData(14, "Show Edit Color Panel", DataPermissions.ReadOnly)]
		public bool ShowEditColorPanel
		{
			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x7DA07D0", Offset = "0x7D9EFD0", VA = "0x187DA07D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x7DA1450", Offset = "0x7D9FC50", VA = "0x187DA1450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000179")]
		[BindableData(16, "Is Edit Color Panel Hidden When Recolor Mode is Active", DataPermissions.ReadWrite)]
		public bool IsEditColorPanelHiddenWhenRecolorModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0xDC2EA0", Offset = "0xDC16A0", VA = "0x180DC2EA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x7DA07E0", Offset = "0x7D9EFE0", VA = "0x187DA07E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017A")]
		[BindableData(18, "OnConfigMode", DataPermissions.ReadWrite)]
		public bool OnConfigMode
		{
			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x1155EB0", Offset = "0x11546B0", VA = "0x181155EB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600061F")]
			[Cpp2IlInjected.Address(RVA = "0x7DA0840", Offset = "0x7D9F040", VA = "0x187DA0840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017B")]
		[BindableData(19, "IsRRUIPageContainerEnabled", DataPermissions.ReadWrite)]
		public bool IsRRUIPageContainerEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000620")]
			[Cpp2IlInjected.Address(RVA = "0x1156140", Offset = "0x1154940", VA = "0x181156140")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000621")]
			[Cpp2IlInjected.Address(RVA = "0x7DA0900", Offset = "0x7D9F100", VA = "0x187DA0900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000625")]
			[Cpp2IlInjected.Address(RVA = "0x7DA1420", Offset = "0x7D9FC20", VA = "0x187DA1420", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000626")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x7D9EA20", Offset = "0x7D9D220", VA = "0x187D9EA20", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x7DA0070", Offset = "0x7D9E870", VA = "0x187DA0070", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000604")]
		[Cpp2IlInjected.Address(RVA = "0x7DA02B0", Offset = "0x7D9EAB0", VA = "0x187DA02B0")]
		[BindableAction(1, "Press Clone button")]
		public void ToggleCloneMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000605")]
		[Cpp2IlInjected.Address(RVA = "0x7DA0370", Offset = "0x7D9EB70", VA = "0x187DA0370")]
		[BindableAction(2, "Press Move button")]
		public void ToggleMoveMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x7DA04E0", Offset = "0x7D9ECE0", VA = "0x187DA04E0")]
		[BindableAction(3, "Press Rotate button")]
		public void ToggleRotateMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x7DA05F0", Offset = "0x7D9EDF0", VA = "0x187DA05F0")]
		[BindableAction(4, "Press Scale button")]
		public void ToggleScaleMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x7D9EC80", Offset = "0x7D9D480", VA = "0x187D9EC80")]
		[BindableAction(5, "Press Delete button")]
		public void DeleteSelection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000617")]
		[Cpp2IlInjected.Address(RVA = "0x7DA0480", Offset = "0x7D9EC80", VA = "0x187DA0480")]
		[BindableAction(13, "Press Recolor button")]
		public void ToggleRecolorMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061A")]
		[Cpp2IlInjected.Address(RVA = "0x7D9ECE0", Offset = "0x7D9D4E0", VA = "0x187D9ECE0")]
		[BindableAction(15, "Press Exit Recolor button")]
		public void ExitRecolorMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061D")]
		[Cpp2IlInjected.Address(RVA = "0x7DA0310", Offset = "0x7D9EB10", VA = "0x187DA0310")]
		[BindableAction(17, "Press Config button")]
		public void ToggleConfigMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x7D9F040", Offset = "0x7D9D840", VA = "0x187D9F040")]
		[BindableAction(20, "Hide RRUI Page Container")]
		public void HideRRUIPageContainer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x7DA0AF0", Offset = "0x7D9F2F0", VA = "0x187DA0AF0")]
		private void UpdateSelectModeContextualBarData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x7DA0AE0", Offset = "0x7D9F2E0", VA = "0x187DA0AE0")]
		private void UpdateColorPickerOpen(bool open)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x7D9F0A0", Offset = "0x7D9D8A0", VA = "0x187D9F0A0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x7D9ED40", Offset = "0x7D9D540", VA = "0x187D9ED40")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000629")]
		[Cpp2IlInjected.Address(RVA = "0x7DA0F30", Offset = "0x7D9F730", VA = "0x187DA0F30")]
		public MakerPenHUDSelectToolbarViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[ViewModel]
	public class MakerPenHUDViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private DataItem<bool> IsUndoAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private DataItem<bool> IsRedoAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private DataItem<bool> OnSelectModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private DataItem<bool> OnCreateModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private DataItem<bool> IsCursorActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private DataItem<bool> IsInSubMenuDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private DataItemAction TriggerUndoDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private DataItemAction TriggerRedoDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private DataItemAction GoToSelectModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private DataItemAction GoToCreateModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private DataItemAction EndCursorDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		[BindableData(7, "Is Undo Allowed", DataPermissions.ReadOnly)]
		public bool IsUndoAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x7DA24A0", Offset = "0x7DA0CA0", VA = "0x187DA24A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		[BindableData(8, "Is Redo Allowed", DataPermissions.ReadOnly)]
		public bool IsRedoAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0x7DA24F0", Offset = "0x7DA0CF0", VA = "0x187DA24F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		[BindableData(5, "OnSelectMode", DataPermissions.ReadOnly)]
		public bool OnSelectMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x7DA2540", Offset = "0x7DA0D40", VA = "0x187DA2540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		[BindableData(6, "OnCreateMode", DataPermissions.ReadOnly)]
		public bool OnCreateMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0x7DA2590", Offset = "0x7DA0D90", VA = "0x187DA2590")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		[BindableData(9, "Is Cursor Active", DataPermissions.ReadOnly)]
		public bool IsCursorActive
		{
			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0x7DA25E0", Offset = "0x7DA0DE0", VA = "0x187DA25E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		[BindableData(11, "Is In Sub Menu", DataPermissions.ReadOnly)]
		public bool IsInSubMenu
		{
			[Cpp2IlInjected.Token(Token = "0x600064E")]
			[Cpp2IlInjected.Address(RVA = "0x7DA2630", Offset = "0x7DA0E30", VA = "0x187DA2630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000650")]
			[Cpp2IlInjected.Address(RVA = "0x7DA2A30", Offset = "0x7DA1230", VA = "0x187DA2A30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000651")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0x7DA14B0", Offset = "0x7D9FCB0", VA = "0x187DA14B0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0x7DA21C0", Offset = "0x7DA09C0", VA = "0x187DA21C0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0x7DA2450", Offset = "0x7DA0C50", VA = "0x187DA2450")]
		[BindableAction(3, "Press Undo button")]
		public void TriggerUndo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0x7DA2400", Offset = "0x7DA0C00", VA = "0x187DA2400")]
		[BindableAction(4, "Press Redo button")]
		public void TriggerRedo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0x7DA2700", Offset = "0x7DA0F00", VA = "0x187DA2700")]
		private void UpdateUndoStackData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0x7DA1990", Offset = "0x7DA0190", VA = "0x187DA1990")]
		[BindableAction(1, "Press Select button")]
		public void GoToSelectMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x7DA1940", Offset = "0x7DA0140", VA = "0x187DA1940")]
		[BindableAction(2, "Press Create button")]
		public void GoToCreateMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0x7DA2160", Offset = "0x7DA0960", VA = "0x187DA2160")]
		private void OnCurrentModeChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x7DA2680", Offset = "0x7DA0E80", VA = "0x187DA2680")]
		private void UpdateCursorActive(bool isCursorActive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x7DA1710", Offset = "0x7D9FF10", VA = "0x187DA1710")]
		[BindableAction(10, "Button to request exiting cursor mode")]
		public void EndCursor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x7DA26C0", Offset = "0x7DA0EC0", VA = "0x187DA26C0")]
		private void UpdateSubMenuActive(bool isInSubMenu)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x7DA19E0", Offset = "0x7DA01E0", VA = "0x187DA19E0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x7DA1760", Offset = "0x7D9FF60", VA = "0x187DA1760")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000654")]
		[Cpp2IlInjected.Address(RVA = "0x7DA2760", Offset = "0x7DA0F60", VA = "0x187DA2760")]
		public MakerPenHUDViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[ViewModel]
	public class NestedItem : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		[SerializeField]
		private NestedListConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private int absoluteIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private NestedListItem item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private string text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private bool isExpanded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private Sprite activeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private int depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private DataItem<string> TextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private DataItem<bool> IsExpandedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private DataItem<Sprite> ActiveIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private DataItem<int> DepthDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private DataItemAction ToggleExpandedDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x600065B")]
			[Cpp2IlInjected.Address(RVA = "0x7DA3610", Offset = "0x7DA1E10", VA = "0x187DA3610", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x600065C")]
			[Cpp2IlInjected.Address(RVA = "0xA35070", Offset = "0xA33870", VA = "0x180A35070")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600065D")]
			[Cpp2IlInjected.Address(RVA = "0x7DA3290", Offset = "0x7DA1A90", VA = "0x187DA3290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool IsExpanded
		{
			[Cpp2IlInjected.Token(Token = "0x600065E")]
			[Cpp2IlInjected.Address(RVA = "0xC6D850", Offset = "0xC6C050", VA = "0x180C6D850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600065F")]
			[Cpp2IlInjected.Address(RVA = "0x7DA3300", Offset = "0x7DA1B00", VA = "0x187DA3300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public Sprite ActiveIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0xA35020", Offset = "0xA33820", VA = "0x180A35020")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0x7DA3690", Offset = "0x7DA1E90", VA = "0x187DA3690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public int Depth
		{
			[Cpp2IlInjected.Token(Token = "0x6000663")]
			[Cpp2IlInjected.Address(RVA = "0xA35050", Offset = "0xA33850", VA = "0x180A35050")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000664")]
			[Cpp2IlInjected.Address(RVA = "0x7DA3370", Offset = "0x7DA1B70", VA = "0x187DA3370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000666")]
			[Cpp2IlInjected.Address(RVA = "0x7DA35D0", Offset = "0x7DA1DD0", VA = "0x187DA35D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000667")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x7DA3240", Offset = "0x7DA1A40", VA = "0x187DA3240")]
		[BindableAction(2, null)]
		public void ToggleExpanded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x7DA30A0", Offset = "0x7DA18A0", VA = "0x187DA30A0")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x7DA2BA0", Offset = "0x7DA13A0", VA = "0x187DA2BA0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0x7DA2A60", Offset = "0x7DA1260", VA = "0x187DA2A60")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0x7DA33D0", Offset = "0x7DA1BD0", VA = "0x187DA33D0")]
		public NestedItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[ViewModel]
	public class NestedList : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		[SerializeField]
		private NestedListConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private DataList<int> activeIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private DataItemList ActiveIndicesDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<int> ActiveIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000673")]
			[Cpp2IlInjected.Address(RVA = "0xA27510", Offset = "0xA25D10", VA = "0x180A27510")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000674")]
			[Cpp2IlInjected.Address(RVA = "0x7DA3DF0", Offset = "0x7DA25F0", VA = "0x187DA3DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000678")]
			[Cpp2IlInjected.Address(RVA = "0x7DA3DC0", Offset = "0x7DA25C0", VA = "0x187DA3DC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x7DA3740", Offset = "0x7DA1F40", VA = "0x187DA3740", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x7DA3A90", Offset = "0x7DA2290", VA = "0x187DA3A90", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x7DA3BA0", Offset = "0x7DA23A0", VA = "0x187DA3BA0")]
		private void OnIndexStateChanged(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067A")]
		[Cpp2IlInjected.Address(RVA = "0x7DA3940", Offset = "0x7DA2140", VA = "0x187DA3940", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0x7DA3890", Offset = "0x7DA2090", VA = "0x187DA3890")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x7DA3CE0", Offset = "0x7DA24E0", VA = "0x187DA3CE0")]
		public NestedList()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[ViewModel]
	public class OutfitListViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		[CompilerGenerated]
		private struct <FetchOutfitData>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400049D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400049E")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			public OutfitListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			private TaskAwaiter<List<IGOJFJLGCNK>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			private TaskAwaiter<RenderTexture> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			private TaskAwaiter<int> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x600069A")]
			[Cpp2IlInjected.Address(RVA = "0x7DAAFA0", Offset = "0x7DA97A0", VA = "0x187DAAFA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600069B")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		[SerializeField]
		private int maxOutfitDisplayCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		[SerializeField]
		private bool generateOutfitTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		[SerializeField]
		private Route customizationRoute;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		[SerializeField]
		private int renderTextureWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		[SerializeField]
		private int renderTextureHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		[SerializeField]
		private DataResolver currentPanelResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private DataList<IGOJFJLGCNK> savedOutfitList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private bool isEmpty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private DataList<int> saveOutfitSlotList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private RenderTexture outfitTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private IOutfitDataManager outfitManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private string pageIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private DataItem<bool> IsEmptyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private DataItem<RenderTexture> OutfitTextureDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private DataItemList SavedOutfitListDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private DataItemList SaveOutfitSlotListDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private DataItemAction OpenCustomizerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private DataItemAction OpenSavedOutfitsPageDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<IGOJFJLGCNK> SavedOutfitList
		{
			[Cpp2IlInjected.Token(Token = "0x600067F")]
			[Cpp2IlInjected.Address(RVA = "0xA35010", Offset = "0xA33810", VA = "0x180A35010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000680")]
			[Cpp2IlInjected.Address(RVA = "0x7DA5510", Offset = "0x7DA3D10", VA = "0x187DA5510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0xD9B8E0", Offset = "0xD9A0E0", VA = "0x180D9B8E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0x7DA4E30", Offset = "0x7DA3630", VA = "0x187DA4E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public DataList<int> SaveOutfitSlotList
		{
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0xA8DF30", Offset = "0xA8C730", VA = "0x180A8DF30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0x7DA54A0", Offset = "0x7DA3CA0", VA = "0x187DA54A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public RenderTexture OutfitTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0xA34FB0", Offset = "0xA337B0", VA = "0x180A34FB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000686")]
			[Cpp2IlInjected.Address(RVA = "0x7DA5380", Offset = "0x7DA3B80", VA = "0x187DA5380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600068D")]
			[Cpp2IlInjected.Address(RVA = "0x7DA5340", Offset = "0x7DA3B40", VA = "0x187DA5340", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600068E")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4C20", Offset = "0x7DA3420", VA = "0x187DA4C20")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4870", Offset = "0x7DA3070", VA = "0x187DA4870", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x7DA45D0", Offset = "0x7DA2DD0", VA = "0x187DA45D0")]
		private void OnActivePanelChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x7DA3E50", Offset = "0x7DA2650", VA = "0x187DA3E50")]
		[AsyncStateMachine(typeof(<FetchOutfitData>d__28))]
		private void FetchOutfitData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4A90", Offset = "0x7DA3290", VA = "0x187DA4A90")]
		[BindableAction(100, null)]
		private void OpenCustomizer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4B60", Offset = "0x7DA3360", VA = "0x187DA4B60")]
		[BindableAction(101, null)]
		private void OpenSavedOutfitsPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x7DA4060", Offset = "0x7DA2860", VA = "0x187DA4060", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x7DA3F00", Offset = "0x7DA2700", VA = "0x187DA3F00")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5040", Offset = "0x7DA3840", VA = "0x187DA5040")]
		public OutfitListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[ViewModel]
	public class OutfitViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private string outfitThumbnailName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private bool wearingOutfit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private IOutfitDataManager outfitManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private IGOJFJLGCNK savedOutfitData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private DataItem<string> OutfitThumbnailNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private DataItem<bool> WearingOutfitDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private DataItemAction ChangeOutfitDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string OutfitThumbnailName
		{
			[Cpp2IlInjected.Token(Token = "0x600069C")]
			[Cpp2IlInjected.Address(RVA = "0xA274B0", Offset = "0xA25CB0", VA = "0x180A274B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600069D")]
			[Cpp2IlInjected.Address(RVA = "0x7DA5EE0", Offset = "0x7DA46E0", VA = "0x187DA5EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool WearingOutfit
		{
			[Cpp2IlInjected.Token(Token = "0x600069E")]
			[Cpp2IlInjected.Address(RVA = "0xA927A0", Offset = "0xA90FA0", VA = "0x180A927A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600069F")]
			[Cpp2IlInjected.Address(RVA = "0x7DA5F50", Offset = "0x7DA4750", VA = "0x187DA5F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60006A0")]
			[Cpp2IlInjected.Address(RVA = "0x7DA6140", Offset = "0x7DA4940", VA = "0x187DA6140", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60006A4")]
			[Cpp2IlInjected.Address(RVA = "0x7DA6100", Offset = "0x7DA4900", VA = "0x187DA6100", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60006A5")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5E20", Offset = "0x7DA4620", VA = "0x187DA5E20")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5AA0", Offset = "0x7DA42A0", VA = "0x187DA5AA0")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5580", Offset = "0x7DA3D80", VA = "0x187DA5580")]
		[BindableAction(100, null)]
		private void ChangeOutfit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A6")]
		[Cpp2IlInjected.Address(RVA = "0x7DA57A0", Offset = "0x7DA3FA0", VA = "0x187DA57A0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A7")]
		[Cpp2IlInjected.Address(RVA = "0x7DA56B0", Offset = "0x7DA3EB0", VA = "0x187DA56B0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A8")]
		[Cpp2IlInjected.Address(RVA = "0x7DA5FB0", Offset = "0x7DA47B0", VA = "0x187DA5FB0")]
		public OutfitViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[ViewModel]
	public class SaveOutfitButtonViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private IOutfitDataManager outfitManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private int slotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private DataItem<int> SlotIndexDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private DataItemAction SaveOutfitDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60006AD")]
			[Cpp2IlInjected.Address(RVA = "0x7DBBF20", Offset = "0x7DBA720", VA = "0x187DBBF20", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public int SlotIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0xF79070", Offset = "0xF77870", VA = "0x180F79070")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0x7DBBDD0", Offset = "0x7DBA5D0", VA = "0x187DBBDD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60006B3")]
			[Cpp2IlInjected.Address(RVA = "0x7DBBEF0", Offset = "0x7DBA6F0", VA = "0x187DBBEF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60006B4")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(RVA = "0x7DBBCA0", Offset = "0x7DBA4A0", VA = "0x187DBBCA0")]
		[BindableAction(100, null)]
		public void SaveOutfit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B1")]
		[Cpp2IlInjected.Address(RVA = "0x7DBB7B0", Offset = "0x7DB9FB0", VA = "0x187DBB7B0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B2")]
		[Cpp2IlInjected.Address(RVA = "0x7DBBB30", Offset = "0x7DBA330", VA = "0x187DBBB30")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B5")]
		[Cpp2IlInjected.Address(RVA = "0x7DBB930", Offset = "0x7DBA130", VA = "0x187DBB930", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B6")]
		[Cpp2IlInjected.Address(RVA = "0x7DBB870", Offset = "0x7DBA070", VA = "0x187DBB870")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(RVA = "0x7DBBE20", Offset = "0x7DBA620", VA = "0x187DBBE20")]
		public SaveOutfitButtonViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[ViewModel]
	public class RoomCategoryListViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x20000AA")]
		public enum Sources
		{
			[Cpp2IlInjected.Token(Token = "0x40004BD")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40004BE")]
			PageSource,
			[Cpp2IlInjected.Token(Token = "0x40004BF")]
			CuratedList
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000AB")]
		[CompilerGenerated]
		private struct <FetchData>d__25 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004C0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004C1")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004C2")]
			public RoomCategoryListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004C3")]
			private TaskAwaiter<(IReadOnlyList<JIAOGBBBDKD> categories, string displayName)> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004C4")]
			private TaskAwaiter<IReadOnlyList<JIAOGBBBDKD>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60006CF")]
			[Cpp2IlInjected.Address(RVA = "0x7DC3430", Offset = "0x7DC1C30", VA = "0x187DC3430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D0")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		[SerializeField]
		private PBGECCHHBDA loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		[SerializeField]
		private Sources source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		[SerializeField]
		private string sourceMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private string _discoverySectionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private IRRUIvNextRoomCategoryBridge roomCategoryBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private DataList<JIAOGBBBDKD> roomCategoryList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private DataItemList RoomCategoryListDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		public PBGECCHHBDA LoadSceneSource
		{
			[Cpp2IlInjected.Token(Token = "0x60006BA")]
			[Cpp2IlInjected.Address(RVA = "0x7DB3600", Offset = "0x7DB1E00", VA = "0x187DB3600")]
			get
			{
				return default(PBGECCHHBDA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		public BrowserModel BrowserModel
		{
			[Cpp2IlInjected.Token(Token = "0x60006BB")]
			[Cpp2IlInjected.Address(RVA = "0x7DB3510", Offset = "0x7DB1D10", VA = "0x187DB3510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		public string DiscoverySectionId
		{
			[Cpp2IlInjected.Token(Token = "0x60006BC")]
			[Cpp2IlInjected.Address(RVA = "0xA274C0", Offset = "0xA25CC0", VA = "0x180A274C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006BD")]
			[Cpp2IlInjected.Address(RVA = "0x7DB3610", Offset = "0x7DB1E10", VA = "0x187DB3610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<JIAOGBBBDKD> RoomCategoryList
		{
			[Cpp2IlInjected.Token(Token = "0x60006BE")]
			[Cpp2IlInjected.Address(RVA = "0xA8DF30", Offset = "0xA8C730", VA = "0x180A8DF30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006BF")]
			[Cpp2IlInjected.Address(RVA = "0x7DB3740", Offset = "0x7DB1F40", VA = "0x187DB3740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60006C0")]
			[Cpp2IlInjected.Address(RVA = "0xA34FB0", Offset = "0xA337B0", VA = "0x180A34FB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006C1")]
			[Cpp2IlInjected.Address(RVA = "0x7DB36C0", Offset = "0x7DB1EC0", VA = "0x187DB36C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0x7DB35C0", Offset = "0x7DB1DC0", VA = "0x187DB35C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x7DB2EB0", Offset = "0x7DB16B0", VA = "0x187DB2EB0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x7DB2F90", Offset = "0x7DB1790", VA = "0x187DB2F90")]
		public void SetSourceData(string source, string sourceMetadata)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x7DB2AD0", Offset = "0x7DB12D0", VA = "0x187DB2AD0")]
		[AsyncStateMachine(typeof(<FetchData>d__25))]
		public void FetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x7DB3030", Offset = "0x7DB1830", VA = "0x187DB3030")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x7DB2C50", Offset = "0x7DB1450", VA = "0x187DB2C50", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x7DB2B80", Offset = "0x7DB1380", VA = "0x187DB2B80")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x7DB33A0", Offset = "0x7DB1BA0", VA = "0x187DB33A0")]
		public RoomCategoryListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[ViewModel]
	public class RoomCategoryViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		[SerializeField]
		private Route searchRoomsroute;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		[SerializeField]
		private Route gridViewRoute;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private IRRUIvNextRoomCategoryBridge roomCategoryBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private PBGECCHHBDA loadSceneSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private JIAOGBBBDKD roomCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private DataItem<string> ImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private DataItemAction SelectRoomCategoryDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60006D1")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4450", Offset = "0x7DB2C50", VA = "0x187DB4450", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0xA8DF30", Offset = "0xA8C730", VA = "0x180A8DF30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006D3")]
			[Cpp2IlInjected.Address(RVA = "0x7DB44D0", Offset = "0x7DB2CD0", VA = "0x187DB44D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60006D4")]
			[Cpp2IlInjected.Address(RVA = "0xA34FB0", Offset = "0xA337B0", VA = "0x180A34FB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006D5")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4550", Offset = "0x7DB2D50", VA = "0x187DB4550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60006DB")]
			[Cpp2IlInjected.Address(RVA = "0x7DB4410", Offset = "0x7DB2C10", VA = "0x187DB4410", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60006DC")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0x7DB3DB0", Offset = "0x7DB25B0", VA = "0x187DB3DB0")]
		[BindableAction(100, null)]
		public void SelectRoomCategory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x7DB37B0", Offset = "0x7DB1FB0", VA = "0x187DB37B0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x7DB3CA0", Offset = "0x7DB24A0", VA = "0x187DB3CA0")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x7DB3F40", Offset = "0x7DB2740", VA = "0x187DB3F40")]
		private void Set(JIAOGBBBDKD data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x7DB41A0", Offset = "0x7DB29A0", VA = "0x187DB41A0")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x7DB39C0", Offset = "0x7DB21C0", VA = "0x187DB39C0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DE")]
		[Cpp2IlInjected.Address(RVA = "0x7DB38D0", Offset = "0x7DB20D0", VA = "0x187DB38D0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DF")]
		[Cpp2IlInjected.Address(RVA = "0x7DB42B0", Offset = "0x7DB2AB0", VA = "0x187DB42B0")]
		public RoomCategoryViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public class RoomCardFeatureHelper : BaseBindableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private KHGCOBFBJJO loadSceneSourceData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private bool showCCUCounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private int pinnedRoomCCUThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private bool showPopularBadge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private int popularRoomCCUThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private bool showNewBadge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private bool showPlayActionButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA2")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private bool showMoreLikeThisButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA3")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private bool showUpdateToPlayIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private bool showUpdateToPlayText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA5")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private bool showNewThisSessionForSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private string sessionSectionIdOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private Guid? sectionSpawnInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private string parentTabName;

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		public KHGCOBFBJJO LoadSceneSourceData
		{
			[Cpp2IlInjected.Token(Token = "0x60006E4")]
			[Cpp2IlInjected.Address(RVA = "0x7DB2520", Offset = "0x7DB0D20", VA = "0x187DB2520")]
			get
			{
				return default(KHGCOBFBJJO);
			}
			[Cpp2IlInjected.Token(Token = "0x60006E5")]
			[Cpp2IlInjected.Address(RVA = "0x7DB2560", Offset = "0x7DB0D60", VA = "0x187DB2560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		public bool ShowCCUCounts
		{
			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0xA58640", Offset = "0xA56E40", VA = "0x180A58640")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006E7")]
			[Cpp2IlInjected.Address(RVA = "0x7DB2830", Offset = "0x7DB1030", VA = "0x187DB2830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		public bool ShowPopularBadge
		{
			[Cpp2IlInjected.Token(Token = "0x60006E8")]
			[Cpp2IlInjected.Address(RVA = "0xECB790", Offset = "0xEC9F90", VA = "0x180ECB790")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006E9")]
			[Cpp2IlInjected.Address(RVA = "0x7DB29B0", Offset = "0x7DB11B0", VA = "0x187DB29B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		public int PopularRoomCCUThreshold
		{
			[Cpp2IlInjected.Token(Token = "0x60006EA")]
			[Cpp2IlInjected.Address(RVA = "0xE41E60", Offset = "0xE40660", VA = "0x180E41E60")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60006EB")]
			[Cpp2IlInjected.Address(RVA = "0x7DB2670", Offset = "0x7DB0E70", VA = "0x187DB2670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		public bool ShowNewBadge
		{
			[Cpp2IlInjected.Token(Token = "0x60006EC")]
			[Cpp2IlInjected.Address(RVA = "0xCFC160", Offset = "0xCFA960", VA = "0x180CFC160")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006ED")]
			[Cpp2IlInjected.Address(RVA = "0x7DB2890", Offset = "0x7DB1090", VA = "0x187DB2890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		public bool ShowPlayActionButton
		{
			[Cpp2IlInjected.Token(Token = "0x60006EE")]
			[Cpp2IlInjected.Address(RVA = "0xDD1680", Offset = "0xDCFE80", VA = "0x180DD1680")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006EF")]
			[Cpp2IlInjected.Address(RVA = "0x7DB2950", Offset = "0x7DB1150", VA = "0x187DB2950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		public bool ShowMoreLikeThisButton
		{
			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(RVA = "0x74986A0", Offset = "0x7496EA0", VA = "0x1874986A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		public bool ShowUpdateToPlayIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60006F1")]
			[Cpp2IlInjected.Address(RVA = "0x7D632A0", Offset = "0x7D61AA0", VA = "0x187D632A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006F2")]
			[Cpp2IlInjected.Address(RVA = "0x7DB2A10", Offset = "0x7DB1210", VA = "0x187DB2A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public bool ShowUpdateToPlayText
		{
			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(RVA = "0xF0DFD0", Offset = "0xF0C7D0", VA = "0x180F0DFD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006F4")]
			[Cpp2IlInjected.Address(RVA = "0x7DB2A70", Offset = "0x7DB1270", VA = "0x187DB2A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public bool ShowNewThisSessionForSection
		{
			[Cpp2IlInjected.Token(Token = "0x60006F5")]
			[Cpp2IlInjected.Address(RVA = "0x182EFA0", Offset = "0x182D7A0", VA = "0x18182EFA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006F6")]
			[Cpp2IlInjected.Address(RVA = "0x7DB28F0", Offset = "0x7DB10F0", VA = "0x187DB28F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public string SessionSectionIdOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60006F7")]
			[Cpp2IlInjected.Address(RVA = "0xA2B840", Offset = "0xA2A040", VA = "0x180A2B840")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0x7DB27B0", Offset = "0x7DB0FB0", VA = "0x187DB27B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public Guid? SectionSpawnInstanceId
		{
			[Cpp2IlInjected.Token(Token = "0x60006F9")]
			[Cpp2IlInjected.Address(RVA = "0xA2B820", Offset = "0xA2A020", VA = "0x180A2B820")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006FA")]
			[Cpp2IlInjected.Address(RVA = "0x7DB26D0", Offset = "0x7DB0ED0", VA = "0x187DB26D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		public string ParentTabName
		{
			[Cpp2IlInjected.Token(Token = "0x60006FB")]
			[Cpp2IlInjected.Address(RVA = "0xABDCA0", Offset = "0xABC4A0", VA = "0x180ABDCA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006FC")]
			[Cpp2IlInjected.Address(RVA = "0x7DB25F0", Offset = "0x7DB0DF0", VA = "0x187DB25F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x7DB2500", Offset = "0x7DB0D00", VA = "0x187DB2500")]
		public RoomCardFeatureHelper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[ViewModel]
	public class RoomListViewModel : RRUIBaseLocalViewModel, IOrderedRenderable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000AF")]
		[CompilerGenerated]
		private struct <FetchData>d__52 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F9")]
			public RoomListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004FA")]
			private TaskAwaiter<List<MBPHGEGJLJE>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0x7DC3A10", Offset = "0x7DC2210", VA = "0x187DC3A10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600072C")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		[SerializeField]
		private RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		[SerializeField]
		private bool overrideLoadSceneSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		[SerializeField]
		private PBGECCHHBDA loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private IRoomQueryManager roomListQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private bool waitingForQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private List<long> tempIdList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private int minItemCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private bool fetchCCUCounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private DataList<long> roomIdList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private string listDisplayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private bool isEmptyOrBelowMinimum;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private RoomCardFeatureHelper featureHelper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private DataItem<string> ListDisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private DataItem<bool> IsEmptyOrBelowMinimumDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private DataItem<RoomListQueryData> QueryDataDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private DataItem<RoomCardFeatureHelper> FeatureHelperDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private DataItemList RoomIdListDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<long> RoomIdList
		{
			[Cpp2IlInjected.Token(Token = "0x60006FE")]
			[Cpp2IlInjected.Address(RVA = "0xA8E350", Offset = "0xA8CB50", VA = "0x180A8E350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006FF")]
			[Cpp2IlInjected.Address(RVA = "0x7DB68E0", Offset = "0x7DB50E0", VA = "0x187DB68E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		[BindableData(1, "The name of the list that can be shown on the UI, e.g. as a carousel title", DataPermissions.ReadWrite)]
		public string ListDisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000700")]
			[Cpp2IlInjected.Address(RVA = "0xA2B840", Offset = "0xA2A040", VA = "0x180A2B840")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000701")]
			[Cpp2IlInjected.Address(RVA = "0x7DB6860", Offset = "0x7DB5060", VA = "0x187DB6860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public bool IsEmptyOrBelowMinimum
		{
			[Cpp2IlInjected.Token(Token = "0x6000702")]
			[Cpp2IlInjected.Address(RVA = "0xFA4450", Offset = "0xFA2C50", VA = "0x180FA4450")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000703")]
			[Cpp2IlInjected.Address(RVA = "0x7DB6350", Offset = "0x7DB4B50", VA = "0x187DB6350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		[BindableData(3, "The query data used to retrieve the room list", DataPermissions.ReadOnly)]
		public RoomListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0xA27510", Offset = "0xA25D10", VA = "0x180A27510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public RoomCardFeatureHelper FeatureHelper
		{
			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0xABDC30", Offset = "0xABC430", VA = "0x180ABDC30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0x7DB63B0", Offset = "0x7DB4BB0", VA = "0x187DB63B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		public bool RenderInCarouselOrder
		{
			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(RVA = "0xF77E80", Offset = "0xF76680", VA = "0x180F77E80", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000708")]
			[Cpp2IlInjected.Address(RVA = "0xC5AFE0", Offset = "0xC597E0", VA = "0x180C5AFE0", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		public bool AllowRender
		{
			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(RVA = "0xF78280", Offset = "0xF76A80", VA = "0x180F78280", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600070A")]
			[Cpp2IlInjected.Address(RVA = "0xC5AFF0", Offset = "0xC597F0", VA = "0x180C5AFF0", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		public bool HasRefreshed
		{
			[Cpp2IlInjected.Token(Token = "0x600070B")]
			[Cpp2IlInjected.Address(RVA = "0x1FF20A0", Offset = "0x1FF08A0", VA = "0x181FF20A0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600070C")]
			[Cpp2IlInjected.Address(RVA = "0xC5B000", Offset = "0xC59800", VA = "0x180C5B000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		public bool RequiresRefresh
		{
			[Cpp2IlInjected.Token(Token = "0x600070D")]
			[Cpp2IlInjected.Address(RVA = "0x1FF1C70", Offset = "0x1FF0470", VA = "0x181FF1C70", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600070E")]
			[Cpp2IlInjected.Address(RVA = "0x1FEE0C0", Offset = "0x1FEC8C0", VA = "0x181FEE0C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		public bool OverrideLoadSceneSource
		{
			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0xDC2EA0", Offset = "0xDC16A0", VA = "0x180DC2EA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		public PBGECCHHBDA LoadSceneSourceOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0xA50790", Offset = "0xA4EF90", VA = "0x180A50790")]
			get
			{
				return default(PBGECCHHBDA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600071D")]
			[Cpp2IlInjected.Address(RVA = "0x7DB6820", Offset = "0x7DB5020", VA = "0x187DB6820", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600071E")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0x7DB61A0", Offset = "0x7DB49A0", VA = "0x187DB61A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0x7DB4EF0", Offset = "0x7DB36F0", VA = "0x187DB4EF0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0x7DB5A00", Offset = "0x7DB4200", VA = "0x187DB5A00")]
		public void SetQueryData(RoomListQueryData listQueryData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0x7DB58C0", Offset = "0x7DB40C0", VA = "0x187DB58C0")]
		public void SetDiscoverySectionId(string sectionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x7DB45D0", Offset = "0x7DB2DD0", VA = "0x187DB45D0")]
		[AsyncStateMachine(typeof(<FetchData>d__52))]
		public void FetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0x7DB5970", Offset = "0x7DB4170", VA = "0x187DB5970")]
		public void SetMaxItems(int maxItemsToFetch, int maxItemsToDisplay)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x7DB59D0", Offset = "0x7DB41D0", VA = "0x187DB59D0")]
		public void SetMinItems(int minItems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x7DB50C0", Offset = "0x7DB38C0", VA = "0x187DB50C0")]
		private void PopulateLoadSceneSourceData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x7DB5650", Offset = "0x7DB3E50", VA = "0x187DB5650")]
		private string ResolveDisplayName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xF78280", Offset = "0xF76A80", VA = "0x180F78280")]
		private bool WaitUntilAllowRender()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x7DB5AC0", Offset = "0x7DB42C0", VA = "0x187DB5AC0")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x7DB4D70", Offset = "0x7DB3570", VA = "0x187DB4D70")]
		private void OnChildImpressionTrackerAdded(ImpressionTracker child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x7DB47C0", Offset = "0x7DB2FC0", VA = "0x187DB47C0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0x7DB4680", Offset = "0x7DB2E80", VA = "0x187DB4680")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0x7DB64F0", Offset = "0x7DB4CF0", VA = "0x187DB64F0")]
		public RoomListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[ViewModel]
	public class RoomViewModel : RRUIBaseLocalViewModel, ILoadable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000B1")]
		[CompilerGenerated]
		private struct <FetchRoomData>d__120 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400053D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400053E")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400053F")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000540")]
			private TaskAwaiter<MBPHGEGJLJE> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0x7DC42E0", Offset = "0x7DC2AE0", VA = "0x187DC42E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000B2")]
		[CompilerGenerated]
		private struct <DoPlayAction>d__126 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000541")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000542")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000543")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000544")]
			private APAMIKOGBPP <details>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000545")]
			private bool <canChooseSubroom>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000546")]
			private TaskAwaiter<APAMIKOGBPP> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000547")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x7DC2BF0", Offset = "0x7DC13F0", VA = "0x187DC2BF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000B4")]
		[CompilerGenerated]
		private struct <CreateOrJoinRoomInstance>d__127 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400054D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400054E")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400054F")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000550")]
			public APAMIKOGBPP roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000551")]
			public bool privateInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x4000552")]
			public bool canChooseSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
			[Cpp2IlInjected.Token(Token = "0x4000553")]
			public bool randomSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000554")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0x7DC2660", Offset = "0x7DC0E60", VA = "0x187DC2660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass128_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000555")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000556")]
			public APAMIKOGBPP roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000557")]
			public NKDJCGCAECB subRoom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000558")]
			public bool privateInstance;

			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public <>c__DisplayClass128_0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x7DC5910", Offset = "0x7DC4110", VA = "0x187DC5910")]
			internal void <PlayAction_TryGoToRoom>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B6")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass128_1
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000559")]
			public NJEJHBFOBPK latestValidSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400055A")]
			public <>c__DisplayClass128_0 CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public <>c__DisplayClass128_1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0x7DC5A00", Offset = "0x7DC4200", VA = "0x187DC5A00")]
			internal void <PlayAction_TryGoToRoom>b__1()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000B7")]
		[CompilerGenerated]
		private struct <PlayAction_TryGoToRoom>d__128 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400055B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400055C")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400055D")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400055E")]
			public APAMIKOGBPP roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400055F")]
			public bool privateInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x4000560")]
			public bool randomSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
			[Cpp2IlInjected.Token(Token = "0x4000561")]
			public bool canChooseSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000562")]
			private <>c__DisplayClass128_0 <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000563")]
			private <>c__DisplayClass128_1 <>8__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000564")]
			private TaskAwaiter<NKDJCGCAECB> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000565")]
			private IRoomSaveManager <saveManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000566")]
			private TaskAwaiter<NJEJHBFOBPK> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0x7DC4650", Offset = "0x7DC2E50", VA = "0x187DC4650", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private const string CCUCountKey = "CCU_COUNT";

		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private const char tokenDelimiter = '.';

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		[SerializeField]
		private DataResolver featureHelperResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private IRoomQueryManager roomQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		private IRoomLoadManager roomLoadManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		private IRRUIvNextUIDataBridge vNextDataBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		private KHGCOBFBJJO loadSceneSourceData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private DialogListModel dialogListModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private int cheerCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private int ccuCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private bool shouldFetchCCUCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private DateTime? lastPublished;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private bool hasSufficientVersionToLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private bool favorited;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private string cheerCountString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		private bool isRooms2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private bool showCheerCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private string ccuCountString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private bool supportsPlayAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x171")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private bool supportsMoreLikeThis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x172")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private bool isPopularRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x173")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private bool isNewlyPublished;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private bool showCCUCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x175")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private bool supportsDataTokens;

		[Cpp2IlInjected.FieldOffset(Offset = "0x176")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private bool showCheerToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x177")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private bool requiresUpdateToPlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private bool showUpdateToPlayIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x179")]
		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private bool showUpdateToPlayText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17A")]
		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private bool showNewThisSessionForSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17B")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		private bool showRooms2Badge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private LGLDNBHKABK publishState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private bool showPublishState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private DataItem<long> RoomIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private DataItem<string> DescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private DataItem<string> ImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private DataItem<bool> FavoritedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private DataItem<string> CheerCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private DataItem<bool> IsRooms2DataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private DataItem<bool> ShowCheerCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private DataItem<string> CCUCountStringDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private DataItem<bool> SupportsPlayActionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private DataItem<bool> SupportsMoreLikeThisDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private DataItem<bool> IsPopularRoomDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private DataItem<bool> IsNewlyPublishedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		private DataItem<bool> ShowCCUCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private DataItem<bool> SupportsDataTokensDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private DataItem<bool> ShowCheerTokenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private DataItem<bool> RequiresUpdateToPlayDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private DataItem<bool> ShowUpdateToPlayIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private DataItem<bool> ShowUpdateToPlayTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private DataItem<bool> ShowNewThisSessionForSectionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private DataItem<bool> ShowRooms2BadgeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private DataItem<LGLDNBHKABK> PublishStateDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private DataItem<bool> ShowPublishStateDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private DataItemAction OpenRoomDetailsPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private DataItemAction DoPlayActionDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		[BindableData(0, "The ID used to retrieve the room data from RecNet", DataPermissions.ReadWrite)]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x600072D")]
			[Cpp2IlInjected.Address(RVA = "0xAB0830", Offset = "0xAAF030", VA = "0x180AB0830")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600072E")]
			[Cpp2IlInjected.Address(RVA = "0x7DBB6B0", Offset = "0x7DB9EB0", VA = "0x187DBB6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		[BindableData(1, "The sanitized, friendly name of the room", DataPermissions.ReadOnly)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0xB32900", Offset = "0xB31100", VA = "0x180B32900")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x7DBB5A0", Offset = "0x7DB9DA0", VA = "0x187DBB5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		[BindableData(2, null, DataPermissions.ReadOnly)]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0xB380A0", Offset = "0xB368A0", VA = "0x180B380A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x7DBB520", Offset = "0x7DB9D20", VA = "0x187DBB520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0xB33C60", Offset = "0xB32460", VA = "0x180B33C60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x7DBB620", Offset = "0x7DB9E20", VA = "0x187DBB620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool Favorited
		{
			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0xB2A8C0", Offset = "0xB290C0", VA = "0x180B2A8C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x7DB9EA0", Offset = "0x7DB86A0", VA = "0x187DB9EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public string CheerCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000737")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAA0", Offset = "0xB2D2A0", VA = "0x180B2EAA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000738")]
			[Cpp2IlInjected.Address(RVA = "0x7DBB4A0", Offset = "0x7DB9CA0", VA = "0x187DBB4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool IsRooms2
		{
			[Cpp2IlInjected.Token(Token = "0x6000739")]
			[Cpp2IlInjected.Address(RVA = "0x1D1F320", Offset = "0x1D1DB20", VA = "0x181D1F320")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600073A")]
			[Cpp2IlInjected.Address(RVA = "0x7DB9820", Offset = "0x7DB8020", VA = "0x187DB9820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		[BindableData(7, null, DataPermissions.ReadWrite)]
		public bool ShowCheerCount
		{
			[Cpp2IlInjected.Token(Token = "0x600073B")]
			[Cpp2IlInjected.Address(RVA = "0x1D1F310", Offset = "0x1D1DB10", VA = "0x181D1F310")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x7DB9880", Offset = "0x7DB8080", VA = "0x187DB9880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		[BindableData(8, null, DataPermissions.ReadWrite)]
		public string CCUCountString
		{
			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0xB3A5F0", Offset = "0xB38DF0", VA = "0x180B3A5F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0x7DBB420", Offset = "0x7DB9C20", VA = "0x187DBB420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		[BindableData(9, null, DataPermissions.ReadWrite)]
		public bool SupportsPlayAction
		{
			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0xB2FA00", Offset = "0xB2E200", VA = "0x180B2FA00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000740")]
			[Cpp2IlInjected.Address(RVA = "0x7DB98F0", Offset = "0x7DB80F0", VA = "0x187DB98F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		[BindableData(10, null, DataPermissions.ReadWrite)]
		public bool SupportsMoreLikeThis
		{
			[Cpp2IlInjected.Token(Token = "0x6000741")]
			[Cpp2IlInjected.Address(RVA = "0xB56DD0", Offset = "0xB555D0", VA = "0x180B56DD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000742")]
			[Cpp2IlInjected.Address(RVA = "0x7DB9950", Offset = "0x7DB8150", VA = "0x187DB9950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		[BindableData(11, null, DataPermissions.ReadWrite)]
		public bool IsPopularRoom
		{
			[Cpp2IlInjected.Token(Token = "0x6000743")]
			[Cpp2IlInjected.Address(RVA = "0x7DB99C0", Offset = "0x7DB81C0", VA = "0x187DB99C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000744")]
			[Cpp2IlInjected.Address(RVA = "0x7DB99D0", Offset = "0x7DB81D0", VA = "0x187DB99D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		[BindableData(12, null, DataPermissions.ReadWrite)]
		public bool IsNewlyPublished
		{
			[Cpp2IlInjected.Token(Token = "0x6000745")]
			[Cpp2IlInjected.Address(RVA = "0xF76C80", Offset = "0xF75480", VA = "0x180F76C80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000746")]
			[Cpp2IlInjected.Address(RVA = "0x7DB9A30", Offset = "0x7DB8230", VA = "0x187DB9A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		[BindableData(13, null, DataPermissions.ReadWrite)]
		public bool ShowCCUCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000747")]
			[Cpp2IlInjected.Address(RVA = "0x7D1B8A0", Offset = "0x7D1A0A0", VA = "0x187D1B8A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000748")]
			[Cpp2IlInjected.Address(RVA = "0x7DB9A90", Offset = "0x7DB8290", VA = "0x187DB9A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		[BindableData(14, null, DataPermissions.ReadWrite)]
		public bool SupportsDataTokens
		{
			[Cpp2IlInjected.Token(Token = "0x6000749")]
			[Cpp2IlInjected.Address(RVA = "0x7D1B860", Offset = "0x7D1A060", VA = "0x187D1B860")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x7DB9AF0", Offset = "0x7DB82F0", VA = "0x187DB9AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		[BindableData(15, null, DataPermissions.ReadWrite)]
		public bool ShowCheerToken
		{
			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0x7D1B9C0", Offset = "0x7D1A1C0", VA = "0x187D1B9C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x7DB9B50", Offset = "0x7DB8350", VA = "0x187DB9B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		[BindableData(16, null, DataPermissions.ReadWrite)]
		public bool RequiresUpdateToPlay
		{
			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0x7DB9BB0", Offset = "0x7DB83B0", VA = "0x187DB9BB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0x7DB9BC0", Offset = "0x7DB83C0", VA = "0x187DB9BC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		[BindableData(17, null, DataPermissions.ReadWrite)]
		public bool ShowUpdateToPlayIcon
		{
			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0xAA63B0", Offset = "0xAA4BB0", VA = "0x180AA63B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000750")]
			[Cpp2IlInjected.Address(RVA = "0x7DB9C20", Offset = "0x7DB8420", VA = "0x187DB9C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		[BindableData(18, null, DataPermissions.ReadWrite)]
		public bool ShowUpdateToPlayText
		{
			[Cpp2IlInjected.Token(Token = "0x6000751")]
			[Cpp2IlInjected.Address(RVA = "0x7DB9C80", Offset = "0x7DB8480", VA = "0x187DB9C80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000752")]
			[Cpp2IlInjected.Address(RVA = "0x7DB9C90", Offset = "0x7DB8490", VA = "0x187DB9C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		[BindableData(19, null, DataPermissions.ReadWrite)]
		public bool ShowNewThisSessionForSection
		{
			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x7DB9CF0", Offset = "0x7DB84F0", VA = "0x187DB9CF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x7DB9D00", Offset = "0x7DB8500", VA = "0x187DB9D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		[BindableData(20, null, DataPermissions.ReadWrite)]
		public bool ShowRooms2Badge
		{
			[Cpp2IlInjected.Token(Token = "0x6000755")]
			[Cpp2IlInjected.Address(RVA = "0x7DB9D60", Offset = "0x7DB8560", VA = "0x187DB9D60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000756")]
			[Cpp2IlInjected.Address(RVA = "0x7DB9D70", Offset = "0x7DB8570", VA = "0x187DB9D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		[BindableData(21, null, DataPermissions.ReadWrite)]
		public LGLDNBHKABK PublishState
		{
			[Cpp2IlInjected.Token(Token = "0x6000757")]
			[Cpp2IlInjected.Address(RVA = "0xB24110", Offset = "0xB22910", VA = "0x180B24110")]
			get
			{
				return default(LGLDNBHKABK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0x7DB9DD0", Offset = "0x7DB85D0", VA = "0x187DB9DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		[BindableData(22, null, DataPermissions.ReadWrite)]
		public bool ShowPublishState
		{
			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0x22D2990", Offset = "0x22D1190", VA = "0x1822D2990")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600075A")]
			[Cpp2IlInjected.Address(RVA = "0x7DB9E30", Offset = "0x7DB8630", VA = "0x187DB9E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0x7DBB2E0", Offset = "0x7DB9AE0", VA = "0x187DBB2E0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x600075C")]
			[Cpp2IlInjected.Address(RVA = "0x7DBB2D0", Offset = "0x7DB9AD0", VA = "0x187DBB2D0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0x7DBB6A0", Offset = "0x7DB9EA0", VA = "0x187DBB6A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600076F")]
			[Cpp2IlInjected.Address(RVA = "0x7DBB290", Offset = "0x7DB9A90", VA = "0x187DBB290", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<ILoadable> Loaded
		{
			[Cpp2IlInjected.Token(Token = "0x600075E")]
			[Cpp2IlInjected.Address(RVA = "0x7DBB1D0", Offset = "0x7DB99D0", VA = "0x187DBB1D0", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x7DBB360", Offset = "0x7DB9B60", VA = "0x187DBB360", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x7DB6AE0", Offset = "0x7DB52E0", VA = "0x187DB6AE0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x7DB89F0", Offset = "0x7DB71F0", VA = "0x187DB89F0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0x7DB8800", Offset = "0x7DB7000", VA = "0x187DB8800")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0x7DB6DE0", Offset = "0x7DB55E0", VA = "0x187DB6DE0")]
		[AsyncStateMachine(typeof(<FetchRoomData>d__120))]
		private void FetchRoomData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x7DBA670", Offset = "0x7DB8E70", VA = "0x187DBA670")]
		private void UpdateRoomData(MBPHGEGJLJE roomDto)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x7DB9F10", Offset = "0x7DB8710", VA = "0x187DB9F10")]
		private void UpdateFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x7DB9320", Offset = "0x7DB7B20", VA = "0x187DB9320")]
		private void ResetRoomData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0x7DB8AE0", Offset = "0x7DB72E0", VA = "0x187DB8AE0")]
		private void OnFeatureHelperUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x7DB8B00", Offset = "0x7DB7300", VA = "0x187DB8B00")]
		[BindableAction(100, null)]
		private void OpenRoomDetailsPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0x7DB6D30", Offset = "0x7DB5530", VA = "0x187DB6D30")]
		[BindableAction(101, null)]
		[AsyncStateMachine(typeof(<DoPlayAction>d__126))]
		private void DoPlayAction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076B")]
		[Cpp2IlInjected.Address(RVA = "0x7DB6C30", Offset = "0x7DB5430", VA = "0x187DB6C30")]
		[AsyncStateMachine(typeof(<CreateOrJoinRoomInstance>d__127))]
		private void CreateOrJoinRoomInstance(bool privateInstance, APAMIKOGBPP roomDetails, bool canChooseSubroom = false, bool randomSubroom = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x7DB9010", Offset = "0x7DB7810", VA = "0x187DB9010")]
		[AsyncStateMachine(typeof(<PlayAction_TryGoToRoom>d__128))]
		private void PlayAction_TryGoToRoom(APAMIKOGBPP roomDetails, bool privateInstance, bool canChooseSubroom, bool randomSubroom)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x7DB9120", Offset = "0x7DB7920", VA = "0x187DB9120")]
		private void RecordImpressionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x7DB6950", Offset = "0x7DB5150", VA = "0x187DB6950")]
		private void AddDataTokenToImpressionData(string dataToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x7DB7280", Offset = "0x7DB5A80", VA = "0x187DB7280", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x7DB6E90", Offset = "0x7DB5690", VA = "0x187DB6E90")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x7DBAA80", Offset = "0x7DB9280", VA = "0x187DBAA80")]
		public RoomViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	public class RRUIBaseGlobalViewModel : BaseGlobalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		protected override string RecordPath
		{
			[Cpp2IlInjected.Token(Token = "0x60007AE")]
			[Cpp2IlInjected.Address(RVA = "0x7DB2330", Offset = "0x7DB0B30", VA = "0x187DB2330", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0x7DB2320", Offset = "0x7DB0B20", VA = "0x187DB2320")]
		public RRUIBaseGlobalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	public class RRUIBaseLocalViewModel : BaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		[SerializeField]
		protected ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		protected CancellationTokenSource cancellationTokenSource;

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		protected override string RecordPath
		{
			[Cpp2IlInjected.Token(Token = "0x60007B0")]
			[Cpp2IlInjected.Address(RVA = "0x7DB24D0", Offset = "0x7DB0CD0", VA = "0x187DB24D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x7DB2460", Offset = "0x7DB0C60", VA = "0x187DB2460", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x7DB2360", Offset = "0x7DB0B60", VA = "0x187DB2360")]
		protected CancellationToken CancelAndRefreshToken()
		{
			return default(CancellationToken);
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x7DB2410", Offset = "0x7DB0C10", VA = "0x187DB2410")]
		protected void CancelToken()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x7DB24C0", Offset = "0x7DB0CC0", VA = "0x187DB24C0")]
		public RRUIBaseLocalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public class Tutorial
	{
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		public enum CompletionState
		{
			[Cpp2IlInjected.Token(Token = "0x4000571")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000572")]
			Completed,
			[Cpp2IlInjected.Token(Token = "0x4000573")]
			SoftExit,
			[Cpp2IlInjected.Token(Token = "0x4000574")]
			HardExit
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private List<TutorialStep> steps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private int activeStepIdx;

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x60007B5")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		public TutorialStep ActiveStep
		{
			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0x7DC2600", Offset = "0x7DC0E00", VA = "0x187DC2600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		public IReadOnlyList<TutorialStep> Steps
		{
			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4A0", Offset = "0xA2BCA0", VA = "0x180A2D4A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		public KECNPIDOCPH OnTutorialStarted
		{
			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		public KECNPIDOCPH OnTutorialExited
		{
			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		public KECNPIDOCPH OnStepChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public CompletionState CompletionStatus
		{
			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0xA30050", Offset = "0xA2E850", VA = "0x180A30050")]
			[CompilerGenerated]
			get
			{
				return default(CompletionState);
			}
			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0xA2FE60", Offset = "0xA2E660", VA = "0x180A2FE60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0x7DC23F0", Offset = "0x7DC0BF0", VA = "0x187DC23F0")]
		public Tutorial(string id, List<TutorialStep> steps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x7DC23B0", Offset = "0x7DC0BB0", VA = "0x187DC23B0")]
		public void StartTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1D00", Offset = "0x7DC0500", VA = "0x187DC1D00")]
		public void ExitTutorial(bool showAgain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1E80", Offset = "0x7DC0680", VA = "0x187DC1E80")]
		public void SetActiveStep(string id, bool forceReload = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1FC0", Offset = "0x7DC07C0", VA = "0x187DC1FC0")]
		public void SetActiveStep(int idx, bool forceReload = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1D80", Offset = "0x7DC0580", VA = "0x187DC1D80")]
		private void OnGoBack()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1E00", Offset = "0x7DC0600", VA = "0x187DC1E00")]
		private void OnStepCompleted()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public class TutorialHighlightTargeter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		[SerializeField]
		protected List<TutorialTargetData> tutorialTargets;

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x7DBBFA0", Offset = "0x7DBA7A0", VA = "0x187DBBFA0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x7DBC110", Offset = "0x7DBA910", VA = "0x187DBC110", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x7DBC3F0", Offset = "0x7DBABF0", VA = "0x187DBC3F0")]
		private void RegisterTargets()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0x7DBC580", Offset = "0x7DBAD80", VA = "0x187DBC580")]
		public TutorialHighlightTargeter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public class TutorialTargetData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		public string TutorialId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		public string StepId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		public RectTransform Target;

		[Cpp2IlInjected.Token(Token = "0x60007C9")]
		[Cpp2IlInjected.Address(RVA = "0x7DC01E0", Offset = "0x7DBE9E0", VA = "0x187DC01E0")]
		public TutorialTargetData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	public class TutorialStep
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private bool isActive;

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x60007CA")]
			[Cpp2IlInjected.Address(RVA = "0xA2D240", Offset = "0xA2BA40", VA = "0x180A2D240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007CB")]
			[Cpp2IlInjected.Address(RVA = "0xA2D230", Offset = "0xA2BA30", VA = "0x180A2D230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x60007CC")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007CD")]
			[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60007CE")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE60", Offset = "0xA2D660", VA = "0x180A2EE60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0xA2A970", Offset = "0xA29170", VA = "0x180A2A970")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		public string ButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0xA2D3B0", Offset = "0xA2BBB0", VA = "0x180A2D3B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE70", Offset = "0xA2D670", VA = "0x180A2EE70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		public string CountText
		{
			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		public bool HasButtonToGoForward
		{
			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0xE4BC70", Offset = "0xE4A470", VA = "0x180E4BC70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D5")]
			[Cpp2IlInjected.Address(RVA = "0xE4B5D0", Offset = "0xE49DD0", VA = "0x180E4B5D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		public bool HasButtonToGoBack
		{
			[Cpp2IlInjected.Token(Token = "0x60007D6")]
			[Cpp2IlInjected.Address(RVA = "0x13AF740", Offset = "0x13ADF40", VA = "0x1813AF740")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D7")]
			[Cpp2IlInjected.Address(RVA = "0x13AF400", Offset = "0x13ADC00", VA = "0x1813AF400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		public bool ShowCountText
		{
			[Cpp2IlInjected.Token(Token = "0x60007D8")]
			[Cpp2IlInjected.Address(RVA = "0xA76450", Offset = "0xA74C50", VA = "0x180A76450")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D9")]
			[Cpp2IlInjected.Address(RVA = "0x206C8E0", Offset = "0x206B0E0", VA = "0x18206C8E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		public bool ShowExitButton
		{
			[Cpp2IlInjected.Token(Token = "0x60007DA")]
			[Cpp2IlInjected.Address(RVA = "0x74117E0", Offset = "0x740FFE0", VA = "0x1874117E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007DB")]
			[Cpp2IlInjected.Address(RVA = "0x76EBC30", Offset = "0x76EA430", VA = "0x1876EBC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		public bool CanSoftExit
		{
			[Cpp2IlInjected.Token(Token = "0x60007DC")]
			[Cpp2IlInjected.Address(RVA = "0xECB7B0", Offset = "0xEC9FB0", VA = "0x180ECB7B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007DD")]
			[Cpp2IlInjected.Address(RVA = "0xECB110", Offset = "0xEC9910", VA = "0x180ECB110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		public bool AllowInteraction
		{
			[Cpp2IlInjected.Token(Token = "0x60007DE")]
			[Cpp2IlInjected.Address(RVA = "0xECB100", Offset = "0xEC9900", VA = "0x180ECB100")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007DF")]
			[Cpp2IlInjected.Address(RVA = "0xECB7A0", Offset = "0xEC9FA0", VA = "0x180ECB7A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		public bool TargetingHUD
		{
			[Cpp2IlInjected.Token(Token = "0x60007E0")]
			[Cpp2IlInjected.Address(RVA = "0xECB410", Offset = "0xEC9C10", VA = "0x180ECB410")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E1")]
			[Cpp2IlInjected.Address(RVA = "0xECB7C0", Offset = "0xEC9FC0", VA = "0x180ECB7C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		public TextAnchor DialogAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0xC775A0", Offset = "0xC75DA0", VA = "0x180C775A0")]
			[CompilerGenerated]
			get
			{
				return default(TextAnchor);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0xEB9080", Offset = "0xEB7880", VA = "0x180EB9080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		public RectTransform TutorialHighlightTarget
		{
			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0xA2D390", Offset = "0xA2BB90", VA = "0x180A2D390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007E5")]
			[Cpp2IlInjected.Address(RVA = "0xA2D480", Offset = "0xA2BC80", VA = "0x180A2D480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		public KECNPIDOCPH OnStepCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x60007E6")]
			[Cpp2IlInjected.Address(RVA = "0xA274F0", Offset = "0xA25CF0", VA = "0x180A274F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		public KECNPIDOCPH OnStepModified
		{
			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0xA27530", Offset = "0xA25D30", VA = "0x180A27530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		public KECNPIDOCPH OnGoBack
		{
			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0xA274B0", Offset = "0xA25CB0", VA = "0x180A274B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007E9")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0040", Offset = "0x7DBE840", VA = "0x187DC0040")]
		public TutorialStep(string id, string title, string description, string buttonText, bool showExitButton, bool canSoftExit, bool canGoBack, bool canGoForward, bool showCount, bool allowInteraction, bool targetingHud, TextAnchor dialogAnchor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EA")]
		[Cpp2IlInjected.Address(RVA = "0x7DBFE60", Offset = "0x7DBE660", VA = "0x187DBFE60")]
		public void SetHighlightTarget(RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EB")]
		[Cpp2IlInjected.Address(RVA = "0x7DBFE20", Offset = "0x7DBE620", VA = "0x187DBFE20")]
		public void SetCountText(string countText)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EC")]
		[Cpp2IlInjected.Address(RVA = "0x7DBFBA0", Offset = "0x7DBE3A0", VA = "0x187DBFBA0")]
		public void BeginStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007ED")]
		[Cpp2IlInjected.Address(RVA = "0x7DBFCE0", Offset = "0x7DBE4E0", VA = "0x187DBFCE0")]
		private void DeactiveStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EE")]
		[Cpp2IlInjected.Address(RVA = "0x7DBFCB0", Offset = "0x7DBE4B0", VA = "0x187DBFCB0")]
		public void CompleteStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0x7DBFDF0", Offset = "0x7DBE5F0", VA = "0x187DBFDF0")]
		public void GoBack()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[ViewModel]
	public class TutorialStepViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x20000C0")]
		[CompilerGenerated]
		private sealed class <UpdateVisualsCoroutine>d__63 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005AC")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005AD")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005AE")]
			public TutorialStepViewModel <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000209")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600082E")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700020A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000830")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600082B")]
			[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
			[DebuggerHidden]
			public <UpdateVisualsCoroutine>d__63(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600082C")]
			[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600082D")]
			[Cpp2IlInjected.Address(RVA = "0x7DC5B00", Offset = "0x7DC4300", VA = "0x187DC5B00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600082F")]
			[Cpp2IlInjected.Address(RVA = "0x7DC5B90", Offset = "0x7DC4390", VA = "0x187DC5B90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		[SerializeField]
		private RectTransform highlightArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		[SerializeField]
		private RectTransform dialogTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		[SerializeField]
		private float maskPadding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		[SerializeField]
		private float additionalAnchorOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		[SerializeField]
		private CanvasScreenSizeRefitter canvasScreenSizeRefitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		[SerializeField]
		private GameObject hackyLeftArrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		[SerializeField]
		private GameObject hackyUpArrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private TutorialStep step;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private Coroutine updateVisualsCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private Canvas targetCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private string title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private string buttonText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private bool showMainButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private bool canInteractWithHighlightArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private bool showExitButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private bool showNextArrowButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private bool showBackArrowButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private string countText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private DataItem<string> TitleDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		private DataItem<string> DescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private DataItem<string> ButtonTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private DataItem<bool> ShowMainButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private DataItem<bool> CanInteractWithHighlightAreaDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private DataItem<bool> ShowExitButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private DataItem<bool> ShowNextArrowButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private DataItem<bool> ShowBackArrowButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private DataItem<string> CountTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private DataItemAction GoToNextStepDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private DataItemAction SkipTutorialDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private DataItemAction SoftExitTutorialDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private DataItemAction GoToPreviousStepDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		private Camera screenCamera
		{
			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x16F3510", Offset = "0x16F1D10", VA = "0x1816F3510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		private Canvas sourceCanvas
		{
			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0x7DBF8C0", Offset = "0x7DBE0C0", VA = "0x187DBF8C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		private RectTransform sourceCanvasRect
		{
			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0x7DBF840", Offset = "0x7DBE040", VA = "0x187DBF840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		private RectTransform targetCanvasRect
		{
			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x7DBF8E0", Offset = "0x7DBE0E0", VA = "0x187DBF8E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0xA35010", Offset = "0xA33810", VA = "0x180A35010")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x7DBFB20", Offset = "0x7DBE320", VA = "0x187DBFB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FF")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0xA35020", Offset = "0xA33820", VA = "0x180A35020")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0x7DBFAA0", Offset = "0x7DBE2A0", VA = "0x187DBFAA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000200")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string ButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0xA8DF30", Offset = "0xA8C730", VA = "0x180A8DF30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0x7DBF9A0", Offset = "0x7DBE1A0", VA = "0x187DBF9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000201")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool ShowMainButton
		{
			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0xECB790", Offset = "0xEC9F90", VA = "0x180ECB790")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x7DBE700", Offset = "0x7DBCF00", VA = "0x187DBE700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000202")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool CanInteractWithHighlightArea
		{
			[Cpp2IlInjected.Token(Token = "0x60007FC")]
			[Cpp2IlInjected.Address(RVA = "0x1A7DC00", Offset = "0x1A7C400", VA = "0x181A7DC00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007FD")]
			[Cpp2IlInjected.Address(RVA = "0x7DBE760", Offset = "0x7DBCF60", VA = "0x187DBE760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public bool ShowExitButton
		{
			[Cpp2IlInjected.Token(Token = "0x60007FE")]
			[Cpp2IlInjected.Address(RVA = "0x470DE50", Offset = "0x470C650", VA = "0x18470DE50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007FF")]
			[Cpp2IlInjected.Address(RVA = "0x7DBE5A0", Offset = "0x7DBCDA0", VA = "0x187DBE5A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000204")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool ShowNextArrowButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000800")]
			[Cpp2IlInjected.Address(RVA = "0x7C801C0", Offset = "0x7C7E9C0", VA = "0x187C801C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000801")]
			[Cpp2IlInjected.Address(RVA = "0x7DBE600", Offset = "0x7DBCE00", VA = "0x187DBE600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000205")]
		[BindableData(7, null, DataPermissions.ReadWrite)]
		public bool ShowBackArrowButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000802")]
			[Cpp2IlInjected.Address(RVA = "0x1D192E0", Offset = "0x1D17AE0", VA = "0x181D192E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000803")]
			[Cpp2IlInjected.Address(RVA = "0x7DBE660", Offset = "0x7DBCE60", VA = "0x187DBE660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000206")]
		[BindableData(8, null, DataPermissions.ReadWrite)]
		public string CountText
		{
			[Cpp2IlInjected.Token(Token = "0x6000804")]
			[Cpp2IlInjected.Address(RVA = "0xA8E350", Offset = "0xA8CB50", VA = "0x180A8E350")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000805")]
			[Cpp2IlInjected.Address(RVA = "0x7DBFA20", Offset = "0x7DBE220", VA = "0x187DBFA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000207")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000814")]
			[Cpp2IlInjected.Address(RVA = "0x7DBF800", Offset = "0x7DBE000", VA = "0x187DBF800", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000208")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000815")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000806")]
		[Cpp2IlInjected.Address(RVA = "0x7DBD500", Offset = "0x7DBBD00", VA = "0x187DBD500")]
		[BindableAction(100, null)]
		public void GoToNextStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000807")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE450", Offset = "0x7DBCC50", VA = "0x187DBE450")]
		[BindableAction(101, null)]
		public void SkipTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE4F0", Offset = "0x7DBCCF0", VA = "0x187DBE4F0")]
		[BindableAction(102, null)]
		public void SoftExitTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x7DBD550", Offset = "0x7DBBD50", VA = "0x187DBD550")]
		[BindableAction(103, null)]
		public void GoToPreviousStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE310", Offset = "0x7DBCB10", VA = "0x187DBE310")]
		public void Set(TutorialStep step)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE2C0", Offset = "0x7DBCAC0", VA = "0x187DBE2C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE280", Offset = "0x7DBCA80", VA = "0x187DBE280")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE1C0", Offset = "0x7DBC9C0", VA = "0x187DBE1C0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE7C0", Offset = "0x7DBCFC0", VA = "0x187DBE7C0")]
		private void UpdateStepData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x7DBECC0", Offset = "0x7DBD4C0", VA = "0x187DBECC0")]
		[IteratorStateMachine(typeof(<UpdateVisualsCoroutine>d__63))]
		private IEnumerator UpdateVisualsCoroutine()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x7DBED40", Offset = "0x7DBD540", VA = "0x187DBED40")]
		private void UpdateVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x7DBC8E0", Offset = "0x7DBB0E0", VA = "0x187DBC8E0")]
		private void AlignEdgeToEdge(RectTransform source, RectTransform target, TextAnchor sourceEdge, TextAnchor targetEdge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x7DBD400", Offset = "0x7DBBC00", VA = "0x187DBD400")]
		private Vector2 GetPivotFromAnchor(TextAnchor anchor)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x7DBE070", Offset = "0x7DBC870", VA = "0x187DBE070")]
		private void MatchSourceLossyScale(Transform source, Transform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x7DBD5A0", Offset = "0x7DBBDA0", VA = "0x187DBD5A0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x7DBD1B0", Offset = "0x7DBB9B0", VA = "0x187DBD1B0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x7DBF3F0", Offset = "0x7DBDBF0", VA = "0x187DBF3F0")]
		public TutorialStepViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public class TutorialUIManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		public static KECNPIDOCPH OnCreated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		public KECNPIDOCPH OnDataUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		private Dictionary<string, Dictionary<string, RectTransform>> tutorialTargets;

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		public static TutorialUIManager Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000831")]
			[Cpp2IlInjected.Address(RVA = "0x7DC11E0", Offset = "0x7DBF9E0", VA = "0x187DC11E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000832")]
			[Cpp2IlInjected.Address(RVA = "0x7DC1230", Offset = "0x7DBFA30", VA = "0x187DC1230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		public Tutorial ActiveTutorial
		{
			[Cpp2IlInjected.Token(Token = "0x6000833")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000834")]
			[Cpp2IlInjected.Address(RVA = "0xA2A960", Offset = "0xA29160", VA = "0x180A2A960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0250", Offset = "0x7DBEA50", VA = "0x187DC0250")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0560", Offset = "0x7DBED60", VA = "0x187DC0560")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0x7DC03D0", Offset = "0x7DBEBD0", VA = "0x187DC03D0")]
		private void ClearActiveTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0x7DC03E0", Offset = "0x7DBEBE0", VA = "0x187DC03E0")]
		private void ClearActiveTutorial(bool sendUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0x7DC09D0", Offset = "0x7DBF1D0", VA = "0x187DC09D0")]
		public void StartTutorial(Tutorial tutorial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0x7DC04D0", Offset = "0x7DBECD0", VA = "0x187DC04D0")]
		public void EndTutorial(bool showAgain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0690", Offset = "0x7DBEE90", VA = "0x187DC0690")]
		public void RegisterTutorialTarget(string tutorialId, string stepId, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0x7DC0DB0", Offset = "0x7DBF5B0", VA = "0x187DC0DB0")]
		public void UnregisterTutorialTarget(string tutorialId, string stepId, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1110", Offset = "0x7DBF910", VA = "0x187DC1110")]
		public TutorialUIManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[ViewModel]
	public class TutorialUIViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		[SerializeField]
		private CanvasScreenSizeRefitter canvasScreenSizeRefitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		[SerializeField]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		[SerializeField]
		private TutorialStepViewModel tutorialStepViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private Tutorial activeTutorial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private bool isTutorialActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private DataItem<bool> IsTutorialActiveDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool IsTutorialActive
		{
			[Cpp2IlInjected.Token(Token = "0x600083F")]
			[Cpp2IlInjected.Address(RVA = "0xA2D4B0", Offset = "0xA2BCB0", VA = "0x180A2D4B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000840")]
			[Cpp2IlInjected.Address(RVA = "0x7DC1BE0", Offset = "0x7DC03E0", VA = "0x187DC1BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000846")]
			[Cpp2IlInjected.Address(RVA = "0x7DC1CD0", Offset = "0x7DC04D0", VA = "0x187DC1CD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000847")]
			[Cpp2IlInjected.Address(RVA = "0xA73360", Offset = "0xA71B60", VA = "0x180A73360", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000841")]
		[Cpp2IlInjected.Address(RVA = "0x7DC12A0", Offset = "0x7DBFAA0", VA = "0x187DC12A0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000842")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1AC0", Offset = "0x7DC02C0", VA = "0x187DC1AC0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000843")]
		[Cpp2IlInjected.Address(RVA = "0x7DC15B0", Offset = "0x7DBFDB0", VA = "0x187DC15B0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000844")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1A40", Offset = "0x7DC0240", VA = "0x187DC1A40")]
		private void OnStepChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000845")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1750", Offset = "0x7DBFF50", VA = "0x187DC1750")]
		private void OnManagerUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000848")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1460", Offset = "0x7DBFC60", VA = "0x187DC1460", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000849")]
		[Cpp2IlInjected.Address(RVA = "0x7DC13B0", Offset = "0x7DBFBB0", VA = "0x187DC13B0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084A")]
		[Cpp2IlInjected.Address(RVA = "0x7DC1C40", Offset = "0x7DC0440", VA = "0x187DC1C40")]
		public TutorialUIViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[CreateAssetMenu(fileName = "UITutorialData", menuName = "RecRoom/UI/UI Tutorial Data")]
	public class UITutorialData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000C4")]
		private class TutorialStepData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005BE")]
			public string Id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005BF")]
			public string Title;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005C0")]
			public string Description;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005C1")]
			public string ButtonText;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005C2")]
			public bool ShowButtonToGoForward;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x40005C3")]
			public bool ShowButtonToGoBack;

			[Cpp2IlInjected.FieldOffset(Offset = "0x32")]
			[Cpp2IlInjected.Token(Token = "0x40005C4")]
			public bool ShowCountText;

			[Cpp2IlInjected.FieldOffset(Offset = "0x33")]
			[Cpp2IlInjected.Token(Token = "0x40005C5")]
			public bool ShowExitButton;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40005C6")]
			public bool CanSoftExit;

			[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
			[Cpp2IlInjected.Token(Token = "0x40005C7")]
			public bool AllowInteraction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x36")]
			[Cpp2IlInjected.Token(Token = "0x40005C8")]
			public bool TargetingHUD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005C9")]
			public TextAnchor DialogAnchor;

			[Cpp2IlInjected.Token(Token = "0x600084F")]
			[Cpp2IlInjected.Address(RVA = "0x7DBC610", Offset = "0x7DBAE10", VA = "0x187DBC610")]
			public TutorialStep ToTutorialStep()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000850")]
			[Cpp2IlInjected.Address(RVA = "0x7DBC820", Offset = "0x7DBB020", VA = "0x187DBC820")]
			public TutorialStepData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		[SerializeField]
		private string id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		[SerializeField]
		private List<TutorialStepData> steps;

		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6220", Offset = "0x7DC4A20", VA = "0x187DC6220")]
		public Tutorial GenerateTutorialFromData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6410", Offset = "0x7DC4C10", VA = "0x187DC6410")]
		public UITutorialData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	public enum UILinkType
	{
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		Uri,
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		Tab,
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		Legacy
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public enum LegacyUIType
	{
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		Challenges,
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		Outfits
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public class LinkInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		public string Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		public UILinkType LinkType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		[IKNPDEEBCLA("requiresUri")]
		public Uri LinkUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		[IKNPDEEBCLA("LinkType", UILinkType.Tab)]
		public LEENOOJANNL LinkTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		[IKNPDEEBCLA("LinkType", UILinkType.Legacy)]
		public LegacyUIType LegacyType;

		[Cpp2IlInjected.Token(Token = "0x17000210")]
		public bool IsLegacyUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000851")]
			[Cpp2IlInjected.Address(RVA = "0x20D4110", Offset = "0x20D2910", VA = "0x1820D4110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0x7DB22C0", Offset = "0x7DB0AC0", VA = "0x187DB22C0")]
		public LinkInfo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	[CreateAssetMenu(fileName = "RouteLookup", menuName = "RecRoom/UI/Route Lookup")]
	public class UILinkLookup : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		[FormerlySerializedAs("routeInfos")]
		[SerializeField]
		private List<LinkInfo> linkInfoList;

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0x7DC5EE0", Offset = "0x7DC46E0", VA = "0x187DC5EE0")]
		public bool TryGetLinkInfo(string alias, [Out] LinkInfo linkInfo)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6060", Offset = "0x7DC4860", VA = "0x187DC6060")]
		public bool TryGetUri(string routeId, [Out] Uri uri)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0x7DC5BE0", Offset = "0x7DC43E0", VA = "0x187DC5BE0")]
		public List<Uri> GetAllUri()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0x7DC5D60", Offset = "0x7DC4560", VA = "0x187DC5D60")]
		public bool TryGetLegacyUIType(string routeId, [Out] LegacyUIType legacyUIType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000857")]
		[Cpp2IlInjected.Address(RVA = "0xC33770", Offset = "0xC31F70", VA = "0x180C33770")]
		public UILinkLookup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public class WatchViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private const string UnifiedUISessionIdKey = "unified_ui_session_id";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private IMenuManager _menuManager;

		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0x7DC64C0", Offset = "0x7DC4CC0", VA = "0x187DC64C0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6750", Offset = "0x7DC4F50", VA = "0x187DC6750", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6820", Offset = "0x7DC5020", VA = "0x187DC6820")]
		private void OnWatchMenuUnifiedSessionIdChanged(Guid watchMenuUnifiedSessionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x7DB2320", Offset = "0x7DB0B20", VA = "0x187DB2320")]
		public WatchViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	public class CanvasScreenSizeRefitter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		[SerializeField]
		private Canvas targetCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		[SerializeField]
		private float minPercentageOfScreenHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		[SerializeField]
		private float maxPercentageOfScreenHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		[SerializeField]
		private float offsetFromNearClipPlane;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		[SerializeField]
		private Camera lookAtCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		[SerializeField]
		private bool updateOnCameraMove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		[SerializeField]
		private bool useScreenSafeArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		[SerializeField]
		private bool forceWidthToFitScreen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private Vector2 cachedDimensions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private Vector2 cachedSafeAreaDimensions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private Vector3 cachedCameraPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		private Quaternion cachedCameraRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private float cachedFov;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private bool forceUpdate;

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		public Canvas TargetCanvas
		{
			[Cpp2IlInjected.Token(Token = "0x600085C")]
			[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000212")]
		public Camera TargetCamera
		{
			[Cpp2IlInjected.Token(Token = "0x600085D")]
			[Cpp2IlInjected.Address(RVA = "0xA2D380", Offset = "0xA2BB80", VA = "0x180A2D380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000213")]
		public float OffsetFromCamera
		{
			[Cpp2IlInjected.Token(Token = "0x600085E")]
			[Cpp2IlInjected.Address(RVA = "0x7DACC10", Offset = "0x7DAB410", VA = "0x187DACC10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000214")]
		private float cameraFov
		{
			[Cpp2IlInjected.Token(Token = "0x600085F")]
			[Cpp2IlInjected.Address(RVA = "0x7DACCA0", Offset = "0x7DAB4A0", VA = "0x187DACCA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000215")]
		private Vector3 cameraPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000860")]
			[Cpp2IlInjected.Address(RVA = "0x7DACD30", Offset = "0x7DAB530", VA = "0x187DACD30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000216")]
		private Quaternion cameraRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000861")]
			[Cpp2IlInjected.Address(RVA = "0x7DACE00", Offset = "0x7DAB600", VA = "0x187DACE00")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000217")]
		private RectTransform canvasRect
		{
			[Cpp2IlInjected.Token(Token = "0x6000862")]
			[Cpp2IlInjected.Address(RVA = "0x7DACED0", Offset = "0x7DAB6D0", VA = "0x187DACED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0xA2EE80", Offset = "0xA2D680", VA = "0x180A2EE80")]
		public void SetLookCamera(Camera lookAt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x26D5D80", Offset = "0x26D4580", VA = "0x1826D5D80")]
		public void ForceUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000865")]
		[Cpp2IlInjected.Address(RVA = "0x7DABED0", Offset = "0x7DAA6D0", VA = "0x187DABED0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000866")]
		[Cpp2IlInjected.Address(RVA = "0x7DAC6B0", Offset = "0x7DAAEB0", VA = "0x187DAC6B0")]
		private void UpdateScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0x7DAC170", Offset = "0x7DAA970", VA = "0x187DAC170")]
		public void PinToTopLeftOfScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x7DACB00", Offset = "0x7DAB300", VA = "0x187DACB00")]
		public CanvasScreenSizeRefitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	public class ImpressionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		public Dictionary<string, int> IntData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		public Dictionary<string, float> FloatData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		public Dictionary<string, long> LongData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		public Dictionary<string, string> StringData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		public Dictionary<string, Guid> GuidData;

		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0x7DADBC0", Offset = "0x7DAC3C0", VA = "0x187DADBC0")]
		public bool TryGetValueAsString(string key, [Out] string valString, string format = "")
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0x7DAD980", Offset = "0x7DAC180", VA = "0x187DAD980")]
		public LNIJEOMEBOK.LFGHOPIMKAN TryAddProperty(string key, LNIJEOMEBOK.LFGHOPIMKAN eventBuilder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600086B")]
		[Cpp2IlInjected.Address(RVA = "0x7DAD010", Offset = "0x7DAB810", VA = "0x187DAD010")]
		public void ClearData(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086C")]
		[Cpp2IlInjected.Address(RVA = "0x7DACF30", Offset = "0x7DAB730", VA = "0x187DACF30")]
		public void ClearAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086D")]
		[Cpp2IlInjected.Address(RVA = "0x7DAD240", Offset = "0x7DABA40", VA = "0x187DAD240")]
		public void CopyData(ImpressionData copyTo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086E")]
		[Cpp2IlInjected.Address(RVA = "0x7DADDA0", Offset = "0x7DAC5A0", VA = "0x187DADDA0")]
		public ImpressionData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public class ImpressionTracker : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		public enum PassToChildren
		{
			[Cpp2IlInjected.Token(Token = "0x4000610")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x4000611")]
			Enabled,
			[Cpp2IlInjected.Token(Token = "0x4000612")]
			EnabledRecursive
		}

		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		[Flags]
		internal enum ImpressionLogEvents
		{
			[Cpp2IlInjected.Token(Token = "0x4000614")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000615")]
			OnClickThrough = 1,
			[Cpp2IlInjected.Token(Token = "0x4000616")]
			OnNavigateToNewPage = 2,
			[Cpp2IlInjected.Token(Token = "0x4000617")]
			OnMenuClosed = 4,
			[Cpp2IlInjected.Token(Token = "0x4000618")]
			OnStopTracking = 8,
			[Cpp2IlInjected.Token(Token = "0x4000619")]
			OnDisable = 0x10
		}

		[Cpp2IlInjected.Token(Token = "0x20000CF")]
		internal enum ImpressionLogConditions
		{
			[Cpp2IlInjected.Token(Token = "0x400061B")]
			NoConditions,
			[Cpp2IlInjected.Token(Token = "0x400061C")]
			OnlyWhenChildrenAreTracked
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		[CompilerGenerated]
		private struct <FinishCleanUpAfterLoggingComplete>d__45 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400061D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400061E")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400061F")]
			public Task logTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000620")]
			public ImpressionTracker <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000621")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600089B")]
			[Cpp2IlInjected.Address(RVA = "0x7DC70B0", Offset = "0x7DC58B0", VA = "0x187DC70B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600089C")]
			[Cpp2IlInjected.Address(RVA = "0xA86C20", Offset = "0xA85420", VA = "0x180A86C20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private static DMJNBPOKINC<ImpressionData> ImpressionDataPool;

		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		private const float minSecondsForImpression = 0.1f;

		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private const string buttonLocationProperty = "buttonLocation";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		[SerializeField]
		private ImpressionLogEvents logEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		[SerializeField]
		private ImpressionLogConditions logConditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		[SerializeField]
		private VisibilityChecker visibilityChecker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		private ImpressionData impressionData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private int idCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private Dictionary<int, string> idToKeyLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private Dictionary<string, int> keyToIdLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private List<int> recordedKeys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private List<int> dataToRecordOnClickThrough;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private List<ImpressionTracker> children;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private List<ImpressionTracker> tempChildrenWhileLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private Dictionary<int, PassToChildren> dataToPassToChildren;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private List<int> dataToCollateFromChildrenOnLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		private Dictionary<int, int> collatedDataToRecordUnderDifferentKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		private List<int> dataToClearOnChildrenAfterLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private Dictionary<int, string> defaultValueLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private Dictionary<string, string> stringFormatLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		private List<ImpressionData> childImpressionsNotYetLogged;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		private List<ImpressionData> allChildImpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		private Uri pageUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		private bool pageUriActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		private ImpressionTracker parentTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		private bool parentTrackerInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		private bool trackingActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		private StringBuilder stringBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		public Action<ImpressionTracker> ChildAdded;

		[Cpp2IlInjected.Token(Token = "0x17000218")]
		public bool AutoTrackWhenVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000870")]
			[Cpp2IlInjected.Address(RVA = "0xB42260", Offset = "0xB40A60", VA = "0x180B42260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000871")]
			[Cpp2IlInjected.Address(RVA = "0xB41160", Offset = "0xB3F960", VA = "0x180B41160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600086F")]
		[Cpp2IlInjected.Address(RVA = "0x7DB1C40", Offset = "0x7DB0440", VA = "0x187DB1C40")]
		private void TryInitializeParentTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0x7DADF60", Offset = "0x7DAC760", VA = "0x187DADF60")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000873")]
		[Cpp2IlInjected.Address(RVA = "0x7DAF8F0", Offset = "0x7DAE0F0", VA = "0x187DAF8F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0x7DAF780", Offset = "0x7DADF80", VA = "0x187DAF780")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0x7DAFF50", Offset = "0x7DAE750", VA = "0x187DAFF50")]
		public void SetDataToCollateFromChildrenOnLog(string key, string defaultValue, bool clearAfterLogging = false, string keyToRecordCollatedData = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0070", Offset = "0x7DAE870", VA = "0x187DB0070")]
		public void SetDataToRecordOnClickThrough(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0x7DAEBA0", Offset = "0x7DAD3A0", VA = "0x187DAEBA0")]
		public void LogImpression(bool force = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x7DAE760", Offset = "0x7DACF60", VA = "0x187DAE760")]
		[AsyncStateMachine(typeof(<FinishCleanUpAfterLoggingComplete>d__45))]
		private void FinishCleanUpAfterLoggingComplete(Task logTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x7DB13A0", Offset = "0x7DAFBA0", VA = "0x187DB13A0")]
		public void StartTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x7DB1860", Offset = "0x7DB0060", VA = "0x187DB1860")]
		public void StopTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x7DB1710", Offset = "0x7DAFF10", VA = "0x187DB1710")]
		public void StopTrackingAndClearData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x7DAFC20", Offset = "0x7DAE420", VA = "0x187DAFC20")]
		public void RecordClickThrough([Optional] string buttonName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0E10", Offset = "0x7DAF610", VA = "0x187DB0E10")]
		public void SetString(string key, string data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0E40", Offset = "0x7DAF640", VA = "0x187DB0E40")]
		public void SetString(string key, string data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0600", Offset = "0x7DAEE00", VA = "0x187DB0600")]
		public void SetGuid(string key, Guid data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0380", Offset = "0x7DAEB80", VA = "0x187DB0380")]
		public void SetGuid(string key, Guid data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x7DB08D0", Offset = "0x7DAF0D0", VA = "0x187DB08D0")]
		public void SetLong(string key, long data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0900", Offset = "0x7DAF100", VA = "0x187DB0900")]
		public void SetLong(string key, long data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x7DB00E0", Offset = "0x7DAE8E0", VA = "0x187DB00E0")]
		public void SetFloat(string key, float data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0110", Offset = "0x7DAE910", VA = "0x187DB0110")]
		public void SetFloat(string key, float data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0B60", Offset = "0x7DAF360", VA = "0x187DB0B60")]
		public void SetObject(string key, object data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0B90", Offset = "0x7DAF390", VA = "0x187DB0B90")]
		public void SetObject(string key, object data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x7DB08A0", Offset = "0x7DAF0A0", VA = "0x187DB08A0")]
		public void SetInt(string key, int data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x7DB0640", Offset = "0x7DAEE40", VA = "0x187DB0640")]
		public void SetInt(string key, int data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x7DB1BB0", Offset = "0x7DB03B0", VA = "0x187DB1BB0")]
		public bool TryGetValueAsString(string key, [Out] string valString, string format = "")
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x7DAE150", Offset = "0x7DAC950", VA = "0x187DAE150")]
		public void ClearData(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x7DAE8C0", Offset = "0x7DAD0C0", VA = "0x187DAE8C0")]
		private int GetOrAddKeyId(string key)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x7DAE830", Offset = "0x7DAD030", VA = "0x187DAE830")]
		private string GetKey(int id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600088D")]
		[Cpp2IlInjected.Address(RVA = "0x7DAFE90", Offset = "0x7DAE690", VA = "0x187DAFE90")]
		private void RecordDuration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x7DB11D0", Offset = "0x7DAF9D0", VA = "0x187DB11D0")]
		private void StartTrackingChild(ImpressionTracker child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088F")]
		[Cpp2IlInjected.Address(RVA = "0x7DB1750", Offset = "0x7DAFF50", VA = "0x187DB1750")]
		private void StopTrackingChild(ImpressionTracker child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x7DAEA40", Offset = "0x7DAD240", VA = "0x187DAEA40")]
		private void HandleVisibilityChanged(bool isVisible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x7DAF650", Offset = "0x7DADE50", VA = "0x187DAF650")]
		private void LogImpressionsOnBrowserModelNavigationComplete(PageWrapper destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x7DAF6F0", Offset = "0x7DADEF0", VA = "0x187DAF6F0")]
		private void LogImpressionsOnMenuClose(bool isOpen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0x7DB1D30", Offset = "0x7DB0530", VA = "0x187DB1D30")]
		private void TryResumeTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000894")]
		[Cpp2IlInjected.Address(RVA = "0x7DAF910", Offset = "0x7DAE110", VA = "0x187DAF910")]
		private void PassDataToChild(string key, ImpressionTracker child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000895")]
		[Cpp2IlInjected.Address(RVA = "0x7DAE380", Offset = "0x7DACB80", VA = "0x187DAE380")]
		private string CollateDataFromChildren(int keyId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000896")]
		[Cpp2IlInjected.Address(RVA = "0x7DB10A0", Offset = "0x7DAF8A0", VA = "0x187DB10A0")]
		private int SortByElementIndex(ImpressionData lhs, ImpressionData rhs)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000897")]
		[Cpp2IlInjected.Address(RVA = "0x7DAE140", Offset = "0x7DAC940", VA = "0x187DAE140")]
		private bool CanLogEvent(ImpressionLogEvents logEvent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000898")]
		[Cpp2IlInjected.Address(RVA = "0x7DAE9B0", Offset = "0x7DAD1B0", VA = "0x187DAE9B0")]
		private void GuaranteeImpressionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000899")]
		[Cpp2IlInjected.Address(RVA = "0x7DB1E60", Offset = "0x7DB0660", VA = "0x187DB1E60")]
		public ImpressionTracker()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public class CanvasSizeData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		public Vector2 CanvasSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		public DMGJGGMGIKH Platforms;

		[Cpp2IlInjected.Token(Token = "0x600089D")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public CanvasSizeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	[CreateAssetMenu(fileName = "PlatformDependentCanvasSizeConfig", menuName = "RecRoom/UI/Canvas Size Settings")]
	public class PlatformDependentCanvasSizeConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		[SerializeField]
		private Vector2 fallbackCanvasSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		[SerializeField]
		private List<CanvasSizeData> canvasSizeSettings;

		[Cpp2IlInjected.Token(Token = "0x600089E")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6910", Offset = "0x7DC5110", VA = "0x187DC6910")]
		public Vector2 GetSizeForPlatform(DMGJGGMGIKH platform)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600089F")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6A90", Offset = "0x7DC5290", VA = "0x187DC6A90")]
		public PlatformDependentCanvasSizeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	public class RaycastIgnoreTransformFilter : MonoBehaviour, ICanvasRaycastFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		[SerializeField]
		private List<RectTransform> targetTransforms;

		[Cpp2IlInjected.Token(Token = "0x60008A0")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6AF0", Offset = "0x7DC52F0", VA = "0x187DC6AF0", Slot = "4")]
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A1")]
		[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
		public RaycastIgnoreTransformFilter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public class RectTransformAspectRatioResizer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		public enum ResizeDimension
		{
			[Cpp2IlInjected.Token(Token = "0x400062A")]
			Height,
			[Cpp2IlInjected.Token(Token = "0x400062B")]
			Width
		}

		[Cpp2IlInjected.Token(Token = "0x20000D6")]
		[CompilerGenerated]
		private sealed class <FitResizeDimensionToAspectRatioAtEndOfFrame>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400062C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400062D")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400062E")]
			public RectTransformAspectRatioResizer <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000219")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60008AA")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700021A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60008AC")]
				[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008A7")]
			[Cpp2IlInjected.Address(RVA = "0xA2B740", Offset = "0xA29F40", VA = "0x180A2B740")]
			[DebuggerHidden]
			public <FitResizeDimensionToAspectRatioAtEndOfFrame>d__4(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008A8")]
			[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008A9")]
			[Cpp2IlInjected.Address(RVA = "0x7DC7340", Offset = "0x7DC5B40", VA = "0x187DC7340", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008AB")]
			[Cpp2IlInjected.Address(RVA = "0x7DC7500", Offset = "0x7DC5D00", VA = "0x187DC7500", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		[SerializeField]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		[SerializeField]
		private ResizeDimension resizeDimension;

		[Cpp2IlInjected.Token(Token = "0x60008A2")]
		[Cpp2IlInjected.Address(RVA = "0x7DC7030", Offset = "0x7DC5830", VA = "0x187DC7030")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A3")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6C60", Offset = "0x7DC5460", VA = "0x187DC6C60")]
		[IteratorStateMachine(typeof(<FitResizeDimensionToAspectRatioAtEndOfFrame>d__4))]
		private IEnumerator FitResizeDimensionToAspectRatioAtEndOfFrame()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6CE0", Offset = "0x7DC54E0", VA = "0x187DC6CE0")]
		private void FitResizeDimensionToAspectRatio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x7DC6E00", Offset = "0x7DC5600", VA = "0x187DC6E00")]
		private float GetScreenAspectRatio(RectTransform rectTransform)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0xA28D30", Offset = "0xA27530", VA = "0x180A28D30")]
		public RectTransformAspectRatioResizer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class RRUIBinderAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
		public RRUIBinderAttribute()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
