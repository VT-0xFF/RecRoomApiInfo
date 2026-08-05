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
		public enum LKIFHLIIJCD
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
		public enum BJBHHHMBIEA
		{
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			AllNonExclusive,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			Any
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private LKIFHLIIJCD visibleFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private BJBHHHMBIEA evaluationMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		[Tooltip("We allow some ugc content for Junior accounts, this is fairly restricted. Consult Social team if you are not sure.")]
		private bool limitedUGCForJuniorAccount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private bool CKMHEPOCJFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool ILPPAGDDDJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool BBJLPGHOKKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool CPHALCMNEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private OHGFADEOGNH KBIEGPDLDOO;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B140", Offset = "0x6F5A540", VA = "0x186F5B140", Slot = "5")]
		protected override void LDFHGIAKDMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B370", Offset = "0x6F5A770", VA = "0x186F5B370", Slot = "4")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B240", Offset = "0x6F5A640", VA = "0x186F5B240")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B130", Offset = "0x6F5A530", VA = "0x186F5B130")]
		private void KDGMAJCALIF(bool CKMHEPOCJFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F5AEE0", Offset = "0x6F5A2E0", VA = "0x186F5AEE0")]
		private void EHLCHFMMAOM(bool CKMHEPOCJFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F5AF80", Offset = "0x6F5A380", VA = "0x186F5AF80", Slot = "6")]
		protected override void HJGFGCECEPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B420", Offset = "0x6F5A820", VA = "0x186F5B420")]
		public AccountRestrictedVisibilityObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class MaterialSwapAltRenderedObject : AltRenderedObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private Renderer swappedRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private Material[] swappedMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private Material[] IJJGCPOKANN;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C230", Offset = "0x6F5B630", VA = "0x186F5C230", Slot = "6")]
		protected override void IHOKKALLJBC(Camera GNCNILLDJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C280", Offset = "0x6F5B680", VA = "0x186F5C280", Slot = "7")]
		protected override void LKDINDCGINJ(Camera GNCNILLDJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C2B0", Offset = "0x6F5B6B0", VA = "0x186F5C2B0")]
		public MaterialSwapAltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class GameObjectSwapAltRenderedObject : AltRenderedObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private GameObject primaryObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private GameObject alternateObject;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C100", Offset = "0x6F5B500", VA = "0x186F5C100", Slot = "6")]
		protected override void IHOKKALLJBC(Camera GNCNILLDJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C140", Offset = "0x6F5B540", VA = "0x186F5C140", Slot = "7")]
		protected override void LKDINDCGINJ(Camera GNCNILLDJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C180", Offset = "0x6F5B580", VA = "0x186F5C180")]
		public GameObjectSwapAltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public abstract class VisibilityRestriction : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private bool OGDPMLMGDAC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool KIMLDMDILJC
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xEDF0E0", Offset = "0xEDE4E0", VA = "0x180EDF0E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C5E0", Offset = "0x6F5B9E0", VA = "0x186F5C5E0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C5E0", Offset = "0x6F5B9E0", VA = "0x186F5C5E0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		protected virtual void LDFHGIAKDMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void HJGFGCECEPE();

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8CEA50", Offset = "0x8CDE50", VA = "0x1808CEA50")]
		protected VisibilityRestriction()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class DisabledAltRenderedObject : AltRenderedObject
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public struct JIHJLOMDANF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public (Component, bool)[] DDIHEFEPLBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public (Component, bool)[] POAJOANMGFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public (Component, bool)[] KAGOLIEAMLH;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private JIHJLOMDANF AMMFLPPPPKO;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6F5BE60", Offset = "0x6F5B260", VA = "0x186F5BE60")]
		public static JIHJLOMDANF PreRender(GameObject GACFHLOJJGF)
		{
			return default(JIHJLOMDANF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F5BCA0", Offset = "0x6F5B0A0", VA = "0x186F5BCA0")]
		public static void PostRender(JIHJLOMDANF BAHNHKFEBGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6F5BA40", Offset = "0x6F5AE40", VA = "0x186F5BA40", Slot = "6")]
		protected override void IHOKKALLJBC(Camera GNCNILLDJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6F5BA80", Offset = "0x6F5AE80", VA = "0x186F5BA80", Slot = "7")]
		protected override void LKDINDCGINJ(Camera GNCNILLDJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F5C050", Offset = "0x6F5B450", VA = "0x186F5C050")]
		public DisabledAltRenderedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B720", Offset = "0x6F5AB20", VA = "0x186F5B720")]
		[CompilerGenerated]
		internal static (Component, bool)[] AEFKOLDMOCE(IEnumerable<Component> NMIBCPIHMNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6F5BC30", Offset = "0x6F5B030", VA = "0x186F5BC30")]
		[CompilerGenerated]
		internal static void PFGPMBKDKDJ((Component, bool) IKBFMOHCOOJ)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class AltRenderedObject : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public static List<AltRenderedObject> All;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[HFBIAFNLDHI("Alters the behavior of this object when rendered in photos taken by junior players")]
		[HFBIAFNLDHI("Enable Never Render to prevent this object from rendering in photos taken by ANY players.", HFBIAFNLDHI.NHJPCBANBGP.Warning)]
		public bool NeverRender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private LMDJEEFCDOJ BIBEJJLJAHC;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool JIKAKELDMHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xC3BC40", Offset = "0xC3B040", VA = "0x180C3BC40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B430", Offset = "0x6F5A830", VA = "0x186F5B430", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B4C0", Offset = "0x6F5A8C0", VA = "0x186F5B4C0", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B5F0", Offset = "0x6F5A9F0", VA = "0x186F5B5F0")]
		public void SetPaused(bool IFJPDKPEEHJ, UnityEngine.Object GAOLOMEJCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B5A0", Offset = "0x6F5A9A0", VA = "0x186F5B5A0")]
		public void PreRender(Camera GNCNILLDJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void IHOKKALLJBC(Camera GNCNILLDJGG);

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B550", Offset = "0x6F5A950", VA = "0x186F5B550")]
		public void PostRender(Camera GNCNILLDJGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void LKDINDCGINJ(Camera GNCNILLDJGG);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6F5B6B0", Offset = "0x6F5AAB0", VA = "0x186F5B6B0")]
		protected AltRenderedObject()
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
