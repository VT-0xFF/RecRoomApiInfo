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
		public enum AEOFPDHIKNF
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
		public enum AFICJJBAFLK
		{
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			AllNonExclusive,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			Any
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private AEOFPDHIKNF visibleFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private AFICJJBAFLK evaluationMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		[Tooltip("We allow some ugc content for Junior accounts, this is fairly restricted. Consult Social team if you are not sure.")]
		private bool limitedUGCForJuniorAccount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private bool BIAEPNIAHKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool IAEBLODBIMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool HMAGDIDLOCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool GPHIOEECKAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private ACMBNDJDLEG FBALLOOIDLL;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x72B2A50", Offset = "0x72B1850", VA = "0x1872B2A50", Slot = "5")]
		protected override void PLMNLGEEKGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x72B2BB0", Offset = "0x72B19B0", VA = "0x1872B2BB0", Slot = "4")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x72B2920", Offset = "0x72B1720", VA = "0x1872B2920")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72B2910", Offset = "0x72B1710", VA = "0x1872B2910")]
		private void FFACLGPPJBD(bool BIAEPNIAHKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72B2880", Offset = "0x72B1680", VA = "0x1872B2880")]
		private void DLAEICBOELJ(bool BIAEPNIAHKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x72B27B0", Offset = "0x72B15B0", VA = "0x1872B27B0", Slot = "6")]
		protected override void DJKAKFCNDGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D30", Offset = "0x8F5B30", VA = "0x1808F6D30")]
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
		[KGHEHNCOBMB("Alters the behavior of this object when rendered in photos taken by junior players", order = 0)]
		[KGHEHNCOBMB("Enable Never Render to prevent this object from rendering in photos taken by ANY players.", KGHEHNCOBMB.HAPJCEFDLFH.Warning, order = 1)]
		public bool NeverRender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private LKPBNFNIBPJ JJLEPIKPBFL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool DKJGFGOMHBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x13A6C00", Offset = "0x13A5A00", VA = "0x1813A6C00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x72B2C60", Offset = "0x72B1A60", VA = "0x1872B2C60", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72B2D60", Offset = "0x72B1B60", VA = "0x1872B2D60", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72B2E80", Offset = "0x72B1C80", VA = "0x1872B2E80")]
		public void SetPaused(bool FKNLOMIJIDB, UnityEngine.Object HACFGBHNOCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72B2E30", Offset = "0x72B1C30", VA = "0x1872B2E30")]
		public void PreRender(Camera IJAHNFGEONI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void ENOONIFBEBF(Camera IJAHNFGEONI);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x72B2DE0", Offset = "0x72B1BE0", VA = "0x1872B2DE0")]
		public void PostRender(Camera IJAHNFGEONI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void EAGCJMAILNO(Camera IJAHNFGEONI);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x72B2F50", Offset = "0x72B1D50", VA = "0x1872B2F50")]
		protected AltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class DisabledAltRenderedObject : AltRenderedObject, EIMDLIIFEAM<RecRoomStudioDisableRenderInShareCamPhoto>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct JCHKFGFDOIO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public (Component, bool)[] BJIHGJLINHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public (Component, bool)[] AEJOLPFDKLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public (Component, bool)[] EHEACOFLPIA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private JCHKFGFDOIO BPCJHBJLIAB;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x72B38A0", Offset = "0x72B26A0", VA = "0x1872B38A0")]
		public static JCHKFGFDOIO PreRender(GameObject IHNPMPCJPIK)
		{
			return default(JCHKFGFDOIO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x72B36E0", Offset = "0x72B24E0", VA = "0x1872B36E0")]
		public static void PostRender(JCHKFGFDOIO MOHABPHBKPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x72B3190", Offset = "0x72B1F90", VA = "0x1872B3190", Slot = "6")]
		protected override void ENOONIFBEBF(Camera IJAHNFGEONI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x72B2FD0", Offset = "0x72B1DD0", VA = "0x1872B2FD0", Slot = "7")]
		protected override void EAGCJMAILNO(Camera IJAHNFGEONI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x72B3640", Offset = "0x72B2440", VA = "0x1872B3640", Slot = "8")]
		private void HPCPFNJECKK(RecRoomStudioDisableRenderInShareCamPhoto HHNNIPLNMPE, int NIAAHOPGNFL, bool FGKFBIINEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x72B3A30", Offset = "0x72B2830", VA = "0x1872B3A30")]
		public DisabledAltRenderedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x72B3340", Offset = "0x72B2140", VA = "0x1872B3340")]
		[CompilerGenerated]
		internal static (Component, bool)[] GBCHKCLJNOI(IEnumerable<Component> DOJAFPBFKND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x72B3670", Offset = "0x72B2470", VA = "0x1872B3670")]
		[CompilerGenerated]
		internal static void PPBCCJNLPBC((Component, bool) KGGHDCPPPMN)
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
		[Cpp2IlInjected.Address(RVA = "0x72B3AC0", Offset = "0x72B28C0", VA = "0x1872B3AC0", Slot = "6")]
		protected override void ENOONIFBEBF(Camera IJAHNFGEONI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x72B3A80", Offset = "0x72B2880", VA = "0x1872B3A80", Slot = "7")]
		protected override void EAGCJMAILNO(Camera IJAHNFGEONI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x72B3B00", Offset = "0x72B2900", VA = "0x1872B3B00")]
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
		private Material[] LCPLEOJOPBN;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x72B3B80", Offset = "0x72B2980", VA = "0x1872B3B80", Slot = "6")]
		protected override void ENOONIFBEBF(Camera IJAHNFGEONI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x72B3B50", Offset = "0x72B2950", VA = "0x1872B3B50", Slot = "7")]
		protected override void EAGCJMAILNO(Camera IJAHNFGEONI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x72B3BD0", Offset = "0x72B29D0", VA = "0x1872B3BD0")]
		public MaterialSwapAltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class VisibilityRestriction : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private bool LCAIAKNOJEA;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool DNLKAFGCCDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xBE0400", Offset = "0xBDF200", VA = "0x180BE0400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x72B3EA0", Offset = "0x72B2CA0", VA = "0x1872B3EA0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x72B3EA0", Offset = "0x72B2CA0", VA = "0x1872B3EA0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		protected virtual void PLMNLGEEKGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void DJKAKFCNDGD();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D30", Offset = "0x8F5B30", VA = "0x1808F6D30")]
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
