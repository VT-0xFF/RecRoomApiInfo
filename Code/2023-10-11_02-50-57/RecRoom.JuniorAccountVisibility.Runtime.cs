using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AccountRestrictedVisibilityObject : VisibilityRestriction
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[Flags]
		public enum IMHHEJAELIG
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
		public enum IDIDBCLJKMH
		{
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			AllNonExclusive,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			Any
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private IMHHEJAELIG visibleFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private IDIDBCLJKMH evaluationMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		[Tooltip("We allow some ugc content for Junior accounts, this is fairly restricted. Consult Social team if you are not sure.")]
		private bool limitedUGCForJuniorAccount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private bool KJEMMDFFILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool JCJHDJMIBEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool FPBBNFCBDOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool IAKCGAGDDJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private KJMCMCNBAMJ NLCBGCPFPPA;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5CEA870", Offset = "0x5CE9670", VA = "0x185CEA870", Slot = "5")]
		protected override void FEKEPCMBOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5CEAC10", Offset = "0x5CE9A10", VA = "0x185CEAC10", Slot = "4")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5CEAAD0", Offset = "0x5CE98D0", VA = "0x185CEAAD0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5CEA7D0", Offset = "0x5CE95D0", VA = "0x185CEA7D0")]
		private void DDIAGBCDEBK(bool KJEMMDFFILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5CEA7E0", Offset = "0x5CE95E0", VA = "0x185CEA7E0")]
		private void EAMLFLOLJJF(bool KJEMMDFFILM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5CEAA00", Offset = "0x5CE9800", VA = "0x185CEAA00", Slot = "6")]
		protected override void NBEAMBJPJBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x762ED0", Offset = "0x761CD0", VA = "0x180762ED0")]
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
		[KMFIPPKBJJC("Alters the behavior of this object when rendered in photos taken by junior players", order = 0)]
		[KMFIPPKBJJC("Enable Never Render to prevent this object from rendering in photos taken by ANY players.", KMFIPPKBJJC.PJFKEPJKGHI.Warning, order = 1)]
		public bool NeverRender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private IBKPFCNCMON LBICFMNGING;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool PCIMOLJAHJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA3B570", Offset = "0xA3A370", VA = "0x180A3B570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5CEACC0", Offset = "0x5CE9AC0", VA = "0x185CEACC0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5CEAD90", Offset = "0x5CE9B90", VA = "0x185CEAD90", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CEAEB0", Offset = "0x5CE9CB0", VA = "0x185CEAEB0")]
		public void SetPaused(bool DDKNJMGKMPM, UnityEngine.Object PFKLELGAJPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CEAE60", Offset = "0x5CE9C60", VA = "0x185CEAE60")]
		public void PreRender(Camera AHMEKLAEGFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void KAFLPNKGEPD(Camera AHMEKLAEGFO);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5CEAE10", Offset = "0x5CE9C10", VA = "0x185CEAE10")]
		public void PostRender(Camera AHMEKLAEGFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void ELGHPHLMIIN(Camera AHMEKLAEGFO);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5CEAF80", Offset = "0x5CE9D80", VA = "0x185CEAF80")]
		protected AltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class DisabledAltRenderedObject : AltRenderedObject
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct MGMILMNAEHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public (Component, bool)[] GBFGNLJMHCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public (Component, bool)[] OPEBEFOBALP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public (Component, bool)[] IOPCPDMAOGK;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private MGMILMNAEHK GJKACHADCKB;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5CEB8A0", Offset = "0x5CEA6A0", VA = "0x185CEB8A0")]
		public static MGMILMNAEHK PreRender(GameObject DEGGPBGPMDB)
		{
			return default(MGMILMNAEHK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5CEB6E0", Offset = "0x5CEA4E0", VA = "0x185CEB6E0")]
		public static void PostRender(MGMILMNAEHK PBGAMMBJDLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5CEB4C0", Offset = "0x5CEA2C0", VA = "0x185CEB4C0", Slot = "6")]
		protected override void KAFLPNKGEPD(Camera AHMEKLAEGFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5CEB000", Offset = "0x5CE9E00", VA = "0x185CEB000", Slot = "7")]
		protected override void ELGHPHLMIIN(Camera AHMEKLAEGFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5CEBA30", Offset = "0x5CEA830", VA = "0x185CEBA30")]
		public DisabledAltRenderedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5CEB1C0", Offset = "0x5CE9FC0", VA = "0x185CEB1C0")]
		[CompilerGenerated]
		internal static (Component, bool)[] ENDKLHBKAHG(IEnumerable<Component> IAEGOGAHMLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5CEB670", Offset = "0x5CEA470", VA = "0x185CEB670")]
		[CompilerGenerated]
		internal static void LPEOEGIKLPC((Component, bool) KABDNODOLBN)
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
		[Cpp2IlInjected.Address(RVA = "0x5CEBAC0", Offset = "0x5CEA8C0", VA = "0x185CEBAC0", Slot = "6")]
		protected override void KAFLPNKGEPD(Camera AHMEKLAEGFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5CEBA80", Offset = "0x5CEA880", VA = "0x185CEBA80", Slot = "7")]
		protected override void ELGHPHLMIIN(Camera AHMEKLAEGFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5CEBB00", Offset = "0x5CEA900", VA = "0x185CEBB00")]
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
		private Material[] ODENLKCIBCE;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5CEBB80", Offset = "0x5CEA980", VA = "0x185CEBB80", Slot = "6")]
		protected override void KAFLPNKGEPD(Camera AHMEKLAEGFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5CEBB50", Offset = "0x5CEA950", VA = "0x185CEBB50", Slot = "7")]
		protected override void ELGHPHLMIIN(Camera AHMEKLAEGFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5CEBBD0", Offset = "0x5CEA9D0", VA = "0x185CEBBD0")]
		public MaterialSwapAltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class VisibilityRestriction : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private bool HHDELIIFEGC;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool CKIMNNAAMBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7D0BF0", Offset = "0x7CF9F0", VA = "0x1807D0BF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5CEBEA0", Offset = "0x5CEACA0", VA = "0x185CEBEA0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5CEBEA0", Offset = "0x5CEACA0", VA = "0x185CEBEA0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		protected virtual void FEKEPCMBOLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void NBEAMBJPJBI();

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x762ED0", Offset = "0x761CD0", VA = "0x180762ED0")]
		protected VisibilityRestriction()
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
