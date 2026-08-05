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
	private readonly struct NCLOBGDLNKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly MBELHNMBAID LMINMIBMCOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string LOGCOHNAJHG;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x862170", Offset = "0x860F70", VA = "0x180862170")]
		public NCLOBGDLNKC(MBELHNMBAID ODDCILLEOAA, string DDCJBJKCDAI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct PFJKFLANMLB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public NCLOBGDLNKC queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5FE59B0", Offset = "0x5FE47B0", VA = "0x185FE59B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5D50", Offset = "0x5FE4B50", VA = "0x185FE5D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider IBHLLKHNHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private HOAPGPFCNAJ<NCLOBGDLNKC, GameObject> BJNELDDNOOB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public FPJGKBLJOCO CKCLKNHJMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x78DFC0", Offset = "0x78CDC0", VA = "0x18078DFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private HOAPGPFCNAJ<NCLOBGDLNKC, GameObject> HILLGFGGLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0C80", Offset = "0x5FDFA80", VA = "0x185FE0C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int HIKDNIMAIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0C30", Offset = "0x5FDFA30", VA = "0x185FE0C30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5FE0870", Offset = "0x5FDF670", VA = "0x185FE0870", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5FE0DE0", Offset = "0x5FDFBE0", VA = "0x185FE0DE0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5FE0930", Offset = "0x5FDF730", VA = "0x185FE0930")]
	[AsyncStateMachine(typeof(PFJKFLANMLB))]
	private Task<GameObject> EAHNHLDDNLP(NCLOBGDLNKC DMKEPFECKMO, CancellationToken EHAEIHNIHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5FE0A50", Offset = "0x5FDF850", VA = "0x185FE0A50")]
	public Task<GameObject> LoadItemAsync(MBELHNMBAID ODDCILLEOAA, CancellationToken EHAEIHNIHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5FE0E50", Offset = "0x5FDFC50", VA = "0x185FE0E50")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class DBNNIGFOKGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public MBELHNMBAID JMBDCAIDNJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public readonly Texture AOCCDFGLEIC;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x79B830", Offset = "0x79A630", VA = "0x18079B830")]
		public DBNNIGFOKGA(MBELHNMBAID KONOIHLGLPJ, Texture BPELOPNELDJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum MDFIDDBDECK
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
	private class FAGHMNODOFH : GPLMKBKFGHN<Texture>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct OMOEFKELFJI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public FAGHMNODOFH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5FE5130", Offset = "0x5FE3F30", VA = "0x185FE5130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5FE5940", Offset = "0x5FE4740", VA = "0x185FE5940", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly MBELHNMBAID KONOIHLGLPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly RenderTexture KEJKGLGJMLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly ImposterRenderConfig BAKHPHHOFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CancellationToken EHAEIHNIHFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private GameObject GFDLNOPHMGD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override FJJBNKADFNG<Texture> MGKPJCOEPDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5FE1010", Offset = "0x5FDFE10", VA = "0x185FE1010", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public override Task<Texture> NEFMEPLGJAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x78DFA0", Offset = "0x78CDA0", VA = "0x18078DFA0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5FE1070", Offset = "0x5FDFE70", VA = "0x185FE1070")]
		public FAGHMNODOFH(MBELHNMBAID KONOIHLGLPJ, RenderTexture KEJKGLGJMLO, ImposterRenderConfig BAKHPHHOFDP, CancellationToken EHAEIHNIHFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0F20", Offset = "0x5FDFD20", VA = "0x185FE0F20")]
		[AsyncStateMachine(typeof(OMOEFKELFJI))]
		private Task<Texture> LMFPIMKDOEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0E90", Offset = "0x5FDFC90", VA = "0x185FE0E90", Slot = "10")]
		protected override void BHBHPNILBJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0EA0", Offset = "0x5FDFCA0", VA = "0x185FE0EA0")]
		private static void CNEGAPJECNH(GameObject GFDLNOPHMGD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct HMPLIBPAPOL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5FE1210", Offset = "0x5FE0010", VA = "0x185FE1210", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x92F090", Offset = "0x92DE90", VA = "0x18092F090", Slot = "5")]
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
	[SerializeField]
	[OBGJPAKDKLL(LNILAIILNJP.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Tooltip("Pixel size of the rendered imposter")]
	[Header("Imposter Rendering")]
	private MDFIDDBDECK size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[DAHJBBELEBC("size", MDFIDDBDECK.Custom)]
	[Tooltip("Custom pixel size for rendered imposter")]
	[SerializeField]
	private int customSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[SerializeField]
	private int antiAliasing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[Tooltip("Configuration specifying render properties for the imposter")]
	private ImposterRenderConfig imposterRenderConfig;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static int IOFLKPLEMGD;

	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public static RenderTextureFormat Format;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private RenderTexture FPOCCEAPBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private PBANMAEHGHL<GameObject> AIBGDBJDBHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private MJDAGPPLDNE GMHFEHLGHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CancellationTokenSource ELAGOJJKAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private INJGOFBOMAK<Texture> AJLHEMILFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private MBELHNMBAID EJLBDJNBKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private Texture MNPEJICGGGO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static int BBKFJFPHLDM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5FE2920", Offset = "0x5FE1720", VA = "0x185FE2920")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5FE2970", Offset = "0x5FE1770", VA = "0x185FE2970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private RenderTexture FNPMGHNLMIB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FE21E0", Offset = "0x5FE0FE0", VA = "0x185FE21E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x78E220", Offset = "0x78D020", VA = "0x18078E220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private MBELHNMBAID JMBDCAIDNJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x78E210", Offset = "0x78D010", VA = "0x18078E210")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5FE2480", Offset = "0x5FE1280", VA = "0x185FE2480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private bool OIDDPHDHDBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x513F8F0", Offset = "0x513E6F0", VA = "0x18513F8F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private int GODCLCGFFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5FE2140", Offset = "0x5FE0F40", VA = "0x185FE2140")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1F10", Offset = "0x5FE0D10", VA = "0x185FE1F10")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2390", Offset = "0x5FE1190", VA = "0x185FE2390")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5FE20C0", Offset = "0x5FE0EC0", VA = "0x185FE20C0")]
	private void GLKOKNOJCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5FE27F0", Offset = "0x5FE15F0", VA = "0x185FE27F0")]
	public void Set(MBELHNMBAID INGPEHGBIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2800", Offset = "0x5FE1600", VA = "0x185FE2800")]
	public void Set(Texture BPELOPNELDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2810", Offset = "0x5FE1610", VA = "0x185FE2810")]
	public void Set(DBNNIGFOKGA MBDKMNBCLGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1F20", Offset = "0x5FE0D20", VA = "0x185FE1F20")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5FE25F0", Offset = "0x5FE13F0", VA = "0x185FE25F0")]
	public void SetInternal(MBELHNMBAID INGPEHGBIJO, [Optional] Texture OHDOPJHKIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5FE25E0", Offset = "0x5FE13E0", VA = "0x185FE25E0")]
	public void SetCustomSize(int LKMHJNGPFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x795190", Offset = "0x793F90", VA = "0x180795190")]
	public void SetAntiAliasing(int HLFOGIOKHAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1F30", Offset = "0x5FE0D30", VA = "0x185FE1F30")]
	[AsyncStateMachine(typeof(HMPLIBPAPOL))]
	private void EBCKCHILLLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1FE0", Offset = "0x5FE0DE0", VA = "0x185FE1FE0")]
	private void FFINBKJKPNI(Texture BPELOPNELDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5FE28A0", Offset = "0x5FE16A0", VA = "0x185FE28A0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, FDMKCDNCHDI
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private const float DPGEEJGMEPO = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "4")]
	public void PrepareImposter(NKONEHLGDIN JMFMJMCAPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1ED0", Offset = "0x5FE0CD0", VA = "0x185FE1ED0")]
	public void SetReferencePoint(Vector3 DDAFDAEAOPI, Quaternion JNABFDAOKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1CD0", Offset = "0x5FE0AD0", VA = "0x185FE1CD0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5FE1EB0", Offset = "0x5FE0CB0", VA = "0x185FE1EB0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x13B4FE0", Offset = "0x13B3DE0", VA = "0x1813B4FE0")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NGJNOPICILK
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static NGJNOPICILK KPNDACKLIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public float KEAADJBOKPI;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2113FF0", Offset = "0x2112DF0", VA = "0x182113FF0")]
	public NGJNOPICILK(float MLBNGNPLNKK)
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		[OBGJPAKDKLL(LNILAIILNJP.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private const int BPKLOBKEEDP = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private const int LMJNAILDLLH = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly List<Material> HINPPNFBLMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool OLHFOPIGKEN;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5FE2B50", Offset = "0x5FE1950", VA = "0x185FE2B50")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5FE2A50", Offset = "0x5FE1850", VA = "0x185FE2A50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5FE2D90", Offset = "0x5FE1B90", VA = "0x185FE2D90")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MBELHNMBAID
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	string LNBBCEIDJMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	NGJNOPICILK NGJNOPICILK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action BPDEPPMDHJK;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> ILJEFJKMDPN(CancellationToken EHAEIHNIHFM);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MKCCOLMIKDJ(MBELHNMBAID GDMGBCDFBAL);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OEFGNEMPPKA();

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OLLMNEOJGGC();

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LEDDIFCOBIH([Out] INJGOFBOMAK<Texture> BBEMBADCHCI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class NFJGBNMDCLB
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5FE5000", Offset = "0x5FE3E00", VA = "0x185FE5000")]
	public static bool GNHODBONIAA(MBELHNMBAID OBDKJFGOCAB, MBELHNMBAID FBMIIJIBBFB)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, FDMKCDNCHDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5FDFE20", Offset = "0x5FDEC20", VA = "0x185FDFE20", Slot = "4")]
		public void PrepareImposter(NKONEHLGDIN JMFMJMCAPBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x790830", Offset = "0x78F630", VA = "0x180790830")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x790830", Offset = "0x78F630", VA = "0x180790830")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FDMKCDNCHDI
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(NKONEHLGDIN JMFMJMCAPBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface BBPHCGPAGFE
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	IEnumerable<Type> NKGLCPAJAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> HPJPPGCIAKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FPJGKBLJOCO
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GameObject OACDANPJAMH(GameObject CDFGDNNFDBC, Transform GEFCENNBDFI, bool FHLFBCKOFPO = false);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	T OACDANPJAMH<T>(T CDFGDNNFDBC, Transform GEFCENNBDFI, bool FHLFBCKOFPO = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	T OACDANPJAMH<T>(GameObject CDFGDNNFDBC, Transform GEFCENNBDFI, bool FHLFBCKOFPO = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GameObject OACDANPJAMH(GameObject CDFGDNNFDBC, Transform GEFCENNBDFI, NKONEHLGDIN JMFMJMCAPBJ, bool FHLFBCKOFPO);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class CACMACHGMOC : IDisposable, FPJGKBLJOCO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly HashSet<Type> JELLGGCGOEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HashSet<Type> FIBGEIGHFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Transform GDKGKPKJGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<Component> LEIFHOEBEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> JHIDLEMEJCA;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5FDF8E0", Offset = "0x5FDE6E0", VA = "0x185FDF8E0")]
	[OKINHFAHPEJ(FNGNILODNLI.None)]
	public static void PFLOEECCCOH(LPFNGCMIAEC KDNLDLIFDLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5FDF9E0", Offset = "0x5FDE7E0", VA = "0x185FDF9E0")]
	[Preserve]
	public CACMACHGMOC([MCCEMKLKAEE(null)] BBPHCGPAGFE GLNFJOAEPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5FDEF80", Offset = "0x5FDDD80", VA = "0x185FDEF80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5FDF7C0", Offset = "0x5FDE5C0", VA = "0x185FDF7C0", Slot = "5")]
	public GameObject OACDANPJAMH(GameObject CDFGDNNFDBC, Transform GEFCENNBDFI, bool FHLFBCKOFPO = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x23FDFA0", Offset = "0x23FCDA0", VA = "0x1823FDFA0", Slot = "6")]
	public T OACDANPJAMH<T>(T CDFGDNNFDBC, Transform GEFCENNBDFI, bool FHLFBCKOFPO = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x23FD9C0", Offset = "0x23FC7C0", VA = "0x1823FD9C0", Slot = "7")]
	public T OACDANPJAMH<T>(GameObject CDFGDNNFDBC, Transform GEFCENNBDFI, bool FHLFBCKOFPO = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5FDF850", Offset = "0x5FDE650", VA = "0x185FDF850", Slot = "8")]
	public GameObject OACDANPJAMH(GameObject CDFGDNNFDBC, Transform GEFCENNBDFI, NKONEHLGDIN JMFMJMCAPBJ, bool FHLFBCKOFPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x23FDF60", Offset = "0x23FCD60", VA = "0x1823FDF60", Slot = "9")]
	public T OACDANPJAMH<T>(GameObject CDFGDNNFDBC, Transform GEFCENNBDFI, NKONEHLGDIN JMFMJMCAPBJ, bool FHLFBCKOFPO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x23FD9F0", Offset = "0x23FC7F0", VA = "0x1823FD9F0")]
	private T OACDANPJAMH<T>(GameObject CDFGDNNFDBC, Transform GEFCENNBDFI, NKONEHLGDIN JMFMJMCAPBJ, bool FHLFBCKOFPO, [Out] GameObject ENMFBJADKEE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x23FD520", Offset = "0x23FC320", VA = "0x1823FD520")]
	private T JFLJEMAGBKF<T>(GameObject FAIKIGMIEFB, NKONEHLGDIN JMFMJMCAPBJ, bool FHLFBCKOFPO) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5FDF6B0", Offset = "0x5FDE4B0", VA = "0x185FDF6B0")]
	private void GIFMCIPNNMP(Component HFOAJNFAAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5FDF060", Offset = "0x5FDDE60", VA = "0x185FDF060")]
	private void FJGMPKJNLOD(Component HFOAJNFAAPM, NKONEHLGDIN JMFMJMCAPBJ, bool FHLFBCKOFPO, bool PCBIDOJDKAE, [Optional] Type KBMGFBKHADG, [Optional] Type ECAOKIOIOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5FDF540", Offset = "0x5FDE340", VA = "0x185FDF540")]
	private void GBMGBFKLMIG(GameObject FAIKIGMIEFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct NKONEHLGDIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private Dictionary<Type, object> LAIFFNOFEAE;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2715140", Offset = "0x2713F40", VA = "0x182715140")]
	public NKONEHLGDIN COLNBMOOCNM<T>(T NEMCDMBDEGA)
	{
		return default(NKONEHLGDIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2716040", Offset = "0x2714E40", VA = "0x182716040")]
	public T NAKCAFGMIJA<T>(T NNIKDBJKMOA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2715870", Offset = "0x2714670", VA = "0x182715870")]
	public bool GDDNGOCDKHE<T>([Out] T NEMCDMBDEGA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct JIEFOHEGIIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public bool MHKOOHBLKJP;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xC0EF90", Offset = "0xC0DD90", VA = "0x180C0EF90")]
	public JIEFOHEGIIN(bool BLGBHBCDMFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct KLHJIPFNFJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly bool DGDCDDKNEIK;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5FE4F50", Offset = "0x5FE3D50", VA = "0x185FE4F50")]
	public KLHJIPFNFJD(bool ICBCBGNPBIK)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x790830", Offset = "0x78F630", VA = "0x180790830")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, FDMKCDNCHDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5FE5DC0", Offset = "0x5FE4BC0", VA = "0x185FE5DC0", Slot = "4")]
		public void PrepareImposter(NKONEHLGDIN JMFMJMCAPBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x790830", Offset = "0x78F630", VA = "0x180790830")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ImposterBoundsOverride : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private Bounds imposterBounds;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Bounds JHPMBGGCCLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x5FE1B40", Offset = "0x5FE0940", VA = "0x185FE1B40")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5FE1B00", Offset = "0x5FE0900", VA = "0x185FE1B00")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5FE1AC0", Offset = "0x5FE08C0", VA = "0x185FE1AC0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5FE19D0", Offset = "0x5FE07D0", VA = "0x185FE19D0")]
		private void KCILDABHFPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x790830", Offset = "0x78F630", VA = "0x180790830")]
		public ImposterBoundsOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CreateAssetMenu(fileName = "ImposterRenderConfig", menuName = "RecRoom/Imposters/Imposter Render Config")]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			[Header("Shadows")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			[Range(0.1f, 10f)]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x5FE4FE0", Offset = "0x5FE3DE0", VA = "0x185FE4FE0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x5FE4FD0", Offset = "0x5FE3DD0", VA = "0x185FE4FD0")]
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
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[ColorUsage(false, true)]
		[Header("Environment Lighting")]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5FE29F0", Offset = "0x5FE17F0", VA = "0x185FE29F0")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class JJDKCMMOKGC
{
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static readonly List<URPLight> IOHAHCDDBCO;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly Vector3 BLFHOPHOKDB;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static readonly Vector3 GPOHALEPNIN;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static Camera CEFPCADNIEA;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static readonly List<Renderer> DDHHHNBFENL;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly List<ImposterBoundsOverride> MJEPHDOBNGJ;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static AmbientMode PLMMNNOKLCE;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color LPPMLLLEEBP;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Color KKHDADEACGK;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Color CBNIDBIPKGA;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static Cubemap MKJNJOOECAN;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static bool PBBOBDGGLJJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera NFADPDLNLNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5FE36F0", Offset = "0x5FE24F0", VA = "0x185FE36F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2F00", Offset = "0x5FE1D00", VA = "0x185FE2F00")]
	public static void CKJFGAFIDDC(Vector3 NBJJEADDPNP, Quaternion DEGOGCAOBJB, ImposterRenderConfig OOMOBDOGPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5FE4A30", Offset = "0x5FE3830", VA = "0x185FE4A30")]
	private static void OEKFLJBCNBD(Vector3 NBJJEADDPNP, Quaternion DEGOGCAOBJB, URPLight PIMBLKJMLAC, ImposterRenderConfig.LightConfig OCPPBEMOMGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5FE2E20", Offset = "0x5FE1C20", VA = "0x185FE2E20")]
	public static void ABMAJGGKFJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3E10", Offset = "0x5FE2C10", VA = "0x185FE3E10")]
	private static void LCHHAJLJCCO(int KNGHPLJBGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3BA0", Offset = "0x5FE29A0", VA = "0x185FE3BA0")]
	public static void GCCAJBEJIEA(ImposterRenderConfig OOMOBDOGPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5FE4190", Offset = "0x5FE2F90", VA = "0x185FE4190")]
	public static void LIJDADAEBNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5FE4860", Offset = "0x5FE3660", VA = "0x185FE4860")]
	public static void MFKHLPJPABF(GameObject ONONJDLEIDO, RenderTexture KEJKGLGJMLO, ImposterRenderConfig OOMOBDOGPNJ, NGJNOPICILK DGJOPHKILGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5FE4280", Offset = "0x5FE3080", VA = "0x185FE4280")]
	private static void LLLJMNHKGGE(GameObject ONONJDLEIDO, RenderTexture KEJKGLGJMLO, ImposterRenderConfig OOMOBDOGPNJ, NGJNOPICILK DGJOPHKILGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3900", Offset = "0x5FE2700", VA = "0x185FE3900")]
	private static void FFNFJPINBKK(GameObject ONONJDLEIDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3170", Offset = "0x5FE1F70", VA = "0x185FE3170")]
	public static void EFFKPELLGEJ(GameObject CDFGDNNFDBC, Vector3 ADMOLKGBLAN, Vector3 FIOEGBLIJBK, float CNFPOPPKCCH, NGJNOPICILK DGJOPHKILGK, [Out] Vector3 CJLIPNFOKAD, [Out] Quaternion CIPKJFEIOHH, [Out] float LKIABFOIHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5FE3D60", Offset = "0x5FE2B60", VA = "0x185FE3D60")]
	public static RenderTexture LAKJILBAPPM(int AIAKOMIHMDA, int BCNPNCGABDL, RenderTextureFormat OIAIKKGGJAI = RenderTextureFormat.ARGB32)
	{
		return null;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public struct LGPJJLEJIKP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public EEELEBFPAJE AOAJFDMKKAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public GameObject BLEFKHABCFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public RenderTexture FNPMGHNLMIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public ImposterRenderConfig OPDGPPMKJKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public NGJNOPICILK NGJNOPICILK;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5FE4F60", Offset = "0x5FE3D60", VA = "0x185FE4F60")]
			public LGPJJLEJIKP(EEELEBFPAJE ENDOBNICGKI, GameObject LNLGFOGFLBO, RenderTexture KEJKGLGJMLO, ImposterRenderConfig BAKHPHHOFDP, NGJNOPICILK DGJOPHKILGK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private static HOAPGPFCNAJ<LGPJJLEJIKP, RenderTexture> DKNLLAOAOMM;

		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private static readonly List<LGPJJLEJIKP> FBOFKEDLICA;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int NKLDEMNCMBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5FE0160", Offset = "0x5FDEF60", VA = "0x185FE0160")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0410", Offset = "0x5FDF210", VA = "0x185FE0410")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject ONONJDLEIDO, RenderTexture KEJKGLGJMLO, ImposterRenderConfig OOMOBDOGPNJ, NGJNOPICILK DGJOPHKILGK, CancellationToken EHAEIHNIHFM, bool OBLNAKAEEAF = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5FDFF70", Offset = "0x5FDED70", VA = "0x185FDFF70", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0370", Offset = "0x5FDF170", VA = "0x185FE0370", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5FE01D0", Offset = "0x5FDEFD0", VA = "0x185FE01D0")]
		private static Task<RenderTexture> KIOKFNALGFD(LGPJJLEJIKP NPPJEGEOHFF, CancellationToken EHAEIHNIHFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5FE0830", Offset = "0x5FDF630", VA = "0x185FE0830")]
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
