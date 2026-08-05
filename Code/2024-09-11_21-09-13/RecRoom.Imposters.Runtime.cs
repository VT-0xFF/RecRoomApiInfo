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
		[Cpp2IlInjected.Address(RVA = "0xC51880", Offset = "0xC4FE80", VA = "0x180C51880")]
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
		public ACJPHJNBHJI queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6B8EA00", Offset = "0x6B8D000", VA = "0x186B8EA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6B8EDA0", Offset = "0x6B8D3A0", VA = "0x186B8EDA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x887030", Offset = "0x885630", VA = "0x180887030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private AHBIPPDKNFN<ACJPHJNBHJI, GameObject> EOMCHMBJBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6B8BE60", Offset = "0x6B8A460", VA = "0x186B8BE60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int OMKEGCNGACK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6B8C3A0", Offset = "0x6B8A9A0", VA = "0x186B8C3A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6B8BFC0", Offset = "0x6B8A5C0", VA = "0x186B8BFC0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C3F0", Offset = "0x6B8A9F0", VA = "0x186B8C3F0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C0A0", Offset = "0x6B8A6A0", VA = "0x186B8C0A0")]
	[AsyncStateMachine(typeof(GCBGMKANJOC))]
	private Task<GameObject> JGFHEFIAMIN(ACJPHJNBHJI IGLDFOKAPDK, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C1C0", Offset = "0x6B8A7C0", VA = "0x186B8C1C0")]
	public Task<GameObject> LoadItemAsync(GHHFJPNPLEF OMHOBBFNDEF, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C460", Offset = "0x6B8AA60", VA = "0x186B8C460")]
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
		[Cpp2IlInjected.Address(RVA = "0x88AB80", Offset = "0x889180", VA = "0x18088AB80")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B90B10", Offset = "0x6B8F110", VA = "0x186B90B10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6B91310", Offset = "0x6B8F910", VA = "0x186B91310", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B8B110", Offset = "0x6B89710", VA = "0x186B8B110", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> DLODDOEOAOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8879F0", Offset = "0x885FF0", VA = "0x1808879F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6B8B1F0", Offset = "0x6B897F0", VA = "0x186B8B1F0")]
		public CDCKKEPHFOO(GHHFJPNPLEF MINMEGBKDFP, RenderTexture NLJNFEPLKML, ImposterRenderConfig IJDONPIKBLO, CancellationToken IONNNJNKLMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6B8B010", Offset = "0x6B89610", VA = "0x186B8B010")]
		[AsyncStateMachine(typeof(MHBJIHEJFPC))]
		private Task<Texture> BHLILHICAIF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6B8B100", Offset = "0x6B89700", VA = "0x186B8B100", Slot = "10")]
		protected override void DNDPHLKJOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6B8B170", Offset = "0x6B89770", VA = "0x186B8B170")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B902A0", Offset = "0x6B8E8A0", VA = "0x186B902A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xB9D680", Offset = "0xB9BC80", VA = "0x180B9D680", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B8FD80", Offset = "0x6B8E380", VA = "0x186B8FD80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6B8FDD0", Offset = "0x6B8E3D0", VA = "0x186B8FDD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture CPMFCBKJGJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6B8F580", Offset = "0x6B8DB80", VA = "0x186B8F580")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x887930", Offset = "0x885F30", VA = "0x180887930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private GHHFJPNPLEF GAFEKGMCCBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x886840", Offset = "0x884E40", VA = "0x180886840")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6B8F8E0", Offset = "0x6B8DEE0", VA = "0x186B8F8E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool KDCGAMJBKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x17C86F0", Offset = "0x17C6CF0", VA = "0x1817C86F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int MGEKODHGGMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6B8F760", Offset = "0x6B8DD60", VA = "0x186B8F760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F430", Offset = "0x6B8DA30", VA = "0x186B8F430")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F7F0", Offset = "0x6B8DDF0", VA = "0x186B8F7F0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F500", Offset = "0x6B8DB00", VA = "0x186B8F500")]
	private void IGEDKNGPLOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FCA0", Offset = "0x6B8E2A0", VA = "0x186B8FCA0")]
	public void Set(GHHFJPNPLEF COOKHKKNOAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FC50", Offset = "0x6B8E250", VA = "0x186B8FC50")]
	public void Set(Texture AKFEKCILDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FC60", Offset = "0x6B8E260", VA = "0x186B8FC60")]
	public void Set(DJHIKJHODIG KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F440", Offset = "0x6B8DA40", VA = "0x186B8F440")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FA50", Offset = "0x6B8E050", VA = "0x186B8FA50")]
	public void SetInternal(GHHFJPNPLEF COOKHKKNOAI, [Optional] Texture NCCJIHKIBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FA40", Offset = "0x6B8E040", VA = "0x186B8FA40")]
	public void SetCustomSize(int GFCBMIAFFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x893F70", Offset = "0x892570", VA = "0x180893F70")]
	public void SetAntiAliasing(int HHINHDGPKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F450", Offset = "0x6B8DA50", VA = "0x186B8F450")]
	[AsyncStateMachine(typeof(JGICFMAAGGK))]
	private void EMHFFOKDMDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F350", Offset = "0x6B8D950", VA = "0x186B8F350")]
	private void ABGDNJAKDAN(Texture AKFEKCILDGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6B8FD00", Offset = "0x6B8E300", VA = "0x186B8FD00")]
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
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "4")]
	public void PrepareImposter(NBEDJOHJHFC FCDCCFDNJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F310", Offset = "0x6B8D910", VA = "0x186B8F310")]
	public void SetReferencePoint(Vector3 OKJIEPLMHFB, Quaternion IKIABBBCOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F120", Offset = "0x6B8D720", VA = "0x186B8F120")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6B8F2F0", Offset = "0x6B8D8F0", VA = "0x186B8F2F0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x17A2D50", Offset = "0x17A1350", VA = "0x1817A2D50")]
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
	[Cpp2IlInjected.Address(RVA = "0x2267600", Offset = "0x2265C00", VA = "0x182267600")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B92680", Offset = "0x6B90C80", VA = "0x186B92680", Slot = "8")]
		public override void BHEMPDPJNII(CGCPPALGHJA registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x624B890", Offset = "0x6249E90", VA = "0x18624B890")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B8FFD0", Offset = "0x6B8E5D0", VA = "0x186B8FFD0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6B8FED0", Offset = "0x6B8E4D0", VA = "0x186B8FED0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6B90210", Offset = "0x6B8E810", VA = "0x186B90210")]
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
	[Cpp2IlInjected.Address(RVA = "0x6B913F0", Offset = "0x6B8F9F0", VA = "0x186B913F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B8B3B0", Offset = "0x6B899B0", VA = "0x186B8B3B0", Slot = "4")]
		public void PrepareImposter(NBEDJOHJHFC FCDCCFDNJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x885340", Offset = "0x883940", VA = "0x180885340")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x885340", Offset = "0x883940", VA = "0x180885340")]
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
	[Cpp2IlInjected.Address(RVA = "0x6B91BD0", Offset = "0x6B901D0", VA = "0x186B91BD0")]
	[DJINMBCHLNM.LIHKMGLKGEL]
	public static void LJBMCKAFLEE(JEFLJDHAGDI EOPOOELIKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6B91F60", Offset = "0x6B90560", VA = "0x186B91F60")]
	[UnityEngine.Scripting.Preserve]
	public OHIHHOBJMOJ([OLJNBPOCBCJ(null)] BAJGHKDKDNO FIFPJAKEMMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6B91990", Offset = "0x6B8FF90", VA = "0x186B91990", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6B91B80", Offset = "0x6B90180", VA = "0x186B91B80", Slot = "5")]
	public void GPAJNCDEAME(params Type[] JJECNKJHOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6B91CD0", Offset = "0x6B902D0", VA = "0x186B91CD0", Slot = "6")]
	public GameObject NJALNPNLDEL(GameObject HLHCNAIOGEN, Transform LDJCBIBELIM, bool CFLOIDAAIDJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2E3EA40", Offset = "0x2E3D040", VA = "0x182E3EA40", Slot = "7")]
	public T NJALNPNLDEL<T>(T HLHCNAIOGEN, Transform LDJCBIBELIM, bool CFLOIDAAIDJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x2E3EB30", Offset = "0x2E3D130", VA = "0x182E3EB30", Slot = "8")]
	public T NJALNPNLDEL<T>(GameObject HLHCNAIOGEN, Transform LDJCBIBELIM, bool CFLOIDAAIDJ = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6B91D60", Offset = "0x6B90360", VA = "0x186B91D60", Slot = "9")]
	public GameObject NJALNPNLDEL(GameObject HLHCNAIOGEN, Transform LDJCBIBELIM, NBEDJOHJHFC FCDCCFDNJHM, bool CFLOIDAAIDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2E3EAD0", Offset = "0x2E3D0D0", VA = "0x182E3EAD0", Slot = "10")]
	public T NJALNPNLDEL<T>(GameObject HLHCNAIOGEN, Transform LDJCBIBELIM, NBEDJOHJHFC FCDCCFDNJHM, bool CFLOIDAAIDJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2E3EB80", Offset = "0x2E3D180", VA = "0x182E3EB80")]
	private T NJALNPNLDEL<T>(GameObject HLHCNAIOGEN, Transform LDJCBIBELIM, NBEDJOHJHFC FCDCCFDNJHM, bool CFLOIDAAIDJ, [Out] GameObject MOFACNHCJPG) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E5A0", Offset = "0x2E3CBA0", VA = "0x182E3E5A0")]
	private T DNDLFEPKPED<T>(GameObject MNKAGJEGJCF, NBEDJOHJHFC FCDCCFDNJHM, bool CFLOIDAAIDJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6B91A70", Offset = "0x6B90070", VA = "0x186B91A70")]
	private void EMBNBPONHAF(Component INEJDODHNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6B914E0", Offset = "0x6B8FAE0", VA = "0x186B914E0")]
	private void APKKGCCNMLK(Component INEJDODHNGG, NBEDJOHJHFC FCDCCFDNJHM, bool CFLOIDAAIDJ, bool MACFJKGLOOD, [Optional] Type IIOJMFFOKGJ, [Optional] Type ICECGLEFCPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6B91DF0", Offset = "0x6B903F0", VA = "0x186B91DF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2E02520", Offset = "0x2E00B20", VA = "0x182E02520")]
	public NBEDJOHJHFC ENCKAHEIPGI<T>(T ACIFELAFDKA)
	{
		return default(NBEDJOHJHFC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2E03420", Offset = "0x2E01A20", VA = "0x182E03420")]
	public T PBGHNKGJFJB<T>(T MCAGMGIJFIA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2E02C50", Offset = "0x2E01250", VA = "0x182E02C50")]
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
	[Cpp2IlInjected.Address(RVA = "0x2266760", Offset = "0x2264D60", VA = "0x182266760")]
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
	[Cpp2IlInjected.Address(RVA = "0x6B8EE10", Offset = "0x6B8D410", VA = "0x186B8EE10")]
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
		[Cpp2IlInjected.Address(RVA = "0x885340", Offset = "0x883940", VA = "0x180885340")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B923A0", Offset = "0x6B909A0", VA = "0x186B923A0", Slot = "4")]
		public void PrepareImposter(NBEDJOHJHFC FCDCCFDNJHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x885340", Offset = "0x883940", VA = "0x180885340")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B8EF90", Offset = "0x6B8D590", VA = "0x186B8EF90")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6B8EF50", Offset = "0x6B8D550", VA = "0x186B8EF50")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6B8EF10", Offset = "0x6B8D510", VA = "0x186B8EF10")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6B8EE20", Offset = "0x6B8D420", VA = "0x186B8EE20")]
		private void LIOIBBDIKPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x885340", Offset = "0x883940", VA = "0x180885340")]
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
				[Cpp2IlInjected.Address(RVA = "0x6B90AF0", Offset = "0x6B8F0F0", VA = "0x186B90AF0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6B90AE0", Offset = "0x6B8F0E0", VA = "0x186B90AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B8FE40", Offset = "0x6B8E440", VA = "0x186B8FE40")]
		public void FOCHALHOBIL(Vector3 PGDAIMHHILE, Quaternion GFAFBDMOJBB, float CJBAJNFCFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6B8FE70", Offset = "0x6B8E470", VA = "0x186B8FE70")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B8DE10", Offset = "0x6B8C410", VA = "0x186B8DE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static List<Light> OPMCOPBMDDE
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6B8E400", Offset = "0x6B8CA00", VA = "0x186B8E400")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static Camera LFBMBOECAAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6B8CD60", Offset = "0x6B8B360", VA = "0x186B8CD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C4A0", Offset = "0x6B8AAA0", VA = "0x186B8C4A0")]
	public static void ABNKNBLMNDK(Vector3 PIDNENIJBOG, Quaternion FIAMOABPOEF, ImposterRenderConfig HGHMIPKGGFJ, bool HMIANLLFCNG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6B8E010", Offset = "0x6B8C610", VA = "0x186B8E010")]
	private static void JLCMBNOJEJA(Vector3 PIDNENIJBOG, Quaternion FIAMOABPOEF, URPLight EPGCIFPLCAO, ImposterRenderConfig.LightConfig IPHIMAFIFHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6B8E450", Offset = "0x6B8CA50", VA = "0x186B8E450")]
	public static void MDNGFBCGJEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6B8DA00", Offset = "0x6B8C000", VA = "0x186B8DA00")]
	private static void GODKEEJADDJ(int DICCGFDIHHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6B8DE60", Offset = "0x6B8C460", VA = "0x186B8DE60")]
	public static void JIOJHEJNLKL(ImposterRenderConfig HGHMIPKGGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6B8D5E0", Offset = "0x6B8BBE0", VA = "0x186B8D5E0")]
	public static void EFPHNKKMFPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6B8D6C0", Offset = "0x6B8BCC0", VA = "0x186B8D6C0")]
	public static void FCCDJMAPIJA(GameObject LDKOBGJEPMJ, RenderTexture NLJNFEPLKML, ImposterRenderConfig HGHMIPKGGFJ, KGLJJDEMODI BADLKNIGIAP, [Optional] Vector3? CMAHLMAALMD, [Optional] Vector3? KHLDMFPFGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6B8C730", Offset = "0x6B8AD30", VA = "0x186B8C730")]
	private static void BDIPPJIIGMK(GameObject LDKOBGJEPMJ, RenderTexture NLJNFEPLKML, ImposterRenderConfig HGHMIPKGGFJ, KGLJJDEMODI BADLKNIGIAP, Vector3 CMAHLMAALMD, Vector3 KHLDMFPFGIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6B8E530", Offset = "0x6B8CB30", VA = "0x186B8E530")]
	private static void PBKJPHNONMG(GameObject LDKOBGJEPMJ, Vector3 MJICJFGBMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6B8CF90", Offset = "0x6B8B590", VA = "0x186B8CF90")]
	private static void EBDDCBMMLON(GameObject HLHCNAIOGEN, ImposterRenderConfig HGHMIPKGGFJ, KGLJJDEMODI BADLKNIGIAP, [Out] Vector3 JFDIADJAGPG, [Out] Quaternion GIENEJGAFCJ, [Out] float PFABDLFDJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6B8E330", Offset = "0x6B8C930", VA = "0x186B8E330")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B91380", Offset = "0x6B8F980", VA = "0x186B91380")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B8B900", Offset = "0x6B89F00", VA = "0x186B8B900")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6B8BA20", Offset = "0x6B8A020", VA = "0x186B8BA20")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject LDKOBGJEPMJ, RenderTexture NLJNFEPLKML, ImposterRenderConfig HGHMIPKGGFJ, KGLJJDEMODI BADLKNIGIAP, CancellationToken IONNNJNKLMJ, bool PKFHGFANCHI = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6B8B500", Offset = "0x6B89B00", VA = "0x186B8B500", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6B8B990", Offset = "0x6B89F90", VA = "0x186B8B990", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6B8B710", Offset = "0x6B89D10", VA = "0x186B8B710")]
		private static Task<RenderTexture> IAHJGNMHLAK(NPLOHFKHFHM BJPMNPGFPCO, CancellationToken IONNNJNKLMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6B8BE20", Offset = "0x6B8A420", VA = "0x186B8BE20")]
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
