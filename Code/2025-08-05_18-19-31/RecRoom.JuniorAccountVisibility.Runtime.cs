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
		public enum ALKFHIGODOG
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
		public enum OHGPPGFPMOJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			AllNonExclusive,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			Any
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private ALKFHIGODOG visibleFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private OHGPPGFPMOJ evaluationMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		[Tooltip("We allow some ugc content for Junior accounts, this is fairly restricted. Consult Social team if you are not sure.")]
		private bool limitedUGCForJuniorAccount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private bool NHDKIEJIGGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool DFAGDGAIBGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool AOHMDNNKAHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool NKBACIKPLIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private APCKAFFCJDF NKBKOKPKBNH;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x82EEB20", Offset = "0x82EDF20", VA = "0x1882EEB20", Slot = "5")]
		protected override void JOLJGOKIDFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x82EEE50", Offset = "0x82EE250", VA = "0x1882EEE50", Slot = "4")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x82EED20", Offset = "0x82EE120", VA = "0x1882EED20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x82EEC80", Offset = "0x82EE080", VA = "0x1882EEC80")]
		private void OAHODLEMIGF(bool NHDKIEJIGGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x82EEC90", Offset = "0x82EE090", VA = "0x1882EEC90")]
		private void OCEPPMPFLCA(bool NHDKIEJIGGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x82EEA50", Offset = "0x82EDE50", VA = "0x1882EEA50", Slot = "6")]
		protected override void HGGMINHPMAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
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
		[KBKFKFHJADL("Alters the behavior of this object when rendered in photos taken by junior players", order = 0)]
		[KBKFKFHJADL("Enable Never Render to prevent this object from rendering in photos taken by ANY players.", KBKFKFHJADL.ELLNCFJACHD.Warning, order = 1)]
		public bool NeverRender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private CKBPAEHADCP MDECPCOJKFC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool GIOLNIGJPNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x1835490", Offset = "0x1834890", VA = "0x181835490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x82EEF00", Offset = "0x82EE300", VA = "0x1882EEF00", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x82EEFD0", Offset = "0x82EE3D0", VA = "0x1882EEFD0", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x82EF0F0", Offset = "0x82EE4F0", VA = "0x1882EF0F0")]
		public void SetPaused(bool OKGNONIDIOA, UnityEngine.Object MONGIMOHLAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82EF0A0", Offset = "0x82EE4A0", VA = "0x1882EF0A0")]
		public void PreRender(Camera MLFNHNIBMNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void FGJFNPACAAG(Camera MLFNHNIBMNH);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x82EF050", Offset = "0x82EE450", VA = "0x1882EF050")]
		public void PostRender(Camera MLFNHNIBMNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void DLNNKMCDFLJ(Camera MLFNHNIBMNH);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x82EF1C0", Offset = "0x82EE5C0", VA = "0x1882EF1C0")]
		protected AltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class DisabledAltRenderedObject : AltRenderedObject, OBFNGACIIII<RecRoomStudioDisableRenderInShareCamPhoto>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct JCPJEIEEKCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public (Component, bool)[] ODBHJNPEJGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public (Component, bool)[] ILCANPPCFLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public (Component, bool)[] GFNNLJBGBIE;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private JCPJEIEEKCH EMDMIGBJLEK;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x82EFB10", Offset = "0x82EEF10", VA = "0x1882EFB10")]
		public static JCPJEIEEKCH PreRender(GameObject JBJNKCGNJKP)
		{
			return default(JCPJEIEEKCH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x82EF950", Offset = "0x82EED50", VA = "0x1882EF950")]
		public static void PostRender(JCPJEIEEKCH DHPCBNCGHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x82EF400", Offset = "0x82EE800", VA = "0x1882EF400", Slot = "6")]
		protected override void FGJFNPACAAG(Camera MLFNHNIBMNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x82EF240", Offset = "0x82EE640", VA = "0x1882EF240", Slot = "7")]
		protected override void DLNNKMCDFLJ(Camera MLFNHNIBMNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x82EF5B0", Offset = "0x82EE9B0", VA = "0x1882EF5B0", Slot = "8")]
		private void JCBMJKDLCML(RecRoomStudioDisableRenderInShareCamPhoto CGKIFPKDBPD, int OIBNLFBFFGE, bool DCDPIKGMKAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x82EFCA0", Offset = "0x82EF0A0", VA = "0x1882EFCA0")]
		public DisabledAltRenderedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x82EF5E0", Offset = "0x82EE9E0", VA = "0x1882EF5E0")]
		[CompilerGenerated]
		internal static (Component, bool)[] LBAFICICLGG(IEnumerable<Component> PEFHILPJDIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x82EF8E0", Offset = "0x82EECE0", VA = "0x1882EF8E0")]
		[CompilerGenerated]
		internal static void NBLFAEOGOPI((Component, bool) GGKKDFMIENI)
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
		[Cpp2IlInjected.Address(RVA = "0x82EFD30", Offset = "0x82EF130", VA = "0x1882EFD30", Slot = "6")]
		protected override void FGJFNPACAAG(Camera MLFNHNIBMNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82EFCF0", Offset = "0x82EF0F0", VA = "0x1882EFCF0", Slot = "7")]
		protected override void DLNNKMCDFLJ(Camera MLFNHNIBMNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x82EFD70", Offset = "0x82EF170", VA = "0x1882EFD70")]
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
		private Material[] ABOLIKHPIAN;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x82EFDF0", Offset = "0x82EF1F0", VA = "0x1882EFDF0", Slot = "6")]
		protected override void FGJFNPACAAG(Camera MLFNHNIBMNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x82EFDC0", Offset = "0x82EF1C0", VA = "0x1882EFDC0", Slot = "7")]
		protected override void DLNNKMCDFLJ(Camera MLFNHNIBMNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x82EFE40", Offset = "0x82EF240", VA = "0x1882EFE40")]
		public MaterialSwapAltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class VisibilityRestriction : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private bool DOCDCNEPKJJ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool IECFCMEPCLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xAC6D20", Offset = "0xAC6120", VA = "0x180AC6D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x82F0110", Offset = "0x82EF510", VA = "0x1882F0110", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x82F0110", Offset = "0x82EF510", VA = "0x1882F0110")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		protected virtual void JOLJGOKIDFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void HGGMINHPMAC();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
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
