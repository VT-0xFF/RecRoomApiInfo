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
		public enum IGODLBFEPBA
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
		public enum NFNMBMDKEAG
		{
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			AllNonExclusive,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			Any
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private IGODLBFEPBA visibleFor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private NFNMBMDKEAG evaluationMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		[Tooltip("We allow some ugc content for Junior accounts, this is fairly restricted. Consult Social team if you are not sure.")]
		private bool limitedUGCForJuniorAccount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private bool KPDCBCEDIDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private bool EIGFCLLPCBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private bool IGJNIOGLAKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private bool COPBNOJPMLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private BBMAGDMGLMJ FKJEIGAHGOG;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6104790", Offset = "0x6103590", VA = "0x186104790", Slot = "5")]
		protected override void CKEEPKIJAHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6104AF0", Offset = "0x61038F0", VA = "0x186104AF0", Slot = "4")]
		protected override void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x61049B0", Offset = "0x61037B0", VA = "0x1861049B0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x61048D0", Offset = "0x61036D0", VA = "0x1861048D0")]
		private void DPPLLKEENBO(bool KPDCBCEDIDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6104700", Offset = "0x6103500", VA = "0x186104700")]
		private void BDILLJOJJDA(bool KPDCBCEDIDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x61048E0", Offset = "0x61036E0", VA = "0x1861048E0", Slot = "6")]
		protected override void NLGDOKOBIPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
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
		[NPCAGAPHNIM("Alters the behavior of this object when rendered in photos taken by junior players", order = 0)]
		[NPCAGAPHNIM("Enable Never Render to prevent this object from rendering in photos taken by ANY players.", NPCAGAPHNIM.IBGGBHCIBNG.Warning, order = 1)]
		public bool NeverRender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private IGJOIAOJFFC NIFMKNKAIKO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool OGNEDGJOKGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xB88C20", Offset = "0xB87A20", VA = "0x180B88C20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6104BA0", Offset = "0x61039A0", VA = "0x186104BA0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6104C70", Offset = "0x6103A70", VA = "0x186104C70", Slot = "5")]
		protected virtual void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6104D90", Offset = "0x6103B90", VA = "0x186104D90")]
		public void SetPaused(bool MNOEKFANECC, UnityEngine.Object BNAJMHPOOCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6104D40", Offset = "0x6103B40", VA = "0x186104D40")]
		public void PreRender(Camera JMAPMJOABDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void BPLJMIPABMG(Camera JMAPMJOABDH);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6104CF0", Offset = "0x6103AF0", VA = "0x186104CF0")]
		public void PostRender(Camera JMAPMJOABDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void DPEJPPKLEBE(Camera JMAPMJOABDH);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6104E60", Offset = "0x6103C60", VA = "0x186104E60")]
		protected AltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class DisabledAltRenderedObject : AltRenderedObject, GMNGEIJKEOI<RecRoomStudioDisableRenderInShareCamPhoto>
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct MADPPPIJJEB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public (Component, bool)[] BLCAHFLDJGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public (Component, bool)[] FIINALAHPGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public (Component, bool)[] FOEDEFBCCOA;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private MADPPPIJJEB GCNOMABFNPF;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x61057B0", Offset = "0x61045B0", VA = "0x1861057B0")]
		public static MADPPPIJJEB PreRender(GameObject EAPMMKKAJGJ)
		{
			return default(MADPPPIJJEB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x61055F0", Offset = "0x61043F0", VA = "0x1861055F0")]
		public static void PostRender(MADPPPIJJEB FCOFDCGKPAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6104EE0", Offset = "0x6103CE0", VA = "0x186104EE0", Slot = "6")]
		protected override void BPLJMIPABMG(Camera JMAPMJOABDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x61050C0", Offset = "0x6103EC0", VA = "0x1861050C0", Slot = "7")]
		protected override void DPEJPPKLEBE(Camera JMAPMJOABDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6105090", Offset = "0x6103E90", VA = "0x186105090", Slot = "8")]
		private void DFIJIKEBOFB(RecRoomStudioDisableRenderInShareCamPhoto CMFKPIHBOHJ, int DFBJEFLELHE, bool JFFJFLKHPIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6105940", Offset = "0x6104740", VA = "0x186105940")]
		public DisabledAltRenderedObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6105280", Offset = "0x6104080", VA = "0x186105280")]
		[CompilerGenerated]
		internal static (Component, bool)[] FBINODIIJDI(IEnumerable<Component> GCEPMMFDAOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6105580", Offset = "0x6104380", VA = "0x186105580")]
		[CompilerGenerated]
		internal static void LBEKODKODBI((Component, bool) DLHIFNKLLMB)
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
		[Cpp2IlInjected.Address(RVA = "0x6105990", Offset = "0x6104790", VA = "0x186105990", Slot = "6")]
		protected override void BPLJMIPABMG(Camera JMAPMJOABDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x61059D0", Offset = "0x61047D0", VA = "0x1861059D0", Slot = "7")]
		protected override void DPEJPPKLEBE(Camera JMAPMJOABDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6105A10", Offset = "0x6104810", VA = "0x186105A10")]
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
		private Material[] KKIAALJBNOB;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6105A60", Offset = "0x6104860", VA = "0x186105A60", Slot = "6")]
		protected override void BPLJMIPABMG(Camera JMAPMJOABDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6105AB0", Offset = "0x61048B0", VA = "0x186105AB0", Slot = "7")]
		protected override void DPEJPPKLEBE(Camera JMAPMJOABDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6105AE0", Offset = "0x61048E0", VA = "0x186105AE0")]
		public MaterialSwapAltRenderedObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public abstract class VisibilityRestriction : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private bool KOJPHOHBNPC;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool CNNBPCHDKBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x87B500", Offset = "0x87A300", VA = "0x18087B500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6105DB0", Offset = "0x6104BB0", VA = "0x186105DB0", Slot = "4")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6105DB0", Offset = "0x6104BB0", VA = "0x186105DB0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
		protected virtual void CKEEPKIJAHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void NLGDOKOBIPB();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
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
