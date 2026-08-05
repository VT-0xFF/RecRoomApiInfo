using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using RecRoom.Core.Studio;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class AccountRestrictedVisibilityObject : VisibilityRestriction
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[Flags]
		public enum BKJIFBGFKPD
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
		public enum FPDPFEGMFDC
		{
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			AllNonExclusive,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			Any
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private BKJIFBGFKPD visibleFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private FPDPFEGMFDC evaluationMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		[Tooltip("We allow some ugc content for Junior accounts, this is fairly restricted. Consult Social team if you are not sure.")]
		private bool limitedUGCForJuniorAccount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private bool EDGAPCIGLOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool KOPFJBBEBEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool HDAAPCNNLDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool ILHCIDLJKCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private EDGGJKNOCEO DHNGNBLIOEP;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3AC0", Offset = "0x7CA2AC0", VA = "0x187CA3AC0", Slot = "5")]
		protected override void HKGLCAEACML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3EC0", Offset = "0x7CA2EC0", VA = "0x187CA3EC0", Slot = "4")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3CB0", Offset = "0x7CA2CB0", VA = "0x187CA3CB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3AB0", Offset = "0x7CA2AB0", VA = "0x187CA3AB0")]
		private void HIHGMLCLFLA(bool EDGAPCIGLOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3C20", Offset = "0x7CA2C20", VA = "0x187CA3C20")]
		private void IMIKGDPNAAC(bool EDGAPCIGLOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3DF0", Offset = "0x7CA2DF0", VA = "0x187CA3DF0", Slot = "6")]
		protected override void PFPONDFAJGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9F0210", Offset = "0x9EF210", VA = "0x1809F0210")]
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
		[PMCNMHCNMIK("Alters the behavior of this object when rendered in photos taken by junior players", order = 0)]
		[PMCNMHCNMIK("Enable Never Render to prevent this object from rendering in photos taken by ANY players.", PMCNMHCNMIK.EKBNEJPMIDG.Warning, order = 1)]
		public bool NeverRender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private PHIGNGELHED MIPMAPCGEFB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool BMHKHIBDACF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x1582FD0", Offset = "0x1581FD0", VA = "0x181582FD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7CA3F70", Offset = "0x7CA2F70", VA = "0x187CA3F70", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4070", Offset = "0x7CA3070", VA = "0x187CA4070", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4190", Offset = "0x7CA3190", VA = "0x187CA4190")]
		public void SetPaused(bool OCMLCOPEGCM, UnityEngine.Object EJJDDFFADPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4140", Offset = "0x7CA3140", VA = "0x187CA4140")]
		public void PreRender(Camera HJJMGNJIHHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void HCJKGBDDPHJ(Camera HJJMGNJIHHH);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7CA40F0", Offset = "0x7CA30F0", VA = "0x187CA40F0")]
		public void PostRender(Camera HJJMGNJIHHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void OFEIPHNOOBL(Camera HJJMGNJIHHH);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4260", Offset = "0x7CA3260", VA = "0x187CA4260")]
		protected AltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class DisabledAltRenderedObject : AltRenderedObject, BFEPDCNPKBB<RecRoomStudioDisableRenderInShareCamPhoto>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct FEGFNGOAOBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public (Component, bool)[] LNCCNAKIHIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public (Component, bool)[] MGOFCHKAEAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public (Component, bool)[] DNFKMIFAFNE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private FEGFNGOAOBB GOLNHEFCPIM;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4BB0", Offset = "0x7CA3BB0", VA = "0x187CA4BB0")]
		public static FEGFNGOAOBB PreRender(GameObject CEKGANCAJPA)
		{
			return default(FEGFNGOAOBB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7CA49F0", Offset = "0x7CA39F0", VA = "0x187CA49F0")]
		public static void PostRender(FEGFNGOAOBB CDAGGLPJHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4650", Offset = "0x7CA3650", VA = "0x187CA4650", Slot = "6")]
		protected override void HCJKGBDDPHJ(Camera HJJMGNJIHHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4830", Offset = "0x7CA3830", VA = "0x187CA4830", Slot = "7")]
		protected override void OFEIPHNOOBL(Camera HJJMGNJIHHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4800", Offset = "0x7CA3800", VA = "0x187CA4800", Slot = "8")]
		private void MNBOIMBCEPL(RecRoomStudioDisableRenderInShareCamPhoto KLOGCINGPKB, int KKMLOMMBMNM, bool BFBCLIJKAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4D40", Offset = "0x7CA3D40", VA = "0x187CA4D40")]
		public DisabledAltRenderedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4350", Offset = "0x7CA3350", VA = "0x187CA4350")]
		[CompilerGenerated]
		internal static (Component, bool)[] HCIJLDBFPBI(IEnumerable<Component> JLLEALKGJHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7CA42E0", Offset = "0x7CA32E0", VA = "0x187CA42E0")]
		[CompilerGenerated]
		internal static void BADMLAMHFIF((Component, bool) DAPCBFLAHDI)
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

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4D90", Offset = "0x7CA3D90", VA = "0x187CA4D90", Slot = "6")]
		protected override void HCJKGBDDPHJ(Camera HJJMGNJIHHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4DD0", Offset = "0x7CA3DD0", VA = "0x187CA4DD0", Slot = "7")]
		protected override void OFEIPHNOOBL(Camera HJJMGNJIHHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4E10", Offset = "0x7CA3E10", VA = "0x187CA4E10")]
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
		private Material[] AABCABHNAGP;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4E60", Offset = "0x7CA3E60", VA = "0x187CA4E60", Slot = "6")]
		protected override void HCJKGBDDPHJ(Camera HJJMGNJIHHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4EB0", Offset = "0x7CA3EB0", VA = "0x187CA4EB0", Slot = "7")]
		protected override void OFEIPHNOOBL(Camera HJJMGNJIHHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7CA4EE0", Offset = "0x7CA3EE0", VA = "0x187CA4EE0")]
		public MaterialSwapAltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class VisibilityRestriction : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private bool MFEGGMHGFMN;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool NPPPOBAOHFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xAA5F80", Offset = "0xAA4F80", VA = "0x180AA5F80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7CA51B0", Offset = "0x7CA41B0", VA = "0x187CA51B0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7CA51B0", Offset = "0x7CA41B0", VA = "0x187CA51B0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		protected virtual void HKGLCAEACML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void PFPONDFAJGO();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0210", Offset = "0x9EF210", VA = "0x1809F0210")]
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
