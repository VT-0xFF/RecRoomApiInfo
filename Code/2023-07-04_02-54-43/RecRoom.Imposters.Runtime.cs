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
public class ImposterPreviewCustomFraming : MonoBehaviour, CJIGMJEEGGL
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private const float KBGANJANPDF = 0.05f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	public ReferencePoint ImposterPreviewCamera;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public float orthographicSize;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "4")]
	public void PrepareImposter(AEAPHDLMPNL CCDJMIJMJKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7098340", Offset = "0x7096940", VA = "0x187098340")]
	public void SetReferencePoint(Vector3 FFBPBBJMKKL, Quaternion PJECOBPELHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x70981B0", Offset = "0x70967B0", VA = "0x1870981B0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7098310", Offset = "0x7096910", VA = "0x187098310")]
	private void OnValidate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7098380", Offset = "0x7096980", VA = "0x187098380")]
	public ImposterPreviewCustomFraming()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[RequireComponent(typeof(RawImage))]
public class ImposterRawImage : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class LBODDAIGCEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public DDKILPDOABP CBFGNODIIAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly Texture NCMJMIFIKON;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x953E90", Offset = "0x952490", VA = "0x180953E90")]
		public LBODDAIGCEK(DDKILPDOABP MNLGCOJCIEI, Texture HJBKIJHPFFK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum FMGMEDDKMCC
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		Custom = 0,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		XS_128 = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		S_256 = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		M_512 = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		L_1024 = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		XL_2048 = 0x800
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private class ADLKHNPJHHC : MPMJDGKIEHM<Texture>, JELHGAIFJPP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class AGNHFKNBJFO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public AsyncTaskMethodBuilder<Texture> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public ADLKHNPJHHC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private GameObject <>s__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private TaskAwaiter<GameObject> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
			public AGNHFKNBJFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x7092FE0", Offset = "0x70915E0", VA = "0x187092FE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly DDKILPDOABP MNLGCOJCIEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly RenderTexture OKHPBJFFFPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private readonly ImposterRenderConfig FOEOKMAGENA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private readonly CancellationToken OOAGLCBNIOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private GameObject LBHBPKMJGAA;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private ADCACBFKFKM OGODKKJBHAE
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x7092CA0", Offset = "0x70912A0", VA = "0x187092CA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public LEKACFEIBBA<Texture> GNNAGCKPGGG
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7092C50", Offset = "0x7091250", VA = "0x187092C50", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Task IGIPLNCOJED
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x86F1C0", Offset = "0x86D7C0", VA = "0x18086F1C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public Task<Texture> KDFGPGKGOOO
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x86F1C0", Offset = "0x86D7C0", VA = "0x18086F1C0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7092E10", Offset = "0x7091410", VA = "0x187092E10")]
		public ADLKHNPJHHC(DDKILPDOABP MNLGCOJCIEI, RenderTexture OKHPBJFFFPA, ImposterRenderConfig FOEOKMAGENA, CancellationToken OOAGLCBNIOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7092CC0", Offset = "0x70912C0", VA = "0x187092CC0")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(AGNHFKNBJFO))]
		private Task<Texture> IGLOKNLKMNA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7092CB0", Offset = "0x70912B0", VA = "0x187092CB0", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7092BC0", Offset = "0x70911C0", VA = "0x187092BC0")]
		private static void ANIKDNOFIEE(GameObject LBHBPKMJGAA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class IKKCLNAKFND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AsyncVoidMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public ImposterRawImage <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private Texture <initTexture>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private Texture <texture>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private Texture <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Exception <ex>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter<Texture> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public IKKCLNAKFND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x70958C0", Offset = "0x7093EC0", VA = "0x1870958C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	[Header("General")]
	[Tooltip("Texture shown when the imposter texture is not available")]
	private Texture defaultTexture;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[SerializeField]
	[EDMDIOABHOI(ODACEGFBLCL.Self, false, false, false)]
	private RawImage rawImage;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[SerializeField]
	[Header("Imposter Rendering")]
	[Tooltip("Pixel size of the rendered imposter")]
	private FMGMEDDKMCC size;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[SerializeField]
	[ECENODKCJDH("size", 0)]
	[Tooltip("Custom pixel size for rendered imposter")]
	private int customSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[SerializeField]
	private int antiAliasing;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[SerializeField]
	[Tooltip("Configuration specifying render properties for the imposter")]
	private ImposterRenderConfig imposterRenderConfig;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private RenderTexture AOKEDEGIELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private MHHMKEBAHKB<GameObject> OIOEMBHMOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private LABEIOOIHEC HILHDOHILBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private CancellationTokenSource NAANFKJBCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private MPMJDGKIEHM<Texture> BGNJDFFEPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private DDKILPDOABP ECEMHPDKNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private Texture DEJJEMNBPCL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private RenderTexture EELJALGJDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x70984D0", Offset = "0x7096AD0", VA = "0x1870984D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x943F90", Offset = "0x942590", VA = "0x180943F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private DDKILPDOABP CBFGNODIIAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9259D0", Offset = "0x923FD0", VA = "0x1809259D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7098660", Offset = "0x7096C60", VA = "0x187098660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool HHHAILHJADH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x41F08E0", Offset = "0x41EEEE0", VA = "0x1841F08E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private int LHEAJEKNOIC
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7098920", Offset = "0x7096F20", VA = "0x187098920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x70984B0", Offset = "0x7096AB0", VA = "0x1870984B0")]
	protected void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7098930", Offset = "0x7096F30", VA = "0x187098930")]
	protected void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7098890", Offset = "0x7096E90", VA = "0x187098890")]
	private void IMBOPJLPHDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7098C90", Offset = "0x7097290", VA = "0x187098C90")]
	public void Set(DDKILPDOABP GFALHNAAKLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7098C80", Offset = "0x7097280", VA = "0x187098C80")]
	public void Set(Texture HJBKIJHPFFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7098C40", Offset = "0x7097240", VA = "0x187098C40")]
	public void Set(LBODDAIGCEK FEBHELIDNED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x70984C0", Offset = "0x7096AC0", VA = "0x1870984C0")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7098A30", Offset = "0x7097030", VA = "0x187098A30")]
	public void SetInternal(DDKILPDOABP GFALHNAAKLH, [Optional] Texture HMIOOBMDMBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7098A20", Offset = "0x7097020", VA = "0x187098A20")]
	public void SetCustomSize(int GJDHIINPLCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x942C30", Offset = "0x941230", VA = "0x180942C30")]
	public void SetAntiAliasing(int MNCDDIOJCOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x70987B0", Offset = "0x7096DB0", VA = "0x1870987B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IKKCLNAKFND))]
	private void FEODBPEAMIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x70983C0", Offset = "0x70969C0", VA = "0x1870983C0")]
	private void AEKNJIFNIPP(Texture HJBKIJHPFFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7098CA0", Offset = "0x70972A0", VA = "0x187098CA0")]
	public ImposterRawImage()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct HGLHKOKMKNO
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static HGLHKOKMKNO HMCFIOHNGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float FPLCKKFFCHA;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x23ABA20", Offset = "0x23AA020", VA = "0x1823ABA20")]
	public HGLHKOKMKNO(float AMAJLFKODFD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class DeferredImposterSpawnManager : SingletonMonoBehaviour<DeferredImposterSpawnManager>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private readonly struct PNABLLFKINB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly DDKILPDOABP LGDNOGHMEJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly string FAIBFIAJKLN;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xBBF9D0", Offset = "0xBBDFD0", VA = "0x180BBF9D0")]
		public PNABLLFKINB(DDKILPDOABP LHMLEMGFMKI, string ILDBOFKKNIM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class LEJJBPAGIAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public AsyncTaskMethodBuilder<GameObject> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public PNABLLFKINB queuedLoad;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public DeferredImposterSpawnManager <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private DDKILPDOABP <request>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private GameObject <imposter>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private GameObject <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private TaskAwaiter<GameObject> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
		public LEJJBPAGIAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7099220", Offset = "0x7097820", VA = "0x187099220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private IRecRoomQualityConfigProvider JOBGFIHEGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private AOGPKIGEJNN<PNABLLFKINB, GameObject> HPHKOKLOAEI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JJENMBHBEKO ODPLJPNHGIN
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x86F2B0", Offset = "0x86D8B0", VA = "0x18086F2B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x920EA0", Offset = "0x91F4A0", VA = "0x180920EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private AOGPKIGEJNN<PNABLLFKINB, GameObject> CIPPMPKPHLG
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x70942C0", Offset = "0x70928C0", VA = "0x1870942C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private int GPJADFMEDDC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x70945C0", Offset = "0x7092BC0", VA = "0x1870945C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7094210", Offset = "0x7092810", VA = "0x187094210", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x70947E0", Offset = "0x7092DE0", VA = "0x1870947E0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7094420", Offset = "0x7092A20", VA = "0x187094420")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LEJJBPAGIAD))]
	private Task<GameObject> FJECIODLBEC(PNABLLFKINB EEDHKJBEGMC, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7094610", Offset = "0x7092C10", VA = "0x187094610")]
	public Task<GameObject> LoadItemAsync(DDKILPDOABP LHMLEMGFMKI, CancellationToken OOAGLCBNIOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7094850", Offset = "0x7092E50", VA = "0x187094850")]
	public DeferredImposterSpawnManager()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class IncreaseTransparentRenderQueueWhenInUI : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		[EDMDIOABHOI(ODACEGFBLCL.Self, false, false, false)]
		private Renderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const int HAPBLBMBNBA = 2500;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private const int AKLOPIFLMGL = 3500;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private readonly List<Material> DPHMDJLBEMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool FHFPMFMOKOJ;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7098E80", Offset = "0x7097480", VA = "0x187098E80")]
		public void SetIsInUI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7098D90", Offset = "0x7097390", VA = "0x187098D90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x70990D0", Offset = "0x70976D0", VA = "0x1870990D0")]
		public IncreaseTransparentRenderQueueWhenInUI()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface DDKILPDOABP
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	string JCPJOACMKEP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	HGLHKOKMKNO HGLHKOKMKNO
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action KLPGHJHEOKI;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task<GameObject> IGDNMNFINIM(CancellationToken OOAGLCBNIOG);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HMADAENKIEI(DDKILPDOABP EJECOGCICOM);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EHJHKNLKJPP();

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OMGEFNMOGJE();

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool OPOJFPFHPIJ(out MPMJDGKIEHM<Texture> EEAHIAPONMD);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class LEIJFABDCNH
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7099150", Offset = "0x7097750", VA = "0x187099150")]
	public static bool JGMLHKBNFBF(DDKILPDOABP NEGEKOFFBPD, DDKILPDOABP JEFLIELOGEG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CNHKBKOEPKJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	IEnumerable<Type> JPCEKJHPDCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	IEnumerable<Type> HKEJONJEOGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class HideInImposter : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x996120", Offset = "0x994720", VA = "0x180996120")]
		public HideInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface JJENMBHBEKO
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPJHFALPJLP(params Type[] ECOJOMPMEMB);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GOMEPIOIJKE(params Type[] ECOJOMPMEMB);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GameObject JHCMLMAAJNA(GameObject NBHNBEHBBFP, Transform KHJHJOOPMKP, bool CFMKCDPECNE = false);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	T JHCMLMAAJNA<T>(T NBHNBEHBBFP, Transform KHJHJOOPMKP, bool CFMKCDPECNE = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	T JHCMLMAAJNA<T>(GameObject NBHNBEHBBFP, Transform KHJHJOOPMKP, bool CFMKCDPECNE = false) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject JHCMLMAAJNA(GameObject NBHNBEHBBFP, Transform KHJHJOOPMKP, AEAPHDLMPNL CCDJMIJMJKG, bool CFMKCDPECNE);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	T JHCMLMAAJNA<T>(GameObject NBHNBEHBBFP, Transform KHJHJOOPMKP, AEAPHDLMPNL CCDJMIJMJKG, bool CFMKCDPECNE) where T : Component;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	T JHCMLMAAJNA<T>(T NBHNBEHBBFP, Transform KHJHJOOPMKP, AEAPHDLMPNL CCDJMIJMJKG, bool CFMKCDPECNE) where T : Component;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IMLLNBOEFHH
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static readonly List<URPLight> PLPFFEMNNEG;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static readonly Vector3 NKMJONKNDMA;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static readonly Vector3 HIKFPICFCLH;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static Camera PBFKLIHOEED;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public const string LKLHPJGGOOD = "_CAMERA_LIT";

	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public const IMLBINIDKHI FEAGLHGBGAN = IMLBINIDKHI.Water;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private static readonly List<Renderer> PLCCNOOEPLN;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static AmbientMode MMONLAAOONM;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private static Color BGFFHKNMJFF;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static Color ICEBHEJCPGP;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static Color OCNCKGDFOGM;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static Cubemap AGFAKJHKHBJ;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private static bool CKAPIPENDFD;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static Camera IOKIKACLOCI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x70969C0", Offset = "0x7094FC0", VA = "0x1870969C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x70975B0", Offset = "0x7095BB0", VA = "0x1870975B0")]
	public static void JONMCPFMJMA(Vector3 CHFKHMGFKEO, Quaternion CNFBHPLDALF, ImposterRenderConfig ANNLIGBFAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x70972D0", Offset = "0x70958D0", VA = "0x1870972D0")]
	private static void JHHLNJKIDKG(Vector3 CHFKHMGFKEO, Quaternion CNFBHPLDALF, URPLight CAJBFCAPGFL, ImposterRenderConfig.LightConfig GHLIJKJEKHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7097830", Offset = "0x7095E30", VA = "0x187097830")]
	public static void KPPMNKOOPKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7096340", Offset = "0x7094940", VA = "0x187096340")]
	private static void GAODMIOPBAD(int NHGFAPCPMNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7097C20", Offset = "0x7096220", VA = "0x187097C20")]
	public static void NJECEEKENML(ImposterRenderConfig ANNLIGBFAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7096240", Offset = "0x7094840", VA = "0x187096240")]
	public static void FEDDJPBMMFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7096C00", Offset = "0x7095200", VA = "0x187096C00")]
	public static void ICEECCJDOFK(GameObject NOPJBFHGPPL, RenderTexture OKHPBJFFFPA, ImposterRenderConfig ANNLIGBFAAC, HGLHKOKMKNO JLLPHPNILCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7096DD0", Offset = "0x70953D0", VA = "0x187096DD0")]
	private static void JBJKBEPHGKM(GameObject NOPJBFHGPPL, RenderTexture OKHPBJFFFPA, ImposterRenderConfig ANNLIGBFAAC, HGLHKOKMKNO JLLPHPNILCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7096710", Offset = "0x7094D10", VA = "0x187096710")]
	private static void GFFEIOGBLNM(GameObject NOPJBFHGPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x70960A0", Offset = "0x70946A0", VA = "0x1870960A0")]
	public static void BKKGNHJIPBO(List<Renderer> CDHHCDLOBHJ, List<Material> HEILCOOAKIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7097920", Offset = "0x7095F20", VA = "0x187097920")]
	public static void LLFBCDIJCCD(GameObject NBHNBEHBBFP, Vector3 NMAHMKBDIJK, Vector3 KLAEPCFOGBH, float IJHIBFODBHN, HGLHKOKMKNO JLLPHPNILCP, out Vector3 PBIOJOJCIDH, out Quaternion NENCFBLKNPM, out float IPLOILKBMBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7097DA0", Offset = "0x70963A0", VA = "0x187097DA0")]
	public static RenderTexture OAINOCMEAPF(int GMHFIKBCJHC, int DBCMKHOADFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7097E40", Offset = "0x7096440", VA = "0x187097E40")]
	public static void OHBGFDAJPDH()
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class DeferredImposterRenderer : SingletonMonoBehaviour<DeferredImposterRenderer>
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public struct COGMAIBDJIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public MDOIJNHMNCN EBNDDMPLOIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public GameObject HANAIDMBPDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public RenderTexture EELJALGJDJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public ImposterRenderConfig FOKAMNNIHBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public HGLHKOKMKNO HGLHKOKMKNO;

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7093770", Offset = "0x7091D70", VA = "0x187093770")]
			public COGMAIBDJIB(MDOIJNHMNCN GBMBJBEJAAE, GameObject MHDNOJEAPOO, RenderTexture OKHPBJFFFPA, ImposterRenderConfig FOEOKMAGENA, HGLHKOKMKNO JLLPHPNILCP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static AOGPKIGEJNN<COGMAIBDJIB, RenderTexture> AHCFDBAFGNO;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly List<COGMAIBDJIB> CNAIAAIDBMA;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private static int PBNJBNILEBK
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7093D00", Offset = "0x7092300", VA = "0x187093D00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7093E10", Offset = "0x7092410", VA = "0x187093E10")]
		public static Task QueueRenderPreMadeImposterToTexture(GameObject NOPJBFHGPPL, RenderTexture OKHPBJFFFPA, ImposterRenderConfig ANNLIGBFAAC, HGLHKOKMKNO JLLPHPNILCP, CancellationToken OOAGLCBNIOG, bool JCIDIPGGMJK = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7093B10", Offset = "0x7092110", VA = "0x187093B10", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7093D70", Offset = "0x7092370", VA = "0x187093D70", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7093940", Offset = "0x7091F40", VA = "0x187093940")]
		private static Task<RenderTexture> ACJEILELOHL(COGMAIBDJIB PNLBDJLAFND, CancellationToken OOAGLCBNIOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x70941D0", Offset = "0x70927D0", VA = "0x1870941D0")]
		public DeferredImposterRenderer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CreateAssetMenu]
	public class ImposterRenderConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public class LightConfig
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public string name;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			[Header("Location")]
			public Vector3 offsetOrientationEulerAngles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float offsetDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			[Header("Shape")]
			public LightType lightType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float range;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float spotAngle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			[Header("Appearance")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public float intensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public float indirectMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public float specularContribution;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			[Tooltip("Type of shadows cast by this light. Only applies if light type is `Spot` or `Directional`")]
			[Header("Shadows")]
			public LightShadows shadowType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			[Tooltip("Intensity of the shadow cast by this light")]
			public float shadowStrength;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			[Range(0.1f, 10f)]
			[Tooltip("Objects closer than this will not cast shadows (0.1 to 10")]
			public float shadowNearPlane;

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			public bool SupportsShadows
			{
				[Cpp2IlInjected.Token(Token = "0x6000067")]
				[Cpp2IlInjected.Address(RVA = "0x7099650", Offset = "0x7097C50", VA = "0x187099650")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7099630", Offset = "0x7097C30", VA = "0x187099630")]
			public LightConfig()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Header("Composition")]
		public Vector3 cameraOffsetPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector3 cameraOffsetDirection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public float cameraOffsetMinDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float cameraPerspectiveAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[Tooltip("Normalized offset from the center of the mesh's bounds that the camera will target")]
		public Vector3 normalizedCameraTargetOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[ColorUsage(false, true)]
		[Header("Environment Lighting")]
		public Color environmentSkyColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[ColorUsage(false, true)]
		public Color environmentEquatorColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[ColorUsage(false, true)]
		public Color environmentGroundColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Cubemap environmentReflectionProbe;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Header("Direct Lighting")]
		public LightConfig[] lights;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7098D40", Offset = "0x7097340", VA = "0x187098D40")]
		public ImposterRenderConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HOPBFEIGIPN : IDisposable, JJENMBHBEKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly HashSet<Type> FDADFFHNBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private readonly HashSet<Type> EDMJLMMLCMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private Transform AJBNLHCPGCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly List<Component> ELOJPODGIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly List<IncreaseTransparentRenderQueueWhenInUI> PPNDGGJABIF;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7094DD0", Offset = "0x70933D0", VA = "0x187094DD0")]
	[PJEDGFFEDPC(PDIHHCLCNFI.None)]
	public static void NLFBANBIGIE(EIHIACACEHJ GEAGAOEEJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7095480", Offset = "0x7093A80", VA = "0x187095480")]
	[Preserve]
	public HOPBFEIGIPN([NALHKAIJJND(null)] CNHKBKOEPKJ DFMHANGOMHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x70948D0", Offset = "0x7092ED0", VA = "0x1870948D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7094EC0", Offset = "0x70934C0", VA = "0x187094EC0", Slot = "5")]
	public void NPJHFALPJLP(params Type[] ECOJOMPMEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x70949D0", Offset = "0x7092FD0", VA = "0x1870949D0", Slot = "6")]
	public void GOMEPIOIJKE(params Type[] ECOJOMPMEMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7094B50", Offset = "0x7093150", VA = "0x187094B50", Slot = "7")]
	public GameObject JHCMLMAAJNA(GameObject NBHNBEHBBFP, Transform KHJHJOOPMKP, bool CFMKCDPECNE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x200D0F0", Offset = "0x200B6F0", VA = "0x18200D0F0", Slot = "8")]
	public T JHCMLMAAJNA<T>(T NBHNBEHBBFP, Transform KHJHJOOPMKP, bool CFMKCDPECNE = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x200D0C0", Offset = "0x200B6C0", VA = "0x18200D0C0", Slot = "9")]
	public T JHCMLMAAJNA<T>(GameObject NBHNBEHBBFP, Transform KHJHJOOPMKP, bool CFMKCDPECNE = false) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7094BE0", Offset = "0x70931E0", VA = "0x187094BE0", Slot = "10")]
	public GameObject JHCMLMAAJNA(GameObject NBHNBEHBBFP, Transform KHJHJOOPMKP, AEAPHDLMPNL CCDJMIJMJKG, bool CFMKCDPECNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x200CA80", Offset = "0x200B080", VA = "0x18200CA80", Slot = "11")]
	public T JHCMLMAAJNA<T>(GameObject NBHNBEHBBFP, Transform KHJHJOOPMKP, AEAPHDLMPNL CCDJMIJMJKG, bool CFMKCDPECNE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x200D030", Offset = "0x200B630", VA = "0x18200D030", Slot = "12")]
	public T JHCMLMAAJNA<T>(T NBHNBEHBBFP, Transform KHJHJOOPMKP, AEAPHDLMPNL CCDJMIJMJKG, bool CFMKCDPECNE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x200CAD0", Offset = "0x200B0D0", VA = "0x18200CAD0")]
	private T JHCMLMAAJNA<T>(GameObject NBHNBEHBBFP, Transform KHJHJOOPMKP, AEAPHDLMPNL CCDJMIJMJKG, bool CFMKCDPECNE, out GameObject PBGIMCGFLAH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x200C440", Offset = "0x200AA40", VA = "0x18200C440")]
	private T ADKNHIHFLGF<T>(GameObject CGLKMGEDNPH, AEAPHDLMPNL CCDJMIJMJKG, bool CFMKCDPECNE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7094A20", Offset = "0x7093020", VA = "0x187094A20")]
	private void JEHMMPFPJCF(Component AEKHFLGBLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7094F10", Offset = "0x7093510", VA = "0x187094F10")]
	private void OJMMGFFIBGG(Component AEKHFLGBLPB, AEAPHDLMPNL CCDJMIJMJKG, bool CFMKCDPECNE, bool LCEFNJPEJFG, [Optional] Type JEDCEKGGJOD, [Optional] Type OAEMGBEHCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7094C70", Offset = "0x7093270", VA = "0x187094C70")]
	private void MMDGBCCHGGD(GameObject CGLKMGEDNPH)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class CenterInImposter : MonoBehaviour, CJIGMJEEGGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private GameObject rootObject;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x70937E0", Offset = "0x7091DE0", VA = "0x1870937E0", Slot = "4")]
		public void PrepareImposter(AEAPHDLMPNL CCDJMIJMJKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x996120", Offset = "0x994720", VA = "0x180996120")]
		public CenterInImposter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class KeepImposterUpright : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x996120", Offset = "0x994720", VA = "0x180996120")]
		public KeepImposterUpright()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct AEAPHDLMPNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private Dictionary<Type, object> AKIAJNDKCOL;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x101C8D0", Offset = "0x101AED0", VA = "0x18101C8D0")]
	public AEAPHDLMPNL PCICHOODFHC<T>(T KHMBOCLPFCI)
	{
		return default(AEAPHDLMPNL);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x101D000", Offset = "0x101B600", VA = "0x18101D000")]
	public T PIDCPOPDLLJ<T>(T LLDPFOJMFMC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x101C0D0", Offset = "0x101A6D0", VA = "0x18101C0D0")]
	public bool HNEMDLLFNLP<T>(out T KHMBOCLPFCI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct KLKLCDPPAKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public bool KFDMAMAINIJ;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xBEC150", Offset = "0xBEA750", VA = "0x180BEC150")]
	public KLKLCDPPAKA(bool LJMBCBCGNPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct NFENCDGODIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public readonly bool CKJNJOPNPBE;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7099670", Offset = "0x7097C70", VA = "0x187099670")]
	public NFENCDGODIC(bool DGGFNIKEINC)
	{
	}
}
namespace RecRoom.Core.Imposters
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class ScaleInImposter : MonoBehaviour, CJIGMJEEGGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private Vector3 scale;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x7099680", Offset = "0x7097C80", VA = "0x187099680", Slot = "4")]
		public void PrepareImposter(AEAPHDLMPNL CCDJMIJMJKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x996120", Offset = "0x994720", VA = "0x180996120")]
		public ScaleInImposter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface CJIGMJEEGGL
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PrepareImposter(AEAPHDLMPNL CCDJMIJMJKG);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class IMLHFCPJGKL
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x86EF10", Offset = "0x86D510", VA = "0x18086EF10")]
	public IMLHFCPJGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD111C0", VA = "0x180D12BC0")]
	public static string GOMDFOEHABF(byte[] CEBGDHINIFO, byte[] FGJCLMKLDKK)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
