using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.Core.DataStructures;
using RecRoom.Core.Imposters;
using RecRoom.DataLayer.Attributes;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;
using UnityEngine.UI;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DeferredImposterSpawnManager : SingletonMonoBehaviour<DeferredImposterSpawnManager>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private readonly struct ACJPHJNBHJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly GHHFJPNPLEF CGHDMEOMFME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string IGLNGGCKCNN;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xD09E10", Offset = "0xD08810", VA = "0x180D09E10")]
		public ACJPHJNBHJI(GHHFJPNPLEF OMHOBBFNDEF, string LHJGOMAMPPA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct GCBGMKANJOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public ACJPHJNBHJI queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6C75C70", Offset = "0x6C74670", VA = "0x186C75C70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C76030", Offset = "0x6C74A30", VA = "0x186C76030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider GMBEIAFAEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private AHBIPPDKNFN<ACJPHJNBHJI, GameObject> JFIMMDKOPNA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public CLDCDFHBNFK AGCDFPKFAJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x899030", Offset = "0x897A30", VA = "0x180899030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private AHBIPPDKNFN<ACJPHJNBHJI, GameObject> EOMCHMBJBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6C730D0", Offset = "0x6C71AD0", VA = "0x186C730D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int OMKEGCNGACK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C73610", Offset = "0x6C72010", VA = "0x186C73610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C73230", Offset = "0x6C71C30", VA = "0x186C73230", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C73660", Offset = "0x6C72060", VA = "0x186C73660", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C73310", Offset = "0x6C71D10", VA = "0x186C73310")]
	[AsyncStateMachine(typeof(GCBGMKANJOC))]
	private Task<GameObject> JGFHEFIAMIN(ACJPHJNBHJI IGLDFOKAPDK, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C73430", Offset = "0x6C71E30", VA = "0x186C73430")]
	public Task<GameObject> LoadItemAsync(GHHFJPNPLEF OMHOBBFNDEF, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6C736D0", Offset = "0x6C720D0", VA = "0x186C736D0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class DJHIKJHODIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public GHHFJPNPLEF GAFEKGMCCBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture DBJPCJDMJJE;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x89CB80", Offset = "0x89B580", VA = "0x18089CB80")]
		public DJHIKJHODIG(GHHFJPNPLEF MINMEGBKDFP, Texture AKFEKCILDGA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum APDLEHHKMEE
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		XS_128 = 0x80,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		S_256 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		M_512 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		L_1024 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		XL_2048 = 0x800
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class CDCKKEPHFOO : IGOJEPKBAMD<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct MHBJIHEJFPC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public CDCKKEPHFOO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6C77DA0", Offset = "0x6C767A0", VA = "0x186C77DA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6C785A0", Offset = "0x6C76FA0", VA = "0x186C785A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly GHHFJPNPLEF MINMEGBKDFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture NLJNFEPLKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig IJDONPIKBLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken IONNNJNKLMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject PLMNHILMIIL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override JAGIEECCCMP<Texture> BFMCIAAECGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6C72300", Offset = "0x6C70D00", VA = "0x186C72300", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> DLODDOEOAOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8999F0", Offset = "0x8983F0", VA = "0x1808999F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6C723E0", Offset = "0x6C70DE0", VA = "0x186C723E0")]
		public CDCKKEPHFOO(GHHFJPNPLEF MINMEGBKDFP, RenderTexture NLJNFEPLKML, ImposterRenderConfig IJDONPIKBLO, CancellationToken IONNNJNKLMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6C72200", Offset = "0x6C70C00", VA = "0x186C72200")]
		[AsyncStateMachine(typeof(MHBJIHEJFPC))]
		private Task<Texture> BHLILHICAIF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6C722F0", Offset = "0x6C70CF0", VA = "0x186C722F0", Slot = "10")]
		protected override void DNDPHLKJOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C72360", Offset = "0x6C70D60", VA = "0x186C72360")]
		private static void NFNFEGCGNDH(GameObject PLMNHILMIIL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct JGICFMAAGGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<Texture> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6C77530", Offset = "0x6C75F30", VA = "0x186C77530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8E5A10", Offset = "0x8E4410", VA = "0x1808E5A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[Tooltip("Texture shown when the imposter texture is not available")]
	[SerializeField]
	[Header("General")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[JLEDHNACBFM(LPFNGFMJOGK.Self, false, false, false)]
	[SerializeField]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	[SerializeField]
	private APDLEHHKMEE size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[EDIEJGINKKE("size", APDLEHHKMEE.Custom)]
	[Tooltip("Custom pixel size for rendered imposter")]
	[SerializeField]
	private int customSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	private int antiAliasing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[Tooltip("Configuration specifying render properties for the imposter")]
	[SerializeField]
	private ImposterRenderConfig imposterRenderConfig;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static int PNDKAJHAMAA;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture IAIIHKLNPKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private CPOHPJBNDEA<GameObject> HKFAEIKCDIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private IBILKJCONGN OHMCPBKBNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource ADHBHFEGLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private POLPOFEBNLM<Texture> EIDMLNIINCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private GHHFJPNPLEF MBDFBKILGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture DKHADLDBAJF;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int DNJEENJFOII
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6C77010", Offset = "0x6C75A10", VA = "0x186C77010")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6C77060", Offset = "0x6C75A60", VA = "0x186C77060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture CPMFCBKJGJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C76810", Offset = "0x6C75210", VA = "0x186C76810")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x899930", Offset = "0x898330", VA = "0x180899930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private GHHFJPNPLEF GAFEKGMCCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x898840", Offset = "0x897240", VA = "0x180898840")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6C76B70", Offset = "0x6C75570", VA = "0x186C76B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool KDCGAMJBKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1900280", Offset = "0x18FEC80", VA = "0x181900280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int MGEKODHGGMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6C769F0", Offset = "0x6C753F0", VA = "0x186C769F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6C766C0", Offset = "0x6C750C0", VA = "0x186C766C0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6C76A80", Offset = "0x6C75480", VA = "0x186C76A80")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6C76790", Offset = "0x6C75190", VA = "0x186C76790")]
	private void IGEDKNGPLOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6C76F30", Offset = "0x6C75930", VA = "0x186C76F30")]
	public void Set(GHHFJPNPLEF COOKHKKNOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C76EE0", Offset = "0x6C758E0", VA = "0x186C76EE0")]
	public void Set(Texture AKFEKCILDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6C76EF0", Offset = "0x6C758F0", VA = "0x186C76EF0")]
	public void Set(DJHIKJHODIG KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6C766D0", Offset = "0x6C750D0", VA = "0x186C766D0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C76CE0", Offset = "0x6C756E0", VA = "0x186C76CE0")]
	public void SetInternal(GHHFJPNPLEF COOKHKKNOAI, [Optional] Texture NCCJIHKIBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6C76CD0", Offset = "0x6C756D0", VA = "0x186C76CD0")]
	public void SetCustomSize(int GFCBMIAFFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8A5F70", Offset = "0x8A4970", VA = "0x1808A5F70")]
	public void SetAntiAliasing(int HHINHDGPKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6C766E0", Offset = "0x6C750E0", VA = "0x186C766E0")]
	[AsyncStateMachine(typeof(JGICFMAAGGK))]
	private void EMHFFOKDMDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C765E0", Offset = "0x6C74FE0", VA = "0x186C765E0")]
	private void ABGDNJAKDAN(Texture AKFEKCILDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C76F90", Offset = "0x6C75990", VA = "0x186C76F90")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, JCNNLIPMIMJ
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float HHCHHAFIACJ = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "4")]
	public void PrepareImposter(NBEDJOHJHFC FCDCCFDNJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6C765A0", Offset = "0x6C74FA0", VA = "0x186C765A0")]
	public void SetReferencePoint(Vector3 OKJIEPLMHFB, Quaternion IKIABBBCOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6C763B0", Offset = "0x6C74DB0", VA = "0x186C763B0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6C76580", Offset = "0x6C74F80", VA = "0x186C76580")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x184BBE0", Offset = "0x184A5E0", VA = "0x18184BBE0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct KGLJJDEMODI
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static KGLJJDEMODI PFOHONFKCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float IGFEFJCGNNL;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x230A130", Offset = "0x2308B30", VA = "0x18230A130")]
	public KGLJJDEMODI(float PCIDCNGJLKG)
	{
	}
}
namespace _AssemblyRegistry.RecRoom_Imposters_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : PBJLLMOALLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6C79910", Offset = "0x6C78310", VA = "0x186C79910", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x632F010", Offset = "0x632DA10", VA = "0x18632F010")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[JLEDHNACBFM(LPFNGFMJOGK.Self, false, false, false)]
		[SerializeField]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int IMJFMCIEEOM = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int FJHCDGNEGOK = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> MOBEFNCJALI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool ANOLFMCIHBB;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6C77260", Offset = "0x6C75C60", VA = "0x186C77260")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6C77160", Offset = "0x6C75B60", VA = "0x186C77160")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6C774A0", Offset = "0x6C75EA0", VA = "0x186C774A0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface GHHFJPNPLEF
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string AKDNKBCELME
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	KGLJJDEMODI KGLJJDEMODI
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action HGPLHPOGDGE;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> GLLMJDIFJFM(CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GDMOAEJJJNJ(GHHFJPNPLEF PLNBHPCFEOK);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CIAAHLNDFDM();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JLLFKIHMGDC();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BAKHFJICKOA([Out] POLPOFEBNLM<Texture> CCGHLGADCAO);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class OELEHCGDMNI
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6C78680", Offset = "0x6C77080", VA = "0x186C78680")]
	public static bool PONMKPGHEDO(GHHFJPNPLEF FPNGGNAMCLJ, GHHFJPNPLEF DAMMLKLBLKA)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CenterInImposter : MonoBehaviour, JCNNLIPMIMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6C725A0", Offset = "0x6C70FA0", VA = "0x186C725A0", Slot = "4")]
		public void PrepareImposter(NBEDJOHJHFC FCDCCFDNJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x897340", Offset = "0x895D40", VA = "0x180897340")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x897340", Offset = "0x895D40", VA = "0x180897340")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JCNNLIPMIMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(NBEDJOHJHFC FCDCCFDNJHM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface BAJGHKDKDNO
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> NPMDJAFFJFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> PBMJFPAGFIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface CLDCDFHBNFK
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GPAJNCDEAME(params Type[] JJECNKJHOHJ);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject NJALNPNLDEL(GameObject HLHCNAIOGEN, Transform LDJCBIBELIM, bool CFLOIDAAIDJ = false);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T NJALNPNLDEL<T>(T HLHCNAIOGEN, Transform LDJCBIBELIM, bool CFLOIDAAIDJ = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T NJALNPNLDEL<T>(GameObject HLHCNAIOGEN, Transform LDJCBIBELIM, bool CFLOIDAAIDJ = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	GameObject NJALNPNLDEL(GameObject HLHCNAIOGEN, Transform LDJCBIBELIM, NBEDJOHJHFC FCDCCFDNJHM, bool CFLOIDAAIDJ);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OHIHHOBJMOJ : IDisposable, CLDCDFHBNFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> GMNNAMNNACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> LJNIBECLDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform BGKAFMNKLJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> FPCLKCAGNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> PIDMFGKDPMO;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C78E60", Offset = "0x6C77860", VA = "0x186C78E60")]
	[DJINMBCHLNM.LIHKMGLKGEL]
	public static void LJBMCKAFLEE(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6C791F0", Offset = "0x6C77BF0", VA = "0x186C791F0")]
	[UnityEngine.Scripting.Preserve]
	public OHIHHOBJMOJ([OLJNBPOCBCJ(null)] BAJGHKDKDNO FIFPJAKEMMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6C78C20", Offset = "0x6C77620", VA = "0x186C78C20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6C78E10", Offset = "0x6C77810", VA = "0x186C78E10", Slot = "5")]
	public void GPAJNCDEAME(params Type[] JJECNKJHOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6C78F60", Offset = "0x6C77960", VA = "0x186C78F60", Slot = "6")]
	public GameObject NJALNPNLDEL(GameObject HLHCNAIOGEN, Transform LDJCBIBELIM, bool CFLOIDAAIDJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2F19EA0", Offset = "0x2F188A0", VA = "0x182F19EA0", Slot = "7")]
	public T NJALNPNLDEL<T>(T HLHCNAIOGEN, Transform LDJCBIBELIM, bool CFLOIDAAIDJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2F19F90", Offset = "0x2F18990", VA = "0x182F19F90", Slot = "8")]
	public T NJALNPNLDEL<T>(GameObject HLHCNAIOGEN, Transform LDJCBIBELIM, bool CFLOIDAAIDJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6C78FF0", Offset = "0x6C779F0", VA = "0x186C78FF0", Slot = "9")]
	public GameObject NJALNPNLDEL(GameObject HLHCNAIOGEN, Transform LDJCBIBELIM, NBEDJOHJHFC FCDCCFDNJHM, bool CFLOIDAAIDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2F19F30", Offset = "0x2F18930", VA = "0x182F19F30", Slot = "10")]
	public T NJALNPNLDEL<T>(GameObject HLHCNAIOGEN, Transform LDJCBIBELIM, NBEDJOHJHFC FCDCCFDNJHM, bool CFLOIDAAIDJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2F19FE0", Offset = "0x2F189E0", VA = "0x182F19FE0")]
	private T NJALNPNLDEL<T>(GameObject HLHCNAIOGEN, Transform LDJCBIBELIM, NBEDJOHJHFC FCDCCFDNJHM, bool CFLOIDAAIDJ, [Out] GameObject MOFACNHCJPG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2F19A00", Offset = "0x2F18400", VA = "0x182F19A00")]
	private T DNDLFEPKPED<T>(GameObject MNKAGJEGJCF, NBEDJOHJHFC FCDCCFDNJHM, bool CFLOIDAAIDJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6C78D00", Offset = "0x6C77700", VA = "0x186C78D00")]
	private void EMBNBPONHAF(Component INEJDODHNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6C78770", Offset = "0x6C77170", VA = "0x186C78770")]
	private void APKKGCCNMLK(Component INEJDODHNGG, NBEDJOHJHFC FCDCCFDNJHM, bool CFLOIDAAIDJ, bool MACFJKGLOOD, [Optional] Type IIOJMFFOKGJ, [Optional] Type ICECGLEFCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6C79080", Offset = "0x6C77A80", VA = "0x186C79080")]
	private void NKPMDIANBCP(GameObject MNKAGJEGJCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct NBEDJOHJHFC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> MHLOOHKAAKF;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2EDDC60", Offset = "0x2EDC660", VA = "0x182EDDC60")]
	public NBEDJOHJHFC ENCKAHEIPGI<T>(T ACIFELAFDKA)
	{
		return default(NBEDJOHJHFC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2EDEB60", Offset = "0x2EDD560", VA = "0x182EDEB60")]
	public T PBGHNKGJFJB<T>(T MCAGMGIJFIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2EDE390", Offset = "0x2EDCD90", VA = "0x182EDE390")]
	public bool JLNEIPDMCNA<T>([Out] T ACIFELAFDKA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct GAGPDNKNANI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool CDAHOLBMGLP;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2309290", Offset = "0x2307C90", VA = "0x182309290")]
	public GAGPDNKNANI(bool IKMAIAGMIFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct HICEFFPGJPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool DOAKNJFOPCH;

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6C760A0", Offset = "0x6C74AA0", VA = "0x186C760A0")]
	public HICEFFPGJPD(bool JNCJIBONFGC)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x897340", Offset = "0x895D40", VA = "0x180897340")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ScaleInImposter : MonoBehaviour, JCNNLIPMIMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6C79630", Offset = "0x6C78030", VA = "0x186C79630", Slot = "4")]
		public void PrepareImposter(NBEDJOHJHFC FCDCCFDNJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x897340", Offset = "0x895D40", VA = "0x180897340")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ImposterBoundsOverride : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Bounds imposterBounds;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Bounds BCDILKLAFJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6C76220", Offset = "0x6C74C20", VA = "0x186C76220")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6C761E0", Offset = "0x6C74BE0", VA = "0x186C761E0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6C761A0", Offset = "0x6C74BA0", VA = "0x186C761A0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6C760B0", Offset = "0x6C74AB0", VA = "0x186C760B0")]
		private void LIOIBBDIKPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x897340", Offset = "0x895D40", VA = "0x180897340")]
		public ImposterBoundsOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CreateAssetMenu(fileName = "ImposterRenderConfig", menuName = "RecRoom/Imposters/Imposter Render Config")]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x600006C")]
				[Cpp2IlInjected.Address(RVA = "0x6C77D80", Offset = "0x6C76780", VA = "0x186C77D80")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6C77D70", Offset = "0x6C76770", VA = "0x186C77D70")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public float cameraOffsetMaxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[ColorUsage(false, true)]
		[Header("Environment Lighting")]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[HideInInspector]
		public bool useExplicitCameraComposition;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[HideInInspector]
		public Vector3 explicitCameraPositionOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		[HideInInspector]
		public Quaternion explicitCameraRotationOffset;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[HideInInspector]
		public float explicitCameraOrthographicSize;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6C770D0", Offset = "0x6C75AD0", VA = "0x186C770D0")]
		public void FOCHALHOBIL(Vector3 PGDAIMHHILE, Quaternion GFAFBDMOJBB, float CJBAJNFCFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6C77100", Offset = "0x6C75B00", VA = "0x186C77100")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class ECGGBDPKPFL
{
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly Vector3 HKFAGIHEFOE;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly List<URPLight> CELBKFHMKBG;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly List<Light> ENLHMBPHAJN;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Camera HEOGNPNMFOD;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly List<Renderer> CGAOJKJMNBH;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly List<ImposterBoundsOverride> JJLDIJIEHCF;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static AmbientMode JBCIAPOPPIA;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private static Color NJMMIPEDNCL;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private static Color KBMOEEBOEMF;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private static Color LKOHDONKIGJ;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private static Cubemap HBJHAJBGKNK;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private static bool FLBMDHPNHNN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static List<URPLight> IBFDOKLEDGG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6C75080", Offset = "0x6C73A80", VA = "0x186C75080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> OPMCOPBMDDE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6C75670", Offset = "0x6C74070", VA = "0x186C75670")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera LFBMBOECAAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6C73FD0", Offset = "0x6C729D0", VA = "0x186C73FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6C73710", Offset = "0x6C72110", VA = "0x186C73710")]
	public static void ABNKNBLMNDK(Vector3 PIDNENIJBOG, Quaternion FIAMOABPOEF, ImposterRenderConfig HGHMIPKGGFJ, bool HMIANLLFCNG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6C75280", Offset = "0x6C73C80", VA = "0x186C75280")]
	private static void JLCMBNOJEJA(Vector3 PIDNENIJBOG, Quaternion FIAMOABPOEF, URPLight EPGCIFPLCAO, ImposterRenderConfig.LightConfig IPHIMAFIFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6C756C0", Offset = "0x6C740C0", VA = "0x186C756C0")]
	public static void MDNGFBCGJEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6C74C70", Offset = "0x6C73670", VA = "0x186C74C70")]
	private static void GODKEEJADDJ(int DICCGFDIHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6C750D0", Offset = "0x6C73AD0", VA = "0x186C750D0")]
	public static void JIOJHEJNLKL(ImposterRenderConfig HGHMIPKGGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6C74850", Offset = "0x6C73250", VA = "0x186C74850")]
	public static void EFPHNKKMFPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6C74930", Offset = "0x6C73330", VA = "0x186C74930")]
	public static void FCCDJMAPIJA(GameObject LDKOBGJEPMJ, RenderTexture NLJNFEPLKML, ImposterRenderConfig HGHMIPKGGFJ, KGLJJDEMODI BADLKNIGIAP, [Optional] Vector3? CMAHLMAALMD, [Optional] Vector3? KHLDMFPFGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6C739A0", Offset = "0x6C723A0", VA = "0x186C739A0")]
	private static void BDIPPJIIGMK(GameObject LDKOBGJEPMJ, RenderTexture NLJNFEPLKML, ImposterRenderConfig HGHMIPKGGFJ, KGLJJDEMODI BADLKNIGIAP, Vector3 CMAHLMAALMD, Vector3 KHLDMFPFGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6C757A0", Offset = "0x6C741A0", VA = "0x186C757A0")]
	private static void PBKJPHNONMG(GameObject LDKOBGJEPMJ, Vector3 MJICJFGBMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6C74200", Offset = "0x6C72C00", VA = "0x186C74200")]
	private static void EBDDCBMMLON(GameObject HLHCNAIOGEN, ImposterRenderConfig HGHMIPKGGFJ, KGLJJDEMODI BADLKNIGIAP, [Out] Vector3 JFDIADJAGPG, [Out] Quaternion GIENEJGAFCJ, [Out] float PFABDLFDJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6C755A0", Offset = "0x6C73FA0", VA = "0x186C755A0")]
	public static RenderTexture LAHHFMFNJGL(int LGAIJEFLCNP, int BNIDPDGADNN, RenderTextureFormat OJCKNPDLJJF = RenderTextureFormat.ARGB32, string DEKCAKEFOAN = "[ImposterRendering]Preview")
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public struct NPLOHFKHFHM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public IKMBNOHICPK IBKOJJAOPHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public GameObject AMHDBPJACLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public RenderTexture CPMFCBKJGJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public ImposterRenderConfig DOGLNIBMJFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public KGLJJDEMODI KGLJJDEMODI;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6C78610", Offset = "0x6C77010", VA = "0x186C78610")]
			public NPLOHFKHFHM(IKMBNOHICPK LCHMOEJABHG, GameObject NOFOKOODIJH, RenderTexture NLJNFEPLKML, ImposterRenderConfig IJDONPIKBLO, KGLJJDEMODI BADLKNIGIAP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static AHBIPPDKNFN<NPLOHFKHFHM, RenderTexture> CJKNGFDIBDJ;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private static readonly List<NPLOHFKHFHM> MBDGHPJGFDP;

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private static int NENCFFICGCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x6C72B70", Offset = "0x6C71570", VA = "0x186C72B70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6C72C90", Offset = "0x6C71690", VA = "0x186C72C90")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject LDKOBGJEPMJ, RenderTexture NLJNFEPLKML, ImposterRenderConfig HGHMIPKGGFJ, KGLJJDEMODI BADLKNIGIAP, CancellationToken IONNNJNKLMJ, bool PKFHGFANCHI = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6C726F0", Offset = "0x6C710F0", VA = "0x186C726F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6C72C00", Offset = "0x6C71600", VA = "0x186C72C00", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6C72900", Offset = "0x6C71300", VA = "0x186C72900")]
		private static Task<RenderTexture> IAHJGNMHLAK(NPLOHFKHFHM BJPMNPGFPCO, CancellationToken IONNNJNKLMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6C73090", Offset = "0x6C71A90", VA = "0x186C73090")]
		public DeferredImposterRenderer()
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
