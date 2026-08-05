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
	[EMFMMKKCPNF(MEAOHOOOBOD.Self, false, false, false)]
	private SpriteRenderer spriteRenderer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private Sprite originalSprite;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Sprite AFFBJLEOCIL;

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
	private float HKJJBFLHBCI;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static Vector3[] GOAAFANMDMA;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static Vector3[] EEPHJMABBMC;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static List<Vector2> AKFIMOKILLF;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static List<ushort> FJMBCDHGFGG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public float FDPCFGFFMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xC99200", Offset = "0xC97C00", VA = "0x180C99200")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7B088E0", Offset = "0x7B072E0", VA = "0x187B088E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool LHALFDGFHMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xE06CF0", Offset = "0xE056F0", VA = "0x180E06CF0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B08960", Offset = "0x7B07360", VA = "0x187B08960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int HAHJFNOOBLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA288C0", Offset = "0xA272C0", VA = "0x180A288C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7B08970", Offset = "0x7B07370", VA = "0x187B08970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7B08730", Offset = "0x7B07130", VA = "0x187B08730")]
	public void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7B08410", Offset = "0x7B06E10", VA = "0x187B08410")]
	public void ForceRegenerateSprite()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7B086F0", Offset = "0x7B070F0", VA = "0x187B086F0")]
	private void KKOPAGCNBMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7B08380", Offset = "0x7B06D80", VA = "0x187B08380")]
	private void EILGJFGGIFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7B08650", Offset = "0x7B07050", VA = "0x187B08650")]
	private Vector4 IIOOHFHPPLA(Sprite NDFNAFDNBHK)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7B084F0", Offset = "0x7B06EF0", VA = "0x187B084F0")]
	private Sprite IAPMIMNCFCL(Sprite OKFHNJPHDOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7B077A0", Offset = "0x7B061A0", VA = "0x187B077A0")]
	private void ECIBGBIKBKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
	public SpriteFill()
	{
	}
}
namespace _LogRegistration.RecRoom_AppUI_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : GIIBELOIOJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7AFE080", Offset = "0x7AFCA80", VA = "0x187AFE080", Slot = "4")]
		public override void EPIAMCEAEFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_AppUI_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7B0F030", Offset = "0x7B0DA30", VA = "0x187B0F030", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2796C60", Offset = "0x2795660", VA = "0x182796C60")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EGFEGFNEHOL
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DBNAFJKLEIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string IOJNCMCCALL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string OFBOEFOIKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string FNJCCMPJEJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string IABJFPGOONN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string ONJOLOEBCPK
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
		protected bool BHFIEKNGBFN;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool CLCDBBNBCPI
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xA10D70", Offset = "0xA0F770", VA = "0x180A10D70", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA10D60", Offset = "0xA0F760", VA = "0x180A10D60", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public virtual float JBOGBCFALHH
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA66550", Offset = "0xA64F50", VA = "0x180A66550", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public virtual float EBMNNOBIICL
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA66560", Offset = "0xA64F60", VA = "0x180A66560", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xC95E70", Offset = "0xC94870", VA = "0x180C95E70")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xC95E70", Offset = "0xC94870", VA = "0x180C95E70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7B02E60", Offset = "0x7B01860", VA = "0x187B02E60")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7B02E20", Offset = "0x7B01820", VA = "0x187B02E20", Slot = "8")]
		public virtual bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
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
		private List<RRUIGameObjectLayoutElement> BNCHGOBFPGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int FGDDIFFEBHA;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7B04660", Offset = "0x7B03060", VA = "0x187B04660")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7B04380", Offset = "0x7B02D80", VA = "0x187B04380")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7B04380", Offset = "0x7B02D80", VA = "0x187B04380")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7B04090", Offset = "0x7B02A90", VA = "0x187B04090")]
		private void NIAADNKFEFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7B03870", Offset = "0x7B02270", VA = "0x187B03870")]
		private float FJHCNKIBJPI()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7B04390", Offset = "0x7B02D90", VA = "0x187B04390")]
		private bool PMBJJGMHJOM([Out] float EMMPIHIGGMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7B03740", Offset = "0x7B02140", VA = "0x187B03740")]
		private bool FAOLJJJICDP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7B039B0", Offset = "0x7B023B0", VA = "0x187B039B0")]
		private void MIFJHOMJEIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7B03050", Offset = "0x7B01A50", VA = "0x187B03050")]
		private void COGEMKNBPHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7B038A0", Offset = "0x7B022A0", VA = "0x187B038A0")]
		private void IBIDGPLKPJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7B045A0", Offset = "0x7B02FA0", VA = "0x187B045A0")]
		public void RebuildLayout()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7B04670", Offset = "0x7B03070", VA = "0x187B04670")]
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
		private Sprite GCMKBAAOIBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool JLHKCFECLJJ;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool CLCDBBNBCPI
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7B04840", Offset = "0x7B03240", VA = "0x187B04840", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override float JBOGBCFALHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7B04920", Offset = "0x7B03320", VA = "0x187B04920", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override float EBMNNOBIICL
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7B04780", Offset = "0x7B03180", VA = "0x187B04780", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7B04700", Offset = "0x7B03100", VA = "0x187B04700", Slot = "8")]
		public override bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
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
		private bool JLHKCFECLJJ;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool CLCDBBNBCPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7B04AC0", Offset = "0x7B034C0", VA = "0x187B04AC0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override float JBOGBCFALHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7B04BA0", Offset = "0x7B035A0", VA = "0x187B04BA0", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override float EBMNNOBIICL
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7B04A60", Offset = "0x7B03460", VA = "0x187B04A60", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7B049E0", Offset = "0x7B033E0", VA = "0x187B049E0", Slot = "8")]
		public override bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AF4770", Offset = "0x7AF3170", VA = "0x187AF4770", Slot = "20")]
		protected override void OnDataUpdated(AccountBadgeIconType dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4810", Offset = "0x7AF3210", VA = "0x187AF4810")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AF5D90", Offset = "0x7AF4790", VA = "0x187AF5D90", Slot = "20")]
		protected override void OnDataUpdated(AccountRoleIconType dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7AF5E30", Offset = "0x7AF4830", VA = "0x187AF5E30")]
		public AccountRoleIconViewBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[RRUIBinder]
	public class ButtonFocusedActionBinder : BaseBinder<Action>
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public enum FocusedState
		{
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			Focused,
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			Unfocused,
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			Both
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		private RRUIButton button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[SerializeField]
		private FocusedState focusedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private bool focused;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7AFA910", Offset = "0x7AF9310", VA = "0x187AFA910", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7AFABA0", Offset = "0x7AF95A0", VA = "0x187AFABA0", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "20")]
		protected override void OnDataUpdated(Action dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7AFAA10", Offset = "0x7AF9410", VA = "0x187AFAA10")]
		protected void OnButtonStateChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7AFAC80", Offset = "0x7AF9680", VA = "0x187AFAC80")]
		public ButtonFocusedActionBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[RRUIBinder]
	public class ButtonFocusedStateBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		private RRUIButton button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private bool focused;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7AFACC0", Offset = "0x7AF96C0", VA = "0x187AFACC0", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7AFAF00", Offset = "0x7AF9900", VA = "0x187AFAF00", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7AFADC0", Offset = "0x7AF97C0", VA = "0x187AFADC0")]
		protected void OnButtonStateChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7AFAFE0", Offset = "0x7AF99E0", VA = "0x187AFAFE0")]
		public ButtonFocusedStateBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[RRUIBinder]
	public class CardHighlightStyleAspectRatioBinder : BaseBinder<HighlightStyle>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public class HighlightStyleAspectRatio
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public HighlightStyle Style;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public float AspectRatio;

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x27EEB00", Offset = "0x27ED500", VA = "0x1827EEB00")]
			public HighlightStyleAspectRatio()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private AspectRatioFitter aspectRatioFitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private RecNetRawImage recNetRawImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		private List<HighlightStyleAspectRatio> aspectRatios;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7AFB020", Offset = "0x7AF9A20", VA = "0x187AFB020", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7AFB320", Offset = "0x7AF9D20", VA = "0x187AFB320", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7AFB120", Offset = "0x7AF9B20", VA = "0x187AFB120")]
		protected void OnImageLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "20")]
		protected override void OnDataUpdated(HighlightStyle dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7AFB420", Offset = "0x7AF9E20", VA = "0x187AFB420")]
		public CardHighlightStyleAspectRatioBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[RRUIBinder]
	public class CarouselHeightBinder : BaseBinder<float?>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private List<LayoutElement> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private LayoutElementSizeBinder.LayoutElementSizeTarget targetSize;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7AFB460", Offset = "0x7AF9E60", VA = "0x187AFB460", Slot = "15")]
		public override void Bind(GameObject bindingObject, bool isListItem, int listItemIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7AFB580", Offset = "0x7AF9F80", VA = "0x187AFB580", Slot = "20")]
		protected override void OnDataUpdated(float? dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7AFB870", Offset = "0x7AFA270", VA = "0x187AFB870")]
		public CarouselHeightBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[RRUIBinder]
	public class CarouselItemSizeBinder : BaseBinder<float?>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7AFB8B0", Offset = "0x7AFA2B0", VA = "0x187AFB8B0", Slot = "20")]
		protected override void OnDataUpdated(float? dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7AFB960", Offset = "0x7AFA360", VA = "0x187AFB960")]
		public CarouselItemSizeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RRUIBinder]
	public class CarouselItemWidthHeightBinder : BaseBinder<Vector2>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7AFB9A0", Offset = "0x7AFA3A0", VA = "0x187AFB9A0", Slot = "20")]
		protected override void OnDataUpdated(Vector2 dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7AFBA50", Offset = "0x7AFA450", VA = "0x187AFBA50")]
		public CarouselItemWidthHeightBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[RRUIBinder]
	public class CarouselRowCountBinder : BaseBinder<int>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7AFBA90", Offset = "0x7AFA490", VA = "0x187AFBA90", Slot = "20")]
		protected override void OnDataUpdated(int dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7AFBB30", Offset = "0x7AFA530", VA = "0x187AFBB30")]
		public CarouselRowCountBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RRUIBinder]
	public class ConditionalPrefabSpawnBinder : BaseBinder<bool>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private struct <LoadPrefab>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public ConditionalPrefabSpawnBinder <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7B0CBC0", Offset = "0x7B0B5C0", VA = "0x187B0CBC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private MultiPrefabSpawner prefabSpawner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private AssetReference prefabReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private bool prependSpawnedObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private bool invert;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private ODDHNIEMFCD<GameObject> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7AFBB70", Offset = "0x7AFA570", VA = "0x187AFBB70", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7AFBDA0", Offset = "0x7AFA7A0", VA = "0x187AFBDA0", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7AFBF40", Offset = "0x7AFA940", VA = "0x187AFBF40", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7AFBCF0", Offset = "0x7AFA6F0", VA = "0x187AFBCF0")]
		[AsyncStateMachine(typeof(<LoadPrefab>d__8))]
		private void LoadPrefab()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		private void OnPopulateInstance(GameObject instance, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		private void OnCleanupInstance(GameObject instance, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7AFC100", Offset = "0x7AFAB00", VA = "0x187AFC100")]
		public ConditionalPrefabSpawnBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[RRUIBinder]
	public class DynamicUIElementsBinder : BaseBinder<DataList>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private DynamicUIModel dynamicUIModel;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7AFC140", Offset = "0x7AFAB40", VA = "0x187AFC140", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7AFC1F0", Offset = "0x7AFABF0", VA = "0x187AFC1F0")]
		public DynamicUIElementsBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[RRUIBinder]
	public class HideableBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private Hideable hideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[SerializeField]
		private bool invert;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7AFC230", Offset = "0x7AFAC30", VA = "0x187AFC230", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7AFC2D0", Offset = "0x7AFACD0", VA = "0x187AFC2D0")]
		public HideableBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[RRUIBinder]
	public class HtmlColorStringToColorBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private List<Image> targetList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Color htmlColor;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7AFC310", Offset = "0x7AFAD10", VA = "0x187AFC310", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7AFC4D0", Offset = "0x7AFAED0", VA = "0x187AFC4D0")]
		public HtmlColorStringToColorBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[RRUIBinder]
	public class HydrationStateBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private List<HydrateBase> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private bool invert;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7AFC510", Offset = "0x7AFAF10", VA = "0x187AFC510", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7AFC640", Offset = "0x7AFB040", VA = "0x187AFC640")]
		public HydrationStateBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[RRUIBinder]
	public class ImageKeyBinder : BaseBinder<string>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private struct <LoadImage>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public ImageKeyBinder <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public AssetReference assetReference;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private AsyncOperationHandle<Sprite> <handle>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private TaskAwaiter<Sprite> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x7B0C910", Offset = "0x7B0B310", VA = "0x187B0C910", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private Image targetImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[SerializeField]
		private AssetReferenceLookup imageKeyLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private AssetReference currentAsset;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7AFC760", Offset = "0x7AFB160", VA = "0x187AFC760", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7AFC910", Offset = "0x7AFB310", VA = "0x187AFC910", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7AFC8C0", Offset = "0x7AFB2C0", VA = "0x187AFC8C0")]
		private void ReleaseAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7AFC680", Offset = "0x7AFB080", VA = "0x187AFC680")]
		[AsyncStateMachine(typeof(<LoadImage>d__6))]
		private void LoadImage(AssetReference assetReference)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7AFC970", Offset = "0x7AFB370", VA = "0x187AFC970")]
		public ImageKeyBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[RRUIBinder]
	public class ImposterImageBinder : BaseBinder<NJPGBKPAHEG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private ImposterRawImage imposterImage;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7AFC9B0", Offset = "0x7AFB3B0", VA = "0x187AFC9B0", Slot = "20")]
		protected override void OnDataUpdated(NJPGBKPAHEG dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7AFCA40", Offset = "0x7AFB440", VA = "0x187AFCA40")]
		public ImposterImageBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[RRUIBinder]
	public class InfiniteListBinder : BaseBinder<DataList>, LKBGBDEONCN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		protected InfiniteListViewControllerBase infiniteList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		protected GameObject defaultPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private int sourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int listId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private HashSet<int> loadedItems;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public int ItemCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xC9F1D0", Offset = "0xC9DBD0", VA = "0x180C9F1D0", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x1476D30", Offset = "0x1475730", VA = "0x181476D30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public NBHKBEPCJOC<int> OnItemAtIndexLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xA09220", Offset = "0xA07C20", VA = "0x180A09220", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public IReadOnlyCollection<NBGEPAKAGCH> VisibleItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x7AFD6B0", Offset = "0x7AFC0B0", VA = "0x187AFD6B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7AFCAE0", Offset = "0x7AFB4E0", VA = "0x187AFCAE0", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7AFCB70", Offset = "0x7AFB570", VA = "0x187AFCB70", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7AFD050", Offset = "0x7AFBA50", VA = "0x187AFD050")]
		protected void RefreshActiveItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7AFCF50", Offset = "0x7AFB950", VA = "0x187AFCF50", Slot = "27")]
		public virtual void OnItemVisible(InfiniteListDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7AFCEC0", Offset = "0x7AFB8C0", VA = "0x187AFCEC0", Slot = "28")]
		public virtual void OnItemRefresh(InfiniteListDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7AFCCC0", Offset = "0x7AFB6C0", VA = "0x187AFCCC0", Slot = "29")]
		public virtual void OnItemHidden(InfiniteListDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xA092C0", Offset = "0xA07CC0", VA = "0x180A092C0", Slot = "30")]
		public virtual GameObject GetPrefabForIndex(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x7AFCA80", Offset = "0x7AFB480", VA = "0x187AFCA80", Slot = "31")]
		public virtual bool IsItemLoaded(InfiniteListDataItem item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7AFCDD0", Offset = "0x7AFB7D0", VA = "0x187AFCDD0")]
		protected void OnItemLoaded(DataListItemBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7AFD5B0", Offset = "0x7AFBFB0", VA = "0x187AFD5B0")]
		public InfiniteListBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RRUIBinder]
	public class LimitedCapacityListBinder : BaseBinder<DataList>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		protected List<BaseLocalViewModel> limitedListObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private GameObject overflowIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private TMP_Text overflowText;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x7AFDBF0", Offset = "0x7AFC5F0", VA = "0x187AFDBF0", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7AFE040", Offset = "0x7AFCA40", VA = "0x187AFE040")]
		public LimitedCapacityListBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[RRUIBinder]
	public class MultiPrefabSpawnerListBinder : BaseBinder<DataList>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private MultiPrefabSpawner multiPrefabSpawner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private GameObject defaultPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private int sourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private int listId;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7AFE560", Offset = "0x7AFCF60", VA = "0x187AFE560", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7AFE400", Offset = "0x7AFCE00", VA = "0x187AFE400", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x7AFE7B0", Offset = "0x7AFD1B0", VA = "0x187AFE7B0", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7AFE5F0", Offset = "0x7AFCFF0", VA = "0x187AFE5F0", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7AFE6A0", Offset = "0x7AFD0A0", VA = "0x187AFE6A0", Slot = "21")]
		protected virtual void OnInstanceCleanupEvent(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7AFE710", Offset = "0x7AFD110", VA = "0x187AFE710", Slot = "22")]
		protected virtual void OnInstanceSpawnedEvent(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7AFE8F0", Offset = "0x7AFD2F0", VA = "0x187AFE8F0")]
		public MultiPrefabSpawnerListBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class PageNavigationHelper : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		private Uri destinationUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[SerializeField]
		private string analyticsButtonName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[SerializeField]
		private RRUIButton button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7AFEFF0", Offset = "0x7AFD9F0", VA = "0x187AFEFF0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7AFF250", Offset = "0x7AFDC50", VA = "0x187AFF250")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7AFF190", Offset = "0x7AFDB90", VA = "0x187AFF190")]
		public void NavigateToPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7AFF4C0", Offset = "0x7AFDEC0", VA = "0x187AFF4C0")]
		public void SetUriData(string uriDataKey, int data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7AFF3C0", Offset = "0x7AFDDC0", VA = "0x187AFF3C0")]
		public void SetUriData(string uriDataKey, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7AFF440", Offset = "0x7AFDE40", VA = "0x187AFF440")]
		public void SetUriData(string uriDataKey, float data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7AFF330", Offset = "0x7AFDD30", VA = "0x187AFF330")]
		public void SetUriData(string uriDataKey, Guid data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7AFF540", Offset = "0x7AFDF40", VA = "0x187AFF540")]
		public PageNavigationHelper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class PageNavigationHelperUriDataBinder : BaseBinder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[SerializeField]
		private PageNavigationHelper target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[SerializeField]
		private string uriDataKey;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7AFEAE0", Offset = "0x7AFD4E0", VA = "0x187AFEAE0", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7AFEFA0", Offset = "0x7AFD9A0", VA = "0x187AFEFA0")]
		public PageNavigationHelperUriDataBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[RRUIBinder]
	public class PlayerColorSpriteBinder : BaseBinder<IPlayerColor>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[SerializeField]
		private SpriteRenderer target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private IPlayerUIBridge.PlayerColorType _colorType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		private Color defaultColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		[IMEGOPBCDNJ("_colorType", new object[] { 3, 5 })]
		private Color customColor;

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7AFF590", Offset = "0x7AFDF90", VA = "0x187AFF590", Slot = "20")]
		protected override void OnDataUpdated(IPlayerColor dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7AFF730", Offset = "0x7AFE130", VA = "0x187AFF730")]
		public PlayerColorSpriteBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[RRUIBinder]
	public class PlayerColorTextBinder : BaseBinder<IPlayerColor>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[SerializeField]
		private TMP_Text target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[SerializeField]
		private IPlayerUIBridge.PlayerColorType _colorType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[SerializeField]
		private Color defaultColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[IMEGOPBCDNJ("_colorType", new object[] { 3, 5 })]
		[SerializeField]
		private Color customTextColor;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x7AFF780", Offset = "0x7AFE180", VA = "0x187AFF780", Slot = "20")]
		protected override void OnDataUpdated(IPlayerColor dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x7AFF950", Offset = "0x7AFE350", VA = "0x187AFF950")]
		public PlayerColorTextBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[RRUIBinder]
	public class RecNetRawImageBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[SerializeField]
		private RecNetRawImage target;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x7B04C00", Offset = "0x7B03600", VA = "0x187B04C00", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x7B04C90", Offset = "0x7B03690", VA = "0x187B04C90")]
		public RecNetRawImageBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[RRUIBinder]
	public class RoomSourceUriLinkButtonBinder : BaseBinder<RoomListQueryData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		private Button button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		private Uri targetUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[SerializeField]
		private bool useQueryDataInUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[IMEGOPBCDNJ("useQueryDataInUri")]
		[SerializeField]
		private bool overrideQueryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private RoomListQueryData queryDataOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		[SerializeField]
		private bool overrideLoadSceneSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		[IMEGOPBCDNJ("overrideLoadSceneSource")]
		private LNNILEGHPHJ loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x7B07280", Offset = "0x7B05C80", VA = "0x187B07280", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x7B07680", Offset = "0x7B06080", VA = "0x187B07680", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "20")]
		protected override void OnDataUpdated(RoomListQueryData dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7B07410", Offset = "0x7B05E10", VA = "0x187B07410")]
		private void OnButtonClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7B07760", Offset = "0x7B06160", VA = "0x187B07760")]
		public RoomSourceUriLinkButtonBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[RRUIBinder]
	public class StringToWidgetWrapperBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		private WidgetWrapperViewModel widgetWrapper;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7B089A0", Offset = "0x7B073A0", VA = "0x187B089A0", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7B08A60", Offset = "0x7B07460", VA = "0x187B08A60")]
		public StringToWidgetWrapperBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[RRUIBinder]
	public class VirtualizedScrollRectListBinder : BaseBinder<DataList>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int sourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int listId;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7B0E700", Offset = "0x7B0D100", VA = "0x187B0E700", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7B0E970", Offset = "0x7B0D370", VA = "0x187B0E970", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EA00", Offset = "0x7B0D400", VA = "0x187B0EA00", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED70", Offset = "0x7B0D770", VA = "0x187B0ED70", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EC70", Offset = "0x7B0D670", VA = "0x187B0EC70", Slot = "21")]
		protected virtual void OnItemVisible(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EBD0", Offset = "0x7B0D5D0", VA = "0x187B0EBD0", Slot = "22")]
		protected virtual void OnItemRefresh(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EAB0", Offset = "0x7B0D4B0", VA = "0x187B0EAB0", Slot = "23")]
		protected virtual void OnItemInvisible(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EB20", Offset = "0x7B0D520", VA = "0x187B0EB20")]
		private void OnItemLoaded(DataListItemBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7B0EFE0", Offset = "0x7B0D9E0", VA = "0x187B0EFE0")]
		public VirtualizedScrollRectListBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public interface IIconConfig
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		AssetReferenceT<Sprite> BackgroundFillIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		AssetReferenceT<Sprite> BackgroundOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		AssetReferenceT<Sprite> BadgeIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		AssetReferenceT<Sprite> BadgeOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface IIconData<T> where T : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetConfig(T enumValue, [Out] IIconConfig config);
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public abstract class EnumIconDataViewBase<T, U> : MonoBehaviour where T : Enum where U : IIconData<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private T defaultIconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[SerializeField]
		private U iconData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[Header("Image Targets")]
		[SerializeField]
		protected List<Image> backgroundOutlineImageTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		protected List<Image> backgroundFillImageTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		protected List<Image> iconOutlineImageTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		protected List<Image> iconFillImageTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[Header("Sprite Renderer Targets")]
		[SerializeField]
		protected List<SpriteRenderer> backgroundOutlineSpriteRendererTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		protected List<SpriteRenderer> backgroundFillSpriteRendererTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		protected List<SpriteRenderer> iconOutlineSpriteRendererTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		protected List<SpriteRenderer> iconFillSpriteRendererTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private T iconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private bool iconTypeSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private List<ODDHNIEMFCD<Sprite>> resourceHandles;

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x4748570", Offset = "0x4746F70", VA = "0x184748570")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4747670", Offset = "0x4746070", VA = "0x184747670")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x4747AD0", Offset = "0x47464D0", VA = "0x184747AD0")]
		private void ReleaseSpriteHandles()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4747DD0", Offset = "0x47467D0", VA = "0x184747DD0")]
		public void SetIconType(T newIconType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x47485F0", Offset = "0x4746FF0", VA = "0x1847485F0")]
		private void UpdateIcons()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x47476B0", Offset = "0x47460B0", VA = "0x1847476B0")]
		private void LoadAndSetupSprite(AssetReference spriteReference, List<Image> imageTargets, List<SpriteRenderer> spriteRendererTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x4747FD0", Offset = "0x47469D0", VA = "0x184747FD0")]
		private void SetImageTargetsToIcon(List<Image> targets, Sprite icon)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x47481B0", Offset = "0x4746BB0", VA = "0x1847481B0")]
		private void SetSpriteRendererTargetsToIcon(List<SpriteRenderer> targets, Sprite icon)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4748AB0", Offset = "0x47474B0", VA = "0x184748AB0")]
		protected EnumIconDataViewBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class MakerPenHUDNavigationInputState
	{
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public class NavInputState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public float MinHoldDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public float HoldDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public float LastHoldDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public bool WasHeldLastFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public NBHKBEPCJOC<NavInputState> NavInputStateChanged;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public bool IsPressed
			{
				[Cpp2IlInjected.Token(Token = "0x60000BB")]
				[Cpp2IlInjected.Address(RVA = "0x1274F60", Offset = "0x1273960", VA = "0x181274F60")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public bool IsHeld
			{
				[Cpp2IlInjected.Token(Token = "0x60000BC")]
				[Cpp2IlInjected.Address(RVA = "0x7AFEAC0", Offset = "0x7AFD4C0", VA = "0x187AFEAC0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			public bool WasHeldLastPress
			{
				[Cpp2IlInjected.Token(Token = "0x60000BD")]
				[Cpp2IlInjected.Address(RVA = "0x7AFEAD0", Offset = "0x7AFD4D0", VA = "0x187AFEAD0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x7AFE9B0", Offset = "0x7AFD3B0", VA = "0x187AFE9B0")]
			public void UpdateHold(float holdDuration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x7AFE940", Offset = "0x7AFD340", VA = "0x187AFE940")]
			public void StopHold()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x7AFEA20", Offset = "0x7AFD420", VA = "0x187AFEA20")]
			public NavInputState()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Dictionary<MakerPenHUDNavInputType, NavInputState> navInputStates;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7AFE270", Offset = "0x7AFCC70", VA = "0x187AFE270")]
		public MakerPenHUDNavigationInputState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7AFE110", Offset = "0x7AFCB10", VA = "0x187AFE110")]
		public void Initialize(float minHoldDuration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7AFE200", Offset = "0x7AFCC00", VA = "0x187AFE200")]
		public bool TryGetNavInputState(MakerPenHUDNavInputType inputType, [Out] NavInputState navInputState)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x7AFE190", Offset = "0x7AFCB90", VA = "0x187AFE190")]
		public void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public abstract class BaseBindableObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public string ObjectName
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action<string> OnObjectChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x7AFA7B0", Offset = "0x7AF91B0", VA = "0x187AFA7B0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x7AFA860", Offset = "0x7AF9260", VA = "0x187AFA860", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7AFA790", Offset = "0x7AF9190", VA = "0x187AFA790")]
		protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		protected BaseBindableObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public interface IInterfacesTeamHelper
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		bool RRUIPerfEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		double RRUIPerfSlowFramesSec
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public enum MakerPenHUDNavInputType
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		LeftModifier,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		RightModifier,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		MAX
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public interface IMakerPenHUDBridge
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		MakerPenHUDNavigationInputState NavigationInputState
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool IsUndoAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool IsRedoAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		CNBOOGKDGFE UndoStackEntriesChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool OnCreateMode
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool OnSelectMode
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		string ToolDescription
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		bool IsRRUIPageContainerEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(Slot = "21")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		NBHKBEPCJOC<bool> RRUIPageContainerEnabledChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool OnCloneMode
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		bool OnConfigMode
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(Slot = "24")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		bool InTransformModeAndMoveOn
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		bool InTransformModeAndRotateOn
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		bool InTransformModeAndScaleOn
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		bool IsDeleteAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		bool IsRecolorMode
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		bool ShowColorPicker
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		NBHKBEPCJOC<bool> ColorPickerToggled
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		bool IsAdjustModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(Slot = "34")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		bool IsPrecisionModifierModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(Slot = "35")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		NBHKBEPCJOC<bool> StampModeChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(Slot = "50")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		bool PaletteIsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(Slot = "51")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		bool IsPaletteSearchOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(Slot = "72")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		string CurrentPaletteSearchString
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(Slot = "76")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		CategoriesNestedListConfig Config
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(Slot = "81")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		KACOJFHHODD Configurable
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(Slot = "82")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		CNBOOGKDGFE MakerPenConfigMenuDataChangedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(Slot = "83")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		bool IsCursorActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(Slot = "86")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		NBHKBEPCJOC<bool> CursorActiveChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(Slot = "87")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		bool IsInSubMenu
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(Slot = "89")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		NBHKBEPCJOC<bool> IsInSubMenuChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(Slot = "90")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		bool ShouldUseButtonNavigation
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(Slot = "91")]
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
		event Action<string, OJGNGALFKDN> PaletteSwitchToObjectsCategoryRequested;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action PaletteSwitchToFavoritesCategoryRequested;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action PaletteSwitchToRoomInventionsCategoryRequested;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action<bool> PaletteToggledToOpen;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action<string> SearchStringChanged;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void TriggerUndo();

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void TriggerRedo();

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void GoToCreateMode();

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void GoToSelectMode();

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void RequestAdjustMode();

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void ToggleCloneMode();

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void ToggleMoveMode();

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "16")]
		void ToggleRotateMode();

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "17")]
		void ToggleScaleMode();

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void ToggleConfigMode();

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void DeleteCurrentSelection();

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(Slot = "29")]
		void PressRecolorButton();

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(Slot = "30")]
		void ExitRecolorMode();

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "40")]
		void ChangeColor(Enum shapeColor, int index);

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(Slot = "45")]
		void OnConfigButtonPressed();

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(Slot = "48")]
		void SelectHotbarSlot(int index);

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void RemoveHotbarItem(int index);

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void TogglePalette(bool open);

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void PaletteObjectToggleSelected(int gridIndex);

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(Slot = "62")]
		void PaletteObjectToggleFavorited(int gridIndex);

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "65")]
		void PaletteObjectClickActionButton(int gridIndex);

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "75")]
		void TogglePaletteSearch();

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "79")]
		void SetSearchString(string newSearchString);

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "80")]
		void CategoryFilterChanged(CategoriesFilter filter);

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "84")]
		void PresentTypedDialog(DialogListModel dialogListModel, JFLFHGFOOPA dialogType, GBKFGNKLPHA dialogData);

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "85")]
		IReadOnlyList<JOIHANOOGOK> GetObjectPropertyDynamicUIData(KACOJFHHODD configurable, bool isQuickConfig);

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(Slot = "88")]
		void EndCursor();
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public enum MenuType
	{
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		AppNav,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		Watch
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public interface IMenuManager
	{
		[Cpp2IlInjected.Token(Token = "0x17000040")]
		Guid WatchMenuUnifiedSessionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		NBHKBEPCJOC<Guid> WatchMenuUnifiedSessionIdChangedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		MenuType LastClosedMenuType
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		float LastClosedMenuTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Reset();
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public class InterfacesTeamHelper : IInterfacesTeamHelper
	{
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private static string RRUI_PERF_EXPERIMENT_NAME;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static string RRUI_PERF_ENABLED_PARAMETER_NAME;

		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private static string RRUI_PERF_SLOW_FRAMES_PARAMETER_NAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private NDICJCLBPMH statSigProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private bool? rruiPerfEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private double? slowFramesSec;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool RRUIPerfEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x7AFD8D0", Offset = "0x7AFC2D0", VA = "0x187AFD8D0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public double RRUIPerfSlowFramesSec
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x7AFDA60", Offset = "0x7AFC460", VA = "0x187AFDA60", Slot = "5")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7AFD700", Offset = "0x7AFC100", VA = "0x187AFD700")]
		[CGLGNCLDKHN.CKJOAALDIOP.OPIHCDHBMNP]
		internal static void InitializeOnLoad(MHGNCMHMEKD container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA14510", Offset = "0xA12F10", VA = "0x180A14510")]
		[UnityEngine.Scripting.Preserve]
		internal InterfacesTeamHelper([NotNull][CNHMBDDCGKB(null)] NDICJCLBPMH statSigProvider)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface IOrderedRenderable
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		bool RenderInCarouselOrder
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		bool AllowRender
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		bool HasRefreshed
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		bool RequiresRefresh
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface IRRUIvNextBridge
	{
		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		FOPNIDOJMAH CurrentPlatformType
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		bool InVRDisplayMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		bool InScreensDisplayMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		Guid ScreensMenuUnifiedSessionId
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		bool IsDebugBuild
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		long LocalRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		PFLGPOLCCPC LocalRoomDetails
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		bool CurrentRoomInstanceIsPrivate
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		bool Discovery_ShouldDefaultPublicInstance
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		bool Discovery_ShouldDefaultPrivateInstance
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		int Discovery_NewDataTokenThresholdDays
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		bool Discovery_ShowPublishStateDataToken
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		string Discovery_StoreItemCardVariant
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		int Discovery_LimitedBadgeThresholdDays
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		bool Discovery_LimitedBadgeQolDetails
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		bool Discovery_LimitedBadgeEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		bool WatchMenuProjector_IsWatchOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		bool WatchMenuProject_IsUIOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "19")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		bool WatchMenuProjector_IsMenuAnimationVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		bool ToolMenuProjector_IsMenuOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		bool ToolMenuProjector_IsMenuAnimationVisible
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		int UnreadWatchNotificationCount
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		bool HideWatchNavBar
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(Slot = "24")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		Camera UICamera
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		Camera ScreenModeCamera
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		bool IsUsingTouchInput
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		Action InputMethodChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(Slot = "29")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		CNBOOGKDGFE BrowserModel_RequestAppNavMenu
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(Slot = "52")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "16")]
		Vector2? Discovery_GetHighlightStyleCardOverride(HighlightStyle style);

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "17")]
		string TimeSpanExtensions_GetFormatedTimeString(TimeSpan timeSpan, bool useShortUnits);

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "30")]
		T GetConfigValue<T>(string key);

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "31")]
		void OpenWatchMenu();

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void CloseWatchMenu();

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void CloseActiveToolMenu();

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "34")]
		void NavigateToLink(LinkInfo linkInfo, bool isPortalButton = false);

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void GuaranteeWatchStateAndGoTo(BrowserModel browserModel, Route route);

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void GuaranteeWatchStateAndGoTo(BrowserModel browserModel, Uri uri);

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "37")]
		void OpenLegacyUI(LegacyUIType legacyUIType);

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void NavigateToUriWithRoomSourceData(BrowserModel browserModel, Uri destination, RoomListQueryData queryData, bool useLoadSceneSourceOverride = false, LNNILEGHPHJ sourceOverride = LNNILEGHPHJ.NOT_SET);

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "39")]
		string GetFriendlyListNameFromRoomsConfig(RoomListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "40")]
		string GetSourceStringForQueryData(RoomListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "41")]
		bool PopulateRoomListQueryDataFromSourceInfo(string source, string sourceMetadata, RoomListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "42")]
		HighlightStyle GetHighlightStyleFromDiscoveryTeamHelper(string sourceLabelText, [Optional] string sizePerPlatformFromMetadata);

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Task LogImpressionEvent(KFDINHAAMME.FHDFLJDPDCA impressionEvent);

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "44")]
		bool IsBrowserModelOnRootScreen(BrowserModel browserModel);

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "45")]
		bool TryGetMenuOpenAction([Out] NBHKBEPCJOC<bool> menuOpenAction);

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "46")]
		void TryTrackLatencyForBrowserRoute(string routeString);

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "47")]
		Task<bool> ShowRoomPlayActionDialog(long roomId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(Slot = "48")]
		Task<BBAIIGBMJIM> ShowChooseSubRoomDialog(PFLGPOLCCPC roomDetails, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void ForceAcceptRoomWarnings(MNEFCBHAIEP room);

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "50")]
		Task ShowTwoButtonMessageDialog(DialogListModel dialogListModel, MJBDHLOEHMH dialogData, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "51")]
		void Discovery_HackyTryShowUpdateTheAppDialog(BrowserModel browserModel);

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "53")]
		Task EvictAllFromDorm();

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void ShowRoomReportDialog(long roomId, string sanitizedFriendlyName);

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "55")]
		void ApplyBrowserModelImpressionData(ImpressionTracker impressionTracker, BrowserModel browserModel, string nullBrowserRouteProperty = "appnav/quickaccess");

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "56")]
		Task<RenderTexture> GenerateTextureForLocalAvatarAsync(CancellationToken token, int width = -1, int height = -1);

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "57")]
		void AddNotificationRestriction(object token);

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "58")]
		void RemoveNotificationRestriction(object token);

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void OpenManageRRPlusMembershipPage();

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "60")]
		bool CanLocalPlayerChatWith(PFIBNNBCPAP account);

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "61")]
		void GoToChatPage(int accountId, IPNLAEAJJGP chatTelemetrySource);
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public interface IRRUIvNextConsumableBridge
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public enum ConsumableCategory
		{
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			All,
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			Food,
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			Other
		}

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action<IGJHKHPDBNB, bool> OnActiveConsumableChanged;

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event Action<IGJHKHPDBNB, bool> OnPurchasedConsumableChanged;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "4")]
		List<IGJHKHPDBNB> GetLatestPurchasedNonTransferableConsumables(ConsumableCategory category);

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UseConsumable(IGJHKHPDBNB consumable);

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "6")]
		NJPGBKPAHEG GetConsumableImposterRequest(IGJHKHPDBNB consumable);

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool IsConsumableSpawned(IGJHKHPDBNB consumable);

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		int GetTotalConsumableCount(IGJHKHPDBNB consumable);
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public interface IRRUIvNextRoomCategoryBridge
	{
		[Cpp2IlInjected.Token(Token = "0x17000066")]
		string DefaultGameConfigKey
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		bool ShouldHideShowMeAllRooms
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		bool ShouldHideChipBar
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SelectRoomCategory(EGFEGFNEHOL category, Route route, LNNILEGHPHJ loadSceneSource, BrowserModel browserModel);

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<IReadOnlyList<EGFEGFNEHOL>> GetRoomCategoriesForPageSource(CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<(IReadOnlyList<EGFEGFNEHOL>, string)> GetRoomCategoriesForCuratedList(string sourceMetadata, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IReadOnlyList<EGFEGFNEHOL> GetRoomCategoriesForConfig(string gameConfigKey);
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[ViewModel]
	public class PlayerNametagViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private struct <OnReputationUpdated>d__76 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public PlayerNametagViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public int accountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private TaskAwaiter<HLOABEKHMKG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x7B0D110", Offset = "0x7B0BB10", VA = "0x187B0D110", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private struct <OnAccountUpdated>d__77 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public PlayerNametagViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public int accountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			private TaskAwaiter<LAHJHLANDCD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x7B0CE70", Offset = "0x7B0B870", VA = "0x187B0CE70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private struct <GetPlayerInfo>d__80 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public PlayerNametagViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public IPlayerUIBridge player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private PFLGPOLCCPC <details>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private GLMJIFEMNOK <progression>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			private TaskAwaiter<PFLGPOLCCPC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			private TaskAwaiter<LAHJHLANDCD> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			private TaskAwaiter<GLMJIFEMNOK> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			private TaskAwaiter<bool> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x7B0B1C0", Offset = "0x7B09BC0", VA = "0x187B0B1C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private bool canShowNametag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private string playerDisplayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private string playerCustomEmoji;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private AccountRoleIconType playerRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private AccountBadgeIconType roleBadgeIconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private AccountBadgeIconType cheerBadgeIconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private string playerLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private bool isBroadcasting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private string developerLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private bool inCallWithLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private bool muted;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA2")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private bool blocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA3")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private bool inAPartyWithLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private IPlayerColor playerColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private IPlayerUIBridge playerUIBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private CancellationTokenSource tokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private string accountLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private bool isInfluencer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private IRoomQueryManager roomQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private IAccountQueryManager accountQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private LAHJHLANDCD account;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private DataItem<bool> CanShowNametagDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private DataItem<string> PlayerDisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private DataItem<string> PlayerCustomEmojiDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private DataItem<bool> HasCustomEmojiDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private DataItem<AccountRoleIconType> PlayerRoleTypeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private DataItem<AccountBadgeIconType> RoleBadgeIconTypeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private DataItem<AccountBadgeIconType> CheerBadgeIconTypeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private DataItem<string> PlayerLevelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private DataItem<bool> IsBroadcastingDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private DataItem<bool> ShowDeveloperLabelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private DataItem<string> DeveloperLabelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private DataItem<bool> InCallWithLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private DataItem<bool> MutedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private DataItem<bool> BlockedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private DataItem<bool> InAPartyWithLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private DataItem<IPlayerColor> PlayerColorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private DataItemAction OpenPlayerProfileDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		[BindableData(0, null, DataPermissions.ReadOnly)]
		public bool CanShowNametag
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xA17C20", Offset = "0xA16620", VA = "0x180A17C20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x7B028D0", Offset = "0x7B012D0", VA = "0x187B028D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		[BindableData(1, "Display name of the associated player", DataPermissions.ReadOnly)]
		public string PlayerDisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xA10530", Offset = "0xA0EF30", VA = "0x180A10530")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x7B02C90", Offset = "0x7B01690", VA = "0x187B02C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		[BindableData(2, "Player-set custom emoji", DataPermissions.ReadOnly)]
		public string PlayerCustomEmoji
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA17C00", Offset = "0xA16600", VA = "0x180A17C00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x7B02C20", Offset = "0x7B01620", VA = "0x187B02C20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		[BindableData(3, "Whether a custom emoji is set", DataPermissions.ReadOnly)]
		public bool HasCustomEmoji
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x7B02150", Offset = "0x7B00B50", VA = "0x187B02150")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		[BindableData(5, "The role of this player in the current room", DataPermissions.ReadOnly)]
		public AccountRoleIconType PlayerRoleType
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xE3E930", Offset = "0xE3D330", VA = "0x180E3E930")]
			get
			{
				return default(AccountRoleIconType);
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x7B02D80", Offset = "0x7B01780", VA = "0x187B02D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		[BindableData(6, "The badge the player has selected", DataPermissions.ReadOnly)]
		public AccountBadgeIconType RoleBadgeIconType
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xEEA520", Offset = "0xEE8F20", VA = "0x180EEA520")]
			get
			{
				return default(AccountBadgeIconType);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x7B02DD0", Offset = "0x7B017D0", VA = "0x187B02DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		[BindableData(15, "The active cheer this player has", DataPermissions.ReadOnly)]
		public AccountBadgeIconType CheerBadgeIconType
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xC9F1D0", Offset = "0xC9DBD0", VA = "0x180C9F1D0")]
			get
			{
				return default(AccountBadgeIconType);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x7B02930", Offset = "0x7B01330", VA = "0x187B02930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		[BindableData(7, "Player level (room level if room has progression)", DataPermissions.ReadOnly)]
		public string PlayerLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xA09220", Offset = "0xA07C20", VA = "0x180A09220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x7B02D00", Offset = "0x7B01700", VA = "0x187B02D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		[BindableData(8, "Whether the player is broadcasting", DataPermissions.ReadOnly)]
		public bool IsBroadcasting
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3B0", Offset = "0xA39DB0", VA = "0x180A3B3B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x7B02AF0", Offset = "0x7B014F0", VA = "0x187B02AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		[BindableData(9, "Whether the player is a developer", DataPermissions.ReadOnly)]
		public bool ShowDeveloperLabel
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x7B02170", Offset = "0x7B00B70", VA = "0x187B02170")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		[BindableData(10, "Player level (room level if room has progression)", DataPermissions.ReadOnly)]
		public string DeveloperLabel
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA091A0", Offset = "0xA07BA0", VA = "0x180A091A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x7B02990", Offset = "0x7B01390", VA = "0x187B02990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		[BindableData(11, "Whether this player is in a call with the local player", DataPermissions.ReadOnly)]
		public bool InCallWithLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xD07DA0", Offset = "0xD067A0", VA = "0x180D07DA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x7B02A90", Offset = "0x7B01490", VA = "0x187B02A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		[BindableData(12, "Whether this player is muted by the local player", DataPermissions.ReadOnly)]
		public bool Muted
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xDD81E0", Offset = "0xDD6BE0", VA = "0x180DD81E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x7B02B50", Offset = "0x7B01550", VA = "0x187B02B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		[BindableData(13, "Whether this player has been blocked by local player", DataPermissions.ReadOnly)]
		public bool Blocked
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x7212E60", Offset = "0x7211860", VA = "0x187212E60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x7B02870", Offset = "0x7B01270", VA = "0x187B02870")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		[BindableData(14, "Whether this player is in a party", DataPermissions.ReadOnly)]
		public bool InAPartyWithLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x7AF9440", Offset = "0x7AF7E40", VA = "0x187AF9440")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x7B02A30", Offset = "0x7B01430", VA = "0x187B02A30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		[BindableData(16, "Player color defined by legacy scripts", DataPermissions.ReadOnly)]
		public IPlayerColor PlayerColor
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA0D3B0", Offset = "0xA0BDB0", VA = "0x180A0D3B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x7B02BB0", Offset = "0x7B015B0", VA = "0x187B02BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x7B02830", Offset = "0x7B01230", VA = "0x187B02830", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7B01F70", Offset = "0x7B00970", VA = "0x187B01F70")]
		public void Set(IPlayerUIBridge player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7AFF9A0", Offset = "0x7AFE3A0", VA = "0x187AFF9A0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7B01610", Offset = "0x7B00010", VA = "0x187B01610")]
		private void OnBroadcastingStateChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7B01750", Offset = "0x7B00150", VA = "0x187B01750")]
		private void OnDeveloperDisplayChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7B016B0", Offset = "0x7B000B0", VA = "0x187B016B0")]
		private void OnCallStatusChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B01960", Offset = "0x7B00360", VA = "0x187B01960")]
		private void OnPartyStatusChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x7B018C0", Offset = "0x7B002C0", VA = "0x187B018C0")]
		private void OnNametagVisibilityChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B01D00", Offset = "0x7B00700", VA = "0x187B01D00")]
		private void OnRelationshipChanged(int? playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7B01C00", Offset = "0x7B00600", VA = "0x187B01C00")]
		private void OnProgressionUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x7B01EB0", Offset = "0x7B008B0", VA = "0x187B01EB0")]
		[AsyncStateMachine(typeof(<OnReputationUpdated>d__76))]
		private void OnReputationUpdated(int accountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x7B01550", Offset = "0x7AFFF50", VA = "0x187B01550")]
		[AsyncStateMachine(typeof(<OnAccountUpdated>d__77))]
		private void OnAccountUpdated(int accountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7B02190", Offset = "0x7B00B90", VA = "0x187B02190")]
		private void UpdateRoleBadge()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x7B01B20", Offset = "0x7B00520", VA = "0x187B01B20")]
		private void OnPlayerColorUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7B00760", Offset = "0x7AFF160", VA = "0x187B00760")]
		[AsyncStateMachine(typeof(<GetPlayerInfo>d__80))]
		private void GetPlayerInfo(IPlayerUIBridge player, long roomId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		[BindableAction(100, "Opens the player profile page")]
		private void OpenPlayerProfile()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7B00850", Offset = "0x7AFF250", VA = "0x187B00850")]
		private static AccountRoleIconType GetRoleIconType(IPlayerUIBridge player, IIOJHPILAFO role)
		{
			return default(AccountRoleIconType);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7B00930", Offset = "0x7AFF330", VA = "0x187B00930", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7AFFF50", Offset = "0x7AFE950", VA = "0x187AFFF50")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x7B022C0", Offset = "0x7B00CC0", VA = "0x187B022C0")]
		public PlayerNametagViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum RecRoomPlusOfferType
	{
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		SimpleBenefitList,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		LimitedTimeSignOnItemBonus
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[ViewModel]
	public class RecRoomPlusOfferViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private struct <FetchBenefitData>d__49 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public RecRoomPlusOfferViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			private TaskAwaiter<List<RecRoomPlusBenefitData>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x7B092D0", Offset = "0x7B07CD0", VA = "0x187B092D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private struct <FetchStoreItemOffers>d__50 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public RecRoomPlusOfferViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public WidgetSourceData sourceData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			private CancellationToken <token>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private TaskAwaiter<IReadOnlyList<MMPONPFCPPM>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private TaskAwaiter<BAINOKAGKDK.GNKJLFGEOAK> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private TaskAwaiter<IReadOnlyList<LLJFOPOCGJJ>> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private IEnumerator<LLJFOPOCGJJ> <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private LLJFOPOCGJJ <item>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private JNPHMLACLHJ <giftDrop>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			private TaskAwaiter<bool> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x7B09510", Offset = "0x7B07F10", VA = "0x187B09510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		[SerializeField]
		private RecRoomPlusOfferType offerType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		private int maxLimitedTimeOfferItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[SerializeField]
		private Uri offerItemDetailsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		[SerializeField]
		private ImpressionTracker bannerContentsImpressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private bool subscriptionActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private string offerDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private string offerIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private string offerImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private bool useImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private int offerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private int activeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IRecRoomPlusDataManager rrplusManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IStoreItemQueryManager storeItemListQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private IRRUIvNextStoreItemBridge vNextStoreItemBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private IAccountQueryManager accountQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private IRecRoomPlusDataManager rrPlusDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private List<RecRoomPlusBenefitData> benefitData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private StoreItemListQueryData wishlistQueryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private StoreItemListQueryData configuredQueryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private string widgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private List<int> wishlistItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private string nonWishlistSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private Dictionary<int, LLJFOPOCGJJ> storeItemLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private DataItem<bool> SubscriptionActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private DataItem<string> OfferDescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private DataItem<string> OfferIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private DataItem<string> OfferImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private DataItem<bool> UseImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private DataItem<int> OfferIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private DataItemAction RefreshOfferDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private DataItemAction ViewOfferItemDetailsDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool SubscriptionActive
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xC77AD0", Offset = "0xC764D0", VA = "0x180C77AD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x7B06610", Offset = "0x7B05010", VA = "0x187B06610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string OfferDescription
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xA09220", Offset = "0xA07C20", VA = "0x180A09220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x7B07100", Offset = "0x7B05B00", VA = "0x187B07100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string OfferIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xA6E210", Offset = "0xA6CC10", VA = "0x180A6E210")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x7B07180", Offset = "0x7B05B80", VA = "0x187B07180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public string OfferImage
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA091A0", Offset = "0xA07BA0", VA = "0x180A091A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x7B07200", Offset = "0x7B05C00", VA = "0x187B07200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool UseImage
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xD07DA0", Offset = "0xD067A0", VA = "0x180D07DA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x7B066A0", Offset = "0x7B050A0", VA = "0x187B066A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public int OfferId
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x14CBED0", Offset = "0x14CA8D0", VA = "0x1814CBED0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x7B065B0", Offset = "0x7B04FB0", VA = "0x187B065B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60001E2")]
			[Cpp2IlInjected.Address(RVA = "0x7B070C0", Offset = "0x7B05AC0", VA = "0x187B070C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7B05A70", Offset = "0x7B04470", VA = "0x187B05A70")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7B061E0", Offset = "0x7B04BE0", VA = "0x187B061E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7B059C0", Offset = "0x7B043C0", VA = "0x187B059C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7B06700", Offset = "0x7B05100", VA = "0x187B06700")]
		private void UpdateUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7B04CD0", Offset = "0x7B036D0", VA = "0x187B04CD0")]
		[AsyncStateMachine(typeof(<FetchBenefitData>d__49))]
		private void FetchBenefitData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7B04D80", Offset = "0x7B03780", VA = "0x187B04D80")]
		[AsyncStateMachine(typeof(<FetchStoreItemOffers>d__50))]
		private void FetchStoreItemOffers(WidgetSourceData sourceData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7B05B50", Offset = "0x7B04550", VA = "0x187B05B50")]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7B05BF0", Offset = "0x7B045F0", VA = "0x187B05BF0")]
		[BindableAction(100, null)]
		private void RefreshOffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B05E50", Offset = "0x7B04850", VA = "0x187B05E50")]
		private void RefreshUIContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7B06020", Offset = "0x7B04A20", VA = "0x187B06020")]
		private void SetUpImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7B06AC0", Offset = "0x7B054C0", VA = "0x187B06AC0")]
		[BindableAction(101, null)]
		private void ViewOfferItemDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x7B05290", Offset = "0x7B03C90", VA = "0x187B05290", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x7B04E70", Offset = "0x7B03870", VA = "0x187B04E70")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x7B06D10", Offset = "0x7B05710", VA = "0x187B06D10")]
		public RecRoomPlusOfferViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public enum AccountBadgeIconType
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		Party,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		RRPlus,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		Influencer,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		Developer,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		Cheer_Helpful,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		Cheer_General,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Cheer_Sportsmanship,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		Cheer_GreatHost,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		Cheer_Creative,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		League
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class AccountBadgeIconConfig : IIconConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public AccountBadgeIconType IconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		private AssetReferenceT<Sprite> backgroundFillIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private AssetReferenceT<Sprite> backgroundOutlineIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		[FormerlySerializedAs("BadgeIcon")]
		private AssetReferenceT<Sprite> badgeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		private AssetReferenceT<Sprite> badgeOutlineIcon;

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public AssetReferenceT<Sprite> BackgroundFillIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public AssetReferenceT<Sprite> BackgroundOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public AssetReferenceT<Sprite> BadgeIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public AssetReferenceT<Sprite> BadgeOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public AccountBadgeIconConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CreateAssetMenu(fileName = "AccountBadgeIconData", menuName = "Rec Room/App UI/Account/Account Badge Icon Data")]
	public class AccountBadgeIconData : ScriptableObject, IIconData<AccountBadgeIconType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public List<AccountBadgeIconConfig> Config;

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4850", Offset = "0x7AF3250", VA = "0x187AF4850", Slot = "4")]
		public bool TryGetConfig(AccountBadgeIconType iconType, [Out] IIconConfig config)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xC49D80", Offset = "0xC48780", VA = "0x180C49D80")]
		public AccountBadgeIconData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class AccountBadgeIconView : EnumIconDataViewBase<AccountBadgeIconType, AccountBadgeIconData>
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x7AF49B0", Offset = "0x7AF33B0", VA = "0x187AF49B0")]
		public AccountBadgeIconView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public enum AccountRoleIconType
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		Banned,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Host,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Moderator,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Contributor,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		CoOwner,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		TemporaryCoOwner,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Creator,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		RoomLevel
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class AccountRoleIconConfig : IIconConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public AccountRoleIconType IconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		private AssetReferenceT<Sprite> backgroundFillIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		private AssetReferenceT<Sprite> backgroundOutlineIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		private AssetReferenceT<Sprite> badgeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[SerializeField]
		private AssetReferenceT<Sprite> badgeOutlineIcon;

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public AssetReferenceT<Sprite> BackgroundFillIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public AssetReferenceT<Sprite> BackgroundOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public AssetReferenceT<Sprite> BadgeIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public AssetReferenceT<Sprite> BadgeOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public AccountRoleIconConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CreateAssetMenu(fileName = "AccountRoleIconData", menuName = "RecRoom/App UI/Account Role Icon Data")]
	public class AccountRoleIconData : ScriptableObject, IIconData<AccountRoleIconType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private List<AccountRoleIconConfig> iconConfigList;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x7AF5C30", Offset = "0x7AF4630", VA = "0x187AF5C30", Slot = "4")]
		public bool TryGetConfig(AccountRoleIconType iconType, [Out] IIconConfig config)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xC49D80", Offset = "0xC48780", VA = "0x180C49D80")]
		public AccountRoleIconData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class AccountRoleView : EnumIconDataViewBase<AccountRoleIconType, AccountRoleIconData>
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x7AF5E70", Offset = "0x7AF4870", VA = "0x187AF5E70")]
		public AccountRoleView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[ViewModel]
	public class AccountListViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct <UpdateList>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public AccountListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private TaskAwaiter<List<int>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x7B0D8B0", Offset = "0x7B0C2B0", VA = "0x187B0D8B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[SerializeField]
		private AccountListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[SerializeField]
		private Uri viewAllFriendsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		private Uri viewHereNowUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private DataList<int> _accountList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private bool _isEmpty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private string _displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private string _emptyText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private IAccountQueryManager _accountQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private IRRUIvNextBridge _vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private BrowserModel _browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private bool _isSubscribed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private DataItem<bool> IsEmptyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private DataItem<string> EmptyTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private DataItemList AccountListDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private DataItemAction GoToViewAllPageDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public AccountListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0xA10520", Offset = "0xA0EF20", VA = "0x180A10520")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x7AF5B30", Offset = "0x7AF4530", VA = "0x187AF5B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<int> AccountList
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0xA092C0", Offset = "0xA07CC0", VA = "0x180A092C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x7AF59D0", Offset = "0x7AF43D0", VA = "0x187AF59D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0xC77AD0", Offset = "0xC764D0", VA = "0x180C77AD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x7AF5550", Offset = "0x7AF3F50", VA = "0x187AF5550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		[BindableData(2, "The name of the list that can be shown on the UI, e.g. as a carousel title", DataPermissions.ReadOnly)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0xA09220", Offset = "0xA07C20", VA = "0x180A09220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x7AF5A30", Offset = "0x7AF4430", VA = "0x187AF5A30")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		[BindableData(3, "The text to show if the list is empty", DataPermissions.ReadOnly)]
		public string EmptyText
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0xA6E210", Offset = "0xA6CC10", VA = "0x180A6E210")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x7AF5AB0", Offset = "0x7AF44B0", VA = "0x187AF5AB0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x7AF5990", Offset = "0x7AF4390", VA = "0x187AF5990", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x7AF52E0", Offset = "0x7AF3CE0", VA = "0x187AF52E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x7AF52C0", Offset = "0x7AF3CC0", VA = "0x187AF52C0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7AF5680", Offset = "0x7AF4080", VA = "0x187AF5680")]
		[AsyncStateMachine(typeof(<UpdateList>d__28))]
		private void UpdateList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4CC0", Offset = "0x7AF36C0", VA = "0x187AF4CC0")]
		[BindableAction(100, null)]
		private void GoToViewAllPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7AF5390", Offset = "0x7AF3D90", VA = "0x187AF5390")]
		private bool TrySubscribe()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7AF5470", Offset = "0x7AF3E70", VA = "0x187AF5470")]
		private bool TryUnsubscribe()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7AF4E50", Offset = "0x7AF3850", VA = "0x187AF4E50", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7AF49F0", Offset = "0x7AF33F0", VA = "0x187AF49F0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7AF5730", Offset = "0x7AF4130", VA = "0x187AF5730")]
		public AccountListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[ViewModel]
	public class AccountViewModel : RRUIBaseLocalViewModel, ILoadable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct <FetchAccountData>d__96 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public AccountViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			private CancellationToken <token>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			private CancellationTokenSource <cts>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			private TaskAwaiter<LAHJHLANDCD> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x7B08AA0", Offset = "0x7B074A0", VA = "0x187B08AA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private struct <UpdateAccountProgression>d__97 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public AccountViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			private TaskAwaiter<GLMJIFEMNOK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x7B0D5D0", Offset = "0x7B0BFD0", VA = "0x187B0D5D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028C")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private struct <UpdatePresence>d__99 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public AccountViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			private TaskAwaiter<string> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600028D")]
			[Cpp2IlInjected.Address(RVA = "0x7B0E0B0", Offset = "0x7B0CAB0", VA = "0x187B0E0B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600028E")]
			[Cpp2IlInjected.Address(RVA = "0x7B0E6A0", Offset = "0x7B0D0A0", VA = "0x187B0E6A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		private Uri profilePageUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		private IPNLAEAJJGP chatTelemetrySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[SerializeField]
		private HMGBIGNMOKO partyJoinedSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private int accountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private string profileImageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private string username;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int level;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private float progressInLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private string presence;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private bool _canLocalPlayerGoTo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private bool isFriendOfLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA2")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private bool canSendOrAcceptFriendRequest;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA3")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private bool canLocalPlayerInviteToParty;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private bool isLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA5")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool canLocalPlayerChatWith;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA6")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private bool canInviteToJoinLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA7")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private bool isInSameRoomAsLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private bool isFriendOfLocalPlayerAndIsInSameRoomAsLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private bool isFriendOfLocalPlayerAndIsNotInSameRoomAsLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAA")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private bool isBlocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private OPEDNILAGEF sessionManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private IAccountQueryManager accountQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private IRRUIvNextAccountBridge vNextAccountBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private IRRUIvNextSocialBridge vNextSocialBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private LAHJHLANDCD account;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private DataItem<int> AccountIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private DataItem<string> ProfileImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private DataItem<string> UsernameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private DataItem<int> LevelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private DataItem<float> ProgressInLevelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private DataItem<string> PresenceDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private DataItem<bool> CanLocalPlayerGoToDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private DataItem<bool> IsFriendOfLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private DataItem<bool> CanSendOrAcceptFriendRequestDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private DataItem<bool> CanInviteToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		private DataItem<bool> IsLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private DataItem<bool> CanLocalPlayerChatWithDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		private DataItem<bool> CanInviteToJoinLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		private DataItem<bool> IsInSameRoomAsLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		private DataItem<bool> IsFriendOfLocalPlayerAndIsInSameRoomAsLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		private DataItem<bool> IsFriendOfLocalPlayerAndIsNotInSameRoomAsLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		private DataItem<bool> IsBlockedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		private DataItemAction GoToProfilePageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		private DataItemAction GoToChatPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		private DataItemAction InviteToMyLocationDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private DataItemAction GoToLocationDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private DataItemAction InviteToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private DataItemAction SendFriendRequestDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0xA320F0", Offset = "0xA30AF0", VA = "0x180A320F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x7AF93D0", Offset = "0x7AF7DD0", VA = "0x187AF93D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0xA092C0", Offset = "0xA07CC0", VA = "0x180A092C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x7AF9760", Offset = "0x7AF8160", VA = "0x187AF9760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string ProfileImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0xA09190", Offset = "0xA07B90", VA = "0x180A09190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x7AFA690", Offset = "0x7AF9090", VA = "0x187AFA690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public string Username
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0xA09220", Offset = "0xA07C20", VA = "0x180A09220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x7AFA710", Offset = "0x7AF9110", VA = "0x187AFA710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public int Level
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0xA09270", Offset = "0xA07C70", VA = "0x180A09270")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x7AF97F0", Offset = "0x7AF81F0", VA = "0x187AF97F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public float ProgressInLevel
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x14B3830", Offset = "0x14B2230", VA = "0x1814B3830")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x7AF9220", Offset = "0x7AF7C20", VA = "0x187AF9220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		[BindableData(6, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public string Presence
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0xA091A0", Offset = "0xA07BA0", VA = "0x180A091A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x7AFA610", Offset = "0x7AF9010", VA = "0x187AFA610")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		[BindableData(7, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanLocalPlayerGoTo
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0xD07DA0", Offset = "0xD067A0", VA = "0x180D07DA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x7AF92A0", Offset = "0x7AF7CA0", VA = "0x187AF92A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		[BindableData(8, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsFriendOfLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0xDD81E0", Offset = "0xDD6BE0", VA = "0x180DD81E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x7AF9300", Offset = "0x7AF7D00", VA = "0x187AF9300")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		[BindableData(9, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanSendOrAcceptFriendRequest
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x7212E60", Offset = "0x7211860", VA = "0x187212E60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x7AF9370", Offset = "0x7AF7D70", VA = "0x187AF9370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		[BindableData(10, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanInviteToParty
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x7AF9440", Offset = "0x7AF7E40", VA = "0x187AF9440")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x7AF9450", Offset = "0x7AF7E50", VA = "0x187AF9450")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		[BindableData(11, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xF0E380", Offset = "0xF0CD80", VA = "0x180F0E380")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x7AF94B0", Offset = "0x7AF7EB0", VA = "0x187AF94B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		[BindableData(12, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanLocalPlayerChatWith
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x18B1D20", Offset = "0x18B0720", VA = "0x1818B1D20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x7AF9510", Offset = "0x7AF7F10", VA = "0x187AF9510")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		[BindableData(13, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanInviteToJoinLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xED6F60", Offset = "0xED5960", VA = "0x180ED6F60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x7AF9570", Offset = "0x7AF7F70", VA = "0x187AF9570")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		[BindableData(14, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsInSameRoomAsLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x6C13B30", Offset = "0x6C12530", VA = "0x186C13B30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x7AF95D0", Offset = "0x7AF7FD0", VA = "0x187AF95D0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		[BindableData(15, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsFriendOfLocalPlayerAndIsInSameRoomAsLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xA86DD0", Offset = "0xA857D0", VA = "0x180A86DD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x7AF9640", Offset = "0x7AF8040", VA = "0x187AF9640")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		[BindableData(16, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsFriendOfLocalPlayerAndIsNotInSameRoomAsLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0xA871E0", Offset = "0xA85BE0", VA = "0x180A871E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x7AF96A0", Offset = "0x7AF80A0", VA = "0x187AF96A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		[BindableData(17, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsBlocked
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x1D736C0", Offset = "0x1D720C0", VA = "0x181D736C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x7AF9700", Offset = "0x7AF8100", VA = "0x187AF9700")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x7AFA4D0", Offset = "0x7AF8ED0", VA = "0x187AFA4D0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0xA86DB0", Offset = "0xA857B0", VA = "0x180A86DB0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xA871C0", Offset = "0xA85BC0", VA = "0x180A871C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x7AFA490", Offset = "0x7AF8E90", VA = "0x187AFA490", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<ILoadable> Loaded
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x7AFA3D0", Offset = "0x7AF8DD0", VA = "0x187AFA3D0", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x7AFA550", Offset = "0x7AF8F50", VA = "0x187AFA550", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x7AF5EB0", Offset = "0x7AF48B0", VA = "0x187AF5EB0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8AA0", Offset = "0x7AF74A0", VA = "0x187AF8AA0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8CE0", Offset = "0x7AF76E0", VA = "0x187AF8CE0")]
		private void OnRelationshipUpdated(int? accountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8CD0", Offset = "0x7AF76D0", VA = "0x187AF8CD0")]
		private void OnPlayerPresenceUpdated(int accountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8CC0", Offset = "0x7AF76C0", VA = "0x187AF8CC0")]
		private void OnPartyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x7AF88C0", Offset = "0x7AF72C0", VA = "0x187AF88C0")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6250", Offset = "0x7AF4C50", VA = "0x187AF6250")]
		[AsyncStateMachine(typeof(<FetchAccountData>d__96))]
		private void FetchAccountData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x7AF9850", Offset = "0x7AF8250", VA = "0x187AF9850")]
		[AsyncStateMachine(typeof(<UpdateAccountProgression>d__97))]
		private void UpdateAccountProgression()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x7AF9B40", Offset = "0x7AF8540", VA = "0x187AF9B40")]
		private void UpdateRelationship()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x7AF9A70", Offset = "0x7AF8470", VA = "0x187AF9A70")]
		[AsyncStateMachine(typeof(<UpdatePresence>d__99))]
		private Task UpdatePresence()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x7AF9900", Offset = "0x7AF8300", VA = "0x187AF9900")]
		private void UpdateCanInviteToParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x7AF99A0", Offset = "0x7AF83A0", VA = "0x187AF99A0")]
		private void UpdateIsFriendAndInSameRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7AF8D50", Offset = "0x7AF7750", VA = "0x187AF8D50")]
		private void ResetAccountData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7AF7120", Offset = "0x7AF5B20", VA = "0x187AF7120")]
		[BindableAction(100, null)]
		private void GoToProfilePage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6E20", Offset = "0x7AF5820", VA = "0x187AF6E20")]
		[BindableAction(101, null)]
		private void GoToChatPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x7AF86F0", Offset = "0x7AF70F0", VA = "0x187AF86F0")]
		[BindableAction(102, null)]
		private void InviteToMyLocation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6FD0", Offset = "0x7AF59D0", VA = "0x187AF6FD0")]
		[BindableAction(103, null)]
		private void GoToLocation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7AF87E0", Offset = "0x7AF71E0", VA = "0x187AF87E0")]
		[BindableAction(104, null)]
		private void InviteToParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7AF91C0", Offset = "0x7AF7BC0", VA = "0x187AF91C0")]
		[BindableAction(105, null)]
		private void SendFriendRequest()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7AF7300", Offset = "0x7AF5D00", VA = "0x187AF7300", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6300", Offset = "0x7AF4D00", VA = "0x187AF6300")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7AF9CF0", Offset = "0x7AF86F0", VA = "0x187AF9CF0")]
		public AccountViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[ViewModel]
	public class AppNavButtonViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private struct <FetchLocalAccountInfo>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public AppNavButtonViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			private TaskAwaiter<LAHJHLANDCD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0x7B22CE0", Offset = "0x7B216E0", VA = "0x187B22CE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private string buttonIdentifierOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private DataResolver activeIdentifierResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private DataResolver targetIdentifierResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private bool buttonPanelActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private string buttonIconId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private bool useProfilePictureAsIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private string profilePictureName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private string buttonIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private IAccountQueryManager accountManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private DataItem<bool> ButtonPanelActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private DataItem<string> ButtonIconIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private DataItem<bool> UseProfilePictureAsIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private DataItem<string> ProfilePictureNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private DataItemAction RequestChangePanelDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		[BindableData(0, null, DataPermissions.ReadOnly)]
		public bool ButtonPanelActive
		{
			[Cpp2IlInjected.Token(Token = "0x600028F")]
			[Cpp2IlInjected.Address(RVA = "0xCDD540", Offset = "0xCDBF40", VA = "0x180CDD540")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x7B10D30", Offset = "0x7B0F730", VA = "0x187B10D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		[BindableData(1, null, DataPermissions.ReadOnly)]
		public string ButtonIconId
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0xA09190", Offset = "0xA07B90", VA = "0x180A09190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x7B10CB0", Offset = "0x7B0F6B0", VA = "0x187B10CB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		[BindableData(2, null, DataPermissions.ReadOnly)]
		public bool UseProfilePictureAsIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0xDA28A0", Offset = "0xDA12A0", VA = "0x180DA28A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x7B10E10", Offset = "0x7B0F810", VA = "0x187B10E10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		[BindableData(3, null, DataPermissions.ReadOnly)]
		public string ProfilePictureName
		{
			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0xA6E210", Offset = "0xA6CC10", VA = "0x180A6E210")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x7B10D90", Offset = "0x7B0F790", VA = "0x187B10D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x7B10C30", Offset = "0x7B0F630", VA = "0x187B10C30", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x7B10BF0", Offset = "0x7B0F5F0", VA = "0x187B10BF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7B0F8D0", Offset = "0x7B0E2D0", VA = "0x187B0F8D0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7B10860", Offset = "0x7B0F260", VA = "0x187B10860")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7B10610", Offset = "0x7B0F010", VA = "0x187B10610", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7B10280", Offset = "0x7B0EC80", VA = "0x187B10280")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7B0FA90", Offset = "0x7B0E490", VA = "0x187B0FA90")]
		[AsyncStateMachine(typeof(<FetchLocalAccountInfo>d__28))]
		private void FetchLocalAccountInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7B101C0", Offset = "0x7B0EBC0", VA = "0x187B101C0")]
		private void OnActiveIdentifierUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7B10720", Offset = "0x7B0F120", VA = "0x187B10720")]
		private void OnTargetIdentifierUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7B107E0", Offset = "0x7B0F1E0", VA = "0x187B107E0")]
		[BindableAction(100, null)]
		private void RequestChangePanel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7B0F9E0", Offset = "0x7B0E3E0", VA = "0x187B0F9E0")]
		private void ConfigureImpressions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7B0FE10", Offset = "0x7B0E810", VA = "0x187B0FE10", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7B0FB40", Offset = "0x7B0E540", VA = "0x187B0FB40")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B109C0", Offset = "0x7B0F3C0", VA = "0x187B109C0")]
		public AppNavButtonViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class AppNavMenu : MonoBehaviour, IAppNavMenu
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private sealed class <WaitForOpenMenu>d__80 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001CD")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001CE")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public AppNavMenu <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			private float <watchOpenStart>5__2;

			[Cpp2IlInjected.Token(Token = "0x170000BE")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002D5")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000BF")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002D7")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
			[DebuggerHidden]
			public <WaitForOpenMenu>d__80(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x7B27CD0", Offset = "0x7B266D0", VA = "0x187B27CD0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x7B280E0", Offset = "0x7B26AE0", VA = "0x187B280E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class <WaitForCloseMenu>d__81 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			public AppNavMenu <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000C0")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C1")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
			[DebuggerHidden]
			public <WaitForCloseMenu>d__81(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x7B27B30", Offset = "0x7B26530", VA = "0x187B27B30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x7B27C80", Offset = "0x7B26680", VA = "0x187B27C80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private sealed class <WaitToOpenWatch>d__82 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public AppNavMenu <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000C2")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C3")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002E3")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
			[DebuggerHidden]
			public <WaitToOpenWatch>d__82(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x7B28570", Offset = "0x7B26F70", VA = "0x187B28570", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x7B28600", Offset = "0x7B27000", VA = "0x187B28600", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public const string AppNavLayerName = "interfaces_2025q1_appnav";

		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public const string UseAppNavParameterName = "use_app_nav_forship";

		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		public const string UXFlowLayerName = "interfaces_widgetwatch_ux_flow";

		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		public const string RetainUIStateParameterName = "enable_retain_ui_state";

		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		public const string ShowWatchButtonParameterName = "show_watch_button_in_menus";

		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		public const string PortalButtonsAsTabsParameterName = "portal_buttons_act_like_tabs";

		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public const string RetainUIStateDurationParameterName = "retain_ui_state_duration";

		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public const string AlwaysPresentPortalParameterName = "portal_always_present";

		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public static readonly CNBOOGKDGFE InitializedEvent;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private static AppNavMenu instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[SerializeField]
		private Canvas menuCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[SerializeField]
		private HydrateBase appNavHydration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[SerializeField]
		private AppNavViewModel appNavViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[SerializeField]
		private AppNavPanelSwitcher panelSwitcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[SerializeField]
		private CanvasScreenSizeRefitter canvasScreenSizeRefitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private PlatformDependentCanvasSizeConfig canvasSizeConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private LongPressInteractable backgroundInteractable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		private float forceWatchCloseDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private Coroutine transitionCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private NDICJCLBPMH statsig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private Transform originalParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private bool isGoingBack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private LGNNFODMHBB<object> disableAppNavTokens;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		public CNBOOGKDGFE BeforeAppNavOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		public CNBOOGKDGFE AfterAppNavOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		public CNBOOGKDGFE AfterAppNavClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		public CNBOOGKDGFE OnShouldUseAppNavChanged;

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public static bool ShouldRetainUIState
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x7B12890", Offset = "0x7B11290", VA = "0x187B12890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public static bool PortalButtonsActAsTabs
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x7B12380", Offset = "0x7B10D80", VA = "0x187B12380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public static float RetainUIStateDuration
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x7B12510", Offset = "0x7B10F10", VA = "0x187B12510")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public static bool ShouldShowWatchButtonInMenus
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x7B12AC0", Offset = "0x7B114C0", VA = "0x187B12AC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		private static bool showWatchButtonInMenus
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x7B12E80", Offset = "0x7B11880", VA = "0x187B12E80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public static bool ShouldRetainUIStateAndResetAfterDuration
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x7B12820", Offset = "0x7B11220", VA = "0x187B12820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public static bool UseAlwaysPresentPortalPanel
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0x7B12CF0", Offset = "0x7B116F0", VA = "0x187B12CF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public static AppNavMenu Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x7B12330", Offset = "0x7B10D30", VA = "0x187B12330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public bool ShouldUseAppNav
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x7B12CA0", Offset = "0x7B116A0", VA = "0x187B12CA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool CanOpenAppNavWhenWatchIsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0xDA28A0", Offset = "0xDA12A0", VA = "0x180DA28A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0xFAEAB0", Offset = "0xFAD4B0", VA = "0x180FAEAB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool IsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0xDA28B0", Offset = "0xDA12B0", VA = "0x180DA28B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0xDA0B30", Offset = "0xD9F530", VA = "0x180DA0B30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public bool IsTransitionActive
		{
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x27677A0", Offset = "0x27661A0", VA = "0x1827677A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x1641C30", Offset = "0x1640630", VA = "0x181641C30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public bool ShouldOpenLastActivePanel
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0x1645230", Offset = "0x1643C30", VA = "0x181645230")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x16411F0", Offset = "0x163FBF0", VA = "0x1816411F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public bool IsToolMenuOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0x1645240", Offset = "0x1643C40", VA = "0x181645240")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x16411E0", Offset = "0x163FBE0", VA = "0x1816411E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public bool WasOpenOnNavigation
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xA6E220", Offset = "0xA6CC20", VA = "0x180A6E220")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xA6B530", Offset = "0xA69F30", VA = "0x180A6B530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7B10FD0", Offset = "0x7B0F9D0", VA = "0x187B10FD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7B11A70", Offset = "0x7B10470", VA = "0x187B11A70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x7B11810", Offset = "0x7B10210", VA = "0x187B11810")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x7B10E70", Offset = "0x7B0F870", VA = "0x187B10E70")]
		public void AddAppNavRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7B11C20", Offset = "0x7B10620", VA = "0x187B11C20")]
		public void RemoveAppNavRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x7B11AB0", Offset = "0x7B104B0", VA = "0x187B11AB0")]
		public void OpenMenuWithPreviousPanel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7B11AC0", Offset = "0x7B104C0", VA = "0x187B11AC0", Slot = "5")]
		public void OpenMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7B11740", Offset = "0x7B10140", VA = "0x187B11740", Slot = "6")]
		public void CloseMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x7B11B90", Offset = "0x7B10590", VA = "0x187B11B90", Slot = "7")]
		public void OpenWatch()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7B11B70", Offset = "0x7B10570", VA = "0x187B11B70")]
		public void OpenPage(string pageIdentifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7B11FF0", Offset = "0x7B109F0", VA = "0x187B11FF0")]
		[IteratorStateMachine(typeof(<WaitForOpenMenu>d__80))]
		private IEnumerator WaitForOpenMenu()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7B11F70", Offset = "0x7B10970", VA = "0x187B11F70")]
		[IteratorStateMachine(typeof(<WaitForCloseMenu>d__81))]
		private IEnumerator WaitForCloseMenu()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7B12070", Offset = "0x7B10A70", VA = "0x187B12070")]
		[IteratorStateMachine(typeof(<WaitToOpenWatch>d__82))]
		private IEnumerator WaitToOpenWatch()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7B11ED0", Offset = "0x7B108D0", VA = "0x187B11ED0")]
		private void SetMenuClosedState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7B11D80", Offset = "0x7B10780", VA = "0x187B11D80")]
		private void SetCanvasSize(Vector2 size)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7B121A0", Offset = "0x7B10BA0", VA = "0x187B121A0")]
		public AppNavMenu()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class AppNavPanel : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private sealed class <RegisterAfterOneFrame>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			public AppNavPanel <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000C6")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002EE")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000C7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60002F0")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
			[DebuggerHidden]
			public <RegisterAfterOneFrame>d__10(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x7B262D0", Offset = "0x7B24CD0", VA = "0x187B262D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x7B26390", Offset = "0x7B24D90", VA = "0x187B26390", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		[SerializeField]
		private string panelIdentifierOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		[SerializeField]
		private HydrateBase hydration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private AppNavPanelSwitcher panelSwitcher;

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		public string Identifier
		{
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0xA14650", Offset = "0xA13050", VA = "0x180A14650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		public HydrateBase Hydration
		{
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7B13CF0", Offset = "0x7B126F0", VA = "0x187B13CF0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7B13AA0", Offset = "0x7B124A0", VA = "0x187B13AA0")]
		[IteratorStateMachine(typeof(<RegisterAfterOneFrame>d__10))]
		private IEnumerator RegisterAfterOneFrame()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7B13B20", Offset = "0x7B12520", VA = "0x187B13B20")]
		public void SetIdentifier(string identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7B13DE0", Offset = "0x7B127E0", VA = "0x187B13DE0")]
		public AppNavPanel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class AppNavPanelSwitcher : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private sealed class <SwapPanels>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001EC")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001ED")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001EE")]
			public AppNavPanelSwitcher <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public string targetIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			private bool <startedSwapWithValidCurrentPanel>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			private AppNavPanel <targetPanel>5__3;

			[Cpp2IlInjected.Token(Token = "0x170000C9")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000302")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CA")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000304")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
			[DebuggerHidden]
			public <SwapPanels>d__24(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x7B263E0", Offset = "0x7B24DE0", VA = "0x187B263E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x7B26970", Offset = "0x7B25370", VA = "0x187B26970", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private sealed class <WaitThenClose>d__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001F4")]
			public AppNavPanelSwitcher <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000CB")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CC")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
			[DebuggerHidden]
			public <WaitThenClose>d__25(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x7B28130", Offset = "0x7B26B30", VA = "0x187B28130", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x7B283C0", Offset = "0x7B26DC0", VA = "0x187B283C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private sealed class <OpenTopLevelOnly>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001F7")]
			public AppNavPanelSwitcher <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000CD")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000CE")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
			[DebuggerHidden]
			public <OpenTopLevelOnly>d__26(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x7B26180", Offset = "0x7B24B80", VA = "0x187B26180", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x7B26280", Offset = "0x7B24C80", VA = "0x187B26280", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		[CompilerGenerated]
		private sealed class <CloseTopLevelOnly>d__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001F8")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public AppNavPanelSwitcher <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170000CF")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000D0")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000316")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
			[DebuggerHidden]
			public <CloseTopLevelOnly>d__27(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x7B226C0", Offset = "0x7B210C0", VA = "0x187B226C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x7B227D0", Offset = "0x7B211D0", VA = "0x187B227D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[SerializeField]
		private float initialWaitBeforeCloseTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[SerializeField]
		private float initialOpenHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		[SerializeField]
		private CanvasScreenSizeRefitter screenSizeRefitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[SerializeField]
		private HydrateBase topLevelHydration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[SerializeField]
		private float topLevelHydrationDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[SerializeField]
		private DataResolver currentPanelResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[SerializeField]
		private DataResolver targetPanelResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private Dictionary<string, AppNavPanel> panelLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private string currentPanelIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private AppNavPanel currentPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private Coroutine panelSwitchCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private Coroutine initialOpenCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private Vector3 cachedInitialPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public CNBOOGKDGFE AllPanelsClosed;

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		public bool SwitchingPanels
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x6B755F0", Offset = "0x6B73FF0", VA = "0x186B755F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7B13010", Offset = "0x7B11A10", VA = "0x187B13010")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7B13710", Offset = "0x7B12110", VA = "0x187B13710")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x1780F50", Offset = "0x177F950", VA = "0x181780F50")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x7B13170", Offset = "0x7B11B70", VA = "0x187B13170")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x7B13310", Offset = "0x7B11D10", VA = "0x187B13310")]
		public void RegisterPanel(AppNavPanel panel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x7B13830", Offset = "0x7B12230", VA = "0x187B13830")]
		public void UnregisterPanel(AppNavPanel panel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x7B13220", Offset = "0x7B11C20", VA = "0x187B13220")]
		private void OnTargetPanelUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7B13400", Offset = "0x7B11E00", VA = "0x187B13400")]
		private void RequestTargetPanel(string identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B137A0", Offset = "0x7B121A0", VA = "0x187B137A0")]
		[IteratorStateMachine(typeof(<SwapPanels>d__24))]
		private IEnumerator SwapPanels(string targetIdentifier)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x7B138D0", Offset = "0x7B122D0", VA = "0x187B138D0")]
		[IteratorStateMachine(typeof(<WaitThenClose>d__25))]
		private IEnumerator WaitThenClose()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x7B13290", Offset = "0x7B11C90", VA = "0x187B13290")]
		[IteratorStateMachine(typeof(<OpenTopLevelOnly>d__26))]
		private IEnumerator OpenTopLevelOnly()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x7B130F0", Offset = "0x7B11AF0", VA = "0x187B130F0")]
		[IteratorStateMachine(typeof(<CloseTopLevelOnly>d__27))]
		private IEnumerator CloseTopLevelOnly()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x7B13950", Offset = "0x7B12350", VA = "0x187B13950")]
		public AppNavPanelSwitcher()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class AppNavTutorial : TutorialHighlightTargeter
	{
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public const string ShowAppNavTutorialParameterName = "enable_app_nav_tutorial";

		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private const string tutorialCompletionKey = "AppNavTutorialCompleted";

		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		private const string tutorialSoftExitKey = "AppNavTutorialSoftExit";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private UITutorialData tutorialDataRecord;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private AppNavMenu appNavMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private string idOfOpenAppNavStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private string idOfWidgetStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private string idOfPortalStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private int allowedSoftExits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private Tutorial tutorial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private IEANCGLMOMK preferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private NDICJCLBPMH statsig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private bool canShowTutorial;

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public static AppNavTutorial Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x7B151E0", Offset = "0x7B13BE0", VA = "0x187B151E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x7B15220", Offset = "0x7B13C20", VA = "0x187B15220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x7B13E50", Offset = "0x7B12850", VA = "0x187B13E50", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x7B14DE0", Offset = "0x7B137E0", VA = "0x187B14DE0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x7B14880", Offset = "0x7B13280", VA = "0x187B14880")]
		public void StartTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x7B14E20", Offset = "0x7B13820", VA = "0x187B14E20")]
		public void StopTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x7B143C0", Offset = "0x7B12DC0", VA = "0x187B143C0")]
		private void OnCanUseAppNavChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x7B14510", Offset = "0x7B12F10", VA = "0x187B14510")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x7B14500", Offset = "0x7B12F00", VA = "0x187B14500")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x7B14430", Offset = "0x7B12E30", VA = "0x187B14430", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x7B14340", Offset = "0x7B12D40", VA = "0x187B14340")]
		private void OnAppNavOpened()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x7B142D0", Offset = "0x7B12CD0", VA = "0x187B142D0")]
		private void OnAppNavClosed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x7B14520", Offset = "0x7B12F20", VA = "0x187B14520")]
		private void OnStepChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x7B140A0", Offset = "0x7B12AA0", VA = "0x187B140A0")]
		private void ClearTutorialEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x7B14830", Offset = "0x7B13230", VA = "0x187B14830")]
		private void OnTutorialStarted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x7B14710", Offset = "0x7B13110", VA = "0x187B14710")]
		private void OnTutorialExited()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x7B15130", Offset = "0x7B13B30", VA = "0x187B15130")]
		public AppNavTutorial()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[ViewModel]
	public class AppNavViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		[CompilerGenerated]
		private struct <FetchPanelIds>d__48 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000226")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000227")]
			public AppNavViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000228")]
			private CancellationToken <token>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000229")]
			private TaskAwaiter<List<string>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400022A")]
			private string <newDefault>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400022B")]
			private List<string>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400022C")]
			private string <panelId>5__5;

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x7B22F40", Offset = "0x7B21940", VA = "0x187B22F40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x7B236C0", Offset = "0x7B220C0", VA = "0x187B236C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private const string UnifiedUISessionIdKey = "unified_ui_session_id";

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private float reopenToLastPanelThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private string activePanelIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private string nextPanelIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private DataList<string> widgetPanelIdentifiers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private float availableHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private Guid sessionGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private bool portalPanelAlwaysPresent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private bool portalPanelAlwaysPresentForTouch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private bool portalPanelAlwaysPresentForScreens;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private IECMHFBIMFA analyticsHelper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private IMenuManager menuManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private string defaultPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private float lastCloseTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private DataItem<string> ActivePanelIdentifierDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private DataItem<string> NextPanelIdentifierDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private DataItem<float> AvailableHeightDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private DataItem<Guid> SessionGuidDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private DataItem<bool> PortalPanelAlwaysPresentDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private DataItem<bool> PortalPanelAlwaysPresentForTouchDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		private DataItem<bool> PortalPanelAlwaysPresentForScreensDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		private DataItemList WidgetPanelIdentifiersDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		private DataItemAction CloseDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string ActivePanelIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0xA10530", Offset = "0xA0EF30", VA = "0x180A10530")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x7B16FB0", Offset = "0x7B159B0", VA = "0x187B16FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string NextPanelIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0xA17C00", Offset = "0xA16600", VA = "0x180A17C00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x7B17060", Offset = "0x7B15A60", VA = "0x187B17060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public DataList<string> WidgetPanelIdentifiers
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0xA092C0", Offset = "0xA07CC0", VA = "0x180A092C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x7B17660", Offset = "0x7B16060", VA = "0x187B17660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public float AvailableHeight
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x17D6ED0", Offset = "0x17D58D0", VA = "0x1817D6ED0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x7B170D0", Offset = "0x7B15AD0", VA = "0x187B170D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public Guid SessionGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x7B17140", Offset = "0x7B15B40", VA = "0x187B17140")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x7B17150", Offset = "0x7B15B50", VA = "0x187B17150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public bool PortalPanelAlwaysPresent
		{
			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x1D55E10", Offset = "0x1D54810", VA = "0x181D55E10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x7B171D0", Offset = "0x7B15BD0", VA = "0x187B171D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool PortalPanelAlwaysPresentForTouch
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x7A14730", Offset = "0x7A13130", VA = "0x187A14730")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x7B16E20", Offset = "0x7B15820", VA = "0x187B16E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		[BindableData(7, null, DataPermissions.ReadWrite)]
		public bool PortalPanelAlwaysPresentForScreens
		{
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x1D784C0", Offset = "0x1D76EC0", VA = "0x181D784C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x7B16E80", Offset = "0x7B15880", VA = "0x187B16E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public string PreviousPanelIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0xA86FD0", Offset = "0xA859D0", VA = "0x180A86FD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0xA86DE0", Offset = "0xA857E0", VA = "0x180A86DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x7B17620", Offset = "0x7B16020", VA = "0x187B17620", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x7B15270", Offset = "0x7B13C70", VA = "0x187B15270", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x7B16780", Offset = "0x7B15180", VA = "0x187B16780")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x7B167D0", Offset = "0x7B151D0", VA = "0x187B167D0")]
		public void Open(string panelIdentifier = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x7B15710", Offset = "0x7B14110", VA = "0x187B15710")]
		[BindableAction(100, null)]
		public void Close()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x7B15980", Offset = "0x7B14380", VA = "0x187B15980")]
		[AsyncStateMachine(typeof(<FetchPanelIds>d__48))]
		private Task FetchPanelIds()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x7B16C50", Offset = "0x7B15650", VA = "0x187B16C50")]
		private void SetAlwaysPortalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x7B15EF0", Offset = "0x7B148F0", VA = "0x187B15EF0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x7B15A60", Offset = "0x7B14460", VA = "0x187B15A60")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x7B17230", Offset = "0x7B15C30", VA = "0x187B17230")]
		public AppNavViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[ViewModel]
	public class DevToolsViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		[SerializeField]
		private Uri debugToolsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		[SerializeField]
		private Uri testCaseManagementUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		[SerializeField]
		private Uri bugReportingUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		[SerializeField]
		private Uri componentLibraryUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private bool canAccessDevTools;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private bool developerToolsActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		private bool shouldShowDebugTools;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		private DataItem<bool> CanAccessDevToolsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		private DataItem<bool> DeveloperToolsActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		private DataItem<bool> ShouldShowDebugToolsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		private DataItemAction OpenDebugToolsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private DataItemAction OpenTestCaseManagementDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		private DataItemAction OpenBugReportingDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		private DataItemAction OpenComponentLibraryDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool CanAccessDevTools
		{
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xC77AD0", Offset = "0xC764D0", VA = "0x180C77AD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x7B18450", Offset = "0x7B16E50", VA = "0x187B18450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool DeveloperToolsActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xEACA30", Offset = "0xEAB430", VA = "0x180EACA30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x7B184B0", Offset = "0x7B16EB0", VA = "0x187B184B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public bool ShouldShowDebugTools
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0xEACA40", Offset = "0xEAB440", VA = "0x180EACA40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x7B18510", Offset = "0x7B16F10", VA = "0x187B18510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x7B188C0", Offset = "0x7B172C0", VA = "0x187B188C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x7B176C0", Offset = "0x7B160C0", VA = "0x187B176C0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x7B18270", Offset = "0x7B16C70", VA = "0x187B18270")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x7B18570", Offset = "0x7B16F70", VA = "0x187B18570")]
		private void UpdateBasedOnLocalAccount()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x7B18390", Offset = "0x7B16D90", VA = "0x187B18390")]
		[BindableAction(100, null)]
		private void OpenDebugTools()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x7B183F0", Offset = "0x7B16DF0", VA = "0x187B183F0")]
		[BindableAction(101, null)]
		private void OpenTestCaseManagement()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x7B182D0", Offset = "0x7B16CD0", VA = "0x187B182D0")]
		[BindableAction(102, null)]
		private void OpenBugReporting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x7B18330", Offset = "0x7B16D30", VA = "0x187B18330")]
		[BindableAction(103, null)]
		private void OpenComponentLibrary()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x7B17CF0", Offset = "0x7B166F0", VA = "0x187B17CF0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x7B17940", Offset = "0x7B16340", VA = "0x187B17940")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x7B186D0", Offset = "0x7B170D0", VA = "0x187B186D0")]
		public DevToolsViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public interface IAppNavMenu
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[ViewModel]
	public class PortalButtonViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		[SerializeField]
		private UILinkLookup routeLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private PortalButtonConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private IRRUIvNextStoreItemBridge storeBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private LinkInfo linkInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private string iconName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		private DataItem<string> IconNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private DataItemAction OpenRouteDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x7B1E610", Offset = "0x7B1D010", VA = "0x187B1E610", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xA09220", Offset = "0xA07C20", VA = "0x180A09220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x7B1E690", Offset = "0x7B1D090", VA = "0x187B1E690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string IconName
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xA6E210", Offset = "0xA6CC10", VA = "0x180A6E210")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x7B1E710", Offset = "0x7B1D110", VA = "0x187B1E710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x7B1E5D0", Offset = "0x7B1CFD0", VA = "0x187B1E5D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x7B1E2E0", Offset = "0x7B1CCE0", VA = "0x187B1E2E0")]
		[BindableAction(2, null)]
		public void OpenRoute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7B1D7B0", Offset = "0x7B1C1B0", VA = "0x187B1D7B0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7B1DD10", Offset = "0x7B1C710", VA = "0x187B1DD10")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x7B1DA30", Offset = "0x7B1C430", VA = "0x187B1DA30", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7B1D840", Offset = "0x7B1C240", VA = "0x187B1D840")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7B1E470", Offset = "0x7B1CE70", VA = "0x187B1E470")]
		public PortalButtonViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[ViewModel]
	public class PortalPanelViewModel : RRUIBaseGlobalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private struct <FetchPortalPanelData>d__25 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000259")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400025A")]
			public PortalPanelViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400025B")]
			private TaskAwaiter<PortalPanelConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x7B23720", Offset = "0x7B22120", VA = "0x187B23720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x7B23B30", Offset = "0x7B22530", VA = "0x187B23B30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private struct <WaitThenUpdateBackplate>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			public PortalPanelViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400025F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x7B28410", Offset = "0x7B26E10", VA = "0x187B28410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private CancellationTokenSource cancellationTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		[SerializeField]
		private List<RectTransform> backplateRects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		[SerializeField]
		private Vector2 verticalBackplatePadding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		[SerializeField]
		private RectTransform sectionParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		[SerializeField]
		private RectTransform trayButtonParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private DataList<PortalButtonGroupConfig> sections;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private bool hasWidget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private string widgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private bool portalPanelOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		private DataItem<bool> HasWidgetDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private DataItem<string> WidgetIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private DataItem<bool> PortalPanelOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private DataItemList SectionsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private DataItemAction TogglePanelStateDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<PortalButtonGroupConfig> Sections
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0xA10530", Offset = "0xA0EF30", VA = "0x180A10530")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x7B1FCD0", Offset = "0x7B1E6D0", VA = "0x187B1FCD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool HasWidget
		{
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0xDC95A0", Offset = "0xDC7FA0", VA = "0x180DC95A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x7B1F270", Offset = "0x7B1DC70", VA = "0x187B1F270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string WidgetId
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0xA092C0", Offset = "0xA07CC0", VA = "0x180A092C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x7B1F2D0", Offset = "0x7B1DCD0", VA = "0x187B1F2D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool PortalPanelOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0xC77AD0", Offset = "0xC764D0", VA = "0x180C77AD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x7B1F340", Offset = "0x7B1DD40", VA = "0x187B1F340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x7B1FC90", Offset = "0x7B1E690", VA = "0x187B1FC90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7B1E790", Offset = "0x7B1D190", VA = "0x187B1E790", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7B1F1F0", Offset = "0x7B1DBF0", VA = "0x187B1F1F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x7B1F1C0", Offset = "0x7B1DBC0", VA = "0x187B1F1C0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7B1E940", Offset = "0x7B1D340", VA = "0x187B1E940")]
		[AsyncStateMachine(typeof(<FetchPortalPanelData>d__25))]
		private Task FetchPortalPanelData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7B1F930", Offset = "0x7B1E330", VA = "0x187B1F930")]
		[AsyncStateMachine(typeof(<WaitThenUpdateBackplate>d__26))]
		private void WaitThenUpdateBackplate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7B1F470", Offset = "0x7B1DE70", VA = "0x187B1F470")]
		private void UpdateBackplateRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7B1F200", Offset = "0x7B1DC00", VA = "0x187B1F200")]
		[BindableAction(100, null)]
		private void TogglePanelState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7B1ECE0", Offset = "0x7B1D6E0", VA = "0x187B1ECE0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7B1EA10", Offset = "0x7B1D410", VA = "0x187B1EA10")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x7B1F9E0", Offset = "0x7B1E3E0", VA = "0x187B1F9E0")]
		public PortalPanelViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[ViewModel]
	public class PortalSectionViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private PortalButtonGroupConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private string sectionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		private string iconName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private DataList<PortalButtonConfig> buttons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private DataItem<string> SectionNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private DataItem<string> IconNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private DataItemList ButtonsDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60003A0")]
			[Cpp2IlInjected.Address(RVA = "0x7B208E0", Offset = "0x7B1F2E0", VA = "0x187B208E0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string SectionName
		{
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0xA10530", Offset = "0xA0EF30", VA = "0x180A10530")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x7B20580", Offset = "0x7B1EF80", VA = "0x187B20580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string IconName
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0xA17C00", Offset = "0xA16600", VA = "0x180A17C00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x7B205F0", Offset = "0x7B1EFF0", VA = "0x187B205F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public DataList<PortalButtonConfig> Buttons
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0xA092C0", Offset = "0xA07CC0", VA = "0x180A092C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x7B20960", Offset = "0x7B1F360", VA = "0x187B20960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x7B208A0", Offset = "0x7B1F2A0", VA = "0x187B208A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B20250", Offset = "0x7B1EC50", VA = "0x187B20250")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x7B1FF20", Offset = "0x7B1E920", VA = "0x187B1FF20", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x7B1FD30", Offset = "0x7B1E730", VA = "0x187B1FD30")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x7B20730", Offset = "0x7B1F130", VA = "0x187B20730")]
		public PortalSectionViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[ViewModel]
	public class WidgetPanelViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private struct <FetchWidgetData>d__19 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000275")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000276")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000277")]
			public WidgetPanelViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000278")]
			private int <currentCount>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000279")]
			private TaskAwaiter<List<string>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x7B23B90", Offset = "0x7B22590", VA = "0x187B23B90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x7B242D0", Offset = "0x7B22CD0", VA = "0x187B242D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		[SerializeField]
		private float defaultHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		[SerializeField]
		private int maximumWidgetCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		[SerializeField]
		private WidgetPrefabMapping widgetPrefabMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		[SerializeField]
		private AppNavPanel panel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		[SerializeField]
		private DataResolver availableHeightResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private string panelId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private float maxHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private float currentHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private List<string> tempList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		private DataList<string> widgetIdList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		private DataItemList WidgetIdListDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x7B29320", Offset = "0x7B27D20", VA = "0x187B29320", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<string> WidgetIdList
		{
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0xA6E630", Offset = "0xA6D030", VA = "0x180A6E630")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x7B293A0", Offset = "0x7B27DA0", VA = "0x187B293A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x7B292E0", Offset = "0x7B27CE0", VA = "0x187B292E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7B286A0", Offset = "0x7B270A0", VA = "0x187B286A0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x7B28FA0", Offset = "0x7B279A0", VA = "0x187B28FA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x7B28E00", Offset = "0x7B27800", VA = "0x187B28E00", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7B28970", Offset = "0x7B27370", VA = "0x187B28970")]
		[AsyncStateMachine(typeof(<FetchWidgetData>d__19))]
		public Task FetchWidgetData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x7B28D00", Offset = "0x7B27700", VA = "0x187B28D00")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7B28890", Offset = "0x7B27290", VA = "0x187B28890")]
		private void CheckIfShouldFetchData(string changedPanelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x7B28910", Offset = "0x7B27310", VA = "0x187B28910")]
		private void DoFetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x7B28CA0", Offset = "0x7B276A0", VA = "0x187B28CA0")]
		private void OnAvailableHeightUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x7B28B50", Offset = "0x7B27550", VA = "0x187B28B50", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x7B28A40", Offset = "0x7B27440", VA = "0x187B28A40")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7B29160", Offset = "0x7B27B60", VA = "0x187B29160")]
		public WidgetPanelViewModel()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class WidgetInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public string Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public AssetReference WidgetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public float MaxHeight;

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7B28650", Offset = "0x7B27050", VA = "0x187B28650")]
		public WidgetInfo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CreateAssetMenu(fileName = "WidgetPrefabMapping", menuName = "RecRoom/UI/App Nav/Widget Prefab Mapping")]
	public class WidgetPrefabMapping : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public List<WidgetInfo> widgetPrefabs;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7B29410", Offset = "0x7B27E10", VA = "0x187B29410")]
		public bool TryGetReference(string widgetId, [Out] AssetReference reference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x7B295A0", Offset = "0x7B27FA0", VA = "0x187B295A0")]
		public bool TryGetWidgetHeight(string widgetId, [Out] float height)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0xC49D80", Offset = "0xC48780", VA = "0x180C49D80")]
		public WidgetPrefabMapping()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[ViewModel]
	public class WidgetWrapperViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct <UpdateWidget>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400028D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400028E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400028F")]
			public string widgetId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000290")]
			public WidgetWrapperViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000291")]
			private string <typeId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000292")]
			private AssetReference <reference>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000293")]
			private AsyncOperationHandle<GameObject> <refHandle>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003DC")]
			[Cpp2IlInjected.Address(RVA = "0x7B271E0", Offset = "0x7B25BE0", VA = "0x187B271E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DD")]
			[Cpp2IlInjected.Address(RVA = "0x7B27AD0", Offset = "0x7B264D0", VA = "0x187B27AD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class <MonitorWidgetForSizeChanges>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000295")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000296")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000297")]
			public WidgetWrapperViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000298")]
			private RectTransform <widgetTransform>5__2;

			[Cpp2IlInjected.Token(Token = "0x170000FB")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003E1")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000FC")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003E3")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003DE")]
			[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
			[DebuggerHidden]
			public <MonitorWidgetForSizeChanges>d__23(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003DF")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E0")]
			[Cpp2IlInjected.Address(RVA = "0x7B24330", Offset = "0x7B22D30", VA = "0x187B24330", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x7B24680", Offset = "0x7B23080", VA = "0x187B24680", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public const string WIDGET_ID_PROPERTY = "widget_id";

		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public const string WIDGET_TYPE_PROPERTY = "widget_type_id";

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		[SerializeField]
		private WidgetPrefabMapping prefabMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		[SerializeField]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		[SerializeField]
		private DataResolver sessionIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		[SerializeField]
		private bool forceWidgetToFitWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private string widgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		private AssetReference widgetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private GameObject instantiatedWidget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private ImpressionTracker widgetImpressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private Vector2 cachedWidgetSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private Coroutine widgetSizeCheckCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private DataItem<string> WidgetIdDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string WidgetId
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0xA09190", Offset = "0xA07B90", VA = "0x180A09190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x7B2A0B0", Offset = "0x7B28AB0", VA = "0x187B2A0B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x7B2A030", Offset = "0x7B28A30", VA = "0x187B2A030", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x7B29FF0", Offset = "0x7B289F0", VA = "0x187B29FF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7B29720", Offset = "0x7B28120", VA = "0x187B29720", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7B29CE0", Offset = "0x7B286E0", VA = "0x187B29CE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7B29C90", Offset = "0x7B28690", VA = "0x187B29C90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7B29AD0", Offset = "0x7B284D0", VA = "0x187B29AD0")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x7B29DE0", Offset = "0x7B287E0", VA = "0x187B29DE0")]
		[AsyncStateMachine(typeof(<UpdateWidget>d__22))]
		public Task UpdateWidget(string widgetId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x7B29A50", Offset = "0x7B28450", VA = "0x187B29A50")]
		[IteratorStateMachine(typeof(<MonitorWidgetForSizeChanges>d__23))]
		private IEnumerator MonitorWidgetForSizeChanges()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7B29D80", Offset = "0x7B28780", VA = "0x187B29D80")]
		private void ReleaseWidgetReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x7B29900", Offset = "0x7B28300", VA = "0x187B29900", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x7B297F0", Offset = "0x7B281F0", VA = "0x187B297F0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7B29EF0", Offset = "0x7B288F0", VA = "0x187B29EF0")]
		public WidgetWrapperViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[ViewModel]
	public class AccountsWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct <OnWidgetIdChanged>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002A1")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002A2")]
			public AccountsWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002A3")]
			private TaskAwaiter<AccountListQueryData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x7B24950", Offset = "0x7B23350", VA = "0x187B24950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private IAppNavDataManager _appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private IRRUIvNextAccountBridge _vNextAccountBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		[SerializeField]
		private AccountListViewModel accountListViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private AccountListQueryData _queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private DataItem<AccountListQueryData> QueryDataDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public AccountListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0xA09190", Offset = "0xA07B90", VA = "0x180A09190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x7B0F790", Offset = "0x7B0E190", VA = "0x187B0F790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x7B0F890", Offset = "0x7B0E290", VA = "0x187B0F890", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x7B0F200", Offset = "0x7B0DC00", VA = "0x187B0F200", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7B0F630", Offset = "0x7B0E030", VA = "0x187B0F630", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x7B0F6E0", Offset = "0x7B0E0E0", VA = "0x187B0F6E0")]
		[AsyncStateMachine(typeof(<OnWidgetIdChanged>d__10))]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x7B0F4E0", Offset = "0x7B0DEE0", VA = "0x187B0F4E0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x7B0F3D0", Offset = "0x7B0DDD0", VA = "0x187B0F3D0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x7B0F800", Offset = "0x7B0E200", VA = "0x187B0F800")]
		public AccountsWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[ViewModel]
	public class LocalPlayerWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct <FetchDataAsync>d__40 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002C3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002C4")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002C5")]
			public LocalPlayerWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002C6")]
			private TaskAwaiter<LAHJHLANDCD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0x7B22820", Offset = "0x7B21220", VA = "0x187B22820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private const int INVALID_TOKEN_BALANCE = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		[SerializeField]
		private AccountViewModel accountViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		[SerializeField]
		private bool manuallySetWidgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		[SerializeField]
		private Uri profilePageUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		[SerializeField]
		private LinkInfo profileLinkInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		[SerializeField]
		private Uri notificationsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		[SerializeField]
		private LinkInfo notificationsLinkInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		[SerializeField]
		private Uri settingsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		[SerializeField]
		private LinkInfo settingsLinkInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		[SerializeField]
		private Uri rrPlusSubscriptionUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private string profilePictureName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private string userName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private bool hasUnreadNotifications;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private long tokenBalance;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		private bool hasRecRoomPlus;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private IAccountQueryManager accountManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private IRecRoomPlusDataManager rrPlusDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private int localPlayerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private DataItem<string> ProfilePictureNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private DataItem<string> UserNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private DataItem<bool> HasUnreadNotificationsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		private DataItem<long> TokenBalanceDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		private DataItem<bool> HasRecRoomPlusDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private DataItemAction GoToProfilePageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private DataItemAction GoToNotificationsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private DataItemAction GoToSettingsPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private DataItemAction GoToRRPlusPageDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string ProfilePictureName
		{
			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0xA0D3B0", Offset = "0xA0BDB0", VA = "0x180A0D3B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x7B1A4B0", Offset = "0x7B18EB0", VA = "0x187B1A4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0xA86FF0", Offset = "0xA859F0", VA = "0x180A86FF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x7B1A420", Offset = "0x7B18E20", VA = "0x187B1A420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string UserName
		{
			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0xAB9040", Offset = "0xAB7A40", VA = "0x180AB9040")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x7B1A530", Offset = "0x7B18F30", VA = "0x187B1A530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool HasUnreadNotifications
		{
			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0xF9E1F0", Offset = "0xF9CBF0", VA = "0x180F9E1F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x7B19FC0", Offset = "0x7B189C0", VA = "0x187B19FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public long TokenBalance
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0xA86FD0", Offset = "0xA859D0", VA = "0x180A86FD0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0x7B1A020", Offset = "0x7B18A20", VA = "0x187B1A020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public bool HasRecRoomPlus
		{
			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0xE01A30", Offset = "0xE00430", VA = "0x180E01A30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0x7B19F30", Offset = "0x7B18930", VA = "0x187B19F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000406")]
			[Cpp2IlInjected.Address(RVA = "0x7B1A3E0", Offset = "0x7B18DE0", VA = "0x187B1A3E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x7B18900", Offset = "0x7B17300", VA = "0x187B18900", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x7B19DC0", Offset = "0x7B187C0", VA = "0x187B19DC0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x7B18B50", Offset = "0x7B17550", VA = "0x187B18B50")]
		[AsyncStateMachine(typeof(<FetchDataAsync>d__40))]
		private void FetchDataAsync()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x7B19E70", Offset = "0x7B18870", VA = "0x187B19E70")]
		private void RefreshTokenBalance()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x7B19210", Offset = "0x7B17C10", VA = "0x187B19210")]
		[BindableAction(100, null)]
		private void GoToProfilePage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x7B19100", Offset = "0x7B17B00", VA = "0x187B19100")]
		[BindableAction(101, null)]
		private void GoToNotifications()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x7B19450", Offset = "0x7B17E50", VA = "0x187B19450")]
		[BindableAction(102, null)]
		private void GoToSettingsPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x7B19310", Offset = "0x7B17D10", VA = "0x187B19310")]
		[BindableAction(103, null)]
		private void GoToRRPlusPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x7B19560", Offset = "0x7B17F60", VA = "0x187B19560", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(RVA = "0x7B18C00", Offset = "0x7B17600", VA = "0x187B18C00")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040A")]
		[Cpp2IlInjected.Address(RVA = "0x7B1A080", Offset = "0x7B18A80", VA = "0x187B1A080")]
		public LocalPlayerWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[ViewModel]
	public class MyDormWidgetViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		[SerializeField]
		private Uri thisRoomUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private IRoomLoadManager roomLoadManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private DataItemAction OpenThisRoomPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private DataItemAction GoToRecCenterDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private DataItemAction EvictAllDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0xA10530", Offset = "0xA0EF30", VA = "0x180A10530")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0x7B1B1D0", Offset = "0x7B19BD0", VA = "0x187B1B1D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000421")]
			[Cpp2IlInjected.Address(RVA = "0x7B1B510", Offset = "0x7B19F10", VA = "0x187B1B510", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000422")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x7B1A5B0", Offset = "0x7B18FB0", VA = "0x187B1A5B0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x7B1B240", Offset = "0x7B19C40", VA = "0x187B1B240")]
		private void UpdateUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x7B1B110", Offset = "0x7B19B10", VA = "0x187B1B110")]
		[BindableAction(100, null)]
		private void OpenThisRoomPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x7B1ABC0", Offset = "0x7B195C0", VA = "0x187B1ABC0")]
		[BindableAction(101, null)]
		private void GoToRecCenter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x7B1A850", Offset = "0x7B19250", VA = "0x187B1A850")]
		[BindableAction(102, null)]
		private void EvictAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x7B1B0B0", Offset = "0x7B19AB0", VA = "0x187B1B0B0")]
		private void OnJoinRoomResponse(KLMAGDANNEG result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(RVA = "0x7B1AD70", Offset = "0x7B19770", VA = "0x187B1AD70", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(RVA = "0x7B1A960", Offset = "0x7B19360", VA = "0x187B1A960")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(RVA = "0x7B1B3B0", Offset = "0x7B19DB0", VA = "0x187B1B3B0")]
		public MyDormWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[ViewModel]
	public class PartyWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private struct <OnPartyChanged>d__39 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002ED")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002EE")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002EF")]
			public PartyWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002F0")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000454")]
			[Cpp2IlInjected.Address(RVA = "0x7B246D0", Offset = "0x7B230D0", VA = "0x187B246D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private struct <UpdatePartyData>d__40 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002F1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002F2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002F3")]
			public PartyWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002F4")]
			private TaskAwaiter<List<int>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002F5")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x7B269C0", Offset = "0x7B253C0", VA = "0x187B269C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x7B27180", Offset = "0x7B25B80", VA = "0x187B27180", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		[SerializeField]
		private Uri createPartyUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		[SerializeField]
		private Uri managePartyUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		[SerializeField]
		private Uri openPartyChatUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		[SerializeField]
		private float notInPartyHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		[SerializeField]
		private float inPartyHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private bool inParty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private bool partyChatAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private bool canGoToParty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x83")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private bool canAddToParty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private DataList<int> partyMembers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private int partyMemberCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private bool hasUnreadPartyChatMessages;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private IRRUIvNextSocialBridge socialBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		private bool updatePending;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		private bool updateQueued;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private DataItem<bool> InPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private DataItem<bool> PartyChatAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private DataItem<bool> CanGoToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private DataItem<bool> CanAddToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private DataItem<int> PartyMemberCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private DataItem<bool> HasUnreadPartyChatMessagesDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private DataItemList PartyMembersDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private DataItemAction CreateOrJoinPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private DataItemAction OpenPartyChatDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private DataItemAction GoToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private DataItemAction AddToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private DataItemAction ManagePartyDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool InParty
		{
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0xC77AD0", Offset = "0xC764D0", VA = "0x180C77AD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0x7B1D0A0", Offset = "0x7B1BAA0", VA = "0x187B1D0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool PartyChatAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0xEACA30", Offset = "0xEAB430", VA = "0x180EACA30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0x7B1D100", Offset = "0x7B1BB00", VA = "0x187B1D100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public bool CanGoToParty
		{
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0xEACA40", Offset = "0xEAB440", VA = "0x180EACA40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600042D")]
			[Cpp2IlInjected.Address(RVA = "0x7B1D160", Offset = "0x7B1BB60", VA = "0x187B1D160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010E")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool CanAddToParty
		{
			[Cpp2IlInjected.Token(Token = "0x600042E")]
			[Cpp2IlInjected.Address(RVA = "0x14B4B50", Offset = "0x14B3550", VA = "0x1814B4B50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600042F")]
			[Cpp2IlInjected.Address(RVA = "0x7B1D1C0", Offset = "0x7B1BBC0", VA = "0x187B1D1C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010F")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public DataList<int> PartyMembers
		{
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0xA09220", Offset = "0xA07C20", VA = "0x180A09220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0x7B1D740", Offset = "0x7B1C140", VA = "0x187B1D740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000110")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public int PartyMemberCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000432")]
			[Cpp2IlInjected.Address(RVA = "0xA09270", Offset = "0xA07C70", VA = "0x180A09270")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000433")]
			[Cpp2IlInjected.Address(RVA = "0x7B1D220", Offset = "0x7B1BC20", VA = "0x187B1D220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000111")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool HasUnreadPartyChatMessages
		{
			[Cpp2IlInjected.Token(Token = "0x6000434")]
			[Cpp2IlInjected.Address(RVA = "0x1D55E10", Offset = "0x1D54810", VA = "0x181D55E10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000435")]
			[Cpp2IlInjected.Address(RVA = "0x7B1CF70", Offset = "0x7B1B970", VA = "0x187B1CF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000441")]
			[Cpp2IlInjected.Address(RVA = "0x7B1D700", Offset = "0x7B1C100", VA = "0x187B1D700", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000442")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(RVA = "0x7B1B620", Offset = "0x7B1A020", VA = "0x187B1B620", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(RVA = "0x7B1CAE0", Offset = "0x7B1B4E0", VA = "0x187B1CAE0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x7B1CC40", Offset = "0x7B1B640", VA = "0x187B1CC40")]
		[AsyncStateMachine(typeof(<OnPartyChanged>d__39))]
		private void OnPartyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x7B1D280", Offset = "0x7B1BC80", VA = "0x187B1D280")]
		[AsyncStateMachine(typeof(<UpdatePartyData>d__40))]
		private Task UpdatePartyData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x7B1CE60", Offset = "0x7B1B860", VA = "0x187B1CE60")]
		private void SetHeight()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x7B1CCF0", Offset = "0x7B1B6F0", VA = "0x187B1CCF0")]
		private void OnPartyChatUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043C")]
		[Cpp2IlInjected.Address(RVA = "0x7B1B8D0", Offset = "0x7B1A2D0", VA = "0x187B1B8D0")]
		[BindableAction(100, null)]
		private void CreateOrJoinParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(RVA = "0x7B1CD90", Offset = "0x7B1B790", VA = "0x187B1CD90")]
		[BindableAction(101, null)]
		private void OpenPartyChat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BF80", Offset = "0x7B1A980", VA = "0x187B1BF80")]
		[BindableAction(102, null)]
		private void GoToParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x7B1B550", Offset = "0x7B19F50", VA = "0x187B1B550")]
		[BindableAction(103, null)]
		private void AddToParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x7B1CA10", Offset = "0x7B1B410", VA = "0x187B1CA10")]
		[BindableAction(104, null)]
		private void ManageParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x7B1C040", Offset = "0x7B1AA40", VA = "0x187B1C040", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x7B1B9A0", Offset = "0x7B1A3A0", VA = "0x187B1B9A0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x7B1D350", Offset = "0x7B1BD50", VA = "0x187B1D350")]
		public PartyWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class RoomCarouselWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		[CompilerGenerated]
		private struct <OnWidgetIdChanged>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002FB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002FC")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002FD")]
			public RoomCarouselWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002FE")]
			private string <widgetId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002FF")]
			private WidgetSourceData <widgetSourceData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000300")]
			private TaskAwaiter<IReadOnlyList<MMPONPFCPPM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0x7B25A30", Offset = "0x7B24430", VA = "0x187B25A30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		[SerializeField]
		private RoomListViewModel roomListViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private RoomListQueryData queryData;

		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(RVA = "0x7B209C0", Offset = "0x7B1F3C0", VA = "0x187B209C0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(RVA = "0x7B20B90", Offset = "0x7B1F590", VA = "0x187B20B90", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x7B20C40", Offset = "0x7B1F640", VA = "0x187B20C40")]
		[AsyncStateMachine(typeof(<OnWidgetIdChanged>d__7))]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x7B20CF0", Offset = "0x7B1F6F0", VA = "0x187B20CF0")]
		public RoomCarouselWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[ViewModel]
	public class RoomCategoryCarouselWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private struct <OnWidgetIdChanged>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000306")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000307")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000308")]
			public RoomCategoryCarouselWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			private string <widgetId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			private WidgetSourceData <widgetSourceData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400030B")]
			private TaskAwaiter<IReadOnlyList<MMPONPFCPPM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000466")]
			[Cpp2IlInjected.Address(RVA = "0x7B254C0", Offset = "0x7B23EC0", VA = "0x187B254C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000467")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		[SerializeField]
		private RoomCategoryListViewModel categoryListViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0x7B21140", Offset = "0x7B1FB40", VA = "0x187B21140", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000115")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x7B20D70", Offset = "0x7B1F770", VA = "0x187B20D70", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x7B20FD0", Offset = "0x7B1F9D0", VA = "0x187B20FD0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x7B21080", Offset = "0x7B1FA80", VA = "0x187B21080")]
		[AsyncStateMachine(typeof(<OnWidgetIdChanged>d__6))]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x7B20FC0", Offset = "0x7B1F9C0", VA = "0x187B20FC0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x7B20F40", Offset = "0x7B1F940", VA = "0x187B20F40")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x7B21130", Offset = "0x7B1FB30", VA = "0x187B21130")]
		public RoomCategoryCarouselWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[ViewModel]
	public class StoreItemsWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		[CompilerGenerated]
		private struct <OnWidgetIdChanged>d__21 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400031B")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400031C")]
			public StoreItemsWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400031D")]
			private TaskAwaiter<IReadOnlyList<MMPONPFCPPM>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400031E")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600047C")]
			[Cpp2IlInjected.Address(RVA = "0x7B24CE0", Offset = "0x7B236E0", VA = "0x187B24CE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600047D")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		[CompilerGenerated]
		private struct <TryLoadingFromActiveSourceList>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			public StoreItemsWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000322")]
			private TaskAwaiter<IReadOnlyList<MMPONPFCPPM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600047E")]
			[Cpp2IlInjected.Address(RVA = "0x7B47750", Offset = "0x7B46150", VA = "0x187B47750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600047F")]
			[Cpp2IlInjected.Address(RVA = "0x7B47B70", Offset = "0x7B46570", VA = "0x187B47B70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private struct <OnQueryDataLoaded>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public StoreItemsWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000480")]
			[Cpp2IlInjected.Address(RVA = "0x7B475A0", Offset = "0x7B45FA0", VA = "0x187B475A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000481")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		[SerializeField]
		private int maxItemsInList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		private IRRUIvNextBridge _vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		private IRRUIvNextStoreItemBridge storeBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		private IAppNavDataManager _appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		private BrowserModel _browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private List<WidgetSourceData> sourceList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private int activeSectionIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private WidgetSourceData widgetSourceData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		[SerializeField]
		private StoreItemListViewModel storeItemListViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private StoreItemListQueryData _queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private DataItem<StoreItemListQueryData> QueryDataDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private DataItemAction GoToStorePageDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000116")]
		private MNEFCBHAIEP Room
		{
			[Cpp2IlInjected.Token(Token = "0x6000468")]
			[Cpp2IlInjected.Address(RVA = "0x7B22680", Offset = "0x7B21080", VA = "0x187B22680")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		private bool CanShowRelatedStoreItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000469")]
			[Cpp2IlInjected.Address(RVA = "0x7B22490", Offset = "0x7B20E90", VA = "0x187B22490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000118")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public StoreItemListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x600046A")]
			[Cpp2IlInjected.Address(RVA = "0xA86FF0", Offset = "0xA859F0", VA = "0x180A86FF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600046B")]
			[Cpp2IlInjected.Address(RVA = "0x7B22340", Offset = "0x7B20D40", VA = "0x187B22340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000119")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000475")]
			[Cpp2IlInjected.Address(RVA = "0x7B22640", Offset = "0x7B21040", VA = "0x187B22640", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011A")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000476")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x7B215C0", Offset = "0x7B1FFC0", VA = "0x187B215C0")]
		[BindableAction(100, null)]
		private void GoToStorePage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x7B21180", Offset = "0x7B1FB80", VA = "0x187B21180", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x7B21990", Offset = "0x7B20390", VA = "0x187B21990", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x7B21B60", Offset = "0x7B20560", VA = "0x187B21B60")]
		[AsyncStateMachine(typeof(<OnWidgetIdChanged>d__21))]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x7B21E20", Offset = "0x7B20820", VA = "0x187B21E20")]
		[AsyncStateMachine(typeof(<TryLoadingFromActiveSourceList>d__22))]
		private Task<bool> TryLoadingFromActiveSourceList()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x7B21C10", Offset = "0x7B20610", VA = "0x187B21C10")]
		private bool TryLoadSection(MMPONPFCPPM section)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x7B21D50", Offset = "0x7B20750", VA = "0x187B21D50")]
		private bool TryLoadSource(string source, string sourceMetadata)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x7B21F10", Offset = "0x7B20910", VA = "0x187B21F10")]
		private bool TrySetQueryData(string source, string sourceMetadata)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x7B21AB0", Offset = "0x7B204B0", VA = "0x187B21AB0")]
		[AsyncStateMachine(typeof(<OnQueryDataLoaded>d__26))]
		private void OnQueryDataLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x7B21790", Offset = "0x7B20190", VA = "0x187B21790", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x7B21440", Offset = "0x7B1FE40", VA = "0x187B21440")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x7B223B0", Offset = "0x7B20DB0", VA = "0x187B223B0")]
		public StoreItemsWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[ViewModel]
	public class ThisRoomWidgetViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		[SerializeField]
		private Uri thisRoomUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private bool canReportRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private IRoomLoadManager roomLoadManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private DataItem<bool> CanReportRoomDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private DataItemAction OpenThisRoomPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private DataItemAction GoToDormDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private DataItemAction ReportRoomDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private DataItemAction GoToRecCenterDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700011B")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000482")]
			[Cpp2IlInjected.Address(RVA = "0xA10530", Offset = "0xA0EF30", VA = "0x180A10530")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000483")]
			[Cpp2IlInjected.Address(RVA = "0x7B464B0", Offset = "0x7B44EB0", VA = "0x187B464B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011C")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool CanReportRoom
		{
			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0xDC95A0", Offset = "0xDC7FA0", VA = "0x180DC95A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0x7B46520", Offset = "0x7B44F20", VA = "0x187B46520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011D")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600048D")]
			[Cpp2IlInjected.Address(RVA = "0x7B468C0", Offset = "0x7B452C0", VA = "0x187B468C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700011E")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x7B45460", Offset = "0x7B43E60", VA = "0x187B45460", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x7B46580", Offset = "0x7B44F80", VA = "0x187B46580")]
		private void UpdateUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x7B461D0", Offset = "0x7B44BD0", VA = "0x187B461D0")]
		[BindableAction(100, null)]
		private void OpenThisRoomPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x7B45A20", Offset = "0x7B44420", VA = "0x187B45A20")]
		[BindableAction(101, null)]
		private void GoToDorm()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x7B46290", Offset = "0x7B44C90", VA = "0x187B46290")]
		[BindableAction(102, null)]
		private void ReportRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x7B45AD0", Offset = "0x7B444D0", VA = "0x187B45AD0")]
		[BindableAction(103, null)]
		private void GoToRecCenter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x7B46170", Offset = "0x7B44B70", VA = "0x187B46170")]
		private void OnJoinRoomResponse(KLMAGDANNEG result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048F")]
		[Cpp2IlInjected.Address(RVA = "0x7B45CA0", Offset = "0x7B446A0", VA = "0x187B45CA0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x7B456E0", Offset = "0x7B440E0", VA = "0x187B456E0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x7B466D0", Offset = "0x7B450D0", VA = "0x187B466D0")]
		public ThisRoomWidgetViewModel()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	public class AssetReferenceInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		public string Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		public AssetReference Asset;

		[Cpp2IlInjected.Token(Token = "0x6000496")]
		[Cpp2IlInjected.Address(RVA = "0x7B2A180", Offset = "0x7B28B80", VA = "0x187B2A180")]
		public AssetReferenceInfo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[CreateAssetMenu(fileName = "AssetReferenceLookup", menuName = "RecRoom/UI/Asset Reference Lookup")]
	public class AssetReferenceLookup : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		[SerializeField]
		private List<AssetReferenceInfo> assetReferences;

		[Cpp2IlInjected.Token(Token = "0x6000497")]
		[Cpp2IlInjected.Address(RVA = "0x7B2A1D0", Offset = "0x7B28BD0", VA = "0x187B2A1D0")]
		public bool TryGetAssetReference(string assetId, [Out] AssetReference assetReference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000498")]
		[Cpp2IlInjected.Address(RVA = "0xC49D80", Offset = "0xC48780", VA = "0x180C49D80")]
		public AssetReferenceLookup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[ViewModel]
	public class StoreItemListViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		[CompilerGenerated]
		private struct <FetchData>d__35 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			public StoreItemListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			private TaskAwaiter<IReadOnlyList<LLJFOPOCGJJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004BA")]
			[Cpp2IlInjected.Address(RVA = "0x7B46900", Offset = "0x7B45300", VA = "0x187B46900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BB")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private static readonly List<CGLIDIKFDHJ> ImmediateUnifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		public CNBOOGKDGFE OnDataFetched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		private BrowserModel _browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private IRRUIvNextBridge _vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private IRRUIvNextStoreItemBridge _vNextStoreItemBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		private IStoreItemQueryManager _storeItemListQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private CancellationTokenSource _cancellationTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		private bool _waitingForQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		private int _minItemsCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		[SerializeField]
		private StoreItemListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private DataList<CGLIDIKFDHJ> _storeItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private string _displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private bool _isEmptyOrBelowMinimum;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		private DataItem<StoreItemListQueryData> QueryDataDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private DataItem<bool> IsEmptyOrBelowMinimumDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private DataItemList StoreItemIdsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		private DataItemAction GoToViewMorePageDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700011F")]
		public int MinItemsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000499")]
			[Cpp2IlInjected.Address(RVA = "0x579F5A0", Offset = "0x579DFA0", VA = "0x18579F5A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600049A")]
			[Cpp2IlInjected.Address(RVA = "0x7B425B0", Offset = "0x7B40FB0", VA = "0x187B425B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		[BindableData(0, "The query data used to retrieve the store item list", DataPermissions.ReadOnly)]
		public StoreItemListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0xA091A0", Offset = "0xA07BA0", VA = "0x180A091A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public DataList<CGLIDIKFDHJ> StoreItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0xA6E630", Offset = "0xA6D030", VA = "0x180A6E630")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600049F")]
			[Cpp2IlInjected.Address(RVA = "0x7B425E0", Offset = "0x7B40FE0", VA = "0x187B425E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		[BindableData(2, "The name of the list that can be shown on the UI, e.g. as a carousel title", DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0xA0D3B0", Offset = "0xA0BDB0", VA = "0x180A0D3B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004A1")]
			[Cpp2IlInjected.Address(RVA = "0x7B42530", Offset = "0x7B40F30", VA = "0x187B42530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool IsEmptyOrBelowMinimum
		{
			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0xA6E220", Offset = "0xA6CC20", VA = "0x180A6E220")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0x7B42080", Offset = "0x7B40A80", VA = "0x187B42080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0x7B424F0", Offset = "0x7B40EF0", VA = "0x187B424F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x7B418C0", Offset = "0x7B402C0", VA = "0x187B418C0")]
		public void SetDiscoverySectionId(string sectionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x7B41970", Offset = "0x7B40370", VA = "0x187B41970")]
		public void SetParentTabName(string parentTabName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x7B41020", Offset = "0x7B3FA20", VA = "0x187B41020")]
		[BindableAction(100, null)]
		private void GoToViewMorePage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B40A00", Offset = "0x7B3F400", VA = "0x187B40A00", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x7B42000", Offset = "0x7B40A00", VA = "0x187B42000")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B41820", Offset = "0x7B40220", VA = "0x187B41820", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A8")]
		[Cpp2IlInjected.Address(RVA = "0x7B41B00", Offset = "0x7B40500", VA = "0x187B41B00")]
		public void SetQueryData(StoreItemListQueryData listQueryData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A9")]
		[Cpp2IlInjected.Address(RVA = "0x7B41A20", Offset = "0x7B40420", VA = "0x187B41A20")]
		public void SetPropertiesToDefaults()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(RVA = "0x7B40B00", Offset = "0x7B3F500", VA = "0x187B40B00")]
		[AsyncStateMachine(typeof(<FetchData>d__35))]
		public void FetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AB")]
		[Cpp2IlInjected.Address(RVA = "0x7B40E80", Offset = "0x7B3F880", VA = "0x187B40E80")]
		private string GetDisplayName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004AC")]
		[Cpp2IlInjected.Address(RVA = "0x7B41C30", Offset = "0x7B40630", VA = "0x187B41C30")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004AF")]
		[Cpp2IlInjected.Address(RVA = "0x7B41350", Offset = "0x7B3FD50", VA = "0x187B41350", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B0")]
		[Cpp2IlInjected.Address(RVA = "0x7B40BB0", Offset = "0x7B3F5B0", VA = "0x187B40BB0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x7B42240", Offset = "0x7B40C40", VA = "0x187B42240")]
		public StoreItemListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[ViewModel]
	public class StoreItemViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private struct <FetchStoreItemData>d__54 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			public StoreItemViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			private TaskAwaiter<LLJFOPOCGJJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004EE")]
			[Cpp2IlInjected.Address(RVA = "0x7B471F0", Offset = "0x7B45BF0", VA = "0x187B471F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004EF")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private static COJJKFBGGKB Log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		private BrowserModel _browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		private IRRUIvNextBridge _vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private IRRUIvNextStoreItemBridge _vNextStoreItemBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private Uri itemDetailsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		private string _thumbnailImageFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private string costText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		private bool isOnSale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private string saleText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private bool isLimitedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private string limitedTimeText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private bool isOwned;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private bool isRecRoomPlusExclusive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private CGLIDIKFDHJ storeItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private long price;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private DataItem<string> ThumbnailImageFilenameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private DataItem<string> CostTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private DataItem<bool> IsOnSaleDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		private DataItem<string> SaleTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		private DataItem<bool> IsLimitedTimeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		private DataItem<string> LimitedTimeTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		private DataItem<bool> IsOwnedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private DataItem<bool> IsRecRoomPlusExclusiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private DataItem<CGLIDIKFDHJ> StoreItemIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		private DataItem<long> PriceDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		private DataItemAction GoToDetailsPageDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60004BC")]
			[Cpp2IlInjected.Address(RVA = "0x7B44EB0", Offset = "0x7B438B0", VA = "0x187B44EB0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string ThumbnailImageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x60004BD")]
			[Cpp2IlInjected.Address(RVA = "0xA09190", Offset = "0xA07B90", VA = "0x180A09190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0x7B453E0", Offset = "0x7B43DE0", VA = "0x187B453E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		[BindableData(1, "The sanitized, friendly name of the store item", DataPermissions.ReadOnly)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0xA09220", Offset = "0xA07C20", VA = "0x180A09220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0x7B44FB0", Offset = "0x7B439B0", VA = "0x187B44FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		[BindableData(2, "The price of the item (including strikethrough for discounts or 'Owned' if owned)", DataPermissions.ReadOnly)]
		public string CostText
		{
			[Cpp2IlInjected.Token(Token = "0x60004C1")]
			[Cpp2IlInjected.Address(RVA = "0xA6E210", Offset = "0xA6CC10", VA = "0x180A6E210")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C2")]
			[Cpp2IlInjected.Address(RVA = "0x7B44F30", Offset = "0x7B43930", VA = "0x187B44F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		[BindableData(3, "Whether or not the item is currently on sale (has a discount)", DataPermissions.ReadOnly)]
		public bool IsOnSale
		{
			[Cpp2IlInjected.Token(Token = "0x60004C3")]
			[Cpp2IlInjected.Address(RVA = "0xED7630", Offset = "0xED6030", VA = "0x180ED7630")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004C4")]
			[Cpp2IlInjected.Address(RVA = "0x7B45090", Offset = "0x7B43A90", VA = "0x187B45090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		[BindableData(4, "Text to show on the sale banner", DataPermissions.ReadOnly)]
		public string SaleText
		{
			[Cpp2IlInjected.Token(Token = "0x60004C5")]
			[Cpp2IlInjected.Address(RVA = "0xA6E630", Offset = "0xA6D030", VA = "0x180A6E630")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004C6")]
			[Cpp2IlInjected.Address(RVA = "0x7B45230", Offset = "0x7B43C30", VA = "0x187B45230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		[BindableData(5, "Whether or not to show the 'Limited Time' banner", DataPermissions.ReadOnly)]
		public bool IsLimitedTime
		{
			[Cpp2IlInjected.Token(Token = "0x60004C7")]
			[Cpp2IlInjected.Address(RVA = "0xA86DD0", Offset = "0xA857D0", VA = "0x180A86DD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004C8")]
			[Cpp2IlInjected.Address(RVA = "0x7B45030", Offset = "0x7B43A30", VA = "0x187B45030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		[BindableData(6, "Text to show on the 'Limited Time' banner", DataPermissions.ReadOnly)]
		public string LimitedTimeText
		{
			[Cpp2IlInjected.Token(Token = "0x60004C9")]
			[Cpp2IlInjected.Address(RVA = "0xA86FF0", Offset = "0xA859F0", VA = "0x180A86FF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004CA")]
			[Cpp2IlInjected.Address(RVA = "0x7B451B0", Offset = "0x7B43BB0", VA = "0x187B451B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		[BindableData(7, "Whether or not the player owns this item", DataPermissions.ReadOnly)]
		public bool IsOwned
		{
			[Cpp2IlInjected.Token(Token = "0x60004CB")]
			[Cpp2IlInjected.Address(RVA = "0xCFF770", Offset = "0xCFE170", VA = "0x180CFF770")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004CC")]
			[Cpp2IlInjected.Address(RVA = "0x7B450F0", Offset = "0x7B43AF0", VA = "0x187B450F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		[BindableData(8, "Whether or not to show the 'Rec Room Plus Exclusive' icon", DataPermissions.ReadOnly)]
		public bool IsRecRoomPlusExclusive
		{
			[Cpp2IlInjected.Token(Token = "0x60004CD")]
			[Cpp2IlInjected.Address(RVA = "0xA6F460", Offset = "0xA6DE60", VA = "0x180A6F460")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004CE")]
			[Cpp2IlInjected.Address(RVA = "0x7B45150", Offset = "0x7B43B50", VA = "0x187B45150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		[BindableData(9, "The ID used to retrieve the IStoreItem from RecNet", DataPermissions.ReadWrite)]
		public CGLIDIKFDHJ StoreItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60004CF")]
			[Cpp2IlInjected.Address(RVA = "0x7B43E60", Offset = "0x7B42860", VA = "0x187B43E60")]
			get
			{
				return default(CGLIDIKFDHJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x7B452B0", Offset = "0x7B43CB0", VA = "0x187B452B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		[BindableData(10, "The price of the item after any applicable discounts", DataPermissions.ReadWrite)]
		public long Price
		{
			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0xA0D440", Offset = "0xA0BE40", VA = "0x180A0D440")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0x7B43EB0", Offset = "0x7B428B0", VA = "0x187B43EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0x7B44E70", Offset = "0x7B43870", VA = "0x187B44E70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60004DB")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D3")]
		[Cpp2IlInjected.Address(RVA = "0x7B42DB0", Offset = "0x7B417B0", VA = "0x187B42DB0")]
		[BindableAction(100, null)]
		private void GoToDetailsPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x7B42650", Offset = "0x7B41050", VA = "0x187B42650", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x7B43900", Offset = "0x7B42300", VA = "0x187B43900")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x7B42720", Offset = "0x7B41120", VA = "0x187B42720")]
		[AsyncStateMachine(typeof(<FetchStoreItemData>d__54))]
		private void FetchStoreItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x7B43F20", Offset = "0x7B42920", VA = "0x187B43F20")]
		private void UpdateStoreItemData(LLJFOPOCGJJ storeItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x7B43BE0", Offset = "0x7B425E0", VA = "0x187B43BE0")]
		private void ResetStoreItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x7B43A60", Offset = "0x7B42460", VA = "0x187B43A60")]
		private void RecordImpressionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x7B42F70", Offset = "0x7B41970", VA = "0x187B42F70", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x7B427D0", Offset = "0x7B411D0", VA = "0x187B427D0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x7B44A60", Offset = "0x7B43460", VA = "0x187B44A60")]
		public StoreItemViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public enum CarouselType
	{
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		Room,
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		Event,
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		Club,
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		Invention,
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		StoreItem,
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		CustomAvatarItem,
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		Account
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	public enum HighlightStyle
	{
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		Scale150,
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		Portrait,
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		Scale75,
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		Scale100,
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		FitPerRow4,
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		FitPerRow5,
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		FitPerRow6
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CreateAssetMenu(fileName = "CarouselDisplayConfig", menuName = "RecRoom/UI/CarouselDisplayConfig")]
	public class CarouselDisplayConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200008B")]
		public struct HighlightCardDataObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public IGNJONDMFAO platformMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public float cardWidth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			public float cardHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public HighlightStyle HighlightStyle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public bool VR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[Tooltip("Carousel height is driven by the card height. Multi-row room carousels will add one 'Card Height' height per row.")]
			[ReadOnlyField]
			public float carouselHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public int cardLimit;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		public struct CardDataObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			[ReadOnlyField]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public CarouselType CarouselType;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			public float carouselTitleHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			public float cardMetadataHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			[Tooltip("Carousel height is driven by the card height. Multi-row room carousels will add one 'Default Card Height' height per row.")]
			[ReadOnlyField]
			public float defaultCarouselHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			public float defaultCardWidth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public float defaultCardHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			public int defaultCardLimitWithScroll;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public int defaultCardLimitWithNoScroll;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			public RectOffset singleRowCarouselPadding;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			public RectOffset multiRowCarouselPadding;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			[FormerlySerializedAs("rowBottomPadding")]
			[Tooltip("Keep this in sync with the 'item spacing' value in Virtualized Scroll Rect List")]
			public int rowPaddingBottom;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200008D")]
		public struct DiscoveryVariantOverrides
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public string variantName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public int cardHeight;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		[SerializeField]
		public List<Uri> Uris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		[SerializeField]
		public bool allowCarouselHighlightingOnConfiguredUris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		[SerializeField]
		public bool allowEnforcingOrderedRenderingOnConfiguredUris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		[Tooltip("Multiplies the number of cards per row by this factor as part of MaximumResultCount. This way, if carousel content is deduplicated, there will still be cards to fill in the empty space left in the carousel.")]
		[SerializeField]
		private int dedupingMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		[SerializeField]
		[Tooltip("Puts a lower bound on number of fetched items as part of MaximumResultCount. This way, if carousel content is deduplicated, there will still be cards to fill in the empty space left in the carousel.")]
		[FormerlySerializedAs("minItemsToFetchPerRow")]
		private int minItemsToFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		[SerializeField]
		private CardDataObject[] defaultCardList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		[SerializeField]
		private HighlightCardDataObject[] highlightRoomListConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		[SerializeField]
		private DiscoveryVariantOverrides[] discoveryVariantOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		private IRRUIvNextBridge VNextBridge
		{
			[Cpp2IlInjected.Token(Token = "0x60004F0")]
			[Cpp2IlInjected.Address(RVA = "0x7B2B330", Offset = "0x7B29D30", VA = "0x187B2B330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B1C0", Offset = "0x7B29BC0", VA = "0x187B2B1C0")]
		public bool IsAnyConfiguredUriActive(BrowserModel browserModel)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x7B2A940", Offset = "0x7B29340", VA = "0x187B2A940")]
		public float GetCardWidth(HighlightStyle highlightStyle, CarouselType carouselType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x7B2A540", Offset = "0x7B28F40", VA = "0x187B2A540")]
		public float GetCardHeight(HighlightStyle highlightStyle, CarouselType carouselType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x7B2AA80", Offset = "0x7B29480", VA = "0x187B2AA80")]
		public float GetCarouselHeight(HighlightStyle highlightStyle, CarouselType carouselType, int numRows = 1, bool addPadding = true)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x7B2ACE0", Offset = "0x7B296E0", VA = "0x187B2ACE0")]
		public RectOffset GetCarouselPadding(CarouselType carouselType, int numRows)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x7B2A800", Offset = "0x7B29200", VA = "0x187B2A800")]
		public int GetCardLimitPerRow(bool isHorizontalScrollEnabled, HighlightStyle highlightStyle, CarouselType carouselType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B190", Offset = "0x7B29B90", VA = "0x187B2B190")]
		public int GetTotalCardLimit(bool isHorizontalScrollEnabled, HighlightStyle highlightStyle, CarouselType carouselType, int maxRows = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B0E0", Offset = "0x7B29AE0", VA = "0x187B2B0E0")]
		public int GetMinItemsToFetch(bool isHorizontalScrollEnabled, HighlightStyle highlightStyle, CarouselType carouselType, int maxRows = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x7B2ADD0", Offset = "0x7B297D0", VA = "0x187B2ADD0")]
		private HighlightCardDataObject GetFilteredDataObject(HighlightStyle highlightStyle)
		{
			return default(HighlightCardDataObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B2A360", Offset = "0x7B28D60", VA = "0x187B2A360")]
		private HighlightCardDataObject ApplyGameConfigOverrides(HighlightCardDataObject cardDataObject)
		{
			return default(HighlightCardDataObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60004FB")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B310", Offset = "0x7B29D10", VA = "0x187B2B310")]
		public CarouselDisplayConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[ViewModel]
	public class CarouselViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private const int defaultMinItemsToFetch = 20;

		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private const int defaultCardLimitPerRow = 5;

		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		public const string HighlightStyleDefault = "highlight_default";

		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		public const string HighlightStyleScale150 = "highlight_scale_150";

		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		public const string HighlightStylePortrait = "highlight_portrait";

		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		public const string HighlightStyleScale75 = "highlight_scale_75";

		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		public const string HighlightStyleScale100 = "highlight_scale_100";

		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		public const string HighlightStyleFitPerRow4 = "highlight_fitperrow_4";

		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		public const string HighlightStyleFitPerRow5 = "highlight_fitperrow_5";

		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		public const string HighlightStyleFitPerRow6 = "highlight_fitperrow_6";

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		[SerializeField]
		private CarouselType carouselType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003B2")]
		[SerializeField]
		private CarouselDisplayConfig displayConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003B3")]
		[SerializeField]
		private DataResolver carouselListResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003B4")]
		[SerializeField]
		private IGNJONDMFAO hidePageButtonsOnThesePlatforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40003B5")]
		private bool allowHorizontalScroll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003B6")]
		private int rowCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		private float? heightOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		private float? widthOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		private string backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		private HighlightStyle highlightStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		private Vector2 cardSizeOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40003BE")]
		private DiscoveryDisplayMetadata displayMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		private string sourceLabelText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private int maxRowCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private int maxResultCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private DataItem<bool> AllowHorizontalScrollDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private DataItem<int> RowCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private DataItem<float?> HeightOverrideDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private DataItem<float?> WidthOverrideDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private DataItem<string> BackgroundColorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private DataItem<HighlightStyle> HighlightStyleDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private DataItem<Vector2> CardSizeOverrideDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool AllowHorizontalScroll
		{
			[Cpp2IlInjected.Token(Token = "0x600050C")]
			[Cpp2IlInjected.Address(RVA = "0xE40770", Offset = "0xE3F170", VA = "0x180E40770")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600050D")]
			[Cpp2IlInjected.Address(RVA = "0x7B2CC60", Offset = "0x7B2B660", VA = "0x187B2CC60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		[BindableData(1, "Number of rows in the carousel", DataPermissions.ReadWrite)]
		public int RowCount
		{
			[Cpp2IlInjected.Token(Token = "0x600050E")]
			[Cpp2IlInjected.Address(RVA = "0xC9F1D0", Offset = "0xC9DBD0", VA = "0x180C9F1D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600050F")]
			[Cpp2IlInjected.Address(RVA = "0x7B2CCC0", Offset = "0x7B2B6C0", VA = "0x187B2CCC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		[BindableData(2, "The height override value, or null if there isn't one", DataPermissions.ReadWrite)]
		public float? HeightOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0x7B2CD20", Offset = "0x7B2B720", VA = "0x187B2CD20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000511")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D1D0", Offset = "0x7B2BBD0", VA = "0x187B2D1D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		[BindableData(3, "The width override value, or null if there isn't one. Typically used for card width.", DataPermissions.ReadWrite)]
		public float? WidthOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000512")]
			[Cpp2IlInjected.Address(RVA = "0x7971000", Offset = "0x796FA00", VA = "0x187971000")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000513")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D260", Offset = "0x7B2BC60", VA = "0x187B2D260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		[BindableData(4, "Background color of the carousel", DataPermissions.ReadWrite)]
		public string BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000514")]
			[Cpp2IlInjected.Address(RVA = "0xA091A0", Offset = "0xA07BA0", VA = "0x180A091A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D0C0", Offset = "0x7B2BAC0", VA = "0x187B2D0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		[BindableData(5, "Card Highlight Style", DataPermissions.ReadWrite)]
		public HighlightStyle HighlightStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0xA09290", Offset = "0xA07C90", VA = "0x180A09290")]
			get
			{
				return default(HighlightStyle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000517")]
			[Cpp2IlInjected.Address(RVA = "0x7B2CBD0", Offset = "0x7B2B5D0", VA = "0x187B2CBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		[BindableData(6, "The card width and height override value, or null if there isn't one. Used when overriding width alone is insufficient.", DataPermissions.ReadWrite)]
		public Vector2 CardSizeOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000518")]
			[Cpp2IlInjected.Address(RVA = "0x7B2CC30", Offset = "0x7B2B630", VA = "0x187B2CC30")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000519")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D140", Offset = "0x7B2BB40", VA = "0x187B2D140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		public int NumItemsToFetch
		{
			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0xA744C0", Offset = "0xA72EC0", VA = "0x180A744C0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0xA740C0", Offset = "0xA72AC0", VA = "0x180A740C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		public int MaxItemsToDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x600051C")]
			[Cpp2IlInjected.Address(RVA = "0xA8EA60", Offset = "0xA8D460", VA = "0x180A8EA60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000524")]
			[Cpp2IlInjected.Address(RVA = "0x7B2D080", Offset = "0x7B2BA80", VA = "0x187B2D080", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000525")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B3B0", Offset = "0x7B29DB0", VA = "0x187B2B3B0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x7B2CB20", Offset = "0x7B2B520", VA = "0x187B2CB20", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B630", Offset = "0x7B2A030", VA = "0x187B2B630")]
		public void ConfigureCarousel(DiscoveryDisplayMetadata displayMetadata, string sourceLabelText)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B470", Offset = "0x7B29E70", VA = "0x187B2B470")]
		private int CalculateNumItemsToFetch()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0x7B2C220", Offset = "0x7B2AC20", VA = "0x187B2C220")]
		private HighlightStyle GetHighlightStyle()
		{
			return default(HighlightStyle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x7B2CA90", Offset = "0x7B2B490", VA = "0x187B2CA90")]
		private void OnCarouselListUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x7B2B830", Offset = "0x7B2A230", VA = "0x187B2B830")]
		private void FinishCarouselInit(int totalNumCards)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x7B2C310", Offset = "0x7B2AD10", VA = "0x187B2C310", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x7B2BE70", Offset = "0x7B2A870", VA = "0x187B2BE70")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x7B2CD60", Offset = "0x7B2B760", VA = "0x187B2CD60")]
		public CarouselViewModel()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	public class DiscoveryDisplayMetadata : BaseDiscoveryDisplayMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public string DisplayTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public bool supportsDedupe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public int numRows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public string sizePerPlatform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public string backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public bool horizontalScrollEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public int itemCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public string cardStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public int minItemsToShowSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public string textColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public bool showNewThisSessionForSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public string sessionSectionIdOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public string descriptionText;

		[Cpp2IlInjected.Token(Token = "0x6000537")]
		[Cpp2IlInjected.Address(RVA = "0x7B34980", Offset = "0x7B33380", VA = "0x187B34980")]
		public DiscoveryDisplayMetadata()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[ViewModel]
	public class ConsumableListViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		[SerializeField]
		private IRRUIvNextConsumableBridge.ConsumableCategory listType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		[SerializeField]
		private Route shopRoute;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		private IRRUIvNextConsumableBridge consumableBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		private IRRUIvNextStoreItemBridge storeBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		private DataList<IGJHKHPDBNB> consumableList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		private DataItemList ConsumableListDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		private DataItemAction OpenShopDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<IGJHKHPDBNB> ConsumableList
		{
			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0xA09220", Offset = "0xA07C20", VA = "0x180A09220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000539")]
			[Cpp2IlInjected.Address(RVA = "0x7B32110", Offset = "0x7B30B10", VA = "0x187B32110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000540")]
			[Cpp2IlInjected.Address(RVA = "0x7B320D0", Offset = "0x7B30AD0", VA = "0x187B320D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000541")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x7B31AF0", Offset = "0x7B304F0", VA = "0x187B31AF0")]
		[BindableAction(1, null)]
		public void OpenShop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0x7B313C0", Offset = "0x7B2FDC0", VA = "0x187B313C0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0x7B319D0", Offset = "0x7B303D0", VA = "0x187B319D0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x7B319A0", Offset = "0x7B303A0", VA = "0x187B319A0")]
		private void OnActiveConsumableChanged(IGJHKHPDBNB consumable, bool isActive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053E")]
		[Cpp2IlInjected.Address(RVA = "0x7B31AE0", Offset = "0x7B304E0", VA = "0x187B31AE0")]
		private void OnPurchasedConsumableChanged(IGJHKHPDBNB consumable, bool added)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x7B31C70", Offset = "0x7B30670", VA = "0x187B31C70")]
		private void RefreshConsumableList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x7B317A0", Offset = "0x7B301A0", VA = "0x187B317A0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x7B31620", Offset = "0x7B30020", VA = "0x187B31620")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x7B31FA0", Offset = "0x7B309A0", VA = "0x187B31FA0")]
		public ConsumableListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[ViewModel]
	public class ConsumableViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		private IRRUIvNextConsumableBridge consumableBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		private IGJHKHPDBNB consumable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		private NJPGBKPAHEG mainImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		private int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		private bool isActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		private DataItem<NJPGBKPAHEG> MainImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		private DataItem<int> CountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		private DataItem<bool> IsActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		private DataItemAction UseConsumableDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000547")]
			[Cpp2IlInjected.Address(RVA = "0x7B33510", Offset = "0x7B31F10", VA = "0x187B33510", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public NJPGBKPAHEG MainImage
		{
			[Cpp2IlInjected.Token(Token = "0x6000548")]
			[Cpp2IlInjected.Address(RVA = "0xA17C00", Offset = "0xA16600", VA = "0x180A17C00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000549")]
			[Cpp2IlInjected.Address(RVA = "0x7B33020", Offset = "0x7B31A20", VA = "0x187B33020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600054A")]
			[Cpp2IlInjected.Address(RVA = "0xE3E930", Offset = "0xE3D330", VA = "0x180E3E930")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600054B")]
			[Cpp2IlInjected.Address(RVA = "0x7B33080", Offset = "0x7B31A80", VA = "0x187B33080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool IsActive
		{
			[Cpp2IlInjected.Token(Token = "0x600054C")]
			[Cpp2IlInjected.Address(RVA = "0xE40770", Offset = "0xE3F170", VA = "0x180E40770")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600054D")]
			[Cpp2IlInjected.Address(RVA = "0x7B330D0", Offset = "0x7B31AD0", VA = "0x187B330D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000555")]
			[Cpp2IlInjected.Address(RVA = "0x7B334D0", Offset = "0x7B31ED0", VA = "0x187B334D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0x7B33130", Offset = "0x7B31B30", VA = "0x187B33130")]
		[BindableAction(0, null)]
		public void UseConsumable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x7B32180", Offset = "0x7B30B80", VA = "0x187B32180", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x7B32A70", Offset = "0x7B31470", VA = "0x187B32A70", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0x7B32920", Offset = "0x7B31320", VA = "0x187B32920")]
		private void OnActiveConsumableChanged(IGJHKHPDBNB consumable, bool isActive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0x7B32F40", Offset = "0x7B31940", VA = "0x187B32F40", Slot = "14")]
		public override void SetBindingData(int sourceId, int itemId, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0x7B32B30", Offset = "0x7B31530", VA = "0x187B32B30")]
		private void RefreshData(IGJHKHPDBNB config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x7B32960", Offset = "0x7B31360", VA = "0x187B32960")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0x7B32520", Offset = "0x7B30F20", VA = "0x187B32520", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0x7B322C0", Offset = "0x7B30CC0", VA = "0x187B322C0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0x7B33350", Offset = "0x7B31D50", VA = "0x187B33350")]
		public ConsumableViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class GlobalDataViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		private int localAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		private long localRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		private long localRoomEventId;

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public int LocalAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000560")]
			[Cpp2IlInjected.Address(RVA = "0xA288C0", Offset = "0xA272C0", VA = "0x180A288C0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000561")]
			[Cpp2IlInjected.Address(RVA = "0x7B34FC0", Offset = "0x7B339C0", VA = "0x187B34FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014A")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public long LocalRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000562")]
			[Cpp2IlInjected.Address(RVA = "0xA0A540", Offset = "0xA08F40", VA = "0x180A0A540")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000563")]
			[Cpp2IlInjected.Address(RVA = "0x7B35070", Offset = "0x7B33A70", VA = "0x187B35070")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014B")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public long LocalRoomEventId
		{
			[Cpp2IlInjected.Token(Token = "0x6000564")]
			[Cpp2IlInjected.Address(RVA = "0xA091E0", Offset = "0xA07BE0", VA = "0x180A091E0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000565")]
			[Cpp2IlInjected.Address(RVA = "0x7B35010", Offset = "0x7B33A10", VA = "0x187B35010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0x7B34E40", Offset = "0x7B33840", VA = "0x187B34E40")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0x7B34990", Offset = "0x7B33390", VA = "0x187B34990", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x7B34AF0", Offset = "0x7B334F0", VA = "0x187B34AF0")]
		private void OnLocalAccountUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x7B34C40", Offset = "0x7B33640", VA = "0x187B34C40")]
		private void OnLocalRoomChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x7B34FA0", Offset = "0x7B339A0", VA = "0x187B34FA0")]
		public GlobalDataViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public class LongPressInteractable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		[SerializeField]
		protected float longPressDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public CNBOOGKDGFE OnLongClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public CNBOOGKDGFE OnShortClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		protected float pressStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		protected bool pointerInside;

		[Cpp2IlInjected.Token(Token = "0x600056B")]
		[Cpp2IlInjected.Address(RVA = "0xE06DE0", Offset = "0xE057E0", VA = "0x180E06DE0", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056C")]
		[Cpp2IlInjected.Address(RVA = "0x7B350F0", Offset = "0x7B33AF0", VA = "0x187B350F0", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056D")]
		[Cpp2IlInjected.Address(RVA = "0x7B350D0", Offset = "0x7B33AD0", VA = "0x187B350D0", Slot = "6")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056E")]
		[Cpp2IlInjected.Address(RVA = "0x7B35100", Offset = "0x7B33B00", VA = "0x187B35100", Slot = "7")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056F")]
		[Cpp2IlInjected.Address(RVA = "0x7B35160", Offset = "0x7B33B60", VA = "0x187B35160")]
		public LongPressInteractable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[ViewModel]
	public class CategoriesNestedItem : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private IMakerPenHUDBridge hudBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private int absoluteIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private CategoriesNestedListItem item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		private string text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		private bool isExpanded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		private Sprite activeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private int depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private DataItem<string> TextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private DataItem<bool> IsExpandedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private DataItem<Sprite> ActiveIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private DataItem<int> DepthDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private DataItemAction SelectItemDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		private CategoriesNestedListConfig config
		{
			[Cpp2IlInjected.Token(Token = "0x6000570")]
			[Cpp2IlInjected.Address(RVA = "0x7B2E5D0", Offset = "0x7B2CFD0", VA = "0x187B2E5D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000571")]
			[Cpp2IlInjected.Address(RVA = "0x7B2E550", Offset = "0x7B2CF50", VA = "0x187B2E550", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0xA092C0", Offset = "0xA07CC0", VA = "0x180A092C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x7B2E1D0", Offset = "0x7B2CBD0", VA = "0x187B2E1D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool IsExpanded
		{
			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0xC77AD0", Offset = "0xC764D0", VA = "0x180C77AD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000577")]
			[Cpp2IlInjected.Address(RVA = "0x7B2E240", Offset = "0x7B2CC40", VA = "0x187B2E240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public Sprite ActiveIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0xA09220", Offset = "0xA07C20", VA = "0x180A09220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600057A")]
			[Cpp2IlInjected.Address(RVA = "0x7B2E620", Offset = "0x7B2D020", VA = "0x187B2E620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public int Depth
		{
			[Cpp2IlInjected.Token(Token = "0x600057B")]
			[Cpp2IlInjected.Address(RVA = "0xA09270", Offset = "0xA07C70", VA = "0x180A09270")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600057C")]
			[Cpp2IlInjected.Address(RVA = "0x7B2E2B0", Offset = "0x7B2CCB0", VA = "0x187B2E2B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600057E")]
			[Cpp2IlInjected.Address(RVA = "0x7B2E510", Offset = "0x7B2CF10", VA = "0x187B2E510", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600057F")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000572")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D2F0", Offset = "0x7B2BCF0", VA = "0x187B2D2F0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000573")]
		[Cpp2IlInjected.Address(RVA = "0x7B2DE80", Offset = "0x7B2C880", VA = "0x187B2DE80", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000578")]
		[Cpp2IlInjected.Address(RVA = "0x7B2DEB0", Offset = "0x7B2C8B0", VA = "0x187B2DEB0")]
		[BindableAction(2, null)]
		public void SelectItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600057D")]
		[Cpp2IlInjected.Address(RVA = "0x7B2DB10", Offset = "0x7B2C510", VA = "0x187B2DB10")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000580")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D610", Offset = "0x7B2C010", VA = "0x187B2D610", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000581")]
		[Cpp2IlInjected.Address(RVA = "0x7B2D340", Offset = "0x7B2BD40", VA = "0x187B2D340")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000582")]
		[Cpp2IlInjected.Address(RVA = "0x7B2E310", Offset = "0x7B2CD10", VA = "0x187B2E310")]
		public CategoriesNestedItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[ViewModel]
	public class CategoriesNestedList : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private IMakerPenHUDBridge hudBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private DataList<int> activeIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private DataItemList ActiveIndicesDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		private CategoriesNestedListConfig config
		{
			[Cpp2IlInjected.Token(Token = "0x600058B")]
			[Cpp2IlInjected.Address(RVA = "0x7B30720", Offset = "0x7B2F120", VA = "0x187B30720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<int> ActiveIndices
		{
			[Cpp2IlInjected.Token(Token = "0x600058C")]
			[Cpp2IlInjected.Address(RVA = "0xA10530", Offset = "0xA0EF30", VA = "0x180A10530")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600058D")]
			[Cpp2IlInjected.Address(RVA = "0x7B30770", Offset = "0x7B2F170", VA = "0x187B30770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000591")]
			[Cpp2IlInjected.Address(RVA = "0x7B306F0", Offset = "0x7B2F0F0", VA = "0x187B306F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000592")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x7B2FD20", Offset = "0x7B2E720", VA = "0x187B2FD20", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x7B30250", Offset = "0x7B2EC50", VA = "0x187B30250", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x7B30470", Offset = "0x7B2EE70", VA = "0x187B30470")]
		private void OnIndexStateChanged(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000593")]
		[Cpp2IlInjected.Address(RVA = "0x7B30100", Offset = "0x7B2EB00", VA = "0x187B30100", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000594")]
		[Cpp2IlInjected.Address(RVA = "0x7B30000", Offset = "0x7B2EA00", VA = "0x187B30000")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x7B30610", Offset = "0x7B2F010", VA = "0x187B30610")]
		public CategoriesNestedList()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[ViewModel]
	public class ColorPickerCardViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private string colorName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public Enum shapeColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		private bool isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		private DataItem<int> IndexDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private DataItem<string> ColorNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private DataItem<Color> ColorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private DataItem<bool> IsSelectedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private DataItemAction SelectDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		[BindableData(1, "Which slot in the hotbar this represents", DataPermissions.ReadOnly)]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x600059A")]
			[Cpp2IlInjected.Address(RVA = "0xFA0640", Offset = "0xF9F040", VA = "0x180FA0640")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600059B")]
			[Cpp2IlInjected.Address(RVA = "0x7B31310", Offset = "0x7B2FD10", VA = "0x187B31310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		[BindableData(2, "Color Name", DataPermissions.ReadOnly)]
		public string ColorName
		{
			[Cpp2IlInjected.Token(Token = "0x600059C")]
			[Cpp2IlInjected.Address(RVA = "0xA17C00", Offset = "0xA16600", VA = "0x180A17C00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600059D")]
			[Cpp2IlInjected.Address(RVA = "0x7B311E0", Offset = "0x7B2FBE0", VA = "0x187B311E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		[BindableData(3, "Color", DataPermissions.ReadOnly)]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x600059E")]
			[Cpp2IlInjected.Address(RVA = "0x12030F0", Offset = "0x1201AF0", VA = "0x1812030F0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x600059F")]
			[Cpp2IlInjected.Address(RVA = "0x7B31250", Offset = "0x7B2FC50", VA = "0x187B31250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		[BindableData(5, "IsSelected", DataPermissions.ReadOnly)]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60005A1")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3B0", Offset = "0xA39DB0", VA = "0x180A3B3B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005A2")]
			[Cpp2IlInjected.Address(RVA = "0x7B31360", Offset = "0x7B2FD60", VA = "0x187B31360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60005A3")]
			[Cpp2IlInjected.Address(RVA = "0x7B311A0", Offset = "0x7B2FBA0", VA = "0x187B311A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60005A4")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0x7B30F80", Offset = "0x7B2F980", VA = "0x187B30F80")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000599")]
		[Cpp2IlInjected.Address(RVA = "0x7B30E80", Offset = "0x7B2F880", VA = "0x187B30E80", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A0")]
		[Cpp2IlInjected.Address(RVA = "0x7B30EB0", Offset = "0x7B2F8B0", VA = "0x187B30EB0")]
		[BindableAction(4, "Selects Color")]
		public void Select()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B30AA0", Offset = "0x7B2F4A0", VA = "0x187B30AA0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A6")]
		[Cpp2IlInjected.Address(RVA = "0x7B307D0", Offset = "0x7B2F1D0", VA = "0x187B307D0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B30FD0", Offset = "0x7B2F9D0", VA = "0x187B30FD0")]
		public ColorPickerCardViewModel()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public class CategoriesNestedListItem : ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public string Text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public bool IsExpanded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public Sprite ExpandedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public Sprite CollapsedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public CategoriesFilter Filter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		[Header("All children of the same parent should have both icons set, or none")]
		public List<CategoriesNestedListItem> Children;

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x7B2F950", Offset = "0x7B2E350", VA = "0x187B2F950", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x7B2FC70", Offset = "0x7B2E670", VA = "0x187B2FC70")]
		public CategoriesNestedListItem()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	public struct CategoriesFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public CategoriesFilterType filterType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		[Tooltip("Metadata for filterType = PaletteSearchFilter")]
		public string paletteSearchFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		[Tooltip("Metadata for paletteSortOption = SortOption")]
		public OJGNGALFKDN paletteSortOption;
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public enum CategoriesFilterType
	{
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		PaletteSearchFilter,
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		Favorites,
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		RoomInventions
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[CreateAssetMenu(fileName = "CategoriesNestedListConfig", menuName = "RRUI/MakerPenHUD/Nested List/Categories Nested List Config")]
	public class CategoriesNestedListConfig : ScriptableObject, EFJOKLHFJAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		[SerializeField]
		private List<CategoriesNestedListItem> nestedListItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private List<CategoriesNestedListItem> clonedNestedListItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		private List<int> activeIndices;

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		public List<CategoriesNestedListItem> ListItems
		{
			[Cpp2IlInjected.Token(Token = "0x60005AE")]
			[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005AF")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA093C0", VA = "0x180A0A9C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		public NBHKBEPCJOC<int> OnIndexExpanded
		{
			[Cpp2IlInjected.Token(Token = "0x60005B0")]
			[Cpp2IlInjected.Address(RVA = "0xA0A590", Offset = "0xA08F90", VA = "0x180A0A590", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005B1")]
			[Cpp2IlInjected.Address(RVA = "0xA10D40", Offset = "0xA0F740", VA = "0x180A10D40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		public NBHKBEPCJOC<int> OnIndexCollapsed
		{
			[Cpp2IlInjected.Token(Token = "0x60005B2")]
			[Cpp2IlInjected.Address(RVA = "0xA0A540", Offset = "0xA08F40", VA = "0x180A0A540", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005B3")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7D0", Offset = "0xA091D0", VA = "0x180A0A7D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		public NBHKBEPCJOC<int> OnIndexSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60005B4")]
			[Cpp2IlInjected.Address(RVA = "0xA091E0", Offset = "0xA07BE0", VA = "0x180A091E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005B5")]
			[Cpp2IlInjected.Address(RVA = "0xA09180", Offset = "0xA07B80", VA = "0x180A09180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005B6")]
		[Cpp2IlInjected.Address(RVA = "0x7B2E8B0", Offset = "0x7B2D2B0", VA = "0x187B2E8B0", Slot = "6")]
		public List<int> GetActiveIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005B7")]
		[Cpp2IlInjected.Address(RVA = "0x7B2F2E0", Offset = "0x7B2DCE0", VA = "0x187B2F2E0")]
		private void SetActiveIndices()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005B8")]
		[Cpp2IlInjected.Address(RVA = "0x7B2E900", Offset = "0x7B2D300", VA = "0x187B2E900", Slot = "7")]
		public int GetDepth(int idx)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x7B2EC20", Offset = "0x7B2D620", VA = "0x187B2EC20", Slot = "8")]
		public bool IsChild(int parentIdx, int childIdx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0x7B2ECD0", Offset = "0x7B2D6D0", VA = "0x187B2ECD0", Slot = "9")]
		public bool IsExpanded(int idx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0x7B2ED30", Offset = "0x7B2D730", VA = "0x187B2ED30", Slot = "10")]
		public bool IsParent(int childIdx, int parentIdx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0x7B2F220", Offset = "0x7B2DC20", VA = "0x187B2F220")]
		public void Select(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x7B2E7C0", Offset = "0x7B2D1C0", VA = "0x187B2E7C0")]
		public void Expand(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0x7B2E6D0", Offset = "0x7B2D0D0", VA = "0x187B2E6D0")]
		public void Collapse(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x7B2EE30", Offset = "0x7B2D830", VA = "0x187B2EE30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x7B2E9F0", Offset = "0x7B2D3F0", VA = "0x187B2E9F0")]
		private bool IconsSetConsistently(List<CategoriesNestedListItem> items)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x7B2EDE0", Offset = "0x7B2D7E0", VA = "0x187B2EDE0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C2")]
		[Cpp2IlInjected.Address(RVA = "0x7B2F850", Offset = "0x7B2E250", VA = "0x187B2F850")]
		public CategoriesNestedListConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[ViewModel]
	public class CreateModeHotbarSlotViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private Texture cachedTextureForNextUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private bool setImageNextUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private Texture image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private bool isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private bool isImageSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private bool isPaletteOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x83")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private bool? isSelectedAndPaletteNotOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private DataItem<int> IndexDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private DataItem<Texture> ImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private DataItem<bool> IsSelectedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private DataItem<bool> IsImageSetDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private DataItem<bool> IsPaletteOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private DataItem<bool> IsSelectedAndPaletteNotOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private DataItem<bool> CanSelectDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private DataItemAction SelectDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		[BindableData(1, "Which slot in the hotbar this represents", DataPermissions.ReadOnly)]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0xA32150", Offset = "0xA30B50", VA = "0x180A32150")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x7B34780", Offset = "0x7B33180", VA = "0x187B34780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		[BindableData(2, "The image that should be displayed for this hotbar item", DataPermissions.ReadOnly)]
		public Texture Image
		{
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0xA092C0", Offset = "0xA07CC0", VA = "0x180A092C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0x7B34650", Offset = "0x7B33050", VA = "0x187B34650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		[BindableData(3, "Whether or not this is selected", DataPermissions.ReadOnly)]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0xC77AD0", Offset = "0xC764D0", VA = "0x180C77AD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x7B34900", Offset = "0x7B33300", VA = "0x187B34900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		[BindableData(5, "Whether or not the Image property is set", DataPermissions.ReadOnly)]
		public bool IsImageSet
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0xEACA30", Offset = "0xEAB430", VA = "0x180EACA30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x7B347D0", Offset = "0x7B331D0", VA = "0x187B347D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		[BindableData(6, "Whether or not the palette is open", DataPermissions.ReadOnly)]
		public bool IsPaletteOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0xEACA40", Offset = "0xEAB440", VA = "0x180EACA40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x7B34090", Offset = "0x7B32A90", VA = "0x187B34090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		[BindableData(7, "Whether or not this is selected", DataPermissions.ReadOnly)]
		public bool IsSelectedAndPaletteNotOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0x7B342A0", Offset = "0x7B32CA0", VA = "0x187B342A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x7B34850", Offset = "0x7B33250", VA = "0x187B34850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		[BindableData(8, "Whether or not we can select this item", DataPermissions.ReadOnly)]
		public bool CanSelect
		{
			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x7B34340", Offset = "0x7B32D40", VA = "0x187B34340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60005D8")]
			[Cpp2IlInjected.Address(RVA = "0x7B34610", Offset = "0x7B33010", VA = "0x187B34610", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60005D9")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005D2")]
		[Cpp2IlInjected.Address(RVA = "0x7B34130", Offset = "0x7B32B30", VA = "0x187B34130")]
		[BindableAction(4, "Selects this hotbar item")]
		public void Select()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D3")]
		[Cpp2IlInjected.Address(RVA = "0x7B341B0", Offset = "0x7B32BB0", VA = "0x187B341B0")]
		public void SetImageInNextUpdate(Texture t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D4")]
		[Cpp2IlInjected.Address(RVA = "0x7B341D0", Offset = "0x7B32BD0", VA = "0x187B341D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D5")]
		[Cpp2IlInjected.Address(RVA = "0x7B34360", Offset = "0x7B32D60", VA = "0x187B34360")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x7B33FA0", Offset = "0x7B329A0", VA = "0x187B33FA0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x7B34090", Offset = "0x7B32A90", VA = "0x187B34090")]
		private void OnPaletteToggled(bool isOpen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x7B339B0", Offset = "0x7B323B0", VA = "0x187B339B0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x7B33590", Offset = "0x7B31F90", VA = "0x187B33590")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x7B343A0", Offset = "0x7B32DA0", VA = "0x187B343A0")]
		public CreateModeHotbarSlotViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[ViewModel]
	public class MakerPenHUDConfigureViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private KACOJFHHODD _configurable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		private bool _hasConfigurable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private string _title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		private string _subtitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		[SerializeField]
		private bool isAdvancedMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		private bool _isAdvancedMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private DataList<JOIHANOOGOK> _dynamicUIElements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private bool _isDynamicUIElementsEmpty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private ToastListModel _toastListModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		private DialogListModel _dialogListModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		private IMakerPenHUDBridge _makerPenHUDBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private DataItem<KACOJFHHODD> ConfigurableDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private DataItem<bool> HasConfigurableDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private DataItem<string> TitleDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private DataItem<string> SubtitleDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		private DataItem<bool> IsAdvancedModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private DataItem<bool> IsDynamicUIElementsEmptyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		private DataItemList DynamicUIElementsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private DataItemAction ResetConfigurableDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private DataItemAction CollapseAllFoldoutsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private DataItemAction ExpandAllFoldoutsDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public KACOJFHHODD Configurable
		{
			[Cpp2IlInjected.Token(Token = "0x60005E4")]
			[Cpp2IlInjected.Address(RVA = "0xA10520", Offset = "0xA0EF20", VA = "0x180A10520")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005E5")]
			[Cpp2IlInjected.Address(RVA = "0x7B37A40", Offset = "0x7B36440", VA = "0x187B37A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		[BindableData(1, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool HasConfigurable
		{
			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0xBD1230", Offset = "0xBCFC30", VA = "0x180BD1230")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(RVA = "0x7B36F60", Offset = "0x7B35960", VA = "0x187B36F60")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		[BindableData(2, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0xA17C00", Offset = "0xA16600", VA = "0x180A17C00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x7B36FC0", Offset = "0x7B359C0", VA = "0x187B36FC0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016E")]
		[BindableData(3, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public string Subtitle
		{
			[Cpp2IlInjected.Token(Token = "0x60005EC")]
			[Cpp2IlInjected.Address(RVA = "0xA092C0", Offset = "0xA07CC0", VA = "0x180A092C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005ED")]
			[Cpp2IlInjected.Address(RVA = "0x7B37030", Offset = "0x7B35A30", VA = "0x187B37030")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool IsAdvancedMode
		{
			[Cpp2IlInjected.Token(Token = "0x60005EE")]
			[Cpp2IlInjected.Address(RVA = "0xEACA30", Offset = "0xEAB430", VA = "0x180EACA30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005EF")]
			[Cpp2IlInjected.Address(RVA = "0x7B370A0", Offset = "0x7B35AA0", VA = "0x187B370A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		[BindableData(5, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public DataList<JOIHANOOGOK> DynamicUIElements
		{
			[Cpp2IlInjected.Token(Token = "0x60005F0")]
			[Cpp2IlInjected.Address(RVA = "0xA09220", Offset = "0xA07C20", VA = "0x180A09220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0x7B37AF0", Offset = "0x7B364F0", VA = "0x187B37AF0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		[BindableData(6, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsDynamicUIElementsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3B0", Offset = "0xA39DB0", VA = "0x180A3B3B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005F3")]
			[Cpp2IlInjected.Address(RVA = "0x7B36E30", Offset = "0x7B35830", VA = "0x187B36E30")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x7B37A00", Offset = "0x7B36400", VA = "0x187B37A00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005E6")]
		[Cpp2IlInjected.Address(RVA = "0x7B36BB0", Offset = "0x7B355B0", VA = "0x187B36BB0")]
		private void Register(KACOJFHHODD configurable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E7")]
		[Cpp2IlInjected.Address(RVA = "0x7B37110", Offset = "0x7B35B10", VA = "0x187B37110")]
		private void Unregister(KACOJFHHODD configurable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x7B35220", Offset = "0x7B33C20", VA = "0x187B35220", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x7B367B0", Offset = "0x7B351B0", VA = "0x187B367B0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x7B36960", Offset = "0x7B35360", VA = "0x187B36960")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x7B36910", Offset = "0x7B35310", VA = "0x187B36910")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x7B36A30", Offset = "0x7B35430", VA = "0x187B36A30")]
		private void OnMakerPenConfigMenuDataChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x7B36AC0", Offset = "0x7B354C0", VA = "0x187B36AC0")]
		private void OnRRUIPageContainerEnabledChanged(bool isEnabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B36A90", Offset = "0x7B35490", VA = "0x187B36A90")]
		private void OnObjectSettingsToast(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x7B36AD0", Offset = "0x7B354D0", VA = "0x187B36AD0")]
		private void OnShowDialog(JFLFHGFOOPA dialogType, GBKFGNKLPHA dialogData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x7B36920", Offset = "0x7B35320", VA = "0x187B36920")]
		private void OnDismissAllDialogs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x7B36950", Offset = "0x7B35350", VA = "0x187B36950")]
		private void OnDynamicUIElementsChanged(KACOJFHHODD configurable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FE")]
		[Cpp2IlInjected.Address(RVA = "0x7B369C0", Offset = "0x7B353C0", VA = "0x187B369C0")]
		private void OnForceRefreshConfigUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FF")]
		[Cpp2IlInjected.Address(RVA = "0x7B37350", Offset = "0x7B35D50", VA = "0x187B37350")]
		private void UpdateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000600")]
		[Cpp2IlInjected.Address(RVA = "0x7B35470", Offset = "0x7B33E70", VA = "0x187B35470")]
		private void ClearData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000601")]
		[Cpp2IlInjected.Address(RVA = "0x7B36DE0", Offset = "0x7B357E0", VA = "0x187B36DE0")]
		[BindableAction(100, null)]
		public void ResetConfigurable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000602")]
		[Cpp2IlInjected.Address(RVA = "0x7B355B0", Offset = "0x7B33FB0", VA = "0x187B355B0")]
		[BindableAction(101, null)]
		public void CollapseAllFoldouts()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000603")]
		[Cpp2IlInjected.Address(RVA = "0x7B357D0", Offset = "0x7B341D0", VA = "0x187B357D0")]
		[BindableAction(102, null)]
		public void ExpandAllFoldouts()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000606")]
		[Cpp2IlInjected.Address(RVA = "0x7B35EF0", Offset = "0x7B348F0", VA = "0x187B35EF0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x7B359F0", Offset = "0x7B343F0", VA = "0x187B359F0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x7B376B0", Offset = "0x7B360B0", VA = "0x187B376B0")]
		public MakerPenHUDConfigureViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[ViewModel]
	public class MakerPenHUDCreateToolbarViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		[SerializeField]
		private GameObject palettePanelGameObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		[SerializeField]
		private FocusableUI toolbarFocusable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private bool leftModifierPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x71")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private bool rightModifierPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x72")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private bool rightModifierHeld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private IRRUIvNextBridge rruiBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private bool hasFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private float holdInputProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private bool showHoldIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x91")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private bool paletteIsOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private string toolDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private DataItem<bool> HasFocusDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private DataItem<float> HoldInputProgressDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private DataItem<bool> ShowHoldIndicatorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private DataItem<bool> PaletteIsOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private DataItem<bool> CreateModeRecolorIsAvailableDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private DataItem<string> ToolDescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private DataItemAction ClickPaletteButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private DataItemAction ClickRecolorButtonDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		private bool shouldFocus
		{
			[Cpp2IlInjected.Token(Token = "0x6000617")]
			[Cpp2IlInjected.Address(RVA = "0x7B39A90", Offset = "0x7B38490", VA = "0x187B39A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000175")]
		[BindableData(200, null, DataPermissions.ReadWrite)]
		public bool HasFocus
		{
			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0xDA28A0", Offset = "0xDA12A0", VA = "0x180DA28A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0x7B39590", Offset = "0x7B37F90", VA = "0x187B39590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000176")]
		[BindableData(201, null, DataPermissions.ReadWrite)]
		public float HoldInputProgress
		{
			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x1135B50", Offset = "0x1134550", VA = "0x181135B50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0x7B395F0", Offset = "0x7B37FF0", VA = "0x187B395F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		[BindableData(202, null, DataPermissions.ReadWrite)]
		public bool ShowHoldIndicator
		{
			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3B0", Offset = "0xA39DB0", VA = "0x180A3B3B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0x7B39660", Offset = "0x7B38060", VA = "0x187B39660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		[BindableData(3, "True if the palette is currently open", DataPermissions.ReadOnly)]
		public bool PaletteIsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000627")]
			[Cpp2IlInjected.Address(RVA = "0x2059080", Offset = "0x2057A80", VA = "0x182059080")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000628")]
			[Cpp2IlInjected.Address(RVA = "0x7B39B40", Offset = "0x7B38540", VA = "0x187B39B40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000179")]
		[BindableData(4, "Recolor in create mode is not yet supported", DataPermissions.ReadOnly)]
		public bool CreateModeRecolorIsAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017A")]
		[BindableData(5, "ToolDescription", DataPermissions.ReadOnly)]
		public string ToolDescription
		{
			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0xA091A0", Offset = "0xA07BA0", VA = "0x180A091A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600062B")]
			[Cpp2IlInjected.Address(RVA = "0x7B39BA0", Offset = "0x7B385A0", VA = "0x187B39BA0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017B")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0x7B39A50", Offset = "0x7B38450", VA = "0x187B39A50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600062E")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x7B390A0", Offset = "0x7B37AA0", VA = "0x187B390A0")]
		private void OnLeftNavInputStateChanged(MakerPenHUDNavigationInputState.NavInputState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x7B392E0", Offset = "0x7B37CE0", VA = "0x187B392E0")]
		private void OnRightNavInputStateChanged(MakerPenHUDNavigationInputState.NavInputState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x7B396C0", Offset = "0x7B380C0", VA = "0x187B396C0")]
		private void UpdateInputState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x7B37B60", Offset = "0x7B36560", VA = "0x187B37B60", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x7B38CB0", Offset = "0x7B376B0", VA = "0x187B38CB0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x7B38130", Offset = "0x7B36B30", VA = "0x187B38130")]
		[BindableAction(1, "Invoked when the palette button is clicked")]
		public void ClickPaletteButton()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0x7B39200", Offset = "0x7B37C00", VA = "0x187B39200")]
		private void OnPaletteToggled(bool open)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x7B38C50", Offset = "0x7B37650", VA = "0x187B38C50")]
		private void OnCursorActiveChanged(bool active)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		[BindableAction(2, "Invoked when the recolor button is clicked")]
		public void ClickRecolorButton()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x7B394F0", Offset = "0x7B37EF0", VA = "0x187B394F0")]
		private void OnStampModeChanged(bool mode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062F")]
		[Cpp2IlInjected.Address(RVA = "0x7B385B0", Offset = "0x7B36FB0", VA = "0x187B385B0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000630")]
		[Cpp2IlInjected.Address(RVA = "0x7B38190", Offset = "0x7B36B90", VA = "0x187B38190")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x7B397E0", Offset = "0x7B381E0", VA = "0x187B397E0")]
		public MakerPenHUDCreateToolbarViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[ViewModel]
	public class MakerPenHUDPaletteObjectViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		[FormerlySerializedAs("Index")]
		public int ObjectIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private bool favorited;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6D")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private bool canBeFavorited;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private Texture iconTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private bool isIconTextureSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private string objectName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private bool selected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		private bool showActionButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		private string actionButtonText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private bool setNameNextUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private bool setIconNextUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private Texture2D cachedIconTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private string cachedName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		private DataItem<bool> FavoritedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		private DataItem<bool> CanBeFavoritedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		private DataItem<Texture> IconTextureDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		private DataItem<bool> IsIconTextureSetDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		private DataItem<string> ObjectNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		private DataItem<bool> SelectedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private DataItem<bool> ShowActionButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private DataItem<string> ActionButtonTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private DataItemAction ClickObjectDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private DataItemAction ClickFavoriteDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private DataItemAction ClickActionButtonDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		[BindableData(1, "Whether or not the user has favorited this object", DataPermissions.ReadOnly)]
		public bool Favorited
		{
			[Cpp2IlInjected.Token(Token = "0x600063B")]
			[Cpp2IlInjected.Address(RVA = "0xF6BF30", Offset = "0xF6A930", VA = "0x180F6BF30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600063C")]
			[Cpp2IlInjected.Address(RVA = "0x7B3B030", Offset = "0x7B39A30", VA = "0x187B3B030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		[BindableData(8, "Whether or not the user can set this object as a favorite", DataPermissions.ReadOnly)]
		public bool CanBeFavorited
		{
			[Cpp2IlInjected.Token(Token = "0x600063D")]
			[Cpp2IlInjected.Address(RVA = "0xF691C0", Offset = "0xF67BC0", VA = "0x180F691C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600063E")]
			[Cpp2IlInjected.Address(RVA = "0x7B3AFD0", Offset = "0x7B399D0", VA = "0x187B3AFD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		[BindableData(2, "The image to use for the icon for the object", DataPermissions.ReadOnly)]
		public Texture IconTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600063F")]
			[Cpp2IlInjected.Address(RVA = "0xA17C00", Offset = "0xA16600", VA = "0x180A17C00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000640")]
			[Cpp2IlInjected.Address(RVA = "0x7B3B090", Offset = "0x7B39A90", VA = "0x187B3B090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		[BindableData(7, "True if the icon texture is set", DataPermissions.ReadOnly)]
		public bool IsIconTextureSet
		{
			[Cpp2IlInjected.Token(Token = "0x6000641")]
			[Cpp2IlInjected.Address(RVA = "0xCDD540", Offset = "0xCDBF40", VA = "0x180CDD540")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000642")]
			[Cpp2IlInjected.Address(RVA = "0x7B3B190", Offset = "0x7B39B90", VA = "0x187B3B190")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		[BindableData(5, "The name of the object to display", DataPermissions.ReadOnly)]
		public string ObjectName
		{
			[Cpp2IlInjected.Token(Token = "0x6000643")]
			[Cpp2IlInjected.Address(RVA = "0xA09190", Offset = "0xA07B90", VA = "0x180A09190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x7B3B1F0", Offset = "0x7B39BF0", VA = "0x187B3B1F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		[BindableData(6, "Whether or not the object is selected by the user", DataPermissions.ReadOnly)]
		public bool Selected
		{
			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0xDA28A0", Offset = "0xDA12A0", VA = "0x180DA28A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x7B3B270", Offset = "0x7B39C70", VA = "0x187B3B270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		[BindableData(9, "Whether or not to show the action button", DataPermissions.ReadOnly)]
		public bool ShowActionButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000647")]
			[Cpp2IlInjected.Address(RVA = "0xDA28B0", Offset = "0xDA12B0", VA = "0x180DA28B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000648")]
			[Cpp2IlInjected.Address(RVA = "0x7B3B2D0", Offset = "0x7B39CD0", VA = "0x187B3B2D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		[BindableData(10, "Text to populate the action button", DataPermissions.ReadOnly)]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x6000649")]
			[Cpp2IlInjected.Address(RVA = "0xA6E210", Offset = "0xA6CC10", VA = "0x180A6E210")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x7B3AF50", Offset = "0x7B39950", VA = "0x187B3AF50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0x7B3AF10", Offset = "0x7B39910", VA = "0x187B3AF10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0x7B39CA0", Offset = "0x7B386A0", VA = "0x187B39CA0")]
		[BindableAction(3, "Call when the object is clicked")]
		public void ClickObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x7B39C50", Offset = "0x7B38650", VA = "0x187B39C50")]
		[BindableAction(4, "Call when the favorite button is clicked")]
		public void ClickFavorite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x7B39C00", Offset = "0x7B38600", VA = "0x187B39C00")]
		[BindableAction(11, "Called when the action button is clicked")]
		public void ClickActionButton()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x7B3AAD0", Offset = "0x7B394D0", VA = "0x187B3AAD0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0x7B3AAB0", Offset = "0x7B394B0", VA = "0x187B3AAB0")]
		public void SetNameInNextUpdate(string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0x7B3AA90", Offset = "0x7B39490", VA = "0x187B3AA90")]
		public void SetIconInNextUpdate(Texture2D icon)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0x7B3AB20", Offset = "0x7B39520", VA = "0x187B3AB20")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000652")]
		[Cpp2IlInjected.Address(RVA = "0x7B3AA50", Offset = "0x7B39450", VA = "0x187B3AA50", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000655")]
		[Cpp2IlInjected.Address(RVA = "0x7B3A260", Offset = "0x7B38C60", VA = "0x187B3A260", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000656")]
		[Cpp2IlInjected.Address(RVA = "0x7B39CF0", Offset = "0x7B386F0", VA = "0x187B39CF0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000657")]
		[Cpp2IlInjected.Address(RVA = "0x7B3ABF0", Offset = "0x7B395F0", VA = "0x187B3ABF0")]
		public MakerPenHUDPaletteObjectViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[ViewModel]
	public class MakerPenHUDPaletteSearchViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private DataItem<string> PaletteSearchStringDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		[BindableData(1, "The current search string fed to the palette population logic", DataPermissions.ReadWrite)]
		public string PaletteSearchString
		{
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0x7B3B5D0", Offset = "0x7B39FD0", VA = "0x187B3B5D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000663")]
			[Cpp2IlInjected.Address(RVA = "0x7B3B620", Offset = "0x7B3A020", VA = "0x187B3B620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000664")]
			[Cpp2IlInjected.Address(RVA = "0x7B3B710", Offset = "0x7B3A110", VA = "0x187B3B710", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000665")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x7B3B330", Offset = "0x7B39D30", VA = "0x187B3B330", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0x7B30E80", Offset = "0x7B2F880", VA = "0x187B30E80", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0x7B3B480", Offset = "0x7B39E80", VA = "0x187B3B480", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0x7B3B380", Offset = "0x7B39D80", VA = "0x187B3B380")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x7B3B680", Offset = "0x7B3A080", VA = "0x187B3B680")]
		public MakerPenHUDPaletteSearchViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[ViewModel]
	public class MakerPenHUDPaletteViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private DataItem<bool> IsPaletteSearchOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private DataItemAction TogglePaletteSearchDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		[BindableData(2, "Is the palette search currently opened or closed", DataPermissions.ReadOnly)]
		public bool IsPaletteSearchOpen
		{
			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0x7B3BB20", Offset = "0x7B3A520", VA = "0x187B3BB20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600066F")]
			[Cpp2IlInjected.Address(RVA = "0x7B3BC30", Offset = "0x7B3A630", VA = "0x187B3BC30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600066B")]
		[Cpp2IlInjected.Address(RVA = "0x7B3B740", Offset = "0x7B3A140", VA = "0x187B3B740", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x7B30E80", Offset = "0x7B2F880", VA = "0x187B30E80", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x7B3BAB0", Offset = "0x7B3A4B0", VA = "0x187B3BAB0")]
		[BindableAction(1, "Toggle Search bar open/closed")]
		public void TogglePaletteSearch()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000671")]
		[Cpp2IlInjected.Address(RVA = "0x7B3B900", Offset = "0x7B3A300", VA = "0x187B3B900", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x7B3B790", Offset = "0x7B3A190", VA = "0x187B3B790")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x7B3BB70", Offset = "0x7B3A570", VA = "0x187B3BB70")]
		public MakerPenHUDPaletteViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[ViewModel]
	public class MakerPenHUDSelectToolbarViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		[SerializeField]
		private FocusableUI focusable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		[SerializeField]
		private DialogListModel dialogListModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private IRRUIvNextBridge rruiBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private bool leftModifierPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private bool rightModifierPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private bool rightModifierHeld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x83")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private bool hasFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private float holdInputProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private bool showHoldIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private bool isDeleteAllow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8A")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private bool onCloneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8B")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private bool inTransformModeAndMoveOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private bool inTransformModeAndRotateOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8D")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		private bool inTransformModeAndScaleOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8E")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private bool isRecolorModeActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8F")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private bool isPrecisionModifierModeActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private bool showEditColorPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x91")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private bool isEditColorPanelHiddenWhenRecolorModeActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x92")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		private bool onConfigMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x93")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		private bool isRRUIPageContainerEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private string toolDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private bool isAdjustModeActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private bool showAdjustButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private DataItem<bool> HasFocusDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private DataItem<float> HoldInputProgressDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private DataItem<bool> ShowHoldIndicatorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private DataItem<bool> IsDeleteAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private DataItem<bool> OnCloneModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private DataItem<bool> InTransfromModeAndMoveOnDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private DataItem<bool> InTransformModeAndRotateOnDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private DataItem<bool> InTransformModeAndScaleOnDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private DataItem<bool> IsRecolorModeActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private DataItem<bool> IsPrecisionModifierModeActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private DataItem<bool> ShowEditColorPanelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private DataItem<bool> IsEditColorPanelHiddenWhenRecolorModeActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private DataItem<bool> OnConfigModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private DataItem<bool> IsRRUIPageContainerEnabledDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private DataItem<string> ToolDescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private DataItem<bool> IsAdjustModeActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private DataItem<bool> ShowAdjustButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private DataItemAction ToggleCloneModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		private DataItemAction ToggleMoveModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private DataItemAction ToggleRotateModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private DataItemAction ToggleScaleModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private DataItemAction DeleteSelectionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private DataItemAction ToggleRecolorModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private DataItemAction ExitRecolorModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private DataItemAction ToggleConfigModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private DataItemAction HideRRUIPageContainerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private DataItemAction ShowRRUIPageContainerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private DataItemAction RequestAdjustModeDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		private bool shouldFocus
		{
			[Cpp2IlInjected.Token(Token = "0x6000675")]
			[Cpp2IlInjected.Address(RVA = "0x7B40870", Offset = "0x7B3F270", VA = "0x187B40870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		[BindableData(200, null, DataPermissions.ReadWrite)]
		public bool HasFocus
		{
			[Cpp2IlInjected.Token(Token = "0x6000676")]
			[Cpp2IlInjected.Address(RVA = "0x14B4B50", Offset = "0x14B3550", VA = "0x1814B4B50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(RVA = "0x7B3F620", Offset = "0x7B3E020", VA = "0x187B3F620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		[BindableData(201, null, DataPermissions.ReadWrite)]
		public float HoldInputProgress
		{
			[Cpp2IlInjected.Token(Token = "0x6000678")]
			[Cpp2IlInjected.Address(RVA = "0x1767A10", Offset = "0x1766410", VA = "0x181767A10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(RVA = "0x7B3F860", Offset = "0x7B3E260", VA = "0x187B3F860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		[BindableData(202, null, DataPermissions.ReadWrite)]
		public bool ShowHoldIndicator
		{
			[Cpp2IlInjected.Token(Token = "0x600067A")]
			[Cpp2IlInjected.Address(RVA = "0xDA28A0", Offset = "0xDA12A0", VA = "0x180DA28A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x7B3F8D0", Offset = "0x7B3E2D0", VA = "0x187B3F8D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		[BindableData(6, "Is Delete Allowed", DataPermissions.ReadWrite)]
		public bool IsDeleteAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x6000687")]
			[Cpp2IlInjected.Address(RVA = "0xDA28B0", Offset = "0xDA12B0", VA = "0x180DA28B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000688")]
			[Cpp2IlInjected.Address(RVA = "0x7B3F930", Offset = "0x7B3E330", VA = "0x187B3F930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		[BindableData(7, "OnCloneMode", DataPermissions.ReadWrite)]
		public bool OnCloneMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000689")]
			[Cpp2IlInjected.Address(RVA = "0x27677A0", Offset = "0x27661A0", VA = "0x1827677A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600068A")]
			[Cpp2IlInjected.Address(RVA = "0x7B3F990", Offset = "0x7B3E390", VA = "0x187B3F990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		[BindableData(8, "In Transfrom Mode And Move On", DataPermissions.ReadWrite)]
		public bool InTransfromModeAndMoveOn
		{
			[Cpp2IlInjected.Token(Token = "0x600068B")]
			[Cpp2IlInjected.Address(RVA = "0x1645230", Offset = "0x1643C30", VA = "0x181645230")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600068C")]
			[Cpp2IlInjected.Address(RVA = "0x7B3F440", Offset = "0x7B3DE40", VA = "0x187B3F440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		[BindableData(9, "In Transform Mode And Rotate On", DataPermissions.ReadWrite)]
		public bool InTransformModeAndRotateOn
		{
			[Cpp2IlInjected.Token(Token = "0x600068D")]
			[Cpp2IlInjected.Address(RVA = "0x1645240", Offset = "0x1643C40", VA = "0x181645240")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600068E")]
			[Cpp2IlInjected.Address(RVA = "0x7B3F4A0", Offset = "0x7B3DEA0", VA = "0x187B3F4A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		[BindableData(10, "In Transform Mode And Scale On", DataPermissions.ReadWrite)]
		public bool InTransformModeAndScaleOn
		{
			[Cpp2IlInjected.Token(Token = "0x600068F")]
			[Cpp2IlInjected.Address(RVA = "0x1645220", Offset = "0x1643C20", VA = "0x181645220")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000690")]
			[Cpp2IlInjected.Address(RVA = "0x7B3F500", Offset = "0x7B3DF00", VA = "0x187B3F500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		[BindableData(11, "Is Recolor Tool Currently Active", DataPermissions.ReadWrite)]
		public bool IsRecolorModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000691")]
			[Cpp2IlInjected.Address(RVA = "0x1D59AE0", Offset = "0x1D584E0", VA = "0x181D59AE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000692")]
			[Cpp2IlInjected.Address(RVA = "0x7B3F560", Offset = "0x7B3DF60", VA = "0x187B3F560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		[BindableData(12, "Is Transform Tool Active", DataPermissions.ReadWrite)]
		public bool IsPrecisionModifierModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000693")]
			[Cpp2IlInjected.Address(RVA = "0x1D59580", Offset = "0x1D57F80", VA = "0x181D59580")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000694")]
			[Cpp2IlInjected.Address(RVA = "0x7B3F5C0", Offset = "0x7B3DFC0", VA = "0x187B3F5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		[BindableData(14, "Show Edit Color Panel", DataPermissions.ReadOnly)]
		public bool ShowEditColorPanel
		{
			[Cpp2IlInjected.Token(Token = "0x6000696")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3B0", Offset = "0xA39DB0", VA = "0x180A3B3B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000697")]
			[Cpp2IlInjected.Address(RVA = "0x7B40920", Offset = "0x7B3F320", VA = "0x187B40920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		[BindableData(16, "Is Edit Color Panel Hidden When Recolor Mode is Active", DataPermissions.ReadWrite)]
		public bool IsEditColorPanelHiddenWhenRecolorModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000699")]
			[Cpp2IlInjected.Address(RVA = "0x2059080", Offset = "0x2057A80", VA = "0x182059080")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600069A")]
			[Cpp2IlInjected.Address(RVA = "0x7B3F680", Offset = "0x7B3E080", VA = "0x187B3F680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		[BindableData(18, "OnConfigMode", DataPermissions.ReadWrite)]
		public bool OnConfigMode
		{
			[Cpp2IlInjected.Token(Token = "0x600069C")]
			[Cpp2IlInjected.Address(RVA = "0x16B7270", Offset = "0x16B5C70", VA = "0x1816B7270")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600069D")]
			[Cpp2IlInjected.Address(RVA = "0x7B3F6E0", Offset = "0x7B3E0E0", VA = "0x187B3F6E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		[BindableData(19, "IsRRUIPageContainerEnabled", DataPermissions.ReadWrite)]
		public bool IsRRUIPageContainerEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600069E")]
			[Cpp2IlInjected.Address(RVA = "0x16B7280", Offset = "0x16B5C80", VA = "0x1816B7280")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600069F")]
			[Cpp2IlInjected.Address(RVA = "0x7B3F740", Offset = "0x7B3E140", VA = "0x187B3F740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		[BindableData(23, "ToolDescription", DataPermissions.ReadOnly)]
		public string ToolDescription
		{
			[Cpp2IlInjected.Token(Token = "0x60006A3")]
			[Cpp2IlInjected.Address(RVA = "0xA091A0", Offset = "0xA07BA0", VA = "0x180A091A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006A4")]
			[Cpp2IlInjected.Address(RVA = "0x7B40980", Offset = "0x7B3F380", VA = "0x187B40980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		[BindableData(24, "Is Adjust Mode Active", DataPermissions.ReadWrite)]
		public bool IsAdjustModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x60006A5")]
			[Cpp2IlInjected.Address(RVA = "0xD07DA0", Offset = "0xD067A0", VA = "0x180D07DA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006A6")]
			[Cpp2IlInjected.Address(RVA = "0x7B3F7A0", Offset = "0x7B3E1A0", VA = "0x187B3F7A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		[BindableData(25, "Show the Adjust button", DataPermissions.ReadWrite)]
		public bool ShowAdjustButton
		{
			[Cpp2IlInjected.Token(Token = "0x60006A7")]
			[Cpp2IlInjected.Address(RVA = "0xDD81E0", Offset = "0xDD6BE0", VA = "0x180DD81E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006A8")]
			[Cpp2IlInjected.Address(RVA = "0x7B3F800", Offset = "0x7B3E200", VA = "0x187B3F800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60006AB")]
			[Cpp2IlInjected.Address(RVA = "0x7B40830", Offset = "0x7B3F230", VA = "0x187B40830", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60006AC")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0x7B3EB90", Offset = "0x7B3D590", VA = "0x187B3EB90")]
		private void OnLeftNavInputStateChanged(MakerPenHUDNavigationInputState.NavInputState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x7B3ECF0", Offset = "0x7B3D6F0", VA = "0x187B3ECF0")]
		private void OnRightNavInputStateChanged(MakerPenHUDNavigationInputState.NavInputState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x7B3FA00", Offset = "0x7B3E400", VA = "0x187B3FA00")]
		private void UpdateInputState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0x7B3E620", Offset = "0x7B3D020", VA = "0x187B3E620")]
		private void OnCursorActiveChanged(bool active)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000680")]
		[Cpp2IlInjected.Address(RVA = "0x7B3BC60", Offset = "0x7B3A660", VA = "0x187B3BC60", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x7B3E6B0", Offset = "0x7B3D0B0", VA = "0x187B3E6B0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000682")]
		[Cpp2IlInjected.Address(RVA = "0x7B3EFC0", Offset = "0x7B3D9C0", VA = "0x187B3EFC0")]
		[BindableAction(1, "Press Clone button")]
		public void ToggleCloneMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0x7B3F080", Offset = "0x7B3DA80", VA = "0x187B3F080")]
		[BindableAction(2, "Press Move button")]
		public void ToggleMoveMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0x7B3F200", Offset = "0x7B3DC00", VA = "0x187B3F200")]
		[BindableAction(3, "Press Rotate button")]
		public void ToggleRotateMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x7B3F320", Offset = "0x7B3DD20", VA = "0x187B3F320")]
		[BindableAction(4, "Press Scale button")]
		public void ToggleScaleMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0x7B3C1D0", Offset = "0x7B3ABD0", VA = "0x187B3C1D0")]
		[BindableAction(5, "Press Delete button")]
		public void DeleteSelection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000695")]
		[Cpp2IlInjected.Address(RVA = "0x7B3F1A0", Offset = "0x7B3DBA0", VA = "0x187B3F1A0")]
		[BindableAction(13, "Press Recolor button")]
		public void ToggleRecolorMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x7B3C230", Offset = "0x7B3AC30", VA = "0x187B3C230")]
		[BindableAction(15, "Press Exit Recolor button")]
		public void ExitRecolorMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x7B3F020", Offset = "0x7B3DA20", VA = "0x187B3F020")]
		[BindableAction(17, "Press Config button")]
		public void ToggleConfigMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x7B3CF70", Offset = "0x7B3B970", VA = "0x187B3CF70")]
		[BindableAction(20, "Hide RRUI Page Container")]
		public void HideRRUIPageContainer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x7B3EF60", Offset = "0x7B3D960", VA = "0x187B3EF60")]
		[BindableAction(21, "Show RRUI Page Container")]
		public void ShowRRUIPageContainer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x7B3EF00", Offset = "0x7B3D900", VA = "0x187B3EF00")]
		[BindableAction(22, "Request Adjust Mode")]
		public void RequestAdjustMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x7B3FB70", Offset = "0x7B3E570", VA = "0x187B3FB70")]
		private void UpdateSelectModeContextualBarData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x7B3F9F0", Offset = "0x7B3E3F0", VA = "0x187B3F9F0")]
		private void UpdateColorPickerOpen(bool open)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AD")]
		[Cpp2IlInjected.Address(RVA = "0x7B3CFD0", Offset = "0x7B3B9D0", VA = "0x187B3CFD0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AE")]
		[Cpp2IlInjected.Address(RVA = "0x7B3C290", Offset = "0x7B3AC90", VA = "0x187B3C290")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006AF")]
		[Cpp2IlInjected.Address(RVA = "0x7B40130", Offset = "0x7B3EB30", VA = "0x187B40130")]
		public MakerPenHUDSelectToolbarViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[ViewModel]
	public class MakerPenHUDViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		[SerializeField]
		private FocusableUI focusable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private IRRUIvNextBridge rruiBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private bool leftModifierHeld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private bool hasFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private float holdInputProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private bool showHoldIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private bool undoModeFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private bool redoModeFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x83")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private bool selectModeFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private bool createModeFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private DataItem<bool> HasFocusDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private DataItem<float> HoldInputProgressDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private DataItem<bool> ShowHoldIndicatorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private DataItem<bool> IsUndoAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private DataItem<bool> IsRedoAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private DataItem<bool> UndoModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private DataItem<bool> RedoModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private DataItem<bool> OnSelectModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private DataItem<bool> OnCreateModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private DataItem<bool> SelectModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private DataItem<bool> CreateModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private DataItem<bool> IsCursorActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private DataItem<bool> IsInSubMenuDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private DataItemAction TriggerUndoDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private DataItemAction TriggerRedoDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private DataItemAction GoToSelectModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private DataItemAction GoToCreateModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private DataItemAction EndCursorDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		private bool shouldFocus
		{
			[Cpp2IlInjected.Token(Token = "0x60006D0")]
			[Cpp2IlInjected.Address(RVA = "0x7B4ABD0", Offset = "0x7B495D0", VA = "0x187B4ABD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		[BindableData(200, null, DataPermissions.ReadWrite)]
		public bool HasFocus
		{
			[Cpp2IlInjected.Token(Token = "0x60006D1")]
			[Cpp2IlInjected.Address(RVA = "0xFAFB40", Offset = "0xFAE540", VA = "0x180FAFB40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006D2")]
			[Cpp2IlInjected.Address(RVA = "0x7B4A230", Offset = "0x7B48C30", VA = "0x187B4A230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		[BindableData(201, null, DataPermissions.ReadWrite)]
		public float HoldInputProgress
		{
			[Cpp2IlInjected.Token(Token = "0x60006D3")]
			[Cpp2IlInjected.Address(RVA = "0x1883560", Offset = "0x1881F60", VA = "0x181883560")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60006D4")]
			[Cpp2IlInjected.Address(RVA = "0x7B4A290", Offset = "0x7B48C90", VA = "0x187B4A290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		[BindableData(202, null, DataPermissions.ReadWrite)]
		public bool ShowHoldIndicator
		{
			[Cpp2IlInjected.Token(Token = "0x60006D5")]
			[Cpp2IlInjected.Address(RVA = "0xC77AD0", Offset = "0xC764D0", VA = "0x180C77AD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006D6")]
			[Cpp2IlInjected.Address(RVA = "0x7B4A2F0", Offset = "0x7B48CF0", VA = "0x187B4A2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		[BindableData(7, "Is Undo Allowed", DataPermissions.ReadOnly)]
		public bool IsUndoAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x60006DE")]
			[Cpp2IlInjected.Address(RVA = "0x7B4A350", Offset = "0x7B48D50", VA = "0x187B4A350")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		[BindableData(8, "Is Redo Allowed", DataPermissions.ReadOnly)]
		public bool IsRedoAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x60006DF")]
			[Cpp2IlInjected.Address(RVA = "0x7B4A3B0", Offset = "0x7B48DB0", VA = "0x187B4A3B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		[BindableData(14, null, DataPermissions.ReadWrite)]
		public bool UndoModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60006E0")]
			[Cpp2IlInjected.Address(RVA = "0xEACA30", Offset = "0xEAB430", VA = "0x180EACA30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006E1")]
			[Cpp2IlInjected.Address(RVA = "0x7B4A410", Offset = "0x7B48E10", VA = "0x187B4A410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		[BindableData(15, null, DataPermissions.ReadWrite)]
		public bool RedoModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60006E2")]
			[Cpp2IlInjected.Address(RVA = "0xEACA40", Offset = "0xEAB440", VA = "0x180EACA40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006E3")]
			[Cpp2IlInjected.Address(RVA = "0x7B49FD0", Offset = "0x7B489D0", VA = "0x187B49FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		[BindableData(5, "OnSelectMode", DataPermissions.ReadOnly)]
		public bool OnSelectMode
		{
			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0x7B4A030", Offset = "0x7B48A30", VA = "0x187B4A030")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		[BindableData(6, "OnCreateMode", DataPermissions.ReadOnly)]
		public bool OnCreateMode
		{
			[Cpp2IlInjected.Token(Token = "0x60006E7")]
			[Cpp2IlInjected.Address(RVA = "0x7B4A080", Offset = "0x7B48A80", VA = "0x187B4A080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		[BindableData(12, null, DataPermissions.ReadWrite)]
		public bool SelectModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60006E8")]
			[Cpp2IlInjected.Address(RVA = "0x14B4B50", Offset = "0x14B3550", VA = "0x1814B4B50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006E9")]
			[Cpp2IlInjected.Address(RVA = "0x7B4A0D0", Offset = "0x7B48AD0", VA = "0x187B4A0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		[BindableData(13, null, DataPermissions.ReadWrite)]
		public bool CreateModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60006EA")]
			[Cpp2IlInjected.Address(RVA = "0xC6CA10", Offset = "0xC6B410", VA = "0x180C6CA10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006EB")]
			[Cpp2IlInjected.Address(RVA = "0x7B4A130", Offset = "0x7B48B30", VA = "0x187B4A130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		[BindableData(9, "Is Cursor Active", DataPermissions.ReadOnly)]
		public bool IsCursorActive
		{
			[Cpp2IlInjected.Token(Token = "0x60006ED")]
			[Cpp2IlInjected.Address(RVA = "0x7B4A190", Offset = "0x7B48B90", VA = "0x187B4A190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		[BindableData(11, "Is In Sub Menu", DataPermissions.ReadOnly)]
		public bool IsInSubMenu
		{
			[Cpp2IlInjected.Token(Token = "0x60006F0")]
			[Cpp2IlInjected.Address(RVA = "0x7B4A1E0", Offset = "0x7B48BE0", VA = "0x187B4A1E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60006F2")]
			[Cpp2IlInjected.Address(RVA = "0x7B4AB90", Offset = "0x7B49590", VA = "0x187B4AB90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60006F3")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0x7B49C60", Offset = "0x7B48660", VA = "0x187B49C60")]
		private void OnNavInputStateChanged(MakerPenHUDNavigationInputState.NavInputState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0x7B4A4C0", Offset = "0x7B48EC0", VA = "0x187B4A4C0")]
		private void UpdateInputState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0x7B47C80", Offset = "0x7B46680", VA = "0x187B47C80", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x7B49870", Offset = "0x7B48270", VA = "0x187B49870", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x7B49F80", Offset = "0x7B48980", VA = "0x187B49F80")]
		[BindableAction(3, "Press Undo button")]
		public void TriggerUndo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x7B49F30", Offset = "0x7B48930", VA = "0x187B49F30")]
		[BindableAction(4, "Press Redo button")]
		public void TriggerRedo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x7B4A690", Offset = "0x7B49090", VA = "0x187B4A690")]
		private void UpdateUndoStackData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x7B489F0", Offset = "0x7B473F0", VA = "0x187B489F0")]
		[BindableAction(1, "Press Select button")]
		public void GoToSelectMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E5")]
		[Cpp2IlInjected.Address(RVA = "0x7B489A0", Offset = "0x7B473A0", VA = "0x187B489A0")]
		[BindableAction(2, "Press Create button")]
		public void GoToCreateMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x7B49810", Offset = "0x7B48210", VA = "0x187B49810")]
		private void OnCurrentModeChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x7B4A470", Offset = "0x7B48E70", VA = "0x187B4A470")]
		private void UpdateCursorActive(bool isCursorActive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x7B480D0", Offset = "0x7B46AD0", VA = "0x187B480D0")]
		[BindableAction(10, "Button to request exiting cursor mode")]
		public void EndCursor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x7B4A650", Offset = "0x7B49050", VA = "0x187B4A650")]
		private void UpdateSubMenuActive(bool isInSubMenu)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x7B48A40", Offset = "0x7B47440", VA = "0x187B48A40", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x7B48120", Offset = "0x7B46B20", VA = "0x187B48120")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x7B4A6F0", Offset = "0x7B490F0", VA = "0x187B4A6F0")]
		public MakerPenHUDViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[ViewModel]
	public class NestedItem : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		[SerializeField]
		private NestedListConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private int absoluteIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private NestedListItem item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		private string text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private bool isExpanded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private Sprite activeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private int depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private DataItem<string> TextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private DataItem<bool> IsExpandedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private DataItem<Sprite> ActiveIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private DataItem<int> DepthDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private DataItemAction ToggleExpandedDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001B1")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x600070B")]
			[Cpp2IlInjected.Address(RVA = "0x7B4B9D0", Offset = "0x7B4A3D0", VA = "0x187B4B9D0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B2")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x600070C")]
			[Cpp2IlInjected.Address(RVA = "0xA092C0", Offset = "0xA07CC0", VA = "0x180A092C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600070D")]
			[Cpp2IlInjected.Address(RVA = "0x7B4B650", Offset = "0x7B4A050", VA = "0x187B4B650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool IsExpanded
		{
			[Cpp2IlInjected.Token(Token = "0x600070E")]
			[Cpp2IlInjected.Address(RVA = "0xC77AD0", Offset = "0xC764D0", VA = "0x180C77AD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x7B4B6C0", Offset = "0x7B4A0C0", VA = "0x187B4B6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public Sprite ActiveIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0xA09220", Offset = "0xA07C20", VA = "0x180A09220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x7B4BA50", Offset = "0x7B4A450", VA = "0x187B4BA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public int Depth
		{
			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0xA09270", Offset = "0xA07C70", VA = "0x180A09270")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x7B4B730", Offset = "0x7B4A130", VA = "0x187B4B730")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0x7B4B990", Offset = "0x7B4A390", VA = "0x187B4B990", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000717")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0x7B4B600", Offset = "0x7B4A000", VA = "0x187B4B600")]
		[BindableAction(2, null)]
		public void ToggleExpanded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0x7B4B460", Offset = "0x7B49E60", VA = "0x187B4B460")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x7B4AF60", Offset = "0x7B49960", VA = "0x187B4AF60", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x7B4AC90", Offset = "0x7B49690", VA = "0x187B4AC90")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4B790", Offset = "0x7B4A190", VA = "0x187B4B790")]
		public NestedItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[ViewModel]
	public class NestedList : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		[SerializeField]
		private NestedListConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private DataList<int> activeIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private DataItemList ActiveIndicesDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<int> ActiveIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0xA10530", Offset = "0xA0EF30", VA = "0x180A10530")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0x7B4C240", Offset = "0x7B4AC40", VA = "0x187B4C240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0x7B4C210", Offset = "0x7B4AC10", VA = "0x187B4C210", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x7B4BB00", Offset = "0x7B4A500", VA = "0x187B4BB00", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x7B4BEA0", Offset = "0x7B4A8A0", VA = "0x187B4BEA0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x7B4BFF0", Offset = "0x7B4A9F0", VA = "0x187B4BFF0")]
		private void OnIndexStateChanged(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4BD50", Offset = "0x7B4A750", VA = "0x187B4BD50", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4BC50", Offset = "0x7B4A650", VA = "0x187B4BC50")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x7B4C130", Offset = "0x7B4AB30", VA = "0x187B4C130")]
		public NestedList()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[ViewModel]
	public class OutfitListViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000AF")]
		[CompilerGenerated]
		private struct <FetchOutfitData>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004FD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004FE")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004FF")]
			public OutfitListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000500")]
			private TaskAwaiter<List<NCOIOOIHPIG>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000501")]
			private TaskAwaiter<RenderTexture> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000502")]
			private TaskAwaiter<int> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x600074A")]
			[Cpp2IlInjected.Address(RVA = "0x7B5FDE0", Offset = "0x7B5E7E0", VA = "0x187B5FDE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074B")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		[SerializeField]
		private int maxOutfitDisplayCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		[SerializeField]
		private bool generateOutfitTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		[SerializeField]
		private Route customizationRoute;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		[SerializeField]
		private int renderTextureWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		[SerializeField]
		private int renderTextureHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		[SerializeField]
		private DataResolver currentPanelResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private DataList<NCOIOOIHPIG> savedOutfitList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private bool isEmpty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private DataList<int> saveOutfitSlotList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private RenderTexture outfitTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private IOutfitDataManager outfitManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private string pageIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		private DataItem<bool> IsEmptyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private DataItem<RenderTexture> OutfitTextureDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private DataItemList SavedOutfitListDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private DataItemList SaveOutfitSlotListDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private DataItemAction OpenCustomizerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private DataItemAction OpenSavedOutfitsPageDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<NCOIOOIHPIG> SavedOutfitList
		{
			[Cpp2IlInjected.Token(Token = "0x600072F")]
			[Cpp2IlInjected.Address(RVA = "0xA09190", Offset = "0xA07B90", VA = "0x180A09190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000730")]
			[Cpp2IlInjected.Address(RVA = "0x7B4DC40", Offset = "0x7B4C640", VA = "0x187B4DC40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000731")]
			[Cpp2IlInjected.Address(RVA = "0xDA28A0", Offset = "0xDA12A0", VA = "0x180DA28A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000732")]
			[Cpp2IlInjected.Address(RVA = "0x7B4D560", Offset = "0x7B4BF60", VA = "0x187B4D560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public DataList<int> SaveOutfitSlotList
		{
			[Cpp2IlInjected.Token(Token = "0x6000733")]
			[Cpp2IlInjected.Address(RVA = "0xA6E210", Offset = "0xA6CC10", VA = "0x180A6E210")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000734")]
			[Cpp2IlInjected.Address(RVA = "0x7B4DBD0", Offset = "0x7B4C5D0", VA = "0x187B4DBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public RenderTexture OutfitTexture
		{
			[Cpp2IlInjected.Token(Token = "0x6000735")]
			[Cpp2IlInjected.Address(RVA = "0xA091A0", Offset = "0xA07BA0", VA = "0x180A091A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000736")]
			[Cpp2IlInjected.Address(RVA = "0x7B4DAB0", Offset = "0x7B4C4B0", VA = "0x187B4DAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x7B4DA70", Offset = "0x7B4C470", VA = "0x187B4DA70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x7B4D350", Offset = "0x7B4BD50", VA = "0x187B4D350")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x7B4CEA0", Offset = "0x7B4B8A0", VA = "0x187B4CEA0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x7B4CC00", Offset = "0x7B4B600", VA = "0x187B4CC00")]
		private void OnActivePanelChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4C2A0", Offset = "0x7B4ACA0", VA = "0x187B4C2A0")]
		[AsyncStateMachine(typeof(<FetchOutfitData>d__28))]
		private void FetchOutfitData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x7B4D100", Offset = "0x7B4BB00", VA = "0x187B4D100")]
		[BindableAction(100, null)]
		private void OpenCustomizer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073C")]
		[Cpp2IlInjected.Address(RVA = "0x7B4D230", Offset = "0x7B4BC30", VA = "0x187B4D230")]
		[BindableAction(101, null)]
		private void OpenSavedOutfitsPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073F")]
		[Cpp2IlInjected.Address(RVA = "0x7B4C690", Offset = "0x7B4B090", VA = "0x187B4C690", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x7B4C350", Offset = "0x7B4AD50", VA = "0x187B4C350")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x7B4D770", Offset = "0x7B4C170", VA = "0x187B4D770")]
		public OutfitListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[ViewModel]
	public class OutfitViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		private string outfitThumbnailName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		private bool wearingOutfit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		private IOutfitDataManager outfitManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		private NCOIOOIHPIG savedOutfitData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private DataItem<string> OutfitThumbnailNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private DataItem<bool> WearingOutfitDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private DataItemAction ChangeOutfitDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string OutfitThumbnailName
		{
			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0xA10520", Offset = "0xA0EF20", VA = "0x180A10520")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0x7B4E710", Offset = "0x7B4D110", VA = "0x187B4E710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool WearingOutfit
		{
			[Cpp2IlInjected.Token(Token = "0x600074E")]
			[Cpp2IlInjected.Address(RVA = "0xBD1230", Offset = "0xBCFC30", VA = "0x180BD1230")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600074F")]
			[Cpp2IlInjected.Address(RVA = "0x7B4E780", Offset = "0x7B4D180", VA = "0x187B4E780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000750")]
			[Cpp2IlInjected.Address(RVA = "0x7B4E970", Offset = "0x7B4D370", VA = "0x187B4E970", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x7B4E930", Offset = "0x7B4D330", VA = "0x187B4E930", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000755")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000751")]
		[Cpp2IlInjected.Address(RVA = "0x7B4E650", Offset = "0x7B4D050", VA = "0x187B4E650")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000752")]
		[Cpp2IlInjected.Address(RVA = "0x7B4E2D0", Offset = "0x7B4CCD0", VA = "0x187B4E2D0")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000753")]
		[Cpp2IlInjected.Address(RVA = "0x7B4DCB0", Offset = "0x7B4C6B0", VA = "0x187B4DCB0")]
		[BindableAction(100, null)]
		private void ChangeOutfit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000756")]
		[Cpp2IlInjected.Address(RVA = "0x7B4DFD0", Offset = "0x7B4C9D0", VA = "0x187B4DFD0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x7B4DDE0", Offset = "0x7B4C7E0", VA = "0x187B4DDE0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0x7B4E7E0", Offset = "0x7B4D1E0", VA = "0x187B4E7E0")]
		public OutfitViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[ViewModel]
	public class SaveOutfitButtonViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private IOutfitDataManager outfitManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private int slotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		private DataItem<int> SlotIndexDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		private DataItemAction SaveOutfitDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0x7B591B0", Offset = "0x7B57BB0", VA = "0x187B591B0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public int SlotIndex
		{
			[Cpp2IlInjected.Token(Token = "0x600075E")]
			[Cpp2IlInjected.Address(RVA = "0xFA0640", Offset = "0xF9F040", VA = "0x180FA0640")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x7B59060", Offset = "0x7B57A60", VA = "0x187B59060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0x7B59180", Offset = "0x7B57B80", VA = "0x187B59180", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000760")]
		[Cpp2IlInjected.Address(RVA = "0x7B58F30", Offset = "0x7B57930", VA = "0x187B58F30")]
		[BindableAction(100, null)]
		public void SaveOutfit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000761")]
		[Cpp2IlInjected.Address(RVA = "0x7B58A10", Offset = "0x7B57410", VA = "0x187B58A10", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0x7B58E40", Offset = "0x7B57840", VA = "0x187B58E40")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0x7B58C40", Offset = "0x7B57640", VA = "0x187B58C40", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0x7B58AD0", Offset = "0x7B574D0", VA = "0x187B58AD0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0x7B590B0", Offset = "0x7B57AB0", VA = "0x187B590B0")]
		public SaveOutfitButtonViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[ViewModel]
	public class RoomCategoryListViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		public enum Sources
		{
			[Cpp2IlInjected.Token(Token = "0x400051D")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400051E")]
			PageSource,
			[Cpp2IlInjected.Token(Token = "0x400051F")]
			CuratedList
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000B4")]
		[CompilerGenerated]
		private struct <FetchData>d__25 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000520")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000521")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000522")]
			public RoomCategoryListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000523")]
			private TaskAwaiter<(IReadOnlyList<EGFEGFNEHOL> categories, string displayName)> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000524")]
			private TaskAwaiter<IReadOnlyList<EGFEGFNEHOL>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600077F")]
			[Cpp2IlInjected.Address(RVA = "0x7B5EF40", Offset = "0x7B5D940", VA = "0x187B5EF40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000780")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		[SerializeField]
		private LNNILEGHPHJ loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		[SerializeField]
		private Sources source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		[SerializeField]
		private string sourceMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private string _discoverySectionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private IRRUIvNextRoomCategoryBridge roomCategoryBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private DataList<EGFEGFNEHOL> roomCategoryList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private DataItemList RoomCategoryListDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		public LNNILEGHPHJ LoadSceneSource
		{
			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(RVA = "0x7B4FEE0", Offset = "0x7B4E8E0", VA = "0x187B4FEE0")]
			get
			{
				return default(LNNILEGHPHJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		public BrowserModel BrowserModel
		{
			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0x7B4FDF0", Offset = "0x7B4E7F0", VA = "0x187B4FDF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		public string DiscoverySectionId
		{
			[Cpp2IlInjected.Token(Token = "0x600076C")]
			[Cpp2IlInjected.Address(RVA = "0xA17C00", Offset = "0xA16600", VA = "0x180A17C00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600076D")]
			[Cpp2IlInjected.Address(RVA = "0x7B4FEF0", Offset = "0x7B4E8F0", VA = "0x187B4FEF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<EGFEGFNEHOL> RoomCategoryList
		{
			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0xA6E210", Offset = "0xA6CC10", VA = "0x180A6E210")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600076F")]
			[Cpp2IlInjected.Address(RVA = "0x7B50020", Offset = "0x7B4EA20", VA = "0x187B50020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000770")]
			[Cpp2IlInjected.Address(RVA = "0xA091A0", Offset = "0xA07BA0", VA = "0x180A091A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000771")]
			[Cpp2IlInjected.Address(RVA = "0x7B4FFA0", Offset = "0x7B4E9A0", VA = "0x187B4FFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(RVA = "0x7B4FEA0", Offset = "0x7B4E8A0", VA = "0x187B4FEA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F7B0", Offset = "0x7B4E1B0", VA = "0x187B4F7B0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F870", Offset = "0x7B4E270", VA = "0x187B4F870")]
		public void SetSourceData(string source, string sourceMetadata)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F320", Offset = "0x7B4DD20", VA = "0x187B4F320")]
		[AsyncStateMachine(typeof(<FetchData>d__25))]
		public void FetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F910", Offset = "0x7B4E310", VA = "0x187B4F910")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F550", Offset = "0x7B4DF50", VA = "0x187B4F550", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F3D0", Offset = "0x7B4DDD0", VA = "0x187B4F3D0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4FC80", Offset = "0x7B4E680", VA = "0x187B4FC80")]
		public RoomCategoryListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[ViewModel]
	public class RoomCategoryViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		[SerializeField]
		private Route searchRoomsroute;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		[SerializeField]
		private Route gridViewRoute;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private IRRUIvNextRoomCategoryBridge roomCategoryBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private LNNILEGHPHJ loadSceneSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private EGFEGFNEHOL roomCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private DataItem<string> ImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private DataItemAction SelectRoomCategoryDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000781")]
			[Cpp2IlInjected.Address(RVA = "0x7B50E20", Offset = "0x7B4F820", VA = "0x187B50E20", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000782")]
			[Cpp2IlInjected.Address(RVA = "0xA6E210", Offset = "0xA6CC10", VA = "0x180A6E210")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000783")]
			[Cpp2IlInjected.Address(RVA = "0x7B50EA0", Offset = "0x7B4F8A0", VA = "0x187B50EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000784")]
			[Cpp2IlInjected.Address(RVA = "0xA091A0", Offset = "0xA07BA0", VA = "0x180A091A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000785")]
			[Cpp2IlInjected.Address(RVA = "0x7B50F20", Offset = "0x7B4F920", VA = "0x187B50F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0x7B50DE0", Offset = "0x7B4F7E0", VA = "0x187B50DE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x7B507A0", Offset = "0x7B4F1A0", VA = "0x187B507A0")]
		[BindableAction(100, null)]
		public void SelectRoomCategory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x7B50090", Offset = "0x7B4EA90", VA = "0x187B50090", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x7B50680", Offset = "0x7B4F080", VA = "0x187B50680")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x7B50930", Offset = "0x7B4F330", VA = "0x187B50930")]
		private void Set(EGFEGFNEHOL data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x7B50B70", Offset = "0x7B4F570", VA = "0x187B50B70")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078D")]
		[Cpp2IlInjected.Address(RVA = "0x7B503A0", Offset = "0x7B4EDA0", VA = "0x187B503A0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078E")]
		[Cpp2IlInjected.Address(RVA = "0x7B501B0", Offset = "0x7B4EBB0", VA = "0x187B501B0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078F")]
		[Cpp2IlInjected.Address(RVA = "0x7B50C80", Offset = "0x7B4F680", VA = "0x187B50C80")]
		public RoomCategoryViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public class RoomCardFeatureHelper : BaseBindableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		private LADHLOMPOJA loadSceneSourceData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private bool showCCUCounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private int pinnedRoomCCUThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private bool showPopularBadge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private int popularRoomCCUThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private bool showNewBadge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private bool showPlayActionButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA2")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private bool showMoreLikeThisButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA3")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private bool showUpdateToPlayIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private bool showUpdateToPlayText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA5")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private bool showNewThisSessionForSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private string sessionSectionIdOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private Guid? sectionSpawnInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private string parentTabName;

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		public LADHLOMPOJA LoadSceneSourceData
		{
			[Cpp2IlInjected.Token(Token = "0x6000794")]
			[Cpp2IlInjected.Address(RVA = "0x7B4ED70", Offset = "0x7B4D770", VA = "0x187B4ED70")]
			get
			{
				return default(LADHLOMPOJA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000795")]
			[Cpp2IlInjected.Address(RVA = "0x7B4EDB0", Offset = "0x7B4D7B0", VA = "0x187B4EDB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		public bool ShowCCUCounts
		{
			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3B0", Offset = "0xA39DB0", VA = "0x180A3B3B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(RVA = "0x7B4F080", Offset = "0x7B4DA80", VA = "0x187B4F080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		public bool ShowPopularBadge
		{
			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0xED7630", Offset = "0xED6030", VA = "0x180ED7630")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0x7B4F200", Offset = "0x7B4DC00", VA = "0x187B4F200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		public int PopularRoomCCUThreshold
		{
			[Cpp2IlInjected.Token(Token = "0x600079A")]
			[Cpp2IlInjected.Address(RVA = "0xE49110", Offset = "0xE47B10", VA = "0x180E49110")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600079B")]
			[Cpp2IlInjected.Address(RVA = "0x7B4EEC0", Offset = "0x7B4D8C0", VA = "0x187B4EEC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		public bool ShowNewBadge
		{
			[Cpp2IlInjected.Token(Token = "0x600079C")]
			[Cpp2IlInjected.Address(RVA = "0xD07DA0", Offset = "0xD067A0", VA = "0x180D07DA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600079D")]
			[Cpp2IlInjected.Address(RVA = "0x7B4F0E0", Offset = "0x7B4DAE0", VA = "0x187B4F0E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		public bool ShowPlayActionButton
		{
			[Cpp2IlInjected.Token(Token = "0x600079E")]
			[Cpp2IlInjected.Address(RVA = "0xDD81E0", Offset = "0xDD6BE0", VA = "0x180DD81E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600079F")]
			[Cpp2IlInjected.Address(RVA = "0x7B4F1A0", Offset = "0x7B4DBA0", VA = "0x187B4F1A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		public bool ShowMoreLikeThisButton
		{
			[Cpp2IlInjected.Token(Token = "0x60007A0")]
			[Cpp2IlInjected.Address(RVA = "0x7212E60", Offset = "0x7211860", VA = "0x187212E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		public bool ShowUpdateToPlayIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60007A1")]
			[Cpp2IlInjected.Address(RVA = "0x7AF9440", Offset = "0x7AF7E40", VA = "0x187AF9440")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x7B4F260", Offset = "0x7B4DC60", VA = "0x187B4F260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		public bool ShowUpdateToPlayText
		{
			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0xF0E380", Offset = "0xF0CD80", VA = "0x180F0E380")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0x7B4F2C0", Offset = "0x7B4DCC0", VA = "0x187B4F2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		public bool ShowNewThisSessionForSection
		{
			[Cpp2IlInjected.Token(Token = "0x60007A5")]
			[Cpp2IlInjected.Address(RVA = "0x18B1D20", Offset = "0x18B0720", VA = "0x1818B1D20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007A6")]
			[Cpp2IlInjected.Address(RVA = "0x7B4F140", Offset = "0x7B4DB40", VA = "0x187B4F140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		public string SessionSectionIdOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60007A7")]
			[Cpp2IlInjected.Address(RVA = "0xA0D3B0", Offset = "0xA0BDB0", VA = "0x180A0D3B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007A8")]
			[Cpp2IlInjected.Address(RVA = "0x7B4F000", Offset = "0x7B4DA00", VA = "0x187B4F000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		public Guid? SectionSpawnInstanceId
		{
			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0xA0D400", Offset = "0xA0BE00", VA = "0x180A0D400")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0x7B4EF20", Offset = "0x7B4D920", VA = "0x187B4EF20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		public string ParentTabName
		{
			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0xA86FD0", Offset = "0xA859D0", VA = "0x180A86FD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0x7B4EE40", Offset = "0x7B4D840", VA = "0x187B4EE40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007AD")]
		[Cpp2IlInjected.Address(RVA = "0x7B4ED50", Offset = "0x7B4D750", VA = "0x187B4ED50")]
		public RoomCardFeatureHelper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[ViewModel]
	public class RoomListViewModel : RRUIBaseLocalViewModel, IOrderedRenderable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000B8")]
		[CompilerGenerated]
		private struct <FetchData>d__52 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000557")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000558")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000559")]
			public RoomListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400055A")]
			private TaskAwaiter<List<MNEFCBHAIEP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60007DB")]
			[Cpp2IlInjected.Address(RVA = "0x7B5F520", Offset = "0x7B5DF20", VA = "0x187B5F520", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007DC")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		[SerializeField]
		private RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		[SerializeField]
		private bool overrideLoadSceneSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000542")]
		[SerializeField]
		private LNNILEGHPHJ loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private IRoomQueryManager roomListQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private bool waitingForQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private List<long> tempIdList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private int minItemCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private bool fetchCCUCounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private DataList<long> roomIdList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private string listDisplayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private bool isEmptyOrBelowMinimum;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private RoomCardFeatureHelper featureHelper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private DataItem<string> ListDisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private DataItem<bool> IsEmptyOrBelowMinimumDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private DataItem<RoomListQueryData> QueryDataDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private DataItem<RoomCardFeatureHelper> FeatureHelperDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private DataItemList RoomIdListDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<long> RoomIdList
		{
			[Cpp2IlInjected.Token(Token = "0x60007AE")]
			[Cpp2IlInjected.Address(RVA = "0xA6E630", Offset = "0xA6D030", VA = "0x180A6E630")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007AF")]
			[Cpp2IlInjected.Address(RVA = "0x7B533D0", Offset = "0x7B51DD0", VA = "0x187B533D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		[BindableData(1, "The name of the list that can be shown on the UI, e.g. as a carousel title", DataPermissions.ReadWrite)]
		public string ListDisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60007B0")]
			[Cpp2IlInjected.Address(RVA = "0xA0D3B0", Offset = "0xA0BDB0", VA = "0x180A0D3B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007B1")]
			[Cpp2IlInjected.Address(RVA = "0x7B53350", Offset = "0x7B51D50", VA = "0x187B53350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public bool IsEmptyOrBelowMinimum
		{
			[Cpp2IlInjected.Token(Token = "0x60007B2")]
			[Cpp2IlInjected.Address(RVA = "0xA6E220", Offset = "0xA6CC20", VA = "0x180A6E220")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007B3")]
			[Cpp2IlInjected.Address(RVA = "0x7B52E40", Offset = "0x7B51840", VA = "0x187B52E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		[BindableData(3, "The query data used to retrieve the room list", DataPermissions.ReadOnly)]
		public RoomListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x60007B4")]
			[Cpp2IlInjected.Address(RVA = "0xA10530", Offset = "0xA0EF30", VA = "0x180A10530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public RoomCardFeatureHelper FeatureHelper
		{
			[Cpp2IlInjected.Token(Token = "0x60007B5")]
			[Cpp2IlInjected.Address(RVA = "0xAB9040", Offset = "0xAB7A40", VA = "0x180AB9040")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0x7B52EA0", Offset = "0x7B518A0", VA = "0x187B52EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		public bool RenderInCarouselOrder
		{
			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0xF9E1F0", Offset = "0xF9CBF0", VA = "0x180F9E1F0", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0xC65AC0", Offset = "0xC644C0", VA = "0x180C65AC0", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		public bool AllowRender
		{
			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0xF9F7D0", Offset = "0xF9E1D0", VA = "0x180F9F7D0", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0xC65AD0", Offset = "0xC644D0", VA = "0x180C65AD0", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		public bool HasRefreshed
		{
			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0x2063CC0", Offset = "0x20626C0", VA = "0x182063CC0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0xC65AE0", Offset = "0xC644E0", VA = "0x180C65AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		public bool RequiresRefresh
		{
			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0x2063890", Offset = "0x2062290", VA = "0x182063890", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x20612C0", Offset = "0x205FCC0", VA = "0x1820612C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		public bool OverrideLoadSceneSource
		{
			[Cpp2IlInjected.Token(Token = "0x60007BF")]
			[Cpp2IlInjected.Address(RVA = "0xDC95A0", Offset = "0xDC7FA0", VA = "0x180DC95A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		public LNNILEGHPHJ LoadSceneSourceOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60007C0")]
			[Cpp2IlInjected.Address(RVA = "0xA32150", Offset = "0xA30B50", VA = "0x180A32150")]
			get
			{
				return default(LNNILEGHPHJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60007CD")]
			[Cpp2IlInjected.Address(RVA = "0x7B53310", Offset = "0x7B51D10", VA = "0x187B53310", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60007CE")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x7B52C90", Offset = "0x7B51690", VA = "0x187B52C90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x7B51A00", Offset = "0x7B50400", VA = "0x187B51A00", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x7B524F0", Offset = "0x7B50EF0", VA = "0x187B524F0")]
		public void SetQueryData(RoomListQueryData listQueryData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x7B523B0", Offset = "0x7B50DB0", VA = "0x187B523B0")]
		public void SetDiscoverySectionId(string sectionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x7B50FA0", Offset = "0x7B4F9A0", VA = "0x187B50FA0")]
		[AsyncStateMachine(typeof(<FetchData>d__52))]
		public void FetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x7B52460", Offset = "0x7B50E60", VA = "0x187B52460")]
		public void SetMaxItems(int maxItemsToFetch, int maxItemsToDisplay)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0x7B524C0", Offset = "0x7B50EC0", VA = "0x187B524C0")]
		public void SetMinItems(int minItems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0x7B51BB0", Offset = "0x7B505B0", VA = "0x187B51BB0")]
		private void PopulateLoadSceneSourceData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C9")]
		[Cpp2IlInjected.Address(RVA = "0x7B52140", Offset = "0x7B50B40", VA = "0x187B52140")]
		private string ResolveDisplayName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0xF9F7D0", Offset = "0xF9E1D0", VA = "0x180F9F7D0")]
		private bool WaitUntilAllowRender()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0x7B525B0", Offset = "0x7B50FB0", VA = "0x187B525B0")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0x7B518D0", Offset = "0x7B502D0", VA = "0x187B518D0")]
		private void OnChildImpressionTrackerAdded(ImpressionTracker child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CF")]
		[Cpp2IlInjected.Address(RVA = "0x7B51320", Offset = "0x7B4FD20", VA = "0x187B51320", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D0")]
		[Cpp2IlInjected.Address(RVA = "0x7B51050", Offset = "0x7B4FA50", VA = "0x187B51050")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D1")]
		[Cpp2IlInjected.Address(RVA = "0x7B52FE0", Offset = "0x7B519E0", VA = "0x187B52FE0")]
		public RoomListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[ViewModel]
	public class RoomViewModel : RRUIBaseLocalViewModel, ILoadable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		[CompilerGenerated]
		private struct <FetchRoomData>d__120 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400059D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400059E")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400059F")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005A0")]
			private TaskAwaiter<MNEFCBHAIEP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000850")]
			[Cpp2IlInjected.Address(RVA = "0x7B608D0", Offset = "0x7B5F2D0", VA = "0x187B608D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000851")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000BB")]
		[CompilerGenerated]
		private struct <DoPlayAction>d__126 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005A1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005A2")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005A3")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005A4")]
			private PFLGPOLCCPC <details>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005A5")]
			private bool <canChooseSubroom>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005A6")]
			private TaskAwaiter<PFLGPOLCCPC> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005A7")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000852")]
			[Cpp2IlInjected.Address(RVA = "0x7B5E700", Offset = "0x7B5D100", VA = "0x187B5E700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000853")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		[CompilerGenerated]
		private struct <CreateOrJoinRoomInstance>d__127 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005AD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005AE")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005AF")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005B0")]
			public PFLGPOLCCPC roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005B1")]
			public bool privateInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x40005B2")]
			public bool canChooseSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
			[Cpp2IlInjected.Token(Token = "0x40005B3")]
			public bool randomSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005B4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000856")]
			[Cpp2IlInjected.Address(RVA = "0x7B5E170", Offset = "0x7B5CB70", VA = "0x187B5E170", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000857")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BE")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass128_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005B5")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005B6")]
			public PFLGPOLCCPC roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40005B7")]
			public BBAIIGBMJIM subRoom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005B8")]
			public bool privateInstance;

			[Cpp2IlInjected.Token(Token = "0x6000858")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public <>c__DisplayClass128_0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000859")]
			[Cpp2IlInjected.Address(RVA = "0x7B61F00", Offset = "0x7B60900", VA = "0x187B61F00")]
			internal void <PlayAction_TryGoToRoom>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BF")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass128_1
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40005B9")]
			public KNOKFGDBNBL latestValidSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40005BA")]
			public <>c__DisplayClass128_0 CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x600085A")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public <>c__DisplayClass128_1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600085B")]
			[Cpp2IlInjected.Address(RVA = "0x7B61FF0", Offset = "0x7B609F0", VA = "0x187B61FF0")]
			internal void <PlayAction_TryGoToRoom>b__1()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000C0")]
		[CompilerGenerated]
		private struct <PlayAction_TryGoToRoom>d__128 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005BB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005BC")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005BD")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005BE")]
			public PFLGPOLCCPC roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005BF")]
			public bool privateInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x40005C0")]
			public bool randomSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
			[Cpp2IlInjected.Token(Token = "0x40005C1")]
			public bool canChooseSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005C2")]
			private <>c__DisplayClass128_0 <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40005C3")]
			private <>c__DisplayClass128_1 <>8__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40005C4")]
			private TaskAwaiter<BBAIIGBMJIM> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40005C5")]
			private IRoomSaveManager <saveManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40005C6")]
			private TaskAwaiter<KNOKFGDBNBL> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600085C")]
			[Cpp2IlInjected.Address(RVA = "0x7B60C40", Offset = "0x7B5F640", VA = "0x187B60C40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600085D")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private const string CCUCountKey = "CCU_COUNT";

		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private const char tokenDelimiter = '.';

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		[SerializeField]
		private DataResolver featureHelperResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private IRoomQueryManager roomQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private IRoomLoadManager roomLoadManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private IRRUIvNextUIDataBridge vNextDataBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private LADHLOMPOJA loadSceneSourceData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private DialogListModel dialogListModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private int cheerCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private int ccuCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private bool shouldFetchCCUCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private DateTime? lastPublished;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private bool hasSufficientVersionToLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private bool favorited;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private string cheerCountString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private bool isRooms2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private bool showCheerCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private string ccuCountString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private bool supportsPlayAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x171")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private bool supportsMoreLikeThis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x172")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private bool isPopularRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x173")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private bool isNewlyPublished;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x4000577")]
		private bool showCCUCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x175")]
		[Cpp2IlInjected.Token(Token = "0x4000578")]
		private bool supportsDataTokens;

		[Cpp2IlInjected.FieldOffset(Offset = "0x176")]
		[Cpp2IlInjected.Token(Token = "0x4000579")]
		private bool showCheerToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x177")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		private bool requiresUpdateToPlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private bool showUpdateToPlayIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x179")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private bool showUpdateToPlayText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17A")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private bool showNewThisSessionForSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17B")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private bool showRooms2Badge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private LCAFLPPAOEN publishState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private bool showPublishState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private DataItem<long> RoomIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private DataItem<string> DescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private DataItem<string> ImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private DataItem<bool> FavoritedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private DataItem<string> CheerCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private DataItem<bool> IsRooms2DataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private DataItem<bool> ShowCheerCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private DataItem<string> CCUCountStringDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private DataItem<bool> SupportsPlayActionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private DataItem<bool> SupportsMoreLikeThisDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private DataItem<bool> IsPopularRoomDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private DataItem<bool> IsNewlyPublishedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		private DataItem<bool> ShowCCUCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private DataItem<bool> SupportsDataTokensDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private DataItem<bool> ShowCheerTokenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private DataItem<bool> RequiresUpdateToPlayDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private DataItem<bool> ShowUpdateToPlayIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private DataItem<bool> ShowUpdateToPlayTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private DataItem<bool> ShowNewThisSessionForSectionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private DataItem<bool> ShowRooms2BadgeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private DataItem<LCAFLPPAOEN> PublishStateDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private DataItem<bool> ShowPublishStateDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private DataItemAction OpenRoomDetailsPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private DataItemAction DoPlayActionDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		[BindableData(0, "The ID used to retrieve the room data from RecNet", DataPermissions.ReadWrite)]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60007DD")]
			[Cpp2IlInjected.Address(RVA = "0xAAE6E0", Offset = "0xAAD0E0", VA = "0x180AAE6E0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60007DE")]
			[Cpp2IlInjected.Address(RVA = "0x7B58910", Offset = "0x7B57310", VA = "0x187B58910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		[BindableData(1, "The sanitized, friendly name of the room", DataPermissions.ReadOnly)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60007DF")]
			[Cpp2IlInjected.Address(RVA = "0xB2BA50", Offset = "0xB2A450", VA = "0x180B2BA50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007E0")]
			[Cpp2IlInjected.Address(RVA = "0x7B58800", Offset = "0x7B57200", VA = "0x187B58800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		[BindableData(2, null, DataPermissions.ReadOnly)]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60007E1")]
			[Cpp2IlInjected.Address(RVA = "0xB2C1A0", Offset = "0xB2ABA0", VA = "0x180B2C1A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0x7B58780", Offset = "0x7B57180", VA = "0x187B58780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0xB302E0", Offset = "0xB2ECE0", VA = "0x180B302E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0x7B58880", Offset = "0x7B57280", VA = "0x187B58880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool Favorited
		{
			[Cpp2IlInjected.Token(Token = "0x60007E5")]
			[Cpp2IlInjected.Address(RVA = "0xB346C0", Offset = "0xB330C0", VA = "0x180B346C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E6")]
			[Cpp2IlInjected.Address(RVA = "0x7B57100", Offset = "0x7B55B00", VA = "0x187B57100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public string CheerCount
		{
			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0xB2C5B0", Offset = "0xB2AFB0", VA = "0x180B2C5B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0x7B58700", Offset = "0x7B57100", VA = "0x187B58700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool IsRooms2
		{
			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0x1D784F0", Offset = "0x1D76EF0", VA = "0x181D784F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007EA")]
			[Cpp2IlInjected.Address(RVA = "0x7B56A50", Offset = "0x7B55450", VA = "0x187B56A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		[BindableData(7, null, DataPermissions.ReadWrite)]
		public bool ShowCheerCount
		{
			[Cpp2IlInjected.Token(Token = "0x60007EB")]
			[Cpp2IlInjected.Address(RVA = "0x1D784E0", Offset = "0x1D76EE0", VA = "0x181D784E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007EC")]
			[Cpp2IlInjected.Address(RVA = "0x7B56AB0", Offset = "0x7B554B0", VA = "0x187B56AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		[BindableData(8, null, DataPermissions.ReadWrite)]
		public string CCUCountString
		{
			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0xB36270", Offset = "0xB34C70", VA = "0x180B36270")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007EE")]
			[Cpp2IlInjected.Address(RVA = "0x7B58680", Offset = "0x7B57080", VA = "0x187B58680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		[BindableData(9, null, DataPermissions.ReadWrite)]
		public bool SupportsPlayAction
		{
			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0xB356B0", Offset = "0xB340B0", VA = "0x180B356B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x7B56B20", Offset = "0x7B55520", VA = "0x187B56B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		[BindableData(10, null, DataPermissions.ReadWrite)]
		public bool SupportsMoreLikeThis
		{
			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0xB5E590", Offset = "0xB5CF90", VA = "0x180B5E590")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0x7B56B80", Offset = "0x7B55580", VA = "0x187B56B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		[BindableData(11, null, DataPermissions.ReadWrite)]
		public bool IsPopularRoom
		{
			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x7B56BF0", Offset = "0x7B555F0", VA = "0x187B56BF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x7B56C00", Offset = "0x7B55600", VA = "0x187B56C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		[BindableData(12, null, DataPermissions.ReadWrite)]
		public bool IsNewlyPublished
		{
			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0xF9FD60", Offset = "0xF9E760", VA = "0x180F9FD60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x7B56C60", Offset = "0x7B55660", VA = "0x187B56C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		[BindableData(13, null, DataPermissions.ReadWrite)]
		public bool ShowCCUCount
		{
			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0x7B56CC0", Offset = "0x7B556C0", VA = "0x187B56CC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x7B56CD0", Offset = "0x7B556D0", VA = "0x187B56CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		[BindableData(14, null, DataPermissions.ReadWrite)]
		public bool SupportsDataTokens
		{
			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0x7B56D30", Offset = "0x7B55730", VA = "0x187B56D30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007FA")]
			[Cpp2IlInjected.Address(RVA = "0x7B56D40", Offset = "0x7B55740", VA = "0x187B56D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FF")]
		[BindableData(15, null, DataPermissions.ReadWrite)]
		public bool ShowCheerToken
		{
			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x7B56DA0", Offset = "0x7B557A0", VA = "0x187B56DA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007FC")]
			[Cpp2IlInjected.Address(RVA = "0x7B56DB0", Offset = "0x7B557B0", VA = "0x187B56DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000200")]
		[BindableData(16, null, DataPermissions.ReadWrite)]
		public bool RequiresUpdateToPlay
		{
			[Cpp2IlInjected.Token(Token = "0x60007FD")]
			[Cpp2IlInjected.Address(RVA = "0x7B56E10", Offset = "0x7B55810", VA = "0x187B56E10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007FE")]
			[Cpp2IlInjected.Address(RVA = "0x7B56E20", Offset = "0x7B55820", VA = "0x187B56E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000201")]
		[BindableData(17, null, DataPermissions.ReadWrite)]
		public bool ShowUpdateToPlayIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60007FF")]
			[Cpp2IlInjected.Address(RVA = "0xAA4560", Offset = "0xAA2F60", VA = "0x180AA4560")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000800")]
			[Cpp2IlInjected.Address(RVA = "0x7B56E80", Offset = "0x7B55880", VA = "0x187B56E80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000202")]
		[BindableData(18, null, DataPermissions.ReadWrite)]
		public bool ShowUpdateToPlayText
		{
			[Cpp2IlInjected.Token(Token = "0x6000801")]
			[Cpp2IlInjected.Address(RVA = "0x7B56EE0", Offset = "0x7B558E0", VA = "0x187B56EE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000802")]
			[Cpp2IlInjected.Address(RVA = "0x7B56EF0", Offset = "0x7B558F0", VA = "0x187B56EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		[BindableData(19, null, DataPermissions.ReadWrite)]
		public bool ShowNewThisSessionForSection
		{
			[Cpp2IlInjected.Token(Token = "0x6000803")]
			[Cpp2IlInjected.Address(RVA = "0x7B56F50", Offset = "0x7B55950", VA = "0x187B56F50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000804")]
			[Cpp2IlInjected.Address(RVA = "0x7B56F60", Offset = "0x7B55960", VA = "0x187B56F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000204")]
		[BindableData(20, null, DataPermissions.ReadWrite)]
		public bool ShowRooms2Badge
		{
			[Cpp2IlInjected.Token(Token = "0x6000805")]
			[Cpp2IlInjected.Address(RVA = "0x7B56FC0", Offset = "0x7B559C0", VA = "0x187B56FC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000806")]
			[Cpp2IlInjected.Address(RVA = "0x7B56FD0", Offset = "0x7B559D0", VA = "0x187B56FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000205")]
		[BindableData(21, null, DataPermissions.ReadWrite)]
		public LCAFLPPAOEN PublishState
		{
			[Cpp2IlInjected.Token(Token = "0x6000807")]
			[Cpp2IlInjected.Address(RVA = "0xA76210", Offset = "0xA74C10", VA = "0x180A76210")]
			get
			{
				return default(LCAFLPPAOEN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000808")]
			[Cpp2IlInjected.Address(RVA = "0x7B57030", Offset = "0x7B55A30", VA = "0x187B57030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000206")]
		[BindableData(22, null, DataPermissions.ReadWrite)]
		public bool ShowPublishState
		{
			[Cpp2IlInjected.Token(Token = "0x6000809")]
			[Cpp2IlInjected.Address(RVA = "0x2342CB0", Offset = "0x23416B0", VA = "0x182342CB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600080A")]
			[Cpp2IlInjected.Address(RVA = "0x7B57090", Offset = "0x7B55A90", VA = "0x187B57090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000207")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x600080B")]
			[Cpp2IlInjected.Address(RVA = "0x7B58540", Offset = "0x7B56F40", VA = "0x187B58540", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000208")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x600080C")]
			[Cpp2IlInjected.Address(RVA = "0x7B58530", Offset = "0x7B56F30", VA = "0x187B58530", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600080D")]
			[Cpp2IlInjected.Address(RVA = "0x7B58900", Offset = "0x7B57300", VA = "0x187B58900")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000209")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600081F")]
			[Cpp2IlInjected.Address(RVA = "0x7B584F0", Offset = "0x7B56EF0", VA = "0x187B584F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000820")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<ILoadable> Loaded
		{
			[Cpp2IlInjected.Token(Token = "0x600080E")]
			[Cpp2IlInjected.Address(RVA = "0x7B58430", Offset = "0x7B56E30", VA = "0x187B58430", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600080F")]
			[Cpp2IlInjected.Address(RVA = "0x7B585C0", Offset = "0x7B56FC0", VA = "0x187B585C0", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x7B53590", Offset = "0x7B51F90", VA = "0x187B53590", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000812")]
		[Cpp2IlInjected.Address(RVA = "0x7B55C40", Offset = "0x7B54640", VA = "0x187B55C40", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000813")]
		[Cpp2IlInjected.Address(RVA = "0x7B55A50", Offset = "0x7B54450", VA = "0x187B55A50")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x7B53890", Offset = "0x7B52290", VA = "0x187B53890")]
		[AsyncStateMachine(typeof(<FetchRoomData>d__120))]
		private void FetchRoomData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x7B578D0", Offset = "0x7B562D0", VA = "0x187B578D0")]
		private void UpdateRoomData(MNEFCBHAIEP roomDto)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x7B57170", Offset = "0x7B55B70", VA = "0x187B57170")]
		private void UpdateFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000817")]
		[Cpp2IlInjected.Address(RVA = "0x7B56570", Offset = "0x7B54F70", VA = "0x187B56570")]
		private void ResetRoomData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x7B55D30", Offset = "0x7B54730", VA = "0x187B55D30")]
		private void OnFeatureHelperUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x7B55D50", Offset = "0x7B54750", VA = "0x187B55D50")]
		[BindableAction(100, null)]
		private void OpenRoomDetailsPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081A")]
		[Cpp2IlInjected.Address(RVA = "0x7B537E0", Offset = "0x7B521E0", VA = "0x187B537E0")]
		[AsyncStateMachine(typeof(<DoPlayAction>d__126))]
		[BindableAction(101, null)]
		private void DoPlayAction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081B")]
		[Cpp2IlInjected.Address(RVA = "0x7B536E0", Offset = "0x7B520E0", VA = "0x187B536E0")]
		[AsyncStateMachine(typeof(<CreateOrJoinRoomInstance>d__127))]
		private void CreateOrJoinRoomInstance(bool privateInstance, PFLGPOLCCPC roomDetails, bool canChooseSubroom = false, bool randomSubroom = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081C")]
		[Cpp2IlInjected.Address(RVA = "0x7B56260", Offset = "0x7B54C60", VA = "0x187B56260")]
		[AsyncStateMachine(typeof(<PlayAction_TryGoToRoom>d__128))]
		private void PlayAction_TryGoToRoom(PFLGPOLCCPC roomDetails, bool privateInstance, bool canChooseSubroom, bool randomSubroom)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0x7B56370", Offset = "0x7B54D70", VA = "0x187B56370")]
		private void RecordImpressionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0x7B53440", Offset = "0x7B51E40", VA = "0x187B53440")]
		private void AddDataTokenToImpressionData(string dataToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000821")]
		[Cpp2IlInjected.Address(RVA = "0x7B544D0", Offset = "0x7B52ED0", VA = "0x187B544D0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000822")]
		[Cpp2IlInjected.Address(RVA = "0x7B53940", Offset = "0x7B52340", VA = "0x187B53940")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000823")]
		[Cpp2IlInjected.Address(RVA = "0x7B57CE0", Offset = "0x7B566E0", VA = "0x187B57CE0")]
		public RoomViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public class RRUIBaseGlobalViewModel : BaseGlobalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		protected override string RecordPath
		{
			[Cpp2IlInjected.Token(Token = "0x600085E")]
			[Cpp2IlInjected.Address(RVA = "0x7B4EB80", Offset = "0x7B4D580", VA = "0x187B4EB80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0x7B4EB70", Offset = "0x7B4D570", VA = "0x187B4EB70")]
		public RRUIBaseGlobalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	public class RRUIBaseLocalViewModel : BaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005C7")]
		[SerializeField]
		protected ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005C8")]
		protected CancellationTokenSource cancellationTokenSource;

		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		protected override string RecordPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000860")]
			[Cpp2IlInjected.Address(RVA = "0x7B4ED20", Offset = "0x7B4D720", VA = "0x187B4ED20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0x7B4ECB0", Offset = "0x7B4D6B0", VA = "0x187B4ECB0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0x7B4EBB0", Offset = "0x7B4D5B0", VA = "0x187B4EBB0")]
		protected CancellationToken CancelAndRefreshToken()
		{
			return default(CancellationToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x7B4EC60", Offset = "0x7B4D660", VA = "0x187B4EC60")]
		protected void CancelToken()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x7B4ED10", Offset = "0x7B4D710", VA = "0x187B4ED10")]
		public RRUIBaseLocalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	public class PopoverCornerController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005C9")]
		[SerializeField]
		private GameObject topLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005CA")]
		[SerializeField]
		private GameObject topCenter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		[SerializeField]
		private GameObject topRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		[SerializeField]
		private GameObject upperLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		[SerializeField]
		private GameObject middleLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		[SerializeField]
		private GameObject lowerLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		[SerializeField]
		private GameObject upperRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		[SerializeField]
		private GameObject middleRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		[SerializeField]
		private GameObject lowerRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		[SerializeField]
		private GameObject bottomLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		[SerializeField]
		private GameObject bottomCenter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		[SerializeField]
		private GameObject bottomRight;

		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		public PopoverAnchor ActiveAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x6000865")]
			[Cpp2IlInjected.Address(RVA = "0xE3E930", Offset = "0xE3D330", VA = "0x180E3E930")]
			[CompilerGenerated]
			get
			{
				return default(PopoverAnchor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000866")]
			[Cpp2IlInjected.Address(RVA = "0xF4F7B0", Offset = "0xF4E1B0", VA = "0x180F4F7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0x7B4E9F0", Offset = "0x7B4D3F0", VA = "0x187B4E9F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x7B4EA00", Offset = "0x7B4D400", VA = "0x187B4EA00")]
		public void SetActiveAnchor(PopoverAnchor anchor, bool force = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0x7B4EB60", Offset = "0x7B4D560", VA = "0x187B4EB60")]
		public PopoverCornerController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	public class Tutorial
	{
		[Cpp2IlInjected.Token(Token = "0x20000C5")]
		public enum CompletionState
		{
			[Cpp2IlInjected.Token(Token = "0x40005DE")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40005DF")]
			Completed,
			[Cpp2IlInjected.Token(Token = "0x40005E0")]
			SoftExit,
			[Cpp2IlInjected.Token(Token = "0x40005E1")]
			HardExit
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private List<TutorialStep> steps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		private int activeStepIdx;

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x600086A")]
			[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600086B")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		public TutorialStep ActiveStep
		{
			[Cpp2IlInjected.Token(Token = "0x600086C")]
			[Cpp2IlInjected.Address(RVA = "0x7B5E110", Offset = "0x7B5CB10", VA = "0x187B5E110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000210")]
		public IReadOnlyList<TutorialStep> Steps
		{
			[Cpp2IlInjected.Token(Token = "0x600086D")]
			[Cpp2IlInjected.Address(RVA = "0xA0A590", Offset = "0xA08F90", VA = "0x180A0A590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		public CNBOOGKDGFE OnTutorialStarted
		{
			[Cpp2IlInjected.Token(Token = "0x600086E")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000212")]
		public CNBOOGKDGFE OnTutorialExited
		{
			[Cpp2IlInjected.Token(Token = "0x600086F")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000213")]
		public CNBOOGKDGFE OnStepChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000870")]
			[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000214")]
		public CompletionState CompletionStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000871")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7C0", Offset = "0xA091C0", VA = "0x180A0A7C0")]
			[CompilerGenerated]
			get
			{
				return default(CompletionState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000872")]
			[Cpp2IlInjected.Address(RVA = "0xA0A550", Offset = "0xA08F50", VA = "0x180A0A550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000873")]
		[Cpp2IlInjected.Address(RVA = "0x7B5DF00", Offset = "0x7B5C900", VA = "0x187B5DF00")]
		public Tutorial(string id, List<TutorialStep> steps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000874")]
		[Cpp2IlInjected.Address(RVA = "0x7B5DEC0", Offset = "0x7B5C8C0", VA = "0x187B5DEC0")]
		public void StartTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000875")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D810", Offset = "0x7B5C210", VA = "0x187B5D810")]
		public void ExitTutorial(bool showAgain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000876")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D990", Offset = "0x7B5C390", VA = "0x187B5D990")]
		public void SetActiveStep(string id, bool forceReload = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0x7B5DAD0", Offset = "0x7B5C4D0", VA = "0x187B5DAD0")]
		public void SetActiveStep(int idx, bool forceReload = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D890", Offset = "0x7B5C290", VA = "0x187B5D890")]
		private void OnGoBack()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D910", Offset = "0x7B5C310", VA = "0x187B5D910")]
		private void OnStepCompleted()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C6")]
	public class TutorialHighlightTargeter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		[SerializeField]
		protected List<TutorialTargetData> tutorialTargets;

		[Cpp2IlInjected.Token(Token = "0x600087A")]
		[Cpp2IlInjected.Address(RVA = "0x7B59230", Offset = "0x7B57C30", VA = "0x187B59230", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x7B593A0", Offset = "0x7B57DA0", VA = "0x187B593A0", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087C")]
		[Cpp2IlInjected.Address(RVA = "0x7B59680", Offset = "0x7B58080", VA = "0x187B59680")]
		private void RegisterTargets()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x7B59810", Offset = "0x7B58210", VA = "0x187B59810")]
		public TutorialHighlightTargeter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	public class TutorialTargetData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		public string TutorialId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		public string StepId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		public RectTransform Target;

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D7A0", Offset = "0x7B5C1A0", VA = "0x187B5D7A0")]
		public TutorialTargetData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C8")]
	public enum PopoverAnchor
	{
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		TopLeft,
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		TopCenter,
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		TopRight,
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		UpperLeft,
		[Cpp2IlInjected.Token(Token = "0x40005EB")]
		MiddleLeft,
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		LowerLeft,
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		UpperRight,
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		MiddleRight,
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		LowerRight,
		[Cpp2IlInjected.Token(Token = "0x40005F0")]
		BottomLeft,
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		BottomCenter,
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		BottomRight,
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		MiddleCenter
	}
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	public class TutorialStep
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x72")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		private bool isActive;

		[Cpp2IlInjected.Token(Token = "0x17000215")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000880")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7A0", Offset = "0xA091A0", VA = "0x180A0A7A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000216")]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x6000881")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000882")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000217")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000883")]
			[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000884")]
			[Cpp2IlInjected.Address(RVA = "0xA0A570", Offset = "0xA08F70", VA = "0x180A0A570")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000218")]
		public Sprite Icon
		{
			[Cpp2IlInjected.Token(Token = "0x6000885")]
			[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000886")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA093C0", VA = "0x180A0A9C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000219")]
		public string ButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000888")]
			[Cpp2IlInjected.Address(RVA = "0xA14650", Offset = "0xA13050", VA = "0x180A14650")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021A")]
		public string CountText
		{
			[Cpp2IlInjected.Token(Token = "0x6000889")]
			[Cpp2IlInjected.Address(RVA = "0xA0A590", Offset = "0xA08F90", VA = "0x180A0A590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600088A")]
			[Cpp2IlInjected.Address(RVA = "0xA10D40", Offset = "0xA0F740", VA = "0x180A10D40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021B")]
		public bool HasButtonToGoForward
		{
			[Cpp2IlInjected.Token(Token = "0x600088B")]
			[Cpp2IlInjected.Address(RVA = "0xCA7120", Offset = "0xCA5B20", VA = "0x180CA7120")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600088C")]
			[Cpp2IlInjected.Address(RVA = "0xD9EDB0", Offset = "0xD9D7B0", VA = "0x180D9EDB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		public bool HasButtonToGoBack
		{
			[Cpp2IlInjected.Token(Token = "0x600088D")]
			[Cpp2IlInjected.Address(RVA = "0xE0D020", Offset = "0xE0BA20", VA = "0x180E0D020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600088E")]
			[Cpp2IlInjected.Address(RVA = "0xE0B9A0", Offset = "0xE0A3A0", VA = "0x180E0B9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021D")]
		public bool ShowCountText
		{
			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0x1FD29E0", Offset = "0x1FD13E0", VA = "0x181FD29E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000890")]
			[Cpp2IlInjected.Address(RVA = "0x1FD1D10", Offset = "0x1FD0710", VA = "0x181FD1D10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021E")]
		public bool ShowExitButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000891")]
			[Cpp2IlInjected.Address(RVA = "0x20A1D90", Offset = "0x20A0790", VA = "0x1820A1D90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000892")]
			[Cpp2IlInjected.Address(RVA = "0x7B5D790", Offset = "0x7B5C190", VA = "0x187B5D790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021F")]
		public bool CanSoftExit
		{
			[Cpp2IlInjected.Token(Token = "0x6000893")]
			[Cpp2IlInjected.Address(RVA = "0x17D6EB0", Offset = "0x17D58B0", VA = "0x1817D6EB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000894")]
			[Cpp2IlInjected.Address(RVA = "0x17E3A10", Offset = "0x17E2410", VA = "0x1817E3A10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000220")]
		public bool AllowInteraction
		{
			[Cpp2IlInjected.Token(Token = "0x6000895")]
			[Cpp2IlInjected.Address(RVA = "0x70DFAC0", Offset = "0x70DE4C0", VA = "0x1870DFAC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000896")]
			[Cpp2IlInjected.Address(RVA = "0x718ACF0", Offset = "0x71896F0", VA = "0x18718ACF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000221")]
		public bool TargetingHUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000897")]
			[Cpp2IlInjected.Address(RVA = "0x70DFAB0", Offset = "0x70DE4B0", VA = "0x1870DFAB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000898")]
			[Cpp2IlInjected.Address(RVA = "0x70DFAE0", Offset = "0x70DE4E0", VA = "0x1870DFAE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000222")]
		public PopoverAnchor DialogAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x6000899")]
			[Cpp2IlInjected.Address(RVA = "0xF015A0", Offset = "0xEFFFA0", VA = "0x180F015A0")]
			[CompilerGenerated]
			get
			{
				return default(PopoverAnchor);
			}
			[Cpp2IlInjected.Token(Token = "0x600089A")]
			[Cpp2IlInjected.Address(RVA = "0xF029E0", Offset = "0xF013E0", VA = "0x180F029E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000223")]
		public RectTransform TutorialHighlightTarget
		{
			[Cpp2IlInjected.Token(Token = "0x600089B")]
			[Cpp2IlInjected.Address(RVA = "0xA10570", Offset = "0xA0EF70", VA = "0x180A10570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600089C")]
			[Cpp2IlInjected.Address(RVA = "0xA10560", Offset = "0xA0EF60", VA = "0x180A10560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000224")]
		public CNBOOGKDGFE OnStepCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x600089D")]
			[Cpp2IlInjected.Address(RVA = "0xA10550", Offset = "0xA0EF50", VA = "0x180A10550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000225")]
		public CNBOOGKDGFE OnStepModified
		{
			[Cpp2IlInjected.Token(Token = "0x600089E")]
			[Cpp2IlInjected.Address(RVA = "0xA10520", Offset = "0xA0EF20", VA = "0x180A10520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000226")]
		public CNBOOGKDGFE OnGoBack
		{
			[Cpp2IlInjected.Token(Token = "0x600089F")]
			[Cpp2IlInjected.Address(RVA = "0xA10530", Offset = "0xA0EF30", VA = "0x180A10530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000227")]
		public bool ShouldShow
		{
			[Cpp2IlInjected.Token(Token = "0x60008A0")]
			[Cpp2IlInjected.Address(RVA = "0xDC95A0", Offset = "0xDC7FA0", VA = "0x180DC95A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A1")]
			[Cpp2IlInjected.Address(RVA = "0xF11DB0", Offset = "0xF107B0", VA = "0x180F11DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000228")]
		public bool CompleteStepOnButtonPress
		{
			[Cpp2IlInjected.Token(Token = "0x60008A2")]
			[Cpp2IlInjected.Address(RVA = "0x11BE010", Offset = "0x11BCA10", VA = "0x1811BE010")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A3")]
			[Cpp2IlInjected.Address(RVA = "0x17C7B50", Offset = "0x17C6550", VA = "0x1817C7B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A4")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D5C0", Offset = "0x7B5BFC0", VA = "0x187B5D5C0")]
		public TutorialStep(string id, string title, string description, Sprite icon, string buttonText, bool showExitButton, bool canSoftExit, bool canGoBack, bool canGoForward, bool showCount, bool allowInteraction, bool targetingHud, PopoverAnchor dialogAnchor, bool shouldShow, bool completeStepOnButtonPress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D3D0", Offset = "0x7B5BDD0", VA = "0x187B5D3D0")]
		public void SetHighlightTarget(RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A6")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D390", Offset = "0x7B5BD90", VA = "0x187B5D390")]
		public void SetCountText(string countText)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D090", Offset = "0x7B5BA90", VA = "0x187B5D090")]
		public void BeginStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D250", Offset = "0x7B5BC50", VA = "0x187B5D250")]
		private void DeactiveStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D220", Offset = "0x7B5BC20", VA = "0x187B5D220")]
		public void CompleteStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AA")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D360", Offset = "0x7B5BD60", VA = "0x187B5D360")]
		public void GoBack()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AB")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D1E0", Offset = "0x7B5BBE0", VA = "0x187B5D1E0")]
		public void ChangeTitle(string newTitle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AC")]
		[Cpp2IlInjected.Address(RVA = "0x7B5D1A0", Offset = "0x7B5BBA0", VA = "0x187B5D1A0")]
		public void ChangeDescription(string newDescription)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[ViewModel]
	public class TutorialStepViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		[CompilerGenerated]
		private sealed class <UpdateVisualsCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400062D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400062E")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400062F")]
			public TutorialStepViewModel <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000239")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60008F0")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700023A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60008F2")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
			[DebuggerHidden]
			public <UpdateVisualsCoroutine>d__68(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008EE")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008EF")]
			[Cpp2IlInjected.Address(RVA = "0x7B6BE60", Offset = "0x7B6A860", VA = "0x187B6BE60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60008F1")]
			[Cpp2IlInjected.Address(RVA = "0x7B6BF20", Offset = "0x7B6A920", VA = "0x187B6BF20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		[SerializeField]
		private RectTransform highlightArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		[SerializeField]
		private RectTransform dialogTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		[SerializeField]
		private float maskPadding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		[SerializeField]
		private float additionalAnchorOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		[SerializeField]
		private CanvasScreenSizeRefitter canvasScreenSizeRefitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		[SerializeField]
		private PopoverCornerController popoverCornerController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private TutorialStep step;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private Coroutine updateVisualsCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		private Canvas targetCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		private string title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		private string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private string buttonText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private bool showMainButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x91")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		private bool canInteractWithHighlightArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x92")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private bool showExitButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x93")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		private bool showNextArrowButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		private bool showBackArrowButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		private string countText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private bool hasIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private Sprite icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400061D")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400061E")]
		private DataItem<string> TitleDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400061F")]
		private DataItem<string> DescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000620")]
		private DataItem<string> ButtonTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000621")]
		private DataItem<bool> ShowMainButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000622")]
		private DataItem<bool> CanInteractWithHighlightAreaDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000623")]
		private DataItem<bool> ShowExitButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000624")]
		private DataItem<bool> ShowNextArrowButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000625")]
		private DataItem<bool> ShowBackArrowButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000626")]
		private DataItem<string> CountTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000627")]
		private DataItem<bool> HasIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000628")]
		private DataItem<Sprite> IconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000629")]
		private DataItemAction GoToNextStepDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400062A")]
		private DataItemAction SkipTutorialDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400062B")]
		private DataItemAction SoftExitTutorialDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400062C")]
		private DataItemAction GoToPreviousStepDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000229")]
		private Camera screenCamera
		{
			[Cpp2IlInjected.Token(Token = "0x60008AD")]
			[Cpp2IlInjected.Address(RVA = "0x17528D0", Offset = "0x17512D0", VA = "0x1817528D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022A")]
		private Canvas sourceCanvas
		{
			[Cpp2IlInjected.Token(Token = "0x60008AE")]
			[Cpp2IlInjected.Address(RVA = "0x7B5CE40", Offset = "0x7B5B840", VA = "0x187B5CE40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022B")]
		private RectTransform sourceCanvasRect
		{
			[Cpp2IlInjected.Token(Token = "0x60008AF")]
			[Cpp2IlInjected.Address(RVA = "0x7B5CDC0", Offset = "0x7B5B7C0", VA = "0x187B5CDC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022C")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x60008B0")]
			[Cpp2IlInjected.Address(RVA = "0xA092C0", Offset = "0xA07CC0", VA = "0x180A092C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008B1")]
			[Cpp2IlInjected.Address(RVA = "0x7B5BA90", Offset = "0x7B5A490", VA = "0x187B5BA90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022D")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x60008B2")]
			[Cpp2IlInjected.Address(RVA = "0xA09190", Offset = "0xA07B90", VA = "0x180A09190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008B3")]
			[Cpp2IlInjected.Address(RVA = "0x7B5CF60", Offset = "0x7B5B960", VA = "0x187B5CF60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022E")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string ButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x60008B4")]
			[Cpp2IlInjected.Address(RVA = "0xA09220", Offset = "0xA07C20", VA = "0x180A09220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008B5")]
			[Cpp2IlInjected.Address(RVA = "0x7B5CE60", Offset = "0x7B5B860", VA = "0x187B5CE60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022F")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool ShowMainButton
		{
			[Cpp2IlInjected.Token(Token = "0x60008B6")]
			[Cpp2IlInjected.Address(RVA = "0xA3B3B0", Offset = "0xA39DB0", VA = "0x180A3B3B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008B7")]
			[Cpp2IlInjected.Address(RVA = "0x7B5BB30", Offset = "0x7B5A530", VA = "0x187B5BB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000230")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool CanInteractWithHighlightArea
		{
			[Cpp2IlInjected.Token(Token = "0x60008B8")]
			[Cpp2IlInjected.Address(RVA = "0x2059080", Offset = "0x2057A80", VA = "0x182059080")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008B9")]
			[Cpp2IlInjected.Address(RVA = "0x7B5BB90", Offset = "0x7B5A590", VA = "0x187B5BB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000231")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public bool ShowExitButton
		{
			[Cpp2IlInjected.Token(Token = "0x60008BA")]
			[Cpp2IlInjected.Address(RVA = "0x16B7270", Offset = "0x16B5C70", VA = "0x1816B7270")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008BB")]
			[Cpp2IlInjected.Address(RVA = "0x7B5B900", Offset = "0x7B5A300", VA = "0x187B5B900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000232")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool ShowNextArrowButton
		{
			[Cpp2IlInjected.Token(Token = "0x60008BC")]
			[Cpp2IlInjected.Address(RVA = "0x16B7280", Offset = "0x16B5C80", VA = "0x1816B7280")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008BD")]
			[Cpp2IlInjected.Address(RVA = "0x7B5B960", Offset = "0x7B5A360", VA = "0x187B5B960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000233")]
		[BindableData(7, null, DataPermissions.ReadWrite)]
		public bool ShowBackArrowButton
		{
			[Cpp2IlInjected.Token(Token = "0x60008BE")]
			[Cpp2IlInjected.Address(RVA = "0x1D55E10", Offset = "0x1D54810", VA = "0x181D55E10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008BF")]
			[Cpp2IlInjected.Address(RVA = "0x7B5B9C0", Offset = "0x7B5A3C0", VA = "0x187B5B9C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000234")]
		[BindableData(8, null, DataPermissions.ReadWrite)]
		public string CountText
		{
			[Cpp2IlInjected.Token(Token = "0x60008C0")]
			[Cpp2IlInjected.Address(RVA = "0xA091A0", Offset = "0xA07BA0", VA = "0x180A091A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008C1")]
			[Cpp2IlInjected.Address(RVA = "0x7B5CEE0", Offset = "0x7B5B8E0", VA = "0x187B5CEE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000235")]
		[BindableData(9, null, DataPermissions.ReadWrite)]
		public bool HasIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60008C2")]
			[Cpp2IlInjected.Address(RVA = "0xD07DA0", Offset = "0xD067A0", VA = "0x180D07DA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008C3")]
			[Cpp2IlInjected.Address(RVA = "0x7B5BA30", Offset = "0x7B5A430", VA = "0x187B5BA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000236")]
		[BindableData(10, null, DataPermissions.ReadWrite)]
		public Sprite Icon
		{
			[Cpp2IlInjected.Token(Token = "0x60008C4")]
			[Cpp2IlInjected.Address(RVA = "0xA0D3B0", Offset = "0xA0BDB0", VA = "0x180A0D3B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008C5")]
			[Cpp2IlInjected.Address(RVA = "0x7B5CFE0", Offset = "0x7B5B9E0", VA = "0x187B5CFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000237")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60008D2")]
			[Cpp2IlInjected.Address(RVA = "0x7B5CD80", Offset = "0x7B5B780", VA = "0x187B5CD80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000238")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60008D3")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008C6")]
		[Cpp2IlInjected.Address(RVA = "0x7B5A7D0", Offset = "0x7B591D0", VA = "0x187B5A7D0")]
		[BindableAction(100, null)]
		public void GoToNextStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C7")]
		[Cpp2IlInjected.Address(RVA = "0x7B5B7B0", Offset = "0x7B5A1B0", VA = "0x187B5B7B0")]
		[BindableAction(101, null)]
		public void SkipTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C8")]
		[Cpp2IlInjected.Address(RVA = "0x7B5B850", Offset = "0x7B5A250", VA = "0x187B5B850")]
		[BindableAction(102, null)]
		public void SoftExitTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C9")]
		[Cpp2IlInjected.Address(RVA = "0x7B5A820", Offset = "0x7B59220", VA = "0x187B5A820")]
		[BindableAction(103, null)]
		public void GoToPreviousStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CA")]
		[Cpp2IlInjected.Address(RVA = "0x7B5B670", Offset = "0x7B5A070", VA = "0x187B5B670")]
		public void Set(TutorialStep step)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CB")]
		[Cpp2IlInjected.Address(RVA = "0x7B5B610", Offset = "0x7B5A010", VA = "0x187B5B610")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CC")]
		[Cpp2IlInjected.Address(RVA = "0x7B5B5D0", Offset = "0x7B59FD0", VA = "0x187B5B5D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0x7B5B510", Offset = "0x7B59F10", VA = "0x187B5B510", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0x7B5BBF0", Offset = "0x7B5A5F0", VA = "0x187B5BBF0")]
		private void UpdateStepData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x7B5C1F0", Offset = "0x7B5ABF0", VA = "0x187B5C1F0")]
		[IteratorStateMachine(typeof(<UpdateVisualsCoroutine>d__68))]
		private IEnumerator UpdateVisualsCoroutine()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x7B5C260", Offset = "0x7B5AC60", VA = "0x187B5C260")]
		private void UpdateVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x7B598A0", Offset = "0x7B582A0", VA = "0x187B598A0")]
		private void AlignEdgeToEdge(RectTransform source, RectTransform target, TextAnchor sourceEdge, TextAnchor targetEdge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x7B5A870", Offset = "0x7B59270", VA = "0x187B5A870", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0x7B5A0A0", Offset = "0x7B58AA0", VA = "0x187B5A0A0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0x7B5C8E0", Offset = "0x7B5B2E0", VA = "0x187B5C8E0")]
		public TutorialStepViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	public class TutorialUIManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		public static CNBOOGKDGFE OnCreated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		public CNBOOGKDGFE OnDataUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		private Dictionary<string, Dictionary<string, RectTransform>> tutorialTargets;

		[Cpp2IlInjected.Token(Token = "0x1700023B")]
		public static TutorialUIManager Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60008F3")]
			[Cpp2IlInjected.Address(RVA = "0x7B6AF60", Offset = "0x7B69960", VA = "0x187B6AF60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008F4")]
			[Cpp2IlInjected.Address(RVA = "0x7B6AFB0", Offset = "0x7B699B0", VA = "0x187B6AFB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023C")]
		public Tutorial ActiveTutorial
		{
			[Cpp2IlInjected.Token(Token = "0x60008F5")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008F6")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0x7B6A050", Offset = "0x7B68A50", VA = "0x187B6A050")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x7B6A2F0", Offset = "0x7B68CF0", VA = "0x187B6A2F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x7B6A1D0", Offset = "0x7B68BD0", VA = "0x187B6A1D0")]
		private void ClearActiveTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x7B6A1E0", Offset = "0x7B68BE0", VA = "0x187B6A1E0")]
		private void ClearActiveTutorial(bool sendUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FB")]
		[Cpp2IlInjected.Address(RVA = "0x7B6A760", Offset = "0x7B69160", VA = "0x187B6A760")]
		public void StartTutorial(Tutorial tutorial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0x7B6A2D0", Offset = "0x7B68CD0", VA = "0x187B6A2D0")]
		public void EndTutorial(bool showAgain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0x7B6A420", Offset = "0x7B68E20", VA = "0x187B6A420")]
		public void RegisterTutorialTarget(string tutorialId, string stepId, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x7B6AB30", Offset = "0x7B69530", VA = "0x187B6AB30")]
		public void UnregisterTutorialTarget(string tutorialId, string stepId, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0x7B6AE90", Offset = "0x7B69890", VA = "0x187B6AE90")]
		public TutorialUIManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[ViewModel]
	public class TutorialUIViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		[SerializeField]
		private CanvasScreenSizeRefitter canvasScreenSizeRefitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		[SerializeField]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		[SerializeField]
		private TutorialStepViewModel tutorialStepViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		private Tutorial activeTutorial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private bool isTutorialActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private DataItem<bool> IsTutorialActiveDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700023D")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool IsTutorialActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000901")]
			[Cpp2IlInjected.Address(RVA = "0xA17C20", Offset = "0xA16620", VA = "0x180A17C20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000902")]
			[Cpp2IlInjected.Address(RVA = "0x7B6B930", Offset = "0x7B6A330", VA = "0x187B6B930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023E")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000908")]
			[Cpp2IlInjected.Address(RVA = "0x7B6BA20", Offset = "0x7B6A420", VA = "0x187B6BA20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023F")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000909")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0x7B6B020", Offset = "0x7B69A20", VA = "0x187B6B020", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0x7B6B810", Offset = "0x7B6A210", VA = "0x187B6B810")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0x7B6B380", Offset = "0x7B69D80", VA = "0x187B6B380", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0x7B6B7D0", Offset = "0x7B6A1D0", VA = "0x187B6B7D0")]
		private void OnStepChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0x7B6B520", Offset = "0x7B69F20", VA = "0x187B6B520")]
		private void OnManagerUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x7B6B230", Offset = "0x7B69C30", VA = "0x187B6B230", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x7B6B130", Offset = "0x7B69B30", VA = "0x187B6B130")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x7B6B990", Offset = "0x7B6A390", VA = "0x187B6B990")]
		public TutorialUIViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[CreateAssetMenu(fileName = "UITutorialData", menuName = "RecRoom/UI/UI Tutorial Data")]
	public class UITutorialData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000CF")]
		private class TutorialStepData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400063F")]
			public string Id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000640")]
			public string Title;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000641")]
			public string Description;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000642")]
			public Sprite OptionalIcon;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000643")]
			public string ButtonText;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000644")]
			public bool ShowButtonToGoForward;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x4000645")]
			public bool ShowButtonToGoBack;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
			[Cpp2IlInjected.Token(Token = "0x4000646")]
			public bool ShowCountText;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3B")]
			[Cpp2IlInjected.Token(Token = "0x4000647")]
			public bool ShowExitButton;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000648")]
			public bool CanSoftExit;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
			[Cpp2IlInjected.Token(Token = "0x4000649")]
			public bool AllowInteraction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3E")]
			[Cpp2IlInjected.Token(Token = "0x400064A")]
			public bool TargetingHUD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3F")]
			[Cpp2IlInjected.Token(Token = "0x400064B")]
			public bool ShouldShow;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400064C")]
			public bool CompleteStepOnButtonPress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400064D")]
			public PopoverAnchor DialogAnchor;

			[Cpp2IlInjected.Token(Token = "0x6000911")]
			[Cpp2IlInjected.Address(RVA = "0x7B69E20", Offset = "0x7B68820", VA = "0x187B69E20")]
			public TutorialStep ToTutorialStep()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000912")]
			[Cpp2IlInjected.Address(RVA = "0x7B69FA0", Offset = "0x7B689A0", VA = "0x187B69FA0")]
			public TutorialStepData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		[SerializeField]
		private string id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		[SerializeField]
		private List<TutorialStepData> steps;

		[Cpp2IlInjected.Token(Token = "0x600090F")]
		[Cpp2IlInjected.Address(RVA = "0x7B6C5B0", Offset = "0x7B6AFB0", VA = "0x187B6C5B0")]
		public Tutorial GenerateTutorialFromData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x7B6C9B0", Offset = "0x7B6B3B0", VA = "0x187B6C9B0")]
		public UITutorialData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	public enum UILinkType
	{
		[Cpp2IlInjected.Token(Token = "0x400064F")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000650")]
		Uri,
		[Cpp2IlInjected.Token(Token = "0x4000651")]
		Tab,
		[Cpp2IlInjected.Token(Token = "0x4000652")]
		Legacy
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	public enum LegacyUIType
	{
		[Cpp2IlInjected.Token(Token = "0x4000654")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000655")]
		Challenges,
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		Outfits
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	public class LinkInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		public string Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		public UILinkType LinkType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		[IMEGOPBCDNJ("requiresUri")]
		public Uri LinkUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		[IMEGOPBCDNJ("LinkType", UILinkType.Tab)]
		public CDPKGMAFFBM LinkTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		[IMEGOPBCDNJ("LinkType", UILinkType.Legacy)]
		public LegacyUIType LegacyType;

		[Cpp2IlInjected.Token(Token = "0x17000240")]
		public bool IsLegacyUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000913")]
			[Cpp2IlInjected.Address(RVA = "0x214A360", Offset = "0x2148D60", VA = "0x18214A360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0x7B692A0", Offset = "0x7B67CA0", VA = "0x187B692A0")]
		public LinkInfo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[CreateAssetMenu(fileName = "RouteLookup", menuName = "RecRoom/UI/Route Lookup")]
	public class UILinkLookup : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		[SerializeField]
		[FormerlySerializedAs("routeInfos")]
		private List<LinkInfo> linkInfoList;

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0x7B6C270", Offset = "0x7B6AC70", VA = "0x187B6C270")]
		public bool TryGetLinkInfo(string alias, [Out] LinkInfo linkInfo)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0x7B6C3F0", Offset = "0x7B6ADF0", VA = "0x187B6C3F0")]
		public bool TryGetUri(string routeId, [Out] Uri uri)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0x7B6BF70", Offset = "0x7B6A970", VA = "0x187B6BF70")]
		public List<Uri> GetAllUri()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0x7B6C0F0", Offset = "0x7B6AAF0", VA = "0x187B6C0F0")]
		public bool TryGetLegacyUIType(string routeId, [Out] LegacyUIType legacyUIType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0xC49D80", Offset = "0xC48780", VA = "0x180C49D80")]
		public UILinkLookup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	public class WatchViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private const string UnifiedUISessionIdKey = "unified_ui_session_id";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private IMenuManager _menuManager;

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0x7B6CA60", Offset = "0x7B6B460", VA = "0x187B6CA60", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x7B6CCF0", Offset = "0x7B6B6F0", VA = "0x187B6CCF0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091C")]
		[Cpp2IlInjected.Address(RVA = "0x7B6CDC0", Offset = "0x7B6B7C0", VA = "0x187B6CDC0")]
		private void OnWatchMenuUnifiedSessionIdChanged(Guid watchMenuUnifiedSessionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x7B6CEB0", Offset = "0x7B6B8B0", VA = "0x187B6CEB0")]
		public WatchViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	public class CanvasScreenSizeRefitter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		[SerializeField]
		private Canvas targetCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		[SerializeField]
		private float minPercentageOfScreenHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		[SerializeField]
		private float maxPercentageOfScreenHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		[SerializeField]
		private float offsetFromNearClipPlane;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		[SerializeField]
		private Camera lookAtCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		[SerializeField]
		private bool updateOnCameraMove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		[SerializeField]
		private bool useScreenSafeArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		[SerializeField]
		private bool forceWidthToFitScreen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private Vector2 cachedDimensions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private Vector2 cachedSafeAreaDimensions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private Vector3 cachedCameraPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private Quaternion cachedCameraRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private float cachedFov;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private bool forceUpdate;

		[Cpp2IlInjected.Token(Token = "0x17000241")]
		public Canvas TargetCanvas
		{
			[Cpp2IlInjected.Token(Token = "0x600091E")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000242")]
		public Camera TargetCamera
		{
			[Cpp2IlInjected.Token(Token = "0x600091F")]
			[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000243")]
		public float OffsetFromCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000920")]
			[Cpp2IlInjected.Address(RVA = "0x7B62E30", Offset = "0x7B61830", VA = "0x187B62E30")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000244")]
		private float cameraFov
		{
			[Cpp2IlInjected.Token(Token = "0x6000921")]
			[Cpp2IlInjected.Address(RVA = "0x7B62EC0", Offset = "0x7B618C0", VA = "0x187B62EC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000245")]
		private Vector3 cameraPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000922")]
			[Cpp2IlInjected.Address(RVA = "0x7B62F50", Offset = "0x7B61950", VA = "0x187B62F50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000246")]
		private Quaternion cameraRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000923")]
			[Cpp2IlInjected.Address(RVA = "0x7B63020", Offset = "0x7B61A20", VA = "0x187B63020")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000247")]
		private RectTransform canvasRect
		{
			[Cpp2IlInjected.Token(Token = "0x6000924")]
			[Cpp2IlInjected.Address(RVA = "0x7B630F0", Offset = "0x7B61AF0", VA = "0x187B630F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0xA14650", Offset = "0xA13050", VA = "0x180A14650")]
		public void SetLookCamera(Camera lookAt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x2759460", Offset = "0x2757E60", VA = "0x182759460")]
		public void ForceUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x7B620F0", Offset = "0x7B60AF0", VA = "0x187B620F0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000928")]
		[Cpp2IlInjected.Address(RVA = "0x7B628D0", Offset = "0x7B612D0", VA = "0x187B628D0")]
		private void UpdateScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x7B62390", Offset = "0x7B60D90", VA = "0x187B62390")]
		public void PinToTopLeftOfScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x7B62D20", Offset = "0x7B61720", VA = "0x187B62D20")]
		public CanvasScreenSizeRefitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[DisallowMultipleComponent]
	public class FocusableAllowedStateHelper : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20000D7")]
		public enum StateOverrideSource
		{
			[Cpp2IlInjected.Token(Token = "0x4000679")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400067A")]
			Statsig,
			[Cpp2IlInjected.Token(Token = "0x400067B")]
			GameConfig
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private string defaultStatsigLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private string defaultStatsigParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		[SerializeField]
		private FocusableUI focusable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		[SerializeField]
		private StateOverrideSource overrideSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		[SerializeField]
		[ConditionalVisibility("overrideSource", ConditionResultType.ShowIfEquals, 1)]
		private string statsigLayerOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		[ConditionalVisibility("overrideSource", ConditionResultType.ShowIfEquals, 1)]
		[SerializeField]
		private string statsigParameterOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		[ConditionalVisibility("overrideSource", ConditionResultType.ShowIfEquals, 2)]
		[SerializeField]
		private string gameConfigKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private JJPMOJNHOLC configProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		private NDICJCLBPMH statsig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		private bool allowed;

		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x7B63150", Offset = "0x7B61B50", VA = "0x187B63150")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x7B63880", Offset = "0x7B62280", VA = "0x187B63880")]
		private void UpdateWhenStatsigReady()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x7B63600", Offset = "0x7B62000", VA = "0x187B63600")]
		private void UpdateFromStatsig()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x7B637D0", Offset = "0x7B621D0", VA = "0x187B637D0")]
		private void UpdateWhenConfigReady()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x7B633E0", Offset = "0x7B61DE0", VA = "0x187B633E0")]
		private void UpdateFromGameConfig()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x7B63930", Offset = "0x7B62330", VA = "0x187B63930")]
		public FocusableAllowedStateHelper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	public class ImpressionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		public Dictionary<string, int> IntData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		public Dictionary<string, float> FloatData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		public Dictionary<string, long> LongData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		public Dictionary<string, string> StringData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		public Dictionary<string, Guid> GuidData;

		[Cpp2IlInjected.Token(Token = "0x6000931")]
		[Cpp2IlInjected.Address(RVA = "0x7B646A0", Offset = "0x7B630A0", VA = "0x187B646A0")]
		public bool TryGetValueAsString(string key, [Out] string valString, string format = "")
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x7B64460", Offset = "0x7B62E60", VA = "0x187B64460")]
		public KFDINHAAMME.FHDFLJDPDCA TryAddProperty(string key, KFDINHAAMME.FHDFLJDPDCA eventBuilder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0x7B63AF0", Offset = "0x7B624F0", VA = "0x187B63AF0")]
		public void ClearData(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0x7B63A10", Offset = "0x7B62410", VA = "0x187B63A10")]
		public void ClearAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x7B63D20", Offset = "0x7B62720", VA = "0x187B63D20")]
		public void CopyData(ImpressionData copyTo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x7B64880", Offset = "0x7B63280", VA = "0x187B64880")]
		public ImpressionData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D9")]
	public class ImpressionTracker : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20000DA")]
		public enum PassToChildren
		{
			[Cpp2IlInjected.Token(Token = "0x40006A2")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x40006A3")]
			Enabled,
			[Cpp2IlInjected.Token(Token = "0x40006A4")]
			EnabledRecursive
		}

		[Cpp2IlInjected.Token(Token = "0x20000DB")]
		[Flags]
		internal enum ImpressionLogEvents
		{
			[Cpp2IlInjected.Token(Token = "0x40006A6")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x40006A7")]
			OnClickThrough = 1,
			[Cpp2IlInjected.Token(Token = "0x40006A8")]
			OnNavigateToNewPage = 2,
			[Cpp2IlInjected.Token(Token = "0x40006A9")]
			OnMenuClosed = 4,
			[Cpp2IlInjected.Token(Token = "0x40006AA")]
			OnStopTracking = 8,
			[Cpp2IlInjected.Token(Token = "0x40006AB")]
			OnDisable = 0x10
		}

		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		internal enum ImpressionLogConditions
		{
			[Cpp2IlInjected.Token(Token = "0x40006AD")]
			NoConditions,
			[Cpp2IlInjected.Token(Token = "0x40006AE")]
			OnlyWhenChildrenAreTracked
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DD")]
		[CompilerGenerated]
		private struct <FinishCleanUpAfterLoggingComplete>d__45 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40006AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40006B0")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40006B1")]
			public Task logTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40006B2")]
			public ImpressionTracker <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40006B3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000963")]
			[Cpp2IlInjected.Address(RVA = "0x7B6BA50", Offset = "0x7B6A450", VA = "0x187B6BA50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000964")]
			[Cpp2IlInjected.Address(RVA = "0xA65B60", Offset = "0xA64560", VA = "0x180A65B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private static KMHICFHJEAE<ImpressionData> ImpressionDataPool;

		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private const float minSecondsForImpression = 0.1f;

		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private const string buttonLocationProperty = "buttonLocation";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		[SerializeField]
		private ImpressionLogEvents logEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		[SerializeField]
		private ImpressionLogConditions logConditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		[SerializeField]
		private VisibilityChecker visibilityChecker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		private ImpressionData impressionData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		private int idCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private Dictionary<int, string> idToKeyLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		private Dictionary<string, int> keyToIdLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400068B")]
		private List<int> recordedKeys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400068C")]
		private List<int> dataToRecordOnClickThrough;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400068D")]
		private List<ImpressionTracker> children;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400068E")]
		private List<ImpressionTracker> tempChildrenWhileLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		private Dictionary<int, PassToChildren> dataToPassToChildren;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private List<int> dataToCollateFromChildrenOnLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private Dictionary<int, int> collatedDataToRecordUnderDifferentKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		private List<int> dataToClearOnChildrenAfterLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		private Dictionary<int, string> defaultValueLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		private Dictionary<string, string> stringFormatLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000695")]
		private List<ImpressionData> childImpressionsNotYetLogged;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000696")]
		private List<ImpressionData> allChildImpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000697")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000698")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		private Uri pageUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		private bool pageUriActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private ImpressionTracker parentTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private bool parentTrackerInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private bool trackingActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private StringBuilder stringBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		public Action<ImpressionTracker> ChildAdded;

		[Cpp2IlInjected.Token(Token = "0x17000248")]
		public bool AutoTrackWhenVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000938")]
			[Cpp2IlInjected.Address(RVA = "0xA86DB0", Offset = "0xA857B0", VA = "0x180A86DB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000939")]
			[Cpp2IlInjected.Address(RVA = "0xA871C0", Offset = "0xA85BC0", VA = "0x180A871C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x7B68C20", Offset = "0x7B67620", VA = "0x187B68C20")]
		private void TryInitializeParentTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0x7B64A40", Offset = "0x7B63440", VA = "0x187B64A40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0x7B66430", Offset = "0x7B64E30", VA = "0x187B66430")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x7B662C0", Offset = "0x7B64CC0", VA = "0x187B662C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x7B66A90", Offset = "0x7B65490", VA = "0x187B66A90")]
		public void SetDataToCollateFromChildrenOnLog(string key, string defaultValue, bool clearAfterLogging = false, string keyToRecordCollatedData = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x7B66C30", Offset = "0x7B65630", VA = "0x187B66C30")]
		public void SetDataToRecordOnClickThrough(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x7B65680", Offset = "0x7B64080", VA = "0x187B65680")]
		public void LogImpression(bool force = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0x7B65240", Offset = "0x7B63C40", VA = "0x187B65240")]
		[AsyncStateMachine(typeof(<FinishCleanUpAfterLoggingComplete>d__45))]
		private void FinishCleanUpAfterLoggingComplete(Task logTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0x7B68380", Offset = "0x7B66D80", VA = "0x187B68380")]
		public void StartTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x7B68840", Offset = "0x7B67240", VA = "0x187B68840")]
		public void StopTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0x7B686F0", Offset = "0x7B670F0", VA = "0x187B686F0")]
		public void StopTrackingAndClearData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0x7B66760", Offset = "0x7B65160", VA = "0x187B66760")]
		public void RecordClickThrough([Optional] string buttonName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x7B67D00", Offset = "0x7B66700", VA = "0x187B67D00")]
		public void SetString(string key, string data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x7B67D30", Offset = "0x7B66730", VA = "0x187B67D30")]
		public void SetString(string key, string data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x7B67340", Offset = "0x7B65D40", VA = "0x187B67340")]
		public void SetGuid(string key, Guid data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000948")]
		[Cpp2IlInjected.Address(RVA = "0x7B67020", Offset = "0x7B65A20", VA = "0x187B67020")]
		public void SetGuid(string key, Guid data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000949")]
		[Cpp2IlInjected.Address(RVA = "0x7B676A0", Offset = "0x7B660A0", VA = "0x187B676A0")]
		public void SetLong(string key, long data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094A")]
		[Cpp2IlInjected.Address(RVA = "0x7B676D0", Offset = "0x7B660D0", VA = "0x187B676D0")]
		public void SetLong(string key, long data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094B")]
		[Cpp2IlInjected.Address(RVA = "0x7B66CF0", Offset = "0x7B656F0", VA = "0x187B66CF0")]
		public void SetFloat(string key, float data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0x7B66D20", Offset = "0x7B65720", VA = "0x187B66D20")]
		public void SetFloat(string key, float data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0x7B679C0", Offset = "0x7B663C0", VA = "0x187B679C0")]
		public void SetObject(string key, object data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0x7B679F0", Offset = "0x7B663F0", VA = "0x187B679F0")]
		public void SetObject(string key, object data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0x7B67670", Offset = "0x7B66070", VA = "0x187B67670")]
		public void SetInt(string key, int data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0x7B67380", Offset = "0x7B65D80", VA = "0x187B67380")]
		public void SetInt(string key, int data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(RVA = "0x7B68B90", Offset = "0x7B67590", VA = "0x187B68B90")]
		public bool TryGetValueAsString(string key, [Out] string valString, string format = "")
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000952")]
		[Cpp2IlInjected.Address(RVA = "0x7B64C30", Offset = "0x7B63630", VA = "0x187B64C30")]
		public void ClearData(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000953")]
		[Cpp2IlInjected.Address(RVA = "0x7B653A0", Offset = "0x7B63DA0", VA = "0x187B653A0")]
		private int GetOrAddKeyId(string key)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0x7B65310", Offset = "0x7B63D10", VA = "0x187B65310")]
		private string GetKey(int id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000955")]
		[Cpp2IlInjected.Address(RVA = "0x7B669D0", Offset = "0x7B653D0", VA = "0x187B669D0")]
		private void RecordDuration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0x7B68150", Offset = "0x7B66B50", VA = "0x187B68150")]
		private void StartTrackingChild(ImpressionTracker child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0x7B68730", Offset = "0x7B67130", VA = "0x187B68730")]
		private void StopTrackingChild(ImpressionTracker child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0x7B65520", Offset = "0x7B63F20", VA = "0x187B65520")]
		private void HandleVisibilityChanged(bool isVisible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0x7B66190", Offset = "0x7B64B90", VA = "0x187B66190")]
		private void LogImpressionsOnBrowserModelNavigationComplete(PageWrapper destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0x7B66230", Offset = "0x7B64C30", VA = "0x187B66230")]
		private void LogImpressionsOnMenuClose(bool isOpen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0x7B68D10", Offset = "0x7B67710", VA = "0x187B68D10")]
		private void TryResumeTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0x7B66450", Offset = "0x7B64E50", VA = "0x187B66450")]
		private void PassDataToChild(string key, ImpressionTracker child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095D")]
		[Cpp2IlInjected.Address(RVA = "0x7B64E60", Offset = "0x7B63860", VA = "0x187B64E60")]
		private string CollateDataFromChildren(int keyId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0x7B68020", Offset = "0x7B66A20", VA = "0x187B68020")]
		private int SortByElementIndex(ImpressionData lhs, ImpressionData rhs)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0x7B64C20", Offset = "0x7B63620", VA = "0x187B64C20")]
		private bool CanLogEvent(ImpressionLogEvents logEvent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0x7B65490", Offset = "0x7B63E90", VA = "0x187B65490")]
		private void GuaranteeImpressionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000961")]
		[Cpp2IlInjected.Address(RVA = "0x7B68E40", Offset = "0x7B67840", VA = "0x187B68E40")]
		public ImpressionTracker()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	public class CanvasSizeData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		public Vector2 CanvasSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		public IGNJONDMFAO Platforms;

		[Cpp2IlInjected.Token(Token = "0x6000965")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public CanvasSizeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[CreateAssetMenu(fileName = "PlatformDependentCanvasSizeConfig", menuName = "RecRoom/UI/Canvas Size Settings")]
	public class PlatformDependentCanvasSizeConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		[SerializeField]
		private Vector2 fallbackCanvasSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		[SerializeField]
		private List<CanvasSizeData> canvasSizeSettings;

		[Cpp2IlInjected.Token(Token = "0x6000966")]
		[Cpp2IlInjected.Address(RVA = "0x7B69300", Offset = "0x7B67D00", VA = "0x187B69300")]
		public Vector2 GetSizeForPlatform(IGNJONDMFAO platform)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000967")]
		[Cpp2IlInjected.Address(RVA = "0x7B69480", Offset = "0x7B67E80", VA = "0x187B69480")]
		public PlatformDependentCanvasSizeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E0")]
	public class RaycastIgnoreTransformFilter : MonoBehaviour, ICanvasRaycastFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		[SerializeField]
		private List<RectTransform> targetTransforms;

		[Cpp2IlInjected.Token(Token = "0x6000968")]
		[Cpp2IlInjected.Address(RVA = "0x7B694E0", Offset = "0x7B67EE0", VA = "0x187B694E0", Slot = "4")]
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000969")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
		public RaycastIgnoreTransformFilter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E1")]
	public class RectTransformAspectRatioResizer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x20000E2")]
		public enum ResizeDimension
		{
			[Cpp2IlInjected.Token(Token = "0x40006BC")]
			Height,
			[Cpp2IlInjected.Token(Token = "0x40006BD")]
			Width
		}

		[Cpp2IlInjected.Token(Token = "0x20000E3")]
		[CompilerGenerated]
		private sealed class <FitResizeDimensionToAspectRatioAtEndOfFrame>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40006BE")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40006BF")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40006C0")]
			public RectTransformAspectRatioResizer <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000249")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000972")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700024A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000974")]
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600096F")]
			[Cpp2IlInjected.Address(RVA = "0xA12710", Offset = "0xA11110", VA = "0x180A12710")]
			[DebuggerHidden]
			public <FitResizeDimensionToAspectRatioAtEndOfFrame>d__4(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000970")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000971")]
			[Cpp2IlInjected.Address(RVA = "0x7B6BD60", Offset = "0x7B6A760", VA = "0x187B6BD60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000973")]
			[Cpp2IlInjected.Address(RVA = "0x7B6BE10", Offset = "0x7B6A810", VA = "0x187B6BE10", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		[SerializeField]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		[SerializeField]
		private ResizeDimension resizeDimension;

		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0x7B69B50", Offset = "0x7B68550", VA = "0x187B69B50")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0x7B69650", Offset = "0x7B68050", VA = "0x187B69650")]
		[IteratorStateMachine(typeof(<FitResizeDimensionToAspectRatioAtEndOfFrame>d__4))]
		private IEnumerator FitResizeDimensionToAspectRatioAtEndOfFrame()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0x7B696D0", Offset = "0x7B680D0", VA = "0x187B696D0")]
		private void FitResizeDimensionToAspectRatio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(RVA = "0x7B69990", Offset = "0x7B68390", VA = "0x187B69990")]
		private float GetScreenAspectRatio(RectTransform rectTransform)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
		public RectTransformAspectRatioResizer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public static class RectTransformUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000975")]
		[Cpp2IlInjected.Address(RVA = "0x7B69CD0", Offset = "0x7B686D0", VA = "0x187B69CD0")]
		public static void MatchSourceLossyScale(this Transform source, Transform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000976")]
		[Cpp2IlInjected.Address(RVA = "0x7B69BD0", Offset = "0x7B685D0", VA = "0x187B69BD0")]
		public static Vector2 GetPivotFromAnchor(TextAnchor anchor)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class RRUIBinderAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000977")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
