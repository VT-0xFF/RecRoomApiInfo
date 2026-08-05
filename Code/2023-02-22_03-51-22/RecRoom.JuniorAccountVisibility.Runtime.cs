using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AccountRestrictedVisibilityObject : VisibilityRestriction
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[Flags]
		public enum CKONGDBDHKJ
		{
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Junior = 1,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			NonJunior = 2,
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			UGC_Allowed = 4,
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			UGC_Blocked = 8,
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			Chat_Allowed = 0x10,
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			Chat_Blocked = 0x20
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public enum HKFJNGGNGIE
		{
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			AllNonExclusive,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			Any
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private CKONGDBDHKJ visibleFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private HKFJNGGNGIE evaluationMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		[Tooltip("We allow some ugc content for Junior accounts, this is fairly restricted. Consult Social team if you are not sure.")]
		private bool limitedUGCForJuniorAccount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private bool KHGIONHEOJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool OMHBFLNDHMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool BJPENKIHFOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool JCBBNDGFIHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private KAMKJOOJPCM HPFKAEFIJLC;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x645CF50", Offset = "0x645C150", VA = "0x18645CF50", Slot = "5")]
		protected override void IPEFOLLCBCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x645D2C0", Offset = "0x645C4C0", VA = "0x18645D2C0", Slot = "4")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x645D190", Offset = "0x645C390", VA = "0x18645D190")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x645D180", Offset = "0x645C380", VA = "0x18645D180")]
		private void NDOLABKCDGF(bool KHGIONHEOJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x645D0E0", Offset = "0x645C2E0", VA = "0x18645D0E0")]
		private void LOOLNACCBBJ(bool KHGIONHEOJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x645CDB0", Offset = "0x645BFB0", VA = "0x18645CDB0", Slot = "6")]
		protected override void APCCDOLONIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xE24550", Offset = "0xE23750", VA = "0x180E24550")]
		public AccountRestrictedVisibilityObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public abstract class AltRenderedObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static List<AltRenderedObject> All;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[JMJGMKPPDEK("Alters the behavior of this object when rendered in photos taken by junior players")]
		[JMJGMKPPDEK("Enable Never Render to prevent this object from rendering in photos taken by ANY players.", JMJGMKPPDEK.EOEFNPJJFHA.Warning)]
		public bool NeverRender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private JMMOMAJEGFM CMEFAHNAFIA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool FIAMLNCJELM
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x15DC740", Offset = "0x15DB940", VA = "0x1815DC740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x645D370", Offset = "0x645C570", VA = "0x18645D370", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x645D400", Offset = "0x645C600", VA = "0x18645D400", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x645D530", Offset = "0x645C730", VA = "0x18645D530")]
		public void SetPaused(bool KHOBADBEHGJ, UnityEngine.Object AJDBKDIMOHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x645D4E0", Offset = "0x645C6E0", VA = "0x18645D4E0")]
		public void PreRender(Camera GBPPCIDHBCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void BHDGPKHJAFM(Camera GBPPCIDHBCJ);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x645D490", Offset = "0x645C690", VA = "0x18645D490")]
		public void PostRender(Camera GBPPCIDHBCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void JFGGAPJEJCD(Camera GBPPCIDHBCJ);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x645D5F0", Offset = "0x645C7F0", VA = "0x18645D5F0")]
		protected AltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class DisabledAltRenderedObject : AltRenderedObject
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct ACGGJJALDFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public (Component, bool)[] CDNFGGBCCAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public (Component, bool)[] MMLNCFFADFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public (Component, bool)[] EBHGIAIPFOC;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private ACGGJJALDFB HFICKGBHKKG;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x645DD50", Offset = "0x645CF50", VA = "0x18645DD50")]
		public static ACGGJJALDFB PreRender(GameObject OOKBNBHDPPG)
		{
			return default(ACGGJJALDFB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x645DB90", Offset = "0x645CD90", VA = "0x18645DB90")]
		public static void PostRender(ACGGJJALDFB NFFMICKCKMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x645D660", Offset = "0x645C860", VA = "0x18645D660", Slot = "6")]
		protected override void BHDGPKHJAFM(Camera GBPPCIDHBCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x645D9C0", Offset = "0x645CBC0", VA = "0x18645D9C0", Slot = "7")]
		protected override void JFGGAPJEJCD(Camera GBPPCIDHBCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x645DF20", Offset = "0x645D120", VA = "0x18645DF20")]
		public DisabledAltRenderedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x645D6A0", Offset = "0x645C8A0", VA = "0x18645D6A0")]
		[CompilerGenerated]
		internal static (Component, bool)[] FHHAFIFBPJE(IEnumerable<Component> AOONNNAPHDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x645DB70", Offset = "0x645CD70", VA = "0x18645DB70")]
		[CompilerGenerated]
		internal static void LIHEHEMLGIC((Component, bool) BDGDANGCJGF)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class GameObjectSwapAltRenderedObject : AltRenderedObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private GameObject primaryObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[SerializeField]
		private GameObject alternateObject;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x645E5F0", Offset = "0x645D7F0", VA = "0x18645E5F0", Slot = "6")]
		protected override void BHDGPKHJAFM(Camera GBPPCIDHBCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x645E630", Offset = "0x645D830", VA = "0x18645E630", Slot = "7")]
		protected override void JFGGAPJEJCD(Camera GBPPCIDHBCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x645E670", Offset = "0x645D870", VA = "0x18645E670")]
		public GameObjectSwapAltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MaterialSwapAltRenderedObject : AltRenderedObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private Renderer swappedRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[SerializeField]
		private Material[] swappedMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private Material[] ALACIIMDGEH;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x645E710", Offset = "0x645D910", VA = "0x18645E710", Slot = "6")]
		protected override void BHDGPKHJAFM(Camera GBPPCIDHBCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x645E760", Offset = "0x645D960", VA = "0x18645E760", Slot = "7")]
		protected override void JFGGAPJEJCD(Camera GBPPCIDHBCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x645E790", Offset = "0x645D990", VA = "0x18645E790")]
		public MaterialSwapAltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class VisibilityRestriction : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private bool LCKFEIIEMOL;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool BCGMGNAPMHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6E18D0", Offset = "0x6E0AD0", VA = "0x1806E18D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x645EA00", Offset = "0x645DC00", VA = "0x18645EA00", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x645EA00", Offset = "0x645DC00", VA = "0x18645EA00")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "5")]
		protected virtual void IPEFOLLCBCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void APCCDOLONIA();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xE24550", Offset = "0xE23750", VA = "0x180E24550")]
		protected VisibilityRestriction()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class EGIIOKJKKGL
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private static byte[] LAFDEEMEPDM;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static int AHBPGGLKEKP;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static int MAHPDNGMMFO;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private static BigInteger NMOJFJKJLEG;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public EGIIOKJKKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x645DFC0", Offset = "0x645D1C0", VA = "0x18645DFC0")]
	private static string CIEKLEOAFAL(byte[] GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x645E0D0", Offset = "0x645D2D0", VA = "0x18645E0D0")]
	public static string NOFFLEGCGLA(byte[] NPNCGJAPKIL, bool FBFFLNHILGA)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
