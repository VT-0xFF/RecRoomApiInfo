using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mono.Math;
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
	private readonly struct LOPKGAANGHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly DMNMAEJFBID HAJJEIBEMMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly string HCDIFBBJJCM;

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCDACE0", Offset = "0xCD9AE0", VA = "0x180CDACE0")]
		public LOPKGAANGHE(DMNMAEJFBID EKHCEKLOBIL, string KIIMCBIPPLC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private struct MJMPJGHMPBH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public LOPKGAANGHE queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x20414B0", Offset = "0x20402B0", VA = "0x1820414B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x20417F0", Offset = "0x20405F0", VA = "0x1820417F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private IRecRoomQualityConfigProvider LOLJFBFEMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private global::EDMGHCKHING<LOPKGAANGHE, GameObject> PBJOGHBOOAB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public DDHEKHJJJNI NFHNNMABEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7011D0", Offset = "0x6FFFD0", VA = "0x1807011D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private global::EDMGHCKHING<LOPKGAANGHE, GameObject> ODINPIAIKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x203CED0", Offset = "0x203BCD0", VA = "0x18203CED0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private int AINELKIHJPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x203CE80", Offset = "0x203BC80", VA = "0x18203CE80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x203CDD0", Offset = "0x203BBD0", VA = "0x18203CDD0", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x203D350", Offset = "0x203C150", VA = "0x18203D350", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x203D200", Offset = "0x203C000", VA = "0x18203D200")]
	[AsyncStateMachine(typeof(MJMPJGHMPBH))]
	private Task<GameObject> MHEDICBAHPB(LOPKGAANGHE IKKFDCJAGBM, CancellationToken ONKANLKLEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x203D030", Offset = "0x203BE30", VA = "0x18203D030")]
	public Task<GameObject> LoadItemAsync(DMNMAEJFBID EKHCEKLOBIL, CancellationToken ONKANLKLEAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x203D3C0", Offset = "0x203C1C0", VA = "0x18203D3C0")]
	public DeferredImposterSpawnManager()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class BFCKALAHFHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public DMNMAEJFBID DEMKGDPLJDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public readonly Texture LFPDAJJFNKI;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8FC090", Offset = "0x8FAE90", VA = "0x1808FC090")]
		public BFCKALAHFHB(DMNMAEJFBID MDBOBAHBNEA, Texture MACEMPHCNCG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum JJLHONIIOFP
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		XS_128 = 0x80,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		S_256 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		M_512 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		L_1024 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		XL_2048 = 0x800
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private class NIJPIDPJPBL : global::JOPKPGPOBHH<Texture>, BILBGOMOIJP, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct HPBAIFMGEGH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public NIJPIDPJPBL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x203F550", Offset = "0x203E350", VA = "0x18203F550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x203FC50", Offset = "0x203EA50", VA = "0x18203FC50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly DMNMAEJFBID MDBOBAHBNEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly RenderTexture MHFALDDJPCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly ImposterRenderConfig LKINBFIMFBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly CancellationToken ONKANLKLEAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private GameObject EKIGGAECNKH;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		private FFFHIGBANBM BDLLNPCKAGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2043060", Offset = "0x2041E60", VA = "0x182043060", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public global::KOILDJEEFJD<Texture> MCJMIDFMEMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2043010", Offset = "0x2041E10", VA = "0x182043010", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Task HJGAKGHLMMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6D0BA0", Offset = "0x6CF9A0", VA = "0x1806D0BA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Task<Texture> GGOGLDCCAMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6D0BA0", Offset = "0x6CF9A0", VA = "0x1806D0BA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2043070", Offset = "0x2041E70", VA = "0x182043070")]
		public NIJPIDPJPBL(DMNMAEJFBID MDBOBAHBNEA, RenderTexture MHFALDDJPCP, ImposterRenderConfig LKINBFIMFBK, CancellationToken ONKANLKLEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2042E50", Offset = "0x2041C50", VA = "0x182042E50")]
		[AsyncStateMachine(typeof(HPBAIFMGEGH))]
		private Task<Texture> CLEEBBDDKOF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2043000", Offset = "0x2041E00", VA = "0x182043000", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2042F70", Offset = "0x2041D70", VA = "0x182042F70")]
		private static void DBDFJCGOLBE(GameObject EKIGGAECNKH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct MJLEMECDBAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private TaskAwaiter<Texture> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2040D20", Offset = "0x203FB20", VA = "0x182040D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA753D0", Offset = "0xA741D0", VA = "0x180A753D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	[Header("General")]
	[Tooltip("Texture shown when the imposter texture is not available")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[GBGNHGGGIDI(DKGJGBDJNIO.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private JJLHONIIOFP size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	[Tooltip("Custom pixel size for rendered imposter")]
	[EKKHEPIAELP("size", 0)]
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

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private RenderTexture MGJINNHPBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private global::OGCIFLDFEID<GameObject> OJLDADLELID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private BDICOFJGLHK DOFAEBLILAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private CancellationTokenSource PPJCBPHOKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private global::JOPKPGPOBHH<Texture> NAKIFDDBCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private DMNMAEJFBID GFPEAMGGGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private Texture FBKFAAHMFFI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private RenderTexture MDBGONHGHGP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2040160", Offset = "0x203EF60", VA = "0x182040160")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6D4460", Offset = "0x6D3260", VA = "0x1806D4460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private DMNMAEJFBID DEMKGDPLJDG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C5CB0", Offset = "0x6C4AB0", VA = "0x1806C5CB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2040000", Offset = "0x203EE00", VA = "0x182040000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private bool NKDJMNMCOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x12896A0", Offset = "0x12884A0", VA = "0x1812896A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	private int BDLBAGDICLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x203FFF0", Offset = "0x203EDF0", VA = "0x18203FFF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x203FF50", Offset = "0x203ED50", VA = "0x18203FF50")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x20403C0", Offset = "0x203F1C0", VA = "0x1820403C0")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x203FF60", Offset = "0x203ED60", VA = "0x18203FF60")]
	private void CCINEFMHCBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x20407B0", Offset = "0x203F5B0", VA = "0x1820407B0")]
	public void Set(DMNMAEJFBID AJHNEODHBKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x2040800", Offset = "0x203F600", VA = "0x182040800")]
	public void Set(Texture MACEMPHCNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x20407C0", Offset = "0x203F5C0", VA = "0x1820407C0")]
	public void Set(BFCKALAHFHB DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x2040150", Offset = "0x203EF50", VA = "0x182040150")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2040590", Offset = "0x203F390", VA = "0x182040590")]
	public void SetInternal(DMNMAEJFBID AJHNEODHBKG, [Optional] Texture EAAACKDJMKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2040580", Offset = "0x203F380", VA = "0x182040580")]
	public void SetCustomSize(int BJIEAIOKNOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xB83FE0", Offset = "0xB82DE0", VA = "0x180B83FE0")]
	public void SetAntiAliasing(int GLMPOEFNJAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x20404B0", Offset = "0x203F2B0", VA = "0x1820404B0")]
	[AsyncStateMachine(typeof(MJLEMECDBAP))]
	private void PBEGKMCIDCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x20402D0", Offset = "0x203F0D0", VA = "0x1820402D0")]
	private void OFPDLIBGMJH(Texture MACEMPHCNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x2040810", Offset = "0x203F610", VA = "0x182040810")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class ImposterPreviewCustomFraming : MonoBehaviour, LICEEGCPGOC
{
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const float GHNPPCPLDDE = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6C8090", Offset = "0x6C6E90", VA = "0x1806C8090", Slot = "4")]
	public void PrepareImposter(ECPBMNOKBMB LNCKHCKJOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x203FF10", Offset = "0x203ED10", VA = "0x18203FF10")]
	public void SetReferencePoint(Vector3 OECGCOHJOHK, Quaternion JILDBBFONDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x203FD80", Offset = "0x203EB80", VA = "0x18203FD80")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x203FEE0", Offset = "0x203ECE0", VA = "0x18203FEE0")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x1CAC380", Offset = "0x1CAB180", VA = "0x181CAC380")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct BLNBAHIJPNO
{
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public static BLNBAHIJPNO JPEAEOJMNOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public float PLIOAFGOGOL;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8D4500", Offset = "0x8D3300", VA = "0x1808D4500")]
	public BLNBAHIJPNO(float FGPJLHEMLKG)
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		[GBGNHGGGIDI(DKGJGBDJNIO.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const int GPNKAEOIPKH = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const int NGCKIDNJMNA = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly List<Material> IPNNOKNGMNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool BLHOMJOOEDI;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x20409C0", Offset = "0x203F7C0", VA = "0x1820409C0")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x20408D0", Offset = "0x203F6D0", VA = "0x1820408D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2040C00", Offset = "0x203FA00", VA = "0x182040C00")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DMNMAEJFBID
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string EEMCADPHDLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	BLNBAHIJPNO BLNBAHIJPNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action GFPFCIFFGDP;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> HIMIGMEHFKM(CancellationToken ONKANLKLEAL);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HMKGAHJANLF(DMNMAEJFBID BNIMMCIKNIE);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FPDFANOGGDA();

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GNGMEEGAPLK();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool GDNDNPKMDPD(out global::JOPKPGPOBHH<Texture> OFLNHCBGDGP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class IPELGKBCGHM
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x203FCA0", Offset = "0x203EAA0", VA = "0x18203FCA0")]
	public static bool LINMCIDFIOG(DMNMAEJFBID HBPABIDMCMH, DMNMAEJFBID OGCCBNKJEIG)
	{
		return default(bool);
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class CenterInImposter : MonoBehaviour, LICEEGCPGOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x203C340", Offset = "0x203B140", VA = "0x18203C340", Slot = "4")]
		public void PrepareImposter(ECPBMNOKBMB LNCKHCKJOFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface LICEEGCPGOC
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(ECPBMNOKBMB LNCKHCKJOFM);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public interface JPNMLJOANHK
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> NGKGCNMDNOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<Type> BDGNBKAPICJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface DDHEKHJJJNI
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IBOOHGBPCJN(params Type[] CBKHHLNLKPG);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CLJEGODCFGM(params Type[] CBKHHLNLKPG);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject EAFPKBKIOJN(GameObject MDFMPPCALJP, Transform KICGHGEEADG, bool GGMOGGECCJH = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T EAFPKBKIOJN<T>(T MDFMPPCALJP, Transform KICGHGEEADG, bool GGMOGGECCJH = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T EAFPKBKIOJN<T>(GameObject MDFMPPCALJP, Transform KICGHGEEADG, bool GGMOGGECCJH = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject EAFPKBKIOJN(GameObject MDFMPPCALJP, Transform KICGHGEEADG, ECPBMNOKBMB LNCKHCKJOFM, bool GGMOGGECCJH);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T EAFPKBKIOJN<T>(GameObject MDFMPPCALJP, Transform KICGHGEEADG, ECPBMNOKBMB LNCKHCKJOFM, bool GGMOGGECCJH) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T EAFPKBKIOJN<T>(T MDFMPPCALJP, Transform KICGHGEEADG, ECPBMNOKBMB LNCKHCKJOFM, bool GGMOGGECCJH) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class MKBOAEPCBGH : IDisposable, DDHEKHJJJNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private readonly HashSet<Type> LPICHIMLHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly HashSet<Type> HCALBAJJPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private Transform JGFOEOCPGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly List<Component> CDADBFCPNON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> OOLFJFCLCDG;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2041840", Offset = "0x2040640", VA = "0x182041840")]
	[HPAMKJCLFIM(BFFNGLOENLB.None)]
	public static void BMLCOLABDIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x20423E0", Offset = "0x20411E0", VA = "0x1820423E0")]
	[Preserve]
	public MKBOAEPCBGH([NOAEAKEJBMN(null)] JPNMLJOANHK FDOCOENEHIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x2041990", Offset = "0x2040790", VA = "0x182041990", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2042390", Offset = "0x2041190", VA = "0x182042390", Slot = "5")]
	public void IBOOHGBPCJN(params Type[] CBKHHLNLKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2041940", Offset = "0x2040740", VA = "0x182041940", Slot = "6")]
	public void CLJEGODCFGM(params Type[] CBKHHLNLKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2041B20", Offset = "0x2040920", VA = "0x182041B20", Slot = "7")]
	public GameObject EAFPKBKIOJN(GameObject MDFMPPCALJP, Transform KICGHGEEADG, bool GGMOGGECCJH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3663CC0", Offset = "0x3662AC0", VA = "0x183663CC0", Slot = "8")]
	public T EAFPKBKIOJN<T>(T MDFMPPCALJP, Transform KICGHGEEADG, bool GGMOGGECCJH = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3663C90", Offset = "0x3662A90", VA = "0x183663C90", Slot = "9")]
	public T EAFPKBKIOJN<T>(GameObject MDFMPPCALJP, Transform KICGHGEEADG, bool GGMOGGECCJH = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2041A90", Offset = "0x2040890", VA = "0x182041A90", Slot = "10")]
	public GameObject EAFPKBKIOJN(GameObject MDFMPPCALJP, Transform KICGHGEEADG, ECPBMNOKBMB LNCKHCKJOFM, bool GGMOGGECCJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3663D30", Offset = "0x3662B30", VA = "0x183663D30", Slot = "11")]
	public T EAFPKBKIOJN<T>(GameObject MDFMPPCALJP, Transform KICGHGEEADG, ECPBMNOKBMB LNCKHCKJOFM, bool GGMOGGECCJH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3663C00", Offset = "0x3662A00", VA = "0x183663C00", Slot = "12")]
	public T EAFPKBKIOJN<T>(T MDFMPPCALJP, Transform KICGHGEEADG, ECPBMNOKBMB LNCKHCKJOFM, bool GGMOGGECCJH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x36636D0", Offset = "0x36624D0", VA = "0x1836636D0")]
	private T EAFPKBKIOJN<T>(GameObject MDFMPPCALJP, Transform KICGHGEEADG, ECPBMNOKBMB LNCKHCKJOFM, bool GGMOGGECCJH, out GameObject EMCIEHKAPOH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3663170", Offset = "0x3661F70", VA = "0x183663170")]
	private T AAOACMAKLHA<T>(GameObject NGIKODIIBGN, ECPBMNOKBMB LNCKHCKJOFM, bool GGMOGGECCJH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2041BB0", Offset = "0x20409B0", VA = "0x182041BB0")]
	private void ENMKHMLNHPP(Component BFKBHAILEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2041E40", Offset = "0x2040C40", VA = "0x182041E40")]
	private void HHAAFPCAGHC(Component BFKBHAILEEA, ECPBMNOKBMB LNCKHCKJOFM, bool GGMOGGECCJH, bool HBNNJKLDOAH, [Optional] Type FFKMEAGNBNO, [Optional] Type NBBPABPNMGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2041CE0", Offset = "0x2040AE0", VA = "0x182041CE0")]
	private void HFANMDCHHMC(GameObject NGIKODIIBGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct ECPBMNOKBMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Dictionary<Type, object> FGEHEPJFFMK;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x3ACDFD0", Offset = "0x3ACCDD0", VA = "0x183ACDFD0")]
	public ECPBMNOKBMB LMMFIPJEJPN<T>(T HNDKIKCHCLJ)
	{
		return default(ECPBMNOKBMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3ACDEB0", Offset = "0x3ACCCB0", VA = "0x183ACDEB0")]
	public T HEOCMNIHPLM<T>(T HCMHCJOGKFN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3ACD710", Offset = "0x3ACC510", VA = "0x183ACD710")]
	public bool GBLHCMBLLEL<T>(out T HNDKIKCHCLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct NKGGJMDJFBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool EDFPBHGENCO;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8D1B20", Offset = "0x8D0920", VA = "0x1808D1B20")]
	public NKGGJMDJFBA(bool LDLNIAABLJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct GEGCOKBLCEF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly bool CHPHJCMLHOJ;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x203F540", Offset = "0x203E340", VA = "0x18203F540")]
	public GEGCOKBLCEF(bool FHMDOKGOOEE)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
		public KeepImposterUpright()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class ScaleInImposter : MonoBehaviour, LICEEGCPGOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2043210", Offset = "0x2042010", VA = "0x182043210", Slot = "4")]
		public void PrepareImposter(ECPBMNOKBMB LNCKHCKJOFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6C73B0", Offset = "0x6C61B0", VA = "0x1806C73B0")]
		public ScaleInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CreateAssetMenu]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000068")]
				[Cpp2IlInjected.Address(RVA = "0x2040D00", Offset = "0x203FB00", VA = "0x182040D00")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x2040CF0", Offset = "0x203FAF0", VA = "0x182040CF0")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		[Header("Environment Lighting")]
		[ColorUsage(false, true)]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x2040890", Offset = "0x203F690", VA = "0x182040890")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class GCHKIJIADCP
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly List<URPLight> OIMNGHDMIOH;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly Vector3 JBKALFMELIN;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly Vector3 NCGDECNDMCD;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static Camera PFKAMIBGDLB;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public const string CNCPDDKMCPL = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public const HBFPLGPHNAM OICMEMKENDK = HBFPLGPHNAM.Water;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static readonly List<Renderer> PPJKOCEKJBA;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static AmbientMode IDNBLNGLJJJ;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static Color LHDHPONPGFO;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static Color EKCEJPOFNKK;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static Color BIMOLHGPPBO;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Cubemap JEGBBOBLCCA;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static bool MBEPEPHKIIH;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static Camera PFEOAHDFJAD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x203DF50", Offset = "0x203CD50", VA = "0x18203DF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x203EDC0", Offset = "0x203DBC0", VA = "0x18203EDC0")]
	public static void NLFMFAOMCJI(Vector3 EEDDEBLIPIH, Quaternion BBBJJAFJAOB, ImposterRenderConfig OEFCDOBMJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x203E6E0", Offset = "0x203D4E0", VA = "0x18203E6E0")]
	private static void LNGGCKGICEA(Vector3 EEDDEBLIPIH, Quaternion BBBJJAFJAOB, URPLight JEAFCBMLEOE, ImposterRenderConfig.LightConfig MKINFNLHOBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x203E5F0", Offset = "0x203D3F0", VA = "0x18203E5F0")]
	public static void LJPKCFNFGFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x203E9F0", Offset = "0x203D7F0", VA = "0x18203E9F0")]
	private static void MJILBMLCMKJ(int GICABDGIJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x203D430", Offset = "0x203C230", VA = "0x18203D430")]
	public static void BFPHJBDEAKE(ImposterRenderConfig OEFCDOBMJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x203F2F0", Offset = "0x203E0F0", VA = "0x18203F2F0")]
	public static void PJGMJBOHGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x203DD80", Offset = "0x203CB80", VA = "0x18203DD80")]
	public static void FDOAMIEBAEE(GameObject ANFOEKMFBMK, RenderTexture MHFALDDJPCP, ImposterRenderConfig OEFCDOBMJJE, BLNBAHIJPNO NHOBGJHOPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x203D5B0", Offset = "0x203C3B0", VA = "0x18203D5B0")]
	private static void BHPCOKAMBMH(GameObject ANFOEKMFBMK, RenderTexture MHFALDDJPCP, ImposterRenderConfig OEFCDOBMJJE, BLNBAHIJPNO NHOBGJHOPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x203F040", Offset = "0x203DE40", VA = "0x18203F040")]
	private static void OBPEOLHNMMP(GameObject ANFOEKMFBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x203E180", Offset = "0x203CF80", VA = "0x18203E180")]
	public static void HHFFMGOKJGO(List<Renderer> GJIBAKJEOBB, List<Material> CKMNMJCFHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x203DAB0", Offset = "0x203C8B0", VA = "0x18203DAB0")]
	public static void FDGGANFKLBB(GameObject MDFMPPCALJP, Vector3 OHCKGNNNLBB, Vector3 HGEIAFHECAG, float LAHEINBEKMB, BLNBAHIJPNO NHOBGJHOPDK, out Vector3 CMJOJNBLNED, out Quaternion LJHBLCHGKLG, out float HHGLNJIIFFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x203E320", Offset = "0x203D120", VA = "0x18203E320")]
	public static RenderTexture JMFOFAFDLIC(int IHIELFHBHBE, int KDPPAHMOANJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x203E3C0", Offset = "0x203D1C0", VA = "0x18203E3C0")]
	public static void LBPFPJKIKLB()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public struct JJBJPPJDEFG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public HNONHEFEGPD EEIIEAAHNBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public GameObject FIFOOBNJFHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public RenderTexture MDBGONHGHGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public ImposterRenderConfig FEHNDPNDAFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public BLNBAHIJPNO BLNBAHIJPNO;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x2040C80", Offset = "0x203FA80", VA = "0x182040C80")]
			public JJBJPPJDEFG(HNONHEFEGPD HOJMPPKDDNK, GameObject EMAKLGNFOMF, RenderTexture MHFALDDJPCP, ImposterRenderConfig LKINBFIMFBK, BLNBAHIJPNO NHOBGJHOPDK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static global::EDMGHCKHING<JJBJPPJDEFG, RenderTexture> LLNBKCPEMHJ;

		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private static readonly List<JJBJPPJDEFG> BHCEHKEJKLF;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private static int NDNLJJMBNII
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x203C860", Offset = "0x203B660", VA = "0x18203C860")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x203C970", Offset = "0x203B770", VA = "0x18203C970")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject ANFOEKMFBMK, RenderTexture MHFALDDJPCP, ImposterRenderConfig OEFCDOBMJJE, BLNBAHIJPNO NHOBGJHOPDK, CancellationToken ONKANLKLEAL, bool KJFKJPMKDNF = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x203C4A0", Offset = "0x203B2A0", VA = "0x18203C4A0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x203C8D0", Offset = "0x203B6D0", VA = "0x18203C8D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x203C690", Offset = "0x203B490", VA = "0x18203C690")]
		private static Task<RenderTexture> LEAKMOAAHNK(JJBJPPJDEFG IDOEAFNPILP, CancellationToken ONKANLKLEAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x203CD60", Offset = "0x203BB60", VA = "0x18203CD60")]
		public DeferredImposterRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class NCKGPBKGCOP
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static byte[] EALBAFGLJIB;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private static int HJJBAIGPCIK;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private static int DMHGBIHBKDJ;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private static BigInteger HJDFPPAMGPN;

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public NCKGPBKGCOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x2042B70", Offset = "0x2041970", VA = "0x182042B70")]
	private static string NEFLGCBJNIO(byte[] BFLEMGIJKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x2042820", Offset = "0x2041620", VA = "0x182042820")]
	public static string BMCDLAKFGCG(byte[] GACPBGKAIDC, bool DFCFJJAKINH)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
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
