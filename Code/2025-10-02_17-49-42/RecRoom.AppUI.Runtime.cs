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
using RecRoom.AI.RoomieAI;
using RecRoom.AI.RoomieAI.Personality;
using RecRoom.AppUI.Data;
using RecRoom.Attributes;
using RecRoom.Core.Creation;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using TMPro;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.EventSystems;
using UnityEngine.Events;
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
	[IHBEENDFBCJ(EAHEBLGAGFP.Self, false, false, false)]
	private SpriteRenderer spriteRenderer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private Sprite originalSprite;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Sprite LLJHLOAHJMG;

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
	private float IMJNMGPMEDM;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static Vector3[] DDKIBMHODHE;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static Vector3[] PDFKHDCIAEN;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static List<Vector2> GBLGEOJAPEM;

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static List<ushort> MEEHPHBMNCI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public float AFNGDDLCHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD89940", Offset = "0xD88340", VA = "0x180D89940")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8281800", Offset = "0x8280200", VA = "0x188281800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool ABKNODLGLKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xF2C990", Offset = "0xF2B390", VA = "0x180F2C990")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8281880", Offset = "0x8280280", VA = "0x188281880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int GICMLDHNIDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xACB3E0", Offset = "0xAC9DE0", VA = "0x180ACB3E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8281890", Offset = "0x8280290", VA = "0x188281890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8281640", Offset = "0x8280040", VA = "0x188281640")]
	public void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x82812D0", Offset = "0x827FCD0", VA = "0x1882812D0")]
	public void ForceRegenerateSprite()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8281290", Offset = "0x827FC90", VA = "0x188281290")]
	private void FEINIGFAMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x82813B0", Offset = "0x827FDB0", VA = "0x1882813B0")]
	private void LCFCMPFLBDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x82815A0", Offset = "0x827FFA0", VA = "0x1882815A0")]
	private Vector4 PECPIDEIOHH(Sprite HPKKCNLEGJA)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8281440", Offset = "0x827FE40", VA = "0x188281440")]
	private Sprite NIOPELNKBNC(Sprite GHANLDMHBLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8280660", Offset = "0x827F060", VA = "0x188280660")]
	private void DIDNHNBKADN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
	public SpriteFill()
	{
	}
}
namespace _LogRegistration.RecRoom_AppUI_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8276520", Offset = "0x8274F20", VA = "0x188276520", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8286D60", Offset = "0x8285760", VA = "0x188286D60", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x29CDED0", Offset = "0x29CC8D0", VA = "0x1829CDED0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IEDAJAEIHMN
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DMLNEJMPMLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	string BFCLHODIKPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string PBPJPBFPLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	string HPIDDOCBHIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	string MPLFIBHEHPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	string LNCIAFAHIHB
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
		protected bool MCHDDKGPIGH;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public virtual bool IJCGECJLNCG
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xAB5CA0", Offset = "0xAB46A0", VA = "0x180AB5CA0", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C80", Offset = "0xAB4680", VA = "0x180AB5C80", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public virtual float PAPHJFANNLM
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xB05990", Offset = "0xB04390", VA = "0x180B05990", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public virtual float OHIPDGIDALN
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xB059A0", Offset = "0xB043A0", VA = "0x180B059A0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xD82590", Offset = "0xD80F90", VA = "0x180D82590")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xD82590", Offset = "0xD80F90", VA = "0x180D82590")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x827BDC0", Offset = "0x827A7C0", VA = "0x18827BDC0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x827BD80", Offset = "0x827A780", VA = "0x18827BD80", Slot = "8")]
		public virtual bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
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
		private List<RRUIGameObjectLayoutElement> DPGHAMJHDME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int OOAANNJOLJN;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x827D5C0", Offset = "0x827BFC0", VA = "0x18827D5C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x827D390", Offset = "0x827BD90", VA = "0x18827D390")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x827D390", Offset = "0x827BD90", VA = "0x18827D390")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x827BFB0", Offset = "0x827A9B0", VA = "0x18827BFB0")]
		private void FGIGKMMIMKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x827D4D0", Offset = "0x827BED0", VA = "0x18827D4D0")]
		private float PKGJBNCHFIK()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x827D180", Offset = "0x827BB80", VA = "0x18827D180")]
		private bool NAELIHNGAID([Out] float GGNPHDJLFHA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x827D3A0", Offset = "0x827BDA0", VA = "0x18827D3A0")]
		private bool PCPNIBFMNOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x827C3B0", Offset = "0x827ADB0", VA = "0x18827C3B0")]
		private void HGILGALDJCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x827CA90", Offset = "0x827B490", VA = "0x18827CA90")]
		private void IOGAKADJDLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x827C2A0", Offset = "0x827ACA0", VA = "0x18827C2A0")]
		private void GBKINCKKNMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x827D500", Offset = "0x827BF00", VA = "0x18827D500")]
		[ContextMenu("RebuildLayout")]
		public void RebuildLayout()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x827D5D0", Offset = "0x827BFD0", VA = "0x18827D5D0")]
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
		private Sprite LOLCMKOMPLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool PKBOOGBJHHC;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override bool IJCGECJLNCG
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x827D7A0", Offset = "0x827C1A0", VA = "0x18827D7A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public override float PAPHJFANNLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x827D880", Offset = "0x827C280", VA = "0x18827D880", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public override float OHIPDGIDALN
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x827D6E0", Offset = "0x827C0E0", VA = "0x18827D6E0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x827D660", Offset = "0x827C060", VA = "0x18827D660", Slot = "8")]
		public override bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
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
		private bool PKBOOGBJHHC;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool IJCGECJLNCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x827DA20", Offset = "0x827C420", VA = "0x18827DA20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override float PAPHJFANNLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x827DB00", Offset = "0x827C500", VA = "0x18827DB00", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public override float OHIPDGIDALN
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x827D9C0", Offset = "0x827C3C0", VA = "0x18827D9C0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x827D940", Offset = "0x827C340", VA = "0x18827D940", Slot = "8")]
		public override bool IsVisible()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public RRUIGameObjectTextLayoutElement()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KMLMFHPEJHO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000013")]
	IReadOnlyList<HJELELCBECL> GFCBJCHBCAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action NPGFAICJOMB;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HJELELCBECL : IEquatable<HJELELCBECL>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	NLFALPDFLDP KMOKANHHPDM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	bool HFEOKMEOPPF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	string PBPJPBFPLHP
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FKPPACPIJDL(bool CIOKAAJFEBK);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task<Texture2D> ECPFBHGOPFH();

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task<Sprite> EKHCMLDEFIB();
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum GONCMHPNDBE
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Select,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Create
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HCPPOIKBIDE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	bool KPGHHHMBPDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	EBDGCEEEFPM LFLGAGIGMDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	bool PNOBMEEPCBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool OCJNDJIFJPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	bool NHABJOHFPMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	bool IMFCAIAOLFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	AHDLCNFLGGK<bool> HPPPEIHGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool BLFELIJFEMI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool MKBPEMHPEPB
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	bool HBDCIMOHDOG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	bool BLJEOEKJPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	bool MMAEPIBMPJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "17")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	bool NDKKEPIDEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "21")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	bool NBIJDDDKAIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "23")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	bool IKLNCKPJAGB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "25")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool FBKEKEKDLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "26")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "27")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	AHDLCNFLGGK<bool> JNIIOLKAKBG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "28")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	bool MPDHBFMFAIA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "29")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "30")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	int AAJOANAKLFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "31")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "32")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	Sprite FGHOHJKPDAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "33")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	DIMPFLOIPHN PKBPEHJKLJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "36")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool CABOOABLPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "39")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "40")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	bool AOGBKHHAMBL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "41")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	AHDLCNFLGGK<bool> HLEGBDONJOE
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "43")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool MCGNAKAKCPL
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "44")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	bool EMALFHJADPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(Slot = "48")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	bool OHEBIPNMKBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "49")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool PDBMNONDJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(Slot = "55")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	AHDLCNFLGGK<bool> KJMMNFDIGPL
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "57")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	bool ICGOKLMGLED
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "59")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	AHDLCNFLGGK<bool> PEGECMAPOIP
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "60")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action MPADIDCKEHN;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<int> BBFDKBACLFC;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<bool> KJECADPAMCE;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NKJJFNJGPFO();

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void DMIAIAJBANE();

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void PDOFHBFGNHK();

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OOFDOIKJLGK(bool EKBABACGLDN);

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void AKFBDCMLNAO(List<NLFALPDFLDP> LJCMECGDLPB);

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool EKAGDLIGMBF(NLFALPDFLDP DLGBNGKOOAH);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void NFKFAOMBCBB(bool LKPDLJMGDGI);

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void EGLLEDDDGGG(bool LKPDLJMGDGI);

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void DILNLGBLBIP();

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void LEHJEACHACN();

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void GNABHCLJLFA();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void GGMLCNKEJEJ();

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void KNNKEFEHOFL();

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void MBNAAKONIAA(OMCJCLBFMAA MFKHKDDANII);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void GPFFCBBLAMP(bool LKPDLJMGDGI);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DIMPFLOIPHN : KMLMFHPEJHO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BHOAIGLBKIM(HJELELCBECL MMANHJNCHIN, [Out] NLFALPDFLDP? COCAHDEJDHE);

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AEOLGKCAPHA(int KABGMIEBEFC);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BPPLCGFEKEP(int KABGMIEBEFC);

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KNJGAIIOCGK(IReadOnlyList<HJELELCBECL> DEOBNICLDEB);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface CALCCDAOBPO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum JLPDGEJFFJP
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		Objects,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		Favorites,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Search,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		RoomInventions
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	JLPDGEJFFJP OKJALPAKOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	IReadOnlyList<NIDNGJKLFHH> MDOPDHCOOIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action EMIOIMPALFF;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LJLFAJOAJFL();

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JEIINAOCFMJ();

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void APEGBHJFCCI(string MIFEHAHCDJO = "", MJCLEJBAMDB LGMILEHGKAH = MJCLEJBAMDB.None);

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KGMLMGGLMBK();

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JINACCGEIGL();

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JINACCGEIGL(string ABOBMDKLEBE);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface PLNOCINMGDG : IEquatable<PLNOCINMGDG>
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	bool HFEOKMEOPPF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	bool GPJEPIGAIAG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	bool EDLJNOKOION
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	string MGDODHAKGNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	bool AKFMFBNACPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool BHELCJIMOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action CJLHOOMAGDE;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task<bool> PJNLNEJDOCM(bool CIOKAAJFEBK);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KMNHKLFNDDK(bool BCMJPMHIODI);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void PABEMBFHHNM();

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LGNLDEKHMAJ();
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class NIDNGJKLFHH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public PLNOCINMGDG FHILKHHCNKC
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public NLFALPDFLDP KDKCJPMOHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x10FB480", Offset = "0x10F9E80", VA = "0x1810FB480")]
		[CompilerGenerated]
		get
		{
			return default(NLFALPDFLDP);
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x8277310", Offset = "0x8275D10", VA = "0x188277310")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public abstract string PBPJPBFPLHP
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract HJELELCBECL NNKJGENNLJH();

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract Task<string> NHGONELCODL();

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract Task<Texture2D> ECPFBHGOPFH();

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void NLJLJHLEKOI();

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	protected NIDNGJKLFHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct NLFALPDFLDP
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum DCKOHANCKPK
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		Prop,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		Invention
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private DCKOHANCKPK DGNODDPLLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private Guid? PKELPKLAMIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private long? JJCEBKKHAMA;

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x8277330", Offset = "0x8275D30", VA = "0x188277330")]
	public static NLFALPDFLDP FIJNMDAEHKG(Guid? DHNJEDOBNMM)
	{
		return default(NLFALPDFLDP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x82773D0", Offset = "0x8275DD0", VA = "0x1882773D0")]
	public static NLFALPDFLDP MPOAJDDFHKD(long? BFGCNPHCNPN)
	{
		return default(NLFALPDFLDP);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8277660", Offset = "0x8276060", VA = "0x188277660")]
	private NLFALPDFLDP(DCKOHANCKPK DGNODDPLLPC, Guid? DHNJEDOBNMM, long? BFGCNPHCNPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x82775C0", Offset = "0x8275FC0", VA = "0x1882775C0")]
	public bool PEJNBADFPEO([Out] Guid OCONCDFGCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8277350", Offset = "0x8275D50", VA = "0x188277350")]
	public bool LDOFMPKJADL([Out] long BFGCNPHCNPN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x82773F0", Offset = "0x8275DF0", VA = "0x1882773F0")]
	public static bool NOPNAEDOCOI(NLFALPDFLDP EICJFDNFOCB, NLFALPDFLDP MIBIEOGGIAP)
	{
		return default(bool);
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RRUIBinder]
	public class AccountBadgeIconBinder : BaseBinder<AccountBadgeIconType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private AccountBadgeIconView accountBadgeView;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x826CD50", Offset = "0x826B750", VA = "0x18826CD50", Slot = "20")]
		protected override void OnDataUpdated(AccountBadgeIconType dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x826CDF0", Offset = "0x826B7F0", VA = "0x18826CDF0")]
		public AccountBadgeIconBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[RRUIBinder]
	public class AccountLeagueIconBinder : BaseBinder<AccountLeagueIconType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private AccountLeagueIconView accountLeagueView;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x826CFD0", Offset = "0x826B9D0", VA = "0x18826CFD0", Slot = "20")]
		protected override void OnDataUpdated(AccountLeagueIconType dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x826D070", Offset = "0x826BA70", VA = "0x18826D070")]
		public AccountLeagueIconBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AccountRoleIconViewBinder : BaseBinder<AccountRoleIconType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private AccountRoleView accountRoleView;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x826E4F0", Offset = "0x826CEF0", VA = "0x18826E4F0", Slot = "20")]
		protected override void OnDataUpdated(AccountRoleIconType dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x826E590", Offset = "0x826CF90", VA = "0x18826E590")]
		public AccountRoleIconViewBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[RRUIBinder]
	public class ButtonFocusedActionBinder : BaseBinder<Action>
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public enum FocusedState
		{
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			Focused,
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			Unfocused,
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			Both
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private RRUIButton button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private FocusedState focusedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private bool focused;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8272940", Offset = "0x8271340", VA = "0x188272940", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8272BD0", Offset = "0x82715D0", VA = "0x188272BD0", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "20")]
		protected override void OnDataUpdated(Action dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8272A40", Offset = "0x8271440", VA = "0x188272A40")]
		protected void OnButtonStateChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8272CB0", Offset = "0x82716B0", VA = "0x188272CB0")]
		public ButtonFocusedActionBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[RRUIBinder]
	public class ButtonFocusedStateBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public enum FocusedState
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			Focused,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			Unfocused,
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			Both
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private RRUIButton button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private BindDirection bindDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private FocusedState focusedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private bool focused;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8272CF0", Offset = "0x82716F0", VA = "0x188272CF0", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8273380", Offset = "0x8271D80", VA = "0x188273380", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x82730F0", Offset = "0x8271AF0", VA = "0x1882730F0", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8272F50", Offset = "0x8271950", VA = "0x188272F50")]
		protected void OnButtonStateChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8273110", Offset = "0x8271B10", VA = "0x188273110")]
		protected void SyncButtonState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8273460", Offset = "0x8271E60", VA = "0x188273460")]
		public ButtonFocusedStateBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[RRUIBinder]
	public class CardHighlightStyleAspectRatioBinder : BaseBinder<HighlightStyle>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public class HighlightStyleAspectRatio
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public HighlightStyle Style;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public float AspectRatio;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x2A25F20", Offset = "0x2A24920", VA = "0x182A25F20")]
			public HighlightStyleAspectRatio()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private AspectRatioFitter aspectRatioFitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private RecNetRawImage recNetRawImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		private List<HighlightStyleAspectRatio> aspectRatios;

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x82734B0", Offset = "0x8271EB0", VA = "0x1882734B0", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x82737B0", Offset = "0x82721B0", VA = "0x1882737B0", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x82735B0", Offset = "0x8271FB0", VA = "0x1882735B0")]
		protected void OnImageLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "20")]
		protected override void OnDataUpdated(HighlightStyle dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x82738B0", Offset = "0x82722B0", VA = "0x1882738B0")]
		public CardHighlightStyleAspectRatioBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[RRUIBinder]
	public class CarouselHeightBinder : BaseBinder<float?>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[SerializeField]
		private List<LayoutElement> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[SerializeField]
		private LayoutElementSizeBinder.LayoutElementSizeTarget targetSize;

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x82738F0", Offset = "0x82722F0", VA = "0x1882738F0", Slot = "15")]
		public override void Bind(GameObject bindingObject, bool isListItem, int listItemIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8273A10", Offset = "0x8272410", VA = "0x188273A10", Slot = "20")]
		protected override void OnDataUpdated(float? dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8273D00", Offset = "0x8272700", VA = "0x188273D00")]
		public CarouselHeightBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[RRUIBinder]
	public class CarouselItemSizeBinder : BaseBinder<float?>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8273D40", Offset = "0x8272740", VA = "0x188273D40", Slot = "20")]
		protected override void OnDataUpdated(float? dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8273DF0", Offset = "0x82727F0", VA = "0x188273DF0")]
		public CarouselItemSizeBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[RRUIBinder]
	public class CarouselItemWidthHeightBinder : BaseBinder<Vector2>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8273E30", Offset = "0x8272830", VA = "0x188273E30", Slot = "20")]
		protected override void OnDataUpdated(Vector2 dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8273EE0", Offset = "0x82728E0", VA = "0x188273EE0")]
		public CarouselItemWidthHeightBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[RRUIBinder]
	public class CarouselRowCountBinder : BaseBinder<int>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedScrollRectList;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8273F20", Offset = "0x8272920", VA = "0x188273F20", Slot = "20")]
		protected override void OnDataUpdated(int dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8273FC0", Offset = "0x82729C0", VA = "0x188273FC0")]
		public CarouselRowCountBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[RRUIBinder]
	public class ConditionalPrefabSpawnBinder : BaseBinder<bool>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private struct <LoadPrefab>d__8 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public ConditionalPrefabSpawnBinder <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x8285220", Offset = "0x8283C20", VA = "0x188285220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[SerializeField]
		private MultiPrefabSpawner prefabSpawner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[SerializeField]
		private AssetReference prefabReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[SerializeField]
		private bool prependSpawnedObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private bool invert;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private AACADPLMCLK<GameObject> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8274000", Offset = "0x8272A00", VA = "0x188274000", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8274230", Offset = "0x8272C30", VA = "0x188274230", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x82743D0", Offset = "0x8272DD0", VA = "0x1882743D0", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x8274180", Offset = "0x8272B80", VA = "0x188274180")]
		[AsyncStateMachine(typeof(<LoadPrefab>d__8))]
		private void LoadPrefab()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		private void OnPopulateInstance(GameObject instance, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		private void OnCleanupInstance(GameObject instance, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8274590", Offset = "0x8272F90", VA = "0x188274590")]
		public ConditionalPrefabSpawnBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[RRUIBinder]
	public class DynamicUIElementsBinder : BaseBinder<DataList>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private DynamicUIModel dynamicUIModel;

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x82745D0", Offset = "0x8272FD0", VA = "0x1882745D0", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8274670", Offset = "0x8273070", VA = "0x188274670")]
		public DynamicUIElementsBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[RRUIBinder]
	public class HideableBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		[SerializeField]
		private Hideable hideable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		[SerializeField]
		private bool invert;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x82746B0", Offset = "0x82730B0", VA = "0x1882746B0", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8274750", Offset = "0x8273150", VA = "0x188274750")]
		public HideableBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[RRUIBinder]
	public class HtmlColorStringToColorBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private List<Image> targetList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Color htmlColor;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8274790", Offset = "0x8273190", VA = "0x188274790", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8274950", Offset = "0x8273350", VA = "0x188274950")]
		public HtmlColorStringToColorBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[RRUIBinder]
	public class HydrationStateBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[SerializeField]
		private List<HydrateBase> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[SerializeField]
		private bool invert;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8274990", Offset = "0x8273390", VA = "0x188274990", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8274AC0", Offset = "0x82734C0", VA = "0x188274AC0")]
		public HydrationStateBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[RRUIBinder]
	public class ImageKeyBinder : BaseBinder<string>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private struct <LoadImage>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public ImageKeyBinder <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public AssetReference assetReference;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private AsyncOperationHandle<Sprite> <handle>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private TaskAwaiter<Sprite> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x8284F70", Offset = "0x8283970", VA = "0x188284F70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[SerializeField]
		private Image targetImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[SerializeField]
		private AssetReferenceLookup imageKeyLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private AssetReference currentAsset;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8274BE0", Offset = "0x82735E0", VA = "0x188274BE0", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8274D90", Offset = "0x8273790", VA = "0x188274D90", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8274D40", Offset = "0x8273740", VA = "0x188274D40")]
		private void ReleaseAsset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8274B00", Offset = "0x8273500", VA = "0x188274B00")]
		[AsyncStateMachine(typeof(<LoadImage>d__6))]
		private void LoadImage(AssetReference assetReference)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8274DF0", Offset = "0x82737F0", VA = "0x188274DF0")]
		public ImageKeyBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[RRUIBinder]
	public class ImposterImageBinder : BaseBinder<KAHAAKGFHGH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[SerializeField]
		private ImposterRawImage imposterImage;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8274E30", Offset = "0x8273830", VA = "0x188274E30", Slot = "20")]
		protected override void OnDataUpdated(KAHAAKGFHGH dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8274EC0", Offset = "0x82738C0", VA = "0x188274EC0")]
		public ImposterImageBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[RRUIBinder]
	public class InfiniteListBinder : BaseBinder<DataList>, KKONBCIODFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[SerializeField]
		protected InfiniteListViewControllerBase infiniteList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[SerializeField]
		protected GameObject defaultPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private int sourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private int listId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private HashSet<int> loadedItems;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public int ItemCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xD8DE70", Offset = "0xD8C870", VA = "0x180D8DE70", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x163A020", Offset = "0x1638A20", VA = "0x18163A020")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public AHDLCNFLGGK<int> OnItemAtIndexLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6550", VA = "0x180AB7B50", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public IReadOnlyCollection<MADECIDFECK> VisibleItems
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8275B20", Offset = "0x8274520", VA = "0x188275B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8274F60", Offset = "0x8273960", VA = "0x188274F60", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8274FF0", Offset = "0x82739F0", VA = "0x188274FF0", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x82754D0", Offset = "0x8273ED0", VA = "0x1882754D0")]
		protected void RefreshActiveItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x82753D0", Offset = "0x8273DD0", VA = "0x1882753D0", Slot = "27")]
		public virtual void OnItemVisible(InfiniteListDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8275340", Offset = "0x8273D40", VA = "0x188275340", Slot = "28")]
		public virtual void OnItemRefresh(InfiniteListDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8275140", Offset = "0x8273B40", VA = "0x188275140", Slot = "29")]
		public virtual void OnItemHidden(InfiniteListDataItem item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xAB7B30", Offset = "0xAB6530", VA = "0x180AB7B30", Slot = "30")]
		public virtual GameObject GetPrefabForIndex(int index)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8274F00", Offset = "0x8273900", VA = "0x188274F00", Slot = "31")]
		public virtual bool IsItemLoaded(InfiniteListDataItem item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8275250", Offset = "0x8273C50", VA = "0x188275250")]
		protected void OnItemLoaded(DataListItemBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8275A20", Offset = "0x8274420", VA = "0x188275A20")]
		public InfiniteListBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[RRUIBinder]
	public class LimitedCapacityListBinder : BaseBinder<DataList>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[SerializeField]
		protected List<BaseLocalViewModel> limitedListObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[SerializeField]
		private GameObject overflowIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[SerializeField]
		private TMP_Text overflowText;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8276090", Offset = "0x8274A90", VA = "0x188276090", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x82764E0", Offset = "0x8274EE0", VA = "0x1882764E0")]
		public LimitedCapacityListBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[RRUIBinder]
	public class MultiPrefabSpawnerListBinder : BaseBinder<DataList>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private MultiPrefabSpawner multiPrefabSpawner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private GameObject defaultPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int sourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int listId;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8276F30", Offset = "0x8275930", VA = "0x188276F30", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8276DD0", Offset = "0x82757D0", VA = "0x188276DD0", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8277180", Offset = "0x8275B80", VA = "0x188277180", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8276FC0", Offset = "0x82759C0", VA = "0x188276FC0", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8277070", Offset = "0x8275A70", VA = "0x188277070", Slot = "21")]
		protected virtual void OnInstanceCleanupEvent(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x82770E0", Offset = "0x8275AE0", VA = "0x1882770E0", Slot = "22")]
		protected virtual void OnInstanceSpawnedEvent(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x82772C0", Offset = "0x8275CC0", VA = "0x1882772C0")]
		public MultiPrefabSpawnerListBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[RRUIBinder]
	public class NavigationModeSwapBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private List<Selectable> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private Navigation activeNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		private Navigation inactiveNavigation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[SerializeField]
		private bool invert;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x82778E0", Offset = "0x82762E0", VA = "0x1882778E0", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8277AE0", Offset = "0x82764E0", VA = "0x188277AE0")]
		public NavigationModeSwapBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PageNavigationHelper : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		private Uri destinationUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		private string analyticsButtonName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private RRUIButton button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8278040", Offset = "0x8276A40", VA = "0x188278040")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x82782A0", Offset = "0x8276CA0", VA = "0x1882782A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x82781E0", Offset = "0x8276BE0", VA = "0x1882781E0")]
		public void NavigateToPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8278510", Offset = "0x8276F10", VA = "0x188278510")]
		public void SetUriData(string uriDataKey, int data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8278410", Offset = "0x8276E10", VA = "0x188278410")]
		public void SetUriData(string uriDataKey, string data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8278490", Offset = "0x8276E90", VA = "0x188278490")]
		public void SetUriData(string uriDataKey, float data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8278380", Offset = "0x8276D80", VA = "0x188278380")]
		public void SetUriData(string uriDataKey, Guid data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x8278590", Offset = "0x8276F90", VA = "0x188278590")]
		public PageNavigationHelper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class PageNavigationHelperUriDataBinder : BaseBinder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		private PageNavigationHelper target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		private string uriDataKey;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8277B20", Offset = "0x8276520", VA = "0x188277B20", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8277FE0", Offset = "0x82769E0", VA = "0x188277FE0")]
		public PageNavigationHelperUriDataBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[RRUIBinder]
	public class PlayerColorSpriteBinder : BaseBinder<IPlayerColor>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		private SpriteRenderer target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private IPlayerUIBridge.PlayerColorType _colorType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		private Color defaultColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		[FFBOEEGEIOD("_colorType", new object[] { 3, 5 })]
		private Color customColor;

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x82785F0", Offset = "0x8276FF0", VA = "0x1882785F0", Slot = "20")]
		protected override void OnDataUpdated(IPlayerColor dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8278790", Offset = "0x8277190", VA = "0x188278790")]
		public PlayerColorSpriteBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[RRUIBinder]
	public class PlayerColorTextBinder : BaseBinder<IPlayerColor>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[SerializeField]
		private TMP_Text target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		private IPlayerUIBridge.PlayerColorType _colorType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[SerializeField]
		private Color defaultColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[SerializeField]
		[FFBOEEGEIOD("_colorType", new object[] { 3, 5 })]
		private Color customTextColor;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x82787E0", Offset = "0x82771E0", VA = "0x1882787E0", Slot = "20")]
		protected override void OnDataUpdated(IPlayerColor dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x82789B0", Offset = "0x82773B0", VA = "0x1882789B0")]
		public PlayerColorTextBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[RRUIBinder]
	public class RecNetRawImageBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[SerializeField]
		private RecNetRawImage target;

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x827DB60", Offset = "0x827C560", VA = "0x18827DB60", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x827DBF0", Offset = "0x827C5F0", VA = "0x18827DBF0")]
		public RecNetRawImageBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[RRUIBinder]
	public class RectTransformHeightSwapBinder : BaseBinder<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[SerializeField]
		private List<RectTransform> targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		private float activeHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private float inactiveHeight;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x827FF90", Offset = "0x827E990", VA = "0x18827FF90", Slot = "20")]
		protected override void OnDataUpdated(bool dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8280100", Offset = "0x827EB00", VA = "0x188280100")]
		public RectTransformHeightSwapBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[RRUIBinder]
	public class RoomSourceUriLinkButtonBinder : BaseBinder<RoomListQueryData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private Button button;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private Uri targetUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		private bool useQueryDataInUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		[FFBOEEGEIOD("useQueryDataInUri")]
		private bool overrideQueryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private RoomListQueryData queryDataOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		private bool overrideLoadSceneSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[FFBOEEGEIOD("overrideLoadSceneSource")]
		[SerializeField]
		private MKJBCDALEDO loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8280140", Offset = "0x827EB40", VA = "0x188280140", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8280540", Offset = "0x827EF40", VA = "0x188280540", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "20")]
		protected override void OnDataUpdated(RoomListQueryData dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x82802D0", Offset = "0x827ECD0", VA = "0x1882802D0")]
		private void OnButtonClick()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8280620", Offset = "0x827F020", VA = "0x188280620")]
		public RoomSourceUriLinkButtonBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[RRUIBinder]
	public class StringToWidgetWrapperBinder : BaseBinder<string>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		private WidgetWrapperViewModel widgetWrapper;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x82818C0", Offset = "0x82802C0", VA = "0x1882818C0", Slot = "20")]
		protected override void OnDataUpdated(string dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8281980", Offset = "0x8280380", VA = "0x188281980")]
		public StringToWidgetWrapperBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[RRUIBinder]
	public class VirtualizedScrollRectListBinder : BaseBinder<DataList>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SerializeField]
		private VirtualizedScrollRectList virtualizedList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int sourceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private int listId;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8286430", Offset = "0x8284E30", VA = "0x188286430", Slot = "14")]
		public override void Bind(GameObject bindingObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x82866A0", Offset = "0x82850A0", VA = "0x1882866A0", Slot = "17")]
		public override void OnDataItemUpdate(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8286730", Offset = "0x8285130", VA = "0x188286730", Slot = "20")]
		protected override void OnDataUpdated(DataList dataValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8286AA0", Offset = "0x82854A0", VA = "0x188286AA0", Slot = "16")]
		public override void Unbind()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x82869A0", Offset = "0x82853A0", VA = "0x1882869A0", Slot = "21")]
		protected virtual void OnItemVisible(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8286900", Offset = "0x8285300", VA = "0x188286900", Slot = "22")]
		protected virtual void OnItemRefresh(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x82867E0", Offset = "0x82851E0", VA = "0x1882867E0", Slot = "23")]
		protected virtual void OnItemInvisible(GameObject go, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8286850", Offset = "0x8285250", VA = "0x188286850")]
		private void OnItemLoaded(DataListItemBinder binder, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8286D10", Offset = "0x8285710", VA = "0x188286D10")]
		public VirtualizedScrollRectListBinder()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public interface IIconConfig
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		AssetReferenceT<Sprite> BackgroundFillIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		AssetReferenceT<Sprite> BackgroundOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		AssetReferenceT<Sprite> BadgeIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		AssetReferenceT<Sprite> BadgeOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public interface IIconData<T> where T : Enum
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryGetConfig(T enumValue, [Out] IIconConfig config);
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public abstract class EnumIconDataViewBase<T, U> : MonoBehaviour where T : Enum where U : IIconData<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private T defaultIconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private U iconData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		[Header("Image Targets")]
		protected List<Image> backgroundOutlineImageTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		protected List<Image> backgroundFillImageTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		protected List<Image> iconOutlineImageTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		protected List<Image> iconFillImageTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[Header("Sprite Renderer Targets")]
		[SerializeField]
		protected List<SpriteRenderer> backgroundOutlineSpriteRendererTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		protected List<SpriteRenderer> backgroundFillSpriteRendererTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		protected List<SpriteRenderer> iconOutlineSpriteRendererTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		protected List<SpriteRenderer> iconFillSpriteRendererTargets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private T iconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private bool iconTypeSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private List<AACADPLMCLK<Sprite>> resourceHandles;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x4B957D0", Offset = "0x4B941D0", VA = "0x184B957D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4B948A0", Offset = "0x4B932A0", VA = "0x184B948A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4B94D20", Offset = "0x4B93720", VA = "0x184B94D20")]
		private void ReleaseSpriteHandles()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4B95030", Offset = "0x4B93A30", VA = "0x184B95030")]
		public void SetIconType(T newIconType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x4B95850", Offset = "0x4B94250", VA = "0x184B95850")]
		private void UpdateIcons()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4B948E0", Offset = "0x4B932E0", VA = "0x184B948E0")]
		private void LoadAndSetupSprite(AssetReference spriteReference, List<Image> imageTargets, List<SpriteRenderer> spriteRendererTargets)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x4B95230", Offset = "0x4B93C30", VA = "0x184B95230")]
		private void SetImageTargetsToIcon(List<Image> targets, Sprite icon)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4B95410", Offset = "0x4B93E10", VA = "0x184B95410")]
		private void SetSpriteRendererTargetsToIcon(List<SpriteRenderer> targets, Sprite icon)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x4B95D40", Offset = "0x4B94740", VA = "0x184B95D40")]
		protected EnumIconDataViewBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class MakerPenHUDNavigationInputState
	{
		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public class NavInputState
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public float MinHoldDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public float HoldDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public float LastHoldDuration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public bool WasHeldLastFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public AHDLCNFLGGK<NavInputState> NavInputStateChanged;

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public bool IsPressed
			{
				[Cpp2IlInjected.Token(Token = "0x6000134")]
				[Cpp2IlInjected.Address(RVA = "0x13F3410", Offset = "0x13F1E10", VA = "0x1813F3410")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public bool IsHeld
			{
				[Cpp2IlInjected.Token(Token = "0x6000135")]
				[Cpp2IlInjected.Address(RVA = "0x82778C0", Offset = "0x82762C0", VA = "0x1882778C0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public bool WasHeldLastPress
			{
				[Cpp2IlInjected.Token(Token = "0x6000136")]
				[Cpp2IlInjected.Address(RVA = "0x82778D0", Offset = "0x82762D0", VA = "0x1882778D0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x82777B0", Offset = "0x82761B0", VA = "0x1882777B0")]
			public void UpdateHold(float holdDuration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x8277740", Offset = "0x8276140", VA = "0x188277740")]
			public void StopHold()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x8277820", Offset = "0x8276220", VA = "0x188277820")]
			public NavInputState()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private Dictionary<MakerPenHUDNavInputType, NavInputState> navInputStates;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8276C40", Offset = "0x8275640", VA = "0x188276C40")]
		public MakerPenHUDNavigationInputState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8276AE0", Offset = "0x82754E0", VA = "0x188276AE0")]
		public void Initialize(float minHoldDuration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8276BD0", Offset = "0x82755D0", VA = "0x188276BD0")]
		public bool TryGetNavInputState(MakerPenHUDNavInputType inputType, [Out] NavInputState navInputState)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8276B60", Offset = "0x8275560", VA = "0x188276B60")]
		public void Reset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public abstract class BaseBindableObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public string ObjectName
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000007")]
		public event Action<string> OnObjectChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x82727E0", Offset = "0x82711E0", VA = "0x1882727E0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8272890", Offset = "0x8271290", VA = "0x188272890", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x82727C0", Offset = "0x82711C0", VA = "0x1882727C0")]
		protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		protected BaseBindableObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public interface IInterfacesTeamHelper
	{
		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		bool RRUIPerfEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		double RRUIPerfSlowFramesSec
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public enum MakerPenHUDNavInputType
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		LeftModifier,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		RightModifier,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		MAX
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public interface IMakerPenHUDBridge
	{
		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		Guid MakerPenSessionGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		MakerPenHUDNavigationInputState NavigationInputState
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		bool UseCuratedControls
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		EBDGCEEEFPM UseCuratedControlsUpdated
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		string InputModeForAnalytics
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		bool IsUndoAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		bool IsRedoAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		EBDGCEEEFPM UndoStackEntriesChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		bool OnCreateMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		bool OnSelectMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		string ToolDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(Slot = "17")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		bool IsRRUIPageContainerEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(Slot = "26")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		AHDLCNFLGGK<bool> RRUIPageContainerEnabledChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		bool OnCloneMode
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		bool OnConfigMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(Slot = "29")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		bool OnDeleteMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(Slot = "30")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		bool InTransformModeAndMoveOn
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "31")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		bool InTransformModeAndRotateOn
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(Slot = "32")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		bool InTransformModeAndScaleOn
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(Slot = "33")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		bool IsDeleteAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(Slot = "34")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		bool IsRecolorMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(Slot = "37")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		bool ShowColorPicker
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(Slot = "38")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		AHDLCNFLGGK<bool> ColorPickerToggled
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(Slot = "39")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		bool IsAdjustModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(Slot = "40")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		bool IsPrecisionModifierModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(Slot = "41")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		AHDLCNFLGGK<bool> StampModeChanged
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(Slot = "59")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		bool PaletteIsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(Slot = "60")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		CALCCDAOBPO PaletteDataStore
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(Slot = "61")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		bool IsPaletteSearchOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(Slot = "78")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		string CurrentPaletteSearchString
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(Slot = "82")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		CategoriesNestedListConfig Config
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(Slot = "87")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		NIDNGJKLFHH ToFocusOnReturnToPalette
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(Slot = "88")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(Slot = "89")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		HPELOPLNJCC Configurable
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(Slot = "90")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		EBDGCEEEFPM MakerPenConfigMenuDataChangedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(Slot = "91")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		bool IsCursorActive
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(Slot = "94")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		AHDLCNFLGGK<bool> CursorActiveChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(Slot = "95")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		bool IsInSubMenu
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(Slot = "97")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		AHDLCNFLGGK<bool> IsInSubMenuChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(Slot = "98")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		bool ShouldUseButtonNavigation
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(Slot = "99")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		bool ButtonShortcutsEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(Slot = "100")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		EBDGCEEEFPM ButtonShortcutsEnabledChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(Slot = "101")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000008")]
		event Action CurrentModeChanged;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		event Action CurrentSelectionChanged;

		[Cpp2IlInjected.Token(Token = "0x1400000A")]
		event Action PrecisionModifierModeActiveChanged;

		[Cpp2IlInjected.Token(Token = "0x1400000B")]
		event Action<int> ColorPickerCardSelected;

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		event Action OnConfigure;

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		event Action HotbarSelectionCleared;

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		event Action ObjectCreated;

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		event Action<bool> PaletteToggled;

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		event Action PaletteNeedsVisualRefresh;

		[Cpp2IlInjected.Token(Token = "0x14000011")]
		event Action<string, MJCLEJBAMDB> PaletteSwitchToObjectsCategoryRequested;

		[Cpp2IlInjected.Token(Token = "0x14000012")]
		event Action PaletteSwitchToFavoritesCategoryRequested;

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		event Action PaletteSwitchToRoomInventionsCategoryRequested;

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		event Action<bool> PaletteToggledToOpen;

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		event Action<string> SearchStringChanged;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void TriggerUndo();

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void TriggerRedo();

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void GoToCreateMode();

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void GoToSelectMode();

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "18")]
		void EnterDeleteMode();

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "19")]
		void RequestAdjustMode();

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "20")]
		void ToggleCloneMode();

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "21")]
		void ToggleMoveMode();

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "22")]
		void ToggleRotateMode();

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "23")]
		void ToggleScaleMode();

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "24")]
		void ToggleConfigMode();

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void PressRecolorButton();

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void ExitRecolorMode();

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "46")]
		void ChangeColor(Enum shapeColor, int index);

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "51")]
		void OnConfigButtonPressed();

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "52")]
		bool IsColorSelected(Enum colorId);

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "57")]
		void SelectHotbarSlot(int index);

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "58")]
		void RemoveHotbarItem(int index);

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "64")]
		void TogglePalette();

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "65")]
		void ShowOrHideGlobalToolbarAccordingToPaletteState();

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "68")]
		void PaletteObjectToggleSelected(NIDNGJKLFHH placable);

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "69")]
		void PaletteObjectToggleFavorited(NIDNGJKLFHH placable);

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "70")]
		bool DoesHotbarContainPaletteObject(NIDNGJKLFHH placable);

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(Slot = "71")]
		void RequestMakerPenHUDMenuToggleIfNeeded(bool open);

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "81")]
		void TogglePaletteSearch();

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "85")]
		void SetSearchString(string newSearchString);

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(Slot = "86")]
		void CategoryFilterChanged(CategoriesFilter filter);

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(Slot = "92")]
		void PresentTypedDialog(DialogListModel dialogListModel, MBDBPDMIJMG dialogType, FKGFKBCFFBN dialogData);

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "93")]
		IReadOnlyList<ILNCJONKHIP> GetObjectPropertyDynamicUIData(HPELOPLNJCC configurable, bool isQuickConfig);

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(Slot = "96")]
		void EndCursor();
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class MakerPenHUDAnalyticsKeys
	{
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public static string SessionKey;

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public static string InputModeKey;

		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public static string InputMode_Cursor;

		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public static string InputMode_ButtonNav;

		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public static string InputMode_Touch;

		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public static string GlobalBarName;

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public static string SelectBarName;

		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public static string PrevSelectModeKey;

		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public static string SelectModeKey;

		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public static string PrecisionMode_Move;

		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public static string PrecisionMode_Rotate;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public static string PrecisionMode_Scale;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static string CreateBarName;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static string PaletteMRUSlotType;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public static string RemovePaletteMRUSlotType;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public static string PaletteMRUSlotObjectTypeKey;

		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public static string PaletteMRUSlot_Prop;

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public static string PaletteMRUSlot_Invention;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public static string StampModeKey;
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public enum MenuType
	{
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		AppNav,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		Watch
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public interface IMenuManager
	{
		[Cpp2IlInjected.Token(Token = "0x17000077")]
		Guid WatchMenuUnifiedSessionId
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		AHDLCNFLGGK<Guid> WatchMenuUnifiedSessionIdChangedEvent
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		MenuType LastClosedMenuType
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		float LastClosedMenuTime
		{
			[Cpp2IlInjected.Token(Token = "0x60001AD")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void Reset();
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class InterfacesTeamHelper : IInterfacesTeamHelper
	{
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private static string RRUI_PERF_EXPERIMENT_NAME;

		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static string RRUI_PERF_ENABLED_PARAMETER_NAME;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static string RRUI_PERF_SLOW_FRAMES_PARAMETER_NAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private CMANBFFCBML statSigProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private bool? rruiPerfEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private double? slowFramesSec;

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public bool RRUIPerfEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x8275D50", Offset = "0x8274750", VA = "0x188275D50", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public double RRUIPerfSlowFramesSec
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8275EF0", Offset = "0x82748F0", VA = "0x188275EF0", Slot = "5")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8275B70", Offset = "0x8274570", VA = "0x188275B70")]
		[DMKNBLIJJON.EGFDFBOLNDK.IOMGPCDPIJG]
		internal static void InitializeOnLoad(JBJKIIKOACK container)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xABA5E0", Offset = "0xAB8FE0", VA = "0x180ABA5E0")]
		[UnityEngine.Scripting.Preserve]
		internal InterfacesTeamHelper([BMCONCJPCIA(null)][NotNull] CMANBFFCBML statSigProvider)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public interface IOrderedRenderable
	{
		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		bool RenderInCarouselOrder
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(Slot = "0")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		bool AllowRender
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		bool HasRefreshed
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		bool RequiresRefresh
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public interface IRoomieBridge
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task UpdateUserKnowledgeSystemMessage(CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public interface IRoomStoreCategory
	{
		[Cpp2IlInjected.Token(Token = "0x17000081")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		Sprite Icon
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		List<IUnifiedRoomStoreItem> Items
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public interface IRRUIvNextBridge
	{
		[Cpp2IlInjected.Token(Token = "0x17000084")]
		FDEIDHKCJEA CurrentPlatformType
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		bool InVRDisplayMode
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		bool InScreensDisplayMode
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		Guid ScreensMenuUnifiedSessionId
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		bool IsDebugBuild
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		long LocalRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		PKCMPJMLDGM LocalRoomDetails
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		bool CurrentRoomInstanceIsPrivate
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		bool Discovery_ShouldDefaultPublicInstance
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		bool Discovery_ShouldDefaultPrivateInstance
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		int Discovery_NewDataTokenThresholdDays
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		bool Discovery_ShowPublishStateDataToken
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		string Discovery_StoreItemCardVariant
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		int Discovery_LimitedBadgeThresholdDays
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		bool Discovery_LimitedBadgeQolDetails
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(Slot = "14")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		bool Discovery_LimitedBadgeEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		bool WatchMenuProjector_IsWatchOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(Slot = "18")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		bool WatchMenuProject_IsUIOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(Slot = "19")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		bool WatchMenuProjector_IsMenuAnimationVisible
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(Slot = "20")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		bool ToolMenuProjector_IsMenuOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(Slot = "21")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		bool ToolMenuProjector_IsMenuAnimationVisible
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(Slot = "22")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		int UnreadWatchNotificationCount
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(Slot = "23")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		bool HideWatchNavBar
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(Slot = "24")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		Camera UICamera
		{
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		Camera ScreenModeCamera
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(Slot = "26")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		bool IsUsingTouchInput
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(Slot = "27")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		Action InputMethodChanged
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(Slot = "28")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(Slot = "29")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		EBDGCEEEFPM BrowserModel_RequestAppNavMenu
		{
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(Slot = "52")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(Slot = "16")]
		Vector2? Discovery_GetHighlightStyleCardOverride(HighlightStyle style);

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(Slot = "17")]
		string TimeSpanExtensions_GetFormatedTimeString(TimeSpan timeSpan, bool useShortUnits);

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(Slot = "30")]
		T GetConfigValue<T>(string key);

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "31")]
		void OpenWatchMenu();

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(Slot = "32")]
		void CloseWatchMenu();

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(Slot = "33")]
		void CloseActiveToolMenu();

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(Slot = "34")]
		void NavigateToLink(LinkInfo linkInfo, bool isPortalButton = false);

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(Slot = "35")]
		void GuaranteeWatchStateAndGoTo(BrowserModel browserModel, Route route);

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "36")]
		void GuaranteeWatchStateAndGoTo(BrowserModel browserModel, Uri uri);

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "37")]
		void OpenLegacyUI(LegacyUIType legacyUIType);

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "38")]
		void NavigateToUriWithRoomSourceData(BrowserModel browserModel, Uri destination, RoomListQueryData queryData, bool useLoadSceneSourceOverride = false, MKJBCDALEDO sourceOverride = MKJBCDALEDO.NOT_SET);

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "39")]
		string GetFriendlyListNameFromRoomsConfig(RoomListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "40")]
		string GetSourceStringForQueryData(RoomListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(Slot = "41")]
		bool PopulateRoomListQueryDataFromSourceInfo(string source, string sourceMetadata, RoomListQueryData queryData);

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(Slot = "42")]
		HighlightStyle GetHighlightStyleFromDiscoveryTeamHelper(string sourceLabelText, [Optional] string sizePerPlatformFromMetadata);

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(Slot = "43")]
		Task LogImpressionEvent(KLBPGLFMBCI.IBADOKOGBMO impressionEvent);

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(Slot = "44")]
		bool IsBrowserModelOnRootScreen(BrowserModel browserModel);

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(Slot = "45")]
		bool TryGetMenuOpenAction([Out] AHDLCNFLGGK<bool> menuOpenAction);

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(Slot = "46")]
		void TryTrackLatencyForBrowserRoute(string routeString);

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(Slot = "47")]
		Task<bool> ShowRoomPlayActionDialog(long roomId, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(Slot = "48")]
		Task<PMHLBPGOPPD> ShowChooseSubRoomDialog(PKCMPJMLDGM roomDetails, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(Slot = "49")]
		void ForceAcceptRoomWarnings(PPFENAOBDPL room);

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(Slot = "50")]
		Task ShowTwoButtonMessageDialog(DialogListModel dialogListModel, FEKKMALIPDK dialogData, CancellationToken token);

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(Slot = "51")]
		void Discovery_HackyTryShowUpdateTheAppDialog(BrowserModel browserModel);

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(Slot = "53")]
		Task EvictAllFromDorm();

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(Slot = "54")]
		void ShowRoomReportDialog(long roomId, string sanitizedFriendlyName);

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(Slot = "55")]
		void ApplyBrowserModelImpressionData(ImpressionTracker impressionTracker, BrowserModel browserModel, string nullBrowserRouteProperty = "appnav/quickaccess");

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(Slot = "56")]
		Task<RenderTexture> GenerateTextureForLocalAvatarAsync(CancellationToken token, int width = -1, int height = -1);

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(Slot = "57")]
		void AddNotificationRestriction(object token);

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(Slot = "58")]
		void RemoveNotificationRestriction(object token);

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(Slot = "59")]
		void OpenManageRRPlusMembershipPage();

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(Slot = "60")]
		bool CanLocalPlayerChatWith(NHEHGMDMJGF account);

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(Slot = "61")]
		void GoToChatPage(int accountId, ALCEKDGFNKH chatTelemetrySource);

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(Slot = "62")]
		void ShowEnumPickerDialog<TEnum>(DialogListModel dialogListModel, string title, Func<TEnum, string> nameGetter, Func<TEnum> selectedGetter, Action<TEnum> selectedSetter) where TEnum : Enum;
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public interface IRRUIvNextConsumableBridge
	{
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public enum ConsumableCategory
		{
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			All,
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			Food,
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			Other
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		event Action<FMBGLPEKILF> OnActiveConsumableChanged;

		[Cpp2IlInjected.Token(Token = "0x14000017")]
		event Action<FMBGLPEKILF> OnPurchasedConsumableChanged;

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		List<FMBGLPEKILF> GetLatestPurchasedNonTransferableConsumables(ConsumableCategory category, bool excludeRoomieActivated);

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void UseConsumable(FMBGLPEKILF consumable);

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(Slot = "6")]
		KAHAAKGFHGH GetConsumableImposterRequest(FMBGLPEKILF consumable);

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool IsConsumableSpawned(FMBGLPEKILF consumable);

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(Slot = "8")]
		int GetTotalConsumableCount(FMBGLPEKILF consumable);
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public interface IRRUIvNextRoomCategoryBridge
	{
		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		string DefaultGameConfigKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		bool ShouldHideShowMeAllRooms
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		bool ShouldHideChipBar
		{
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SelectRoomCategory(IEDAJAEIHMN category, Route route, MKJBCDALEDO loadSceneSource, BrowserModel browserModel);

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task<IReadOnlyList<IEDAJAEIHMN>> GetRoomCategoriesForPageSource(CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task<(IReadOnlyList<IEDAJAEIHMN>, string)> GetRoomCategoriesForCuratedList(string sourceMetadata, CancellationToken ct);

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		IReadOnlyList<IEDAJAEIHMN> GetRoomCategoriesForConfig(string gameConfigKey);
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public interface IRRUIvNextRoomInventoryBridge
	{
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		const string ROOM_INVENTORY_ITEM_ELEMENT_TYPE = "RoomInventoryItem";

		[Cpp2IlInjected.Token(Token = "0x14000018")]
		event Action OnInventoryItemsChanged;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		List<IUnifiedRoomInventoryItem> GetRoomInventoryItems();
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public interface IUnifiedRoomInventoryItem
	{
		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		Sprite Icon
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		Color IconColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void OpenItemDetails([Optional] string source);
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public interface IRRUIvNextRoomStoreBridge
	{
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		const string UNIFIED_ROOM_STORE_ENTRYPOINT = "UnifiedRoomStore";

		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		const string ROOM_STORE_CATEGORY_PROPERTY = "room_store_category";

		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		const string ROOM_STORE_CATEGORY_POSITION_PROPERTY = "room_store_category_position";

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		IRoomStoreCategory SelectedCategory
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(Slot = "9")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		event Action OnStoreItemsChanged;

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		event Action OnSelectedCategoryChanged;

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		event Action OnResetSelectedCategory;

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		List<IRoomStoreCategory> LoadRoomStoreCategories();

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		List<IUnifiedRoomStoreItem> GetAllRoomStoreItems();

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void ResetSelectedCategory();
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public interface IUnifiedRoomStoreItem
	{
		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		Guid Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		string Name
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		Sprite SecondaryIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		Color SecondaryIconColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		Sprite CurrencyIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		string FormattedPriceText
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		bool CanBuy
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(Slot = "10")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		string ElementType
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(Slot = "12")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		event Action ItemUpdated;

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void OpenItemDetails(bool attemptCheckout = false, [Optional] string source);

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void Attach();

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void Detach();
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[ViewModel]
	public class PlayerNametagViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private struct <OnReputationUpdated>d__81 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public PlayerNametagViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public int accountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			private TaskAwaiter<IGDEJBPKFDK> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x8285770", Offset = "0x8284170", VA = "0x188285770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private struct <OnAccountUpdated>d__82 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public PlayerNametagViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public int accountId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			private TaskAwaiter<BMCJEMDNANL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x82854D0", Offset = "0x8283ED0", VA = "0x1882854D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private struct <GetPlayerInfo>d__87 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public PlayerNametagViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public IPlayerUIBridge player;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public long roomId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private PKCMPJMLDGM <details>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private LKDAKICMOII <progression>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private TaskAwaiter<PKCMPJMLDGM> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			private TaskAwaiter<BMCJEMDNANL> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			private TaskAwaiter<LKDAKICMOII> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private TaskAwaiter<bool> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x600027A")]
			[Cpp2IlInjected.Address(RVA = "0x82837A0", Offset = "0x82821A0", VA = "0x1882837A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private bool canShowNametag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private string playerDisplayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private string playerCustomEmoji;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private AccountRoleIconType playerRoleType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private AccountBadgeIconType roleBadgeIconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private string playerLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private bool isBroadcasting;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private string developerLabel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool inCallWithLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private bool muted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private bool blocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private bool inAPartyWithLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private AccountBadgeIconType cheerBadgeIconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private IPlayerColor playerColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private AccountLeagueIconType leagueIconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private IPlayerUIBridge playerUIBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private CancellationTokenSource tokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private string accountLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private bool isInfluencer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private IRoomQueryManager roomQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private IAccountQueryManager accountQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private MGNJLPDEIEI leagueService;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private BMCJEMDNANL account;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private DataItem<bool> CanShowNametagDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private DataItem<string> PlayerDisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private DataItem<string> PlayerCustomEmojiDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		private DataItem<bool> HasCustomEmojiDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private DataItem<AccountRoleIconType> PlayerRoleTypeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private DataItem<AccountBadgeIconType> RoleBadgeIconTypeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private DataItem<string> PlayerLevelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private DataItem<bool> IsBroadcastingDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private DataItem<bool> ShowDeveloperLabelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private DataItem<string> DeveloperLabelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private DataItem<bool> InCallWithLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private DataItem<bool> MutedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private DataItem<bool> BlockedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private DataItem<bool> InAPartyWithLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private DataItem<AccountBadgeIconType> CheerBadgeIconTypeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private DataItem<IPlayerColor> PlayerColorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private DataItem<AccountLeagueIconType> LeagueIconTypeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private DataItemAction OpenPlayerProfileDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		[BindableData(0, null, DataPermissions.ReadOnly)]
		public bool CanShowNametag
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0xABA770", Offset = "0xAB9170", VA = "0x180ABA770")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x827B7D0", Offset = "0x827A1D0", VA = "0x18827B7D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		[BindableData(1, "Display name of the associated player", DataPermissions.ReadOnly)]
		public string PlayerDisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x827BBF0", Offset = "0x827A5F0", VA = "0x18827BBF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		[BindableData(2, "Player-set custom emoji", DataPermissions.ReadOnly)]
		public string PlayerCustomEmoji
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x827BB80", Offset = "0x827A580", VA = "0x18827BB80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		[BindableData(3, "Whether a custom emoji is set", DataPermissions.ReadOnly)]
		public bool HasCustomEmoji
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x827AFF0", Offset = "0x82799F0", VA = "0x18827AFF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		[BindableData(5, "The role of this player in the current room", DataPermissions.ReadOnly)]
		public AccountRoleIconType PlayerRoleType
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7D0", Offset = "0xB2E1D0", VA = "0x180B2F7D0")]
			get
			{
				return default(AccountRoleIconType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x827BCE0", Offset = "0x827A6E0", VA = "0x18827BCE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		[BindableData(6, "The badge the player has selected", DataPermissions.ReadOnly)]
		public AccountBadgeIconType RoleBadgeIconType
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7B0", Offset = "0xB2E1B0", VA = "0x180B2F7B0")]
			get
			{
				return default(AccountBadgeIconType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x827BD30", Offset = "0x827A730", VA = "0x18827BD30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		[BindableData(7, "Player level (room level if room has progression)", DataPermissions.ReadOnly)]
		public string PlayerLevel
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B40", Offset = "0xAB6540", VA = "0x180AB7B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x827BC60", Offset = "0x827A660", VA = "0x18827BC60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		[BindableData(8, "Whether the player is broadcasting", DataPermissions.ReadOnly)]
		public bool IsBroadcasting
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xB341E0", Offset = "0xB32BE0", VA = "0x180B341E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x827B9F0", Offset = "0x827A3F0", VA = "0x18827B9F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		[BindableData(9, "Whether the player is a developer", DataPermissions.ReadOnly)]
		public bool ShowDeveloperLabel
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x827B010", Offset = "0x8279A10", VA = "0x18827B010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		[BindableData(10, "Player level (room level if room has progression)", DataPermissions.ReadOnly)]
		public string DeveloperLabel
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7C0", Offset = "0xB2E1C0", VA = "0x180B2F7C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x827B890", Offset = "0x827A290", VA = "0x18827B890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		[BindableData(11, "Whether this player is in a call with the local player", DataPermissions.ReadOnly)]
		public bool InCallWithLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xFEB740", Offset = "0xFEA140", VA = "0x180FEB740")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x827B990", Offset = "0x827A390", VA = "0x18827B990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		[BindableData(12, "Whether this player is muted by the local player", DataPermissions.ReadOnly)]
		public bool Muted
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x1CC1B50", Offset = "0x1CC0550", VA = "0x181CC1B50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x827BAB0", Offset = "0x827A4B0", VA = "0x18827BAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BF")]
		[BindableData(13, "Whether this player has been blocked by local player", DataPermissions.ReadOnly)]
		public bool Blocked
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x5986F70", Offset = "0x5985970", VA = "0x185986F70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x827B770", Offset = "0x827A170", VA = "0x18827B770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C0")]
		[BindableData(14, "Whether this player is in a party", DataPermissions.ReadOnly)]
		public bool InAPartyWithLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x81764E0", Offset = "0x8174EE0", VA = "0x1881764E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x827B930", Offset = "0x827A330", VA = "0x18827B930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C1")]
		[BindableData(15, "The active cheer this player has", DataPermissions.ReadOnly)]
		public AccountBadgeIconType CheerBadgeIconType
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0xF68C80", Offset = "0xF67680", VA = "0x180F68C80")]
			get
			{
				return default(AccountBadgeIconType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x827B830", Offset = "0x827A230", VA = "0x18827B830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		[BindableData(16, "Player color defined by legacy scripts", DataPermissions.ReadOnly)]
		public IPlayerColor PlayerColor
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xB79620", Offset = "0xB78020", VA = "0x180B79620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x827BB10", Offset = "0x827A510", VA = "0x18827BB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C3")]
		[BindableData(17, "The league icon this player has", DataPermissions.ReadOnly)]
		public AccountLeagueIconType LeagueIconType
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0xAAC190", Offset = "0xAAAB90", VA = "0x180AAC190")]
			get
			{
				return default(AccountLeagueIconType);
			}
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x827BA50", Offset = "0x827A450", VA = "0x18827BA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C4")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x827B730", Offset = "0x827A130", VA = "0x18827B730", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C5")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x827AE10", Offset = "0x8279810", VA = "0x18827AE10")]
		public void Set(IPlayerUIBridge player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x8278A00", Offset = "0x8277400", VA = "0x188278A00")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x827A290", Offset = "0x8278C90", VA = "0x18827A290")]
		private void OnBroadcastingStateChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x827A3D0", Offset = "0x8278DD0", VA = "0x18827A3D0")]
		private void OnDeveloperDisplayChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x827A330", Offset = "0x8278D30", VA = "0x18827A330")]
		private void OnCallStatusChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x827A800", Offset = "0x8279200", VA = "0x18827A800")]
		private void OnPartyStatusChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x827A760", Offset = "0x8279160", VA = "0x18827A760")]
		private void OnNametagVisibilityChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x827ABA0", Offset = "0x82795A0", VA = "0x18827ABA0")]
		private void OnRelationshipChanged(int? playerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x827AAA0", Offset = "0x82794A0", VA = "0x18827AAA0")]
		private void OnProgressionUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x827AD50", Offset = "0x8279750", VA = "0x18827AD50")]
		[AsyncStateMachine(typeof(<OnReputationUpdated>d__81))]
		private void OnReputationUpdated(int accountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x827A1D0", Offset = "0x8278BD0", VA = "0x18827A1D0")]
		[AsyncStateMachine(typeof(<OnAccountUpdated>d__82))]
		private void OnAccountUpdated(int accountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x827A550", Offset = "0x8278F50", VA = "0x18827A550")]
		private void OnLeagueUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x82792B0", Offset = "0x8277CB0", VA = "0x1882792B0")]
		private static AccountLeagueIconType GetAccountLeagueIconTypeFromLeagueValue(int leagueValue)
		{
			return default(AccountLeagueIconType);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x827B030", Offset = "0x8279A30", VA = "0x18827B030")]
		private void UpdateRoleBadge()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x827A9C0", Offset = "0x82793C0", VA = "0x18827A9C0")]
		private void OnPlayerColorUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x8279320", Offset = "0x8277D20", VA = "0x188279320")]
		[AsyncStateMachine(typeof(<GetPlayerInfo>d__87))]
		private void GetPlayerInfo(IPlayerUIBridge player, long roomId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		[BindableAction(100, "Opens the player profile page")]
		private void OpenPlayerProfile()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x8279410", Offset = "0x8277E10", VA = "0x188279410")]
		private static AccountRoleIconType GetRoleIconType(IPlayerUIBridge player, LHDJNPMOIOH role)
		{
			return default(AccountRoleIconType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x82794F0", Offset = "0x8277EF0", VA = "0x1882794F0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8278FB0", Offset = "0x82779B0", VA = "0x188278FB0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x827B160", Offset = "0x8279B60", VA = "0x18827B160")]
		public PlayerNametagViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public enum RecRoomPlusOfferType
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		SimpleBenefitList,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		LimitedTimeSignOnItemBonus
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[ViewModel]
	public class RecRoomPlusOfferViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private struct <FetchBenefitData>d__49 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000143")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000144")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000145")]
			public RecRoomPlusOfferViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000146")]
			private TaskAwaiter<List<RecRoomPlusBenefitData>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x82819C0", Offset = "0x82803C0", VA = "0x1882819C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private struct <FetchStoreItemOffers>d__50 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000147")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000148")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000149")]
			public RecRoomPlusOfferViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400014A")]
			public WidgetSourceData sourceData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400014B")]
			private CancellationToken <token>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400014C")]
			private TaskAwaiter<IReadOnlyList<LFCAJIEBPDF>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			private TaskAwaiter<KIIHIBCONNM.OHPHGGKODGG> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			private TaskAwaiter<IReadOnlyList<JJNPIFNJJFP>> <>u__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			private IEnumerator<JJNPIFNJJFP> <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private JJNPIFNJJFP <item>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private ENCDNBIIIKJ <giftDrop>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private TaskAwaiter<bool> <>u__4;

			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x8281C00", Offset = "0x8280600", VA = "0x188281C00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		private RecRoomPlusOfferType offerType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[SerializeField]
		private int maxLimitedTimeOfferItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[SerializeField]
		private Uri offerItemDetailsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[SerializeField]
		private ImpressionTracker bannerContentsImpressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private bool subscriptionActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private string offerDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private string offerIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private string offerImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private bool useImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private int offerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private int activeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private IRecRoomPlusDataManager rrplusManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private IStoreItemQueryManager storeItemListQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private IRRUIvNextStoreItemBridge vNextStoreItemBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private IAccountQueryManager accountQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private IRecRoomPlusDataManager rrPlusDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private List<RecRoomPlusBenefitData> benefitData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private StoreItemListQueryData wishlistQueryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private StoreItemListQueryData configuredQueryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private string widgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private List<int> wishlistItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private string nonWishlistSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Dictionary<int, JJNPIFNJJFP> storeItemLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private DataItem<bool> SubscriptionActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private DataItem<string> OfferDescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private DataItem<string> OfferIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private DataItem<string> OfferImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private DataItem<bool> UseImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private DataItem<int> OfferIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private DataItemAction RefreshOfferDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private DataItemAction ViewOfferItemDetailsDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool SubscriptionActive
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0xD54F60", Offset = "0xD53960", VA = "0x180D54F60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x827F300", Offset = "0x827DD00", VA = "0x18827F300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C7")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string OfferDescription
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6550", VA = "0x180AB7B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x827FE10", Offset = "0x827E810", VA = "0x18827FE10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C8")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string OfferIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7C0", Offset = "0xB2E1C0", VA = "0x180B2F7C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x827FE90", Offset = "0x827E890", VA = "0x18827FE90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000C9")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public string OfferImage
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0xAB7A80", Offset = "0xAB6480", VA = "0x180AB7A80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000283")]
			[Cpp2IlInjected.Address(RVA = "0x827FF10", Offset = "0x827E910", VA = "0x18827FF10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CA")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool UseImage
		{
			[Cpp2IlInjected.Token(Token = "0x6000284")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7E0", Offset = "0xB2E1E0", VA = "0x180B2F7E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x827F390", Offset = "0x827DD90", VA = "0x18827F390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CB")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public int OfferId
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0xB09EF0", Offset = "0xB088F0", VA = "0x180B09EF0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x827F2A0", Offset = "0x827DCA0", VA = "0x18827F2A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CC")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x827FDD0", Offset = "0x827E7D0", VA = "0x18827FDD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CD")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x827E750", Offset = "0x827D150", VA = "0x18827E750")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x827EEC0", Offset = "0x827D8C0", VA = "0x18827EEC0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x827E6A0", Offset = "0x827D0A0", VA = "0x18827E6A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x827F3F0", Offset = "0x827DDF0", VA = "0x18827F3F0")]
		private void UpdateUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x827DC30", Offset = "0x827C630", VA = "0x18827DC30")]
		[AsyncStateMachine(typeof(<FetchBenefitData>d__49))]
		private void FetchBenefitData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x827DCE0", Offset = "0x827C6E0", VA = "0x18827DCE0")]
		[AsyncStateMachine(typeof(<FetchStoreItemOffers>d__50))]
		private void FetchStoreItemOffers(WidgetSourceData sourceData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x827E830", Offset = "0x827D230", VA = "0x18827E830")]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x827E8D0", Offset = "0x827D2D0", VA = "0x18827E8D0")]
		[BindableAction(100, null)]
		private void RefreshOffer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x827EB30", Offset = "0x827D530", VA = "0x18827EB30")]
		private void RefreshUIContent()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x827ED00", Offset = "0x827D700", VA = "0x18827ED00")]
		private void SetUpImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x827F7B0", Offset = "0x827E1B0", VA = "0x18827F7B0")]
		[BindableAction(101, null)]
		private void ViewOfferItemDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x827DF70", Offset = "0x827C970", VA = "0x18827DF70", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x827DDD0", Offset = "0x827C7D0", VA = "0x18827DDD0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x827FA10", Offset = "0x827E410", VA = "0x18827FA10")]
		public RecRoomPlusOfferViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public enum AccountBadgeIconType
	{
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		Party,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		RRPlus,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		Influencer,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		Developer,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		Cheer_Helpful,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		Cheer_General,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		Cheer_Sportsmanship,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		Cheer_GreatHost,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		Cheer_Creative,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		League
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class AccountBadgeIconConfig : IIconConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public AccountBadgeIconType IconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private AssetReferenceT<Sprite> backgroundFillIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private AssetReferenceT<Sprite> backgroundOutlineIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		[FormerlySerializedAs("BadgeIcon")]
		private AssetReferenceT<Sprite> badgeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private AssetReferenceT<Sprite> badgeOutlineIcon;

		[Cpp2IlInjected.Token(Token = "0x170000CE")]
		public AssetReferenceT<Sprite> BackgroundFillIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000CF")]
		public AssetReferenceT<Sprite> BackgroundOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D0")]
		public AssetReferenceT<Sprite> BadgeIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D1")]
		public AssetReferenceT<Sprite> BadgeOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public AccountBadgeIconConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CreateAssetMenu(fileName = "AccountBadgeIconData", menuName = "Rec Room/App UI/Account/Account Badge Icon Data")]
	public class AccountBadgeIconData : ScriptableObject, IIconData<AccountBadgeIconType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public List<AccountBadgeIconConfig> Config;

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x826CE30", Offset = "0x826B830", VA = "0x18826CE30", Slot = "4")]
		public bool TryGetConfig(AccountBadgeIconType iconType, [Out] IIconConfig config)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0xD5D430", Offset = "0xD5BE30", VA = "0x180D5D430")]
		public AccountBadgeIconData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public class AccountBadgeIconView : EnumIconDataViewBase<AccountBadgeIconType, AccountBadgeIconData>
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x826CF90", Offset = "0x826B990", VA = "0x18826CF90")]
		public AccountBadgeIconView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public enum AccountLeagueIconType
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		TheAmazings,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		ValorSociety,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		LeagueOfDefenders,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		MasterMinds,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		TheUnripened,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		TheRootforged,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		TheVineguard
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class AccountLeagueIconConfig : IIconConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public AccountLeagueIconType IconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		private AssetReferenceT<Sprite> backgroundFillIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		private AssetReferenceT<Sprite> backgroundOutlineIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		[FormerlySerializedAs("BadgeIcon")]
		private AssetReferenceT<Sprite> badgeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[SerializeField]
		private AssetReferenceT<Sprite> badgeOutlineIcon;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public AssetReferenceT<Sprite> BackgroundFillIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		public AssetReferenceT<Sprite> BackgroundOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		public AssetReferenceT<Sprite> BadgeIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		public AssetReferenceT<Sprite> BadgeOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public AccountLeagueIconConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CreateAssetMenu(fileName = "AccountLeagueIconData", menuName = "Rec Room/App UI/Account/Account League Icon Data")]
	public class AccountLeagueIconData : ScriptableObject, IIconData<AccountLeagueIconType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public List<AccountLeagueIconConfig> Config;

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x826D0B0", Offset = "0x826BAB0", VA = "0x18826D0B0", Slot = "4")]
		public bool TryGetConfig(AccountLeagueIconType iconType, [Out] IIconConfig config)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xD5D430", Offset = "0xD5BE30", VA = "0x180D5D430")]
		public AccountLeagueIconData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class AccountLeagueIconView : EnumIconDataViewBase<AccountLeagueIconType, AccountLeagueIconData>
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x826D210", Offset = "0x826BC10", VA = "0x18826D210")]
		public AccountLeagueIconView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public enum AccountRoleIconType
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		Banned,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		Host,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		Moderator,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Contributor,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		CoOwner,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		TemporaryCoOwner,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		Creator,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		RoomLevel
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public class AccountRoleIconConfig : IIconConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		public AccountRoleIconType IconType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		[SerializeField]
		private AssetReferenceT<Sprite> backgroundFillIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		[SerializeField]
		private AssetReferenceT<Sprite> backgroundOutlineIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		[SerializeField]
		private AssetReferenceT<Sprite> badgeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		[SerializeField]
		private AssetReferenceT<Sprite> badgeOutlineIcon;

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		public AssetReferenceT<Sprite> BackgroundFillIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		public AssetReferenceT<Sprite> BackgroundOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		public AssetReferenceT<Sprite> BadgeIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D9")]
		public AssetReferenceT<Sprite> BadgeOutlineIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public AccountRoleIconConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[CreateAssetMenu(fileName = "AccountRoleIconData", menuName = "RecRoom/App UI/Account Role Icon Data")]
	public class AccountRoleIconData : ScriptableObject, IIconData<AccountRoleIconType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		[SerializeField]
		private List<AccountRoleIconConfig> iconConfigList;

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x826E390", Offset = "0x826CD90", VA = "0x18826E390", Slot = "4")]
		public bool TryGetConfig(AccountRoleIconType iconType, [Out] IIconConfig config)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0xD5D430", Offset = "0xD5BE30", VA = "0x180D5D430")]
		public AccountRoleIconData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class AccountRoleView : EnumIconDataViewBase<AccountRoleIconType, AccountRoleIconData>
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x826E5D0", Offset = "0x826CFD0", VA = "0x18826E5D0")]
		public AccountRoleView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[ViewModel]
	public class AccountListViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private struct <UpdateList>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public AccountListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			private TaskAwaiter<List<int>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x8285C30", Offset = "0x8284630", VA = "0x188285C30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		private AccountListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		private Uri viewAllFriendsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[SerializeField]
		private Uri viewHereNowUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private DataList<int> _accountList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private bool _isEmpty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private string _displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private string _emptyText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private IAccountQueryManager _accountQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		private IRRUIvNextBridge _vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		private BrowserModel _browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		private bool _isSubscribed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private DataItem<bool> IsEmptyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private DataItem<string> EmptyTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private DataItemList AccountListDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private DataItemAction GoToViewAllPageDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000DA")]
		public AccountListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xAB4850", Offset = "0xAB3250", VA = "0x180AB4850")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x826E290", Offset = "0x826CC90", VA = "0x18826E290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<int> AccountList
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B30", Offset = "0xAB6530", VA = "0x180AB7B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x826E130", Offset = "0x826CB30", VA = "0x18826E130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0xD54F60", Offset = "0xD53960", VA = "0x180D54F60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C5")]
			[Cpp2IlInjected.Address(RVA = "0x826DCB0", Offset = "0x826C6B0", VA = "0x18826DCB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DD")]
		[BindableData(2, "The name of the list that can be shown on the UI, e.g. as a carousel title", DataPermissions.ReadOnly)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6550", VA = "0x180AB7B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x826E190", Offset = "0x826CB90", VA = "0x18826E190")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DE")]
		[BindableData(3, "The text to show if the list is empty", DataPermissions.ReadOnly)]
		public string EmptyText
		{
			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7C0", Offset = "0xB2E1C0", VA = "0x180B2F7C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x826E210", Offset = "0x826CC10", VA = "0x18826E210")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x826E0F0", Offset = "0x826CAF0", VA = "0x18826E0F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x826D9C0", Offset = "0x826C3C0", VA = "0x18826D9C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x826D9A0", Offset = "0x826C3A0", VA = "0x18826D9A0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x826DDE0", Offset = "0x826C7E0", VA = "0x18826DDE0")]
		[AsyncStateMachine(typeof(<UpdateList>d__28))]
		private void UpdateList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x826D390", Offset = "0x826BD90", VA = "0x18826D390")]
		[BindableAction(100, null)]
		private void GoToViewAllPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x826DAD0", Offset = "0x826C4D0", VA = "0x18826DAD0")]
		private bool TrySubscribe()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x826DBC0", Offset = "0x826C5C0", VA = "0x18826DBC0")]
		private bool TryUnsubscribe()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x826D530", Offset = "0x826BF30", VA = "0x18826D530", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x826D250", Offset = "0x826BC50", VA = "0x18826D250")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x826DE90", Offset = "0x826C890", VA = "0x18826DE90")]
		public AccountListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[ViewModel]
	public class AccountViewModel : RRUIBaseLocalViewModel, ILoadable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private struct <FetchAccountData>d__96 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001D0")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001D1")]
			public AccountViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001D2")]
			private CancellationToken <token>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001D3")]
			private CancellationTokenSource <cts>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001D4")]
			private TaskAwaiter<BMCJEMDNANL> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001D5")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x8297EE0", Offset = "0x82968E0", VA = "0x188297EE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private struct <UpdateAccountProgression>d__97 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001D6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001D7")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001D8")]
			public AccountViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001D9")]
			private TaskAwaiter<LKDAKICMOII> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x829BE30", Offset = "0x829A830", VA = "0x18829BE30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private struct <UpdatePresence>d__99 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001DA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001DB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001DC")]
			public AccountViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001DD")]
			private TaskAwaiter<string> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001DE")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x829C870", Offset = "0x829B270", VA = "0x18829C870", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x829CD40", Offset = "0x829B740", VA = "0x18829CD40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private Uri profilePageUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		private ALCEKDGFNKH chatTelemetrySource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		private FJOPDGCALOP partyJoinedSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private int accountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private string profileImageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private string username;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private int level;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private float progressInLevel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private string presence;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private bool _canLocalPlayerGoTo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private bool isFriendOfLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA2")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private bool canSendOrAcceptFriendRequest;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA3")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private bool canLocalPlayerInviteToParty;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private bool isLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA5")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private bool canLocalPlayerChatWith;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA6")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private bool canInviteToJoinLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA7")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private bool isInSameRoomAsLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private bool isFriendOfLocalPlayerAndIsInSameRoomAsLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private bool isFriendOfLocalPlayerAndIsNotInSameRoomAsLocalPlayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAA")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private bool isBlocked;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private NAKKFAFPINH sessionManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private IAccountQueryManager accountQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private IRRUIvNextAccountBridge vNextAccountBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private IRRUIvNextSocialBridge vNextSocialBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private BMCJEMDNANL account;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private DataItem<int> AccountIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private DataItem<string> ProfileImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		private DataItem<string> UsernameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		private DataItem<int> LevelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		private DataItem<float> ProgressInLevelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		private DataItem<string> PresenceDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		private DataItem<bool> CanLocalPlayerGoToDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		private DataItem<bool> IsFriendOfLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		private DataItem<bool> CanSendOrAcceptFriendRequestDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		private DataItem<bool> CanInviteToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		private DataItem<bool> IsLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		private DataItem<bool> CanLocalPlayerChatWithDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private DataItem<bool> CanInviteToJoinLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private DataItem<bool> IsInSameRoomAsLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private DataItem<bool> IsFriendOfLocalPlayerAndIsInSameRoomAsLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private DataItem<bool> IsFriendOfLocalPlayerAndIsNotInSameRoomAsLocalPlayerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private DataItem<bool> IsBlockedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		private DataItemAction GoToProfilePageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		private DataItemAction GoToChatPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		private DataItemAction InviteToMyLocationDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		private DataItemAction GoToLocationDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		private DataItemAction InviteToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		private DataItemAction SendFriendRequestDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public int AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0xAD4A70", Offset = "0xAD3470", VA = "0x180AD4A70")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x8271400", Offset = "0x826FE00", VA = "0x188271400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E2")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B30", Offset = "0xAB6530", VA = "0x180AB7B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x8271790", Offset = "0x8270190", VA = "0x188271790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E3")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string ProfileImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B40", Offset = "0xAB6540", VA = "0x180AB7B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x82726C0", Offset = "0x82710C0", VA = "0x1882726C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E4")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public string Username
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6550", VA = "0x180AB7B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x8272740", Offset = "0x8271140", VA = "0x188272740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E5")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public int Level
		{
			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0xAB7C20", Offset = "0xAB6620", VA = "0x180AB7C20")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x8271820", Offset = "0x8270220", VA = "0x188271820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E6")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public float ProgressInLevel
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x167CF80", Offset = "0x167B980", VA = "0x18167CF80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x8271250", Offset = "0x826FC50", VA = "0x188271250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E7")]
		[BindableData(6, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public string Presence
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0xAB7A80", Offset = "0xAB6480", VA = "0x180AB7A80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x8272640", Offset = "0x8271040", VA = "0x188272640")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E8")]
		[BindableData(7, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanLocalPlayerGoTo
		{
			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7E0", Offset = "0xB2E1E0", VA = "0x180B2F7E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x82712D0", Offset = "0x826FCD0", VA = "0x1882712D0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000E9")]
		[BindableData(8, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsFriendOfLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0xEE0210", Offset = "0xEDEC10", VA = "0x180EE0210")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x8271330", Offset = "0x826FD30", VA = "0x188271330")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		[BindableData(9, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanSendOrAcceptFriendRequest
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x792B950", Offset = "0x792A350", VA = "0x18792B950")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x82713A0", Offset = "0x826FDA0", VA = "0x1882713A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EB")]
		[BindableData(10, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanInviteToParty
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x8271470", Offset = "0x826FE70", VA = "0x188271470")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x8271480", Offset = "0x826FE80", VA = "0x188271480")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EC")]
		[BindableData(11, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x104F250", Offset = "0x104DC50", VA = "0x18104F250")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x82714E0", Offset = "0x826FEE0", VA = "0x1882714E0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		[BindableData(12, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanLocalPlayerChatWith
		{
			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x1AA8C00", Offset = "0x1AA7600", VA = "0x181AA8C00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x8271540", Offset = "0x826FF40", VA = "0x188271540")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EE")]
		[BindableData(13, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool CanInviteToJoinLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0xFE7F50", Offset = "0xFE6950", VA = "0x180FE7F50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x82715A0", Offset = "0x826FFA0", VA = "0x1882715A0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		[BindableData(14, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsInSameRoomAsLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x7334310", Offset = "0x7332D10", VA = "0x187334310")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8271600", Offset = "0x8270000", VA = "0x188271600")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		[BindableData(15, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsFriendOfLocalPlayerAndIsInSameRoomAsLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0xB797F0", Offset = "0xB781F0", VA = "0x180B797F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x8271670", Offset = "0x8270070", VA = "0x188271670")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		[BindableData(16, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsFriendOfLocalPlayerAndIsNotInSameRoomAsLocalPlayer
		{
			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0xB795A0", Offset = "0xB77FA0", VA = "0x180B795A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x82716D0", Offset = "0x82700D0", VA = "0x1882716D0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		[BindableData(17, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsBlocked
		{
			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x1FA1E20", Offset = "0x1FA0820", VA = "0x181FA1E20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x8271730", Offset = "0x8270130", VA = "0x188271730")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x8272500", Offset = "0x8270F00", VA = "0x188272500", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0xB79850", Offset = "0xB78250", VA = "0x180B79850", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0xB79580", Offset = "0xB77F80", VA = "0x180B79580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x82724C0", Offset = "0x8270EC0", VA = "0x1882724C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action<ILoadable> Loaded
		{
			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x8272400", Offset = "0x8270E00", VA = "0x188272400", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x8272580", Offset = "0x8270F80", VA = "0x188272580", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x826E610", Offset = "0x826D010", VA = "0x18826E610", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8270AC0", Offset = "0x826F4C0", VA = "0x188270AC0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8270D00", Offset = "0x826F700", VA = "0x188270D00")]
		private void OnRelationshipUpdated(int? accountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x8270CF0", Offset = "0x826F6F0", VA = "0x188270CF0")]
		private void OnPlayerPresenceUpdated(int accountId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x8270CE0", Offset = "0x826F6E0", VA = "0x188270CE0")]
		private void OnPartyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x82708E0", Offset = "0x826F2E0", VA = "0x1882708E0")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x826E9C0", Offset = "0x826D3C0", VA = "0x18826E9C0")]
		[AsyncStateMachine(typeof(<FetchAccountData>d__96))]
		private void FetchAccountData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x8271880", Offset = "0x8270280", VA = "0x188271880")]
		[AsyncStateMachine(typeof(<UpdateAccountProgression>d__97))]
		private void UpdateAccountProgression()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x8271B70", Offset = "0x8270570", VA = "0x188271B70")]
		private void UpdateRelationship()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8271AA0", Offset = "0x82704A0", VA = "0x188271AA0")]
		[AsyncStateMachine(typeof(<UpdatePresence>d__99))]
		private Task UpdatePresence()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x8271930", Offset = "0x8270330", VA = "0x188271930")]
		private void UpdateCanInviteToParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x82719D0", Offset = "0x82703D0", VA = "0x1882719D0")]
		private void UpdateIsFriendAndInSameRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x8270D70", Offset = "0x826F770", VA = "0x188270D70")]
		private void ResetAccountData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x826F140", Offset = "0x826DB40", VA = "0x18826F140")]
		[BindableAction(100, null)]
		private void GoToProfilePage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x826EE40", Offset = "0x826D840", VA = "0x18826EE40")]
		[BindableAction(101, null)]
		private void GoToChatPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8270710", Offset = "0x826F110", VA = "0x188270710")]
		[BindableAction(102, null)]
		private void InviteToMyLocation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x826EFF0", Offset = "0x826D9F0", VA = "0x18826EFF0")]
		[BindableAction(103, null)]
		private void GoToLocation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x8270800", Offset = "0x826F200", VA = "0x188270800")]
		[BindableAction(104, null)]
		private void InviteToParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x82711F0", Offset = "0x826FBF0", VA = "0x1882711F0")]
		[BindableAction(105, null)]
		private void SendFriendRequest()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x826F320", Offset = "0x826DD20", VA = "0x18826F320", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x826EA70", Offset = "0x826D470", VA = "0x18826EA70")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8271D20", Offset = "0x8270720", VA = "0x188271D20")]
		public AccountViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[ViewModel]
	public class AppNavButtonViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct <FetchLocalAccountInfo>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001EF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001F0")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public AppNavButtonViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			private TaskAwaiter<BMCJEMDNANL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x8298910", Offset = "0x8297310", VA = "0x188298910", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[SerializeField]
		private string buttonIdentifierOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		[SerializeField]
		private DataResolver activeIdentifierResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		[SerializeField]
		private DataResolver targetIdentifierResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private bool buttonPanelActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private string buttonIconId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private bool useProfilePictureAsIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private string profilePictureName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private string buttonIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private IAccountQueryManager accountManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private DataItem<bool> ButtonPanelActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private DataItem<string> ButtonIconIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private DataItem<bool> UseProfilePictureAsIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private DataItem<string> ProfilePictureNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private DataItemAction RequestChangePanelDataItem;

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		[BindableData(0, null, DataPermissions.ReadOnly)]
		public bool ButtonPanelActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0xDD49D0", Offset = "0xDD33D0", VA = "0x180DD49D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x8288880", Offset = "0x8287280", VA = "0x188288880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F8")]
		[BindableData(1, null, DataPermissions.ReadOnly)]
		public string ButtonIconId
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B40", Offset = "0xAB6540", VA = "0x180AB7B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x8288800", Offset = "0x8287200", VA = "0x188288800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F9")]
		[BindableData(2, null, DataPermissions.ReadOnly)]
		public bool UseProfilePictureAsIcon
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xB341E0", Offset = "0xB32BE0", VA = "0x180B341E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x8288960", Offset = "0x8287360", VA = "0x188288960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FA")]
		[BindableData(3, null, DataPermissions.ReadOnly)]
		public string ProfilePictureName
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7C0", Offset = "0xB2E1C0", VA = "0x180B2F7C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x82888E0", Offset = "0x82872E0", VA = "0x1882888E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x8288780", Offset = "0x8287180", VA = "0x188288780", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x8288740", Offset = "0x8287140", VA = "0x188288740", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x82875A0", Offset = "0x8285FA0", VA = "0x1882875A0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x82883B0", Offset = "0x8286DB0", VA = "0x1882883B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x8288160", Offset = "0x8286B60", VA = "0x188288160", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x8287DC0", Offset = "0x82867C0", VA = "0x188287DC0")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x8287760", Offset = "0x8286160", VA = "0x188287760")]
		[AsyncStateMachine(typeof(<FetchLocalAccountInfo>d__28))]
		private void FetchLocalAccountInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x8287D00", Offset = "0x8286700", VA = "0x188287D00")]
		private void OnActiveIdentifierUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x8288270", Offset = "0x8286C70", VA = "0x188288270")]
		private void OnTargetIdentifierUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x8288330", Offset = "0x8286D30", VA = "0x188288330")]
		[BindableAction(100, null)]
		private void RequestChangePanel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x82876B0", Offset = "0x82860B0", VA = "0x1882876B0")]
		private void ConfigureImpressions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x8287950", Offset = "0x8286350", VA = "0x188287950", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x8287810", Offset = "0x8286210", VA = "0x188287810")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8288510", Offset = "0x8286F10", VA = "0x188288510")]
		public AppNavButtonViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class AppNavMenu : MonoBehaviour, IAppNavMenu
	{
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class <WaitForOpenMenu>d__80 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000217")]
			public AppNavMenu <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000218")]
			private float <watchOpenStart>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700010D")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600038E")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700010E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000390")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public <WaitForOpenMenu>d__80(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x829D890", Offset = "0x829C290", VA = "0x18829D890", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x829DCA0", Offset = "0x829C6A0", VA = "0x18829DCA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private sealed class <WaitForCloseMenu>d__81 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000219")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400021A")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400021B")]
			public AppNavMenu <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700010F")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000394")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000110")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000396")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public <WaitForCloseMenu>d__81(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0x829D6F0", Offset = "0x829C0F0", VA = "0x18829D6F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x829D840", Offset = "0x829C240", VA = "0x18829D840", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class <WaitToOpenWatch>d__82 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400021C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400021D")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400021E")]
			public AppNavMenu <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000111")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600039A")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000112")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600039C")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public <WaitToOpenWatch>d__82(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x829E130", Offset = "0x829CB30", VA = "0x18829E130", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x829E1C0", Offset = "0x829CBC0", VA = "0x18829E1C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public const string AppNavLayerName = "interfaces_2025q1_appnav";

		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		public const string UseAppNavParameterName = "use_app_nav_forship";

		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public const string UXFlowLayerName = "interfaces_widgetwatch_ux_flow";

		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public const string RetainUIStateParameterName = "enable_retain_ui_state";

		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		public const string ShowWatchButtonParameterName = "show_watch_button_in_menus";

		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		public const string PortalButtonsAsTabsParameterName = "portal_buttons_act_like_tabs";

		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public const string RetainUIStateDurationParameterName = "retain_ui_state_duration";

		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public const string AlwaysPresentPortalParameterName = "portal_always_present";

		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public static readonly EBDGCEEEFPM InitializedEvent;

		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private static AppNavMenu instance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private Canvas menuCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private HydrateBase appNavHydration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private AppNavViewModel appNavViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private AppNavPanelSwitcher panelSwitcher;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private CanvasScreenSizeRefitter canvasScreenSizeRefitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private PlatformDependentCanvasSizeConfig canvasSizeConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private LongPressInteractable backgroundInteractable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private float forceWatchCloseDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private Coroutine transitionCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private CMANBFFCBML statsig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private Transform originalParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private bool isGoingBack;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private FGPFCPIHEJA<object> disableAppNavTokens;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		public EBDGCEEEFPM BeforeAppNavOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		public EBDGCEEEFPM AfterAppNavOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		public EBDGCEEEFPM AfterAppNavClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		public EBDGCEEEFPM OnShouldUseAppNavChanged;

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		public static bool ShouldRetainUIState
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x828A3F0", Offset = "0x8288DF0", VA = "0x18828A3F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		public static bool PortalButtonsActAsTabs
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x8289EE0", Offset = "0x82888E0", VA = "0x188289EE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000100")]
		public static float RetainUIStateDuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x828A070", Offset = "0x8288A70", VA = "0x18828A070")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000101")]
		public static bool ShouldShowWatchButtonInMenus
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x828A630", Offset = "0x8289030", VA = "0x18828A630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000102")]
		private static bool showWatchButtonInMenus
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x828AA00", Offset = "0x8289400", VA = "0x18828AA00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000103")]
		public static bool ShouldRetainUIStateAndResetAfterDuration
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x828A380", Offset = "0x8288D80", VA = "0x18828A380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000104")]
		public static bool UseAlwaysPresentPortalPanel
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x828A870", Offset = "0x8289270", VA = "0x18828A870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000105")]
		public static AppNavMenu Instance
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x8289E90", Offset = "0x8288890", VA = "0x188289E90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000106")]
		public bool ShouldUseAppNav
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x828A820", Offset = "0x8289220", VA = "0x18828A820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000107")]
		public bool CanOpenAppNavWhenWatchIsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0xB341E0", Offset = "0xB32BE0", VA = "0x180B341E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0xB341A0", Offset = "0xB32BA0", VA = "0x180B341A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000108")]
		public bool IsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xB341D0", Offset = "0xB32BD0", VA = "0x180B341D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0xEA9320", Offset = "0xEA7D20", VA = "0x180EA9320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000109")]
		public bool IsTransitionActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xB34170", Offset = "0xB32B70", VA = "0x180B34170")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0xB34180", Offset = "0xB32B80", VA = "0x180B34180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		public bool ShouldOpenLastActivePanel
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0xB341F0", Offset = "0xB32BF0", VA = "0x180B341F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0xB34190", Offset = "0xB32B90", VA = "0x180B34190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		public bool IsToolMenuOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0xE2F480", Offset = "0xE2DE80", VA = "0x180E2F480")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0xE2DBB0", Offset = "0xE2C5B0", VA = "0x180E2DBB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		public bool WasOpenOnNavigation
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0xC5E0D0", Offset = "0xC5CAD0", VA = "0x180C5E0D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0xC5A4F0", Offset = "0xC58EF0", VA = "0x180C5A4F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x8288B20", Offset = "0x8287520", VA = "0x188288B20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x82895C0", Offset = "0x8287FC0", VA = "0x1882895C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x8289360", Offset = "0x8287D60", VA = "0x188289360")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x82889C0", Offset = "0x82873C0", VA = "0x1882889C0")]
		public void AddAppNavRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x8289770", Offset = "0x8288170", VA = "0x188289770")]
		public void RemoveAppNavRestriction(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x8289600", Offset = "0x8288000", VA = "0x188289600")]
		public void OpenMenuWithPreviousPanel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x8289610", Offset = "0x8288010", VA = "0x188289610", Slot = "5")]
		public void OpenMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x8289290", Offset = "0x8287C90", VA = "0x188289290", Slot = "6")]
		public void CloseMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x82896E0", Offset = "0x82880E0", VA = "0x1882896E0", Slot = "7")]
		public void OpenWatch()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x82896C0", Offset = "0x82880C0", VA = "0x1882896C0")]
		public void OpenPage(string pageIdentifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x8289B40", Offset = "0x8288540", VA = "0x188289B40")]
		[IteratorStateMachine(typeof(<WaitForOpenMenu>d__80))]
		private IEnumerator WaitForOpenMenu()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x8289AC0", Offset = "0x82884C0", VA = "0x188289AC0")]
		[IteratorStateMachine(typeof(<WaitForCloseMenu>d__81))]
		private IEnumerator WaitForCloseMenu()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x8289BC0", Offset = "0x82885C0", VA = "0x188289BC0")]
		[IteratorStateMachine(typeof(<WaitToOpenWatch>d__82))]
		private IEnumerator WaitToOpenWatch()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x8289A20", Offset = "0x8288420", VA = "0x188289A20")]
		private void SetMenuClosedState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x82898D0", Offset = "0x82882D0", VA = "0x1882898D0")]
		private void SetCanvasSize(Vector2 size)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x8289D00", Offset = "0x8288700", VA = "0x188289D00")]
		public AppNavMenu()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class AppNavPanel : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private sealed class <RegisterAfterOneFrame>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000223")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000224")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000225")]
			public AppNavPanel <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000115")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003A7")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000116")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003A9")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public <RegisterAfterOneFrame>d__10(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x829B730", Offset = "0x829A130", VA = "0x18829B730", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x829B7F0", Offset = "0x829A1F0", VA = "0x18829B7F0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		[SerializeField]
		private string panelIdentifierOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		[SerializeField]
		private HydrateBase hydration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private AppNavPanelSwitcher panelSwitcher;

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		public string Identifier
		{
			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000114")]
		public HydrateBase Hydration
		{
			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x828B870", Offset = "0x828A270", VA = "0x18828B870")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x828B620", Offset = "0x828A020", VA = "0x18828B620")]
		[IteratorStateMachine(typeof(<RegisterAfterOneFrame>d__10))]
		private IEnumerator RegisterAfterOneFrame()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x828B6A0", Offset = "0x828A0A0", VA = "0x18828B6A0")]
		public void SetIdentifier(string identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x828B960", Offset = "0x828A360", VA = "0x18828B960")]
		public AppNavPanel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class AppNavPanelSwitcher : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private sealed class <SwapPanels>d__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000234")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000235")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000236")]
			public AppNavPanelSwitcher <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000237")]
			public string targetIdentifier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000238")]
			private bool <startedSwapWithValidCurrentPanel>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000239")]
			private AppNavPanel <targetPanel>5__3;

			[Cpp2IlInjected.Token(Token = "0x17000118")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003BB")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000119")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003BD")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public <SwapPanels>d__24(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x829B840", Offset = "0x829A240", VA = "0x18829B840", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x829BDE0", Offset = "0x829A7E0", VA = "0x18829BDE0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private sealed class <WaitThenClose>d__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400023A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400023B")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400023C")]
			public AppNavPanelSwitcher <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700011A")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003C1")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700011B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003C3")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public <WaitThenClose>d__25(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x829DCF0", Offset = "0x829C6F0", VA = "0x18829DCF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x829DF80", Offset = "0x829C980", VA = "0x18829DF80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private sealed class <OpenTopLevelOnly>d__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400023D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400023E")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400023F")]
			public AppNavPanelSwitcher <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700011C")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003C7")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700011D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003C9")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public <OpenTopLevelOnly>d__26(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x829B5E0", Offset = "0x8299FE0", VA = "0x18829B5E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x829B6E0", Offset = "0x829A0E0", VA = "0x18829B6E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private sealed class <CloseTopLevelOnly>d__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000240")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000241")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000242")]
			public AppNavPanelSwitcher <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700011E")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003CD")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700011F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003CF")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003CA")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public <CloseTopLevelOnly>d__27(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x8297D80", Offset = "0x8296780", VA = "0x188297D80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x8297E90", Offset = "0x8296890", VA = "0x188297E90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		[SerializeField]
		private float initialWaitBeforeCloseTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		[SerializeField]
		private float initialOpenHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		[SerializeField]
		private CanvasScreenSizeRefitter screenSizeRefitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		[SerializeField]
		private HydrateBase topLevelHydration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		[SerializeField]
		private float topLevelHydrationDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		[SerializeField]
		private DataResolver currentPanelResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		[SerializeField]
		private DataResolver targetPanelResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private Dictionary<string, AppNavPanel> panelLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private string currentPanelIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		private AppNavPanel currentPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		private Coroutine panelSwitchCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private Coroutine initialOpenCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		private Vector3 cachedInitialPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		public EBDGCEEEFPM AllPanelsClosed;

		[Cpp2IlInjected.Token(Token = "0x17000117")]
		public bool SwitchingPanels
		{
			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x727C940", Offset = "0x727B340", VA = "0x18727C940")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x828AB90", Offset = "0x8289590", VA = "0x18828AB90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x828B290", Offset = "0x8289C90", VA = "0x18828B290")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x1982610", Offset = "0x1981010", VA = "0x181982610")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x828ACF0", Offset = "0x82896F0", VA = "0x18828ACF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x828AE90", Offset = "0x8289890", VA = "0x18828AE90")]
		public void RegisterPanel(AppNavPanel panel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x828B3B0", Offset = "0x8289DB0", VA = "0x18828B3B0")]
		public void UnregisterPanel(AppNavPanel panel)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x828ADA0", Offset = "0x82897A0", VA = "0x18828ADA0")]
		private void OnTargetPanelUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x828AF80", Offset = "0x8289980", VA = "0x18828AF80")]
		private void RequestTargetPanel(string identifier)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x828B320", Offset = "0x8289D20", VA = "0x18828B320")]
		[IteratorStateMachine(typeof(<SwapPanels>d__24))]
		private IEnumerator SwapPanels(string targetIdentifier)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x828B450", Offset = "0x8289E50", VA = "0x18828B450")]
		[IteratorStateMachine(typeof(<WaitThenClose>d__25))]
		private IEnumerator WaitThenClose()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x828AE10", Offset = "0x8289810", VA = "0x18828AE10")]
		[IteratorStateMachine(typeof(<OpenTopLevelOnly>d__26))]
		private IEnumerator OpenTopLevelOnly()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x828AC70", Offset = "0x8289670", VA = "0x18828AC70")]
		[IteratorStateMachine(typeof(<CloseTopLevelOnly>d__27))]
		private IEnumerator CloseTopLevelOnly()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x828B4D0", Offset = "0x8289ED0", VA = "0x18828B4D0")]
		public AppNavPanelSwitcher()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public class AppNavTutorial : TutorialHighlightTargeter
	{
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		public const string ShowAppNavTutorialParameterName = "enable_app_nav_tutorial";

		[Cpp2IlInjected.Token(Token = "0x4000244")]
		private const string tutorialCompletionKey = "AppNavTutorialCompleted";

		[Cpp2IlInjected.Token(Token = "0x4000245")]
		private const string tutorialSoftExitKey = "AppNavTutorialSoftExit";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		[SerializeField]
		private UITutorialData tutorialDataRecord;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		[SerializeField]
		private AppNavMenu appNavMenu;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		[SerializeField]
		private string idOfOpenAppNavStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		[SerializeField]
		private string idOfWidgetStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		[SerializeField]
		private string idOfPortalStep;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		[SerializeField]
		private int allowedSoftExits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		private Tutorial tutorial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		private CNGDCLJNIFB preferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private CMANBFFCBML statsig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private bool canShowTutorial;

		[Cpp2IlInjected.Token(Token = "0x17000120")]
		public static AppNavTutorial Instance
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0x828CD90", Offset = "0x828B790", VA = "0x18828CD90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x828CDD0", Offset = "0x828B7D0", VA = "0x18828CDD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x828B9D0", Offset = "0x828A3D0", VA = "0x18828B9D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x828C980", Offset = "0x828B380", VA = "0x18828C980")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x828C420", Offset = "0x828AE20", VA = "0x18828C420")]
		public void StartTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x828C9C0", Offset = "0x828B3C0", VA = "0x18828C9C0")]
		public void StopTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x828BF50", Offset = "0x828A950", VA = "0x18828BF50")]
		private void OnCanUseAppNavChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x828C0B0", Offset = "0x828AAB0", VA = "0x18828C0B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x828C0A0", Offset = "0x828AAA0", VA = "0x18828C0A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x828BFC0", Offset = "0x828A9C0", VA = "0x18828BFC0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x828BED0", Offset = "0x828A8D0", VA = "0x18828BED0")]
		private void OnAppNavOpened()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x828BE60", Offset = "0x828A860", VA = "0x18828BE60")]
		private void OnAppNavClosed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x828C0C0", Offset = "0x828AAC0", VA = "0x18828C0C0")]
		private void OnStepChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x828BC30", Offset = "0x828A630", VA = "0x18828BC30")]
		private void ClearTutorialEvents()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x828C3D0", Offset = "0x828ADD0", VA = "0x18828C3D0")]
		private void OnTutorialStarted()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x828C2B0", Offset = "0x828ACB0", VA = "0x18828C2B0")]
		private void OnTutorialExited()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x828CCE0", Offset = "0x828B6E0", VA = "0x18828CCE0")]
		public AppNavTutorial()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[ViewModel]
	public class AppNavViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		[CompilerGenerated]
		private struct <FetchPanelIds>d__48 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400026D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400026E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400026F")]
			public AppNavViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000270")]
			private CancellationToken <token>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000271")]
			private TaskAwaiter<List<string>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000272")]
			private string <newDefault>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000273")]
			private List<string>.Enumerator <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000274")]
			private string <panelId>5__5;

			[Cpp2IlInjected.Token(Token = "0x600040E")]
			[Cpp2IlInjected.Address(RVA = "0x8298B70", Offset = "0x8297570", VA = "0x188298B70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x82992F0", Offset = "0x8297CF0", VA = "0x1882992F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private const string UnifiedUISessionIdKey = "unified_ui_session_id";

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		[SerializeField]
		private float reopenToLastPanelThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		private string activePanelIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		private string nextPanelIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private DataList<string> widgetPanelIdentifiers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private float availableHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private Guid sessionGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private bool portalPanelAlwaysPresent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private bool portalPanelAlwaysPresentForTouch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private bool portalPanelAlwaysPresentForScreens;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private MEDFICBLIIJ analyticsHelper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private IMenuManager menuManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		private string defaultPanel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		private float lastCloseTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		private DataItem<string> ActivePanelIdentifierDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		private DataItem<string> NextPanelIdentifierDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		private DataItem<float> AvailableHeightDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private DataItem<Guid> SessionGuidDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private DataItem<bool> PortalPanelAlwaysPresentDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private DataItem<bool> PortalPanelAlwaysPresentForTouchDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private DataItem<bool> PortalPanelAlwaysPresentForScreensDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private DataItemList WidgetPanelIdentifiersDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private DataItemAction CloseDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000121")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string ActivePanelIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x60003E1")]
			[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E2")]
			[Cpp2IlInjected.Address(RVA = "0x828E8B0", Offset = "0x828D2B0", VA = "0x18828E8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000122")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string NextPanelIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x60003E3")]
			[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E4")]
			[Cpp2IlInjected.Address(RVA = "0x828E960", Offset = "0x828D360", VA = "0x18828E960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000123")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public DataList<string> WidgetPanelIdentifiers
		{
			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B30", Offset = "0xAB6530", VA = "0x180AB7B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x828EF70", Offset = "0x828D970", VA = "0x18828EF70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000124")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public float AvailableHeight
		{
			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x19D98E0", Offset = "0x19D82E0", VA = "0x1819D98E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x828E9D0", Offset = "0x828D3D0", VA = "0x18828E9D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000125")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public Guid SessionGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x828EA40", Offset = "0x828D440", VA = "0x18828EA40")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0x828EA50", Offset = "0x828D450", VA = "0x18828EA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000126")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public bool PortalPanelAlwaysPresent
		{
			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x1F85E50", Offset = "0x1F84850", VA = "0x181F85E50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x828EAD0", Offset = "0x828D4D0", VA = "0x18828EAD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool PortalPanelAlwaysPresentForTouch
		{
			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x81764C0", Offset = "0x8174EC0", VA = "0x1881764C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x828E720", Offset = "0x828D120", VA = "0x18828E720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000128")]
		[BindableData(7, null, DataPermissions.ReadWrite)]
		public bool PortalPanelAlwaysPresentForScreens
		{
			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x1FA8450", Offset = "0x1FA6E50", VA = "0x181FA8450")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x828E780", Offset = "0x828D180", VA = "0x18828E780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000129")]
		public string PreviousPanelIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0xB795C0", Offset = "0xB77FC0", VA = "0x180B795C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0xB79820", Offset = "0xB78220", VA = "0x180B79820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012A")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x828EF30", Offset = "0x828D930", VA = "0x18828EF30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012B")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x828CE30", Offset = "0x828B830", VA = "0x18828CE30", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x828E080", Offset = "0x828CA80", VA = "0x18828E080")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x828E0D0", Offset = "0x828CAD0", VA = "0x18828E0D0")]
		public void Open(string panelIdentifier = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x828D2D0", Offset = "0x828BCD0", VA = "0x18828D2D0")]
		[BindableAction(100, null)]
		public void Close()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0x828D550", Offset = "0x828BF50", VA = "0x18828D550")]
		[AsyncStateMachine(typeof(<FetchPanelIds>d__48))]
		private Task FetchPanelIds()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x828E550", Offset = "0x828CF50", VA = "0x18828E550")]
		private void SetAlwaysPortalState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x828D7F0", Offset = "0x828C1F0", VA = "0x18828D7F0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0x828D630", Offset = "0x828C030", VA = "0x18828D630")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x828EB30", Offset = "0x828D530", VA = "0x18828EB30")]
		public AppNavViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[ViewModel]
	public class DevToolsViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		[SerializeField]
		private Uri debugToolsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		[SerializeField]
		private Uri testCaseManagementUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		[SerializeField]
		private Uri bugReportingUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		[SerializeField]
		private Uri componentLibraryUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private bool canAccessDevTools;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		private bool developerToolsActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private bool shouldShowDebugTools;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		private DataItem<bool> CanAccessDevToolsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		private DataItem<bool> DeveloperToolsActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		private DataItem<bool> ShouldShowDebugToolsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		private DataItemAction OpenDebugToolsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		private DataItemAction OpenTestCaseManagementDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		private DataItemAction OpenBugReportingDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		private DataItemAction OpenComponentLibraryDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700012C")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool CanAccessDevTools
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xD54F60", Offset = "0xD53960", VA = "0x180D54F60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x828FB30", Offset = "0x828E530", VA = "0x18828FB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012D")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool DeveloperToolsActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xFD8E80", Offset = "0xFD7880", VA = "0x180FD8E80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0x828FB90", Offset = "0x828E590", VA = "0x18828FB90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012E")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public bool ShouldShowDebugTools
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0xFD8E90", Offset = "0xFD7890", VA = "0x180FD8E90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0x828FBF0", Offset = "0x828E5F0", VA = "0x18828FBF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700012F")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600041D")]
			[Cpp2IlInjected.Address(RVA = "0x828FFA0", Offset = "0x828E9A0", VA = "0x18828FFA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000130")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600041E")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x828EFD0", Offset = "0x828D9D0", VA = "0x18828EFD0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x828F950", Offset = "0x828E350", VA = "0x18828F950")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x828FC50", Offset = "0x828E650", VA = "0x18828FC50")]
		private void UpdateBasedOnLocalAccount()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x828FA70", Offset = "0x828E470", VA = "0x18828FA70")]
		[BindableAction(100, null)]
		private void OpenDebugTools()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(RVA = "0x828FAD0", Offset = "0x828E4D0", VA = "0x18828FAD0")]
		[BindableAction(101, null)]
		private void OpenTestCaseManagement()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(RVA = "0x828F9B0", Offset = "0x828E3B0", VA = "0x18828F9B0")]
		[BindableAction(102, null)]
		private void OpenBugReporting()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(RVA = "0x828FA10", Offset = "0x828E410", VA = "0x18828FA10")]
		[BindableAction(103, null)]
		private void OpenComponentLibrary()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x828F3D0", Offset = "0x828DDD0", VA = "0x18828F3D0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x828F250", Offset = "0x828DC50", VA = "0x18828F250")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x828FDB0", Offset = "0x828E7B0", VA = "0x18828FDB0")]
		public DevToolsViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public interface IAppNavMenu
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[ViewModel]
	public class PortalButtonViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		[SerializeField]
		private UILinkLookup routeLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		private PortalButtonConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		private IRRUIvNextStoreItemBridge storeBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		private LinkInfo linkInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		private string iconName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		private DataItem<string> IconNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		private DataItemAction OpenRouteDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000131")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000428")]
			[Cpp2IlInjected.Address(RVA = "0x8295480", Offset = "0x8293E80", VA = "0x188295480", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000132")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000429")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6550", VA = "0x180AB7B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600042A")]
			[Cpp2IlInjected.Address(RVA = "0x8295500", Offset = "0x8293F00", VA = "0x188295500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000133")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string IconName
		{
			[Cpp2IlInjected.Token(Token = "0x600042B")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7C0", Offset = "0xB2E1C0", VA = "0x180B2F7C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600042C")]
			[Cpp2IlInjected.Address(RVA = "0x8295580", Offset = "0x8293F80", VA = "0x188295580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000134")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000430")]
			[Cpp2IlInjected.Address(RVA = "0x8295440", Offset = "0x8293E40", VA = "0x188295440", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000135")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000431")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(RVA = "0x82950D0", Offset = "0x8293AD0", VA = "0x1882950D0")]
		[BindableAction(2, null)]
		public void OpenRoute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x82946A0", Offset = "0x82930A0", VA = "0x1882946A0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(RVA = "0x8294B00", Offset = "0x8293500", VA = "0x188294B00")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000432")]
		[Cpp2IlInjected.Address(RVA = "0x8294820", Offset = "0x8293220", VA = "0x188294820", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(RVA = "0x8294730", Offset = "0x8293130", VA = "0x188294730")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(RVA = "0x82952E0", Offset = "0x8293CE0", VA = "0x1882952E0")]
		public PortalButtonViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[ViewModel]
	public class PortalPanelViewModel : RRUIBaseGlobalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000081")]
		[CompilerGenerated]
		private struct <FetchPortalPanelData>d__25 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002A1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002A2")]
			public PortalPanelViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002A3")]
			private TaskAwaiter<PortalPanelConfig> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000455")]
			[Cpp2IlInjected.Address(RVA = "0x8299350", Offset = "0x8297D50", VA = "0x188299350", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000456")]
			[Cpp2IlInjected.Address(RVA = "0x8299760", Offset = "0x8298160", VA = "0x188299760", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		[CompilerGenerated]
		private struct <WaitThenUpdateBackplate>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002A4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002A5")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002A6")]
			public PortalPanelViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002A7")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000457")]
			[Cpp2IlInjected.Address(RVA = "0x829DFD0", Offset = "0x829C9D0", VA = "0x18829DFD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000458")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		private CancellationTokenSource cancellationTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		[SerializeField]
		private List<RectTransform> backplateRects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		[SerializeField]
		private Vector2 verticalBackplatePadding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		[SerializeField]
		private RectTransform sectionParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		[SerializeField]
		private RectTransform trayButtonParent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		private DataList<PortalButtonGroupConfig> sections;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private bool hasWidget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private string widgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private bool portalPanelOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private DataItem<bool> HasWidgetDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private DataItem<string> WidgetIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private DataItem<bool> PortalPanelOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private DataItemList SectionsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private DataItemAction TogglePanelStateDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000136")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<PortalButtonGroupConfig> Sections
		{
			[Cpp2IlInjected.Token(Token = "0x6000439")]
			[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043A")]
			[Cpp2IlInjected.Address(RVA = "0x82969C0", Offset = "0x82953C0", VA = "0x1882969C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000137")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool HasWidget
		{
			[Cpp2IlInjected.Token(Token = "0x600043B")]
			[Cpp2IlInjected.Address(RVA = "0xEC9A90", Offset = "0xEC8490", VA = "0x180EC9A90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600043C")]
			[Cpp2IlInjected.Address(RVA = "0x8295F50", Offset = "0x8294950", VA = "0x188295F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000138")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string WidgetId
		{
			[Cpp2IlInjected.Token(Token = "0x600043D")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B30", Offset = "0xAB6530", VA = "0x180AB7B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600043E")]
			[Cpp2IlInjected.Address(RVA = "0x8295FB0", Offset = "0x82949B0", VA = "0x188295FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000139")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool PortalPanelOpen
		{
			[Cpp2IlInjected.Token(Token = "0x600043F")]
			[Cpp2IlInjected.Address(RVA = "0xD54F60", Offset = "0xD53960", VA = "0x180D54F60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000440")]
			[Cpp2IlInjected.Address(RVA = "0x8296020", Offset = "0x8294A20", VA = "0x188296020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013A")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000448")]
			[Cpp2IlInjected.Address(RVA = "0x8296980", Offset = "0x8295380", VA = "0x188296980", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013B")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000449")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(RVA = "0x8295600", Offset = "0x8294000", VA = "0x188295600", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(RVA = "0x8295ED0", Offset = "0x82948D0", VA = "0x188295ED0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(RVA = "0x8295EA0", Offset = "0x82948A0", VA = "0x188295EA0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(RVA = "0x82957B0", Offset = "0x82941B0", VA = "0x1882957B0")]
		[AsyncStateMachine(typeof(<FetchPortalPanelData>d__25))]
		private Task FetchPortalPanelData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(RVA = "0x8296610", Offset = "0x8295010", VA = "0x188296610")]
		[AsyncStateMachine(typeof(<WaitThenUpdateBackplate>d__26))]
		private void WaitThenUpdateBackplate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(RVA = "0x8296150", Offset = "0x8294B50", VA = "0x188296150")]
		private void UpdateBackplateRect()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(RVA = "0x8295EE0", Offset = "0x82948E0", VA = "0x188295EE0")]
		[BindableAction(100, null)]
		private void TogglePanelState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(RVA = "0x82959C0", Offset = "0x82943C0", VA = "0x1882959C0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044B")]
		[Cpp2IlInjected.Address(RVA = "0x8295880", Offset = "0x8294280", VA = "0x188295880")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(RVA = "0x82966C0", Offset = "0x82950C0", VA = "0x1882966C0")]
		public PortalPanelViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[ViewModel]
	public class PortalSectionViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private PortalButtonGroupConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		private string sectionName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		private string iconName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private DataList<PortalButtonConfig> buttons;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private DataItem<string> SectionNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private DataItem<string> IconNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private DataItemList ButtonsDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700013C")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000459")]
			[Cpp2IlInjected.Address(RVA = "0x82974E0", Offset = "0x8295EE0", VA = "0x1882974E0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013D")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string SectionName
		{
			[Cpp2IlInjected.Token(Token = "0x600045A")]
			[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045B")]
			[Cpp2IlInjected.Address(RVA = "0x8297180", Offset = "0x8295B80", VA = "0x188297180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013E")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string IconName
		{
			[Cpp2IlInjected.Token(Token = "0x600045C")]
			[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045D")]
			[Cpp2IlInjected.Address(RVA = "0x82971F0", Offset = "0x8295BF0", VA = "0x1882971F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700013F")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public DataList<PortalButtonConfig> Buttons
		{
			[Cpp2IlInjected.Token(Token = "0x600045E")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B30", Offset = "0xAB6530", VA = "0x180AB7B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600045F")]
			[Cpp2IlInjected.Address(RVA = "0x8297560", Offset = "0x8295F60", VA = "0x188297560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000140")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000461")]
			[Cpp2IlInjected.Address(RVA = "0x82974A0", Offset = "0x8295EA0", VA = "0x1882974A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000141")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000462")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x8296E40", Offset = "0x8295840", VA = "0x188296E40")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x8296B10", Offset = "0x8295510", VA = "0x188296B10", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x8296A20", Offset = "0x8295420", VA = "0x188296A20")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x8297330", Offset = "0x8295D30", VA = "0x188297330")]
		public PortalSectionViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[ViewModel]
	public class WidgetPanelViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		[CompilerGenerated]
		private struct <FetchWidgetData>d__19 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002BE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002BF")]
			public WidgetPanelViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002C0")]
			private int <currentCount>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002C1")]
			private TaskAwaiter<List<string>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600047E")]
			[Cpp2IlInjected.Address(RVA = "0x82997C0", Offset = "0x82981C0", VA = "0x1882997C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600047F")]
			[Cpp2IlInjected.Address(RVA = "0x8299F10", Offset = "0x8298910", VA = "0x188299F10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		[SerializeField]
		private float defaultHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		[SerializeField]
		private int maximumWidgetCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		[SerializeField]
		private WidgetPrefabMapping widgetPrefabMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		[SerializeField]
		private AppNavPanel panel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		[SerializeField]
		private DataResolver availableHeightResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private string panelId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private float maxHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private float currentHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private List<string> tempList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private DataList<string> widgetIdList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		private DataItemList WidgetIdListDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000142")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x600046C")]
			[Cpp2IlInjected.Address(RVA = "0x829EEA0", Offset = "0x829D8A0", VA = "0x18829EEA0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000143")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<string> WidgetIdList
		{
			[Cpp2IlInjected.Token(Token = "0x600046D")]
			[Cpp2IlInjected.Address(RVA = "0xB79620", Offset = "0xB78020", VA = "0x180B79620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600046E")]
			[Cpp2IlInjected.Address(RVA = "0x829EF20", Offset = "0x829D920", VA = "0x18829EF20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000144")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000477")]
			[Cpp2IlInjected.Address(RVA = "0x829EE60", Offset = "0x829D860", VA = "0x18829EE60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000145")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000478")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x829E270", Offset = "0x829CC70", VA = "0x18829E270", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x829EB20", Offset = "0x829D520", VA = "0x18829EB20")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x829E980", Offset = "0x829D380", VA = "0x18829E980", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x829E550", Offset = "0x829CF50", VA = "0x18829E550")]
		[AsyncStateMachine(typeof(<FetchWidgetData>d__19))]
		public Task FetchWidgetData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x829E880", Offset = "0x829D280", VA = "0x18829E880")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x829E470", Offset = "0x829CE70", VA = "0x18829E470")]
		private void CheckIfShouldFetchData(string changedPanelId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x829E4F0", Offset = "0x829CEF0", VA = "0x18829E4F0")]
		private void DoFetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x829E820", Offset = "0x829D220", VA = "0x18829E820")]
		private void OnAvailableHeightUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x829E6D0", Offset = "0x829D0D0", VA = "0x18829E6D0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x829E620", Offset = "0x829D020", VA = "0x18829E620")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x829ECE0", Offset = "0x829D6E0", VA = "0x18829ECE0")]
		public WidgetPanelViewModel()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class WidgetInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public string Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public AssetReference WidgetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public float MaxHeight;

		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x829E210", Offset = "0x829CC10", VA = "0x18829E210")]
		public WidgetInfo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[CreateAssetMenu(fileName = "WidgetPrefabMapping", menuName = "RecRoom/UI/App Nav/Widget Prefab Mapping")]
	public class WidgetPrefabMapping : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public List<WidgetInfo> widgetPrefabs;

		[Cpp2IlInjected.Token(Token = "0x6000481")]
		[Cpp2IlInjected.Address(RVA = "0x829EF90", Offset = "0x829D990", VA = "0x18829EF90")]
		public bool TryGetReference(string widgetId, [Out] AssetReference reference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000482")]
		[Cpp2IlInjected.Address(RVA = "0x829F120", Offset = "0x829DB20", VA = "0x18829F120")]
		public bool TryGetWidgetHeight(string widgetId, [Out] float height)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0xD5D430", Offset = "0xD5BE30", VA = "0x180D5D430")]
		public WidgetPrefabMapping()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[ViewModel]
	public class WidgetWrapperViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private struct <UpdateWidget>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002D5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002D6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002D7")]
			public string widgetId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002D8")]
			public WidgetWrapperViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002D9")]
			private string <typeId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40002DA")]
			private AssetReference <reference>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002DB")]
			private AsyncOperationHandle<GameObject> <refHandle>5__4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002DC")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000495")]
			[Cpp2IlInjected.Address(RVA = "0x829CDA0", Offset = "0x829B7A0", VA = "0x18829CDA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000496")]
			[Cpp2IlInjected.Address(RVA = "0x829D690", Offset = "0x829C090", VA = "0x18829D690", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200008A")]
		[CompilerGenerated]
		private sealed class <MonitorWidgetForSizeChanges>d__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002DD")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002DE")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40002DF")]
			public WidgetWrapperViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002E0")]
			private RectTransform <widgetTransform>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700014A")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600049A")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700014B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600049C")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000497")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public <MonitorWidgetForSizeChanges>d__23(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000498")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000499")]
			[Cpp2IlInjected.Address(RVA = "0x8299F70", Offset = "0x8298970", VA = "0x188299F70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600049B")]
			[Cpp2IlInjected.Address(RVA = "0x829A2C0", Offset = "0x8298CC0", VA = "0x18829A2C0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public const string WIDGET_ID_PROPERTY = "widget_id";

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public const string WIDGET_TYPE_PROPERTY = "widget_type_id";

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		[SerializeField]
		private WidgetPrefabMapping prefabMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		[SerializeField]
		private LayoutElement layoutElement;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		[SerializeField]
		private DataResolver sessionIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		[SerializeField]
		private bool forceWidgetToFitWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private string widgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private AssetReference widgetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private GameObject instantiatedWidget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private ImpressionTracker widgetImpressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private Vector2 cachedWidgetSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private Coroutine widgetSizeCheckCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private DataItem<string> WidgetIdDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000146")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string WidgetId
		{
			[Cpp2IlInjected.Token(Token = "0x6000484")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B40", Offset = "0xAB6540", VA = "0x180AB7B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000485")]
			[Cpp2IlInjected.Address(RVA = "0x829FBD0", Offset = "0x829E5D0", VA = "0x18829FBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000147")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000486")]
			[Cpp2IlInjected.Address(RVA = "0x829FB50", Offset = "0x829E550", VA = "0x18829FB50", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000148")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600048E")]
			[Cpp2IlInjected.Address(RVA = "0x829FB10", Offset = "0x829E510", VA = "0x18829FB10", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000149")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600048F")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000487")]
		[Cpp2IlInjected.Address(RVA = "0x829F2A0", Offset = "0x829DCA0", VA = "0x18829F2A0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000488")]
		[Cpp2IlInjected.Address(RVA = "0x829F800", Offset = "0x829E200", VA = "0x18829F800")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x829F7B0", Offset = "0x829E1B0", VA = "0x18829F7B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x829F5F0", Offset = "0x829DFF0", VA = "0x18829F5F0")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600048B")]
		[Cpp2IlInjected.Address(RVA = "0x829F900", Offset = "0x829E300", VA = "0x18829F900")]
		[AsyncStateMachine(typeof(<UpdateWidget>d__22))]
		public Task UpdateWidget(string widgetId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048C")]
		[Cpp2IlInjected.Address(RVA = "0x829F570", Offset = "0x829DF70", VA = "0x18829F570")]
		[IteratorStateMachine(typeof(<MonitorWidgetForSizeChanges>d__23))]
		private IEnumerator MonitorWidgetForSizeChanges()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600048D")]
		[Cpp2IlInjected.Address(RVA = "0x829F8A0", Offset = "0x829E2A0", VA = "0x18829F8A0")]
		private void ReleaseWidgetReference()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000490")]
		[Cpp2IlInjected.Address(RVA = "0x829F420", Offset = "0x829DE20", VA = "0x18829F420", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000491")]
		[Cpp2IlInjected.Address(RVA = "0x829F370", Offset = "0x829DD70", VA = "0x18829F370")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000492")]
		[Cpp2IlInjected.Address(RVA = "0x829FA10", Offset = "0x829E410", VA = "0x18829FA10")]
		public WidgetWrapperViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[ViewModel]
	public class AccountsWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008C")]
		[CompilerGenerated]
		private struct <OnWidgetIdChanged>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002E8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40002E9")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002EA")]
			public AccountsWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002EB")]
			private TaskAwaiter<AccountListQueryData> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004A9")]
			[Cpp2IlInjected.Address(RVA = "0x829A590", Offset = "0x8298F90", VA = "0x18829A590", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004AA")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private IAppNavDataManager _appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private IRRUIvNextAccountBridge _vNextAccountBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		[SerializeField]
		private AccountListViewModel accountListViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private AccountListQueryData _queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private DataItem<AccountListQueryData> QueryDataDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700014C")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public AccountListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x600049D")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B40", Offset = "0xAB6540", VA = "0x180AB7B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x8287460", Offset = "0x8285E60", VA = "0x188287460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014D")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60004A2")]
			[Cpp2IlInjected.Address(RVA = "0x8287560", Offset = "0x8285F60", VA = "0x188287560", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700014E")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60004A3")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x8286F30", Offset = "0x8285930", VA = "0x188286F30", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A0")]
		[Cpp2IlInjected.Address(RVA = "0x8287300", Offset = "0x8285D00", VA = "0x188287300", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A1")]
		[Cpp2IlInjected.Address(RVA = "0x82873B0", Offset = "0x8285DB0", VA = "0x1882873B0")]
		[AsyncStateMachine(typeof(<OnWidgetIdChanged>d__10))]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A4")]
		[Cpp2IlInjected.Address(RVA = "0x82871B0", Offset = "0x8285BB0", VA = "0x1882871B0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A5")]
		[Cpp2IlInjected.Address(RVA = "0x8287100", Offset = "0x8285B00", VA = "0x188287100")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004A6")]
		[Cpp2IlInjected.Address(RVA = "0x82874D0", Offset = "0x8285ED0", VA = "0x1882874D0")]
		public AccountsWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[ViewModel]
	public class LocalPlayerWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200008E")]
		[CompilerGenerated]
		private struct <FetchDataAsync>d__40 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public LocalPlayerWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			private TaskAwaiter<BMCJEMDNANL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60004D0")]
			[Cpp2IlInjected.Address(RVA = "0x8298450", Offset = "0x8296E50", VA = "0x188298450", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004D1")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private const int INVALID_TOKEN_BALANCE = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		[SerializeField]
		private AccountViewModel accountViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		[SerializeField]
		private bool manuallySetWidgetId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		[SerializeField]
		private Uri profilePageUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		[SerializeField]
		private LinkInfo profileLinkInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		[SerializeField]
		private Uri notificationsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		[SerializeField]
		private LinkInfo notificationsLinkInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		[SerializeField]
		private Uri settingsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		[SerializeField]
		private LinkInfo settingsLinkInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[SerializeField]
		private Uri rrPlusSubscriptionUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private string profilePictureName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private string userName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private bool hasUnreadNotifications;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private long tokenBalance;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private bool hasRecRoomPlus;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private IAccountQueryManager accountManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private IRecRoomPlusDataManager rrPlusDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private int localPlayerId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private DataItem<string> ProfilePictureNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		private DataItem<string> UserNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		private DataItem<bool> HasUnreadNotificationsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		private DataItem<long> TokenBalanceDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private DataItem<bool> HasRecRoomPlusDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private DataItemAction GoToProfilePageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private DataItemAction GoToNotificationsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private DataItemAction GoToSettingsPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		private DataItemAction GoToRRPlusPageDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700014F")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string ProfilePictureName
		{
			[Cpp2IlInjected.Token(Token = "0x60004AB")]
			[Cpp2IlInjected.Address(RVA = "0xAB9520", Offset = "0xAB7F20", VA = "0x180AB9520")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004AC")]
			[Cpp2IlInjected.Address(RVA = "0x8291890", Offset = "0x8290290", VA = "0x188291890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000150")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60004AD")]
			[Cpp2IlInjected.Address(RVA = "0xB793D0", Offset = "0xB77DD0", VA = "0x180B793D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004AE")]
			[Cpp2IlInjected.Address(RVA = "0x8291800", Offset = "0x8290200", VA = "0x188291800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000151")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string UserName
		{
			[Cpp2IlInjected.Token(Token = "0x60004AF")]
			[Cpp2IlInjected.Address(RVA = "0xEE2960", Offset = "0xEE1360", VA = "0x180EE2960")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004B0")]
			[Cpp2IlInjected.Address(RVA = "0x8291910", Offset = "0x8290310", VA = "0x188291910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000152")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool HasUnreadNotifications
		{
			[Cpp2IlInjected.Token(Token = "0x60004B1")]
			[Cpp2IlInjected.Address(RVA = "0x10E8B30", Offset = "0x10E7530", VA = "0x1810E8B30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B2")]
			[Cpp2IlInjected.Address(RVA = "0x82913A0", Offset = "0x828FDA0", VA = "0x1882913A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000153")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public long TokenBalance
		{
			[Cpp2IlInjected.Token(Token = "0x60004B3")]
			[Cpp2IlInjected.Address(RVA = "0xB795C0", Offset = "0xB77FC0", VA = "0x180B795C0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B4")]
			[Cpp2IlInjected.Address(RVA = "0x8291400", Offset = "0x828FE00", VA = "0x188291400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000154")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public bool HasRecRoomPlus
		{
			[Cpp2IlInjected.Token(Token = "0x60004B5")]
			[Cpp2IlInjected.Address(RVA = "0xF25030", Offset = "0xF23A30", VA = "0x180F25030")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004B6")]
			[Cpp2IlInjected.Address(RVA = "0x8291310", Offset = "0x828FD10", VA = "0x188291310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000155")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x82917C0", Offset = "0x82901C0", VA = "0x1882917C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000156")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B7")]
		[Cpp2IlInjected.Address(RVA = "0x828FFE0", Offset = "0x828E9E0", VA = "0x18828FFE0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B8")]
		[Cpp2IlInjected.Address(RVA = "0x82911A0", Offset = "0x828FBA0", VA = "0x1882911A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x8290240", Offset = "0x828EC40", VA = "0x188290240")]
		[AsyncStateMachine(typeof(<FetchDataAsync>d__40))]
		private void FetchDataAsync()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0x8291250", Offset = "0x828FC50", VA = "0x188291250")]
		private void RefreshTokenBalance()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0x82905F0", Offset = "0x828EFF0", VA = "0x1882905F0")]
		[BindableAction(100, null)]
		private void GoToProfilePage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x82904E0", Offset = "0x828EEE0", VA = "0x1882904E0")]
		[BindableAction(101, null)]
		private void GoToNotifications()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x8290830", Offset = "0x828F230", VA = "0x188290830")]
		[BindableAction(102, null)]
		private void GoToSettingsPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BE")]
		[Cpp2IlInjected.Address(RVA = "0x82906F0", Offset = "0x828F0F0", VA = "0x1882906F0")]
		[BindableAction(103, null)]
		private void GoToRRPlusPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0x8290940", Offset = "0x828F340", VA = "0x188290940", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x82902F0", Offset = "0x828ECF0", VA = "0x1882902F0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x8291460", Offset = "0x828FE60", VA = "0x188291460")]
		public LocalPlayerWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[ViewModel]
	public class MyDormWidgetViewModel : RRUIBaseLocalViewModel
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
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private IRoomLoadManager roomLoadManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private DataItemAction OpenThisRoomPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private DataItemAction GoToRecCenterDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private DataItemAction EvictAllDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000157")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60004D2")]
			[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004D3")]
			[Cpp2IlInjected.Address(RVA = "0x8292460", Offset = "0x8290E60", VA = "0x188292460")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000158")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60004DA")]
			[Cpp2IlInjected.Address(RVA = "0x82927B0", Offset = "0x82911B0", VA = "0x1882927B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000159")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60004DB")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004D4")]
		[Cpp2IlInjected.Address(RVA = "0x8291990", Offset = "0x8290390", VA = "0x188291990", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D5")]
		[Cpp2IlInjected.Address(RVA = "0x82924D0", Offset = "0x8290ED0", VA = "0x1882924D0")]
		private void UpdateUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D6")]
		[Cpp2IlInjected.Address(RVA = "0x82923A0", Offset = "0x8290DA0", VA = "0x1882923A0")]
		[BindableAction(100, null)]
		private void OpenThisRoomPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D7")]
		[Cpp2IlInjected.Address(RVA = "0x8291E50", Offset = "0x8290850", VA = "0x188291E50")]
		[BindableAction(101, null)]
		private void GoToRecCenter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D8")]
		[Cpp2IlInjected.Address(RVA = "0x8291C30", Offset = "0x8290630", VA = "0x188291C30")]
		[BindableAction(102, null)]
		private void EvictAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004D9")]
		[Cpp2IlInjected.Address(RVA = "0x8292340", Offset = "0x8290D40", VA = "0x188292340")]
		private void OnJoinRoomResponse(CMHICBAEBCH result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DC")]
		[Cpp2IlInjected.Address(RVA = "0x8292000", Offset = "0x8290A00", VA = "0x188292000", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DD")]
		[Cpp2IlInjected.Address(RVA = "0x8291D40", Offset = "0x8290740", VA = "0x188291D40")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004DE")]
		[Cpp2IlInjected.Address(RVA = "0x8292640", Offset = "0x8291040", VA = "0x188292640")]
		public MyDormWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[ViewModel]
	public class PartyWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000091")]
		[CompilerGenerated]
		private struct <OnPartyChanged>d__39 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public PartyWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600050D")]
			[Cpp2IlInjected.Address(RVA = "0x829A310", Offset = "0x8298D10", VA = "0x18829A310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600050E")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000092")]
		[CompilerGenerated]
		private struct <UpdatePartyData>d__40 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public PartyWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private TaskAwaiter<List<int>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600050F")]
			[Cpp2IlInjected.Address(RVA = "0x829C050", Offset = "0x829AA50", VA = "0x18829C050", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000510")]
			[Cpp2IlInjected.Address(RVA = "0x829C810", Offset = "0x829B210", VA = "0x18829C810", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		[SerializeField]
		private Uri createPartyUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		[SerializeField]
		private Uri managePartyUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[SerializeField]
		private Uri openPartyChatUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		[SerializeField]
		private float notInPartyHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		[SerializeField]
		private float inPartyHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private bool inParty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private bool partyChatAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private bool canGoToParty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x83")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private bool canAddToParty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private DataList<int> partyMembers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private int partyMemberCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private bool hasUnreadPartyChatMessages;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private IRRUIvNextSocialBridge socialBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private bool updatePending;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private bool updateQueued;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private DataItem<bool> InPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private DataItem<bool> PartyChatAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		private DataItem<bool> CanGoToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		private DataItem<bool> CanAddToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		private DataItem<int> PartyMemberCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		private DataItem<bool> HasUnreadPartyChatMessagesDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		private DataItemList PartyMembersDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private DataItemAction CreateOrJoinPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		private DataItemAction OpenPartyChatDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private DataItemAction GoToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private DataItemAction AddToPartyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private DataItemAction ManagePartyDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700015A")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool InParty
		{
			[Cpp2IlInjected.Token(Token = "0x60004E1")]
			[Cpp2IlInjected.Address(RVA = "0xD54F60", Offset = "0xD53960", VA = "0x180D54F60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E2")]
			[Cpp2IlInjected.Address(RVA = "0x8293F90", Offset = "0x8292990", VA = "0x188293F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015B")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool PartyChatAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x60004E3")]
			[Cpp2IlInjected.Address(RVA = "0xFD8E80", Offset = "0xFD7880", VA = "0x180FD8E80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E4")]
			[Cpp2IlInjected.Address(RVA = "0x8293FF0", Offset = "0x82929F0", VA = "0x188293FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015C")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public bool CanGoToParty
		{
			[Cpp2IlInjected.Token(Token = "0x60004E5")]
			[Cpp2IlInjected.Address(RVA = "0xFD8E90", Offset = "0xFD7890", VA = "0x180FD8E90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E6")]
			[Cpp2IlInjected.Address(RVA = "0x8294050", Offset = "0x8292A50", VA = "0x188294050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015D")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool CanAddToParty
		{
			[Cpp2IlInjected.Token(Token = "0x60004E7")]
			[Cpp2IlInjected.Address(RVA = "0x167D800", Offset = "0x167C200", VA = "0x18167D800")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004E8")]
			[Cpp2IlInjected.Address(RVA = "0x82940B0", Offset = "0x8292AB0", VA = "0x1882940B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015E")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public DataList<int> PartyMembers
		{
			[Cpp2IlInjected.Token(Token = "0x60004E9")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6550", VA = "0x180AB7B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60004EA")]
			[Cpp2IlInjected.Address(RVA = "0x8294630", Offset = "0x8293030", VA = "0x188294630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700015F")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public int PartyMemberCount
		{
			[Cpp2IlInjected.Token(Token = "0x60004EB")]
			[Cpp2IlInjected.Address(RVA = "0xAB7C20", Offset = "0xAB6620", VA = "0x180AB7C20")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60004EC")]
			[Cpp2IlInjected.Address(RVA = "0x8294110", Offset = "0x8292B10", VA = "0x188294110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000160")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool HasUnreadPartyChatMessages
		{
			[Cpp2IlInjected.Token(Token = "0x60004ED")]
			[Cpp2IlInjected.Address(RVA = "0x1F85E50", Offset = "0x1F84850", VA = "0x181F85E50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60004EE")]
			[Cpp2IlInjected.Address(RVA = "0x8293E60", Offset = "0x8292860", VA = "0x188293E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000161")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60004FA")]
			[Cpp2IlInjected.Address(RVA = "0x82945F0", Offset = "0x8292FF0", VA = "0x1882945F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000162")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60004FB")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004EF")]
		[Cpp2IlInjected.Address(RVA = "0x82928C0", Offset = "0x82912C0", VA = "0x1882928C0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F0")]
		[Cpp2IlInjected.Address(RVA = "0x82939D0", Offset = "0x82923D0", VA = "0x1882939D0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F1")]
		[Cpp2IlInjected.Address(RVA = "0x8293B30", Offset = "0x8292530", VA = "0x188293B30")]
		[AsyncStateMachine(typeof(<OnPartyChanged>d__39))]
		private void OnPartyChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F2")]
		[Cpp2IlInjected.Address(RVA = "0x8294170", Offset = "0x8292B70", VA = "0x188294170")]
		[AsyncStateMachine(typeof(<UpdatePartyData>d__40))]
		private Task UpdatePartyData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x8293D50", Offset = "0x8292750", VA = "0x188293D50")]
		private void SetHeight()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x8293BE0", Offset = "0x82925E0", VA = "0x188293BE0")]
		private void OnPartyChatUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F5")]
		[Cpp2IlInjected.Address(RVA = "0x8292B70", Offset = "0x8291570", VA = "0x188292B70")]
		[BindableAction(100, null)]
		private void CreateOrJoinParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F6")]
		[Cpp2IlInjected.Address(RVA = "0x8293C80", Offset = "0x8292680", VA = "0x188293C80")]
		[BindableAction(101, null)]
		private void OpenPartyChat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F7")]
		[Cpp2IlInjected.Address(RVA = "0x8292E70", Offset = "0x8291870", VA = "0x188292E70")]
		[BindableAction(102, null)]
		private void GoToParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F8")]
		[Cpp2IlInjected.Address(RVA = "0x82927F0", Offset = "0x82911F0", VA = "0x1882927F0")]
		[BindableAction(103, null)]
		private void AddToParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004F9")]
		[Cpp2IlInjected.Address(RVA = "0x8293900", Offset = "0x8292300", VA = "0x188293900")]
		[BindableAction(104, null)]
		private void ManageParty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FC")]
		[Cpp2IlInjected.Address(RVA = "0x8292F30", Offset = "0x8291930", VA = "0x188292F30", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FD")]
		[Cpp2IlInjected.Address(RVA = "0x8292C40", Offset = "0x8291640", VA = "0x188292C40")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004FE")]
		[Cpp2IlInjected.Address(RVA = "0x8294240", Offset = "0x8292C40", VA = "0x188294240")]
		public PartyWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	public class RoomCarouselWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000094")]
		[CompilerGenerated]
		private struct <OnWidgetIdChanged>d__7 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public RoomCarouselWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			private string <widgetId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			private WidgetSourceData <widgetSourceData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			private TaskAwaiter<IReadOnlyList<LFCAJIEBPDF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000515")]
			[Cpp2IlInjected.Address(RVA = "0x829AE90", Offset = "0x8299890", VA = "0x18829AE90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000516")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		[SerializeField]
		private RoomListViewModel roomListViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		private RoomListQueryData queryData;

		[Cpp2IlInjected.Token(Token = "0x6000511")]
		[Cpp2IlInjected.Address(RVA = "0x82975C0", Offset = "0x8295FC0", VA = "0x1882975C0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000512")]
		[Cpp2IlInjected.Address(RVA = "0x8297790", Offset = "0x8296190", VA = "0x188297790", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000513")]
		[Cpp2IlInjected.Address(RVA = "0x8297840", Offset = "0x8296240", VA = "0x188297840")]
		[AsyncStateMachine(typeof(<OnWidgetIdChanged>d__7))]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000514")]
		[Cpp2IlInjected.Address(RVA = "0x82978F0", Offset = "0x82962F0", VA = "0x1882978F0")]
		public RoomCarouselWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[ViewModel]
	public class RoomCategoryCarouselWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[CompilerGenerated]
		private struct <OnWidgetIdChanged>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			public RoomCategoryCarouselWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			private string <widgetId>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			private WidgetSourceData <widgetSourceData>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			private TaskAwaiter<IReadOnlyList<LFCAJIEBPDF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600051F")]
			[Cpp2IlInjected.Address(RVA = "0x829A920", Offset = "0x8299320", VA = "0x18829A920", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000520")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		[SerializeField]
		private RoomCategoryListViewModel categoryListViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private IAppNavDataManager appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.Token(Token = "0x17000163")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600051A")]
			[Cpp2IlInjected.Address(RVA = "0x8297D40", Offset = "0x8296740", VA = "0x188297D40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000164")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600051B")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000517")]
		[Cpp2IlInjected.Address(RVA = "0x8297970", Offset = "0x8296370", VA = "0x188297970", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000518")]
		[Cpp2IlInjected.Address(RVA = "0x8297BD0", Offset = "0x82965D0", VA = "0x188297BD0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000519")]
		[Cpp2IlInjected.Address(RVA = "0x8297C80", Offset = "0x8296680", VA = "0x188297C80")]
		[AsyncStateMachine(typeof(<OnWidgetIdChanged>d__6))]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x8297BC0", Offset = "0x82965C0", VA = "0x188297BC0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x8297B40", Offset = "0x8296540", VA = "0x188297B40")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0x8297D30", Offset = "0x8296730", VA = "0x188297D30")]
		public RoomCategoryCarouselWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[ViewModel]
	public class StoreItemsWidgetViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private struct <OnWidgetIdChanged>d__21 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public StoreItemsWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			private TaskAwaiter<IReadOnlyList<LFCAJIEBPDF>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000535")]
			[Cpp2IlInjected.Address(RVA = "0x82BAC90", Offset = "0x82B9690", VA = "0x1882BAC90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000536")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private struct <TryLoadingFromActiveSourceList>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public StoreItemsWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			private TaskAwaiter<IReadOnlyList<LFCAJIEBPDF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000537")]
			[Cpp2IlInjected.Address(RVA = "0x82BB820", Offset = "0x82BA220", VA = "0x1882BB820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000538")]
			[Cpp2IlInjected.Address(RVA = "0x82BBBE0", Offset = "0x82BA5E0", VA = "0x1882BBBE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private struct <OnQueryDataLoaded>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public StoreItemsWidgetViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000539")]
			[Cpp2IlInjected.Address(RVA = "0x82BAAE0", Offset = "0x82B94E0", VA = "0x1882BAAE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600053A")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		[SerializeField]
		private int maxItemsInList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[SerializeField]
		private DataResolver widgetIdResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private IRRUIvNextBridge _vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private IRRUIvNextStoreItemBridge storeBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private IAppNavDataManager _appNavDataManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private BrowserModel _browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		private List<WidgetSourceData> sourceList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		private int activeSectionIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		private WidgetSourceData widgetSourceData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		[SerializeField]
		private StoreItemListViewModel storeItemListViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		private StoreItemListQueryData _queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		private DataItem<StoreItemListQueryData> QueryDataDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		private DataItemAction GoToStorePageDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000165")]
		private PPFENAOBDPL Room
		{
			[Cpp2IlInjected.Token(Token = "0x6000521")]
			[Cpp2IlInjected.Address(RVA = "0x82B8B30", Offset = "0x82B7530", VA = "0x1882B8B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000166")]
		private bool CanShowRelatedStoreItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000522")]
			[Cpp2IlInjected.Address(RVA = "0x82B8940", Offset = "0x82B7340", VA = "0x1882B8940")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000167")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public StoreItemListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x6000523")]
			[Cpp2IlInjected.Address(RVA = "0xB793D0", Offset = "0xB77DD0", VA = "0x180B793D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000524")]
			[Cpp2IlInjected.Address(RVA = "0x82B87F0", Offset = "0x82B71F0", VA = "0x1882B87F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000168")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600052E")]
			[Cpp2IlInjected.Address(RVA = "0x82B8AF0", Offset = "0x82B74F0", VA = "0x1882B8AF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000169")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600052F")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x82B7960", Offset = "0x82B6360", VA = "0x1882B7960")]
		[BindableAction(100, null)]
		private void GoToStorePage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x82B75D0", Offset = "0x82B5FD0", VA = "0x1882B75D0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0x82B7D30", Offset = "0x82B6730", VA = "0x1882B7D30", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x82B7F00", Offset = "0x82B6900", VA = "0x1882B7F00")]
		[AsyncStateMachine(typeof(<OnWidgetIdChanged>d__21))]
		private void OnWidgetIdChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x82B81C0", Offset = "0x82B6BC0", VA = "0x1882B81C0")]
		[AsyncStateMachine(typeof(<TryLoadingFromActiveSourceList>d__22))]
		private Task<bool> TryLoadingFromActiveSourceList()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0x82B7FB0", Offset = "0x82B69B0", VA = "0x1882B7FB0")]
		private bool TryLoadSection(LFCAJIEBPDF section)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x82B80F0", Offset = "0x82B6AF0", VA = "0x1882B80F0")]
		private bool TryLoadSource(string source, string sourceMetadata)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x82B82B0", Offset = "0x82B6CB0", VA = "0x1882B82B0")]
		private bool TrySetQueryData(string source, string sourceMetadata)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600052D")]
		[Cpp2IlInjected.Address(RVA = "0x82B7E50", Offset = "0x82B6850", VA = "0x1882B7E50")]
		[AsyncStateMachine(typeof(<OnQueryDataLoaded>d__26))]
		private void OnQueryDataLoaded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000530")]
		[Cpp2IlInjected.Address(RVA = "0x82B7B30", Offset = "0x82B6530", VA = "0x1882B7B30", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000531")]
		[Cpp2IlInjected.Address(RVA = "0x82B7890", Offset = "0x82B6290", VA = "0x1882B7890")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000532")]
		[Cpp2IlInjected.Address(RVA = "0x82B8860", Offset = "0x82B7260", VA = "0x1882B8860")]
		public StoreItemsWidgetViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[ViewModel]
	public class ThisRoomWidgetViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		[SerializeField]
		private Uri thisRoomUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private bool canReportRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		private IRoomLoadManager roomLoadManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		private DataItem<bool> CanReportRoomDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		private DataItemAction OpenThisRoomPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		private DataItemAction GoToDormDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		private DataItemAction ReportRoomDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		private DataItemAction GoToRecCenterDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700016A")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x600053B")]
			[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600053C")]
			[Cpp2IlInjected.Address(RVA = "0x82B99E0", Offset = "0x82B83E0", VA = "0x1882B99E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016B")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool CanReportRoom
		{
			[Cpp2IlInjected.Token(Token = "0x600053D")]
			[Cpp2IlInjected.Address(RVA = "0xEC9A90", Offset = "0xEC8490", VA = "0x180EC9A90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600053E")]
			[Cpp2IlInjected.Address(RVA = "0x82B9A50", Offset = "0x82B8450", VA = "0x1882B9A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016C")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000546")]
			[Cpp2IlInjected.Address(RVA = "0x82B9DF0", Offset = "0x82B87F0", VA = "0x1882B9DF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016D")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000547")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600053F")]
		[Cpp2IlInjected.Address(RVA = "0x82B8B70", Offset = "0x82B7570", VA = "0x1882B8B70", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000540")]
		[Cpp2IlInjected.Address(RVA = "0x82B9AB0", Offset = "0x82B84B0", VA = "0x1882B9AB0")]
		private void UpdateUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000541")]
		[Cpp2IlInjected.Address(RVA = "0x82B9700", Offset = "0x82B8100", VA = "0x1882B9700")]
		[BindableAction(100, null)]
		private void OpenThisRoomPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000542")]
		[Cpp2IlInjected.Address(RVA = "0x82B8F50", Offset = "0x82B7950", VA = "0x1882B8F50")]
		[BindableAction(101, null)]
		private void GoToDorm()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000543")]
		[Cpp2IlInjected.Address(RVA = "0x82B97C0", Offset = "0x82B81C0", VA = "0x1882B97C0")]
		[BindableAction(102, null)]
		private void ReportRoom()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000544")]
		[Cpp2IlInjected.Address(RVA = "0x82B9000", Offset = "0x82B7A00", VA = "0x1882B9000")]
		[BindableAction(103, null)]
		private void GoToRecCenter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000545")]
		[Cpp2IlInjected.Address(RVA = "0x82B96A0", Offset = "0x82B80A0", VA = "0x1882B96A0")]
		private void OnJoinRoomResponse(CMHICBAEBCH result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0x82B91D0", Offset = "0x82B7BD0", VA = "0x1882B91D0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0x82B8DF0", Offset = "0x82B77F0", VA = "0x1882B8DF0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0x82B9C00", Offset = "0x82B8600", VA = "0x1882B9C00")]
		public ThisRoomWidgetViewModel()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	public class AssetReferenceInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		public string Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		public AssetReference Asset;

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0x829FC50", Offset = "0x829E650", VA = "0x18829FC50")]
		public AssetReferenceInfo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[CreateAssetMenu(fileName = "AssetReferenceLookup", menuName = "RecRoom/UI/Asset Reference Lookup")]
	public class AssetReferenceLookup : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		[SerializeField]
		private List<AssetReferenceInfo> assetReferences;

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0x829FCB0", Offset = "0x829E6B0", VA = "0x18829FCB0")]
		public bool TryGetAssetReference(string assetId, [Out] AssetReference assetReference)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0xD5D430", Offset = "0xD5BE30", VA = "0x180D5D430")]
		public AssetReferenceLookup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[ViewModel]
	public class StoreItemListViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200009F")]
		[CompilerGenerated]
		private struct <FetchData>d__35 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			public StoreItemListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			private TaskAwaiter<IReadOnlyList<JJNPIFNJJFP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0x82B9E30", Offset = "0x82B8830", VA = "0x1882B9E30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400037E")]
		private static readonly List<CKAJELFPLEM> ImmediateUnifiedItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		public EBDGCEEEFPM OnDataFetched;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private BrowserModel _browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private IRRUIvNextBridge _vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		private IRRUIvNextStoreItemBridge _vNextStoreItemBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private IStoreItemQueryManager _storeItemListQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private CancellationTokenSource _cancellationTokenSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		private bool _waitingForQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		private int _minItemsCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		[SerializeField]
		private StoreItemListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		private DataList<CKAJELFPLEM> _storeItemIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private string _displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private bool _isEmptyOrBelowMinimum;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private DataItem<StoreItemListQueryData> QueryDataDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private DataItem<bool> IsEmptyOrBelowMinimumDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		private DataItemList StoreItemIdsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		private DataItemAction GoToViewMorePageDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700016E")]
		public int MinItemsCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000552")]
			[Cpp2IlInjected.Address(RVA = "0x3012430", Offset = "0x3010E30", VA = "0x183012430")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000553")]
			[Cpp2IlInjected.Address(RVA = "0x82B4B50", Offset = "0x82B3550", VA = "0x1882B4B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700016F")]
		[BindableData(0, "The query data used to retrieve the store item list", DataPermissions.ReadOnly)]
		public StoreItemListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x6000556")]
			[Cpp2IlInjected.Address(RVA = "0xAB7A80", Offset = "0xAB6480", VA = "0x180AB7A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000170")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public DataList<CKAJELFPLEM> StoreItemIds
		{
			[Cpp2IlInjected.Token(Token = "0x6000557")]
			[Cpp2IlInjected.Address(RVA = "0xB79620", Offset = "0xB78020", VA = "0x180B79620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000558")]
			[Cpp2IlInjected.Address(RVA = "0x82B4B80", Offset = "0x82B3580", VA = "0x1882B4B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000171")]
		[BindableData(2, "The name of the list that can be shown on the UI, e.g. as a carousel title", DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000559")]
			[Cpp2IlInjected.Address(RVA = "0xAB9520", Offset = "0xAB7F20", VA = "0x180AB9520")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600055A")]
			[Cpp2IlInjected.Address(RVA = "0x82B4AD0", Offset = "0x82B34D0", VA = "0x1882B4AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000172")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool IsEmptyOrBelowMinimum
		{
			[Cpp2IlInjected.Token(Token = "0x600055B")]
			[Cpp2IlInjected.Address(RVA = "0xC5E0D0", Offset = "0xC5CAD0", VA = "0x180C5E0D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600055C")]
			[Cpp2IlInjected.Address(RVA = "0x82B4610", Offset = "0x82B3010", VA = "0x1882B4610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000173")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000566")]
			[Cpp2IlInjected.Address(RVA = "0x82B4A90", Offset = "0x82B3490", VA = "0x1882B4A90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000174")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000567")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0x82B3E40", Offset = "0x82B2840", VA = "0x1882B3E40")]
		public void SetDiscoverySectionId(string sectionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0x82B3EF0", Offset = "0x82B28F0", VA = "0x1882B3EF0")]
		public void SetParentTabName(string parentTabName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0x82B35A0", Offset = "0x82B1FA0", VA = "0x1882B35A0")]
		[BindableAction(100, null)]
		private void GoToViewMorePage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0x82B3110", Offset = "0x82B1B10", VA = "0x1882B3110", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0x82B4590", Offset = "0x82B2F90", VA = "0x1882B4590")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0x82B3DA0", Offset = "0x82B27A0", VA = "0x1882B3DA0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0x82B4080", Offset = "0x82B2A80", VA = "0x1882B4080")]
		public void SetQueryData(StoreItemListQueryData listQueryData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0x82B3FA0", Offset = "0x82B29A0", VA = "0x1882B3FA0")]
		public void SetPropertiesToDefaults()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000563")]
		[Cpp2IlInjected.Address(RVA = "0x82B3210", Offset = "0x82B1C10", VA = "0x1882B3210")]
		[AsyncStateMachine(typeof(<FetchData>d__35))]
		public void FetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0x82B3400", Offset = "0x82B1E00", VA = "0x1882B3400")]
		private string GetDisplayName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0x82B41B0", Offset = "0x82B2BB0", VA = "0x1882B41B0")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000568")]
		[Cpp2IlInjected.Address(RVA = "0x82B38D0", Offset = "0x82B22D0", VA = "0x1882B38D0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000569")]
		[Cpp2IlInjected.Address(RVA = "0x82B32C0", Offset = "0x82B1CC0", VA = "0x1882B32C0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600056A")]
		[Cpp2IlInjected.Address(RVA = "0x82B47E0", Offset = "0x82B31E0", VA = "0x1882B47E0")]
		public StoreItemListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[ViewModel]
	public class StoreItemViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[CompilerGenerated]
		private struct <FetchStoreItemData>d__54 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			public StoreItemViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			private TaskAwaiter<JJNPIFNJJFP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60005A7")]
			[Cpp2IlInjected.Address(RVA = "0x82BA730", Offset = "0x82B9130", VA = "0x1882BA730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005A8")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private static OLFEOKKCIEG Log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private BrowserModel _browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private IRRUIvNextBridge _vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private IRRUIvNextStoreItemBridge _vNextStoreItemBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private Uri itemDetailsUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private string _thumbnailImageFilename;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private string costText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private bool isOnSale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private string saleText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400039F")]
		private bool isLimitedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40003A0")]
		private string limitedTimeText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40003A1")]
		private bool isOwned;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB9")]
		[Cpp2IlInjected.Token(Token = "0x40003A2")]
		private bool isRecRoomPlusExclusive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40003A3")]
		private CKAJELFPLEM storeItemId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40003A4")]
		private long price;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private DataItem<string> ThumbnailImageFilenameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private DataItem<string> CostTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private DataItem<bool> IsOnSaleDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private DataItem<string> SaleTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private DataItem<bool> IsLimitedTimeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private DataItem<string> LimitedTimeTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private DataItem<bool> IsOwnedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40003AE")]
		private DataItem<bool> IsRecRoomPlusExclusiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40003AF")]
		private DataItem<CKAJELFPLEM> StoreItemIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40003B0")]
		private DataItem<long> PriceDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40003B1")]
		private DataItemAction GoToDetailsPageDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000175")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0x82B7020", Offset = "0x82B5A20", VA = "0x1882B7020", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000176")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string ThumbnailImageFilename
		{
			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B40", Offset = "0xAB6540", VA = "0x180AB7B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000577")]
			[Cpp2IlInjected.Address(RVA = "0x82B7550", Offset = "0x82B5F50", VA = "0x1882B7550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000177")]
		[BindableData(1, "The sanitized, friendly name of the store item", DataPermissions.ReadOnly)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000578")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6550", VA = "0x180AB7B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0x82B7120", Offset = "0x82B5B20", VA = "0x1882B7120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000178")]
		[BindableData(2, "The price of the item (including strikethrough for discounts or 'Owned' if owned)", DataPermissions.ReadOnly)]
		public string CostText
		{
			[Cpp2IlInjected.Token(Token = "0x600057A")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7C0", Offset = "0xB2E1C0", VA = "0x180B2F7C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600057B")]
			[Cpp2IlInjected.Address(RVA = "0x82B70A0", Offset = "0x82B5AA0", VA = "0x1882B70A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000179")]
		[BindableData(3, "Whether or not the item is currently on sale (has a discount)", DataPermissions.ReadOnly)]
		public bool IsOnSale
		{
			[Cpp2IlInjected.Token(Token = "0x600057C")]
			[Cpp2IlInjected.Address(RVA = "0xFEB740", Offset = "0xFEA140", VA = "0x180FEB740")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600057D")]
			[Cpp2IlInjected.Address(RVA = "0x82B7200", Offset = "0x82B5C00", VA = "0x1882B7200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017A")]
		[BindableData(4, "Text to show on the sale banner", DataPermissions.ReadOnly)]
		public string SaleText
		{
			[Cpp2IlInjected.Token(Token = "0x600057E")]
			[Cpp2IlInjected.Address(RVA = "0xB79620", Offset = "0xB78020", VA = "0x180B79620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600057F")]
			[Cpp2IlInjected.Address(RVA = "0x82B73A0", Offset = "0x82B5DA0", VA = "0x1882B73A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017B")]
		[BindableData(5, "Whether or not to show the 'Limited Time' banner", DataPermissions.ReadOnly)]
		public bool IsLimitedTime
		{
			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0xB797F0", Offset = "0xB781F0", VA = "0x180B797F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000581")]
			[Cpp2IlInjected.Address(RVA = "0x82B71A0", Offset = "0x82B5BA0", VA = "0x1882B71A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017C")]
		[BindableData(6, "Text to show on the 'Limited Time' banner", DataPermissions.ReadOnly)]
		public string LimitedTimeText
		{
			[Cpp2IlInjected.Token(Token = "0x6000582")]
			[Cpp2IlInjected.Address(RVA = "0xB793D0", Offset = "0xB77DD0", VA = "0x180B793D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000583")]
			[Cpp2IlInjected.Address(RVA = "0x82B7320", Offset = "0x82B5D20", VA = "0x1882B7320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017D")]
		[BindableData(7, "Whether or not the player owns this item", DataPermissions.ReadOnly)]
		public bool IsOwned
		{
			[Cpp2IlInjected.Token(Token = "0x6000584")]
			[Cpp2IlInjected.Address(RVA = "0xE2A010", Offset = "0xE28A10", VA = "0x180E2A010")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000585")]
			[Cpp2IlInjected.Address(RVA = "0x82B7260", Offset = "0x82B5C60", VA = "0x1882B7260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017E")]
		[BindableData(8, "Whether or not to show the 'Rec Room Plus Exclusive' icon", DataPermissions.ReadOnly)]
		public bool IsRecRoomPlusExclusive
		{
			[Cpp2IlInjected.Token(Token = "0x6000586")]
			[Cpp2IlInjected.Address(RVA = "0xC5ED90", Offset = "0xC5D790", VA = "0x180C5ED90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0x82B72C0", Offset = "0x82B5CC0", VA = "0x1882B72C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700017F")]
		[BindableData(9, "The ID used to retrieve the IStoreItem from RecNet", DataPermissions.ReadWrite)]
		public CKAJELFPLEM StoreItemId
		{
			[Cpp2IlInjected.Token(Token = "0x6000588")]
			[Cpp2IlInjected.Address(RVA = "0x82B6050", Offset = "0x82B4A50", VA = "0x1882B6050")]
			get
			{
				return default(CKAJELFPLEM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000589")]
			[Cpp2IlInjected.Address(RVA = "0x82B7420", Offset = "0x82B5E20", VA = "0x1882B7420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000180")]
		[BindableData(10, "The price of the item after any applicable discounts", DataPermissions.ReadWrite)]
		public long Price
		{
			[Cpp2IlInjected.Token(Token = "0x600058A")]
			[Cpp2IlInjected.Address(RVA = "0xAB94F0", Offset = "0xAB7EF0", VA = "0x180AB94F0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600058B")]
			[Cpp2IlInjected.Address(RVA = "0x82B60A0", Offset = "0x82B4AA0", VA = "0x1882B60A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000181")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000593")]
			[Cpp2IlInjected.Address(RVA = "0x82B6FE0", Offset = "0x82B59E0", VA = "0x1882B6FE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000182")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000594")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600058C")]
		[Cpp2IlInjected.Address(RVA = "0x82B4FA0", Offset = "0x82B39A0", VA = "0x1882B4FA0")]
		[BindableAction(100, null)]
		private void GoToDetailsPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058D")]
		[Cpp2IlInjected.Address(RVA = "0x82B4BF0", Offset = "0x82B35F0", VA = "0x1882B4BF0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058E")]
		[Cpp2IlInjected.Address(RVA = "0x82B5AF0", Offset = "0x82B44F0", VA = "0x1882B5AF0")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600058F")]
		[Cpp2IlInjected.Address(RVA = "0x82B4CC0", Offset = "0x82B36C0", VA = "0x1882B4CC0")]
		[AsyncStateMachine(typeof(<FetchStoreItemData>d__54))]
		private void FetchStoreItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000590")]
		[Cpp2IlInjected.Address(RVA = "0x82B6110", Offset = "0x82B4B10", VA = "0x1882B6110")]
		private void UpdateStoreItemData(JJNPIFNJJFP storeItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000591")]
		[Cpp2IlInjected.Address(RVA = "0x82B5DD0", Offset = "0x82B47D0", VA = "0x1882B5DD0")]
		private void ResetStoreItemData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000592")]
		[Cpp2IlInjected.Address(RVA = "0x82B5C50", Offset = "0x82B4650", VA = "0x1882B5C50")]
		private void RecordImpressionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000595")]
		[Cpp2IlInjected.Address(RVA = "0x82B5160", Offset = "0x82B3B60", VA = "0x1882B5160", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000596")]
		[Cpp2IlInjected.Address(RVA = "0x82B4D70", Offset = "0x82B3770", VA = "0x1882B4D70")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0x82B6BD0", Offset = "0x82B55D0", VA = "0x1882B6BD0")]
		public StoreItemViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	public enum CarouselType
	{
		[Cpp2IlInjected.Token(Token = "0x40003B7")]
		Room,
		[Cpp2IlInjected.Token(Token = "0x40003B8")]
		Event,
		[Cpp2IlInjected.Token(Token = "0x40003B9")]
		Club,
		[Cpp2IlInjected.Token(Token = "0x40003BA")]
		Invention,
		[Cpp2IlInjected.Token(Token = "0x40003BB")]
		StoreItem,
		[Cpp2IlInjected.Token(Token = "0x40003BC")]
		CustomAvatarItem,
		[Cpp2IlInjected.Token(Token = "0x40003BD")]
		Account
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	public enum HighlightStyle
	{
		[Cpp2IlInjected.Token(Token = "0x40003BF")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		Scale150,
		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		Portrait,
		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		Scale75,
		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		Scale100,
		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		FitPerRow4,
		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		FitPerRow5,
		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		FitPerRow6
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[CreateAssetMenu(fileName = "CarouselDisplayConfig", menuName = "RecRoom/UI/CarouselDisplayConfig")]
	public class CarouselDisplayConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000A5")]
		public struct HighlightCardDataObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			public AMLOJEALFHA platformMask;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public float cardWidth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public float cardHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public HighlightStyle HighlightStyle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			public bool VR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			[ReadOnlyField]
			[Tooltip("Carousel height is driven by the card height. Multi-row room carousels will add one 'Card Height' height per row.")]
			public float carouselHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			public int cardLimit;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000A6")]
		public struct CardDataObject
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			[ReadOnlyField]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public CarouselType CarouselType;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public float carouselTitleHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public float cardMetadataHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			[Tooltip("Carousel height is driven by the card height. Multi-row room carousels will add one 'Default Card Height' height per row.")]
			[ReadOnlyField]
			public float defaultCarouselHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public float defaultCardWidth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public float defaultCardHeight;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public int defaultCardLimitWithScroll;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public int defaultCardLimitWithNoScroll;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public RectOffset singleRowCarouselPadding;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public RectOffset multiRowCarouselPadding;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			[FormerlySerializedAs("rowBottomPadding")]
			[Tooltip("Keep this in sync with the 'item spacing' value in Virtualized Scroll Rect List")]
			public int rowPaddingBottom;
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x20000A7")]
		public struct DiscoveryVariantOverrides
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public string variantName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			public int cardHeight;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		[SerializeField]
		public List<Uri> Uris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		[SerializeField]
		public bool allowCarouselHighlightingOnConfiguredUris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		[SerializeField]
		public bool allowEnforcingOrderedRenderingOnConfiguredUris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		[Tooltip("Multiplies the number of cards per row by this factor as part of MaximumResultCount. This way, if carousel content is deduplicated, there will still be cards to fill in the empty space left in the carousel.")]
		[SerializeField]
		private int dedupingMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		[SerializeField]
		[FormerlySerializedAs("minItemsToFetchPerRow")]
		[Tooltip("Puts a lower bound on number of fetched items as part of MaximumResultCount. This way, if carousel content is deduplicated, there will still be cards to fill in the empty space left in the carousel.")]
		private int minItemsToFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		[SerializeField]
		private CardDataObject[] defaultCardList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		[SerializeField]
		private HighlightCardDataObject[] highlightRoomListConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		[SerializeField]
		private DiscoveryVariantOverrides[] discoveryVariantOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.Token(Token = "0x17000183")]
		private IRRUIvNextBridge VNextBridge
		{
			[Cpp2IlInjected.Token(Token = "0x60005A9")]
			[Cpp2IlInjected.Address(RVA = "0x82A0E10", Offset = "0x829F810", VA = "0x1882A0E10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005AA")]
		[Cpp2IlInjected.Address(RVA = "0x82A0CA0", Offset = "0x829F6A0", VA = "0x1882A0CA0")]
		public bool IsAnyConfiguredUriActive(BrowserModel browserModel)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AB")]
		[Cpp2IlInjected.Address(RVA = "0x82A0420", Offset = "0x829EE20", VA = "0x1882A0420")]
		public float GetCardWidth(HighlightStyle highlightStyle, CarouselType carouselType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AC")]
		[Cpp2IlInjected.Address(RVA = "0x82A0020", Offset = "0x829EA20", VA = "0x1882A0020")]
		public float GetCardHeight(HighlightStyle highlightStyle, CarouselType carouselType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AD")]
		[Cpp2IlInjected.Address(RVA = "0x82A0560", Offset = "0x829EF60", VA = "0x1882A0560")]
		public float GetCarouselHeight(HighlightStyle highlightStyle, CarouselType carouselType, int numRows = 1, bool addPadding = true)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60005AE")]
		[Cpp2IlInjected.Address(RVA = "0x82A07C0", Offset = "0x829F1C0", VA = "0x1882A07C0")]
		public RectOffset GetCarouselPadding(CarouselType carouselType, int numRows)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005AF")]
		[Cpp2IlInjected.Address(RVA = "0x82A02E0", Offset = "0x829ECE0", VA = "0x1882A02E0")]
		public int GetCardLimitPerRow(bool isHorizontalScrollEnabled, HighlightStyle highlightStyle, CarouselType carouselType)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B0")]
		[Cpp2IlInjected.Address(RVA = "0x82A0C70", Offset = "0x829F670", VA = "0x1882A0C70")]
		public int GetTotalCardLimit(bool isHorizontalScrollEnabled, HighlightStyle highlightStyle, CarouselType carouselType, int maxRows = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B1")]
		[Cpp2IlInjected.Address(RVA = "0x82A0BC0", Offset = "0x829F5C0", VA = "0x1882A0BC0")]
		public int GetMinItemsToFetch(bool isHorizontalScrollEnabled, HighlightStyle highlightStyle, CarouselType carouselType, int maxRows = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B2")]
		[Cpp2IlInjected.Address(RVA = "0x82A08B0", Offset = "0x829F2B0", VA = "0x1882A08B0")]
		private HighlightCardDataObject GetFilteredDataObject(HighlightStyle highlightStyle)
		{
			return default(HighlightCardDataObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B3")]
		[Cpp2IlInjected.Address(RVA = "0x829FE40", Offset = "0x829E840", VA = "0x18829FE40")]
		private HighlightCardDataObject ApplyGameConfigOverrides(HighlightCardDataObject cardDataObject)
		{
			return default(HighlightCardDataObject);
		}

		[Cpp2IlInjected.Token(Token = "0x60005B4")]
		[Cpp2IlInjected.Address(RVA = "0x82A0DF0", Offset = "0x829F7F0", VA = "0x1882A0DF0")]
		public CarouselDisplayConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[ViewModel]
	public class CarouselViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		private const int defaultMinItemsToFetch = 20;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		private const int defaultCardLimitPerRow = 5;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public const string HighlightStyleDefault = "highlight_default";

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public const string HighlightStyleScale150 = "highlight_scale_150";

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public const string HighlightStylePortrait = "highlight_portrait";

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public const string HighlightStyleScale75 = "highlight_scale_75";

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public const string HighlightStyleScale100 = "highlight_scale_100";

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public const string HighlightStyleFitPerRow4 = "highlight_fitperrow_4";

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public const string HighlightStyleFitPerRow5 = "highlight_fitperrow_5";

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public const string HighlightStyleFitPerRow6 = "highlight_fitperrow_6";

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		[SerializeField]
		private CarouselType carouselType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		[SerializeField]
		private CarouselDisplayConfig displayConfig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		[SerializeField]
		private DataResolver carouselListResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		[SerializeField]
		private AMLOJEALFHA hidePageButtonsOnThesePlatforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private bool allowHorizontalScroll;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private int rowCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private float? heightOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private float? widthOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private string backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private HighlightStyle highlightStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private Vector2 cardSizeOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private DiscoveryDisplayMetadata displayMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private string sourceLabelText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private int maxRowCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private int maxResultCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		private DataItem<bool> AllowHorizontalScrollDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private DataItem<int> RowCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private DataItem<float?> HeightOverrideDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private DataItem<float?> WidthOverrideDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private DataItem<string> BackgroundColorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private DataItem<HighlightStyle> HighlightStyleDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private DataItem<Vector2> CardSizeOverrideDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000184")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool AllowHorizontalScroll
		{
			[Cpp2IlInjected.Token(Token = "0x60005C5")]
			[Cpp2IlInjected.Address(RVA = "0xF7CCF0", Offset = "0xF7B6F0", VA = "0x180F7CCF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C6")]
			[Cpp2IlInjected.Address(RVA = "0x82A2510", Offset = "0x82A0F10", VA = "0x1882A2510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000185")]
		[BindableData(1, "Number of rows in the carousel", DataPermissions.ReadWrite)]
		public int RowCount
		{
			[Cpp2IlInjected.Token(Token = "0x60005C7")]
			[Cpp2IlInjected.Address(RVA = "0xD8DE70", Offset = "0xD8C870", VA = "0x180D8DE70")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005C8")]
			[Cpp2IlInjected.Address(RVA = "0x82A2570", Offset = "0x82A0F70", VA = "0x1882A2570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000186")]
		[BindableData(2, "The height override value, or null if there isn't one", DataPermissions.ReadWrite)]
		public float? HeightOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x82A25D0", Offset = "0x82A0FD0", VA = "0x1882A25D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x82A2A90", Offset = "0x82A1490", VA = "0x1882A2A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000187")]
		[BindableData(3, "The width override value, or null if there isn't one. Typically used for card width.", DataPermissions.ReadWrite)]
		public float? WidthOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60005CB")]
			[Cpp2IlInjected.Address(RVA = "0x1CD29A0", Offset = "0x1CD13A0", VA = "0x181CD29A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005CC")]
			[Cpp2IlInjected.Address(RVA = "0x82A2B20", Offset = "0x82A1520", VA = "0x1882A2B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000188")]
		[BindableData(4, "Background color of the carousel", DataPermissions.ReadWrite)]
		public string BackgroundColor
		{
			[Cpp2IlInjected.Token(Token = "0x60005CD")]
			[Cpp2IlInjected.Address(RVA = "0xAB7A80", Offset = "0xAB6480", VA = "0x180AB7A80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005CE")]
			[Cpp2IlInjected.Address(RVA = "0x82A2980", Offset = "0x82A1380", VA = "0x1882A2980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000189")]
		[BindableData(5, "Card Highlight Style", DataPermissions.ReadWrite)]
		public HighlightStyle HighlightStyle
		{
			[Cpp2IlInjected.Token(Token = "0x60005CF")]
			[Cpp2IlInjected.Address(RVA = "0xAB7C30", Offset = "0xAB6630", VA = "0x180AB7C30")]
			get
			{
				return default(HighlightStyle);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x82A2480", Offset = "0x82A0E80", VA = "0x1882A2480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018A")]
		[BindableData(6, "The card width and height override value, or null if there isn't one. Used when overriding width alone is insufficient.", DataPermissions.ReadWrite)]
		public Vector2 CardSizeOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x82A24E0", Offset = "0x82A0EE0", VA = "0x1882A24E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D2")]
			[Cpp2IlInjected.Address(RVA = "0x82A2A00", Offset = "0x82A1400", VA = "0x1882A2A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018B")]
		public int NumItemsToFetch
		{
			[Cpp2IlInjected.Token(Token = "0x60005D3")]
			[Cpp2IlInjected.Address(RVA = "0xB4D8F0", Offset = "0xB4C2F0", VA = "0x180B4D8F0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60005D4")]
			[Cpp2IlInjected.Address(RVA = "0xB4D840", Offset = "0xB4C240", VA = "0x180B4D840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018C")]
		public int MaxItemsToDisplay
		{
			[Cpp2IlInjected.Token(Token = "0x60005D5")]
			[Cpp2IlInjected.Address(RVA = "0xB68B50", Offset = "0xB67550", VA = "0x180B68B50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018D")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60005DD")]
			[Cpp2IlInjected.Address(RVA = "0x82A2940", Offset = "0x82A1340", VA = "0x1882A2940", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700018E")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60005DE")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005D6")]
		[Cpp2IlInjected.Address(RVA = "0x82A0E90", Offset = "0x829F890", VA = "0x1882A0E90", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D7")]
		[Cpp2IlInjected.Address(RVA = "0x82A23D0", Offset = "0x82A0DD0", VA = "0x1882A23D0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x82A1110", Offset = "0x829FB10", VA = "0x1882A1110")]
		public void ConfigureCarousel(DiscoveryDisplayMetadata displayMetadata, string sourceLabelText)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x82A0F50", Offset = "0x829F950", VA = "0x1882A0F50")]
		private int CalculateNumItemsToFetch()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x82A1AD0", Offset = "0x82A04D0", VA = "0x1882A1AD0")]
		private HighlightStyle GetHighlightStyle()
		{
			return default(HighlightStyle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x82A2340", Offset = "0x82A0D40", VA = "0x1882A2340")]
		private void OnCarouselListUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x82A1310", Offset = "0x829FD10", VA = "0x1882A1310")]
		private void FinishCarouselInit(int totalNumCards)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x82A1BC0", Offset = "0x82A05C0", VA = "0x1882A1BC0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x82A1950", Offset = "0x82A0350", VA = "0x1882A1950")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x82A2610", Offset = "0x82A1010", VA = "0x1882A2610")]
		public CarouselViewModel()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	public class DiscoveryDisplayMetadata : BaseDiscoveryDisplayMetadata
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public string DisplayTitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public bool supportsDedupe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public int numRows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public string sizePerPlatform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public string backgroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public bool horizontalScrollEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public int itemCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public string cardStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public int minItemsToShowSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public string textColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public bool showNewThisSessionForSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public string sessionSectionIdOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public string descriptionText;

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x82AD390", Offset = "0x82ABD90", VA = "0x1882AD390")]
		public DiscoveryDisplayMetadata()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[ViewModel]
	public class ConsumableListViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		[SerializeField]
		private IRRUIvNextConsumableBridge.ConsumableCategory listType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		[SerializeField]
		private Route shopRoute;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		private IRRUIvNextConsumableBridge consumableBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private IRRUIvNextStoreItemBridge storeBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private DataList<FMBGLPEKILF> consumableList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		private DataItemList ConsumableListDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private DataItemAction OpenShopDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700018F")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<FMBGLPEKILF> ConsumableList
		{
			[Cpp2IlInjected.Token(Token = "0x60005F1")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6550", VA = "0x180AB7B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60005F2")]
			[Cpp2IlInjected.Address(RVA = "0x82A8170", Offset = "0x82A6B70", VA = "0x1882A8170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000190")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60005F9")]
			[Cpp2IlInjected.Address(RVA = "0x82A8130", Offset = "0x82A6B30", VA = "0x1882A8130", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000191")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x82A7B40", Offset = "0x82A6540", VA = "0x1882A7B40")]
		[BindableAction(1, null)]
		public void OpenShop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x82A74E0", Offset = "0x82A5EE0", VA = "0x1882A74E0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x82A7A30", Offset = "0x82A6430", VA = "0x1882A7A30", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x82A7A20", Offset = "0x82A6420", VA = "0x1882A7A20")]
		private void OnActiveConsumableChanged(FMBGLPEKILF _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x82A7A20", Offset = "0x82A6420", VA = "0x1882A7A20")]
		private void OnPurchasedConsumableChanged(FMBGLPEKILF _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F8")]
		[Cpp2IlInjected.Address(RVA = "0x82A7CC0", Offset = "0x82A66C0", VA = "0x1882A7CC0")]
		private void RefreshConsumableList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FB")]
		[Cpp2IlInjected.Address(RVA = "0x82A7820", Offset = "0x82A6220", VA = "0x1882A7820", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FC")]
		[Cpp2IlInjected.Address(RVA = "0x82A7750", Offset = "0x82A6150", VA = "0x1882A7750")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005FD")]
		[Cpp2IlInjected.Address(RVA = "0x82A8000", Offset = "0x82A6A00", VA = "0x1882A8000")]
		public ConsumableListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[ViewModel]
	public class ConsumableViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		private IRRUIvNextConsumableBridge consumableBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		private FMBGLPEKILF consumable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private KAHAAKGFHGH mainImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private int count;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private bool isActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		private DataItem<KAHAAKGFHGH> MainImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private DataItem<int> CountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		private DataItem<bool> IsActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		private DataItemAction UseConsumableDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000192")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x82A9800", Offset = "0x82A8200", VA = "0x1882A9800", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000193")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public KAHAAKGFHGH MainImage
		{
			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x82A9320", Offset = "0x82A7D20", VA = "0x1882A9320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000194")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7D0", Offset = "0xB2E1D0", VA = "0x180B2F7D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x82A9380", Offset = "0x82A7D80", VA = "0x1882A9380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000195")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool IsActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0xF7CCF0", Offset = "0xF7B6F0", VA = "0x180F7CCF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x82A93D0", Offset = "0x82A7DD0", VA = "0x1882A93D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000196")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600060E")]
			[Cpp2IlInjected.Address(RVA = "0x82A97C0", Offset = "0x82A81C0", VA = "0x1882A97C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000197")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600060F")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000607")]
		[Cpp2IlInjected.Address(RVA = "0x82A9430", Offset = "0x82A7E30", VA = "0x1882A9430")]
		[BindableAction(0, null)]
		public void UseConsumable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000608")]
		[Cpp2IlInjected.Address(RVA = "0x82A81E0", Offset = "0x82A6BE0", VA = "0x1882A81E0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000609")]
		[Cpp2IlInjected.Address(RVA = "0x82A8D10", Offset = "0x82A7710", VA = "0x1882A8D10", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060A")]
		[Cpp2IlInjected.Address(RVA = "0x82A8830", Offset = "0x82A7230", VA = "0x1882A8830")]
		private void OnActiveConsumableChanged(FMBGLPEKILF consumable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060B")]
		[Cpp2IlInjected.Address(RVA = "0x82A9240", Offset = "0x82A7C40", VA = "0x1882A9240", Slot = "14")]
		public override void SetBindingData(int sourceId, int itemId, int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060C")]
		[Cpp2IlInjected.Address(RVA = "0x82A8DD0", Offset = "0x82A77D0", VA = "0x1882A8DD0")]
		private void RefreshData(FMBGLPEKILF config)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060D")]
		[Cpp2IlInjected.Address(RVA = "0x82A8850", Offset = "0x82A7250", VA = "0x1882A8850")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x82A8430", Offset = "0x82A6E30", VA = "0x1882A8430", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0x82A8320", Offset = "0x82A6D20", VA = "0x1882A8320")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0x82A9640", Offset = "0x82A8040", VA = "0x1882A9640")]
		public ConsumableViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	public class GlobalDataViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private int localAccountId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private long localRoomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private long localRoomEventId;

		[Cpp2IlInjected.Token(Token = "0x17000198")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public int LocalAccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000619")]
			[Cpp2IlInjected.Address(RVA = "0xACB3E0", Offset = "0xAC9DE0", VA = "0x180ACB3E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600061A")]
			[Cpp2IlInjected.Address(RVA = "0x82ADA00", Offset = "0x82AC400", VA = "0x1882ADA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000199")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public long LocalRoomId
		{
			[Cpp2IlInjected.Token(Token = "0x600061B")]
			[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600061C")]
			[Cpp2IlInjected.Address(RVA = "0x82ADAB0", Offset = "0x82AC4B0", VA = "0x1882ADAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019A")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public long LocalRoomEventId
		{
			[Cpp2IlInjected.Token(Token = "0x600061D")]
			[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x600061E")]
			[Cpp2IlInjected.Address(RVA = "0x82ADA50", Offset = "0x82AC450", VA = "0x1882ADA50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600061F")]
		[Cpp2IlInjected.Address(RVA = "0x82AD870", Offset = "0x82AC270", VA = "0x1882AD870")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000620")]
		[Cpp2IlInjected.Address(RVA = "0x82AD3A0", Offset = "0x82ABDA0", VA = "0x1882AD3A0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000621")]
		[Cpp2IlInjected.Address(RVA = "0x82AD510", Offset = "0x82ABF10", VA = "0x1882AD510")]
		private void OnLocalAccountUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000622")]
		[Cpp2IlInjected.Address(RVA = "0x82AD670", Offset = "0x82AC070", VA = "0x1882AD670")]
		private void OnLocalRoomChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000623")]
		[Cpp2IlInjected.Address(RVA = "0x82AD9E0", Offset = "0x82AC3E0", VA = "0x1882AD9E0")]
		public GlobalDataViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	public class LongPressInteractable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		[SerializeField]
		protected float longPressDuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public EBDGCEEEFPM OnLongClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public EBDGCEEEFPM OnShortClick;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected float pressStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected bool pointerInside;

		[Cpp2IlInjected.Token(Token = "0x6000624")]
		[Cpp2IlInjected.Address(RVA = "0xF2CFB0", Offset = "0xF2B9B0", VA = "0x180F2CFB0", Slot = "4")]
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000625")]
		[Cpp2IlInjected.Address(RVA = "0x82ADB30", Offset = "0x82AC530", VA = "0x1882ADB30", Slot = "5")]
		public void OnPointerExit(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000626")]
		[Cpp2IlInjected.Address(RVA = "0x82ADB10", Offset = "0x82AC510", VA = "0x1882ADB10", Slot = "6")]
		public void OnPointerDown(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000627")]
		[Cpp2IlInjected.Address(RVA = "0x82ADB40", Offset = "0x82AC540", VA = "0x1882ADB40", Slot = "7")]
		public void OnPointerUp(PointerEventData eventData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000628")]
		[Cpp2IlInjected.Address(RVA = "0x82ADBA0", Offset = "0x82AC5A0", VA = "0x1882ADBA0")]
		public LongPressInteractable()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[ViewModel]
	public class CategoriesNestedItem : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		private IMakerPenHUDBridge hudBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		private int absoluteIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		private CategoriesNestedListItem item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		private string text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		private bool isExpanded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private Sprite activeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		private int depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		private DataItem<string> TextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private DataItem<bool> IsExpandedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private DataItem<Sprite> ActiveIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		private DataItem<int> DepthDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		private DataItemAction SelectItemDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700019B")]
		private CategoriesNestedListConfig config
		{
			[Cpp2IlInjected.Token(Token = "0x6000629")]
			[Cpp2IlInjected.Address(RVA = "0x82A3D00", Offset = "0x82A2700", VA = "0x1882A3D00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019C")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x600062A")]
			[Cpp2IlInjected.Address(RVA = "0x82A3C80", Offset = "0x82A2680", VA = "0x1882A3C80", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019D")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x600062D")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B30", Offset = "0xAB6530", VA = "0x180AB7B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600062E")]
			[Cpp2IlInjected.Address(RVA = "0x82A3900", Offset = "0x82A2300", VA = "0x1882A3900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019E")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool IsExpanded
		{
			[Cpp2IlInjected.Token(Token = "0x600062F")]
			[Cpp2IlInjected.Address(RVA = "0xD54F60", Offset = "0xD53960", VA = "0x180D54F60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000630")]
			[Cpp2IlInjected.Address(RVA = "0x82A3970", Offset = "0x82A2370", VA = "0x1882A3970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700019F")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public Sprite ActiveIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000632")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6550", VA = "0x180AB7B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000633")]
			[Cpp2IlInjected.Address(RVA = "0x82A3D50", Offset = "0x82A2750", VA = "0x1882A3D50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A0")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public int Depth
		{
			[Cpp2IlInjected.Token(Token = "0x6000634")]
			[Cpp2IlInjected.Address(RVA = "0xAB7C20", Offset = "0xAB6620", VA = "0x180AB7C20")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000635")]
			[Cpp2IlInjected.Address(RVA = "0x82A39E0", Offset = "0x82A23E0", VA = "0x1882A39E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A1")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000637")]
			[Cpp2IlInjected.Address(RVA = "0x82A3C40", Offset = "0x82A2640", VA = "0x1882A3C40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A2")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000638")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600062B")]
		[Cpp2IlInjected.Address(RVA = "0x82A2BB0", Offset = "0x82A15B0", VA = "0x1882A2BB0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600062C")]
		[Cpp2IlInjected.Address(RVA = "0x82A35B0", Offset = "0x82A1FB0", VA = "0x1882A35B0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000631")]
		[Cpp2IlInjected.Address(RVA = "0x82A35E0", Offset = "0x82A1FE0", VA = "0x1882A35E0")]
		[BindableAction(2, null)]
		public void SelectItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000636")]
		[Cpp2IlInjected.Address(RVA = "0x82A3240", Offset = "0x82A1C40", VA = "0x1882A3240")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000639")]
		[Cpp2IlInjected.Address(RVA = "0x82A2D40", Offset = "0x82A1740", VA = "0x1882A2D40", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063A")]
		[Cpp2IlInjected.Address(RVA = "0x82A2C00", Offset = "0x82A1600", VA = "0x1882A2C00")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x82A3A40", Offset = "0x82A2440", VA = "0x1882A3A40")]
		public CategoriesNestedItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[ViewModel]
	public class CategoriesNestedList : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		private IMakerPenHUDBridge hudBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private DataList<int> activeIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		private DataItemList ActiveIndicesDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001A3")]
		private CategoriesNestedListConfig config
		{
			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0x82A5CD0", Offset = "0x82A46D0", VA = "0x1882A5CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A4")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<int> ActiveIndices
		{
			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000646")]
			[Cpp2IlInjected.Address(RVA = "0x82A5D20", Offset = "0x82A4720", VA = "0x1882A5D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A5")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600064A")]
			[Cpp2IlInjected.Address(RVA = "0x82A5CA0", Offset = "0x82A46A0", VA = "0x1882A5CA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A6")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600064B")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0x82A5320", Offset = "0x82A3D20", VA = "0x1882A5320", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0x82A5800", Offset = "0x82A4200", VA = "0x1882A5800", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0x82A5A20", Offset = "0x82A4420", VA = "0x1882A5A20")]
		private void OnIndexStateChanged(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0x82A56B0", Offset = "0x82A40B0", VA = "0x1882A56B0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0x82A5600", Offset = "0x82A4000", VA = "0x1882A5600")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0x82A5BC0", Offset = "0x82A45C0", VA = "0x1882A5BC0")]
		public CategoriesNestedList()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[ViewModel]
	public class ColorPickerCardViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		private ShapeColorInfo shapeColorInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		private string colorName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		private bool isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		private DataItem<int> IndexDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		private DataItem<string> ColorNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private DataItem<Color> ColorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		private DataItem<bool> IsSelectedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		private DataItemAction SelectDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001A7")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000651")]
			[Cpp2IlInjected.Address(RVA = "0x82A6B90", Offset = "0x82A5590", VA = "0x1882A6B90", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A8")]
		[BindableData(1, "Which slot in the color picker this represents", DataPermissions.ReadOnly)]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000652")]
			[Cpp2IlInjected.Address(RVA = "0xAD4A70", Offset = "0xAD3470", VA = "0x180AD4A70")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000653")]
			[Cpp2IlInjected.Address(RVA = "0x82A6D40", Offset = "0x82A5740", VA = "0x1882A6D40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001A9")]
		[BindableData(2, "Color Name", DataPermissions.ReadOnly)]
		public string ColorName
		{
			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B30", Offset = "0xAB6530", VA = "0x180AB7B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0x82A6C10", Offset = "0x82A5610", VA = "0x1882A6C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AA")]
		[BindableData(3, "Color", DataPermissions.ReadOnly)]
		public Color Color
		{
			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0x216F720", Offset = "0x216E120", VA = "0x18216F720")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0x82A6C80", Offset = "0x82A5680", VA = "0x1882A6C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AB")]
		[BindableData(5, "IsSelected", DataPermissions.ReadOnly)]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6000658")]
			[Cpp2IlInjected.Address(RVA = "0xADD9C0", Offset = "0xADC3C0", VA = "0x180ADD9C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000659")]
			[Cpp2IlInjected.Address(RVA = "0x82A6D90", Offset = "0x82A5790", VA = "0x1882A6D90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AC")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000661")]
			[Cpp2IlInjected.Address(RVA = "0x82A6B50", Offset = "0x82A5550", VA = "0x1882A6B50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AD")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000662")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600065A")]
		[Cpp2IlInjected.Address(RVA = "0x82A6610", Offset = "0x82A5010", VA = "0x1882A6610")]
		[BindableAction(4, "Selects Color")]
		public void Select()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065B")]
		[Cpp2IlInjected.Address(RVA = "0x82A6720", Offset = "0x82A5120", VA = "0x1882A6720")]
		private void SetData(ShapeColorInfo colorInfo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065C")]
		[Cpp2IlInjected.Address(RVA = "0x82A6840", Offset = "0x82A5240", VA = "0x1882A6840")]
		private void UpdateSelectionState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065D")]
		[Cpp2IlInjected.Address(RVA = "0x82A6390", Offset = "0x82A4D90", VA = "0x1882A6390")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0x82A5D80", Offset = "0x82A4780", VA = "0x1882A5D80", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0x82A6530", Offset = "0x82A4F30", VA = "0x1882A6530", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0x82A6380", Offset = "0x82A4D80", VA = "0x1882A6380")]
		private void OnColorPickerCardSelected(int selectedIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0x82A5FA0", Offset = "0x82A49A0", VA = "0x1882A5FA0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0x82A5E60", Offset = "0x82A4860", VA = "0x1882A5E60")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0x82A6980", Offset = "0x82A5380", VA = "0x1882A6980")]
		public ColorPickerCardViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[ViewModel]
	public class ColorPickerListViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		[CompilerGenerated]
		private sealed class <SelectFirstItem>d__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400045F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public ColorPickerListViewModel <>4__this;

			[Cpp2IlInjected.Token(Token = "0x170001B1")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600067A")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170001B2")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600067C")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000677")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public <SelectFirstItem>d__10(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000678")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000679")]
			[Cpp2IlInjected.Address(RVA = "0x82BB550", Offset = "0x82B9F50", VA = "0x1882BB550", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600067B")]
			[Cpp2IlInjected.Address(RVA = "0x82BB7D0", Offset = "0x82BA1D0", VA = "0x1882BB7D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		[SerializeField]
		private InfiniteListViewControllerBase listController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private List<ShapeColorInfo> allColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private Coroutine selectFirstItemCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private DataList<ShapeColorInfo> colors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private DataItemList ColorsDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001AE")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<ShapeColorInfo> Colors
		{
			[Cpp2IlInjected.Token(Token = "0x600066A")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B30", Offset = "0xAB6530", VA = "0x180AB7B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600066B")]
			[Cpp2IlInjected.Address(RVA = "0x82A7480", Offset = "0x82A5E80", VA = "0x1882A7480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001AF")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000670")]
			[Cpp2IlInjected.Address(RVA = "0x82A7440", Offset = "0x82A5E40", VA = "0x1882A7440", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B0")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000671")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x82A6DF0", Offset = "0x82A57F0", VA = "0x1882A6DF0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066D")]
		[Cpp2IlInjected.Address(RVA = "0x82A7110", Offset = "0x82A5B10", VA = "0x1882A7110")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066E")]
		[Cpp2IlInjected.Address(RVA = "0x82A7150", Offset = "0x82A5B50", VA = "0x1882A7150")]
		private void RefreshList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066F")]
		[Cpp2IlInjected.Address(RVA = "0x82A7210", Offset = "0x82A5C10", VA = "0x1882A7210")]
		[IteratorStateMachine(typeof(<SelectFirstItem>d__10))]
		private IEnumerator SelectFirstItem()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000672")]
		[Cpp2IlInjected.Address(RVA = "0x82A6FC0", Offset = "0x82A59C0", VA = "0x1882A6FC0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x82A6F10", Offset = "0x82A5910", VA = "0x1882A6F10")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x82A7360", Offset = "0x82A5D60", VA = "0x1882A7360")]
		public ColorPickerListViewModel()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	public class CategoriesNestedListItem : ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public string Text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public bool IsExpanded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public Sprite ExpandedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public Sprite CollapsedIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public CategoriesFilter Filter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		[Header("All children of the same parent should have both icons set, or none")]
		public List<CategoriesNestedListItem> Children;

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0x82A4FC0", Offset = "0x82A39C0", VA = "0x1882A4FC0", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x82A5270", Offset = "0x82A3C70", VA = "0x1882A5270")]
		public CategoriesNestedListItem()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	public struct CategoriesFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public CategoriesFilterType filterType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		[Tooltip("Metadata for filterType = PaletteSearchFilter")]
		public string paletteSearchFilter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		[Tooltip("Metadata for paletteSortOption = SortOption")]
		public MJCLEJBAMDB paletteSortOption;
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	public enum CategoriesFilterType
	{
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		PaletteSearchFilter,
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		Favorites,
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		RoomInventions
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[CreateAssetMenu(fileName = "CategoriesNestedListConfig", menuName = "RRUI/MakerPenHUD/Nested List/Categories Nested List Config")]
	public class CategoriesNestedListConfig : ScriptableObject, NMPPICCHBFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		[SerializeField]
		private List<CategoriesNestedListItem> nestedListItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private List<CategoriesNestedListItem> clonedNestedListItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private List<int> activeIndices;

		[Cpp2IlInjected.Token(Token = "0x170001B3")]
		public List<CategoriesNestedListItem> ListItems
		{
			[Cpp2IlInjected.Token(Token = "0x600067F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000680")]
			[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B4")]
		public AHDLCNFLGGK<int> OnIndexExpanded
		{
			[Cpp2IlInjected.Token(Token = "0x6000681")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B5")]
		public AHDLCNFLGGK<int> OnIndexCollapsed
		{
			[Cpp2IlInjected.Token(Token = "0x6000683")]
			[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000684")]
			[Cpp2IlInjected.Address(RVA = "0xAB5CB0", Offset = "0xAB46B0", VA = "0x180AB5CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B6")]
		public AHDLCNFLGGK<int> OnIndexSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6000685")]
			[Cpp2IlInjected.Address(RVA = "0xAB5A70", Offset = "0xAB4470", VA = "0x180AB5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000686")]
			[Cpp2IlInjected.Address(RVA = "0xAB5A60", Offset = "0xAB4460", VA = "0x180AB5A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000687")]
		[Cpp2IlInjected.Address(RVA = "0x82A3FE0", Offset = "0x82A29E0", VA = "0x1882A3FE0", Slot = "6")]
		public List<int> GetActiveIndices()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x82A49A0", Offset = "0x82A33A0", VA = "0x1882A49A0")]
		private void SetActiveIndices()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0x82A4030", Offset = "0x82A2A30", VA = "0x1882A4030", Slot = "7")]
		public int GetDepth(int idx)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0x82A4350", Offset = "0x82A2D50", VA = "0x1882A4350", Slot = "8")]
		public bool IsChild(int parentIdx, int childIdx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0x82A4400", Offset = "0x82A2E00", VA = "0x1882A4400", Slot = "9")]
		public bool IsExpanded(int idx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x82A4460", Offset = "0x82A2E60", VA = "0x1882A4460", Slot = "10")]
		public bool IsParent(int childIdx, int parentIdx)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600068D")]
		[Cpp2IlInjected.Address(RVA = "0x82A48E0", Offset = "0x82A32E0", VA = "0x1882A48E0")]
		public void Select(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068E")]
		[Cpp2IlInjected.Address(RVA = "0x82A3EF0", Offset = "0x82A28F0", VA = "0x1882A3EF0")]
		public void Expand(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068F")]
		[Cpp2IlInjected.Address(RVA = "0x82A3E00", Offset = "0x82A2800", VA = "0x1882A3E00")]
		public void Collapse(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000690")]
		[Cpp2IlInjected.Address(RVA = "0x82A4560", Offset = "0x82A2F60", VA = "0x1882A4560")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000691")]
		[Cpp2IlInjected.Address(RVA = "0x82A4120", Offset = "0x82A2B20", VA = "0x1882A4120")]
		private bool IconsSetConsistently(List<CategoriesNestedListItem> items)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000692")]
		[Cpp2IlInjected.Address(RVA = "0x82A4510", Offset = "0x82A2F10", VA = "0x1882A4510")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x82A4EC0", Offset = "0x82A38C0", VA = "0x1882A4EC0")]
		public CategoriesNestedListConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[ViewModel]
	public class CreateModeHotbarListViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		[SerializeField]
		private InfiniteListViewControllerBase listViewController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		private HCPPOIKBIDE manager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		private DataList<HJELELCBECL> hotbarEntries;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private DataItemList HotbarEntriesDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001B7")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<HJELELCBECL> HotbarEntries
		{
			[Cpp2IlInjected.Token(Token = "0x6000696")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B30", Offset = "0xAB6530", VA = "0x180AB7B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000697")]
			[Cpp2IlInjected.Address(RVA = "0x82AAB30", Offset = "0x82A9530", VA = "0x1882AAB30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B8")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60006A0")]
			[Cpp2IlInjected.Address(RVA = "0x82AAAF0", Offset = "0x82A94F0", VA = "0x1882AAAF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001B9")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60006A1")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000698")]
		[Cpp2IlInjected.Address(RVA = "0x82A9880", Offset = "0x82A8280", VA = "0x1882A9880", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000699")]
		[Cpp2IlInjected.Address(RVA = "0x82A9D60", Offset = "0x82A8760", VA = "0x1882A9D60", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069A")]
		[Cpp2IlInjected.Address(RVA = "0x82AA0E0", Offset = "0x82A8AE0", VA = "0x1882AA0E0")]
		private void OnHotbarSlotSelected(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069B")]
		[Cpp2IlInjected.Address(RVA = "0x82AA000", Offset = "0x82A8A00", VA = "0x1882AA000")]
		private void OnHotbarSelectionCleared()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069C")]
		[Cpp2IlInjected.Address(RVA = "0x82AA350", Offset = "0x82A8D50", VA = "0x1882AA350")]
		private void OnSlotsChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069D")]
		[Cpp2IlInjected.Address(RVA = "0x82AA2D0", Offset = "0x82A8CD0", VA = "0x1882AA2D0")]
		private void OnPaletteToggled(bool open)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069E")]
		[Cpp2IlInjected.Address(RVA = "0x82AA1D0", Offset = "0x82A8BD0", VA = "0x1882AA1D0")]
		private void OnObjectCreated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600069F")]
		[Cpp2IlInjected.Address(RVA = "0x82AA6F0", Offset = "0x82A90F0", VA = "0x1882AA6F0")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A2")]
		[Cpp2IlInjected.Address(RVA = "0x82A9C10", Offset = "0x82A8610", VA = "0x1882A9C10", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A3")]
		[Cpp2IlInjected.Address(RVA = "0x82A9B60", Offset = "0x82A8560", VA = "0x1882A9B60")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006A4")]
		[Cpp2IlInjected.Address(RVA = "0x82AAA10", Offset = "0x82A9410", VA = "0x1882AAA10")]
		public CreateModeHotbarListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[ViewModel]
	public class CreateModeHotbarSlotViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000C2")]
		[CompilerGenerated]
		private struct <RefreshIcon>d__47 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public HJELELCBECL entry;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public CreateModeHotbarSlotViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			private TaskAwaiter<Texture2D> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60006D6")]
			[Cpp2IlInjected.Address(RVA = "0x82BB250", Offset = "0x82B9C50", VA = "0x1882BB250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60006D7")]
			[Cpp2IlInjected.Address(RVA = "0x82BB4F0", Offset = "0x82B9EF0", VA = "0x1882BB4F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private HCPPOIKBIDE manager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private HJELELCBECL hotbarEntry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private Texture image;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private bool isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x89")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private bool isImageSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8A")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private bool isPaletteOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8B")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private bool? isSelectedAndPaletteNotOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private DataItem<int> IndexDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private DataItem<Texture> ImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private DataItem<bool> IsSelectedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		private DataItem<bool> IsImageSetDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		private DataItem<bool> IsPaletteOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		private DataItem<bool> IsSelectedAndPaletteNotOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		private DataItem<bool> CanSelectDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		private DataItem<string> ImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private DataItem<bool> CanShowEmptyPlusIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		private DataItem<bool> CanShowRecNetImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		private DataItemAction SelectDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private DataItemAction ClickDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001BA")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60006A7")]
			[Cpp2IlInjected.Address(RVA = "0x82ACEE0", Offset = "0x82AB8E0", VA = "0x1882ACEE0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BB")]
		[BindableData(1, "Which slot in the hotbar this represents", DataPermissions.ReadOnly)]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x60006A8")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7D0", Offset = "0xB2E1D0", VA = "0x180B2F7D0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60006A9")]
			[Cpp2IlInjected.Address(RVA = "0x82AD100", Offset = "0x82ABB00", VA = "0x1882AD100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BC")]
		[BindableData(2, "The image that should be displayed for this hotbar item", DataPermissions.ReadOnly)]
		public Texture Image
		{
			[Cpp2IlInjected.Token(Token = "0x60006AA")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B40", Offset = "0xAB6540", VA = "0x180AB7B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006AB")]
			[Cpp2IlInjected.Address(RVA = "0x82AD020", Offset = "0x82ABA20", VA = "0x1882AD020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BD")]
		[BindableData(3, "Whether or not this is selected", DataPermissions.ReadOnly)]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x60006AC")]
			[Cpp2IlInjected.Address(RVA = "0xB341E0", Offset = "0xB32BE0", VA = "0x180B341E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006AD")]
			[Cpp2IlInjected.Address(RVA = "0x82AD2C0", Offset = "0x82ABCC0", VA = "0x1882AD2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BE")]
		[BindableData(5, "Whether or not the Image property is set", DataPermissions.ReadOnly)]
		public bool IsImageSet
		{
			[Cpp2IlInjected.Token(Token = "0x60006AE")]
			[Cpp2IlInjected.Address(RVA = "0xB341D0", Offset = "0xB32BD0", VA = "0x180B341D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006AF")]
			[Cpp2IlInjected.Address(RVA = "0x82AD150", Offset = "0x82ABB50", VA = "0x1882AD150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001BF")]
		[BindableData(6, "Whether or not the palette is open", DataPermissions.ReadOnly)]
		public bool IsPaletteOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60006B0")]
			[Cpp2IlInjected.Address(RVA = "0xB34170", Offset = "0xB32B70", VA = "0x180B34170")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006B1")]
			[Cpp2IlInjected.Address(RVA = "0x82ABEE0", Offset = "0x82AA8E0", VA = "0x1882ABEE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C0")]
		[BindableData(7, "Whether or not this is selected", DataPermissions.ReadOnly)]
		public bool IsSelectedAndPaletteNotOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60006B2")]
			[Cpp2IlInjected.Address(RVA = "0x82AC6A0", Offset = "0x82AB0A0", VA = "0x1882AC6A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006B3")]
			[Cpp2IlInjected.Address(RVA = "0x82AD210", Offset = "0x82ABC10", VA = "0x1882AD210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C1")]
		[BindableData(8, "Whether or not we can select this item", DataPermissions.ReadOnly)]
		public bool CanSelect
		{
			[Cpp2IlInjected.Token(Token = "0x60006B4")]
			[Cpp2IlInjected.Address(RVA = "0x727C920", Offset = "0x727B320", VA = "0x18727C920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C2")]
		[BindableData(9, null, DataPermissions.ReadWrite)]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60006B5")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7C0", Offset = "0xB2E1C0", VA = "0x180B2F7C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006B6")]
			[Cpp2IlInjected.Address(RVA = "0x82ACF60", Offset = "0x82AB960", VA = "0x1882ACF60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C3")]
		[BindableData(11, "Whether or not we should show the Plus Icon on empty slot", DataPermissions.ReadOnly)]
		public bool CanShowEmptyPlusIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60006B7")]
			[Cpp2IlInjected.Address(RVA = "0x82AC750", Offset = "0x82AB150", VA = "0x1882AC750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C4")]
		[BindableData(12, "Whether or not we should show the recnet Image for invention's icon", DataPermissions.ReadOnly)]
		public bool CanShowRecNetImage
		{
			[Cpp2IlInjected.Token(Token = "0x60006B8")]
			[Cpp2IlInjected.Address(RVA = "0x82AC680", Offset = "0x82AB080", VA = "0x1882AC680")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C5")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0x82ACEA0", Offset = "0x82AB8A0", VA = "0x1882ACEA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C6")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(RVA = "0x82AC090", Offset = "0x82AAA90", VA = "0x1882AC090")]
		[BindableAction(4, "Selects this hotbar item")]
		public void Select()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(RVA = "0x82AAD80", Offset = "0x82A9780", VA = "0x1882AAD80")]
		[BindableAction(10, "Invoked when the hotbar slot is clicked")]
		public void Click()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(RVA = "0x82AAB90", Offset = "0x82A9590", VA = "0x1882AAB90", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(RVA = "0x82ABCF0", Offset = "0x82AA6F0", VA = "0x1882ABCF0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BD")]
		[Cpp2IlInjected.Address(RVA = "0x82ABED0", Offset = "0x82AA8D0", VA = "0x1882ABED0")]
		private void OnHotbarSlotSelected(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BE")]
		[Cpp2IlInjected.Address(RVA = "0x82ABEC0", Offset = "0x82AA8C0", VA = "0x1882ABEC0")]
		private void OnHotbarSelectionCleared()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006BF")]
		[Cpp2IlInjected.Address(RVA = "0x82ABEE0", Offset = "0x82AA8E0", VA = "0x1882ABEE0")]
		private void OnPaletteToggled(bool isOpen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C0")]
		[Cpp2IlInjected.Address(RVA = "0x82AC140", Offset = "0x82AAB40", VA = "0x1882AC140")]
		private void SetData(HJELELCBECL entry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C1")]
		[Cpp2IlInjected.Address(RVA = "0x82ABFA0", Offset = "0x82AA9A0", VA = "0x1882ABFA0")]
		[AsyncStateMachine(typeof(<RefreshIcon>d__47))]
		private Task RefreshIcon(HJELELCBECL entry)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006C2")]
		[Cpp2IlInjected.Address(RVA = "0x82ABBE0", Offset = "0x82AA5E0", VA = "0x1882ABBE0")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C3")]
		[Cpp2IlInjected.Address(RVA = "0x82AC400", Offset = "0x82AAE00", VA = "0x1882AC400")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C4")]
		[Cpp2IlInjected.Address(RVA = "0x82AC770", Offset = "0x82AB170", VA = "0x1882AC770")]
		private void UpdateData(HJELELCBECL hotbarEntry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C5")]
		[Cpp2IlInjected.Address(RVA = "0x82AB9E0", Offset = "0x82AA3E0", VA = "0x1882AB9E0")]
		private void LogClick(bool forRemoval = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0x82AB0E0", Offset = "0x82A9AE0", VA = "0x1882AB0E0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0x82AAEB0", Offset = "0x82A98B0", VA = "0x1882AAEB0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0x82ACB00", Offset = "0x82AB500", VA = "0x1882ACB00")]
		public CreateModeHotbarSlotViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[ViewModel]
	public class MakerPenHUDConfigureViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		private HPELOPLNJCC _configurable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private bool _hasConfigurable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private string _title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private string _subtitle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		[SerializeField]
		private bool isAdvancedMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private bool _isAdvancedMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private DataList<ILNCJONKHIP> _dynamicUIElements;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private bool _isDynamicUIElementsEmpty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private ToastListModel _toastListModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		private DialogListModel _dialogListModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private IMakerPenHUDBridge _makerPenHUDBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		private DataItem<HPELOPLNJCC> ConfigurableDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		private DataItem<bool> HasConfigurableDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private DataItem<string> TitleDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private DataItem<string> SubtitleDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private DataItem<bool> IsAdvancedModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		private DataItem<bool> IsDynamicUIElementsEmptyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		private DataItemList DynamicUIElementsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		private DataItemAction ResetConfigurableDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		private DataItemAction CollapseAllFoldoutsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		private DataItemAction ExpandAllFoldoutsDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001C7")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public HPELOPLNJCC Configurable
		{
			[Cpp2IlInjected.Token(Token = "0x60006D8")]
			[Cpp2IlInjected.Address(RVA = "0xAB4850", Offset = "0xAB3250", VA = "0x180AB4850")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006D9")]
			[Cpp2IlInjected.Address(RVA = "0x82B01A0", Offset = "0x82AEBA0", VA = "0x1882B01A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C8")]
		[BindableData(1, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool HasConfigurable
		{
			[Cpp2IlInjected.Token(Token = "0x60006DC")]
			[Cpp2IlInjected.Address(RVA = "0xB2F830", Offset = "0xB2E230", VA = "0x180B2F830")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006DD")]
			[Cpp2IlInjected.Address(RVA = "0x82AF6C0", Offset = "0x82AE0C0", VA = "0x1882AF6C0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001C9")]
		[BindableData(2, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x60006DE")]
			[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006DF")]
			[Cpp2IlInjected.Address(RVA = "0x82AF720", Offset = "0x82AE120", VA = "0x1882AF720")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CA")]
		[BindableData(3, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public string Subtitle
		{
			[Cpp2IlInjected.Token(Token = "0x60006E0")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B30", Offset = "0xAB6530", VA = "0x180AB7B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006E1")]
			[Cpp2IlInjected.Address(RVA = "0x82AF790", Offset = "0x82AE190", VA = "0x1882AF790")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CB")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool IsAdvancedMode
		{
			[Cpp2IlInjected.Token(Token = "0x60006E2")]
			[Cpp2IlInjected.Address(RVA = "0xFD8E80", Offset = "0xFD7880", VA = "0x180FD8E80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006E3")]
			[Cpp2IlInjected.Address(RVA = "0x82AF800", Offset = "0x82AE200", VA = "0x1882AF800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CC")]
		[BindableData(5, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public DataList<ILNCJONKHIP> DynamicUIElements
		{
			[Cpp2IlInjected.Token(Token = "0x60006E4")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6550", VA = "0x180AB7B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60006E5")]
			[Cpp2IlInjected.Address(RVA = "0x82B0250", Offset = "0x82AEC50", VA = "0x1882B0250")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CD")]
		[BindableData(6, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool IsDynamicUIElementsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0xADD9C0", Offset = "0xADC3C0", VA = "0x180ADD9C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60006E7")]
			[Cpp2IlInjected.Address(RVA = "0x82AF590", Offset = "0x82ADF90", VA = "0x1882AF590")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CE")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60006F8")]
			[Cpp2IlInjected.Address(RVA = "0x82B0160", Offset = "0x82AEB60", VA = "0x1882B0160", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001CF")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60006F9")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006DA")]
		[Cpp2IlInjected.Address(RVA = "0x82AF310", Offset = "0x82ADD10", VA = "0x1882AF310")]
		private void Register(HPELOPLNJCC configurable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006DB")]
		[Cpp2IlInjected.Address(RVA = "0x82AF870", Offset = "0x82AE270", VA = "0x1882AF870")]
		private void Unregister(HPELOPLNJCC configurable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x82ADC60", Offset = "0x82AC660", VA = "0x1882ADC60", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x82AEEE0", Offset = "0x82AD8E0", VA = "0x1882AEEE0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EA")]
		[Cpp2IlInjected.Address(RVA = "0x82AF090", Offset = "0x82ADA90", VA = "0x1882AF090")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x82AF040", Offset = "0x82ADA40", VA = "0x1882AF040")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x82AF160", Offset = "0x82ADB60", VA = "0x1882AF160")]
		private void OnMakerPenConfigMenuDataChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006ED")]
		[Cpp2IlInjected.Address(RVA = "0x82AF1F0", Offset = "0x82ADBF0", VA = "0x1882AF1F0")]
		private void OnRRUIPageContainerEnabledChanged(bool isEnabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EE")]
		[Cpp2IlInjected.Address(RVA = "0x82AF1C0", Offset = "0x82ADBC0", VA = "0x1882AF1C0")]
		private void OnObjectSettingsToast(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006EF")]
		[Cpp2IlInjected.Address(RVA = "0x82AF200", Offset = "0x82ADC00", VA = "0x1882AF200")]
		private void OnShowDialog(MBDBPDMIJMG dialogType, FKGFKBCFFBN dialogData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F0")]
		[Cpp2IlInjected.Address(RVA = "0x82AF050", Offset = "0x82ADA50", VA = "0x1882AF050")]
		private void OnDismissAllDialogs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F1")]
		[Cpp2IlInjected.Address(RVA = "0x82AF080", Offset = "0x82ADA80", VA = "0x1882AF080")]
		private void OnDynamicUIElementsChanged(HPELOPLNJCC configurable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F2")]
		[Cpp2IlInjected.Address(RVA = "0x82AF0F0", Offset = "0x82ADAF0", VA = "0x1882AF0F0")]
		private void OnForceRefreshConfigUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F3")]
		[Cpp2IlInjected.Address(RVA = "0x82AFAB0", Offset = "0x82AE4B0", VA = "0x1882AFAB0")]
		private void UpdateData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F4")]
		[Cpp2IlInjected.Address(RVA = "0x82ADEB0", Offset = "0x82AC8B0", VA = "0x1882ADEB0")]
		private void ClearData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F5")]
		[Cpp2IlInjected.Address(RVA = "0x82AF540", Offset = "0x82ADF40", VA = "0x1882AF540")]
		[BindableAction(100, null)]
		public void ResetConfigurable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F6")]
		[Cpp2IlInjected.Address(RVA = "0x82ADFF0", Offset = "0x82AC9F0", VA = "0x1882ADFF0")]
		[BindableAction(101, null)]
		public void CollapseAllFoldouts()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006F7")]
		[Cpp2IlInjected.Address(RVA = "0x82AE210", Offset = "0x82ACC10", VA = "0x1882AE210")]
		[BindableAction(102, null)]
		public void ExpandAllFoldouts()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FA")]
		[Cpp2IlInjected.Address(RVA = "0x82AE620", Offset = "0x82AD020", VA = "0x1882AE620", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0x82AE430", Offset = "0x82ACE30", VA = "0x1882AE430")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0x82AFE10", Offset = "0x82AE810", VA = "0x1882AFE10")]
		public MakerPenHUDConfigureViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[ViewModel]
	public class MakerPenHUDCreateToolbarViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		[SerializeField]
		private FocusableUI toolbarFocusable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private bool leftModifierPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x69")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private bool rightModifierPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6A")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private bool rightModifierHeld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private IRRUIvNextBridge rruiBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private HCPPOIKBIDE manager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		private bool hasFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		private float holdInputProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		private bool showHoldIndicator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x91")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		private bool paletteButtonSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x92")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		private bool paletteButtonSelectedOrPaletteOpen;

		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		private const string openPaletteButtonName = "Open Palette";

		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private const string closePaletteButtonName = "Close Palette";

		[Cpp2IlInjected.FieldOffset(Offset = "0x93")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		private bool paletteIsOpen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		private string toolDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private DataItem<bool> HasFocusDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private DataItem<float> HoldInputProgressDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private DataItem<bool> ShowHoldIndicatorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private DataItem<bool> PaletteButtonSelectedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private DataItem<bool> PaletteButtonSelectedOrPaletteOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private DataItem<bool> PaletteButtonSelectedAndPaletteClosedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private DataItem<bool> PaletteIsOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private DataItem<bool> CreateModeRecolorIsAvailableDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private DataItem<string> ToolDescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private DataItemAction GoToPaletteModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private DataItemAction ClickPaletteButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private DataItemAction ClickRecolorButtonDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001D0")]
		private bool shouldFocus
		{
			[Cpp2IlInjected.Token(Token = "0x600070B")]
			[Cpp2IlInjected.Address(RVA = "0x82B2F30", Offset = "0x82B1930", VA = "0x1882B2F30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D1")]
		[BindableData(200, null, DataPermissions.ReadWrite)]
		public bool HasFocus
		{
			[Cpp2IlInjected.Token(Token = "0x600070C")]
			[Cpp2IlInjected.Address(RVA = "0xB341E0", Offset = "0xB32BE0", VA = "0x180B341E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600070D")]
			[Cpp2IlInjected.Address(RVA = "0x82B27C0", Offset = "0x82B11C0", VA = "0x1882B27C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D2")]
		[BindableData(201, null, DataPermissions.ReadWrite)]
		public float HoldInputProgress
		{
			[Cpp2IlInjected.Token(Token = "0x600070E")]
			[Cpp2IlInjected.Address(RVA = "0x12C4210", Offset = "0x12C2C10", VA = "0x1812C4210")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600070F")]
			[Cpp2IlInjected.Address(RVA = "0x82B2820", Offset = "0x82B1220", VA = "0x1882B2820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D3")]
		[BindableData(202, null, DataPermissions.ReadWrite)]
		public bool ShowHoldIndicator
		{
			[Cpp2IlInjected.Token(Token = "0x6000710")]
			[Cpp2IlInjected.Address(RVA = "0xADD9C0", Offset = "0xADC3C0", VA = "0x180ADD9C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000711")]
			[Cpp2IlInjected.Address(RVA = "0x82B2890", Offset = "0x82B1290", VA = "0x1882B2890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D4")]
		[BindableData(203, null, DataPermissions.ReadWrite)]
		public bool PaletteButtonSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6000712")]
			[Cpp2IlInjected.Address(RVA = "0x10F1C70", Offset = "0x10F0670", VA = "0x1810F1C70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000713")]
			[Cpp2IlInjected.Address(RVA = "0x82B28F0", Offset = "0x82B12F0", VA = "0x1882B28F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D5")]
		[BindableData(204, null, DataPermissions.ReadWrite)]
		public bool PaletteButtonSelectedOrPaletteOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000714")]
			[Cpp2IlInjected.Address(RVA = "0x1899370", Offset = "0x1897D70", VA = "0x181899370")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000715")]
			[Cpp2IlInjected.Address(RVA = "0x82B29C0", Offset = "0x82B13C0", VA = "0x1882B29C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D6")]
		[BindableData(205, "True if the palette button is selected and the palette is closed", DataPermissions.ReadOnly)]
		public bool PaletteButtonSelectedAndPaletteClosed
		{
			[Cpp2IlInjected.Token(Token = "0x6000716")]
			[Cpp2IlInjected.Address(RVA = "0x82B27A0", Offset = "0x82B11A0", VA = "0x1882B27A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D7")]
		[BindableData(3, "True if the palette is currently open", DataPermissions.ReadOnly)]
		public bool PaletteIsOpen
		{
			[Cpp2IlInjected.Token(Token = "0x6000721")]
			[Cpp2IlInjected.Address(RVA = "0x1899380", Offset = "0x1897D80", VA = "0x181899380")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000722")]
			[Cpp2IlInjected.Address(RVA = "0x82B2FE0", Offset = "0x82B19E0", VA = "0x1882B2FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D8")]
		[BindableData(4, "Recolor in create mode is not yet supported", DataPermissions.ReadOnly)]
		public bool CreateModeRecolorIsAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x6000723")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001D9")]
		[BindableData(5, "ToolDescription", DataPermissions.ReadOnly)]
		public string ToolDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6000724")]
			[Cpp2IlInjected.Address(RVA = "0xAB7A80", Offset = "0xAB6480", VA = "0x180AB7A80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000725")]
			[Cpp2IlInjected.Address(RVA = "0x82B30B0", Offset = "0x82B1AB0", VA = "0x1882B30B0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DA")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0x82B2EF0", Offset = "0x82B18F0", VA = "0x1882B2EF0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DB")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600072B")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0x82B0DA0", Offset = "0x82AF7A0", VA = "0x1882B0DA0")]
		[BindableAction(6, null)]
		public void GoToPaletteMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0x82B1DA0", Offset = "0x82B07A0", VA = "0x1882B1DA0")]
		private void OnLeftNavInputStateChanged(MakerPenHUDNavigationInputState.NavInputState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0x82B21B0", Offset = "0x82B0BB0", VA = "0x1882B21B0")]
		private void OnRightNavInputStateChanged(MakerPenHUDNavigationInputState.NavInputState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0x82B2A80", Offset = "0x82B1480", VA = "0x1882B2A80")]
		private void UpdateInputState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0x82B02C0", Offset = "0x82AECC0", VA = "0x1882B02C0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0x82B1930", Offset = "0x82B0330", VA = "0x1882B1930", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0x82B09A0", Offset = "0x82AF3A0", VA = "0x1882B09A0")]
		[BindableAction(1, "Invoked when the palette button is clicked")]
		public void ClickPaletteButton()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0x82B1FC0", Offset = "0x82B09C0", VA = "0x1882B1FC0")]
		private void OnPaletteToggled(bool open)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0x82B18D0", Offset = "0x82B02D0", VA = "0x1882B18D0")]
		private void OnCursorActiveChanged(bool active)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		[BindableAction(2, "Invoked when the recolor button is clicked")]
		public void ClickRecolorButton()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000726")]
		[Cpp2IlInjected.Address(RVA = "0x82B2480", Offset = "0x82B0E80", VA = "0x1882B2480")]
		private void OnStampModeChanged(bool mode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000727")]
		[Cpp2IlInjected.Address(RVA = "0x82B2A20", Offset = "0x82B1420", VA = "0x1882B2A20")]
		private void UpdateCreateModeContextualBarData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000728")]
		[Cpp2IlInjected.Address(RVA = "0x82B2520", Offset = "0x82B0F20", VA = "0x1882B2520")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000729")]
		[Cpp2IlInjected.Address(RVA = "0x82B17B0", Offset = "0x82B01B0", VA = "0x1882B17B0")]
		private void LogClick(string buttonName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072C")]
		[Cpp2IlInjected.Address(RVA = "0x82B0E20", Offset = "0x82AF820", VA = "0x1882B0E20", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072D")]
		[Cpp2IlInjected.Address(RVA = "0x82B0B70", Offset = "0x82AF570", VA = "0x1882B0B70")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600072E")]
		[Cpp2IlInjected.Address(RVA = "0x82B2BA0", Offset = "0x82B15A0", VA = "0x1882B2BA0")]
		public MakerPenHUDCreateToolbarViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C5")]
	[ViewModel]
	public class MakerPenHUDPaletteListViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x20000C6")]
		private enum PaletteCategory
		{
			[Cpp2IlInjected.Token(Token = "0x40004D4")]
			Favorites,
			[Cpp2IlInjected.Token(Token = "0x40004D5")]
			AllObjects,
			[Cpp2IlInjected.Token(Token = "0x40004D6")]
			RoomInventions
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		[SerializeField]
		private InfiniteListViewControllerBase listController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private PaletteCategory currentCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private DataList<NIDNGJKLFHH> placableObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private DataItemList PlacableObjectsDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001DC")]
		private CALCCDAOBPO paletteDataStore
		{
			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x82BD330", Offset = "0x82BBD30", VA = "0x1882BD330")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DD")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<NIDNGJKLFHH> PlacableObjects
		{
			[Cpp2IlInjected.Token(Token = "0x600073E")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B30", Offset = "0xAB6530", VA = "0x180AB7B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600073F")]
			[Cpp2IlInjected.Address(RVA = "0x82BD380", Offset = "0x82BBD80", VA = "0x1882BD380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DE")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x82BD2F0", Offset = "0x82BBCF0", VA = "0x1882BD2F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001DF")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000740")]
		[Cpp2IlInjected.Address(RVA = "0x82BBCF0", Offset = "0x82BA6F0", VA = "0x1882BBCF0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000741")]
		[Cpp2IlInjected.Address(RVA = "0x82BC2C0", Offset = "0x82BACC0", VA = "0x1882BC2C0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x82BC700", Offset = "0x82BB100", VA = "0x1882BC700")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x82BC6B0", Offset = "0x82BB0B0", VA = "0x1882BC6B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0x82BCBA0", Offset = "0x82BB5A0", VA = "0x1882BCBA0")]
		private void RefreshList()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x82BC840", Offset = "0x82BB240", VA = "0x1882BC840")]
		private void OnObjectsCategoryRequested(string paletteSearchFilter, MJCLEJBAMDB paletteSortOption)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x82BC7B0", Offset = "0x82BB1B0", VA = "0x1882BC7B0")]
		private void OnFavoritesCategoryRequested()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x82BCA80", Offset = "0x82BB480", VA = "0x1882BCA80")]
		private void OnRoomInventionsCategoryRequested()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x82BCA70", Offset = "0x82BB470", VA = "0x1882BCA70")]
		private void OnPaletteToggled(bool open)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x82BCFD0", Offset = "0x82BB9D0", VA = "0x1882BCFD0")]
		private void SelectFirstGridItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x82BC8F0", Offset = "0x82BB2F0", VA = "0x1882BC8F0")]
		private void OnPaletteSearchToggledToOpen(bool open)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x82BCB10", Offset = "0x82BB510", VA = "0x1882BCB10")]
		private void OnSearchStringChanged(string newSearchString)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074E")]
		[Cpp2IlInjected.Address(RVA = "0x82BC170", Offset = "0x82BAB70", VA = "0x1882BC170", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074F")]
		[Cpp2IlInjected.Address(RVA = "0x82BC0C0", Offset = "0x82BAAC0", VA = "0x1882BC0C0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000750")]
		[Cpp2IlInjected.Address(RVA = "0x82BD200", Offset = "0x82BBC00", VA = "0x1882BD200")]
		public MakerPenHUDPaletteListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C7")]
	[ViewModel]
	public class MakerPenHUDPaletteObjectViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000C8")]
		[CompilerGenerated]
		private struct <RefreshIcon>d__65 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004FD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004FE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004FF")]
			public NIDNGJKLFHH placableObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000500")]
			public MakerPenHUDPaletteObjectViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000501")]
			private TaskAwaiter<Texture2D> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000790")]
			[Cpp2IlInjected.Address(RVA = "0x82D5340", Offset = "0x82D3D40", VA = "0x1882D5340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000791")]
			[Cpp2IlInjected.Address(RVA = "0x82D5550", Offset = "0x82D3F50", VA = "0x1882D5550", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000C9")]
		[CompilerGenerated]
		private struct <RefreshName>d__66 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000502")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000503")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000504")]
			public NIDNGJKLFHH placableObject;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000505")]
			public MakerPenHUDPaletteObjectViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000506")]
			private TaskAwaiter<string> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000792")]
			[Cpp2IlInjected.Address(RVA = "0x82D55B0", Offset = "0x82D3FB0", VA = "0x1882D55B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000793")]
			[Cpp2IlInjected.Address(RVA = "0x82D57A0", Offset = "0x82D41A0", VA = "0x1882D57A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		private NIDNGJKLFHH placable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		private ContextMenuManager contextMenuManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		private List<ContextMenuItemData> contextMenuItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		[SerializeField]
		private ContextMenuItemData favoriteMenuItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		[SerializeField]
		private ContextMenuItemData unfavoriteMenuItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		[SerializeField]
		private ContextMenuItemData infoMenuItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		[FormerlySerializedAs("Index")]
		public int ObjectIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private bool favorited;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private bool canBeFavorited;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9E")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private bool contextMenuShortcutAvailable;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private Texture iconTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		private bool isIconTextureSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		private string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		private string objectName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		private bool selected;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		private bool showActionButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private string actionButtonText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private bool canShowInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private bool focused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private DataItem<bool> FavoritedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private DataItem<bool> CanBeFavoritedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		private DataItem<bool> ContentMenuShortcutAvailableDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		private DataItem<Texture> IconTextureDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		private DataItem<bool> IsIconTextureSetDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		private DataItem<string> ImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private DataItem<string> ObjectNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private DataItem<bool> SelectedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private DataItem<bool> ShowActionButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private DataItem<string> ActionButtonTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private DataItem<bool> CanShowInfoDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		private DataItem<bool> FocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private DataItemAction ClickObjectDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private DataItemAction ClickFavoriteDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private DataItemAction ClickActionButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private DataItemAction ClickInfoButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private DataItemAction SeeMoreOptionsDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001E0")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000753")]
			[Cpp2IlInjected.Address(RVA = "0x82BFD60", Offset = "0x82BE760", VA = "0x1882BFD60", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E1")]
		[BindableData(1, "Whether or not the user has favorited this object", DataPermissions.ReadOnly)]
		public bool Favorited
		{
			[Cpp2IlInjected.Token(Token = "0x6000754")]
			[Cpp2IlInjected.Address(RVA = "0x1FA0C80", Offset = "0x1F9F680", VA = "0x181FA0C80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000755")]
			[Cpp2IlInjected.Address(RVA = "0x82BFF20", Offset = "0x82BE920", VA = "0x1882BFF20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E2")]
		[BindableData(8, "Whether or not the user can set this object as a favorite", DataPermissions.ReadOnly)]
		public bool CanBeFavorited
		{
			[Cpp2IlInjected.Token(Token = "0x6000756")]
			[Cpp2IlInjected.Address(RVA = "0x21330F0", Offset = "0x2131AF0", VA = "0x1821330F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000757")]
			[Cpp2IlInjected.Address(RVA = "0x82BFE60", Offset = "0x82BE860", VA = "0x1882BFE60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E3")]
		[BindableData(12, null, DataPermissions.ReadWrite)]
		public bool ContentMenuShortcutAvailable
		{
			[Cpp2IlInjected.Token(Token = "0x6000758")]
			[Cpp2IlInjected.Address(RVA = "0x82BF6C0", Offset = "0x82BE0C0", VA = "0x1882BF6C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000759")]
			[Cpp2IlInjected.Address(RVA = "0x82BF6D0", Offset = "0x82BE0D0", VA = "0x1882BF6D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E4")]
		[BindableData(2, "The image to use for the icon for the object", DataPermissions.ReadOnly)]
		public Texture IconTexture
		{
			[Cpp2IlInjected.Token(Token = "0x600075A")]
			[Cpp2IlInjected.Address(RVA = "0xB79620", Offset = "0xB78020", VA = "0x180B79620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600075B")]
			[Cpp2IlInjected.Address(RVA = "0x82BFF80", Offset = "0x82BE980", VA = "0x1882BFF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E5")]
		[BindableData(7, "True if the icon texture is set", DataPermissions.ReadOnly)]
		public bool IsIconTextureSet
		{
			[Cpp2IlInjected.Token(Token = "0x600075C")]
			[Cpp2IlInjected.Address(RVA = "0xB797F0", Offset = "0xB781F0", VA = "0x180B797F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600075D")]
			[Cpp2IlInjected.Address(RVA = "0x82C0170", Offset = "0x82BEB70", VA = "0x1882C0170")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E6")]
		[BindableData(13, null, DataPermissions.ReadWrite)]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x600075E")]
			[Cpp2IlInjected.Address(RVA = "0xB793D0", Offset = "0xB77DD0", VA = "0x180B793D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600075F")]
			[Cpp2IlInjected.Address(RVA = "0x82C00E0", Offset = "0x82BEAE0", VA = "0x1882C00E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E7")]
		[BindableData(5, "The name of the object to display", DataPermissions.ReadOnly)]
		public string ObjectName
		{
			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(RVA = "0xEE2960", Offset = "0xEE1360", VA = "0x180EE2960")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x82C01D0", Offset = "0x82BEBD0", VA = "0x1882C01D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E8")]
		[BindableData(6, "Whether or not the object is selected by the user", DataPermissions.ReadOnly)]
		public bool Selected
		{
			[Cpp2IlInjected.Token(Token = "0x6000762")]
			[Cpp2IlInjected.Address(RVA = "0x10E8B30", Offset = "0x10E7530", VA = "0x1810E8B30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000763")]
			[Cpp2IlInjected.Address(RVA = "0x82C0250", Offset = "0x82BEC50", VA = "0x1882C0250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001E9")]
		[BindableData(9, "Whether or not to show the action button", DataPermissions.ReadOnly)]
		public bool ShowActionButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000764")]
			[Cpp2IlInjected.Address(RVA = "0x10E8CC0", Offset = "0x10E76C0", VA = "0x1810E8CC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000765")]
			[Cpp2IlInjected.Address(RVA = "0x82C02B0", Offset = "0x82BECB0", VA = "0x1882C02B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EA")]
		[BindableData(10, "Text to populate the action button", DataPermissions.ReadOnly)]
		public string ActionButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x6000766")]
			[Cpp2IlInjected.Address(RVA = "0xB795C0", Offset = "0xB77FC0", VA = "0x180B795C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000767")]
			[Cpp2IlInjected.Address(RVA = "0x82BFDE0", Offset = "0x82BE7E0", VA = "0x1882BFDE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EB")]
		[BindableData(14, "Whether or not the user can the info button", DataPermissions.ReadOnly)]
		public bool CanShowInfo
		{
			[Cpp2IlInjected.Token(Token = "0x6000768")]
			[Cpp2IlInjected.Address(RVA = "0xF25030", Offset = "0xF23A30", VA = "0x180F25030")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000769")]
			[Cpp2IlInjected.Address(RVA = "0x82BFEC0", Offset = "0x82BE8C0", VA = "0x1882BFEC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EC")]
		[BindableData(17, null, DataPermissions.ReadWrite)]
		public bool Focused
		{
			[Cpp2IlInjected.Token(Token = "0x600076A")]
			[Cpp2IlInjected.Address(RVA = "0x2717740", Offset = "0x2716140", VA = "0x182717740")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600076B")]
			[Cpp2IlInjected.Address(RVA = "0x82BF660", Offset = "0x82BE060", VA = "0x1882BF660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001ED")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600077C")]
			[Cpp2IlInjected.Address(RVA = "0x82BFD20", Offset = "0x82BE720", VA = "0x1882BFD20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001EE")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600077D")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0x82BD550", Offset = "0x82BBF50", VA = "0x1882BD550")]
		[BindableAction(3, "Call when the object is clicked")]
		public void ClickObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0x82BD490", Offset = "0x82BBE90", VA = "0x1882BD490")]
		[BindableAction(4, "Call when the favorite button is clicked")]
		public void ClickFavorite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076E")]
		[Cpp2IlInjected.Address(RVA = "0x82BD430", Offset = "0x82BBE30", VA = "0x1882BD430")]
		[BindableAction(11, "Called when the action button is clicked")]
		public void ClickActionButton()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076F")]
		[Cpp2IlInjected.Address(RVA = "0x82BD4F0", Offset = "0x82BBEF0", VA = "0x1882BD4F0")]
		[BindableAction(15, "Called when the info button is clicked")]
		public void ClickInfoButton()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000770")]
		[Cpp2IlInjected.Address(RVA = "0x82BECB0", Offset = "0x82BD6B0", VA = "0x1882BECB0")]
		[BindableAction(16, null)]
		private void SeeMoreOptions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000771")]
		[Cpp2IlInjected.Address(RVA = "0x82BE7A0", Offset = "0x82BD1A0", VA = "0x1882BE7A0")]
		private void OnPaletteEntryUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000772")]
		[Cpp2IlInjected.Address(RVA = "0x82BECC0", Offset = "0x82BD6C0", VA = "0x1882BECC0")]
		private void SetData(NIDNGJKLFHH placableObject)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000773")]
		[Cpp2IlInjected.Address(RVA = "0x82BEAD0", Offset = "0x82BD4D0", VA = "0x1882BEAD0")]
		[AsyncStateMachine(typeof(<RefreshIcon>d__65))]
		private Task RefreshIcon(NIDNGJKLFHH placableObject)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000774")]
		[Cpp2IlInjected.Address(RVA = "0x82BEBC0", Offset = "0x82BD5C0", VA = "0x1882BEBC0")]
		[AsyncStateMachine(typeof(<RefreshName>d__66))]
		private Task RefreshName(NIDNGJKLFHH placableObject)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000775")]
		[Cpp2IlInjected.Address(RVA = "0x82BE610", Offset = "0x82BD010", VA = "0x1882BE610")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000776")]
		[Cpp2IlInjected.Address(RVA = "0x82BF290", Offset = "0x82BDC90", VA = "0x1882BF290")]
		private void ShowContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000777")]
		[Cpp2IlInjected.Address(RVA = "0x82BE520", Offset = "0x82BCF20", VA = "0x1882BE520")]
		private void OnContextMenuClosed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000778")]
		[Cpp2IlInjected.Address(RVA = "0x82BF5B0", Offset = "0x82BDFB0", VA = "0x1882BF5B0")]
		private void ToggleFavorite()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000779")]
		[Cpp2IlInjected.Address(RVA = "0x82BF740", Offset = "0x82BE140", VA = "0x1882BF740")]
		private void ViewInfo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077A")]
		[Cpp2IlInjected.Address(RVA = "0x82BD3E0", Offset = "0x82BBDE0", VA = "0x1882BD3E0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077B")]
		[Cpp2IlInjected.Address(RVA = "0x82BE750", Offset = "0x82BD150", VA = "0x1882BE750", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077E")]
		[Cpp2IlInjected.Address(RVA = "0x82BD890", Offset = "0x82BC290", VA = "0x1882BD890", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600077F")]
		[Cpp2IlInjected.Address(RVA = "0x82BD5B0", Offset = "0x82BBFB0", VA = "0x1882BD5B0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000780")]
		[Cpp2IlInjected.Address(RVA = "0x82BF820", Offset = "0x82BE220", VA = "0x1882BF820")]
		public MakerPenHUDPaletteObjectViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[ViewModel]
	public class MakerPenHUDPaletteSearchViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000507")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private DataItem<string> PaletteSearchStringDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001EF")]
		[BindableData(1, "The current search string fed to the palette population logic", DataPermissions.ReadWrite)]
		public string PaletteSearchString
		{
			[Cpp2IlInjected.Token(Token = "0x6000796")]
			[Cpp2IlInjected.Address(RVA = "0x82C0590", Offset = "0x82BEF90", VA = "0x1882C0590")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000797")]
			[Cpp2IlInjected.Address(RVA = "0x82C05E0", Offset = "0x82BEFE0", VA = "0x1882C05E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F0")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000798")]
			[Cpp2IlInjected.Address(RVA = "0x82C06D0", Offset = "0x82BF0D0", VA = "0x1882C06D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F1")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000799")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000794")]
		[Cpp2IlInjected.Address(RVA = "0x82C0310", Offset = "0x82BED10", VA = "0x1882C0310", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000795")]
		[Cpp2IlInjected.Address(RVA = "0x82C0560", Offset = "0x82BEF60", VA = "0x1882C0560", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0x82C0410", Offset = "0x82BEE10", VA = "0x1882C0410", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079B")]
		[Cpp2IlInjected.Address(RVA = "0x82C0360", Offset = "0x82BED60", VA = "0x1882C0360")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x82C0640", Offset = "0x82BF040", VA = "0x1882C0640")]
		public MakerPenHUDPaletteSearchViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CB")]
	[ViewModel]
	public class MakerPenHUDPaletteViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private DataItem<bool> IsPaletteSearchOpenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private DataItemAction TogglePaletteSearchDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001F2")]
		[BindableData(2, "Is the palette search currently opened or closed", DataPermissions.ReadOnly)]
		public bool IsPaletteSearchOpen
		{
			[Cpp2IlInjected.Token(Token = "0x60007A2")]
			[Cpp2IlInjected.Address(RVA = "0x82C0A30", Offset = "0x82BF430", VA = "0x1882C0A30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F3")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60007A3")]
			[Cpp2IlInjected.Address(RVA = "0x82C0B40", Offset = "0x82BF540", VA = "0x1882C0B40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F4")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60007A4")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600079F")]
		[Cpp2IlInjected.Address(RVA = "0x82C0700", Offset = "0x82BF100", VA = "0x1882C0700", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A0")]
		[Cpp2IlInjected.Address(RVA = "0x82C0560", Offset = "0x82BEF60", VA = "0x1882C0560", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A1")]
		[Cpp2IlInjected.Address(RVA = "0x82C09C0", Offset = "0x82BF3C0", VA = "0x1882C09C0")]
		[BindableAction(1, "Toggle Search bar open/closed")]
		public void TogglePaletteSearch()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A5")]
		[Cpp2IlInjected.Address(RVA = "0x82C0810", Offset = "0x82BF210", VA = "0x1882C0810", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A6")]
		[Cpp2IlInjected.Address(RVA = "0x82C0750", Offset = "0x82BF150", VA = "0x1882C0750")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007A7")]
		[Cpp2IlInjected.Address(RVA = "0x82C0A80", Offset = "0x82BF480", VA = "0x1882C0A80")]
		public MakerPenHUDPaletteViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CC")]
	[ViewModel]
	public class MakerPenHUDSelectToolbarViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x20000CD")]
		[CompilerGenerated]
		private sealed class <UnfocusedNavWaitDelay>d__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000577")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000578")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000579")]
			public MakerPenHUDSelectToolbarViewModel <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700021D")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000859")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700021E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600085B")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000856")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public <UnfocusedNavWaitDelay>d__33(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000857")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000858")]
			[Cpp2IlInjected.Address(RVA = "0x82D5800", Offset = "0x82D4200", VA = "0x1882D5800", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600085A")]
			[Cpp2IlInjected.Address(RVA = "0x82D58E0", Offset = "0x82D42E0", VA = "0x1882D58E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400050E")]
		[SerializeField]
		private FocusableUI focusable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400050F")]
		[SerializeField]
		private float unfocusedNavigationSelectDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000510")]
		[SerializeField]
		private DialogListModel dialogListModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000511")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000512")]
		private IRRUIvNextBridge rruiBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000513")]
		private HCPPOIKBIDE makerPenHUDManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000514")]
		private bool leftModifierPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x91")]
		[Cpp2IlInjected.Token(Token = "0x4000515")]
		private bool rightModifierPressed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x92")]
		[Cpp2IlInjected.Token(Token = "0x4000516")]
		private bool rightModifierHeld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000517")]
		private float lastUnfocusedNavEventTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000518")]
		private Coroutine unfocusedNavWaitCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		private bool hasFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		private float holdInputProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		private bool showHoldIndicator;

		[Cpp2IlInjected.Token(Token = "0x400051C")]
		private const string cloneButtonName = "Clone Tool Button";

		[Cpp2IlInjected.Token(Token = "0x400051D")]
		private const string moveButtonName = "Precision Move Toggle";

		[Cpp2IlInjected.Token(Token = "0x400051E")]
		private const string rotateButtonName = "Precision Rotate Toggle";

		[Cpp2IlInjected.Token(Token = "0x400051F")]
		private const string scaleButtonName = "Precision Scale Toggle";

		[Cpp2IlInjected.Token(Token = "0x4000520")]
		private const string deleteButtonName = "Delete Button";

		[Cpp2IlInjected.FieldOffset(Offset = "0xA9")]
		[Cpp2IlInjected.Token(Token = "0x4000521")]
		private bool isDeleteAllow;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAA")]
		[Cpp2IlInjected.Token(Token = "0x4000522")]
		private bool onCloneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAB")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		private bool inTransformModeAndMoveOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000524")]
		private bool inTransformModeAndRotateOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAD")]
		[Cpp2IlInjected.Token(Token = "0x4000525")]
		private bool inTransformModeAndScaleOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAE")]
		[Cpp2IlInjected.Token(Token = "0x4000526")]
		private bool isRecolorModeActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAF")]
		[Cpp2IlInjected.Token(Token = "0x4000527")]
		private bool isPrecisionModifierModeActive;

		[Cpp2IlInjected.Token(Token = "0x4000528")]
		private const string recolorButtonName = "Recolor Tool Button";

		[Cpp2IlInjected.Token(Token = "0x4000529")]
		private const string colorPickerButtonName = "Color Picker Menu Toggle";

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400052A")]
		private bool showEditColorPanel;

		[Cpp2IlInjected.Token(Token = "0x400052B")]
		private const string exitRecolorButtonName = "Exit Recolor Button";

		[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
		[Cpp2IlInjected.Token(Token = "0x400052C")]
		private bool isEditColorPanelHiddenWhenRecolorModeActive;

		[Cpp2IlInjected.Token(Token = "0x400052D")]
		private const string configButtonName = "Config Tool Button";

		[Cpp2IlInjected.FieldOffset(Offset = "0xB2")]
		[Cpp2IlInjected.Token(Token = "0x400052E")]
		private bool onConfigMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB3")]
		[Cpp2IlInjected.Token(Token = "0x400052F")]
		private bool isRRUIPageContainerEnabled;

		[Cpp2IlInjected.Token(Token = "0x4000530")]
		private const string adjustButtonName = "Adjust Button";

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000531")]
		private string toolDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000532")]
		private bool isAdjustModeActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
		[Cpp2IlInjected.Token(Token = "0x4000533")]
		private bool showAdjustButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC2")]
		[Cpp2IlInjected.Token(Token = "0x4000534")]
		private bool adjustFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC3")]
		[Cpp2IlInjected.Token(Token = "0x4000535")]
		private bool cloneFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000536")]
		private bool recolorFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC5")]
		[Cpp2IlInjected.Token(Token = "0x4000537")]
		private bool configFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC6")]
		[Cpp2IlInjected.Token(Token = "0x4000538")]
		private bool deleteFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC7")]
		[Cpp2IlInjected.Token(Token = "0x4000539")]
		private bool moveModeFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400053A")]
		private bool rotateModeFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC9")]
		[Cpp2IlInjected.Token(Token = "0x400053B")]
		private bool scaleModeFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCA")]
		[Cpp2IlInjected.Token(Token = "0x400053C")]
		private bool recolorModeAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCB")]
		[Cpp2IlInjected.Token(Token = "0x400053D")]
		private bool configModeAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400053E")]
		private bool isDeleteModeActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCD")]
		[Cpp2IlInjected.Token(Token = "0x400053F")]
		private bool onlyMoveOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCE")]
		[Cpp2IlInjected.Token(Token = "0x4000540")]
		private bool onlyRotateOn;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCF")]
		[Cpp2IlInjected.Token(Token = "0x4000541")]
		private bool onlyScaleOn;

		[Cpp2IlInjected.Token(Token = "0x4000542")]
		private const string selectModeAnalyticsString = "Default Mode";

		[Cpp2IlInjected.Token(Token = "0x4000543")]
		private const string precisionSelectModeAnalyticsString = "Precision Mode";

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000544")]
		private string currentModeAnalyticsString;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000545")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000546")]
		private DataItem<bool> HasFocusDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000547")]
		private DataItem<float> HoldInputProgressDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000548")]
		private DataItem<bool> ShowHoldIndicatorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000549")]
		private DataItem<bool> IsDeleteAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400054A")]
		private DataItem<bool> OnCloneModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400054B")]
		private DataItem<bool> MoveOnDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400054C")]
		private DataItem<bool> RotateOnDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400054D")]
		private DataItem<bool> ScaleOnDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400054E")]
		private DataItem<bool> IsRecolorModeActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400054F")]
		private DataItem<bool> IsPrecisionModifierModeActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000550")]
		private DataItem<bool> ShowEditColorPanelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000551")]
		private DataItem<bool> IsEditColorPanelHiddenWhenRecolorModeActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000552")]
		private DataItem<bool> OnConfigModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000553")]
		private DataItem<bool> IsRRUIPageContainerEnabledDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000554")]
		private DataItem<string> ToolDescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000555")]
		private DataItem<bool> IsAdjustModeActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000556")]
		private DataItem<bool> ShowAdjustButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000557")]
		private DataItem<bool> AdjustFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000558")]
		private DataItem<bool> CloneFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000559")]
		private DataItem<bool> RecolorFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400055A")]
		private DataItem<bool> ConfigFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400055B")]
		private DataItem<bool> DeleteFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400055C")]
		private DataItem<bool> MoveModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400055D")]
		private DataItem<bool> RotateModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400055E")]
		private DataItem<bool> ScaleModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400055F")]
		private DataItem<bool> RecolorModeAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000560")]
		private DataItem<bool> ConfigModeAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000561")]
		private DataItem<bool> IsDeleteModeActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000562")]
		private DataItem<bool> MoveOnAndFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000563")]
		private DataItem<bool> RotateOnAndFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000564")]
		private DataItem<bool> ScaleOnAndFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000565")]
		private DataItem<bool> MoveOffAndFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000566")]
		private DataItem<bool> RotateOffAndFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000567")]
		private DataItem<bool> ScaleOffAndFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000568")]
		private DataItem<bool> OnlyMoveOnDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000569")]
		private DataItem<bool> OnlyRotateOnDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x400056A")]
		private DataItem<bool> OnlyScaleOnDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x400056B")]
		private DataItemAction ToggleCloneModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x400056C")]
		private DataItemAction ToggleMoveModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400056D")]
		private DataItemAction ToggleRotateModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x400056E")]
		private DataItemAction ToggleScaleModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400056F")]
		private DataItemAction DeleteSelectionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000570")]
		private DataItemAction ToggleRecolorModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000571")]
		private DataItemAction ExitRecolorModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000572")]
		private DataItemAction ToggleConfigModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000573")]
		private DataItemAction HideRRUIPageContainerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000574")]
		private DataItemAction ShowRRUIPageContainerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000575")]
		private DataItemAction RequestAdjustModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000576")]
		private DataItemAction ToggleColorPickerDataItem;

		[Cpp2IlInjected.Token(Token = "0x170001F5")]
		private bool shouldFocus
		{
			[Cpp2IlInjected.Token(Token = "0x60007A9")]
			[Cpp2IlInjected.Address(RVA = "0x82C8CA0", Offset = "0x82C76A0", VA = "0x1882C8CA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F6")]
		[BindableData(200, null, DataPermissions.ReadWrite)]
		public bool HasFocus
		{
			[Cpp2IlInjected.Token(Token = "0x60007AA")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7E0", Offset = "0xB2E1E0", VA = "0x180B2F7E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007AB")]
			[Cpp2IlInjected.Address(RVA = "0x82C6B50", Offset = "0x82C5550", VA = "0x1882C6B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F7")]
		[BindableData(201, null, DataPermissions.ReadWrite)]
		public float HoldInputProgress
		{
			[Cpp2IlInjected.Token(Token = "0x60007AC")]
			[Cpp2IlInjected.Address(RVA = "0x1FF6940", Offset = "0x1FF5340", VA = "0x181FF6940")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60007AD")]
			[Cpp2IlInjected.Address(RVA = "0x82C6DA0", Offset = "0x82C57A0", VA = "0x1882C6DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F8")]
		[BindableData(202, null, DataPermissions.ReadWrite)]
		public bool ShowHoldIndicator
		{
			[Cpp2IlInjected.Token(Token = "0x60007AE")]
			[Cpp2IlInjected.Address(RVA = "0xB797F0", Offset = "0xB781F0", VA = "0x180B797F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007AF")]
			[Cpp2IlInjected.Address(RVA = "0x82C7200", Offset = "0x82C5C00", VA = "0x1882C7200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001F9")]
		[BindableData(6, "Is Delete Allowed", DataPermissions.ReadWrite)]
		public bool IsDeleteAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x60007C4")]
			[Cpp2IlInjected.Address(RVA = "0xB795A0", Offset = "0xB77FA0", VA = "0x180B795A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007C5")]
			[Cpp2IlInjected.Address(RVA = "0x82C7270", Offset = "0x82C5C70", VA = "0x1882C7270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FA")]
		[BindableData(7, "OnCloneMode", DataPermissions.ReadWrite)]
		public bool OnCloneMode
		{
			[Cpp2IlInjected.Token(Token = "0x60007C6")]
			[Cpp2IlInjected.Address(RVA = "0x1FA1E20", Offset = "0x1FA0820", VA = "0x181FA1E20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007C7")]
			[Cpp2IlInjected.Address(RVA = "0x82C72D0", Offset = "0x82C5CD0", VA = "0x1882C72D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FB")]
		[BindableData(8, "In Transfrom Mode And Move On", DataPermissions.ReadWrite)]
		public bool MoveOn
		{
			[Cpp2IlInjected.Token(Token = "0x60007C8")]
			[Cpp2IlInjected.Address(RVA = "0x2ADF400", Offset = "0x2ADDE00", VA = "0x182ADF400")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007C9")]
			[Cpp2IlInjected.Address(RVA = "0x82C90F0", Offset = "0x82C7AF0", VA = "0x1882C90F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FC")]
		[BindableData(9, "In Transform Mode And Rotate On", DataPermissions.ReadWrite)]
		public bool RotateOn
		{
			[Cpp2IlInjected.Token(Token = "0x60007CA")]
			[Cpp2IlInjected.Address(RVA = "0xAAC1A0", Offset = "0xAAABA0", VA = "0x180AAC1A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007CB")]
			[Cpp2IlInjected.Address(RVA = "0x82C9330", Offset = "0x82C7D30", VA = "0x1882C9330")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FD")]
		[BindableData(10, "In Transform Mode And Scale On", DataPermissions.ReadWrite)]
		public bool ScaleOn
		{
			[Cpp2IlInjected.Token(Token = "0x60007CC")]
			[Cpp2IlInjected.Address(RVA = "0x2F2E3F0", Offset = "0x2F2CDF0", VA = "0x182F2E3F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007CD")]
			[Cpp2IlInjected.Address(RVA = "0x82C93D0", Offset = "0x82C7DD0", VA = "0x1882C93D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FE")]
		[BindableData(11, "Is Recolor Tool Currently Active", DataPermissions.ReadWrite)]
		public bool IsRecolorModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x60007CE")]
			[Cpp2IlInjected.Address(RVA = "0x82C6AD0", Offset = "0x82C54D0", VA = "0x1882C6AD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007CF")]
			[Cpp2IlInjected.Address(RVA = "0x82C6AE0", Offset = "0x82C54E0", VA = "0x1882C6AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170001FF")]
		[BindableData(12, "Is Transform Tool Active", DataPermissions.ReadWrite)]
		public bool IsPrecisionModifierModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x60007D0")]
			[Cpp2IlInjected.Address(RVA = "0x79240E0", Offset = "0x7922AE0", VA = "0x1879240E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0x82C8EF0", Offset = "0x82C78F0", VA = "0x1882C8EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000200")]
		[BindableData(14, "Show Edit Color Panel", DataPermissions.ReadOnly)]
		public bool ShowEditColorPanel
		{
			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0xC5E0D0", Offset = "0xC5CAD0", VA = "0x180C5E0D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0x82C9540", Offset = "0x82C7F40", VA = "0x1882C9540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000201")]
		[BindableData(16, "Is Edit Color Panel Hidden When Recolor Mode is Active", DataPermissions.ReadWrite)]
		public bool IsEditColorPanelHiddenWhenRecolorModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x60007D6")]
			[Cpp2IlInjected.Address(RVA = "0xC5E0E0", Offset = "0xC5CAE0", VA = "0x180C5E0E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007D7")]
			[Cpp2IlInjected.Address(RVA = "0x82C6BB0", Offset = "0x82C55B0", VA = "0x1882C6BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000202")]
		[BindableData(18, "OnConfigMode", DataPermissions.ReadWrite)]
		public bool OnConfigMode
		{
			[Cpp2IlInjected.Token(Token = "0x60007D9")]
			[Cpp2IlInjected.Address(RVA = "0xC5E100", Offset = "0xC5CB00", VA = "0x180C5E100")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007DA")]
			[Cpp2IlInjected.Address(RVA = "0x82C6C10", Offset = "0x82C5610", VA = "0x1882C6C10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000203")]
		[BindableData(19, "IsRRUIPageContainerEnabled", DataPermissions.ReadWrite)]
		public bool IsRRUIPageContainerEnabled
		{
			[Cpp2IlInjected.Token(Token = "0x60007DB")]
			[Cpp2IlInjected.Address(RVA = "0x239D4E0", Offset = "0x239BEE0", VA = "0x18239D4E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007DC")]
			[Cpp2IlInjected.Address(RVA = "0x82C6C70", Offset = "0x82C5670", VA = "0x1882C6C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000204")]
		[BindableData(23, "ToolDescription", DataPermissions.ReadOnly)]
		public string ToolDescription
		{
			[Cpp2IlInjected.Token(Token = "0x60007E0")]
			[Cpp2IlInjected.Address(RVA = "0xEE2960", Offset = "0xEE1360", VA = "0x180EE2960")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60007E1")]
			[Cpp2IlInjected.Address(RVA = "0x82C95A0", Offset = "0x82C7FA0", VA = "0x1882C95A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000205")]
		[BindableData(24, "Is Adjust Mode Active", DataPermissions.ReadWrite)]
		public bool IsAdjustModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x60007E2")]
			[Cpp2IlInjected.Address(RVA = "0x10E8B30", Offset = "0x10E7530", VA = "0x1810E8B30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E3")]
			[Cpp2IlInjected.Address(RVA = "0x82C6CD0", Offset = "0x82C56D0", VA = "0x1882C6CD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000206")]
		[BindableData(25, "Show the Adjust button", DataPermissions.ReadWrite)]
		public bool ShowAdjustButton
		{
			[Cpp2IlInjected.Token(Token = "0x60007E4")]
			[Cpp2IlInjected.Address(RVA = "0x10E8CC0", Offset = "0x10E76C0", VA = "0x1810E8CC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E5")]
			[Cpp2IlInjected.Address(RVA = "0x82C9470", Offset = "0x82C7E70", VA = "0x1882C9470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000207")]
		[BindableData(26, null, DataPermissions.ReadWrite)]
		public bool AdjustFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007E6")]
			[Cpp2IlInjected.Address(RVA = "0x229C130", Offset = "0x229AB30", VA = "0x18229C130")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0x82C8D70", Offset = "0x82C7770", VA = "0x1882C8D70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000208")]
		[BindableData(27, null, DataPermissions.ReadWrite)]
		public bool CloneFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0x229BD00", Offset = "0x229A700", VA = "0x18229BD00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007E9")]
			[Cpp2IlInjected.Address(RVA = "0x82C8DF0", Offset = "0x82C77F0", VA = "0x1882C8DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000209")]
		[BindableData(28, null, DataPermissions.ReadWrite)]
		public bool RecolorFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007EA")]
			[Cpp2IlInjected.Address(RVA = "0x82C6D60", Offset = "0x82C5760", VA = "0x1882C6D60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007EB")]
			[Cpp2IlInjected.Address(RVA = "0x82C92B0", Offset = "0x82C7CB0", VA = "0x1882C92B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020A")]
		[BindableData(29, null, DataPermissions.ReadWrite)]
		public bool ConfigFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007EC")]
			[Cpp2IlInjected.Address(RVA = "0x82C6D80", Offset = "0x82C5780", VA = "0x1882C6D80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007ED")]
			[Cpp2IlInjected.Address(RVA = "0x82C8E70", Offset = "0x82C7870", VA = "0x1882C8E70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020B")]
		[BindableData(31, null, DataPermissions.ReadWrite)]
		public bool DeleteFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007EE")]
			[Cpp2IlInjected.Address(RVA = "0x82C6E10", Offset = "0x82C5810", VA = "0x1882C6E10")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007EF")]
			[Cpp2IlInjected.Address(RVA = "0x82C6E20", Offset = "0x82C5820", VA = "0x1882C6E20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020C")]
		[BindableData(32, null, DataPermissions.ReadWrite)]
		public bool MoveModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007F0")]
			[Cpp2IlInjected.Address(RVA = "0x82C6EA0", Offset = "0x82C58A0", VA = "0x1882C6EA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007F1")]
			[Cpp2IlInjected.Address(RVA = "0x82C9050", Offset = "0x82C7A50", VA = "0x1882C9050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020D")]
		[BindableData(33, null, DataPermissions.ReadWrite)]
		public bool RotateModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007F2")]
			[Cpp2IlInjected.Address(RVA = "0x10F1F90", Offset = "0x10F0990", VA = "0x1810F1F90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007F3")]
			[Cpp2IlInjected.Address(RVA = "0x82C6EC0", Offset = "0x82C58C0", VA = "0x1882C6EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020E")]
		[BindableData(34, null, DataPermissions.ReadWrite)]
		public bool ScaleModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0x16A2850", Offset = "0x16A1250", VA = "0x1816A2850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0x82C6F60", Offset = "0x82C5960", VA = "0x1882C6F60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700020F")]
		[BindableData(35, null, DataPermissions.ReadWrite)]
		public bool RecolorModeAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0x82C7000", Offset = "0x82C5A00", VA = "0x1882C7000")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0x82C7010", Offset = "0x82C5A10", VA = "0x1882C7010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000210")]
		[BindableData(36, null, DataPermissions.ReadWrite)]
		public bool ConfigModeAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x60007F8")]
			[Cpp2IlInjected.Address(RVA = "0x82C7070", Offset = "0x82C5A70", VA = "0x1882C7070")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007F9")]
			[Cpp2IlInjected.Address(RVA = "0x82C7080", Offset = "0x82C5A80", VA = "0x1882C7080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000211")]
		[BindableData(38, "Is Delete Mode Active", DataPermissions.ReadWrite)]
		public bool IsDeleteModeActive
		{
			[Cpp2IlInjected.Token(Token = "0x60007FB")]
			[Cpp2IlInjected.Address(RVA = "0x2A88CB0", Offset = "0x2A876B0", VA = "0x182A88CB0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60007FC")]
			[Cpp2IlInjected.Address(RVA = "0x82C70E0", Offset = "0x82C5AE0", VA = "0x1882C70E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000212")]
		[BindableData(39, "Move On And Focused", DataPermissions.ReadOnly)]
		public bool MoveOnAndFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007FD")]
			[Cpp2IlInjected.Address(RVA = "0x82C7140", Offset = "0x82C5B40", VA = "0x1882C7140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000213")]
		[BindableData(40, "Rotate On And Focused", DataPermissions.ReadOnly)]
		public bool RotateOnAndFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007FE")]
			[Cpp2IlInjected.Address(RVA = "0x82C7160", Offset = "0x82C5B60", VA = "0x1882C7160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000214")]
		[BindableData(41, "Scale On And Focused", DataPermissions.ReadOnly)]
		public bool ScaleOnAndFocused
		{
			[Cpp2IlInjected.Token(Token = "0x60007FF")]
			[Cpp2IlInjected.Address(RVA = "0x82C7180", Offset = "0x82C5B80", VA = "0x1882C7180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000215")]
		[BindableData(42, "Move Off And Focused", DataPermissions.ReadOnly)]
		public bool MoveOffAndFocused
		{
			[Cpp2IlInjected.Token(Token = "0x6000800")]
			[Cpp2IlInjected.Address(RVA = "0x82C71A0", Offset = "0x82C5BA0", VA = "0x1882C71A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000216")]
		[BindableData(43, "Rotate Off And Focused", DataPermissions.ReadOnly)]
		public bool RotateOffAndFocused
		{
			[Cpp2IlInjected.Token(Token = "0x6000801")]
			[Cpp2IlInjected.Address(RVA = "0x82C71C0", Offset = "0x82C5BC0", VA = "0x1882C71C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000217")]
		[BindableData(44, "Scale Off And Focused", DataPermissions.ReadOnly)]
		public bool ScaleOffAndFocused
		{
			[Cpp2IlInjected.Token(Token = "0x6000802")]
			[Cpp2IlInjected.Address(RVA = "0x82C71E0", Offset = "0x82C5BE0", VA = "0x1882C71E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000218")]
		[BindableData(45, "Only Move On", DataPermissions.ReadOnly)]
		public bool OnlyMoveOn
		{
			[Cpp2IlInjected.Token(Token = "0x6000803")]
			[Cpp2IlInjected.Address(RVA = "0x2A88CD0", Offset = "0x2A876D0", VA = "0x182A88CD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000804")]
			[Cpp2IlInjected.Address(RVA = "0x82C9190", Offset = "0x82C7B90", VA = "0x1882C9190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000219")]
		[BindableData(46, "Only Rotate On", DataPermissions.ReadOnly)]
		public bool OnlyRotateOn
		{
			[Cpp2IlInjected.Token(Token = "0x6000805")]
			[Cpp2IlInjected.Address(RVA = "0x2A88CC0", Offset = "0x2A876C0", VA = "0x182A88CC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000806")]
			[Cpp2IlInjected.Address(RVA = "0x82C91F0", Offset = "0x82C7BF0", VA = "0x1882C91F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021A")]
		[BindableData(47, "Only Scale On", DataPermissions.ReadOnly)]
		public bool OnlyScaleOn
		{
			[Cpp2IlInjected.Token(Token = "0x6000807")]
			[Cpp2IlInjected.Address(RVA = "0x82C7260", Offset = "0x82C5C60", VA = "0x1882C7260")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000808")]
			[Cpp2IlInjected.Address(RVA = "0x82C9250", Offset = "0x82C7C50", VA = "0x1882C9250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021B")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000812")]
			[Cpp2IlInjected.Address(RVA = "0x82C8C60", Offset = "0x82C7660", VA = "0x1882C8C60", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700021C")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000813")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0x82C5960", Offset = "0x82C4360", VA = "0x1882C5960")]
		private void OnLeftNavInputStateChanged(MakerPenHUDNavigationInputState.NavInputState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0x82C5B80", Offset = "0x82C4580", VA = "0x1882C5B80")]
		private void OnRightNavInputStateChanged(MakerPenHUDNavigationInputState.NavInputState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0x82C7580", Offset = "0x82C5F80", VA = "0x1882C7580")]
		private void UpdateInputState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0x82C1A70", Offset = "0x82C0470", VA = "0x1882C1A70")]
		private void CheckForFocusGained()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B4")]
		[Cpp2IlInjected.Address(RVA = "0x82C1BC0", Offset = "0x82C05C0", VA = "0x1882C1BC0")]
		private void CheckForFocusLost()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x82C5220", Offset = "0x82C3C20", VA = "0x1882C5220")]
		private void OnCursorActiveChanged(bool active)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B6")]
		[Cpp2IlInjected.Address(RVA = "0x82C1290", Offset = "0x82BFC90", VA = "0x1882C1290")]
		private void ChangeModeToMatchButtonFocusState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B7")]
		[Cpp2IlInjected.Address(RVA = "0x82C5B50", Offset = "0x82C4550", VA = "0x1882C5B50")]
		private void OnNavFocusChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B8")]
		[Cpp2IlInjected.Address(RVA = "0x82C7330", Offset = "0x82C5D30", VA = "0x1882C7330")]
		[IteratorStateMachine(typeof(<UnfocusedNavWaitDelay>d__33))]
		private IEnumerator UnfocusedNavWaitDelay()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60007B9")]
		[Cpp2IlInjected.Address(RVA = "0x82C0B70", Offset = "0x82BF570", VA = "0x1882C0B70", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BA")]
		[Cpp2IlInjected.Address(RVA = "0x82C5910", Offset = "0x82C4310", VA = "0x1882C5910")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BB")]
		[Cpp2IlInjected.Address(RVA = "0x82C52B0", Offset = "0x82C3CB0", VA = "0x1882C52B0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BC")]
		[Cpp2IlInjected.Address(RVA = "0x82C6470", Offset = "0x82C4E70", VA = "0x1882C6470")]
		[BindableAction(1, "Press Clone button")]
		public void ToggleCloneMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BD")]
		[Cpp2IlInjected.Address(RVA = "0x82C6630", Offset = "0x82C5030", VA = "0x1882C6630")]
		[BindableAction(2, "Press Move button")]
		public void ToggleMoveMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BE")]
		[Cpp2IlInjected.Address(RVA = "0x82C6860", Offset = "0x82C5260", VA = "0x1882C6860")]
		[BindableAction(3, "Press Rotate button")]
		public void ToggleRotateMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0x82C6980", Offset = "0x82C5380", VA = "0x1882C6980")]
		[BindableAction(4, "Press Scale button")]
		public void ToggleScaleMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0x82C1E10", Offset = "0x82C0810", VA = "0x1882C1E10")]
		[BindableAction(5, "Press Delete button")]
		public void DeleteSelection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0x82C1F50", Offset = "0x82C0950", VA = "0x1882C1F50")]
		public void EnterPrecisionMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0x82C1EF0", Offset = "0x82C08F0", VA = "0x1882C1EF0")]
		public void EnterDeleteMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0x82C73D0", Offset = "0x82C5DD0", VA = "0x1882C73D0")]
		private void UpdateFocusedToMatchActiveMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D2")]
		[Cpp2IlInjected.Address(RVA = "0x82C6750", Offset = "0x82C5150", VA = "0x1882C6750")]
		[BindableAction(13, "Press Recolor button")]
		public void ToggleRecolorMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D5")]
		[Cpp2IlInjected.Address(RVA = "0x82C20B0", Offset = "0x82C0AB0", VA = "0x1882C20B0")]
		[BindableAction(15, "Press Exit Recolor button")]
		public void ExitRecolorMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007D8")]
		[Cpp2IlInjected.Address(RVA = "0x82C6590", Offset = "0x82C4F90", VA = "0x1882C6590")]
		[BindableAction(17, "Press Config button")]
		public void ToggleConfigMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DD")]
		[Cpp2IlInjected.Address(RVA = "0x82C2880", Offset = "0x82C1280", VA = "0x1882C2880")]
		[BindableAction(20, "Hide RRUI Page Container")]
		public void HideRRUIPageContainer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0x82C6410", Offset = "0x82C4E10", VA = "0x1882C6410")]
		[BindableAction(21, "Show RRUI Page Container")]
		public void ShowRRUIPageContainer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0x82C6080", Offset = "0x82C4A80", VA = "0x1882C6080")]
		[BindableAction(22, "Request Adjust Mode")]
		public void RequestAdjustMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FA")]
		[Cpp2IlInjected.Address(RVA = "0x82C6510", Offset = "0x82C4F10", VA = "0x1882C6510")]
		[BindableAction(37, "Toggle Color Picker")]
		public void ToggleColorPicker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0x82C7730", Offset = "0x82C6130", VA = "0x1882C7730")]
		private void UpdatePrecisionModeToolStatus()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080A")]
		[Cpp2IlInjected.Address(RVA = "0x82C7A20", Offset = "0x82C6420", VA = "0x1882C7A20")]
		private void UpdateSelectModeContextualBarData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080B")]
		[Cpp2IlInjected.Address(RVA = "0x82C73B0", Offset = "0x82C5DB0", VA = "0x1882C73B0")]
		private void UpdateColorPickerOpen(bool open)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x82C7A10", Offset = "0x82C6410", VA = "0x1882C7A10")]
		private void UpdateRRUIPageContainerEnabled(bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x82C6120", Offset = "0x82C4B20", VA = "0x1882C6120")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080E")]
		[Cpp2IlInjected.Address(RVA = "0x82C5070", Offset = "0x82C3A70", VA = "0x1882C5070")]
		private void LogImpressionAndChangeMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x82C7880", Offset = "0x82C6280", VA = "0x1882C7880")]
		private void UpdatePrecisionModifierAnalytics()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x82C1D10", Offset = "0x82C0710", VA = "0x1882C1D10")]
		private void ClearPrecisionModifierAnalytics()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000811")]
		[Cpp2IlInjected.Address(RVA = "0x82C4F50", Offset = "0x82C3950", VA = "0x1882C4F50")]
		private void LogClick(string buttonName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000814")]
		[Cpp2IlInjected.Address(RVA = "0x82C28E0", Offset = "0x82C12E0", VA = "0x1882C28E0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000815")]
		[Cpp2IlInjected.Address(RVA = "0x82C2140", Offset = "0x82C0B40", VA = "0x1882C2140")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000816")]
		[Cpp2IlInjected.Address(RVA = "0x82C8030", Offset = "0x82C6A30", VA = "0x1882C8030")]
		public MakerPenHUDSelectToolbarViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CE")]
	[ViewModel]
	public class MakerPenHUDViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400057A")]
		[SerializeField]
		private FocusableUI focusable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400057B")]
		private IMakerPenHUDBridge bridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400057C")]
		private IRRUIvNextBridge rruiBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400057D")]
		private bool leftModifierHeld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x400057E")]
		private bool hasFocus;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400057F")]
		private float holdInputProgress;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000580")]
		private bool showHoldIndicator;

		[Cpp2IlInjected.Token(Token = "0x4000581")]
		private const string undoButtonName = "Undo Button";

		[Cpp2IlInjected.Token(Token = "0x4000582")]
		private const string redoButtonName = "Redo Button";

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x4000583")]
		private bool undoModeFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x82")]
		[Cpp2IlInjected.Token(Token = "0x4000584")]
		private bool redoModeFocused;

		[Cpp2IlInjected.Token(Token = "0x4000585")]
		private const string selectButtonName = "Select Mode Button";

		[Cpp2IlInjected.Token(Token = "0x4000586")]
		private const string createButtonName = "Create Mode Button";

		[Cpp2IlInjected.FieldOffset(Offset = "0x83")]
		[Cpp2IlInjected.Token(Token = "0x4000587")]
		private bool selectModeFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000588")]
		private bool createModeFocused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x85")]
		[Cpp2IlInjected.Token(Token = "0x4000589")]
		private bool selectModeAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x86")]
		[Cpp2IlInjected.Token(Token = "0x400058A")]
		private bool createModeAllowed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400058B")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400058C")]
		private DataItem<bool> HasFocusDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400058D")]
		private DataItem<float> HoldInputProgressDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400058E")]
		private DataItem<bool> ShowHoldIndicatorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400058F")]
		private DataItem<bool> IsUndoAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000590")]
		private DataItem<bool> IsRedoAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000591")]
		private DataItem<bool> UndoModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000592")]
		private DataItem<bool> RedoModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000593")]
		private DataItem<bool> OnSelectModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000594")]
		private DataItem<bool> OnCreateModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000595")]
		private DataItem<bool> SelectModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000596")]
		private DataItem<bool> CreateModeFocusedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000597")]
		private DataItem<bool> SelectModeAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000598")]
		private DataItem<bool> CreateModeAllowedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000599")]
		private DataItem<bool> IsCursorActiveDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400059A")]
		private DataItem<bool> IsInSubMenuDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400059B")]
		private DataItemAction TriggerUndoDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400059C")]
		private DataItemAction TriggerRedoDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400059D")]
		private DataItemAction GoToSelectModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400059E")]
		private DataItemAction GoToCreateModeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400059F")]
		private DataItemAction EndCursorDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700021F")]
		private bool shouldFocus
		{
			[Cpp2IlInjected.Token(Token = "0x600085C")]
			[Cpp2IlInjected.Address(RVA = "0x82CCD40", Offset = "0x82CB740", VA = "0x1882CCD40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000220")]
		[BindableData(200, null, DataPermissions.ReadWrite)]
		public bool HasFocus
		{
			[Cpp2IlInjected.Token(Token = "0x600085D")]
			[Cpp2IlInjected.Address(RVA = "0x18DC6D0", Offset = "0x18DB0D0", VA = "0x1818DC6D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600085E")]
			[Cpp2IlInjected.Address(RVA = "0x82CC150", Offset = "0x82CAB50", VA = "0x1882CC150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000221")]
		[BindableData(201, null, DataPermissions.ReadWrite)]
		public float HoldInputProgress
		{
			[Cpp2IlInjected.Token(Token = "0x600085F")]
			[Cpp2IlInjected.Address(RVA = "0x1A53260", Offset = "0x1A51C60", VA = "0x181A53260")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000860")]
			[Cpp2IlInjected.Address(RVA = "0x82CC2B0", Offset = "0x82CACB0", VA = "0x1882CC2B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000222")]
		[BindableData(202, null, DataPermissions.ReadWrite)]
		public bool ShowHoldIndicator
		{
			[Cpp2IlInjected.Token(Token = "0x6000861")]
			[Cpp2IlInjected.Address(RVA = "0xD54F60", Offset = "0xD53960", VA = "0x180D54F60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000862")]
			[Cpp2IlInjected.Address(RVA = "0x82CC310", Offset = "0x82CAD10", VA = "0x1882CC310")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000223")]
		[BindableData(7, "Is Undo Allowed", DataPermissions.ReadOnly)]
		public bool IsUndoAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x600086B")]
			[Cpp2IlInjected.Address(RVA = "0x82CC370", Offset = "0x82CAD70", VA = "0x1882CC370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000224")]
		[BindableData(8, "Is Redo Allowed", DataPermissions.ReadOnly)]
		public bool IsRedoAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x600086C")]
			[Cpp2IlInjected.Address(RVA = "0x82CC3C0", Offset = "0x82CADC0", VA = "0x1882CC3C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000225")]
		[BindableData(14, null, DataPermissions.ReadWrite)]
		public bool UndoModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x600086D")]
			[Cpp2IlInjected.Address(RVA = "0xFD8E80", Offset = "0xFD7880", VA = "0x180FD8E80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600086E")]
			[Cpp2IlInjected.Address(RVA = "0x82CC410", Offset = "0x82CAE10", VA = "0x1882CC410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000226")]
		[BindableData(15, null, DataPermissions.ReadWrite)]
		public bool RedoModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x600086F")]
			[Cpp2IlInjected.Address(RVA = "0xFD8E90", Offset = "0xFD7890", VA = "0x180FD8E90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000870")]
			[Cpp2IlInjected.Address(RVA = "0x82CBF30", Offset = "0x82CA930", VA = "0x1882CBF30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000227")]
		[BindableData(5, "OnSelectMode", DataPermissions.ReadOnly)]
		public bool OnSelectMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000873")]
			[Cpp2IlInjected.Address(RVA = "0x82CBF90", Offset = "0x82CA990", VA = "0x1882CBF90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000228")]
		[BindableData(6, "OnCreateMode", DataPermissions.ReadOnly)]
		public bool OnCreateMode
		{
			[Cpp2IlInjected.Token(Token = "0x6000874")]
			[Cpp2IlInjected.Address(RVA = "0x82CBFE0", Offset = "0x82CA9E0", VA = "0x1882CBFE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000229")]
		[BindableData(12, null, DataPermissions.ReadWrite)]
		public bool SelectModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x6000875")]
			[Cpp2IlInjected.Address(RVA = "0x167D800", Offset = "0x167C200", VA = "0x18167D800")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000876")]
			[Cpp2IlInjected.Address(RVA = "0x82CC030", Offset = "0x82CAA30", VA = "0x1882CC030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022A")]
		[BindableData(13, null, DataPermissions.ReadWrite)]
		public bool CreateModeFocused
		{
			[Cpp2IlInjected.Token(Token = "0x6000877")]
			[Cpp2IlInjected.Address(RVA = "0xD84B50", Offset = "0xD83550", VA = "0x180D84B50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000878")]
			[Cpp2IlInjected.Address(RVA = "0x82CC090", Offset = "0x82CAA90", VA = "0x1882CC090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022B")]
		[BindableData(16, null, DataPermissions.ReadWrite)]
		public bool SelectModeAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x6000879")]
			[Cpp2IlInjected.Address(RVA = "0xD8DDF0", Offset = "0xD8C7F0", VA = "0x180D8DDF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600087A")]
			[Cpp2IlInjected.Address(RVA = "0x82CC0F0", Offset = "0x82CAAF0", VA = "0x1882CC0F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022C")]
		[BindableData(17, null, DataPermissions.ReadWrite)]
		public bool CreateModeAllowed
		{
			[Cpp2IlInjected.Token(Token = "0x600087B")]
			[Cpp2IlInjected.Address(RVA = "0x77F4E70", Offset = "0x77F3870", VA = "0x1877F4E70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600087C")]
			[Cpp2IlInjected.Address(RVA = "0x82CC1B0", Offset = "0x82CABB0", VA = "0x1882CC1B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022D")]
		[BindableData(9, "Is Cursor Active", DataPermissions.ReadOnly)]
		public bool IsCursorActive
		{
			[Cpp2IlInjected.Token(Token = "0x600087F")]
			[Cpp2IlInjected.Address(RVA = "0x82CC210", Offset = "0x82CAC10", VA = "0x1882CC210")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022E")]
		[BindableData(11, "Is In Sub Menu", DataPermissions.ReadOnly)]
		public bool IsInSubMenu
		{
			[Cpp2IlInjected.Token(Token = "0x6000882")]
			[Cpp2IlInjected.Address(RVA = "0x82CC260", Offset = "0x82CAC60", VA = "0x1882CC260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700022F")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000886")]
			[Cpp2IlInjected.Address(RVA = "0x82CCD00", Offset = "0x82CB700", VA = "0x1882CCD00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000230")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000887")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0x82CB7A0", Offset = "0x82CA1A0", VA = "0x1882CB7A0")]
		private void OnNavInputStateChanged(MakerPenHUDNavigationInputState.NavInputState state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0x82CC560", Offset = "0x82CAF60", VA = "0x1882CC560")]
		private void UpdateInputState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000865")]
		[Cpp2IlInjected.Address(RVA = "0x82C9620", Offset = "0x82C8020", VA = "0x1882C9620", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000866")]
		[Cpp2IlInjected.Address(RVA = "0x82CB2F0", Offset = "0x82C9CF0", VA = "0x1882CB2F0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0x82CBEB0", Offset = "0x82CA8B0", VA = "0x1882CBEB0")]
		[BindableAction(3, "Press Undo button")]
		public void TriggerUndo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000868")]
		[Cpp2IlInjected.Address(RVA = "0x82CBE30", Offset = "0x82CA830", VA = "0x1882CBE30")]
		[BindableAction(4, "Press Redo button")]
		public void TriggerRedo()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000869")]
		[Cpp2IlInjected.Address(RVA = "0x82CC780", Offset = "0x82CB180", VA = "0x1882CC780")]
		private void UpdateUndoStackData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600086A")]
		[Cpp2IlInjected.Address(RVA = "0x82C9C30", Offset = "0x82C8630", VA = "0x1882C9C30")]
		private void FocusCurrentMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000871")]
		[Cpp2IlInjected.Address(RVA = "0x82CA140", Offset = "0x82C8B40", VA = "0x1882CA140")]
		[BindableAction(1, "Press Select button")]
		public void GoToSelectMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000872")]
		[Cpp2IlInjected.Address(RVA = "0x82CA090", Offset = "0x82C8A90", VA = "0x1882CA090")]
		[BindableAction(2, "Press Create button")]
		public void GoToCreateMode()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x82CB290", Offset = "0x82C9C90", VA = "0x1882CB290")]
		private void OnCurrentModeChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x82CC470", Offset = "0x82CAE70", VA = "0x1882CC470")]
		private void UpdateCuratedControls()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x82CC510", Offset = "0x82CAF10", VA = "0x1882CC510")]
		private void UpdateCursorActive(bool isCursorActive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x82C9BE0", Offset = "0x82C85E0", VA = "0x1882C9BE0")]
		[BindableAction(10, "Button to request exiting cursor mode")]
		public void EndCursor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000883")]
		[Cpp2IlInjected.Address(RVA = "0x82CC740", Offset = "0x82CB140", VA = "0x1882CC740")]
		private void UpdateSubMenuActive(bool isInSubMenu)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x82CBBB0", Offset = "0x82CA5B0", VA = "0x1882CBBB0")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000885")]
		[Cpp2IlInjected.Address(RVA = "0x82CB170", Offset = "0x82C9B70", VA = "0x1882CB170")]
		private void LogClick(string buttonName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0x82CA1F0", Offset = "0x82C8BF0", VA = "0x1882CA1F0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x82C9D50", Offset = "0x82C8750", VA = "0x1882C9D50")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x82CC7E0", Offset = "0x82CB1E0", VA = "0x1882CC7E0")]
		public MakerPenHUDViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000CF")]
	[ViewModel]
	public class NestedItem : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005A0")]
		[SerializeField]
		private NestedListConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005A1")]
		private int absoluteIdx;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005A2")]
		private NestedListItem item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005A3")]
		private string text;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005A4")]
		private bool isExpanded;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005A5")]
		private Sprite activeIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005A6")]
		private int depth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005A7")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005A8")]
		private DataItem<string> TextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005A9")]
		private DataItem<bool> IsExpandedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40005AA")]
		private DataItem<Sprite> ActiveIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40005AB")]
		private DataItem<int> DepthDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40005AC")]
		private DataItemAction ToggleExpandedDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000231")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60008A3")]
			[Cpp2IlInjected.Address(RVA = "0x82CD9B0", Offset = "0x82CC3B0", VA = "0x1882CD9B0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000232")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string Text
		{
			[Cpp2IlInjected.Token(Token = "0x60008A4")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B30", Offset = "0xAB6530", VA = "0x180AB7B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008A5")]
			[Cpp2IlInjected.Address(RVA = "0x82CD630", Offset = "0x82CC030", VA = "0x1882CD630")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000233")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool IsExpanded
		{
			[Cpp2IlInjected.Token(Token = "0x60008A6")]
			[Cpp2IlInjected.Address(RVA = "0xD54F60", Offset = "0xD53960", VA = "0x180D54F60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A7")]
			[Cpp2IlInjected.Address(RVA = "0x82CD6A0", Offset = "0x82CC0A0", VA = "0x1882CD6A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000234")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public Sprite ActiveIcon
		{
			[Cpp2IlInjected.Token(Token = "0x60008A9")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6550", VA = "0x180AB7B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008AA")]
			[Cpp2IlInjected.Address(RVA = "0x82CDA30", Offset = "0x82CC430", VA = "0x1882CDA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000235")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public int Depth
		{
			[Cpp2IlInjected.Token(Token = "0x60008AB")]
			[Cpp2IlInjected.Address(RVA = "0xAB7C20", Offset = "0xAB6620", VA = "0x180AB7C20")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008AC")]
			[Cpp2IlInjected.Address(RVA = "0x82CD710", Offset = "0x82CC110", VA = "0x1882CD710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000236")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60008AE")]
			[Cpp2IlInjected.Address(RVA = "0x82CD970", Offset = "0x82CC370", VA = "0x1882CD970", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000237")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60008AF")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0x82CD5E0", Offset = "0x82CBFE0", VA = "0x1882CD5E0")]
		[BindableAction(2, null)]
		public void ToggleExpanded()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x82CD440", Offset = "0x82CBE40", VA = "0x1882CD440")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0x82CCF40", Offset = "0x82CB940", VA = "0x1882CCF40", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x82CCE00", Offset = "0x82CB800", VA = "0x1882CCE00")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008B2")]
		[Cpp2IlInjected.Address(RVA = "0x82CD770", Offset = "0x82CC170", VA = "0x1882CD770")]
		public NestedItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D0")]
	[ViewModel]
	public class NestedList : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005AD")]
		[SerializeField]
		private NestedListConfig config;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005AE")]
		private DataList<int> activeIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005AF")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B0")]
		private DataItemList ActiveIndicesDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000238")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<int> ActiveIndices
		{
			[Cpp2IlInjected.Token(Token = "0x60008BB")]
			[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008BC")]
			[Cpp2IlInjected.Address(RVA = "0x82CE190", Offset = "0x82CCB90", VA = "0x1882CE190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000239")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60008C0")]
			[Cpp2IlInjected.Address(RVA = "0x82CE160", Offset = "0x82CCB60", VA = "0x1882CE160", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023A")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60008C1")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008BD")]
		[Cpp2IlInjected.Address(RVA = "0x82CDAE0", Offset = "0x82CC4E0", VA = "0x1882CDAE0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BE")]
		[Cpp2IlInjected.Address(RVA = "0x82CDE30", Offset = "0x82CC830", VA = "0x1882CDE30", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008BF")]
		[Cpp2IlInjected.Address(RVA = "0x82CDF40", Offset = "0x82CC940", VA = "0x1882CDF40")]
		private void OnIndexStateChanged(int idx)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x82CDCE0", Offset = "0x82CC6E0", VA = "0x1882CDCE0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x82CDC30", Offset = "0x82CC630", VA = "0x1882CDC30")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x82CE080", Offset = "0x82CCA80", VA = "0x1882CE080")]
		public NestedList()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D1")]
	[ViewModel]
	public class OutfitListViewModel : RRUIBaseLocalViewModel
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000D2")]
		[CompilerGenerated]
		private struct <FetchOutfitData>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40005C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40005C6")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40005C7")]
			public OutfitListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40005C8")]
			private TaskAwaiter<List<ABLACFOHHEB>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40005C9")]
			private TaskAwaiter<RenderTexture> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40005CA")]
			private TaskAwaiter<int> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x60008E2")]
			[Cpp2IlInjected.Address(RVA = "0x82D4840", Offset = "0x82D3240", VA = "0x1882D4840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008E3")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005B1")]
		[SerializeField]
		private int maxOutfitDisplayCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40005B2")]
		[SerializeField]
		private bool generateOutfitTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005B3")]
		[SerializeField]
		private Route customizationRoute;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005B4")]
		[SerializeField]
		private int renderTextureWidth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40005B5")]
		[SerializeField]
		private int renderTextureHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005B6")]
		[SerializeField]
		private DataResolver currentPanelResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005B7")]
		private DataList<ABLACFOHHEB> savedOutfitList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005B8")]
		private bool isEmpty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005B9")]
		private DataList<int> saveOutfitSlotList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005BA")]
		private RenderTexture outfitTexture;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005BB")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005BC")]
		private IOutfitDataManager outfitManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40005BD")]
		private string pageIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40005BE")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40005BF")]
		private DataItem<bool> IsEmptyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40005C0")]
		private DataItem<RenderTexture> OutfitTextureDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40005C1")]
		private DataItemList SavedOutfitListDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40005C2")]
		private DataItemList SaveOutfitSlotListDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40005C3")]
		private DataItemAction OpenCustomizerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40005C4")]
		private DataItemAction OpenSavedOutfitsPageDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700023B")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<ABLACFOHHEB> SavedOutfitList
		{
			[Cpp2IlInjected.Token(Token = "0x60008C7")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B40", Offset = "0xAB6540", VA = "0x180AB7B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008C8")]
			[Cpp2IlInjected.Address(RVA = "0x82CF970", Offset = "0x82CE370", VA = "0x1882CF970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023C")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x60008C9")]
			[Cpp2IlInjected.Address(RVA = "0xB341E0", Offset = "0xB32BE0", VA = "0x180B341E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008CA")]
			[Cpp2IlInjected.Address(RVA = "0x82CF290", Offset = "0x82CDC90", VA = "0x1882CF290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023D")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public DataList<int> SaveOutfitSlotList
		{
			[Cpp2IlInjected.Token(Token = "0x60008CB")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7C0", Offset = "0xB2E1C0", VA = "0x180B2F7C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008CC")]
			[Cpp2IlInjected.Address(RVA = "0x82CF900", Offset = "0x82CE300", VA = "0x1882CF900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023E")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public RenderTexture OutfitTexture
		{
			[Cpp2IlInjected.Token(Token = "0x60008CD")]
			[Cpp2IlInjected.Address(RVA = "0xAB7A80", Offset = "0xAB6480", VA = "0x180AB7A80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008CE")]
			[Cpp2IlInjected.Address(RVA = "0x82CF7E0", Offset = "0x82CE1E0", VA = "0x1882CF7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700023F")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60008D5")]
			[Cpp2IlInjected.Address(RVA = "0x82CF7A0", Offset = "0x82CE1A0", VA = "0x1882CF7A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000240")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60008D6")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0x82CF080", Offset = "0x82CDA80", VA = "0x1882CF080")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0x82CEC10", Offset = "0x82CD610", VA = "0x1882CEC10", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D1")]
		[Cpp2IlInjected.Address(RVA = "0x82CE970", Offset = "0x82CD370", VA = "0x1882CE970")]
		private void OnActivePanelChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D2")]
		[Cpp2IlInjected.Address(RVA = "0x82CE1F0", Offset = "0x82CCBF0", VA = "0x1882CE1F0")]
		[AsyncStateMachine(typeof(<FetchOutfitData>d__28))]
		private void FetchOutfitData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0x82CEE30", Offset = "0x82CD830", VA = "0x1882CEE30")]
		[BindableAction(100, null)]
		private void OpenCustomizer()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0x82CEF60", Offset = "0x82CD960", VA = "0x1882CEF60")]
		[BindableAction(101, null)]
		private void OpenSavedOutfitsPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0x82CE400", Offset = "0x82CCE00", VA = "0x1882CE400", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0x82CE2A0", Offset = "0x82CCCA0", VA = "0x1882CE2A0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0x82CF4A0", Offset = "0x82CDEA0", VA = "0x1882CF4A0")]
		public OutfitListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D3")]
	[ViewModel]
	public class OutfitViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005CB")]
		private string outfitThumbnailName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005CC")]
		private bool wearingOutfit;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005CD")]
		private IOutfitDataManager outfitManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005CE")]
		private ABLACFOHHEB savedOutfitData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005CF")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005D0")]
		private DataItem<string> OutfitThumbnailNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005D1")]
		private DataItem<bool> WearingOutfitDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005D2")]
		private DataItemAction ChangeOutfitDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000241")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string OutfitThumbnailName
		{
			[Cpp2IlInjected.Token(Token = "0x60008E4")]
			[Cpp2IlInjected.Address(RVA = "0xAB4850", Offset = "0xAB3250", VA = "0x180AB4850")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60008E5")]
			[Cpp2IlInjected.Address(RVA = "0x82D0340", Offset = "0x82CED40", VA = "0x1882D0340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000242")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public bool WearingOutfit
		{
			[Cpp2IlInjected.Token(Token = "0x60008E6")]
			[Cpp2IlInjected.Address(RVA = "0xB2F830", Offset = "0xB2E230", VA = "0x180B2F830")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60008E7")]
			[Cpp2IlInjected.Address(RVA = "0x82D03B0", Offset = "0x82CEDB0", VA = "0x1882D03B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000243")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60008E8")]
			[Cpp2IlInjected.Address(RVA = "0x82D05A0", Offset = "0x82CEFA0", VA = "0x1882D05A0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000244")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60008EC")]
			[Cpp2IlInjected.Address(RVA = "0x82D0560", Offset = "0x82CEF60", VA = "0x1882D0560", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000245")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60008ED")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0x82D0280", Offset = "0x82CEC80", VA = "0x1882D0280")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0x82CFF00", Offset = "0x82CE900", VA = "0x1882CFF00")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0x82CF9E0", Offset = "0x82CE3E0", VA = "0x1882CF9E0")]
		[BindableAction(100, null)]
		private void ChangeOutfit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0x82CFC00", Offset = "0x82CE600", VA = "0x1882CFC00", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0x82CFB10", Offset = "0x82CE510", VA = "0x1882CFB10")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0x82D0410", Offset = "0x82CEE10", VA = "0x1882D0410")]
		public OutfitViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[ViewModel]
	public class SaveOutfitButtonViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D3")]
		private IOutfitDataManager outfitManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D4")]
		private int slotIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005D5")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005D6")]
		private DataItem<int> SlotIndexDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005D7")]
		private DataItemAction SaveOutfitDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000246")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60008F5")]
			[Cpp2IlInjected.Address(RVA = "0x82D47C0", Offset = "0x82D31C0", VA = "0x1882D47C0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000247")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public int SlotIndex
		{
			[Cpp2IlInjected.Token(Token = "0x60008F6")]
			[Cpp2IlInjected.Address(RVA = "0xE40D50", Offset = "0xE3F750", VA = "0x180E40D50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60008F7")]
			[Cpp2IlInjected.Address(RVA = "0x82D4670", Offset = "0x82D3070", VA = "0x1882D4670")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000248")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60008FB")]
			[Cpp2IlInjected.Address(RVA = "0x82D4790", Offset = "0x82D3190", VA = "0x1882D4790", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000249")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60008FC")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0x82D4540", Offset = "0x82D2F40", VA = "0x1882D4540")]
		[BindableAction(100, null)]
		public void SaveOutfit()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0x82D40C0", Offset = "0x82D2AC0", VA = "0x1882D40C0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0x82D4450", Offset = "0x82D2E50", VA = "0x1882D4450")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FD")]
		[Cpp2IlInjected.Address(RVA = "0x82D4250", Offset = "0x82D2C50", VA = "0x1882D4250", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FE")]
		[Cpp2IlInjected.Address(RVA = "0x82D4190", Offset = "0x82D2B90", VA = "0x1882D4190")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FF")]
		[Cpp2IlInjected.Address(RVA = "0x82D46C0", Offset = "0x82D30C0", VA = "0x1882D46C0")]
		public SaveOutfitButtonViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D5")]
	[ViewModel]
	public class RoomiePersonalityQuizAnswerViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005D8")]
		private string _answerText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005D9")]
		private string _componentValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005DA")]
		private bool _isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005DB")]
		private RoomiePersonalityQuizQuestionViewModel _roomiePersonalityQuizQuestionViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005DC")]
		private QuizAnswer _quizAnswer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005DD")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005DE")]
		private DataItem<string> AnswerTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005DF")]
		private DataItem<string> ComponentValueDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005E0")]
		private DataItem<bool> IsSelectedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005E1")]
		private DataItemAction SelectDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700024A")]
		[BindableData(0, null, DataPermissions.ReadOnly)]
		public string AnswerText
		{
			[Cpp2IlInjected.Token(Token = "0x6000902")]
			[Cpp2IlInjected.Address(RVA = "0xAB4850", Offset = "0xAB3250", VA = "0x180AB4850")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000903")]
			[Cpp2IlInjected.Address(RVA = "0x82D1210", Offset = "0x82CFC10", VA = "0x1882D1210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024B")]
		[BindableData(1, null, DataPermissions.ReadOnly)]
		public string ComponentValue
		{
			[Cpp2IlInjected.Token(Token = "0x6000904")]
			[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000905")]
			[Cpp2IlInjected.Address(RVA = "0x82D1280", Offset = "0x82CFC80", VA = "0x1882D1280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024C")]
		[BindableData(2, null, DataPermissions.ReadOnly)]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6000906")]
			[Cpp2IlInjected.Address(RVA = "0xEC9A90", Offset = "0xEC8490", VA = "0x180EC9A90")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000907")]
			[Cpp2IlInjected.Address(RVA = "0x82D12F0", Offset = "0x82CFCF0", VA = "0x1882D12F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024D")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000908")]
			[Cpp2IlInjected.Address(RVA = "0x82D1190", Offset = "0x82CFB90", VA = "0x1882D1190", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024E")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600090E")]
			[Cpp2IlInjected.Address(RVA = "0x82D1150", Offset = "0x82CFB50", VA = "0x1882D1150", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700024F")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600090F")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0x82D0E40", Offset = "0x82CF840", VA = "0x1882D0E40")]
		[BindableAction(100, null)]
		public void Select()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0x82D0620", Offset = "0x82CF020", VA = "0x1882D0620", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0x82D0EA0", Offset = "0x82CF8A0", VA = "0x1882D0EA0")]
		private void UpdateDataItem(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0x82D0B70", Offset = "0x82CF570", VA = "0x1882D0B70")]
		private void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0x82D0680", Offset = "0x82CF080", VA = "0x1882D0680")]
		private void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0x82D0860", Offset = "0x82CF260", VA = "0x1882D0860", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000911")]
		[Cpp2IlInjected.Address(RVA = "0x82D0750", Offset = "0x82CF150", VA = "0x1882D0750")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0x82D0FF0", Offset = "0x82CF9F0", VA = "0x1882D0FF0")]
		public RoomiePersonalityQuizAnswerViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D6")]
	[ViewModel]
	public class RoomiePersonalityQuizQuestionViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40005E2")]
		private string _questionText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005E3")]
		private string _componentName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005E4")]
		private DataList<QuizAnswer> _answers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005E5")]
		private RoomiePersonalityQuizViewModel _roomiePersonalityQuizViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005E6")]
		private QuizQuestion _quizQuestion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005E7")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005E8")]
		private DataItem<string> QuestionTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005E9")]
		private DataItem<string> ComponentNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005EA")]
		private DataItemList AnswersDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000250")]
		[BindableData(0, null, DataPermissions.ReadOnly)]
		public string QuestionText
		{
			[Cpp2IlInjected.Token(Token = "0x6000916")]
			[Cpp2IlInjected.Address(RVA = "0xAB4850", Offset = "0xAB3250", VA = "0x180AB4850")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000917")]
			[Cpp2IlInjected.Address(RVA = "0x82D1F90", Offset = "0x82D0990", VA = "0x1882D1F90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000251")]
		[BindableData(1, null, DataPermissions.ReadOnly)]
		public string ComponentName
		{
			[Cpp2IlInjected.Token(Token = "0x6000918")]
			[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000919")]
			[Cpp2IlInjected.Address(RVA = "0x82D1F20", Offset = "0x82D0920", VA = "0x1882D1F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000252")]
		[BindableData(2, null, DataPermissions.ReadOnly)]
		public DataList<QuizAnswer> Answers
		{
			[Cpp2IlInjected.Token(Token = "0x600091A")]
			[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600091B")]
			[Cpp2IlInjected.Address(RVA = "0x82D1EC0", Offset = "0x82D08C0", VA = "0x1882D1EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000253")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x600091C")]
			[Cpp2IlInjected.Address(RVA = "0x82D1E40", Offset = "0x82D0840", VA = "0x1882D1E40", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000254")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000923")]
			[Cpp2IlInjected.Address(RVA = "0x82D1E00", Offset = "0x82D0800", VA = "0x1882D1E00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000255")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000924")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x82D1B00", Offset = "0x82D0500", VA = "0x1882D1B00")]
		public void Select(QuizAnswer quizAnswer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x82D1810", Offset = "0x82D0210", VA = "0x1882D1810")]
		public bool IsSelected(QuizAnswer quizAnswer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x82D1350", Offset = "0x82CFD50", VA = "0x1882D1350", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x82D1B40", Offset = "0x82D0540", VA = "0x1882D1B40")]
		private void UpdateDataItem(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x82D18D0", Offset = "0x82D02D0", VA = "0x1882D18D0")]
		private void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x82D13B0", Offset = "0x82CFDB0", VA = "0x1882D13B0")]
		private void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x82D15B0", Offset = "0x82CFFB0", VA = "0x1882D15B0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x82D14C0", Offset = "0x82CFEC0", VA = "0x1882D14C0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x82D1C90", Offset = "0x82D0690", VA = "0x1882D1C90")]
		public RoomiePersonalityQuizQuestionViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D7")]
	[ViewModel]
	public class RoomiePersonalityQuizViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40005EC")]
		private DataList<QuizQuestion> _questions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40005ED")]
		private bool _hasRespondedToAllQuestions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40005EE")]
		private string _personalityPrompt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40005EF")]
		private bool _shouldShowSkipButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40005F1")]
		private readonly Dictionary<QuizQuestion, QuizAnswer> _answersByQuestion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40005F2")]
		private IRoomiePersonality _roomiePersonality;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40005F3")]
		private IRoomieManager _roomieManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40005F4")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40005F5")]
		private DataItem<bool> HasRespondedToAllQuestionsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40005F6")]
		private DataItem<string> PersonalityPromptDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40005F7")]
		private DataItem<bool> ShouldShowSkipButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40005F8")]
		private DataItemList QuestionsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40005F9")]
		private DataItemAction DoneDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40005FA")]
		private DataItemAction CancelDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40005FB")]
		private DataItemAction SavePersonalityPromptDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40005FC")]
		private DataItemAction SkipDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000256")]
		public bool SuppressQuip
		{
			[Cpp2IlInjected.Token(Token = "0x600092B")]
			[Cpp2IlInjected.Address(RVA = "0xB041D0", Offset = "0xB02BD0", VA = "0x180B041D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600092C")]
			[Cpp2IlInjected.Address(RVA = "0xB04860", Offset = "0xB03260", VA = "0x180B04860")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000257")]
		[BindableData(0, null, DataPermissions.ReadOnly)]
		public DataList<QuizQuestion> Questions
		{
			[Cpp2IlInjected.Token(Token = "0x600092D")]
			[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600092E")]
			[Cpp2IlInjected.Address(RVA = "0x82D4000", Offset = "0x82D2A00", VA = "0x1882D4000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000258")]
		[BindableData(1, null, DataPermissions.ReadOnly)]
		public bool HasRespondedToAllQuestions
		{
			[Cpp2IlInjected.Token(Token = "0x600092F")]
			[Cpp2IlInjected.Address(RVA = "0xDB85A0", Offset = "0xDB6FA0", VA = "0x180DB85A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000930")]
			[Cpp2IlInjected.Address(RVA = "0x82D3FA0", Offset = "0x82D29A0", VA = "0x1882D3FA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000259")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string PersonalityPrompt
		{
			[Cpp2IlInjected.Token(Token = "0x6000931")]
			[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000932")]
			[Cpp2IlInjected.Address(RVA = "0x82D3AA0", Offset = "0x82D24A0", VA = "0x1882D3AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025A")]
		[BindableData(3, null, DataPermissions.ReadOnly)]
		public bool ShouldShowSkipButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000933")]
			[Cpp2IlInjected.Address(RVA = "0xD7DEA0", Offset = "0xD7C8A0", VA = "0x180D7DEA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000934")]
			[Cpp2IlInjected.Address(RVA = "0x82D4060", Offset = "0x82D2A60", VA = "0x1882D4060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025B")]
		public IReadOnlyDictionary<QuizQuestion, QuizAnswer> AnswersByQuestion
		{
			[Cpp2IlInjected.Token(Token = "0x600093B")]
			[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025C")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000943")]
			[Cpp2IlInjected.Address(RVA = "0x82D3EC0", Offset = "0x82D28C0", VA = "0x1882D3EC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025D")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000944")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action CompleteEvent
		{
			[Cpp2IlInjected.Token(Token = "0x6000939")]
			[Cpp2IlInjected.Address(RVA = "0x82D3E20", Offset = "0x82D2820", VA = "0x1882D3E20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600093A")]
			[Cpp2IlInjected.Address(RVA = "0x82D3F00", Offset = "0x82D2900", VA = "0x1882D3F00")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0x82D2290", Offset = "0x82D0C90", VA = "0x1882D2290")]
		[BindableAction(100, null)]
		public void Done()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0x82D2250", Offset = "0x82D0C50", VA = "0x1882D2250")]
		[BindableAction(101, null)]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0x82D3530", Offset = "0x82D1F30", VA = "0x1882D3530")]
		[BindableAction(102, null)]
		public void SavePersonalityPrompt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0x82D38F0", Offset = "0x82D22F0", VA = "0x1882D38F0")]
		[BindableAction(103, null)]
		public void Skip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0x82D3590", Offset = "0x82D1F90", VA = "0x1882D3590")]
		public void Select(QuizQuestion quizQuestion, QuizAnswer quizAnswer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0x82D2ED0", Offset = "0x82D18D0", VA = "0x1882D2ED0")]
		public bool IsSelected(QuizQuestion quizQuestion, QuizAnswer quizAnswer)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0x82D2000", Offset = "0x82D0A00", VA = "0x1882D2000", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0x82D2F80", Offset = "0x82D1980", VA = "0x1882D2F80", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0x82D3050", Offset = "0x82D1A50", VA = "0x1882D3050")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0x82D3080", Offset = "0x82D1A80", VA = "0x1882D3080")]
		private void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0x82D3060", Offset = "0x82D1A60", VA = "0x1882D3060")]
		private void OnPersonalityChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000945")]
		[Cpp2IlInjected.Address(RVA = "0x82D28F0", Offset = "0x82D12F0", VA = "0x1882D28F0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0x82D2750", Offset = "0x82D1150", VA = "0x1882D2750")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x82D3B10", Offset = "0x82D2510", VA = "0x1882D3B10")]
		public RoomiePersonalityQuizViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[ViewModel]
	public class RoomieUserFactsViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x20000DA")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass49_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400061F")]
			public RoomieUserFactsViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000620")]
			public ABPNHOCMFDB userFact;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000621")]
			public MessageDialogModel messageDialogModel;

			[Cpp2IlInjected.Token(Token = "0x6000983")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public <>c__DisplayClass49_0()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DC")]
		[CompilerGenerated]
		private struct <Delete>d__49 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000626")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000627")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000628")]
			public RoomieUserFactsViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000629")]
			public ABPNHOCMFDB userFact;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400062A")]
			private <>c__DisplayClass49_0 <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400062B")]
			private TaskAwaiter<MessageDialogModel> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000988")]
			[Cpp2IlInjected.Address(RVA = "0x82E9BB0", Offset = "0x82E85B0", VA = "0x1882E9BB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000989")]
			[Cpp2IlInjected.Address(RVA = "0x82EA2C0", Offset = "0x82E8CC0", VA = "0x1882EA2C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000DD")]
		[CompilerGenerated]
		private struct <Refresh>d__52 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400062C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400062D")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400062E")]
			public RoomieUserFactsViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400062F")]
			private TaskAwaiter<RoomieUserFactQueryData.IContext> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600098A")]
			[Cpp2IlInjected.Address(RVA = "0x82ECFF0", Offset = "0x82EB9F0", VA = "0x1882ECFF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600098B")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40005FD")]
		private static readonly string HasLocalPlayerSeenInfoBannerKey;

		[Cpp2IlInjected.Token(Token = "0x40005FE")]
		private static readonly string ShouldShowSectionOnSettingsPageKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40005FF")]
		[SerializeField]
		private VisibilityChecker visibilityChecker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000600")]
		[SerializeField]
		private RoomieUserFactQueryData roomieUserFactQueryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000601")]
		private RoomieUserFactQueryData _roomieUserFactQueryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000602")]
		private RoomieUserFactQueryData.IContext _roomieUserFactQueryDataContext;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000603")]
		private EIMOPKCOAGH _recNetAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000604")]
		private CNGDCLJNIFB _preferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000605")]
		private JLFIJNDEFBP _gameConfigsProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000606")]
		private IRRUIvNextBridge _RRUIvNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000607")]
		private IRoomieBridge _roomieBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000608")]
		private IRoomieQueryManager _roomieQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000609")]
		private DialogListModel _dialogListModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400060A")]
		private DataList<ABPNHOCMFDB> _userFacts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400060B")]
		private bool _hasNoUserFacts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
		[Cpp2IlInjected.Token(Token = "0x400060C")]
		private bool _hasNoUnfilteredUserFacts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
		[Cpp2IlInjected.Token(Token = "0x400060D")]
		private bool _shouldShowInfoBanner;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
		[Cpp2IlInjected.Token(Token = "0x400060E")]
		private bool _shouldShowSectionOnSettingsPage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400060F")]
		private bool _shouldUpdateUserKnowledge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000610")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000611")]
		private DataItem<string> SearchQueryDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000612")]
		private DataItem<bool> HasNoUserFactsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000613")]
		private DataItem<bool> HasNoUnfilteredUserFactsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000614")]
		private DataItem<RoomieUserFactSortType> SortDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000615")]
		private DataItem<bool> ShouldShowInfoBannerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000616")]
		private DataItem<bool> HasSearchQueryDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000617")]
		private DataItem<bool> ShouldShowSectionOnSettingsPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000618")]
		private DataItemList UserFactsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000619")]
		private DataItemAction ClearSearchQueryDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400061A")]
		private DataItemAction ShowSortDialogDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400061B")]
		private DataItemAction SetHasLocalPlayerSeenBannerDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400061C")]
		private DataItemAction DismissBannerDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700025E")]
		private RoomieUserFactQueryData RoomieUserFactQueryData
		{
			[Cpp2IlInjected.Token(Token = "0x600094D")]
			[Cpp2IlInjected.Address(RVA = "0x82E93E0", Offset = "0x82E7DE0", VA = "0x1882E93E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700025F")]
		[BindableData(0, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public DataList<ABPNHOCMFDB> UserFacts
		{
			[Cpp2IlInjected.Token(Token = "0x600094E")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7C0", Offset = "0xB2E1C0", VA = "0x180B2F7C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600094F")]
			[Cpp2IlInjected.Address(RVA = "0x82E95B0", Offset = "0x82E7FB0", VA = "0x1882E95B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000260")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string SearchQuery
		{
			[Cpp2IlInjected.Token(Token = "0x6000950")]
			[Cpp2IlInjected.Address(RVA = "0x82E8C40", Offset = "0x82E7640", VA = "0x1882E8C40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000951")]
			[Cpp2IlInjected.Address(RVA = "0x82E9470", Offset = "0x82E7E70", VA = "0x1882E9470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000261")]
		[BindableData(2, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool HasNoUserFacts
		{
			[Cpp2IlInjected.Token(Token = "0x6000952")]
			[Cpp2IlInjected.Address(RVA = "0xFEB740", Offset = "0xFEA140", VA = "0x180FEB740")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000953")]
			[Cpp2IlInjected.Address(RVA = "0x82E8DD0", Offset = "0x82E77D0", VA = "0x1882E8DD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000262")]
		[BindableData(3, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool HasNoUnfilteredUserFacts
		{
			[Cpp2IlInjected.Token(Token = "0x6000954")]
			[Cpp2IlInjected.Address(RVA = "0x1CC1B50", Offset = "0x1CC0550", VA = "0x181CC1B50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000955")]
			[Cpp2IlInjected.Address(RVA = "0x82E8E30", Offset = "0x82E7830", VA = "0x1882E8E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000263")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public RoomieUserFactSortType Sort
		{
			[Cpp2IlInjected.Token(Token = "0x6000956")]
			[Cpp2IlInjected.Address(RVA = "0x82E8E90", Offset = "0x82E7890", VA = "0x1882E8E90")]
			get
			{
				return default(RoomieUserFactSortType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000957")]
			[Cpp2IlInjected.Address(RVA = "0x82E9530", Offset = "0x82E7F30", VA = "0x1882E9530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000264")]
		[BindableData(5, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool ShouldShowInfoBanner
		{
			[Cpp2IlInjected.Token(Token = "0x6000958")]
			[Cpp2IlInjected.Address(RVA = "0x5986F70", Offset = "0x5985970", VA = "0x185986F70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000959")]
			[Cpp2IlInjected.Address(RVA = "0x82E8EC0", Offset = "0x82E78C0", VA = "0x1882E8EC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000265")]
		[BindableData(6, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool HasSearchQuery
		{
			[Cpp2IlInjected.Token(Token = "0x600095A")]
			[Cpp2IlInjected.Address(RVA = "0x82E8C60", Offset = "0x82E7660", VA = "0x1882E8C60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600095B")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000266")]
		[BindableData(7, null, DataPermissions.ReadWrite, Permissions = DataPermissions.ReadOnly)]
		public bool ShouldShowSectionOnSettingsPage
		{
			[Cpp2IlInjected.Token(Token = "0x600095C")]
			[Cpp2IlInjected.Address(RVA = "0x81764E0", Offset = "0x8174EE0", VA = "0x1881764E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600095D")]
			[Cpp2IlInjected.Address(RVA = "0x82E8C90", Offset = "0x82E7690", VA = "0x1882E8C90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000267")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000968")]
			[Cpp2IlInjected.Address(RVA = "0x82E93A0", Offset = "0x82E7DA0", VA = "0x1882E93A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000268")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000969")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600095E")]
		[Cpp2IlInjected.Address(RVA = "0x82E7620", Offset = "0x82E6020", VA = "0x1882E7620")]
		[BindableAction(100, null)]
		public void ClearSearchQuery()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095F")]
		[Cpp2IlInjected.Address(RVA = "0x82E89C0", Offset = "0x82E73C0", VA = "0x1882E89C0")]
		[BindableAction(101, null)]
		public void ShowSortDialog()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000960")]
		[Cpp2IlInjected.Address(RVA = "0x82E88C0", Offset = "0x82E72C0", VA = "0x1882E88C0")]
		[BindableAction(102, null)]
		public void SetHasLocalPlayerSeenBanner()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000961")]
		[Cpp2IlInjected.Address(RVA = "0x82E7880", Offset = "0x82E6280", VA = "0x1882E7880")]
		[BindableAction(103, null)]
		public void DismissBanner()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000962")]
		[Cpp2IlInjected.Address(RVA = "0x82E7780", Offset = "0x82E6180", VA = "0x1882E7780")]
		[AsyncStateMachine(typeof(<Delete>d__49))]
		public Task Delete(ABPNHOCMFDB userFact)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000963")]
		[Cpp2IlInjected.Address(RVA = "0x82E7360", Offset = "0x82E5D60", VA = "0x1882E7360", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000964")]
		[Cpp2IlInjected.Address(RVA = "0x82E8540", Offset = "0x82E6F40", VA = "0x1882E8540", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000965")]
		[Cpp2IlInjected.Address(RVA = "0x82E8810", Offset = "0x82E7210", VA = "0x1882E8810")]
		[AsyncStateMachine(typeof(<Refresh>d__52))]
		private void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000966")]
		[Cpp2IlInjected.Address(RVA = "0x82E7630", Offset = "0x82E6030", VA = "0x1882E7630")]
		private void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000967")]
		[Cpp2IlInjected.Address(RVA = "0x82E8600", Offset = "0x82E7000", VA = "0x1882E8600")]
		private void OnVisibilityChanged(bool isVisible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0x82E7B10", Offset = "0x82E6510", VA = "0x1882E7B10", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0x82E78E0", Offset = "0x82E62E0", VA = "0x1882E78E0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0x82E8FD0", Offset = "0x82E79D0", VA = "0x1882E8FD0")]
		public RoomieUserFactsViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DE")]
	[ViewModel]
	public class RoomieUserFactViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x4000630")]
		private static readonly DateTime InvalidDateTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000631")]
		private string _predicate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000632")]
		private string _object;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000633")]
		private string _emotion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000634")]
		private string _createdAt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000635")]
		private string _userFact;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000636")]
		private bool _isCreatedAtValid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000637")]
		private RoomieUserFactsViewModel _roomieUserFactsViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000638")]
		private ABPNHOCMFDB _userFactDto;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000639")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400063A")]
		private DataItem<string> PredicateDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400063B")]
		private DataItem<string> ObjectDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400063C")]
		private DataItem<string> EmotionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400063D")]
		private DataItem<string> CreatedAtDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400063E")]
		private DataItem<string> UserFactDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400063F")]
		private DataItem<bool> IsCreatedAtValidDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000640")]
		private DataItemAction DeleteDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000269")]
		[BindableData(0, null, DataPermissions.ReadOnly)]
		public string Predicate
		{
			[Cpp2IlInjected.Token(Token = "0x600098C")]
			[Cpp2IlInjected.Address(RVA = "0xAB4850", Offset = "0xAB3250", VA = "0x180AB4850")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600098D")]
			[Cpp2IlInjected.Address(RVA = "0x82E7270", Offset = "0x82E5C70", VA = "0x1882E7270")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026A")]
		[BindableData(1, null, DataPermissions.ReadOnly)]
		public string Object
		{
			[Cpp2IlInjected.Token(Token = "0x600098E")]
			[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600098F")]
			[Cpp2IlInjected.Address(RVA = "0x82E7200", Offset = "0x82E5C00", VA = "0x1882E7200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026B")]
		[BindableData(2, null, DataPermissions.ReadOnly)]
		public string Emotion
		{
			[Cpp2IlInjected.Token(Token = "0x6000990")]
			[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000991")]
			[Cpp2IlInjected.Address(RVA = "0x82E7130", Offset = "0x82E5B30", VA = "0x1882E7130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026C")]
		[BindableData(3, null, DataPermissions.ReadOnly)]
		public string CreatedAt
		{
			[Cpp2IlInjected.Token(Token = "0x6000992")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B30", Offset = "0xAB6530", VA = "0x180AB7B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000993")]
			[Cpp2IlInjected.Address(RVA = "0x82E70C0", Offset = "0x82E5AC0", VA = "0x1882E70C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026D")]
		[BindableData(4, null, DataPermissions.ReadOnly)]
		public string UserFact
		{
			[Cpp2IlInjected.Token(Token = "0x6000994")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B40", Offset = "0xAB6540", VA = "0x180AB7B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000995")]
			[Cpp2IlInjected.Address(RVA = "0x82E72E0", Offset = "0x82E5CE0", VA = "0x1882E72E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026E")]
		[BindableData(5, null, DataPermissions.ReadOnly)]
		public bool IsCreatedAtValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000996")]
			[Cpp2IlInjected.Address(RVA = "0xB341E0", Offset = "0xB32BE0", VA = "0x180B341E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000997")]
			[Cpp2IlInjected.Address(RVA = "0x82E71A0", Offset = "0x82E5BA0", VA = "0x1882E71A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700026F")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000998")]
			[Cpp2IlInjected.Address(RVA = "0x82E7040", Offset = "0x82E5A40", VA = "0x1882E7040", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000270")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x600099E")]
			[Cpp2IlInjected.Address(RVA = "0x82E7000", Offset = "0x82E5A00", VA = "0x1882E7000", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000271")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x600099F")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x82E5640", Offset = "0x82E4040", VA = "0x1882E5640")]
		[BindableAction(100, null)]
		public void Delete()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x82E53C0", Offset = "0x82E3DC0", VA = "0x1882E53C0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099B")]
		[Cpp2IlInjected.Address(RVA = "0x82E6310", Offset = "0x82E4D10", VA = "0x1882E6310")]
		private void UpdateDataItem(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099C")]
		[Cpp2IlInjected.Address(RVA = "0x82E5E00", Offset = "0x82E4800", VA = "0x1882E5E00")]
		private void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600099D")]
		[Cpp2IlInjected.Address(RVA = "0x82E5430", Offset = "0x82E3E30", VA = "0x1882E5430")]
		private void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x82E5910", Offset = "0x82E4310", VA = "0x1882E5910", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x82E5790", Offset = "0x82E4190", VA = "0x1882E5790")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x82E6DE0", Offset = "0x82E57E0", VA = "0x1882E6DE0")]
		public RoomieUserFactViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DF")]
	[ViewModel]
	public class RoomCategoryListViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x20000E0")]
		public enum Sources
		{
			[Cpp2IlInjected.Token(Token = "0x400064E")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400064F")]
			PageSource,
			[Cpp2IlInjected.Token(Token = "0x4000650")]
			CuratedList
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E1")]
		[CompilerGenerated]
		private struct <FetchData>d__25 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000651")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000652")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000653")]
			public RoomCategoryListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000654")]
			private TaskAwaiter<(IReadOnlyList<IEDAJAEIHMN> categories, string displayName)> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000655")]
			private TaskAwaiter<IReadOnlyList<IEDAJAEIHMN>> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60009BF")]
			[Cpp2IlInjected.Address(RVA = "0x82EAB60", Offset = "0x82E9560", VA = "0x1882EAB60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60009C0")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000641")]
		[SerializeField]
		private MKJBCDALEDO loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000642")]
		[SerializeField]
		private Sources source;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000643")]
		[SerializeField]
		private string sourceMetadata;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000644")]
		private string _discoverySectionId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000645")]
		private IRRUIvNextRoomCategoryBridge roomCategoryBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000646")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000647")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000648")]
		private DataList<IEDAJAEIHMN> roomCategoryList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000649")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400064A")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400064B")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400064C")]
		private DataItemList RoomCategoryListDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000272")]
		public MKJBCDALEDO LoadSceneSource
		{
			[Cpp2IlInjected.Token(Token = "0x60009AA")]
			[Cpp2IlInjected.Address(RVA = "0x82D69D0", Offset = "0x82D53D0", VA = "0x1882D69D0")]
			get
			{
				return default(MKJBCDALEDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000273")]
		public BrowserModel BrowserModel
		{
			[Cpp2IlInjected.Token(Token = "0x60009AB")]
			[Cpp2IlInjected.Address(RVA = "0x82D68E0", Offset = "0x82D52E0", VA = "0x1882D68E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000274")]
		public string DiscoverySectionId
		{
			[Cpp2IlInjected.Token(Token = "0x60009AC")]
			[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009AD")]
			[Cpp2IlInjected.Address(RVA = "0x82D69E0", Offset = "0x82D53E0", VA = "0x1882D69E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000275")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<IEDAJAEIHMN> RoomCategoryList
		{
			[Cpp2IlInjected.Token(Token = "0x60009AE")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7C0", Offset = "0xB2E1C0", VA = "0x180B2F7C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009AF")]
			[Cpp2IlInjected.Address(RVA = "0x82D6B10", Offset = "0x82D5510", VA = "0x1882D6B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000276")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60009B0")]
			[Cpp2IlInjected.Address(RVA = "0xAB7A80", Offset = "0xAB6480", VA = "0x180AB7A80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009B1")]
			[Cpp2IlInjected.Address(RVA = "0x82D6A90", Offset = "0x82D5490", VA = "0x1882D6A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000277")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60009B6")]
			[Cpp2IlInjected.Address(RVA = "0x82D6990", Offset = "0x82D5390", VA = "0x1882D6990", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000278")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60009B7")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009B2")]
		[Cpp2IlInjected.Address(RVA = "0x82D62E0", Offset = "0x82D4CE0", VA = "0x1882D62E0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B3")]
		[Cpp2IlInjected.Address(RVA = "0x82D6360", Offset = "0x82D4D60", VA = "0x1882D6360")]
		public void SetSourceData(string source, string sourceMetadata)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B4")]
		[Cpp2IlInjected.Address(RVA = "0x82D5F00", Offset = "0x82D4900", VA = "0x1882D5F00")]
		[AsyncStateMachine(typeof(<FetchData>d__25))]
		public void FetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B5")]
		[Cpp2IlInjected.Address(RVA = "0x82D6400", Offset = "0x82D4E00", VA = "0x1882D6400")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B8")]
		[Cpp2IlInjected.Address(RVA = "0x82D6080", Offset = "0x82D4A80", VA = "0x1882D6080", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009B9")]
		[Cpp2IlInjected.Address(RVA = "0x82D5FB0", Offset = "0x82D49B0", VA = "0x1882D5FB0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009BA")]
		[Cpp2IlInjected.Address(RVA = "0x82D6770", Offset = "0x82D5170", VA = "0x1882D6770")]
		public RoomCategoryListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E2")]
	[ViewModel]
	public class RoomCategoryViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000656")]
		[SerializeField]
		private Route searchRoomsroute;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000657")]
		[SerializeField]
		private Route gridViewRoute;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000658")]
		private IRRUIvNextRoomCategoryBridge roomCategoryBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000659")]
		private MKJBCDALEDO loadSceneSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400065A")]
		private IEDAJAEIHMN roomCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400065B")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400065C")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400065D")]
		private string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400065E")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400065F")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000660")]
		private DataItem<string> ImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000661")]
		private DataItemAction SelectRoomCategoryDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000279")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60009C1")]
			[Cpp2IlInjected.Address(RVA = "0x82D7790", Offset = "0x82D6190", VA = "0x1882D7790", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027A")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x60009C2")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7C0", Offset = "0xB2E1C0", VA = "0x180B2F7C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009C3")]
			[Cpp2IlInjected.Address(RVA = "0x82D7810", Offset = "0x82D6210", VA = "0x1882D7810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027B")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60009C4")]
			[Cpp2IlInjected.Address(RVA = "0xAB7A80", Offset = "0xAB6480", VA = "0x180AB7A80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009C5")]
			[Cpp2IlInjected.Address(RVA = "0x82D7890", Offset = "0x82D6290", VA = "0x1882D7890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027C")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60009CB")]
			[Cpp2IlInjected.Address(RVA = "0x82D7750", Offset = "0x82D6150", VA = "0x1882D7750", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027D")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60009CC")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009C6")]
		[Cpp2IlInjected.Address(RVA = "0x82D7100", Offset = "0x82D5B00", VA = "0x1882D7100")]
		[BindableAction(100, null)]
		public void SelectRoomCategory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C7")]
		[Cpp2IlInjected.Address(RVA = "0x82D6B80", Offset = "0x82D5580", VA = "0x1882D6B80", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C8")]
		[Cpp2IlInjected.Address(RVA = "0x82D7070", Offset = "0x82D5A70", VA = "0x1882D7070")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009C9")]
		[Cpp2IlInjected.Address(RVA = "0x82D7290", Offset = "0x82D5C90", VA = "0x1882D7290")]
		private void Set(IEDAJAEIHMN data)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CA")]
		[Cpp2IlInjected.Address(RVA = "0x82D74E0", Offset = "0x82D5EE0", VA = "0x1882D74E0")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CD")]
		[Cpp2IlInjected.Address(RVA = "0x82D6D90", Offset = "0x82D5790", VA = "0x1882D6D90", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CE")]
		[Cpp2IlInjected.Address(RVA = "0x82D6CA0", Offset = "0x82D56A0", VA = "0x1882D6CA0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009CF")]
		[Cpp2IlInjected.Address(RVA = "0x82D75F0", Offset = "0x82D5FF0", VA = "0x1882D75F0")]
		public RoomCategoryViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E3")]
	[ViewModel]
	public class RoomInventoryItemViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000662")]
		private IUnifiedRoomInventoryItem item;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000663")]
		private string itemName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000664")]
		private string itemImageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000665")]
		private bool hasImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000666")]
		private Sprite icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000667")]
		private Color iconColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000668")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000669")]
		private DataItem<string> ItemNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400066A")]
		private DataItem<string> ItemImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400066B")]
		private DataItem<bool> HasImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400066C")]
		private DataItem<Sprite> IconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400066D")]
		private DataItem<Color> IconColorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400066E")]
		private DataItemAction OpenItemDetailsDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700027E")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x60009D4")]
			[Cpp2IlInjected.Address(RVA = "0x82D8BE0", Offset = "0x82D75E0", VA = "0x1882D8BE0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700027F")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string ItemName
		{
			[Cpp2IlInjected.Token(Token = "0x60009D5")]
			[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009D6")]
			[Cpp2IlInjected.Address(RVA = "0x82D82D0", Offset = "0x82D6CD0", VA = "0x1882D82D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000280")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string ItemImageName
		{
			[Cpp2IlInjected.Token(Token = "0x60009D7")]
			[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009D8")]
			[Cpp2IlInjected.Address(RVA = "0x82D8340", Offset = "0x82D6D40", VA = "0x1882D8340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000281")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool HasImage
		{
			[Cpp2IlInjected.Token(Token = "0x60009DA")]
			[Cpp2IlInjected.Address(RVA = "0xDD49D0", Offset = "0xDD33D0", VA = "0x180DD49D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60009DB")]
			[Cpp2IlInjected.Address(RVA = "0x82D83B0", Offset = "0x82D6DB0", VA = "0x1882D83B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000282")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public Sprite Icon
		{
			[Cpp2IlInjected.Token(Token = "0x60009DC")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B40", Offset = "0xAB6540", VA = "0x180AB7B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60009DD")]
			[Cpp2IlInjected.Address(RVA = "0x82D8D20", Offset = "0x82D7720", VA = "0x1882D8D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000283")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public Color IconColor
		{
			[Cpp2IlInjected.Token(Token = "0x60009DE")]
			[Cpp2IlInjected.Address(RVA = "0x1D375E0", Offset = "0x1D35FE0", VA = "0x181D375E0")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x60009DF")]
			[Cpp2IlInjected.Address(RVA = "0x82D8C60", Offset = "0x82D7660", VA = "0x1882D8C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000284")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x60009E4")]
			[Cpp2IlInjected.Address(RVA = "0x82D8BA0", Offset = "0x82D75A0", VA = "0x1882D8BA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000285")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x60009E5")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60009D9")]
		[Cpp2IlInjected.Address(RVA = "0x82D8180", Offset = "0x82D6B80", VA = "0x1882D8180")]
		[BindableAction(2, null)]
		public void OpenItemDetails()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E0")]
		[Cpp2IlInjected.Address(RVA = "0x82D86B0", Offset = "0x82D70B0", VA = "0x1882D86B0")]
		private void UpdateItem(IUnifiedRoomInventoryItem newItem)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E1")]
		[Cpp2IlInjected.Address(RVA = "0x82D80E0", Offset = "0x82D6AE0", VA = "0x1882D80E0")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E2")]
		[Cpp2IlInjected.Address(RVA = "0x82D8440", Offset = "0x82D6E40", VA = "0x1882D8440")]
		private void UpdateImpressionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0x82D8050", Offset = "0x82D6A50", VA = "0x1882D8050")]
		private void LogClick(string buttonName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E6")]
		[Cpp2IlInjected.Address(RVA = "0x82D7A70", Offset = "0x82D6470", VA = "0x1882D7A70", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E7")]
		[Cpp2IlInjected.Address(RVA = "0x82D7910", Offset = "0x82D6310", VA = "0x1882D7910")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60009E8")]
		[Cpp2IlInjected.Address(RVA = "0x82D8940", Offset = "0x82D7340", VA = "0x1882D8940")]
		public RoomInventoryItemViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E4")]
	public class RoomCardFeatureHelper : BaseBindableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400066F")]
		private EEIOAMNMKPH loadSceneSourceData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000670")]
		private bool showCCUCounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000671")]
		private int pinnedRoomCCUThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000672")]
		private bool showPopularBadge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000673")]
		private int popularRoomCCUThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000674")]
		private bool showNewBadge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
		[Cpp2IlInjected.Token(Token = "0x4000675")]
		private bool showPlayActionButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA2")]
		[Cpp2IlInjected.Token(Token = "0x4000676")]
		private bool showMoreLikeThisButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA3")]
		[Cpp2IlInjected.Token(Token = "0x4000677")]
		private bool showUpdateToPlayIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000678")]
		private bool showUpdateToPlayText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA5")]
		[Cpp2IlInjected.Token(Token = "0x4000679")]
		private bool showNewThisSessionForSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400067A")]
		private string sessionSectionIdOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400067B")]
		private Guid? sectionSpawnInstanceId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400067C")]
		private string parentTabName;

		[Cpp2IlInjected.Token(Token = "0x17000286")]
		public EEIOAMNMKPH LoadSceneSourceData
		{
			[Cpp2IlInjected.Token(Token = "0x60009F3")]
			[Cpp2IlInjected.Address(RVA = "0x82D5950", Offset = "0x82D4350", VA = "0x1882D5950")]
			get
			{
				return default(EEIOAMNMKPH);
			}
			[Cpp2IlInjected.Token(Token = "0x60009F4")]
			[Cpp2IlInjected.Address(RVA = "0x82D5990", Offset = "0x82D4390", VA = "0x1882D5990")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000287")]
		public bool ShowCCUCounts
		{
			[Cpp2IlInjected.Token(Token = "0x60009F5")]
			[Cpp2IlInjected.Address(RVA = "0xADD9C0", Offset = "0xADC3C0", VA = "0x180ADD9C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60009F6")]
			[Cpp2IlInjected.Address(RVA = "0x82D5C60", Offset = "0x82D4660", VA = "0x1882D5C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000288")]
		public bool ShowPopularBadge
		{
			[Cpp2IlInjected.Token(Token = "0x60009F7")]
			[Cpp2IlInjected.Address(RVA = "0xFEB740", Offset = "0xFEA140", VA = "0x180FEB740")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60009F8")]
			[Cpp2IlInjected.Address(RVA = "0x82D5DE0", Offset = "0x82D47E0", VA = "0x1882D5DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000289")]
		public int PopularRoomCCUThreshold
		{
			[Cpp2IlInjected.Token(Token = "0x60009F9")]
			[Cpp2IlInjected.Address(RVA = "0xF68C80", Offset = "0xF67680", VA = "0x180F68C80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60009FA")]
			[Cpp2IlInjected.Address(RVA = "0x82D5AA0", Offset = "0x82D44A0", VA = "0x1882D5AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028A")]
		public bool ShowNewBadge
		{
			[Cpp2IlInjected.Token(Token = "0x60009FB")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7E0", Offset = "0xB2E1E0", VA = "0x180B2F7E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60009FC")]
			[Cpp2IlInjected.Address(RVA = "0x82D5CC0", Offset = "0x82D46C0", VA = "0x1882D5CC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028B")]
		public bool ShowPlayActionButton
		{
			[Cpp2IlInjected.Token(Token = "0x60009FD")]
			[Cpp2IlInjected.Address(RVA = "0xEE0210", Offset = "0xEDEC10", VA = "0x180EE0210")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60009FE")]
			[Cpp2IlInjected.Address(RVA = "0x82D5D80", Offset = "0x82D4780", VA = "0x1882D5D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028C")]
		public bool ShowMoreLikeThisButton
		{
			[Cpp2IlInjected.Token(Token = "0x60009FF")]
			[Cpp2IlInjected.Address(RVA = "0x792B950", Offset = "0x792A350", VA = "0x18792B950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028D")]
		public bool ShowUpdateToPlayIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000A00")]
			[Cpp2IlInjected.Address(RVA = "0x8271470", Offset = "0x826FE70", VA = "0x188271470")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A01")]
			[Cpp2IlInjected.Address(RVA = "0x82D5E40", Offset = "0x82D4840", VA = "0x1882D5E40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028E")]
		public bool ShowUpdateToPlayText
		{
			[Cpp2IlInjected.Token(Token = "0x6000A02")]
			[Cpp2IlInjected.Address(RVA = "0x104F250", Offset = "0x104DC50", VA = "0x18104F250")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A03")]
			[Cpp2IlInjected.Address(RVA = "0x82D5EA0", Offset = "0x82D48A0", VA = "0x1882D5EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700028F")]
		public bool ShowNewThisSessionForSection
		{
			[Cpp2IlInjected.Token(Token = "0x6000A04")]
			[Cpp2IlInjected.Address(RVA = "0x1AA8C00", Offset = "0x1AA7600", VA = "0x181AA8C00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A05")]
			[Cpp2IlInjected.Address(RVA = "0x82D5D20", Offset = "0x82D4720", VA = "0x1882D5D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000290")]
		public string SessionSectionIdOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000A06")]
			[Cpp2IlInjected.Address(RVA = "0xAB9520", Offset = "0xAB7F20", VA = "0x180AB9520")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A07")]
			[Cpp2IlInjected.Address(RVA = "0x82D5BE0", Offset = "0x82D45E0", VA = "0x1882D5BE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000291")]
		public Guid? SectionSpawnInstanceId
		{
			[Cpp2IlInjected.Token(Token = "0x6000A08")]
			[Cpp2IlInjected.Address(RVA = "0xAAC1F0", Offset = "0xAAABF0", VA = "0x180AAC1F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A09")]
			[Cpp2IlInjected.Address(RVA = "0x82D5B00", Offset = "0x82D4500", VA = "0x1882D5B00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000292")]
		public string ParentTabName
		{
			[Cpp2IlInjected.Token(Token = "0x6000A0A")]
			[Cpp2IlInjected.Address(RVA = "0xB795C0", Offset = "0xB77FC0", VA = "0x180B795C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A0B")]
			[Cpp2IlInjected.Address(RVA = "0x82D5A20", Offset = "0x82D4420", VA = "0x1882D5A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A0C")]
		[Cpp2IlInjected.Address(RVA = "0x82D5930", Offset = "0x82D4330", VA = "0x1882D5930")]
		public RoomCardFeatureHelper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E5")]
	[ViewModel]
	public class RoomListViewModel : RRUIBaseLocalViewModel, IOrderedRenderable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000E6")]
		[CompilerGenerated]
		private struct <FetchData>d__52 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000695")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000696")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000697")]
			public RoomListViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000698")]
			private TaskAwaiter<List<PPFENAOBDPL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000A3A")]
			[Cpp2IlInjected.Address(RVA = "0x82EB140", Offset = "0x82E9B40", VA = "0x1882EB140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000A3B")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400067D")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400067E")]
		[SerializeField]
		private RoomListQueryData queryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400067F")]
		[SerializeField]
		private bool overrideLoadSceneSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000680")]
		[SerializeField]
		private MKJBCDALEDO loadSceneSourceOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000681")]
		private IRoomQueryManager roomListQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000682")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000683")]
		private bool waitingForQuery;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000684")]
		private List<long> tempIdList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000685")]
		private int minItemCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000686")]
		private bool fetchCCUCounts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000687")]
		private DataList<long> roomIdList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000688")]
		private string listDisplayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000689")]
		private bool isEmptyOrBelowMinimum;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400068A")]
		private RoomCardFeatureHelper featureHelper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400068F")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000690")]
		private DataItem<string> ListDisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000691")]
		private DataItem<bool> IsEmptyOrBelowMinimumDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000692")]
		private DataItem<RoomListQueryData> QueryDataDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000693")]
		private DataItem<RoomCardFeatureHelper> FeatureHelperDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000694")]
		private DataItemList RoomIdListDataItem;

		[Cpp2IlInjected.Token(Token = "0x17000293")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<long> RoomIdList
		{
			[Cpp2IlInjected.Token(Token = "0x6000A0D")]
			[Cpp2IlInjected.Address(RVA = "0xB79620", Offset = "0xB78020", VA = "0x180B79620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A0E")]
			[Cpp2IlInjected.Address(RVA = "0x82DB040", Offset = "0x82D9A40", VA = "0x1882DB040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000294")]
		[BindableData(1, "The name of the list that can be shown on the UI, e.g. as a carousel title", DataPermissions.ReadWrite)]
		public string ListDisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000A0F")]
			[Cpp2IlInjected.Address(RVA = "0xAB9520", Offset = "0xAB7F20", VA = "0x180AB9520")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A10")]
			[Cpp2IlInjected.Address(RVA = "0x82DAFC0", Offset = "0x82D99C0", VA = "0x1882DAFC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000295")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public bool IsEmptyOrBelowMinimum
		{
			[Cpp2IlInjected.Token(Token = "0x6000A11")]
			[Cpp2IlInjected.Address(RVA = "0xC5E0D0", Offset = "0xC5CAD0", VA = "0x180C5E0D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A12")]
			[Cpp2IlInjected.Address(RVA = "0x82DAAB0", Offset = "0x82D94B0", VA = "0x1882DAAB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000296")]
		[BindableData(3, "The query data used to retrieve the room list", DataPermissions.ReadOnly)]
		public RoomListQueryData QueryData
		{
			[Cpp2IlInjected.Token(Token = "0x6000A13")]
			[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000297")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public RoomCardFeatureHelper FeatureHelper
		{
			[Cpp2IlInjected.Token(Token = "0x6000A14")]
			[Cpp2IlInjected.Address(RVA = "0xEE2960", Offset = "0xEE1360", VA = "0x180EE2960")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A15")]
			[Cpp2IlInjected.Address(RVA = "0x82DAB10", Offset = "0x82D9510", VA = "0x1882DAB10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000298")]
		public bool RenderInCarouselOrder
		{
			[Cpp2IlInjected.Token(Token = "0x6000A16")]
			[Cpp2IlInjected.Address(RVA = "0x10E8B30", Offset = "0x10E7530", VA = "0x1810E8B30", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A17")]
			[Cpp2IlInjected.Address(RVA = "0xD75210", Offset = "0xD73C10", VA = "0x180D75210", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000299")]
		public bool AllowRender
		{
			[Cpp2IlInjected.Token(Token = "0x6000A18")]
			[Cpp2IlInjected.Address(RVA = "0x10E8CC0", Offset = "0x10E76C0", VA = "0x1810E8CC0", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A19")]
			[Cpp2IlInjected.Address(RVA = "0xD75220", Offset = "0xD73C20", VA = "0x180D75220", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029A")]
		public bool HasRefreshed
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1A")]
			[Cpp2IlInjected.Address(RVA = "0x229C130", Offset = "0x229AB30", VA = "0x18229C130", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A1B")]
			[Cpp2IlInjected.Address(RVA = "0xD75230", Offset = "0xD73C30", VA = "0x180D75230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029B")]
		public bool RequiresRefresh
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1C")]
			[Cpp2IlInjected.Address(RVA = "0x229BD00", Offset = "0x229A700", VA = "0x18229BD00", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A1D")]
			[Cpp2IlInjected.Address(RVA = "0x2298120", Offset = "0x2296B20", VA = "0x182298120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029C")]
		public bool OverrideLoadSceneSource
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1E")]
			[Cpp2IlInjected.Address(RVA = "0xEC9A90", Offset = "0xEC8490", VA = "0x180EC9A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029D")]
		public MKJBCDALEDO LoadSceneSourceOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000A1F")]
			[Cpp2IlInjected.Address(RVA = "0xAD4AD0", Offset = "0xAD34D0", VA = "0x180AD4AD0")]
			get
			{
				return default(MKJBCDALEDO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029E")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2C")]
			[Cpp2IlInjected.Address(RVA = "0x82DAF80", Offset = "0x82D9980", VA = "0x1882DAF80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700029F")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000A2D")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A20")]
		[Cpp2IlInjected.Address(RVA = "0x82DA900", Offset = "0x82D9300", VA = "0x1882DA900")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A21")]
		[Cpp2IlInjected.Address(RVA = "0x82D96A0", Offset = "0x82D80A0", VA = "0x1882D96A0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A22")]
		[Cpp2IlInjected.Address(RVA = "0x82DA150", Offset = "0x82D8B50", VA = "0x1882DA150")]
		public void SetQueryData(RoomListQueryData listQueryData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A23")]
		[Cpp2IlInjected.Address(RVA = "0x82DA010", Offset = "0x82D8A10", VA = "0x1882DA010")]
		public void SetDiscoverySectionId(string sectionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A24")]
		[Cpp2IlInjected.Address(RVA = "0x82D8DD0", Offset = "0x82D77D0", VA = "0x1882D8DD0")]
		[AsyncStateMachine(typeof(<FetchData>d__52))]
		public void FetchData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A25")]
		[Cpp2IlInjected.Address(RVA = "0x82DA0C0", Offset = "0x82D8AC0", VA = "0x1882DA0C0")]
		public void SetMaxItems(int maxItemsToFetch, int maxItemsToDisplay)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A26")]
		[Cpp2IlInjected.Address(RVA = "0x82DA120", Offset = "0x82D8B20", VA = "0x1882DA120")]
		public void SetMinItems(int minItems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A27")]
		[Cpp2IlInjected.Address(RVA = "0x82D9810", Offset = "0x82D8210", VA = "0x1882D9810")]
		private void PopulateLoadSceneSourceData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A28")]
		[Cpp2IlInjected.Address(RVA = "0x82D9DA0", Offset = "0x82D87A0", VA = "0x1882D9DA0")]
		private string ResolveDisplayName()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A29")]
		[Cpp2IlInjected.Address(RVA = "0x10E8CC0", Offset = "0x10E76C0", VA = "0x1810E8CC0")]
		private bool WaitUntilAllowRender()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2A")]
		[Cpp2IlInjected.Address(RVA = "0x82DA210", Offset = "0x82D8C10", VA = "0x1882DA210")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2B")]
		[Cpp2IlInjected.Address(RVA = "0x82D9570", Offset = "0x82D7F70", VA = "0x1882D9570")]
		private void OnChildImpressionTrackerAdded(ImpressionTracker child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2E")]
		[Cpp2IlInjected.Address(RVA = "0x82D8FC0", Offset = "0x82D79C0", VA = "0x1882D8FC0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A2F")]
		[Cpp2IlInjected.Address(RVA = "0x82D8E80", Offset = "0x82D7880", VA = "0x1882D8E80")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A30")]
		[Cpp2IlInjected.Address(RVA = "0x82DAC50", Offset = "0x82D9650", VA = "0x1882DAC50")]
		public RoomListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E7")]
	[ViewModel]
	public class RoomStoreCategoryListViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000699")]
		private IRRUIvNextRoomStoreBridge _roomStoreBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400069A")]
		private BrowserModel _browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400069B")]
		private bool _isSubscribed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400069C")]
		private IRoomStoreCategory _selectedCategory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400069D")]
		private DataList<IRoomStoreCategory> categoryList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400069E")]
		private DataList<IUnifiedRoomStoreItem> _selectedCategoryItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400069F")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40006A0")]
		private DataItemList CategoryListDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40006A1")]
		private DataItemList SelectedCategoryItemsDataItem;

		[Cpp2IlInjected.Token(Token = "0x170002A0")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public DataList<IRoomStoreCategory> CategoryList
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3C")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B40", Offset = "0xAB6540", VA = "0x180AB7B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A3D")]
			[Cpp2IlInjected.Address(RVA = "0x82DC8C0", Offset = "0x82DB2C0", VA = "0x1882DC8C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A1")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public DataList<IUnifiedRoomStoreItem> SelectedCategoryItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000A3E")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6550", VA = "0x180AB7B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A3F")]
			[Cpp2IlInjected.Address(RVA = "0x82DC930", Offset = "0x82DB330", VA = "0x1882DC930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A2")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000A49")]
			[Cpp2IlInjected.Address(RVA = "0x82DC880", Offset = "0x82DB280", VA = "0x1882DC880", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A3")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000A4A")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A40")]
		[Cpp2IlInjected.Address(RVA = "0x82DB0B0", Offset = "0x82D9AB0", VA = "0x1882DB0B0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A41")]
		[Cpp2IlInjected.Address(RVA = "0x82DC1B0", Offset = "0x82DABB0", VA = "0x1882DC1B0")]
		private void SubscribeToStoreChanges()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A42")]
		[Cpp2IlInjected.Address(RVA = "0x82DB730", Offset = "0x82DA130", VA = "0x1882DB730")]
		private void LoadSelectedCategory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A43")]
		[Cpp2IlInjected.Address(RVA = "0x82DBEC0", Offset = "0x82DA8C0", VA = "0x1882DBEC0")]
		private void OnResetSelectedCategory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A44")]
		[Cpp2IlInjected.Address(RVA = "0x82DB5A0", Offset = "0x82D9FA0", VA = "0x1882DB5A0")]
		private void LoadCategories()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A45")]
		[Cpp2IlInjected.Address(RVA = "0x82DBD40", Offset = "0x82DA740", VA = "0x1882DBD40", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A46")]
		[Cpp2IlInjected.Address(RVA = "0x82DBF70", Offset = "0x82DA970", VA = "0x1882DBF70")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A47")]
		[Cpp2IlInjected.Address(RVA = "0x82DBCC0", Offset = "0x82DA6C0", VA = "0x1882DBCC0")]
		private void LogImpressionsBeforeCategoryChange()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A48")]
		[Cpp2IlInjected.Address(RVA = "0x82DC560", Offset = "0x82DAF60", VA = "0x1882DC560")]
		private void UpdateImpressionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4B")]
		[Cpp2IlInjected.Address(RVA = "0x82DB370", Offset = "0x82D9D70", VA = "0x1882DB370", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4C")]
		[Cpp2IlInjected.Address(RVA = "0x82DB2A0", Offset = "0x82D9CA0", VA = "0x1882DB2A0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A4D")]
		[Cpp2IlInjected.Address(RVA = "0x82DC6F0", Offset = "0x82DB0F0", VA = "0x1882DC6F0")]
		public RoomStoreCategoryListViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[ViewModel]
	public class RoomStoreCategoryViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006A4")]
		private string itemName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006A5")]
		private Sprite icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006A6")]
		private DataList<IUnifiedRoomStoreItem> items;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006A7")]
		private bool isSelected;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006A8")]
		private IRRUIvNextRoomStoreBridge roomStoreBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006A9")]
		private IRoomStoreCategory categoryData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006AA")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40006AB")]
		private DataItem<string> ItemNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40006AC")]
		private DataItem<Sprite> IconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40006AD")]
		private DataItem<bool> IsSelectedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40006AE")]
		private DataItemList ItemsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40006AF")]
		private DataItemAction SelectCategoryDataItem;

		[Cpp2IlInjected.Token(Token = "0x170002A4")]
		[BindableData(0, "The name of the category", DataPermissions.ReadOnly)]
		public string ItemName
		{
			[Cpp2IlInjected.Token(Token = "0x6000A55")]
			[Cpp2IlInjected.Address(RVA = "0xAB4850", Offset = "0xAB3250", VA = "0x180AB4850")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A56")]
			[Cpp2IlInjected.Address(RVA = "0x82DDA60", Offset = "0x82DC460", VA = "0x1882DDA60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A5")]
		[BindableData(1, "The icon for the category", DataPermissions.ReadOnly)]
		public Sprite Icon
		{
			[Cpp2IlInjected.Token(Token = "0x6000A57")]
			[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A58")]
			[Cpp2IlInjected.Address(RVA = "0x82DD960", Offset = "0x82DC360", VA = "0x1882DD960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A6")]
		[BindableData(2, "The items in this category", DataPermissions.ReadOnly)]
		public DataList<IUnifiedRoomStoreItem> Items
		{
			[Cpp2IlInjected.Token(Token = "0x6000A59")]
			[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A5A")]
			[Cpp2IlInjected.Address(RVA = "0x82DDAD0", Offset = "0x82DC4D0", VA = "0x1882DDAD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A7")]
		[BindableData(4, "Whether the category is selected", DataPermissions.ReadOnly)]
		public bool IsSelected
		{
			[Cpp2IlInjected.Token(Token = "0x6000A5C")]
			[Cpp2IlInjected.Address(RVA = "0xDD49D0", Offset = "0xDD33D0", VA = "0x180DD49D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A5D")]
			[Cpp2IlInjected.Address(RVA = "0x82DDA00", Offset = "0x82DC400", VA = "0x1882DDA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A8")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000A5E")]
			[Cpp2IlInjected.Address(RVA = "0x82DD8E0", Offset = "0x82DC2E0", VA = "0x1882DD8E0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002A9")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000A65")]
			[Cpp2IlInjected.Address(RVA = "0x82DD8A0", Offset = "0x82DC2A0", VA = "0x1882DD8A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AA")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000A66")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0x82DD4D0", Offset = "0x82DBED0", VA = "0x1882DD4D0")]
		[BindableAction(3, "Selects the category")]
		public void SelectCategory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5F")]
		[Cpp2IlInjected.Address(RVA = "0x82DC9A0", Offset = "0x82DB3A0", VA = "0x1882DC9A0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A60")]
		[Cpp2IlInjected.Address(RVA = "0x82DD310", Offset = "0x82DBD10", VA = "0x1882DD310", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0x82DD530", Offset = "0x82DBF30", VA = "0x1882DD530")]
		private void UpdateSelection()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0x82DD160", Offset = "0x82DBB60", VA = "0x1882DD160")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0x82DD3D0", Offset = "0x82DBDD0", VA = "0x1882DD3D0")]
		private void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A64")]
		[Cpp2IlInjected.Address(RVA = "0x82DCB00", Offset = "0x82DB500", VA = "0x1882DCB00")]
		private void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A67")]
		[Cpp2IlInjected.Address(RVA = "0x82DCD50", Offset = "0x82DB750", VA = "0x1882DCD50", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A68")]
		[Cpp2IlInjected.Address(RVA = "0x82DCC10", Offset = "0x82DB610", VA = "0x1882DCC10")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A69")]
		[Cpp2IlInjected.Address(RVA = "0x82DD650", Offset = "0x82DC050", VA = "0x1882DD650")]
		public RoomStoreCategoryViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EA")]
	[ViewModel]
	public class RoomStoreItemViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006B0")]
		private string itemName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006B1")]
		private string itemDescription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006B2")]
		private string priceText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006B3")]
		private string buyText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006B4")]
		private string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006B5")]
		private Sprite secondaryIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40006B6")]
		private Sprite currencyIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40006B7")]
		private bool hasRawImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40006B8")]
		private Sprite fallbackImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40006B9")]
		private bool canBuy;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x40006BA")]
		private Color iconColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40006BB")]
		private bool hidePrice;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40006BC")]
		[SerializeField]
		private Sprite defaultItemImage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40006BD")]
		private IUnifiedRoomStoreItem storeItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40006BF")]
		private IRRUIvNextRoomStoreBridge roomStoreBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40006C0")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40006C1")]
		private DataItem<string> ItemNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40006C2")]
		private DataItem<string> ItemDescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40006C3")]
		private DataItem<string> PriceTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40006C4")]
		private DataItem<string> BuyTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40006C5")]
		private DataItem<string> ImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40006C6")]
		private DataItem<Sprite> SecondaryIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40006C7")]
		private DataItem<Sprite> CurrencyIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40006C8")]
		private DataItem<bool> HasRawImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40006C9")]
		private DataItem<Sprite> FallbackImageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40006CA")]
		private DataItem<bool> CanBuyDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40006CB")]
		private DataItem<Color> IconColorDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40006CC")]
		private DataItem<bool> HidePriceDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40006CD")]
		private DataItemAction OpenStorePageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40006CE")]
		private DataItemAction BuyItemDataItem;

		[Cpp2IlInjected.Token(Token = "0x170002AB")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string ItemName
		{
			[Cpp2IlInjected.Token(Token = "0x6000A6E")]
			[Cpp2IlInjected.Address(RVA = "0xAB4850", Offset = "0xAB3250", VA = "0x180AB4850")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A6F")]
			[Cpp2IlInjected.Address(RVA = "0x82DF650", Offset = "0x82DE050", VA = "0x1882DF650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AC")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string ItemDescription
		{
			[Cpp2IlInjected.Token(Token = "0x6000A70")]
			[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A71")]
			[Cpp2IlInjected.Address(RVA = "0x82DF740", Offset = "0x82DE140", VA = "0x1882DF740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AD")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string PriceText
		{
			[Cpp2IlInjected.Token(Token = "0x6000A72")]
			[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A73")]
			[Cpp2IlInjected.Address(RVA = "0x82DF7B0", Offset = "0x82DE1B0", VA = "0x1882DF7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AE")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public string BuyText
		{
			[Cpp2IlInjected.Token(Token = "0x6000A74")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B30", Offset = "0xAB6530", VA = "0x180AB7B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A75")]
			[Cpp2IlInjected.Address(RVA = "0x82DF820", Offset = "0x82DE220", VA = "0x1882DF820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002AF")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000A76")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B40", Offset = "0xAB6540", VA = "0x180AB7B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A77")]
			[Cpp2IlInjected.Address(RVA = "0x82E0410", Offset = "0x82DEE10", VA = "0x1882E0410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B0")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public Sprite SecondaryIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000A78")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6550", VA = "0x180AB7B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A79")]
			[Cpp2IlInjected.Address(RVA = "0x82E0490", Offset = "0x82DEE90", VA = "0x1882E0490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B1")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public Sprite CurrencyIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000A7A")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7C0", Offset = "0xB2E1C0", VA = "0x180B2F7C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A7B")]
			[Cpp2IlInjected.Address(RVA = "0x82E01F0", Offset = "0x82DEBF0", VA = "0x1882E01F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B2")]
		[BindableData(7, null, DataPermissions.ReadWrite)]
		public bool HasRawImage
		{
			[Cpp2IlInjected.Token(Token = "0x6000A7C")]
			[Cpp2IlInjected.Address(RVA = "0xFEB740", Offset = "0xFEA140", VA = "0x180FEB740")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A7D")]
			[Cpp2IlInjected.Address(RVA = "0x82DF580", Offset = "0x82DDF80", VA = "0x1882DF580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B3")]
		[BindableData(8, null, DataPermissions.ReadWrite)]
		public Sprite FallbackImage
		{
			[Cpp2IlInjected.Token(Token = "0x6000A7E")]
			[Cpp2IlInjected.Address(RVA = "0xB79620", Offset = "0xB78020", VA = "0x180B79620")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A7F")]
			[Cpp2IlInjected.Address(RVA = "0x82E02A0", Offset = "0x82DECA0", VA = "0x1882E02A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B4")]
		[BindableData(11, null, DataPermissions.ReadWrite)]
		public bool CanBuy
		{
			[Cpp2IlInjected.Token(Token = "0x6000A82")]
			[Cpp2IlInjected.Address(RVA = "0xB797F0", Offset = "0xB781F0", VA = "0x180B797F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A83")]
			[Cpp2IlInjected.Address(RVA = "0x82DF5F0", Offset = "0x82DDFF0", VA = "0x1882DF5F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B5")]
		[BindableData(12, null, DataPermissions.ReadWrite)]
		public Color IconColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000A84")]
			[Cpp2IlInjected.Address(RVA = "0x210F300", Offset = "0x210DD00", VA = "0x18210F300")]
			get
			{
				return default(Color);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A85")]
			[Cpp2IlInjected.Address(RVA = "0x82E0350", Offset = "0x82DED50", VA = "0x1882E0350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B6")]
		[BindableData(13, null, DataPermissions.ReadWrite)]
		public bool HidePrice
		{
			[Cpp2IlInjected.Token(Token = "0x6000A86")]
			[Cpp2IlInjected.Address(RVA = "0x2F7A3D0", Offset = "0x2F78DD0", VA = "0x182F7A3D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000A87")]
			[Cpp2IlInjected.Address(RVA = "0x82DF6E0", Offset = "0x82DE0E0", VA = "0x1882DF6E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B7")]
		public IUnifiedRoomStoreItem StoreItem
		{
			[Cpp2IlInjected.Token(Token = "0x6000A88")]
			[Cpp2IlInjected.Address(RVA = "0xB795C0", Offset = "0xB77FC0", VA = "0x180B795C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000A89")]
			[Cpp2IlInjected.Address(RVA = "0x82E0540", Offset = "0x82DEF40", VA = "0x1882E0540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B8")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000A8C")]
			[Cpp2IlInjected.Address(RVA = "0x82E00C0", Offset = "0x82DEAC0", VA = "0x1882E00C0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002B9")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000A95")]
			[Cpp2IlInjected.Address(RVA = "0x82E0080", Offset = "0x82DEA80", VA = "0x1882E0080", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BA")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000A96")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001F")]
		public event Action OnStoreItemChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000A8A")]
			[Cpp2IlInjected.Address(RVA = "0x82DFFD0", Offset = "0x82DE9D0", VA = "0x1882DFFD0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000A8B")]
			[Cpp2IlInjected.Address(RVA = "0x82E0140", Offset = "0x82DEB40", VA = "0x1882E0140")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A80")]
		[Cpp2IlInjected.Address(RVA = "0x82DF080", Offset = "0x82DDA80", VA = "0x1882DF080")]
		[BindableAction(9, null)]
		public void OpenStorePage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A81")]
		[Cpp2IlInjected.Address(RVA = "0x82DDC00", Offset = "0x82DC600", VA = "0x1882DDC00")]
		[BindableAction(10, null)]
		public void BuyItem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8D")]
		[Cpp2IlInjected.Address(RVA = "0x82DDB30", Offset = "0x82DC530", VA = "0x1882DDB30", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8E")]
		[Cpp2IlInjected.Address(RVA = "0x82DEF90", Offset = "0x82DD990", VA = "0x1882DEF90", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A8F")]
		[Cpp2IlInjected.Address(RVA = "0x82DEEF0", Offset = "0x82DD8F0", VA = "0x1882DEEF0")]
		private void OnDataUpdated(IDataSource source, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A90")]
		[Cpp2IlInjected.Address(RVA = "0x82DDC90", Offset = "0x82DC690", VA = "0x1882DDC90")]
		private void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A91")]
		[Cpp2IlInjected.Address(RVA = "0x82DF110", Offset = "0x82DDB10", VA = "0x1882DF110")]
		private void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A92")]
		[Cpp2IlInjected.Address(RVA = "0x82DF070", Offset = "0x82DDA70", VA = "0x1882DF070")]
		private void OnUnifiedItemUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A93")]
		[Cpp2IlInjected.Address(RVA = "0x82DF8A0", Offset = "0x82DE2A0", VA = "0x1882DF8A0")]
		private void UpdateImpressionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A94")]
		[Cpp2IlInjected.Address(RVA = "0x82DEE60", Offset = "0x82DD860", VA = "0x1882DEE60")]
		private void LogClick(string buttonName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A97")]
		[Cpp2IlInjected.Address(RVA = "0x82DE1F0", Offset = "0x82DCBF0", VA = "0x1882DE1F0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A98")]
		[Cpp2IlInjected.Address(RVA = "0x82DDF80", Offset = "0x82DC980", VA = "0x1882DDF80")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A99")]
		[Cpp2IlInjected.Address(RVA = "0x82DFB30", Offset = "0x82DE530", VA = "0x1882DFB30")]
		public RoomStoreItemViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	[ViewModel]
	public class RoomViewModel : RRUIBaseLocalViewModel, ILoadable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000EC")]
		[CompilerGenerated]
		private struct <FetchRoomData>d__120 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000711")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000712")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000713")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000714")]
			private TaskAwaiter<PPFENAOBDPL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000B25")]
			[Cpp2IlInjected.Address(RVA = "0x82EBA00", Offset = "0x82EA400", VA = "0x1882EBA00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B26")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000ED")]
		[CompilerGenerated]
		private struct <DoPlayAction>d__126 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000715")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000716")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000717")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000718")]
			private PKCMPJMLDGM <details>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000719")]
			private bool <canChooseSubroom>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400071A")]
			private TaskAwaiter<PKCMPJMLDGM> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400071B")]
			private TaskAwaiter<bool> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000B27")]
			[Cpp2IlInjected.Address(RVA = "0x82EA320", Offset = "0x82E8D20", VA = "0x1882EA320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B28")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		[CompilerGenerated]
		private struct <CreateOrJoinRoomInstance>d__127 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000721")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000722")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000723")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000724")]
			public PKCMPJMLDGM roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000725")]
			public bool privateInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x4000726")]
			public bool canChooseSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
			[Cpp2IlInjected.Token(Token = "0x4000727")]
			public bool randomSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000728")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000B2B")]
			[Cpp2IlInjected.Address(RVA = "0x82E9620", Offset = "0x82E8020", VA = "0x1882E9620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B2C")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F0")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass128_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000729")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400072A")]
			public PKCMPJMLDGM roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400072B")]
			public PMHLBPGOPPD subRoom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400072C")]
			public bool privateInstance;

			[Cpp2IlInjected.Token(Token = "0x6000B2D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public <>c__DisplayClass128_0()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B2E")]
			[Cpp2IlInjected.Address(RVA = "0x82EDB40", Offset = "0x82EC540", VA = "0x1882EDB40")]
			internal void <PlayAction_TryGoToRoom>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F1")]
		[CompilerGenerated]
		private sealed class <>c__DisplayClass128_1
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400072D")]
			public INDFDDFMNAH latestValidSave;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400072E")]
			public <>c__DisplayClass128_0 CS$<>8__locals1;

			[Cpp2IlInjected.Token(Token = "0x6000B2F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public <>c__DisplayClass128_1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B30")]
			[Cpp2IlInjected.Address(RVA = "0x82EDC30", Offset = "0x82EC630", VA = "0x1882EDC30")]
			internal void <PlayAction_TryGoToRoom>b__1()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		[CompilerGenerated]
		private struct <PlayAction_TryGoToRoom>d__128 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400072F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000730")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000731")]
			public RoomViewModel <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000732")]
			public PKCMPJMLDGM roomDetails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000733")]
			public bool privateInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x4000734")]
			public bool randomSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
			[Cpp2IlInjected.Token(Token = "0x4000735")]
			public bool canChooseSubroom;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000736")]
			private <>c__DisplayClass128_0 <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000737")]
			private <>c__DisplayClass128_1 <>8__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000738")]
			private TaskAwaiter<PMHLBPGOPPD> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000739")]
			private IRoomSaveManager <saveManager>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400073A")]
			private TaskAwaiter<INDFDDFMNAH> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000B31")]
			[Cpp2IlInjected.Address(RVA = "0x82EBD70", Offset = "0x82EA770", VA = "0x1882EBD70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000B32")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40006CF")]
		private const string CCUCountKey = "CCU_COUNT";

		[Cpp2IlInjected.Token(Token = "0x40006D0")]
		private const char tokenDelimiter = '.';

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40006D1")]
		[SerializeField]
		private DataResolver featureHelperResolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40006D2")]
		private IRoomQueryManager roomQueryManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40006D3")]
		private IRoomLoadManager roomLoadManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40006D4")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40006D5")]
		private IRRUIvNextUIDataBridge vNextDataBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40006D6")]
		private EEIOAMNMKPH loadSceneSourceData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40006D7")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40006D8")]
		private DialogListModel dialogListModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40006D9")]
		private int cheerCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
		[Cpp2IlInjected.Token(Token = "0x40006DA")]
		private int ccuCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40006DB")]
		private bool shouldFetchCCUCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40006DC")]
		private DateTime? lastPublished;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40006DD")]
		private bool hasSufficientVersionToLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40006DE")]
		private long roomId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40006DF")]
		private string displayName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40006E0")]
		private string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40006E1")]
		private string imageName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40006E2")]
		private bool favorited;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40006E3")]
		private string cheerCountString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40006E4")]
		private bool isRooms2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x161")]
		[Cpp2IlInjected.Token(Token = "0x40006E5")]
		private bool showCheerCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40006E6")]
		private string ccuCountString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40006E7")]
		private bool supportsPlayAction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x171")]
		[Cpp2IlInjected.Token(Token = "0x40006E8")]
		private bool supportsMoreLikeThis;

		[Cpp2IlInjected.FieldOffset(Offset = "0x172")]
		[Cpp2IlInjected.Token(Token = "0x40006E9")]
		private bool isPopularRoom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x173")]
		[Cpp2IlInjected.Token(Token = "0x40006EA")]
		private bool isNewlyPublished;

		[Cpp2IlInjected.FieldOffset(Offset = "0x174")]
		[Cpp2IlInjected.Token(Token = "0x40006EB")]
		private bool showCCUCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x175")]
		[Cpp2IlInjected.Token(Token = "0x40006EC")]
		private bool supportsDataTokens;

		[Cpp2IlInjected.FieldOffset(Offset = "0x176")]
		[Cpp2IlInjected.Token(Token = "0x40006ED")]
		private bool showCheerToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x177")]
		[Cpp2IlInjected.Token(Token = "0x40006EE")]
		private bool requiresUpdateToPlay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40006EF")]
		private bool showUpdateToPlayIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0x179")]
		[Cpp2IlInjected.Token(Token = "0x40006F0")]
		private bool showUpdateToPlayText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17A")]
		[Cpp2IlInjected.Token(Token = "0x40006F1")]
		private bool showNewThisSessionForSection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17B")]
		[Cpp2IlInjected.Token(Token = "0x40006F2")]
		private bool showRooms2Badge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
		[Cpp2IlInjected.Token(Token = "0x40006F3")]
		private CNJHFMJAOKM publishState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40006F4")]
		private bool showPublishState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40006F7")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40006F8")]
		private DataItem<long> RoomIdDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40006F9")]
		private DataItem<string> DisplayNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40006FA")]
		private DataItem<string> DescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40006FB")]
		private DataItem<string> ImageNameDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40006FC")]
		private DataItem<bool> FavoritedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40006FD")]
		private DataItem<string> CheerCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40006FE")]
		private DataItem<bool> IsRooms2DataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40006FF")]
		private DataItem<bool> ShowCheerCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000700")]
		private DataItem<string> CCUCountStringDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000701")]
		private DataItem<bool> SupportsPlayActionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000702")]
		private DataItem<bool> SupportsMoreLikeThisDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000703")]
		private DataItem<bool> IsPopularRoomDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000704")]
		private DataItem<bool> IsNewlyPublishedDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000705")]
		private DataItem<bool> ShowCCUCountDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000706")]
		private DataItem<bool> SupportsDataTokensDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000707")]
		private DataItem<bool> ShowCheerTokenDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000708")]
		private DataItem<bool> RequiresUpdateToPlayDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000709")]
		private DataItem<bool> ShowUpdateToPlayIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400070A")]
		private DataItem<bool> ShowUpdateToPlayTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400070B")]
		private DataItem<bool> ShowNewThisSessionForSectionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x400070C")]
		private DataItem<bool> ShowRooms2BadgeDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x400070D")]
		private DataItem<CNJHFMJAOKM> PublishStateDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x400070E")]
		private DataItem<bool> ShowPublishStateDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x400070F")]
		private DataItemAction OpenRoomDetailsPageDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000710")]
		private DataItemAction DoPlayActionDataItem;

		[Cpp2IlInjected.Token(Token = "0x170002BB")]
		[BindableData(0, "The ID used to retrieve the room data from RecNet", DataPermissions.ReadWrite)]
		public long RoomId
		{
			[Cpp2IlInjected.Token(Token = "0x6000AB2")]
			[Cpp2IlInjected.Address(RVA = "0xBA47A0", Offset = "0xBA31A0", VA = "0x180BA47A0")]
			get
			{
				return default(long);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AB3")]
			[Cpp2IlInjected.Address(RVA = "0x82E52C0", Offset = "0x82E3CC0", VA = "0x1882E52C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BC")]
		[BindableData(1, "The sanitized, friendly name of the room", DataPermissions.ReadOnly)]
		public string DisplayName
		{
			[Cpp2IlInjected.Token(Token = "0x6000AB4")]
			[Cpp2IlInjected.Address(RVA = "0xC28520", Offset = "0xC26F20", VA = "0x180C28520")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AB5")]
			[Cpp2IlInjected.Address(RVA = "0x82E51B0", Offset = "0x82E3BB0", VA = "0x1882E51B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BD")]
		[BindableData(2, null, DataPermissions.ReadOnly)]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000AB6")]
			[Cpp2IlInjected.Address(RVA = "0xC261F0", Offset = "0xC24BF0", VA = "0x180C261F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AB7")]
			[Cpp2IlInjected.Address(RVA = "0x82E5130", Offset = "0x82E3B30", VA = "0x1882E5130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BE")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public string ImageName
		{
			[Cpp2IlInjected.Token(Token = "0x6000AB8")]
			[Cpp2IlInjected.Address(RVA = "0xC265D0", Offset = "0xC24FD0", VA = "0x180C265D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AB9")]
			[Cpp2IlInjected.Address(RVA = "0x82E5230", Offset = "0x82E3C30", VA = "0x1882E5230")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002BF")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool Favorited
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABA")]
			[Cpp2IlInjected.Address(RVA = "0xC284F0", Offset = "0xC26EF0", VA = "0x180C284F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ABB")]
			[Cpp2IlInjected.Address(RVA = "0x82E3B10", Offset = "0x82E2510", VA = "0x1882E3B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C0")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public string CheerCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABC")]
			[Cpp2IlInjected.Address(RVA = "0xC29330", Offset = "0xC27D30", VA = "0x180C29330")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000ABD")]
			[Cpp2IlInjected.Address(RVA = "0x82E50B0", Offset = "0x82E3AB0", VA = "0x1882E50B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C1")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool IsRooms2
		{
			[Cpp2IlInjected.Token(Token = "0x6000ABE")]
			[Cpp2IlInjected.Address(RVA = "0x1FA8480", Offset = "0x1FA6E80", VA = "0x181FA8480")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ABF")]
			[Cpp2IlInjected.Address(RVA = "0x82E34D0", Offset = "0x82E1ED0", VA = "0x1882E34D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C2")]
		[BindableData(7, null, DataPermissions.ReadWrite)]
		public bool ShowCheerCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC0")]
			[Cpp2IlInjected.Address(RVA = "0x1FA8470", Offset = "0x1FA6E70", VA = "0x181FA8470")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AC1")]
			[Cpp2IlInjected.Address(RVA = "0x82E3530", Offset = "0x82E1F30", VA = "0x1882E3530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C3")]
		[BindableData(8, null, DataPermissions.ReadWrite)]
		public string CCUCountString
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC2")]
			[Cpp2IlInjected.Address(RVA = "0xC26D40", Offset = "0xC25740", VA = "0x180C26D40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000AC3")]
			[Cpp2IlInjected.Address(RVA = "0x82E5030", Offset = "0x82E3A30", VA = "0x1882E5030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C4")]
		[BindableData(9, null, DataPermissions.ReadWrite)]
		public bool SupportsPlayAction
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC4")]
			[Cpp2IlInjected.Address(RVA = "0xC26290", Offset = "0xC24C90", VA = "0x180C26290")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AC5")]
			[Cpp2IlInjected.Address(RVA = "0x82E35A0", Offset = "0x82E1FA0", VA = "0x1882E35A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C5")]
		[BindableData(10, null, DataPermissions.ReadWrite)]
		public bool SupportsMoreLikeThis
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC6")]
			[Cpp2IlInjected.Address(RVA = "0xC6F670", Offset = "0xC6E070", VA = "0x180C6F670")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AC7")]
			[Cpp2IlInjected.Address(RVA = "0x82E3600", Offset = "0x82E2000", VA = "0x1882E3600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C6")]
		[BindableData(11, null, DataPermissions.ReadWrite)]
		public bool IsPopularRoom
		{
			[Cpp2IlInjected.Token(Token = "0x6000AC8")]
			[Cpp2IlInjected.Address(RVA = "0x82E3670", Offset = "0x82E2070", VA = "0x1882E3670")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AC9")]
			[Cpp2IlInjected.Address(RVA = "0x82E3680", Offset = "0x82E2080", VA = "0x1882E3680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C7")]
		[BindableData(12, null, DataPermissions.ReadWrite)]
		public bool IsNewlyPublished
		{
			[Cpp2IlInjected.Token(Token = "0x6000ACA")]
			[Cpp2IlInjected.Address(RVA = "0x10E7890", Offset = "0x10E6290", VA = "0x1810E7890")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ACB")]
			[Cpp2IlInjected.Address(RVA = "0x82E36E0", Offset = "0x82E20E0", VA = "0x1882E36E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C8")]
		[BindableData(13, null, DataPermissions.ReadWrite)]
		public bool ShowCCUCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000ACC")]
			[Cpp2IlInjected.Address(RVA = "0x82E3740", Offset = "0x82E2140", VA = "0x1882E3740")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ACD")]
			[Cpp2IlInjected.Address(RVA = "0x82E3750", Offset = "0x82E2150", VA = "0x1882E3750")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002C9")]
		[BindableData(14, null, DataPermissions.ReadWrite)]
		public bool SupportsDataTokens
		{
			[Cpp2IlInjected.Token(Token = "0x6000ACE")]
			[Cpp2IlInjected.Address(RVA = "0x82E37B0", Offset = "0x82E21B0", VA = "0x1882E37B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ACF")]
			[Cpp2IlInjected.Address(RVA = "0x82E37C0", Offset = "0x82E21C0", VA = "0x1882E37C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CA")]
		[BindableData(15, null, DataPermissions.ReadWrite)]
		public bool ShowCheerToken
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD0")]
			[Cpp2IlInjected.Address(RVA = "0x82E3820", Offset = "0x82E2220", VA = "0x1882E3820")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AD1")]
			[Cpp2IlInjected.Address(RVA = "0x82E3830", Offset = "0x82E2230", VA = "0x1882E3830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CB")]
		[BindableData(16, null, DataPermissions.ReadWrite)]
		public bool RequiresUpdateToPlay
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD2")]
			[Cpp2IlInjected.Address(RVA = "0x82E3890", Offset = "0x82E2290", VA = "0x1882E3890")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AD3")]
			[Cpp2IlInjected.Address(RVA = "0x82E38A0", Offset = "0x82E22A0", VA = "0x1882E38A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CC")]
		[BindableData(17, null, DataPermissions.ReadWrite)]
		public bool ShowUpdateToPlayIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD4")]
			[Cpp2IlInjected.Address(RVA = "0xB879A0", Offset = "0xB863A0", VA = "0x180B879A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AD5")]
			[Cpp2IlInjected.Address(RVA = "0x82E3900", Offset = "0x82E2300", VA = "0x1882E3900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CD")]
		[BindableData(18, null, DataPermissions.ReadWrite)]
		public bool ShowUpdateToPlayText
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD6")]
			[Cpp2IlInjected.Address(RVA = "0x82E3960", Offset = "0x82E2360", VA = "0x1882E3960")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AD7")]
			[Cpp2IlInjected.Address(RVA = "0x82E3970", Offset = "0x82E2370", VA = "0x1882E3970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CE")]
		[BindableData(19, null, DataPermissions.ReadWrite)]
		public bool ShowNewThisSessionForSection
		{
			[Cpp2IlInjected.Token(Token = "0x6000AD8")]
			[Cpp2IlInjected.Address(RVA = "0x82E39D0", Offset = "0x82E23D0", VA = "0x1882E39D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AD9")]
			[Cpp2IlInjected.Address(RVA = "0x82E39E0", Offset = "0x82E23E0", VA = "0x1882E39E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002CF")]
		[BindableData(20, null, DataPermissions.ReadWrite)]
		public bool ShowRooms2Badge
		{
			[Cpp2IlInjected.Token(Token = "0x6000ADA")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ADB")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D0")]
		[BindableData(21, null, DataPermissions.ReadWrite)]
		public CNJHFMJAOKM PublishState
		{
			[Cpp2IlInjected.Token(Token = "0x6000ADC")]
			[Cpp2IlInjected.Address(RVA = "0xB4F5C0", Offset = "0xB4DFC0", VA = "0x180B4F5C0")]
			get
			{
				return default(CNJHFMJAOKM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ADD")]
			[Cpp2IlInjected.Address(RVA = "0x82E3A40", Offset = "0x82E2440", VA = "0x1882E3A40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D1")]
		[BindableData(22, null, DataPermissions.ReadWrite)]
		public bool ShowPublishState
		{
			[Cpp2IlInjected.Token(Token = "0x6000ADE")]
			[Cpp2IlInjected.Address(RVA = "0x25B31F0", Offset = "0x25B1BF0", VA = "0x1825B31F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000ADF")]
			[Cpp2IlInjected.Address(RVA = "0x82E3AA0", Offset = "0x82E24A0", VA = "0x1882E3AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D2")]
		protected override DataItemUpdate UpdateFunction
		{
			[Cpp2IlInjected.Token(Token = "0x6000AE0")]
			[Cpp2IlInjected.Address(RVA = "0x82E4EF0", Offset = "0x82E38F0", VA = "0x1882E4EF0", Slot = "13")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D3")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x6000AE1")]
			[Cpp2IlInjected.Address(RVA = "0x82E4EE0", Offset = "0x82E38E0", VA = "0x1882E4EE0", Slot = "18")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000AE2")]
			[Cpp2IlInjected.Address(RVA = "0x82E52B0", Offset = "0x82E3CB0", VA = "0x1882E52B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D4")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF4")]
			[Cpp2IlInjected.Address(RVA = "0x82E4EA0", Offset = "0x82E38A0", VA = "0x1882E4EA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D5")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000AF5")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000020")]
		public event Action<ILoadable> Loaded
		{
			[Cpp2IlInjected.Token(Token = "0x6000AE3")]
			[Cpp2IlInjected.Address(RVA = "0x82E4DE0", Offset = "0x82E37E0", VA = "0x1882E4DE0", Slot = "16")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000AE4")]
			[Cpp2IlInjected.Address(RVA = "0x82E4F70", Offset = "0x82E3970", VA = "0x1882E4F70", Slot = "17")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE5")]
		[Cpp2IlInjected.Address(RVA = "0x82E0820", Offset = "0x82DF220", VA = "0x1882E0820", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE6")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE7")]
		[Cpp2IlInjected.Address(RVA = "0x82E2730", Offset = "0x82E1130", VA = "0x1882E2730", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE8")]
		[Cpp2IlInjected.Address(RVA = "0x82E2540", Offset = "0x82E0F40", VA = "0x1882E2540")]
		private void OnDataUpdated(IDataSource dataSource, int itemId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AE9")]
		[Cpp2IlInjected.Address(RVA = "0x82E0B20", Offset = "0x82DF520", VA = "0x1882E0B20")]
		[AsyncStateMachine(typeof(<FetchRoomData>d__120))]
		private void FetchRoomData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEA")]
		[Cpp2IlInjected.Address(RVA = "0x82E42E0", Offset = "0x82E2CE0", VA = "0x1882E42E0")]
		private void UpdateRoomData(PPFENAOBDPL roomDto)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEB")]
		[Cpp2IlInjected.Address(RVA = "0x82E3B80", Offset = "0x82E2580", VA = "0x1882E3B80")]
		private void UpdateFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEC")]
		[Cpp2IlInjected.Address(RVA = "0x82E3020", Offset = "0x82E1A20", VA = "0x1882E3020")]
		private void ResetRoomData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AED")]
		[Cpp2IlInjected.Address(RVA = "0x82E27E0", Offset = "0x82E11E0", VA = "0x1882E27E0")]
		private void OnFeatureHelperUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEE")]
		[Cpp2IlInjected.Address(RVA = "0x82E2800", Offset = "0x82E1200", VA = "0x1882E2800")]
		[BindableAction(100, null)]
		private void OpenRoomDetailsPage()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AEF")]
		[Cpp2IlInjected.Address(RVA = "0x82E0A70", Offset = "0x82DF470", VA = "0x1882E0A70")]
		[AsyncStateMachine(typeof(<DoPlayAction>d__126))]
		[BindableAction(101, null)]
		private void DoPlayAction()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF0")]
		[Cpp2IlInjected.Address(RVA = "0x82E0970", Offset = "0x82DF370", VA = "0x1882E0970")]
		[AsyncStateMachine(typeof(<CreateOrJoinRoomInstance>d__127))]
		private void CreateOrJoinRoomInstance(bool privateInstance, PKCMPJMLDGM roomDetails, bool canChooseSubroom = false, bool randomSubroom = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF1")]
		[Cpp2IlInjected.Address(RVA = "0x82E2D10", Offset = "0x82E1710", VA = "0x1882E2D10")]
		[AsyncStateMachine(typeof(<PlayAction_TryGoToRoom>d__128))]
		private void PlayAction_TryGoToRoom(PKCMPJMLDGM roomDetails, bool privateInstance, bool canChooseSubroom, bool randomSubroom)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF2")]
		[Cpp2IlInjected.Address(RVA = "0x82E2E20", Offset = "0x82E1820", VA = "0x1882E2E20")]
		private void RecordImpressionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF3")]
		[Cpp2IlInjected.Address(RVA = "0x82E06D0", Offset = "0x82DF0D0", VA = "0x1882E06D0")]
		private void AddDataTokenToImpressionData(string dataToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF6")]
		[Cpp2IlInjected.Address(RVA = "0x82E0FC0", Offset = "0x82DF9C0", VA = "0x1882E0FC0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF7")]
		[Cpp2IlInjected.Address(RVA = "0x82E0BD0", Offset = "0x82DF5D0", VA = "0x1882E0BD0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000AF8")]
		[Cpp2IlInjected.Address(RVA = "0x82E4680", Offset = "0x82E3080", VA = "0x1882E4680")]
		public RoomViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F3")]
	[ViewModel]
	public class WatchHomeRoomStoreCarouselViewModel : RRUIBaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400073B")]
		private bool shouldShowRoomStore;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x400073C")]
		private bool shouldShowRoomInventory;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400073D")]
		private DataList<IUnifiedRoomStoreItem> roomStoreItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400073E")]
		private DataList<IUnifiedRoomInventoryItem> roomInventoryItems;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400073F")]
		[SerializeField]
		private Uri roomStoreUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000740")]
		[SerializeField]
		private Uri roomInventoryUriR1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000741")]
		[SerializeField]
		private Uri roomInventoryUriR2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000742")]
		[SerializeField]
		private int maxActiveCards;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000743")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000744")]
		private IRRUIvNextRoomStoreBridge roomStoreBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000745")]
		private IRRUIvNextRoomInventoryBridge roomInventoryBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000746")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000747")]
		private DataItem<bool> ShouldShowRoomStoreDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000748")]
		private DataItem<bool> ShouldShowRoomInventoryDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000749")]
		private DataItemList RoomStoreItemsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400074A")]
		private DataItemList RoomInventoryItemsDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400074B")]
		private DataItemAction GoToRoomStoreDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400074C")]
		private DataItemAction GoToRoomInventoryDataItem;

		[Cpp2IlInjected.Token(Token = "0x170002D6")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public bool ShouldShowRoomStore
		{
			[Cpp2IlInjected.Token(Token = "0x6000B35")]
			[Cpp2IlInjected.Address(RVA = "0xABA770", Offset = "0xAB9170", VA = "0x180ABA770")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B36")]
			[Cpp2IlInjected.Address(RVA = "0x82EF3B0", Offset = "0x82EDDB0", VA = "0x1882EF3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D7")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool ShouldShowRoomInventory
		{
			[Cpp2IlInjected.Token(Token = "0x6000B37")]
			[Cpp2IlInjected.Address(RVA = "0xABA910", Offset = "0xAB9310", VA = "0x180ABA910")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B38")]
			[Cpp2IlInjected.Address(RVA = "0x82EF410", Offset = "0x82EDE10", VA = "0x1882EF410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D8")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public DataList<IUnifiedRoomStoreItem> RoomStoreItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000B39")]
			[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B3A")]
			[Cpp2IlInjected.Address(RVA = "0x82EF950", Offset = "0x82EE350", VA = "0x1882EF950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002D9")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public DataList<IUnifiedRoomInventoryItem> RoomInventoryItems
		{
			[Cpp2IlInjected.Token(Token = "0x6000B3B")]
			[Cpp2IlInjected.Address(RVA = "0xAB4830", Offset = "0xAB3230", VA = "0x180AB4830")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B3C")]
			[Cpp2IlInjected.Address(RVA = "0x82EF8F0", Offset = "0x82EE2F0", VA = "0x1882EF8F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DA")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000B42")]
			[Cpp2IlInjected.Address(RVA = "0x82EF8B0", Offset = "0x82EE2B0", VA = "0x1882EF8B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002DB")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000B43")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B33")]
		[Cpp2IlInjected.Address(RVA = "0x82EE460", Offset = "0x82ECE60", VA = "0x1882EE460")]
		[BindableAction(0, null)]
		public void GoToRoomStore()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B34")]
		[Cpp2IlInjected.Address(RVA = "0x82EE350", Offset = "0x82ECD50", VA = "0x1882EE350")]
		[BindableAction(1, null)]
		public void GoToRoomInventory()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3D")]
		[Cpp2IlInjected.Address(RVA = "0x82EDF60", Offset = "0x82EC960", VA = "0x1882EDF60", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3E")]
		[Cpp2IlInjected.Address(RVA = "0x82EEA70", Offset = "0x82ED470", VA = "0x1882EEA70", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B3F")]
		[Cpp2IlInjected.Address(RVA = "0x82EEE60", Offset = "0x82ED860", VA = "0x1882EEE60")]
		private void OnStoreItemsChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B40")]
		[Cpp2IlInjected.Address(RVA = "0x82EEBA0", Offset = "0x82ED5A0", VA = "0x1882EEBA0")]
		private void OnInventoryItemsChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B41")]
		[Cpp2IlInjected.Address(RVA = "0x82EF170", Offset = "0x82EDB70", VA = "0x1882EF170")]
		private void SetupImpressionTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B44")]
		[Cpp2IlInjected.Address(RVA = "0x82EE520", Offset = "0x82ECF20", VA = "0x1882EE520", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B45")]
		[Cpp2IlInjected.Address(RVA = "0x82EE1F0", Offset = "0x82ECBF0", VA = "0x1882EE1F0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B46")]
		[Cpp2IlInjected.Address(RVA = "0x82EF610", Offset = "0x82EE010", VA = "0x1882EF610")]
		public WatchHomeRoomStoreCarouselViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F4")]
	public class RRUIBaseGlobalViewModel : BaseGlobalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x170002DC")]
		protected override string RecordPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000B4F")]
			[Cpp2IlInjected.Address(RVA = "0x82F7530", Offset = "0x82F5F30", VA = "0x1882F7530", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B50")]
		[Cpp2IlInjected.Address(RVA = "0x82F7520", Offset = "0x82F5F20", VA = "0x1882F7520")]
		public RRUIBaseGlobalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F5")]
	public class RRUIBaseLocalViewModel : BaseLocalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400074D")]
		[SerializeField]
		protected ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400074E")]
		protected CancellationTokenSource cancellationTokenSource;

		[Cpp2IlInjected.Token(Token = "0x170002DD")]
		protected override string RecordPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000B51")]
			[Cpp2IlInjected.Address(RVA = "0x82F76D0", Offset = "0x82F60D0", VA = "0x1882F76D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B52")]
		[Cpp2IlInjected.Address(RVA = "0x82F7660", Offset = "0x82F6060", VA = "0x1882F7660", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B53")]
		[Cpp2IlInjected.Address(RVA = "0x82F7560", Offset = "0x82F5F60", VA = "0x1882F7560")]
		protected CancellationToken CancelAndRefreshToken()
		{
			return default(CancellationToken);
		}

		[Cpp2IlInjected.Token(Token = "0x6000B54")]
		[Cpp2IlInjected.Address(RVA = "0x82F7610", Offset = "0x82F6010", VA = "0x1882F7610")]
		protected void CancelToken()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B55")]
		[Cpp2IlInjected.Address(RVA = "0x82F76C0", Offset = "0x82F60C0", VA = "0x1882F76C0")]
		public RRUIBaseLocalViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F6")]
	public class PopoverCornerController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400074F")]
		[SerializeField]
		private GameObject topLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000750")]
		[SerializeField]
		private GameObject topCenter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000751")]
		[SerializeField]
		private GameObject topRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000752")]
		[SerializeField]
		private GameObject upperLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000753")]
		[SerializeField]
		private GameObject middleLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000754")]
		[SerializeField]
		private GameObject lowerLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000755")]
		[SerializeField]
		private GameObject upperRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000756")]
		[SerializeField]
		private GameObject middleRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000757")]
		[SerializeField]
		private GameObject lowerRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000758")]
		[SerializeField]
		private GameObject bottomLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000759")]
		[SerializeField]
		private GameObject bottomCenter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400075A")]
		[SerializeField]
		private GameObject bottomRight;

		[Cpp2IlInjected.Token(Token = "0x170002DE")]
		public PopoverAnchor ActiveAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x6000B56")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7D0", Offset = "0xB2E1D0", VA = "0x180B2F7D0")]
			[CompilerGenerated]
			get
			{
				return default(PopoverAnchor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B57")]
			[Cpp2IlInjected.Address(RVA = "0x167DC60", Offset = "0x167C660", VA = "0x18167DC60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B58")]
		[Cpp2IlInjected.Address(RVA = "0x82F73A0", Offset = "0x82F5DA0", VA = "0x1882F73A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B59")]
		[Cpp2IlInjected.Address(RVA = "0x82F73B0", Offset = "0x82F5DB0", VA = "0x1882F73B0")]
		public void SetActiveAnchor(PopoverAnchor anchor, bool force = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B5A")]
		[Cpp2IlInjected.Address(RVA = "0x82F7510", Offset = "0x82F5F10", VA = "0x1882F7510")]
		public PopoverCornerController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public class Tutorial
	{
		[Cpp2IlInjected.Token(Token = "0x20000F8")]
		public enum CompletionState
		{
			[Cpp2IlInjected.Token(Token = "0x4000764")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000765")]
			Completed,
			[Cpp2IlInjected.Token(Token = "0x4000766")]
			SoftExit,
			[Cpp2IlInjected.Token(Token = "0x4000767")]
			HardExit
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000761")]
		private List<TutorialStep> steps;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000762")]
		private int activeStepIdx;

		[Cpp2IlInjected.Token(Token = "0x170002DF")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5B")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B5C")]
			[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E0")]
		public TutorialStep ActiveStep
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5D")]
			[Cpp2IlInjected.Address(RVA = "0x82FE980", Offset = "0x82FD380", VA = "0x1882FE980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E1")]
		public IReadOnlyList<TutorialStep> Steps
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5E")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E2")]
		public EBDGCEEEFPM OnTutorialStarted
		{
			[Cpp2IlInjected.Token(Token = "0x6000B5F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E3")]
		public EBDGCEEEFPM OnTutorialExited
		{
			[Cpp2IlInjected.Token(Token = "0x6000B60")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E4")]
		public EBDGCEEEFPM OnStepChanged
		{
			[Cpp2IlInjected.Token(Token = "0x6000B61")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E5")]
		public CompletionState CompletionStatus
		{
			[Cpp2IlInjected.Token(Token = "0x6000B62")]
			[Cpp2IlInjected.Address(RVA = "0xABC390", Offset = "0xABAD90", VA = "0x180ABC390")]
			[CompilerGenerated]
			get
			{
				return default(CompletionState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B63")]
			[Cpp2IlInjected.Address(RVA = "0xABC380", Offset = "0xABAD80", VA = "0x180ABC380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B64")]
		[Cpp2IlInjected.Address(RVA = "0x82FE770", Offset = "0x82FD170", VA = "0x1882FE770")]
		public Tutorial(string id, List<TutorialStep> steps)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B65")]
		[Cpp2IlInjected.Address(RVA = "0x82FE730", Offset = "0x82FD130", VA = "0x1882FE730")]
		public void StartTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B66")]
		[Cpp2IlInjected.Address(RVA = "0x82FE080", Offset = "0x82FCA80", VA = "0x1882FE080")]
		public void ExitTutorial(bool showAgain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B67")]
		[Cpp2IlInjected.Address(RVA = "0x82FE200", Offset = "0x82FCC00", VA = "0x1882FE200")]
		public void SetActiveStep(string id, bool forceReload = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B68")]
		[Cpp2IlInjected.Address(RVA = "0x82FE340", Offset = "0x82FCD40", VA = "0x1882FE340")]
		public void SetActiveStep(int idx, bool forceReload = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B69")]
		[Cpp2IlInjected.Address(RVA = "0x82FE100", Offset = "0x82FCB00", VA = "0x1882FE100")]
		private void OnGoBack()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6A")]
		[Cpp2IlInjected.Address(RVA = "0x82FE180", Offset = "0x82FCB80", VA = "0x1882FE180")]
		private void OnStepCompleted()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public class TutorialHighlightTargeter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000768")]
		[SerializeField]
		protected List<TutorialTargetData> tutorialTargets;

		[Cpp2IlInjected.Token(Token = "0x6000B6B")]
		[Cpp2IlInjected.Address(RVA = "0x82F8040", Offset = "0x82F6A40", VA = "0x1882F8040", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6C")]
		[Cpp2IlInjected.Address(RVA = "0x82F81B0", Offset = "0x82F6BB0", VA = "0x1882F81B0", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6D")]
		[Cpp2IlInjected.Address(RVA = "0x82F84A0", Offset = "0x82F6EA0", VA = "0x1882F84A0")]
		private void RegisterTargets()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B6E")]
		[Cpp2IlInjected.Address(RVA = "0x82F8640", Offset = "0x82F7040", VA = "0x1882F8640")]
		public TutorialHighlightTargeter()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000FA")]
	public class TutorialTargetData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000769")]
		public string TutorialId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400076A")]
		public string StepId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400076B")]
		public RectTransform Target;

		[Cpp2IlInjected.Token(Token = "0x6000B6F")]
		[Cpp2IlInjected.Address(RVA = "0x82FC590", Offset = "0x82FAF90", VA = "0x1882FC590")]
		public TutorialTargetData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	public enum PopoverAnchor
	{
		[Cpp2IlInjected.Token(Token = "0x400076D")]
		TopLeft,
		[Cpp2IlInjected.Token(Token = "0x400076E")]
		TopCenter,
		[Cpp2IlInjected.Token(Token = "0x400076F")]
		TopRight,
		[Cpp2IlInjected.Token(Token = "0x4000770")]
		UpperLeft,
		[Cpp2IlInjected.Token(Token = "0x4000771")]
		MiddleLeft,
		[Cpp2IlInjected.Token(Token = "0x4000772")]
		LowerLeft,
		[Cpp2IlInjected.Token(Token = "0x4000773")]
		UpperRight,
		[Cpp2IlInjected.Token(Token = "0x4000774")]
		MiddleRight,
		[Cpp2IlInjected.Token(Token = "0x4000775")]
		LowerRight,
		[Cpp2IlInjected.Token(Token = "0x4000776")]
		BottomLeft,
		[Cpp2IlInjected.Token(Token = "0x4000777")]
		BottomCenter,
		[Cpp2IlInjected.Token(Token = "0x4000778")]
		BottomRight,
		[Cpp2IlInjected.Token(Token = "0x4000779")]
		MiddleCenter
	}
	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	public class TutorialStep
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x72")]
		[Cpp2IlInjected.Token(Token = "0x400078E")]
		private bool isActive;

		[Cpp2IlInjected.Token(Token = "0x170002E6")]
		public string Id
		{
			[Cpp2IlInjected.Token(Token = "0x6000B70")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B71")]
			[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E7")]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x6000B72")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B73")]
			[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E8")]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000B74")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B75")]
			[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002E9")]
		public Sprite Icon
		{
			[Cpp2IlInjected.Token(Token = "0x6000B76")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B77")]
			[Cpp2IlInjected.Address(RVA = "0xAAE150", Offset = "0xAACB50", VA = "0x180AAE150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002EA")]
		public string ButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x6000B78")]
			[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B79")]
			[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002EB")]
		public string CountText
		{
			[Cpp2IlInjected.Token(Token = "0x6000B7A")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B7B")]
			[Cpp2IlInjected.Address(RVA = "0xAB5A80", Offset = "0xAB4480", VA = "0x180AB5A80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002EC")]
		public bool HasButtonToGoForward
		{
			[Cpp2IlInjected.Token(Token = "0x6000B7C")]
			[Cpp2IlInjected.Address(RVA = "0xDB85B0", Offset = "0xDB6FB0", VA = "0x180DB85B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B7D")]
			[Cpp2IlInjected.Address(RVA = "0xEA4E70", Offset = "0xEA3870", VA = "0x180EA4E70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002ED")]
		public bool HasButtonToGoBack
		{
			[Cpp2IlInjected.Token(Token = "0x6000B7E")]
			[Cpp2IlInjected.Address(RVA = "0xF34AA0", Offset = "0xF334A0", VA = "0x180F34AA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B7F")]
			[Cpp2IlInjected.Address(RVA = "0xF334C0", Offset = "0xF31EC0", VA = "0x180F334C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002EE")]
		public bool ShowCountText
		{
			[Cpp2IlInjected.Token(Token = "0x6000B80")]
			[Cpp2IlInjected.Address(RVA = "0x21EF3F0", Offset = "0x21EDDF0", VA = "0x1821EF3F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B81")]
			[Cpp2IlInjected.Address(RVA = "0x21EEC70", Offset = "0x21ED670", VA = "0x1821EEC70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002EF")]
		public bool ShowExitButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000B82")]
			[Cpp2IlInjected.Address(RVA = "0x22F4ED0", Offset = "0x22F38D0", VA = "0x1822F4ED0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B83")]
			[Cpp2IlInjected.Address(RVA = "0x82FC580", Offset = "0x82FAF80", VA = "0x1882FC580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F0")]
		public bool CanSoftExit
		{
			[Cpp2IlInjected.Token(Token = "0x6000B84")]
			[Cpp2IlInjected.Address(RVA = "0x19D98C0", Offset = "0x19D82C0", VA = "0x1819D98C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B85")]
			[Cpp2IlInjected.Address(RVA = "0x19F8950", Offset = "0x19F7350", VA = "0x1819F8950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F1")]
		public bool AllowInteraction
		{
			[Cpp2IlInjected.Token(Token = "0x6000B86")]
			[Cpp2IlInjected.Address(RVA = "0x78019D0", Offset = "0x78003D0", VA = "0x1878019D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B87")]
			[Cpp2IlInjected.Address(RVA = "0x78B38E0", Offset = "0x78B22E0", VA = "0x1878B38E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F2")]
		public bool TargetingHUD
		{
			[Cpp2IlInjected.Token(Token = "0x6000B88")]
			[Cpp2IlInjected.Address(RVA = "0x78019C0", Offset = "0x78003C0", VA = "0x1878019C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B89")]
			[Cpp2IlInjected.Address(RVA = "0x78019F0", Offset = "0x78003F0", VA = "0x1878019F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F3")]
		public PopoverAnchor DialogAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8A")]
			[Cpp2IlInjected.Address(RVA = "0xB2F870", Offset = "0xB2E270", VA = "0x180B2F870")]
			[CompilerGenerated]
			get
			{
				return default(PopoverAnchor);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B8B")]
			[Cpp2IlInjected.Address(RVA = "0x1004F20", Offset = "0x1003920", VA = "0x181004F20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F4")]
		public RectTransform TutorialHighlightTarget
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8C")]
			[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000B8D")]
			[Cpp2IlInjected.Address(RVA = "0xAB4880", Offset = "0xAB3280", VA = "0x180AB4880")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F5")]
		public EBDGCEEEFPM OnStepCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8E")]
			[Cpp2IlInjected.Address(RVA = "0xAB4840", Offset = "0xAB3240", VA = "0x180AB4840")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F6")]
		public EBDGCEEEFPM OnStepModified
		{
			[Cpp2IlInjected.Token(Token = "0x6000B8F")]
			[Cpp2IlInjected.Address(RVA = "0xAB4850", Offset = "0xAB3250", VA = "0x180AB4850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F7")]
		public EBDGCEEEFPM OnGoBack
		{
			[Cpp2IlInjected.Token(Token = "0x6000B90")]
			[Cpp2IlInjected.Address(RVA = "0xAB4870", Offset = "0xAB3270", VA = "0x180AB4870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F8")]
		public bool ShouldShow
		{
			[Cpp2IlInjected.Token(Token = "0x6000B91")]
			[Cpp2IlInjected.Address(RVA = "0xEC9A90", Offset = "0xEC8490", VA = "0x180EC9A90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B92")]
			[Cpp2IlInjected.Address(RVA = "0x1050500", Offset = "0x104EF00", VA = "0x181050500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002F9")]
		public bool CompleteStepOnButtonPress
		{
			[Cpp2IlInjected.Token(Token = "0x6000B93")]
			[Cpp2IlInjected.Address(RVA = "0x1341190", Offset = "0x133FB90", VA = "0x181341190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000B94")]
			[Cpp2IlInjected.Address(RVA = "0x19CA6A0", Offset = "0x19C90A0", VA = "0x1819CA6A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000B95")]
		[Cpp2IlInjected.Address(RVA = "0x82FC3B0", Offset = "0x82FADB0", VA = "0x1882FC3B0")]
		public TutorialStep(string id, string title, string description, Sprite icon, string buttonText, bool showExitButton, bool canSoftExit, bool canGoBack, bool canGoForward, bool showCount, bool allowInteraction, bool targetingHud, PopoverAnchor dialogAnchor, bool shouldShow, bool completeStepOnButtonPress)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B96")]
		[Cpp2IlInjected.Address(RVA = "0x82FC1C0", Offset = "0x82FABC0", VA = "0x1882FC1C0")]
		public void SetHighlightTarget(RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B97")]
		[Cpp2IlInjected.Address(RVA = "0x82FC180", Offset = "0x82FAB80", VA = "0x1882FC180")]
		public void SetCountText(string countText)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B98")]
		[Cpp2IlInjected.Address(RVA = "0x82FBE80", Offset = "0x82FA880", VA = "0x1882FBE80")]
		public void BeginStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B99")]
		[Cpp2IlInjected.Address(RVA = "0x82FC040", Offset = "0x82FAA40", VA = "0x1882FC040")]
		private void DeactiveStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9A")]
		[Cpp2IlInjected.Address(RVA = "0x82FC010", Offset = "0x82FAA10", VA = "0x1882FC010")]
		public void CompleteStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9B")]
		[Cpp2IlInjected.Address(RVA = "0x82FC150", Offset = "0x82FAB50", VA = "0x1882FC150")]
		public void GoBack()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9C")]
		[Cpp2IlInjected.Address(RVA = "0x82FBFD0", Offset = "0x82FA9D0", VA = "0x1882FBFD0")]
		public void ChangeTitle(string newTitle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000B9D")]
		[Cpp2IlInjected.Address(RVA = "0x82FBF90", Offset = "0x82FA990", VA = "0x1882FBF90")]
		public void ChangeDescription(string newDescription)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FD")]
	[ViewModel]
	public class TutorialStepViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x20000FE")]
		[CompilerGenerated]
		private sealed class <UpdateVisualsCoroutine>d__68 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007B3")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007B4")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007B5")]
			public TutorialStepViewModel <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700030A")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000BE1")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700030B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000BE3")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000BDE")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public <UpdateVisualsCoroutine>d__68(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BDF")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000BE0")]
			[Cpp2IlInjected.Address(RVA = "0x82FEDF0", Offset = "0x82FD7F0", VA = "0x1882FEDF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000BE2")]
			[Cpp2IlInjected.Address(RVA = "0x82FEEB0", Offset = "0x82FD8B0", VA = "0x1882FEEB0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400078F")]
		[SerializeField]
		private RectTransform highlightArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000790")]
		[SerializeField]
		private RectTransform dialogTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000791")]
		[SerializeField]
		private float maskPadding;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000792")]
		[SerializeField]
		private float additionalAnchorOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000793")]
		[SerializeField]
		private CanvasScreenSizeRefitter canvasScreenSizeRefitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000794")]
		[SerializeField]
		private PopoverCornerController popoverCornerController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000795")]
		private TutorialStep step;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000796")]
		private Coroutine updateVisualsCoroutine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000797")]
		private Canvas targetCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000798")]
		private string title;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000799")]
		private string description;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400079A")]
		private string buttonText;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400079B")]
		private bool showMainButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x91")]
		[Cpp2IlInjected.Token(Token = "0x400079C")]
		private bool canInteractWithHighlightArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x92")]
		[Cpp2IlInjected.Token(Token = "0x400079D")]
		private bool showExitButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x93")]
		[Cpp2IlInjected.Token(Token = "0x400079E")]
		private bool showNextArrowButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400079F")]
		private bool showBackArrowButton;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40007A0")]
		private string countText;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40007A1")]
		private bool hasIcon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40007A2")]
		private Sprite icon;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40007A3")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40007A4")]
		private DataItem<string> TitleDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40007A5")]
		private DataItem<string> DescriptionDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40007A6")]
		private DataItem<string> ButtonTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40007A7")]
		private DataItem<bool> ShowMainButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40007A8")]
		private DataItem<bool> CanInteractWithHighlightAreaDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40007A9")]
		private DataItem<bool> ShowExitButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40007AA")]
		private DataItem<bool> ShowNextArrowButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40007AB")]
		private DataItem<bool> ShowBackArrowButtonDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40007AC")]
		private DataItem<string> CountTextDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40007AD")]
		private DataItem<bool> HasIconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40007AE")]
		private DataItem<Sprite> IconDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40007AF")]
		private DataItemAction GoToNextStepDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40007B0")]
		private DataItemAction SkipTutorialDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40007B1")]
		private DataItemAction SoftExitTutorialDataItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40007B2")]
		private DataItemAction GoToPreviousStepDataItem;

		[Cpp2IlInjected.Token(Token = "0x170002FA")]
		private Camera screenCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9E")]
			[Cpp2IlInjected.Address(RVA = "0x1953AA0", Offset = "0x19524A0", VA = "0x181953AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FB")]
		private Canvas sourceCanvas
		{
			[Cpp2IlInjected.Token(Token = "0x6000B9F")]
			[Cpp2IlInjected.Address(RVA = "0x82FBC30", Offset = "0x82FA630", VA = "0x1882FBC30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FC")]
		private RectTransform sourceCanvasRect
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA0")]
			[Cpp2IlInjected.Address(RVA = "0x82FBBB0", Offset = "0x82FA5B0", VA = "0x1882FBBB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FD")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public string Title
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA1")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B30", Offset = "0xAB6530", VA = "0x180AB7B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA2")]
			[Cpp2IlInjected.Address(RVA = "0x82FA850", Offset = "0x82F9250", VA = "0x1882FA850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FE")]
		[BindableData(1, null, DataPermissions.ReadWrite)]
		public string Description
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA3")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B40", Offset = "0xAB6540", VA = "0x180AB7B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA4")]
			[Cpp2IlInjected.Address(RVA = "0x82FBD50", Offset = "0x82FA750", VA = "0x1882FBD50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170002FF")]
		[BindableData(2, null, DataPermissions.ReadWrite)]
		public string ButtonText
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA5")]
			[Cpp2IlInjected.Address(RVA = "0xAB7B50", Offset = "0xAB6550", VA = "0x180AB7B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA6")]
			[Cpp2IlInjected.Address(RVA = "0x82FBC50", Offset = "0x82FA650", VA = "0x1882FBC50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000300")]
		[BindableData(3, null, DataPermissions.ReadWrite)]
		public bool ShowMainButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA7")]
			[Cpp2IlInjected.Address(RVA = "0xADD9C0", Offset = "0xADC3C0", VA = "0x180ADD9C0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BA8")]
			[Cpp2IlInjected.Address(RVA = "0x82FA8F0", Offset = "0x82F92F0", VA = "0x1882FA8F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000301")]
		[BindableData(4, null, DataPermissions.ReadWrite)]
		public bool CanInteractWithHighlightArea
		{
			[Cpp2IlInjected.Token(Token = "0x6000BA9")]
			[Cpp2IlInjected.Address(RVA = "0x10F1C70", Offset = "0x10F0670", VA = "0x1810F1C70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BAA")]
			[Cpp2IlInjected.Address(RVA = "0x82FA950", Offset = "0x82F9350", VA = "0x1882FA950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000302")]
		[BindableData(5, null, DataPermissions.ReadWrite)]
		public bool ShowExitButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000BAB")]
			[Cpp2IlInjected.Address(RVA = "0x1899370", Offset = "0x1897D70", VA = "0x181899370")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BAC")]
			[Cpp2IlInjected.Address(RVA = "0x82FA6C0", Offset = "0x82F90C0", VA = "0x1882FA6C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000303")]
		[BindableData(6, null, DataPermissions.ReadWrite)]
		public bool ShowNextArrowButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000BAD")]
			[Cpp2IlInjected.Address(RVA = "0x1899380", Offset = "0x1897D80", VA = "0x181899380")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BAE")]
			[Cpp2IlInjected.Address(RVA = "0x82FA720", Offset = "0x82F9120", VA = "0x1882FA720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000304")]
		[BindableData(7, null, DataPermissions.ReadWrite)]
		public bool ShowBackArrowButton
		{
			[Cpp2IlInjected.Token(Token = "0x6000BAF")]
			[Cpp2IlInjected.Address(RVA = "0x1F85E50", Offset = "0x1F84850", VA = "0x181F85E50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB0")]
			[Cpp2IlInjected.Address(RVA = "0x82FA780", Offset = "0x82F9180", VA = "0x1882FA780")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000305")]
		[BindableData(8, null, DataPermissions.ReadWrite)]
		public string CountText
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB1")]
			[Cpp2IlInjected.Address(RVA = "0xAB7A80", Offset = "0xAB6480", VA = "0x180AB7A80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB2")]
			[Cpp2IlInjected.Address(RVA = "0x82FBCD0", Offset = "0x82FA6D0", VA = "0x1882FBCD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000306")]
		[BindableData(9, null, DataPermissions.ReadWrite)]
		public bool HasIcon
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB3")]
			[Cpp2IlInjected.Address(RVA = "0xB2F7E0", Offset = "0xB2E1E0", VA = "0x180B2F7E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB4")]
			[Cpp2IlInjected.Address(RVA = "0x82FA7F0", Offset = "0x82F91F0", VA = "0x1882FA7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000307")]
		[BindableData(10, null, DataPermissions.ReadWrite)]
		public Sprite Icon
		{
			[Cpp2IlInjected.Token(Token = "0x6000BB5")]
			[Cpp2IlInjected.Address(RVA = "0xAB9520", Offset = "0xAB7F20", VA = "0x180AB9520")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BB6")]
			[Cpp2IlInjected.Address(RVA = "0x82FBDD0", Offset = "0x82FA7D0", VA = "0x1882FBDD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000308")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000BC3")]
			[Cpp2IlInjected.Address(RVA = "0x82FBB70", Offset = "0x82FA570", VA = "0x1882FBB70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000309")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000BC4")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB7")]
		[Cpp2IlInjected.Address(RVA = "0x82F9580", Offset = "0x82F7F80", VA = "0x1882F9580")]
		[BindableAction(100, null)]
		public void GoToNextStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB8")]
		[Cpp2IlInjected.Address(RVA = "0x82FA560", Offset = "0x82F8F60", VA = "0x1882FA560")]
		[BindableAction(101, null)]
		public void SkipTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BB9")]
		[Cpp2IlInjected.Address(RVA = "0x82FA610", Offset = "0x82F9010", VA = "0x1882FA610")]
		[BindableAction(102, null)]
		public void SoftExitTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBA")]
		[Cpp2IlInjected.Address(RVA = "0x82F95D0", Offset = "0x82F7FD0", VA = "0x1882F95D0")]
		[BindableAction(103, null)]
		public void GoToPreviousStep()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBB")]
		[Cpp2IlInjected.Address(RVA = "0x82FA420", Offset = "0x82F8E20", VA = "0x1882FA420")]
		public void Set(TutorialStep step)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBC")]
		[Cpp2IlInjected.Address(RVA = "0x82FA3C0", Offset = "0x82F8DC0", VA = "0x1882FA3C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBD")]
		[Cpp2IlInjected.Address(RVA = "0x82FA380", Offset = "0x82F8D80", VA = "0x1882FA380")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBE")]
		[Cpp2IlInjected.Address(RVA = "0x82FA2C0", Offset = "0x82F8CC0", VA = "0x1882FA2C0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BBF")]
		[Cpp2IlInjected.Address(RVA = "0x82FA9B0", Offset = "0x82F93B0", VA = "0x1882FA9B0")]
		private void UpdateStepData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC0")]
		[Cpp2IlInjected.Address(RVA = "0x82FAFC0", Offset = "0x82F99C0", VA = "0x1882FAFC0")]
		[IteratorStateMachine(typeof(<UpdateVisualsCoroutine>d__68))]
		private IEnumerator UpdateVisualsCoroutine()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC1")]
		[Cpp2IlInjected.Address(RVA = "0x82FB040", Offset = "0x82F9A40", VA = "0x1882FB040")]
		private void UpdateVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC2")]
		[Cpp2IlInjected.Address(RVA = "0x82F89E0", Offset = "0x82F73E0", VA = "0x1882F89E0")]
		private void AlignEdgeToEdge(RectTransform source, RectTransform target, TextAnchor sourceEdge, TextAnchor targetEdge)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC5")]
		[Cpp2IlInjected.Address(RVA = "0x82F9620", Offset = "0x82F8020", VA = "0x1882F9620", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC6")]
		[Cpp2IlInjected.Address(RVA = "0x82F92F0", Offset = "0x82F7CF0", VA = "0x1882F92F0")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BC7")]
		[Cpp2IlInjected.Address(RVA = "0x82FB6C0", Offset = "0x82FA0C0", VA = "0x1882FB6C0")]
		public TutorialStepViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000FF")]
	public class TutorialUIManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40007B7")]
		public static EBDGCEEEFPM OnCreated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007B9")]
		public EBDGCEEEFPM OnDataUpdated;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007BA")]
		private Dictionary<string, Dictionary<string, RectTransform>> tutorialTargets;

		[Cpp2IlInjected.Token(Token = "0x1700030C")]
		public static TutorialUIManager Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE4")]
			[Cpp2IlInjected.Address(RVA = "0x82FD560", Offset = "0x82FBF60", VA = "0x1882FD560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE5")]
			[Cpp2IlInjected.Address(RVA = "0x82FD5B0", Offset = "0x82FBFB0", VA = "0x1882FD5B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030D")]
		public Tutorial ActiveTutorial
		{
			[Cpp2IlInjected.Token(Token = "0x6000BE6")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000BE7")]
			[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE8")]
		[Cpp2IlInjected.Address(RVA = "0x82FC600", Offset = "0x82FB000", VA = "0x1882FC600")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BE9")]
		[Cpp2IlInjected.Address(RVA = "0x82FC8D0", Offset = "0x82FB2D0", VA = "0x1882FC8D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEA")]
		[Cpp2IlInjected.Address(RVA = "0x82FC740", Offset = "0x82FB140", VA = "0x1882FC740")]
		private void ClearActiveTutorial()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEB")]
		[Cpp2IlInjected.Address(RVA = "0x82FC750", Offset = "0x82FB150", VA = "0x1882FC750")]
		private void ClearActiveTutorial(bool sendUpdate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEC")]
		[Cpp2IlInjected.Address(RVA = "0x82FCD40", Offset = "0x82FB740", VA = "0x1882FCD40")]
		public void StartTutorial(Tutorial tutorial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BED")]
		[Cpp2IlInjected.Address(RVA = "0x82FC840", Offset = "0x82FB240", VA = "0x1882FC840")]
		public void EndTutorial(bool showAgain)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEE")]
		[Cpp2IlInjected.Address(RVA = "0x82FCA00", Offset = "0x82FB400", VA = "0x1882FCA00")]
		public void RegisterTutorialTarget(string tutorialId, string stepId, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BEF")]
		[Cpp2IlInjected.Address(RVA = "0x82FD120", Offset = "0x82FBB20", VA = "0x1882FD120")]
		public void UnregisterTutorialTarget(string tutorialId, string stepId, RectTransform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF0")]
		[Cpp2IlInjected.Address(RVA = "0x82FD490", Offset = "0x82FBE90", VA = "0x1882FD490")]
		public TutorialUIManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[ViewModel]
	public class TutorialUIViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007BB")]
		[SerializeField]
		private CanvasScreenSizeRefitter canvasScreenSizeRefitter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007BC")]
		[SerializeField]
		private Canvas canvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007BD")]
		[SerializeField]
		private TutorialStepViewModel tutorialStepViewModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007BE")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007BF")]
		private Tutorial activeTutorial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007C0")]
		private bool isTutorialActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007C1")]
		private List<IDataItem> generatedDataItemList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40007C2")]
		private DataItem<bool> IsTutorialActiveDataItem;

		[Cpp2IlInjected.Token(Token = "0x1700030E")]
		[BindableData(0, null, DataPermissions.ReadWrite)]
		public bool IsTutorialActive
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF2")]
			[Cpp2IlInjected.Address(RVA = "0xABA770", Offset = "0xAB9170", VA = "0x180ABA770")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000BF3")]
			[Cpp2IlInjected.Address(RVA = "0x82FDF60", Offset = "0x82FC960", VA = "0x1882FDF60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700030F")]
		protected override List<IDataItem> DataItemList
		{
			[Cpp2IlInjected.Token(Token = "0x6000BF9")]
			[Cpp2IlInjected.Address(RVA = "0x82FE050", Offset = "0x82FCA50", VA = "0x1882FE050", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000310")]
		protected override bool UseReflection
		{
			[Cpp2IlInjected.Token(Token = "0x6000BFA")]
			[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF4")]
		[Cpp2IlInjected.Address(RVA = "0x82FD620", Offset = "0x82FC020", VA = "0x1882FD620", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF5")]
		[Cpp2IlInjected.Address(RVA = "0x82FDE40", Offset = "0x82FC840", VA = "0x1882FDE40")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF6")]
		[Cpp2IlInjected.Address(RVA = "0x82FD930", Offset = "0x82FC330", VA = "0x1882FD930", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF7")]
		[Cpp2IlInjected.Address(RVA = "0x82FDDC0", Offset = "0x82FC7C0", VA = "0x1882FDDC0")]
		private void OnStepChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BF8")]
		[Cpp2IlInjected.Address(RVA = "0x82FDAD0", Offset = "0x82FC4D0", VA = "0x1882FDAD0")]
		private void OnManagerUpdated()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFB")]
		[Cpp2IlInjected.Address(RVA = "0x82FD7E0", Offset = "0x82FC1E0", VA = "0x1882FD7E0", Slot = "11")]
		protected override void InitializeDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFC")]
		[Cpp2IlInjected.Address(RVA = "0x82FD730", Offset = "0x82FC130", VA = "0x1882FD730")]
		private void GatherDataItems()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000BFD")]
		[Cpp2IlInjected.Address(RVA = "0x82FDFC0", Offset = "0x82FC9C0", VA = "0x1882FDFC0")]
		public TutorialUIViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CreateAssetMenu(fileName = "UITutorialData", menuName = "RecRoom/UI/UI Tutorial Data")]
	public class UITutorialData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000102")]
		private class TutorialStepData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40007C5")]
			public string Id;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40007C6")]
			public string Title;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40007C7")]
			public string Description;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40007C8")]
			public Sprite OptionalIcon;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40007C9")]
			public string ButtonText;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40007CA")]
			public bool ShowButtonToGoForward;

			[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
			[Cpp2IlInjected.Token(Token = "0x40007CB")]
			public bool ShowButtonToGoBack;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
			[Cpp2IlInjected.Token(Token = "0x40007CC")]
			public bool ShowCountText;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3B")]
			[Cpp2IlInjected.Token(Token = "0x40007CD")]
			public bool ShowExitButton;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40007CE")]
			public bool CanSoftExit;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
			[Cpp2IlInjected.Token(Token = "0x40007CF")]
			public bool AllowInteraction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3E")]
			[Cpp2IlInjected.Token(Token = "0x40007D0")]
			public bool TargetingHUD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3F")]
			[Cpp2IlInjected.Token(Token = "0x40007D1")]
			public bool ShouldShow;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40007D2")]
			public bool CompleteStepOnButtonPress;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x40007D3")]
			public PopoverAnchor DialogAnchor;

			[Cpp2IlInjected.Token(Token = "0x6000C02")]
			[Cpp2IlInjected.Address(RVA = "0x82F86D0", Offset = "0x82F70D0", VA = "0x1882F86D0")]
			public TutorialStep ToTutorialStep()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000C03")]
			[Cpp2IlInjected.Address(RVA = "0x82F8920", Offset = "0x82F7320", VA = "0x1882F8920")]
			public TutorialStepData()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007C3")]
		[SerializeField]
		private string id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007C4")]
		[SerializeField]
		private List<TutorialStepData> steps;

		[Cpp2IlInjected.Token(Token = "0x6000C00")]
		[Cpp2IlInjected.Address(RVA = "0x82FF540", Offset = "0x82FDF40", VA = "0x1882FF540")]
		public Tutorial GenerateTutorialFromData()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C01")]
		[Cpp2IlInjected.Address(RVA = "0x82FF730", Offset = "0x82FE130", VA = "0x1882FF730")]
		public UITutorialData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000103")]
	public enum UILinkType
	{
		[Cpp2IlInjected.Token(Token = "0x40007D5")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40007D6")]
		Uri,
		[Cpp2IlInjected.Token(Token = "0x40007D7")]
		Tab,
		[Cpp2IlInjected.Token(Token = "0x40007D8")]
		Legacy
	}
	[Cpp2IlInjected.Token(Token = "0x2000104")]
	public enum LegacyUIType
	{
		[Cpp2IlInjected.Token(Token = "0x40007DA")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40007DB")]
		Challenges,
		[Cpp2IlInjected.Token(Token = "0x40007DC")]
		Outfits
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000105")]
	public class LinkInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40007DD")]
		public string Id;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007DE")]
		public UILinkType LinkType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007DF")]
		[FFBOEEGEIOD("requiresUri")]
		public Uri LinkUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E0")]
		[FFBOEEGEIOD("LinkType", UILinkType.Tab)]
		public KMNADGLDMBL LinkTab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40007E1")]
		[FFBOEEGEIOD("LinkType", UILinkType.Legacy)]
		public LegacyUIType LegacyType;

		[Cpp2IlInjected.Token(Token = "0x17000311")]
		public bool IsLegacyUI
		{
			[Cpp2IlInjected.Token(Token = "0x6000C04")]
			[Cpp2IlInjected.Address(RVA = "0x237A490", Offset = "0x2378E90", VA = "0x18237A490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C05")]
		[Cpp2IlInjected.Address(RVA = "0x82F7160", Offset = "0x82F5B60", VA = "0x1882F7160")]
		public LinkInfo()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000106")]
	[CreateAssetMenu(fileName = "RouteLookup", menuName = "RecRoom/UI/Route Lookup")]
	public class UILinkLookup : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007E2")]
		[FormerlySerializedAs("routeInfos")]
		[SerializeField]
		private List<LinkInfo> linkInfoList;

		[Cpp2IlInjected.Token(Token = "0x6000C06")]
		[Cpp2IlInjected.Address(RVA = "0x82FF200", Offset = "0x82FDC00", VA = "0x1882FF200")]
		public bool TryGetLinkInfo(string alias, [Out] LinkInfo linkInfo)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C07")]
		[Cpp2IlInjected.Address(RVA = "0x82FF380", Offset = "0x82FDD80", VA = "0x1882FF380")]
		public bool TryGetUri(string routeId, [Out] Uri uri)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C08")]
		[Cpp2IlInjected.Address(RVA = "0x82FEF00", Offset = "0x82FD900", VA = "0x1882FEF00")]
		public List<Uri> GetAllUri()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C09")]
		[Cpp2IlInjected.Address(RVA = "0x82FF080", Offset = "0x82FDA80", VA = "0x1882FF080")]
		public bool TryGetLegacyUIType(string routeId, [Out] LegacyUIType legacyUIType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0A")]
		[Cpp2IlInjected.Address(RVA = "0xD5D430", Offset = "0xD5BE30", VA = "0x180D5D430")]
		public UILinkLookup()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	public class WatchViewModel : RRUIBaseGlobalViewModel
	{
		[Cpp2IlInjected.Token(Token = "0x40007E3")]
		private const string UnifiedUISessionIdKey = "unified_ui_session_id";

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007E4")]
		[SerializeField]
		private ImpressionTracker impressionTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007E5")]
		private IMenuManager _menuManager;

		[Cpp2IlInjected.Token(Token = "0x6000C0B")]
		[Cpp2IlInjected.Address(RVA = "0x82FF7E0", Offset = "0x82FE1E0", VA = "0x1882FF7E0", Slot = "8")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0C")]
		[Cpp2IlInjected.Address(RVA = "0x82FFA70", Offset = "0x82FE470", VA = "0x1882FFA70", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0D")]
		[Cpp2IlInjected.Address(RVA = "0x82FFB40", Offset = "0x82FE540", VA = "0x1882FFB40")]
		private void OnWatchMenuUnifiedSessionIdChanged(Guid watchMenuUnifiedSessionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C0E")]
		[Cpp2IlInjected.Address(RVA = "0x82F7520", Offset = "0x82F5F20", VA = "0x1882F7520")]
		public WatchViewModel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000108")]
	public class CanvasScreenSizeRefitter : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007E6")]
		[SerializeField]
		private Canvas targetCanvas;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007E7")]
		[SerializeField]
		private float minPercentageOfScreenHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40007E8")]
		[SerializeField]
		private float maxPercentageOfScreenHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007E9")]
		[SerializeField]
		private float offsetFromNearClipPlane;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007EA")]
		[SerializeField]
		private Camera lookAtCamera;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007EB")]
		[SerializeField]
		private bool updateOnCameraMove;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x40007EC")]
		[SerializeField]
		private bool useScreenSafeArea;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A")]
		[Cpp2IlInjected.Token(Token = "0x40007ED")]
		[SerializeField]
		private bool forceWidthToFitScreen;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40007EE")]
		private Vector2 cachedDimensions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40007EF")]
		private Vector2 cachedSafeAreaDimensions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40007F0")]
		private Vector3 cachedCameraPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007F1")]
		private Quaternion cachedCameraRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40007F2")]
		private float cachedFov;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40007F3")]
		private bool forceUpdate;

		[Cpp2IlInjected.Token(Token = "0x17000312")]
		public Canvas TargetCanvas
		{
			[Cpp2IlInjected.Token(Token = "0x6000C0F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000313")]
		public Camera TargetCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000C10")]
			[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000314")]
		public float OffsetFromCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000C11")]
			[Cpp2IlInjected.Address(RVA = "0x82F0770", Offset = "0x82EF170", VA = "0x1882F0770")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000315")]
		private float cameraFov
		{
			[Cpp2IlInjected.Token(Token = "0x6000C12")]
			[Cpp2IlInjected.Address(RVA = "0x82F0800", Offset = "0x82EF200", VA = "0x1882F0800")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000316")]
		private Vector3 cameraPosition
		{
			[Cpp2IlInjected.Token(Token = "0x6000C13")]
			[Cpp2IlInjected.Address(RVA = "0x82F0890", Offset = "0x82EF290", VA = "0x1882F0890")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000317")]
		private Quaternion cameraRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000C14")]
			[Cpp2IlInjected.Address(RVA = "0x82F0970", Offset = "0x82EF370", VA = "0x1882F0970")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000318")]
		private RectTransform canvasRect
		{
			[Cpp2IlInjected.Token(Token = "0x6000C15")]
			[Cpp2IlInjected.Address(RVA = "0x82F0A40", Offset = "0x82EF440", VA = "0x1882F0A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C16")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		public void SetLookCamera(Camera lookAt)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C17")]
		[Cpp2IlInjected.Address(RVA = "0xB27890", Offset = "0xB26290", VA = "0x180B27890")]
		public void ForceUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C18")]
		[Cpp2IlInjected.Address(RVA = "0x82EFA20", Offset = "0x82EE420", VA = "0x1882EFA20")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C19")]
		[Cpp2IlInjected.Address(RVA = "0x82F0200", Offset = "0x82EEC00", VA = "0x1882F0200")]
		private void UpdateScale()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1A")]
		[Cpp2IlInjected.Address(RVA = "0x82EFCC0", Offset = "0x82EE6C0", VA = "0x1882EFCC0")]
		public void PinToTopLeftOfScreen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1B")]
		[Cpp2IlInjected.Address(RVA = "0x82F0650", Offset = "0x82EF050", VA = "0x1882F0650")]
		public CanvasScreenSizeRefitter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000109")]
	[DisallowMultipleComponent]
	public class FocusableAllowedStateHelper : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200010A")]
		public enum StateOverrideSource
		{
			[Cpp2IlInjected.Token(Token = "0x40007FF")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000800")]
			Statsig,
			[Cpp2IlInjected.Token(Token = "0x4000801")]
			GameConfig
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40007F4")]
		private string defaultStatsigLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40007F5")]
		private string defaultStatsigParam;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40007F6")]
		[SerializeField]
		private FocusableUI focusable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40007F7")]
		[SerializeField]
		private StateOverrideSource overrideSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40007F8")]
		[ConditionalVisibility("overrideSource", ConditionResultType.ShowIfEquals, 1)]
		[SerializeField]
		private string statsigLayerOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40007F9")]
		[SerializeField]
		[ConditionalVisibility("overrideSource", ConditionResultType.ShowIfEquals, 1)]
		private string statsigParameterOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40007FA")]
		[ConditionalVisibility("overrideSource", ConditionResultType.ShowIfEquals, 2)]
		[SerializeField]
		private string gameConfigKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40007FB")]
		private JLFIJNDEFBP configProvider;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40007FC")]
		private CMANBFFCBML statsig;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40007FD")]
		private bool allowed;

		[Cpp2IlInjected.Token(Token = "0x6000C1C")]
		[Cpp2IlInjected.Address(RVA = "0x82F0ED0", Offset = "0x82EF8D0", VA = "0x1882F0ED0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1D")]
		[Cpp2IlInjected.Address(RVA = "0x82F1610", Offset = "0x82F0010", VA = "0x1882F1610")]
		private void UpdateWhenStatsigReady()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1E")]
		[Cpp2IlInjected.Address(RVA = "0x82F1390", Offset = "0x82EFD90", VA = "0x1882F1390")]
		private void UpdateFromStatsig()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C1F")]
		[Cpp2IlInjected.Address(RVA = "0x82F1560", Offset = "0x82EFF60", VA = "0x1882F1560")]
		private void UpdateWhenConfigReady()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C20")]
		[Cpp2IlInjected.Address(RVA = "0x82F1170", Offset = "0x82EFB70", VA = "0x1882F1170")]
		private void UpdateFromGameConfig()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C21")]
		[Cpp2IlInjected.Address(RVA = "0x82F16C0", Offset = "0x82F00C0", VA = "0x1882F16C0")]
		public FocusableAllowedStateHelper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	public class FocusStateHelper : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000802")]
		[SerializeField]
		[IHBEENDFBCJ(EAHEBLGAGFP.Self, false, false, false)]
		private Selectable focusable;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000803")]
		public UnityEvent<BaseEventData> FocusGained;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000804")]
		public UnityEvent<BaseEventData> FocusLost;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000805")]
		public UnityEvent OnEnabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000806")]
		public UnityEvent OnDisabled;

		[Cpp2IlInjected.Token(Token = "0x6000C22")]
		[Cpp2IlInjected.Address(RVA = "0x82F0AA0", Offset = "0x82EF4A0", VA = "0x1882F0AA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C23")]
		[Cpp2IlInjected.Address(RVA = "0x82F0BE0", Offset = "0x82EF5E0", VA = "0x1882F0BE0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C24")]
		[Cpp2IlInjected.Address(RVA = "0x82F0D20", Offset = "0x82EF720", VA = "0x1882F0D20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C25")]
		[Cpp2IlInjected.Address(RVA = "0x82F0D00", Offset = "0x82EF700", VA = "0x1882F0D00")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C26")]
		[Cpp2IlInjected.Address(RVA = "0x82F0D40", Offset = "0x82EF740", VA = "0x1882F0D40")]
		private void OnSelect(BaseEventData eventData, Selectable selectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C27")]
		[Cpp2IlInjected.Address(RVA = "0x82F0B80", Offset = "0x82EF580", VA = "0x1882F0B80")]
		private void OnDeselect(BaseEventData eventData, Selectable selectable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C28")]
		[Cpp2IlInjected.Address(RVA = "0x82F0DA0", Offset = "0x82EF7A0", VA = "0x1882F0DA0")]
		public FocusStateHelper()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010C")]
	public class ImpressionData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000807")]
		public Dictionary<string, int> IntData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000808")]
		public Dictionary<string, float> FloatData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000809")]
		public Dictionary<string, long> LongData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400080A")]
		public Dictionary<string, string> StringData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400080B")]
		public Dictionary<string, Guid> GuidData;

		[Cpp2IlInjected.Token(Token = "0x6000C29")]
		[Cpp2IlInjected.Address(RVA = "0x82F2430", Offset = "0x82F0E30", VA = "0x1882F2430")]
		public bool TryGetValueAsString(string key, [Out] string valString, string format = "")
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2A")]
		[Cpp2IlInjected.Address(RVA = "0x82F21F0", Offset = "0x82F0BF0", VA = "0x1882F21F0")]
		public KLBPGLFMBCI.IBADOKOGBMO TryAddProperty(string key, KLBPGLFMBCI.IBADOKOGBMO eventBuilder)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2B")]
		[Cpp2IlInjected.Address(RVA = "0x82F1880", Offset = "0x82F0280", VA = "0x1882F1880")]
		public void ClearData(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2C")]
		[Cpp2IlInjected.Address(RVA = "0x82F17A0", Offset = "0x82F01A0", VA = "0x1882F17A0")]
		public void ClearAll()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2D")]
		[Cpp2IlInjected.Address(RVA = "0x82F1AB0", Offset = "0x82F04B0", VA = "0x1882F1AB0")]
		public void CopyData(ImpressionData copyTo)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2E")]
		[Cpp2IlInjected.Address(RVA = "0x82F2610", Offset = "0x82F1010", VA = "0x1882F2610")]
		public ImpressionData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200010D")]
	public class ImpressionTracker : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200010E")]
		public enum PassToChildren
		{
			[Cpp2IlInjected.Token(Token = "0x400082D")]
			Disabled,
			[Cpp2IlInjected.Token(Token = "0x400082E")]
			Enabled,
			[Cpp2IlInjected.Token(Token = "0x400082F")]
			EnabledRecursive
		}

		[Cpp2IlInjected.Token(Token = "0x200010F")]
		[Flags]
		internal enum ImpressionLogEvents
		{
			[Cpp2IlInjected.Token(Token = "0x4000831")]
			None = 0,
			[Cpp2IlInjected.Token(Token = "0x4000832")]
			OnClickThrough = 1,
			[Cpp2IlInjected.Token(Token = "0x4000833")]
			OnNavigateToNewPage = 2,
			[Cpp2IlInjected.Token(Token = "0x4000834")]
			OnMenuClosed = 4,
			[Cpp2IlInjected.Token(Token = "0x4000835")]
			OnStopTracking = 8,
			[Cpp2IlInjected.Token(Token = "0x4000836")]
			OnDisable = 0x10
		}

		[Cpp2IlInjected.Token(Token = "0x2000110")]
		internal enum ImpressionLogConditions
		{
			[Cpp2IlInjected.Token(Token = "0x4000838")]
			NoConditions,
			[Cpp2IlInjected.Token(Token = "0x4000839")]
			OnlyWhenChildrenAreTracked
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000111")]
		[CompilerGenerated]
		private struct <FinishCleanUpAfterLoggingComplete>d__45 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400083A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400083B")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400083C")]
			public Task logTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400083D")]
			public ImpressionTracker <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400083E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000C5C")]
			[Cpp2IlInjected.Address(RVA = "0x82FE9E0", Offset = "0x82FD3E0", VA = "0x1882FE9E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C5D")]
			[Cpp2IlInjected.Address(RVA = "0xB082C0", Offset = "0xB06CC0", VA = "0x180B082C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400080C")]
		private static CNAMKBJAJEE<ImpressionData> ImpressionDataPool;

		[Cpp2IlInjected.Token(Token = "0x400080D")]
		private const float minSecondsForImpression = 0.1f;

		[Cpp2IlInjected.Token(Token = "0x400080E")]
		private const string buttonLocationProperty = "buttonLocation";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400080F")]
		[SerializeField]
		private ImpressionLogEvents logEvents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000810")]
		[SerializeField]
		private ImpressionLogConditions logConditions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000811")]
		[SerializeField]
		private VisibilityChecker visibilityChecker;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000812")]
		private ImpressionData impressionData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000813")]
		private int idCounter;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000814")]
		private Dictionary<int, string> idToKeyLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000815")]
		private Dictionary<string, int> keyToIdLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000816")]
		private List<int> recordedKeys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000817")]
		private List<int> dataToRecordOnClickThrough;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000818")]
		private List<ImpressionTracker> children;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000819")]
		private List<ImpressionTracker> tempChildrenWhileLogging;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400081A")]
		private Dictionary<int, PassToChildren> dataToPassToChildren;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400081B")]
		private List<int> dataToCollateFromChildrenOnLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400081C")]
		private Dictionary<int, int> collatedDataToRecordUnderDifferentKey;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400081D")]
		private List<int> dataToClearOnChildrenAfterLog;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400081E")]
		private Dictionary<int, string> defaultValueLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400081F")]
		private Dictionary<string, string> stringFormatLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000820")]
		private List<ImpressionData> childImpressionsNotYetLogged;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000821")]
		private List<ImpressionData> allChildImpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000822")]
		private IRRUIvNextBridge vNextBridge;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000823")]
		private BrowserModel browserModel;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000824")]
		private Uri pageUri;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000825")]
		private bool pageUriActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000826")]
		private ImpressionTracker parentTracker;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000827")]
		private bool parentTrackerInitialized;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x4000828")]
		private bool trackingActive;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000829")]
		private StringBuilder stringBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400082B")]
		public Action<ImpressionTracker> ChildAdded;

		[Cpp2IlInjected.Token(Token = "0x17000319")]
		public bool AutoTrackWhenVisible
		{
			[Cpp2IlInjected.Token(Token = "0x6000C30")]
			[Cpp2IlInjected.Address(RVA = "0xB79850", Offset = "0xB78250", VA = "0x180B79850")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000C31")]
			[Cpp2IlInjected.Address(RVA = "0xB79580", Offset = "0xB77F80", VA = "0x180B79580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000C2F")]
		[Cpp2IlInjected.Address(RVA = "0x82F6AD0", Offset = "0x82F54D0", VA = "0x1882F6AD0")]
		private void TryInitializeParentTracker()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C32")]
		[Cpp2IlInjected.Address(RVA = "0x82F27D0", Offset = "0x82F11D0", VA = "0x1882F27D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C33")]
		[Cpp2IlInjected.Address(RVA = "0x82F41C0", Offset = "0x82F2BC0", VA = "0x1882F41C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C34")]
		[Cpp2IlInjected.Address(RVA = "0x82F4050", Offset = "0x82F2A50", VA = "0x1882F4050")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C35")]
		[Cpp2IlInjected.Address(RVA = "0x82F4980", Offset = "0x82F3380", VA = "0x1882F4980")]
		public void SetDataToCollateFromChildrenOnLog(string key, string defaultValue, bool clearAfterLogging = false, string keyToRecordCollatedData = "")
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C36")]
		[Cpp2IlInjected.Address(RVA = "0x82F4B30", Offset = "0x82F3530", VA = "0x1882F4B30")]
		public void SetDataToRecordOnClickThrough(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C37")]
		[Cpp2IlInjected.Address(RVA = "0x82F3440", Offset = "0x82F1E40", VA = "0x1882F3440")]
		public void LogImpression(bool force = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C38")]
		[Cpp2IlInjected.Address(RVA = "0x82F2FE0", Offset = "0x82F19E0", VA = "0x1882F2FE0")]
		[AsyncStateMachine(typeof(<FinishCleanUpAfterLoggingComplete>d__45))]
		private void FinishCleanUpAfterLoggingComplete(Task logTask)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C39")]
		[Cpp2IlInjected.Address(RVA = "0x82F6220", Offset = "0x82F4C20", VA = "0x1882F6220")]
		public void StartTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3A")]
		[Cpp2IlInjected.Address(RVA = "0x82F66E0", Offset = "0x82F50E0", VA = "0x1882F66E0")]
		public void StopTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3B")]
		[Cpp2IlInjected.Address(RVA = "0x82F6590", Offset = "0x82F4F90", VA = "0x1882F6590")]
		public void StopTrackingAndClearData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3C")]
		[Cpp2IlInjected.Address(RVA = "0x82F44F0", Offset = "0x82F2EF0", VA = "0x1882F44F0")]
		public void RecordClickThrough([Optional] string buttonName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3D")]
		[Cpp2IlInjected.Address(RVA = "0x82F5C00", Offset = "0x82F4600", VA = "0x1882F5C00")]
		public void SetString(string key, string data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3E")]
		[Cpp2IlInjected.Address(RVA = "0x82F5C30", Offset = "0x82F4630", VA = "0x1882F5C30")]
		public void SetString(string key, string data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C3F")]
		[Cpp2IlInjected.Address(RVA = "0x82F5240", Offset = "0x82F3C40", VA = "0x1882F5240")]
		public void SetGuid(string key, Guid data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C40")]
		[Cpp2IlInjected.Address(RVA = "0x82F4F20", Offset = "0x82F3920", VA = "0x1882F4F20")]
		public void SetGuid(string key, Guid data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C41")]
		[Cpp2IlInjected.Address(RVA = "0x82F55A0", Offset = "0x82F3FA0", VA = "0x1882F55A0")]
		public void SetLong(string key, long data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C42")]
		[Cpp2IlInjected.Address(RVA = "0x82F55D0", Offset = "0x82F3FD0", VA = "0x1882F55D0")]
		public void SetLong(string key, long data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C43")]
		[Cpp2IlInjected.Address(RVA = "0x82F4BF0", Offset = "0x82F35F0", VA = "0x1882F4BF0")]
		public void SetFloat(string key, float data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C44")]
		[Cpp2IlInjected.Address(RVA = "0x82F4C20", Offset = "0x82F3620", VA = "0x1882F4C20")]
		public void SetFloat(string key, float data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C45")]
		[Cpp2IlInjected.Address(RVA = "0x82F58C0", Offset = "0x82F42C0", VA = "0x1882F58C0")]
		public void SetObject(string key, object data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C46")]
		[Cpp2IlInjected.Address(RVA = "0x82F58F0", Offset = "0x82F42F0", VA = "0x1882F58F0")]
		public void SetObject(string key, object data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C47")]
		[Cpp2IlInjected.Address(RVA = "0x82F5570", Offset = "0x82F3F70", VA = "0x1882F5570")]
		public void SetInt(string key, int data, bool passToChildren = false, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C48")]
		[Cpp2IlInjected.Address(RVA = "0x82F5280", Offset = "0x82F3C80", VA = "0x1882F5280")]
		public void SetInt(string key, int data, PassToChildren passToChildren, bool setOnClickThrough = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C49")]
		[Cpp2IlInjected.Address(RVA = "0x82F6A30", Offset = "0x82F5430", VA = "0x1882F6A30")]
		public bool TryGetValueAsString(string key, [Out] string valString, string format = "")
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4A")]
		[Cpp2IlInjected.Address(RVA = "0x82F29C0", Offset = "0x82F13C0", VA = "0x1882F29C0")]
		public void ClearData(string key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4B")]
		[Cpp2IlInjected.Address(RVA = "0x82F3150", Offset = "0x82F1B50", VA = "0x1882F3150")]
		private int GetOrAddKeyId(string key)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4C")]
		[Cpp2IlInjected.Address(RVA = "0x82F30B0", Offset = "0x82F1AB0", VA = "0x1882F30B0")]
		private string GetKey(int id)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4D")]
		[Cpp2IlInjected.Address(RVA = "0x82F4760", Offset = "0x82F3160", VA = "0x1882F4760")]
		private void RecordDuration()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4E")]
		[Cpp2IlInjected.Address(RVA = "0x82F6050", Offset = "0x82F4A50", VA = "0x1882F6050")]
		private void StartTrackingChild(ImpressionTracker child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C4F")]
		[Cpp2IlInjected.Address(RVA = "0x82F65D0", Offset = "0x82F4FD0", VA = "0x1882F65D0")]
		private void StopTrackingChild(ImpressionTracker child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C50")]
		[Cpp2IlInjected.Address(RVA = "0x82F32E0", Offset = "0x82F1CE0", VA = "0x1882F32E0")]
		private void HandleVisibilityChanged(bool isVisible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C51")]
		[Cpp2IlInjected.Address(RVA = "0x82F3EF0", Offset = "0x82F28F0", VA = "0x1882F3EF0")]
		private void LogImpressionsOnBrowserModelNavigationComplete(PageWrapper destination)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C52")]
		[Cpp2IlInjected.Address(RVA = "0x82F3FA0", Offset = "0x82F29A0", VA = "0x1882F3FA0")]
		private void LogImpressionsOnMenuClose(bool isOpen)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C53")]
		[Cpp2IlInjected.Address(RVA = "0x82F4820", Offset = "0x82F3220", VA = "0x1882F4820")]
		private void ResetDurationTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C54")]
		[Cpp2IlInjected.Address(RVA = "0x82F6BC0", Offset = "0x82F55C0", VA = "0x1882F6BC0")]
		private void TryResumeTracking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C55")]
		[Cpp2IlInjected.Address(RVA = "0x82F41E0", Offset = "0x82F2BE0", VA = "0x1882F41E0")]
		private void PassDataToChild(string key, ImpressionTracker child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C56")]
		[Cpp2IlInjected.Address(RVA = "0x82F2BF0", Offset = "0x82F15F0", VA = "0x1882F2BF0")]
		private string CollateDataFromChildren(int keyId)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C57")]
		[Cpp2IlInjected.Address(RVA = "0x82F5F20", Offset = "0x82F4920", VA = "0x1882F5F20")]
		private int SortByElementIndex(ImpressionData lhs, ImpressionData rhs)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C58")]
		[Cpp2IlInjected.Address(RVA = "0x82F29B0", Offset = "0x82F13B0", VA = "0x1882F29B0")]
		private bool CanLogEvent(ImpressionLogEvents logEvent)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C59")]
		[Cpp2IlInjected.Address(RVA = "0x82F3240", Offset = "0x82F1C40", VA = "0x1882F3240")]
		private void GuaranteeImpressionData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C5A")]
		[Cpp2IlInjected.Address(RVA = "0x82F6D00", Offset = "0x82F5700", VA = "0x1882F6D00")]
		public ImpressionTracker()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000112")]
	public class CanvasSizeData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400083F")]
		public Vector2 CanvasSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000840")]
		public AMLOJEALFHA Platforms;

		[Cpp2IlInjected.Token(Token = "0x6000C5E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public CanvasSizeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000113")]
	[CreateAssetMenu(fileName = "PlatformDependentCanvasSizeConfig", menuName = "RecRoom/UI/Canvas Size Settings")]
	public class PlatformDependentCanvasSizeConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000841")]
		[SerializeField]
		private Vector2 fallbackCanvasSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000842")]
		[SerializeField]
		private List<CanvasSizeData> canvasSizeSettings;

		[Cpp2IlInjected.Token(Token = "0x6000C5F")]
		[Cpp2IlInjected.Address(RVA = "0x82F71C0", Offset = "0x82F5BC0", VA = "0x1882F71C0")]
		public Vector2 GetSizeForPlatform(AMLOJEALFHA platform)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C60")]
		[Cpp2IlInjected.Address(RVA = "0x82F7340", Offset = "0x82F5D40", VA = "0x1882F7340")]
		public PlatformDependentCanvasSizeConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000114")]
	public class RaycastIgnoreTransformFilter : MonoBehaviour, ICanvasRaycastFilter
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000843")]
		[SerializeField]
		private List<RectTransform> targetTransforms;

		[Cpp2IlInjected.Token(Token = "0x6000C61")]
		[Cpp2IlInjected.Address(RVA = "0x82F7700", Offset = "0x82F6100", VA = "0x1882F7700", Slot = "4")]
		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C62")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public RaycastIgnoreTransformFilter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000115")]
	public class RectTransformAspectRatioResizer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000116")]
		public enum ResizeDimension
		{
			[Cpp2IlInjected.Token(Token = "0x4000847")]
			Height,
			[Cpp2IlInjected.Token(Token = "0x4000848")]
			Width
		}

		[Cpp2IlInjected.Token(Token = "0x2000117")]
		[CompilerGenerated]
		private sealed class <FitResizeDimensionToAspectRatioAtEndOfFrame>d__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000849")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400084A")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400084B")]
			public RectTransformAspectRatioResizer <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700031A")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C6B")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700031B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000C6D")]
				[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000C68")]
			[Cpp2IlInjected.Address(RVA = "0xAB33A0", Offset = "0xAB1DA0", VA = "0x180AB33A0")]
			[DebuggerHidden]
			public <FitResizeDimensionToAspectRatioAtEndOfFrame>d__4(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C69")]
			[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000C6A")]
			[Cpp2IlInjected.Address(RVA = "0x82FECF0", Offset = "0x82FD6F0", VA = "0x1882FECF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000C6C")]
			[Cpp2IlInjected.Address(RVA = "0x82FEDA0", Offset = "0x82FD7A0", VA = "0x1882FEDA0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000844")]
		[SerializeField]
		private RectTransform rectTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000845")]
		[SerializeField]
		private ResizeDimension resizeDimension;

		[Cpp2IlInjected.Token(Token = "0x6000C63")]
		[Cpp2IlInjected.Address(RVA = "0x82F7D70", Offset = "0x82F6770", VA = "0x1882F7D70")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C64")]
		[Cpp2IlInjected.Address(RVA = "0x82F7870", Offset = "0x82F6270", VA = "0x1882F7870")]
		[IteratorStateMachine(typeof(<FitResizeDimensionToAspectRatioAtEndOfFrame>d__4))]
		private IEnumerator FitResizeDimensionToAspectRatioAtEndOfFrame()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000C65")]
		[Cpp2IlInjected.Address(RVA = "0x82F78F0", Offset = "0x82F62F0", VA = "0x1882F78F0")]
		private void FitResizeDimensionToAspectRatio()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C66")]
		[Cpp2IlInjected.Address(RVA = "0x82F7BB0", Offset = "0x82F65B0", VA = "0x1882F7BB0")]
		private float GetScreenAspectRatio(RectTransform rectTransform)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000C67")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public RectTransformAspectRatioResizer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000118")]
	public static class RectTransformUtilities
	{
		[Cpp2IlInjected.Token(Token = "0x6000C6E")]
		[Cpp2IlInjected.Address(RVA = "0x82F7EF0", Offset = "0x82F68F0", VA = "0x1882F7EF0")]
		public static void MatchSourceLossyScale(this Transform source, Transform target)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000C6F")]
		[Cpp2IlInjected.Address(RVA = "0x82F7DF0", Offset = "0x82F67F0", VA = "0x1882F7DF0")]
		public static Vector2 GetPivotFromAnchor(TextAnchor anchor)
		{
			return default(Vector2);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000119")]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
	public class RRUIBinderAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000C70")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
