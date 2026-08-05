using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.ClusterLODs;
using RecRoom.Configs;
using RecRoom.Core.Creation.Shapes;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation.Mathematics;
using RecRoom.Logging.Attributes;
using RecRoom.ShapeRendering;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_ShapeRendering_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : KHEEPBINELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8905700", Offset = "0x8904300", VA = "0x188905700", Slot = "4")]
		public override void KHPGHNAFBFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ShapeRendering_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[RecRoom.DataLayer.Attributes.Preserve]
	[CompilerGenerated]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890AD60", Offset = "0x8909960", VA = "0x18890AD60", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x27CE7F0", Offset = "0x27CD3F0", VA = "0x1827CE7F0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BDKCBIIPGGF : FJBLKNENKNG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte OAFOIONFALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] BMBLCPJHPNK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DIHKJMBIGEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA768B0", Offset = "0xA754B0", VA = "0x180A768B0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA76890", Offset = "0xA75490", VA = "0x180A76890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int OMMKLGLGEHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xBDFF80", Offset = "0xBDEB80", VA = "0x180BDFF80", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xF7D730", Offset = "0xF7C330", VA = "0x180F7D730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float EFALLPCHEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xF23850", Offset = "0xF22450", VA = "0x180F23850", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1425D80", Offset = "0x1424980", VA = "0x181425D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float BOBGKMMIEID
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCF8730", Offset = "0xCF7330", VA = "0x180CF8730", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xCF8740", Offset = "0xCF7340", VA = "0x180CF8740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> OHJIBPNPCJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x88F9A40", Offset = "0x88F8640", VA = "0x1888F9A40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> EJBBGJBKDIG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x88F9A90", Offset = "0x88F8690", VA = "0x1888F9A90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject MMGGJKMBNAC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA21F10", Offset = "0xA20B10", VA = "0x180A21F10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA217E0", Offset = "0xA203E0", VA = "0x180A217E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte FFLOPLKALAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x88F99F0", Offset = "0x88F85F0", VA = "0x1888F99F0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x88F9D40", Offset = "0x88F8940", VA = "0x1888F9D40")]
	public BDKCBIIPGGF(List<GBNPLAAEKHD> OEFNJJCHFNA, List<GBNPLAAEKHD> EIDGIBLBBLJ, List<LNFJEBGBMKD> AJDCHCNBIKJ, Material IMKAMKEPJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x88F9AC0", Offset = "0x88F86C0", VA = "0x1888F9AC0")]
	private int OEEGLDJIMLF(List<GBNPLAAEKHD> FCGKFOHAJFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x88F9BE0", Offset = "0x88F87E0", VA = "0x1888F9BE0")]
	private void PNBHDLLPCMG(int LKNMGAIMHBP, bool AENDFIMJKFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x88F9760", Offset = "0x88F8360", VA = "0x1888F9760")]
	public void BFMHNGPNHNB(Vector3 HEKKEJMBPPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x88F98F0", Offset = "0x88F84F0", VA = "0x1888F98F0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x88F98B0", Offset = "0x88F84B0", VA = "0x1888F98B0")]
	public void DENOOAPOKLL(Transform EGPHEIONJLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IEOPPNLCFAO : LOFJNALBJNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class GMHBNMNONMJ : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public IEOPPNLCFAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private List<ClusterMeshRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private IEnumerator<Renderer> <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private IEnumerator<MeshRenderer> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xF21C60", Offset = "0xF20860", VA = "0x180F21C60")]
		[DebuggerHidden]
		public GMHBNMNONMJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8900430", Offset = "0x88FF030", VA = "0x188900430", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x88FFE20", Offset = "0x88FEA20", VA = "0x1888FFE20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x88FFD30", Offset = "0x88FE930", VA = "0x1888FFD30")]
		private void HOIHHFKDFKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x88FFDD0", Offset = "0x88FE9D0", VA = "0x1888FFDD0")]
		private void JKFKJAKKDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x88FFD80", Offset = "0x88FE980", VA = "0x1888FFD80")]
		private void IIELIPNJMBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x89003E0", Offset = "0x88FEFE0", VA = "0x1889003E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8900330", Offset = "0x88FEF30", VA = "0x188900330", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8900330", Offset = "0x88FEF30", VA = "0x188900330", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class MBNOCEHPIFF : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public IEOPPNLCFAO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IEnumerator<Renderer> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xF21C60", Offset = "0xF20860", VA = "0x180F21C60")]
		[DebuggerHidden]
		public MBNOCEHPIFF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8905CE0", Offset = "0x89048E0", VA = "0x188905CE0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8905870", Offset = "0x8904470", VA = "0x188905870", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x89057D0", Offset = "0x89043D0", VA = "0x1889057D0")]
		private void HOIHHFKDFKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8905820", Offset = "0x8904420", VA = "0x188905820")]
		private void JKFKJAKKDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8905C90", Offset = "0x8904890", VA = "0x188905C90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8905BE0", Offset = "0x89047E0", VA = "0x188905BE0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8905BE0", Offset = "0x89047E0", VA = "0x188905BE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly PLLHHFOOEOI GJNNPOIHKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<BPAKCCFAFEE> LMIKJLDMIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> HKOBEEGKAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer EDMGMEIKAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool EKJLHBFNIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool NAAICJKCEOF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<ENGBCAMGFNJ> CHKLKLKIOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int KDAANAJNIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8900F20", Offset = "0x88FFB20", VA = "0x188900F20", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LNFJEBGBMKD POBOMJKEGFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x89021E0", Offset = "0x8900DE0", VA = "0x1889021E0", Slot = "8")]
		get
		{
			return default(LNFJEBGBMKD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> ABDGMLEFJJE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA24650", Offset = "0xA23250", VA = "0x180A24650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA24690", Offset = "0xA23290", VA = "0x180A24690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x89021C0", Offset = "0x8900DC0", VA = "0x1889021C0")]
	private bool OLJMPAAFAJN(BPAKCCFAFEE DAAJJNMMALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8901A20", Offset = "0x8900620", VA = "0x188901A20")]
	private static bool MDOELMBDGJK(BPAKCCFAFEE DAAJJNMMALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8902400", Offset = "0x8901000", VA = "0x188902400")]
	public IEOPPNLCFAO(PLLHHFOOEOI PEDMEJIDLNB, bool BHCBOEMNJGO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8901060", Offset = "0x88FFC60", VA = "0x188901060", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8901CB0", Offset = "0x89008B0", VA = "0x188901CB0")]
	public void NKAMMCABBBC(BPAKCCFAFEE DAAJJNMMALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8901310", Offset = "0x88FFF10", VA = "0x188901310")]
	public void HMCNGGMNMHK(BPAKCCFAFEE DAAJJNMMALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8900A20", Offset = "0x88FF620", VA = "0x188900A20", Slot = "4")]
	public void AEPCOKJKHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8901A40", Offset = "0x8900640", VA = "0x188901A40")]
	public void NJCBLGMIGNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8902000", Offset = "0x8900C00", VA = "0x188902000")]
	private void OFIFPCDOFDM(List<BPAKCCFAFEE> LMIKJLDMIHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8901EF0", Offset = "0x8900AF0", VA = "0x188901EF0")]
	private static Material NNHFCEEGBGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8901F50", Offset = "0x8900B50", VA = "0x188901F50")]
	private void OFIFPCDOFDM(BPAKCCFAFEE DAAJJNMMALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x8902330", Offset = "0x8900F30", VA = "0x188902330")]
	private void PNBCHCHDENO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8901470", Offset = "0x8900070", VA = "0x188901470")]
	public void JHADBDBAIEC(bool MDJIFOLGECM, bool IKFPKOKHEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8901250", Offset = "0x88FFE50", VA = "0x188901250")]
	protected void ENINKBADDCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x89022B0", Offset = "0x8900EB0", VA = "0x1889022B0")]
	public void PIGMDAFMODO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8900FE0", Offset = "0x88FFBE0", VA = "0x188900FE0")]
	[IteratorStateMachine(typeof(GMHBNMNONMJ))]
	public IEnumerable<Renderer> DOBIDMFOOEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8900F60", Offset = "0x88FFB60", VA = "0x188900F60")]
	[IteratorStateMachine(typeof(MBNOCEHPIFF))]
	public IEnumerable<Renderer> CFFEBPEPIOH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class LLONHHFFAPB : BPAKCCFAFEE
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct AOLDNGGENIB : OJJGDKPFBLD, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private OKLIIGFAOMH BFDKALDCPEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle DJIBHNIMKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private MEELADGBCDF HHHGCMEFEDJ;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x88F7260", Offset = "0x88F5E60", VA = "0x1888F7260")]
		public AOLDNGGENIB(OKLIIGFAOMH BFDKALDCPEN, JobHandle DJIBHNIMKKB, MEELADGBCDF HHHGCMEFEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x88F7230", Offset = "0x88F5E30", VA = "0x1888F7230", Slot = "4")]
		public OKLIIGFAOMH JLDGPNOKBIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x88F71E0", Offset = "0x88F5DE0", VA = "0x1888F71E0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly BKJBENJIBKG IEKBCEHOONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float HMMDMGIPNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 GPPBCOJOIGI;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 PFPNLGJJNBH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8905520", Offset = "0x8904120", VA = "0x188905520", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8905650", Offset = "0x8904250", VA = "0x188905650")]
	public LLONHHFFAPB(IEOPPNLCFAO HMGDINOCJAI, BKJBENJIBKG PEDMEJIDLNB, bool BHCBOEMNJGO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "18")]
	public override bool EAKCBGBNPEF(LNFJEBGBMKD HMGDINOCJAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x8905350", Offset = "0x8903F50", VA = "0x188905350", Slot = "19")]
	public override int OEEGLDJIMLF(CNFDLJNNJAL FEJALILJGHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x89046B0", Offset = "0x89032B0", VA = "0x1889046B0", Slot = "20")]
	public override int CPNEDFPJMEM(CNFDLJNNJAL FEJALILJGHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x8904F30", Offset = "0x8903B30", VA = "0x188904F30", Slot = "21")]
	public override AGIDILLGDFN HEAGJJHEABK()
	{
		return default(AGIDILLGDFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xBDFF60", Offset = "0xBDEB60", VA = "0x180BDFF60", Slot = "22")]
	public override float JNDEOBNJPCA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x8904950", Offset = "0x8903550", VA = "0x188904950", Slot = "23")]
	public override void HDIPHKFNAIG(CNFDLJNNJAL FEJALILJGHL, FIAIMIEBBMJ DLDAFAMDNJN, int DLPFMAPHOKP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x8904880", Offset = "0x8903480", VA = "0x188904880", Slot = "24")]
	public override LNFJEBGBMKD DANAIHCBOCN()
	{
		return default(LNFJEBGBMKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x8903D30", Offset = "0x8902930", VA = "0x188903D30", Slot = "26")]
	public override ODOLHPKOKHA ADLIMNLFOGK()
	{
		return default(ODOLHPKOKHA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x8903EE0", Offset = "0x8902AE0", VA = "0x188903EE0", Slot = "27")]
	public override OJJGDKPFBLD CFAJDIOELOM(CNFDLJNNJAL FEJALILJGHL, JobHandle DJIBHNIMKKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public interface HDPCLFCBCPA
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	IEOPPNLCFAO HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	BPAKCCFAFEE HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	LCELBDBACOO HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class MDMDJDNLMGP : MEFOENIIPMB, IDisposable, HDPCLFCBCPA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct MEGNHHAIEBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public MDMDJDNLMGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x89083E0", Offset = "0x8906FE0", VA = "0x1889083E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8908940", Offset = "0x8907540", VA = "0x188908940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly DGNDEINJLGE<EEHGLNGJALI, IEOPPNLCFAO> MALILLMFKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly DGNDEINJLGE<PLBHNIEEDEN, BPAKCCFAFEE> LMIKJLDMIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly DGNDEINJLGE<FDKEBGOKFEA, LCELBDBACOO> AJPKLHJJEND;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public IEOPPNLCFAO HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8907680", Offset = "0x8906280", VA = "0x188907680", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public BPAKCCFAFEE HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x89076E0", Offset = "0x89062E0", VA = "0x1889076E0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public LCELBDBACOO HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8907740", Offset = "0x8906340", VA = "0x188907740", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool FAEMLNNJBBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xBDFF70", Offset = "0xBDEB70", VA = "0x180BDFF70", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xB3BA30", Offset = "0xB3A630", VA = "0x180B3BA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x8907F60", Offset = "0x8906B60", VA = "0x188907F60")]
	public MDMDJDNLMGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x8906C00", Offset = "0x8905800", VA = "0x188906C00", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x8906DC0", Offset = "0x89059C0", VA = "0x188906DC0", Slot = "4")]
	public EEHGLNGJALI ELCHGMLJKIA(PLLHHFOOEOI PEDMEJIDLNB)
	{
		return default(EEHGLNGJALI);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x8906DD0", Offset = "0x89059D0", VA = "0x188906DD0", Slot = "5")]
	public EEHGLNGJALI ELCHGMLJKIA(PLLHHFOOEOI PEDMEJIDLNB, bool BHCBOEMNJGO)
	{
		return default(EEHGLNGJALI);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8907D10", Offset = "0x8906910", VA = "0x188907D10", Slot = "6")]
	public void PMPMKFBKBDP(EEHGLNGJALI HMGDINOCJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x8907190", Offset = "0x8905D90", VA = "0x188907190", Slot = "7")]
	public void HGJECIIJCBG(EEHGLNGJALI HMGDINOCJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x8906210", Offset = "0x8904E10", VA = "0x188906210", Slot = "8")]
	public PLBHNIEEDEN BCCNHNEJPAO(EEHGLNGJALI HMGDINOCJAI, FLIFFCNMJBP PEDMEJIDLNB)
	{
		return default(PLBHNIEEDEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8906740", Offset = "0x8905340", VA = "0x188906740", Slot = "9")]
	public PLBHNIEEDEN DLPCKAECPEI(EEHGLNGJALI HMGDINOCJAI, BKJBENJIBKG PEDMEJIDLNB)
	{
		return default(PLBHNIEEDEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8905E10", Offset = "0x8904A10", VA = "0x188905E10", Slot = "11")]
	public void AAGENEJBIAL(PLBHNIEEDEN DAAJJNMMALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8907960", Offset = "0x8906560", VA = "0x188907960", Slot = "10")]
	public void IOJINMAMACM(PLBHNIEEDEN DAAJJNMMALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x89066D0", Offset = "0x89052D0", VA = "0x1889066D0", Slot = "20")]
	public IEnumerable<Renderer> CDOIFOFFJHG(EEHGLNGJALI HMGDINOCJAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8907110", Offset = "0x8905D10", VA = "0x188907110", Slot = "12")]
	public FDKEBGOKFEA GJHAEJOBDAK(JMKGEOALEPB PEDMEJIDLNB)
	{
		return default(FDKEBGOKFEA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8907BB0", Offset = "0x89067B0", VA = "0x188907BB0", Slot = "14")]
	public void KKODIHKGODL(FDKEBGOKFEA ALGOPHJEAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x89077A0", Offset = "0x89063A0", VA = "0x1889077A0", Slot = "16")]
	public Task ILGKOHFNCHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x89074D0", Offset = "0x89060D0", VA = "0x1889074D0", Slot = "17")]
	public Task HJIKLLFIBAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8907040", Offset = "0x8905C40", VA = "0x188907040", Slot = "18")]
	[AsyncStateMachine(typeof(MEGNHHAIEBE))]
	public Task GEJKCMMBNDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8907C20", Offset = "0x8906820", VA = "0x188907C20", Slot = "19")]
	public void LHGKCPEDNCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x89061B0", Offset = "0x8904DB0", VA = "0x1889061B0", Slot = "13")]
	public void AKDHODBJMFL(FDKEBGOKFEA ALGOPHJEAMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class AONECCDJIFG : BPAKCCFAFEE
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct GKIFBGODDOE : OJJGDKPFBLD, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private OKLIIGFAOMH BFDKALDCPEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeArray<int> JLGABHMLDHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JobHandle DJIBHNIMKKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private OLPOABKOAHA HHHGCMEFEDJ;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x88FFCD0", Offset = "0x88FE8D0", VA = "0x1888FFCD0")]
		public GKIFBGODDOE(OKLIIGFAOMH BFDKALDCPEN, NativeArray<int> JLGABHMLDHK, JobHandle DJIBHNIMKKB, OLPOABKOAHA HHHGCMEFEDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x88FFC70", Offset = "0x88FE870", VA = "0x1888FFC70", Slot = "4")]
		public OKLIIGFAOMH JLDGPNOKBIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x88FFBD0", Offset = "0x88FE7D0", VA = "0x1888FFBD0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly FLIFFCNMJBP PBCJADGOGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] FFDMAAKOGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 GPPBCOJOIGI;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 LABKLJIABNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x88F7C40", Offset = "0x88F6840", VA = "0x1888F7C40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 PFPNLGJJNBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x88F9580", Offset = "0x88F8180", VA = "0x1888F9580", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x88F96B0", Offset = "0x88F82B0", VA = "0x1888F96B0")]
	public AONECCDJIFG(IEOPPNLCFAO HMGDINOCJAI, FLIFFCNMJBP PEDMEJIDLNB, bool ELOBDPJPEEI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x88F7FF0", Offset = "0x88F6BF0", VA = "0x1888F7FF0", Slot = "18")]
	public override bool EAKCBGBNPEF(LNFJEBGBMKD HMGDINOCJAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x88F8910", Offset = "0x88F7510", VA = "0x1888F8910", Slot = "21")]
	public override AGIDILLGDFN HEAGJJHEABK()
	{
		return default(AGIDILLGDFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x88F8950", Offset = "0x88F7550", VA = "0x1888F8950")]
	private AGIDILLGDFN HEAGJJHEABK(LNFJEBGBMKD HMGDINOCJAI)
	{
		return default(AGIDILLGDFN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x88F92D0", Offset = "0x88F7ED0", VA = "0x1888F92D0")]
	private MOPHBHNAHLA KHOHFBMFDIL([In] UniformTRS OGEAAGCFPGJ, [In] float3 CDHHINPIGMF)
	{
		return default(MOPHBHNAHLA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x88F94D0", Offset = "0x88F80D0", VA = "0x1888F94D0", Slot = "19")]
	public override int OEEGLDJIMLF(CNFDLJNNJAL FEJALILJGHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x88F7E70", Offset = "0x88F6A70", VA = "0x1888F7E70", Slot = "20")]
	public override int CPNEDFPJMEM(CNFDLJNNJAL FEJALILJGHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x88F91E0", Offset = "0x88F7DE0", VA = "0x1888F91E0", Slot = "22")]
	public override float JNDEOBNJPCA()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x88F8F60", Offset = "0x88F7B60", VA = "0x1888F8F60")]
	private int IBFHFEEPBMB(CNFDLJNNJAL FEJALILJGHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x88F80C0", Offset = "0x88F6CC0", VA = "0x1888F80C0", Slot = "23")]
	public override void HDIPHKFNAIG(CNFDLJNNJAL FEJALILJGHL, FIAIMIEBBMJ DLDAFAMDNJN, int DLPFMAPHOKP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x88F7F20", Offset = "0x88F6B20", VA = "0x1888F7F20", Slot = "24")]
	public override LNFJEBGBMKD DANAIHCBOCN()
	{
		return default(LNFJEBGBMKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x88F72C0", Offset = "0x88F5EC0", VA = "0x1888F72C0", Slot = "26")]
	public override ODOLHPKOKHA ADLIMNLFOGK()
	{
		return default(ODOLHPKOKHA);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x88F7470", Offset = "0x88F6070", VA = "0x1888F7470", Slot = "27")]
	public override OJJGDKPFBLD CFAJDIOELOM(CNFDLJNNJAL FEJALILJGHL, JobHandle DJIBHNIMKKB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ONIFPIMJMBA
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IHKGHOPJKON(JOMANKOGPON OPOPAMPKKGD, Renderer GJIEBJCNJLG, int CDDPFBMNKGJ);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AAOLCANIMMI(Renderer GJIEBJCNJLG, JDCOBKHFBGG JGEAKKMMJAI, Vector3 OFJNCJJBDIF, Vector3 JKNKAKBDBIK, Vector3 LGGFMHCJENO, float KEBLHPJHFCI, float GLCMHLOEKHJ, float AMJOKGIFMLC = -1f, [Optional] Color? GCKOLKABAJC, [Optional] IReadOnlyList<Camera> KHIEAOMBCBM);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KJIKBBFHJJB(Renderer GJIEBJCNJLG, int CDDPFBMNKGJ);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int BDNAAGAEPGB();

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ICHJHFJNPPA(int GGPHEIGEPAI, AGAICHLALAG OPOPAMPKKGD, Renderer GJIEBJCNJLG, int CDDPFBMNKGJ);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FMJDFNEDKMI : FOCKMLOJPND, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class NGJNKBDNGGM : GMJODGJPEMH<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x89089A0", Offset = "0x89075A0", VA = "0x1889089A0")]
		public NGJNKBDNGGM(string LAOCJKNALFF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly ONIFPIMJMBA LCDAEGABLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly HDPCLFCBCPA GMOAOFPHJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer HIOALPHMNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private NGJNKBDNGGM LDCLFPJNIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool FILGHGJCDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MeshRenderer NGPPLFCMCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private NGJNKBDNGGM HOBHFNLNOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool HMGFPOAPFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MeshRenderer PCMCGCCOGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private NGJNKBDNGGM HCCALJHAFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool JMHDHAMCODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool HPDIEOLMMOM;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xA20DD0", Offset = "0xA1F9D0", VA = "0x180A20DD0")]
	public FMJDFNEDKMI(ONIFPIMJMBA JKMNDIFKIHJ, HDPCLFCBCPA GMOAOFPHJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x88FD2B0", Offset = "0x88FBEB0", VA = "0x1888FD2B0", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x88FE090", Offset = "0x88FCC90", VA = "0x1888FE090")]
	private void KCIIIKJKIJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x88FD530", Offset = "0x88FC130", VA = "0x1888FD530", Slot = "4")]
	public void GJFNAFLEGBM(EEHGLNGJALI HMGDINOCJAI, AGAICHLALAG FPDMHGECAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x88FD840", Offset = "0x88FC440", VA = "0x1888FD840", Slot = "5")]
	public void GJFNAFLEGBM(PLBHNIEEDEN DAAJJNMMALF, AGAICHLALAG FPDMHGECAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x88FDF30", Offset = "0x88FCB30", VA = "0x1888FDF30", Slot = "6")]
	public void JIJGNKEKPEK(PLBHNIEEDEN DAAJJNMMALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x88FCEF0", Offset = "0x88FBAF0", VA = "0x1888FCEF0", Slot = "7")]
	public void CNCJOFHOMNI(PLBHNIEEDEN DAAJJNMMALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x88FBF40", Offset = "0x88FAB40", VA = "0x1888FBF40", Slot = "24")]
	public void AIIOKEOIALO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x113BF00", Offset = "0x113AB00", VA = "0x18113BF00", Slot = "8")]
	public void JKICPAJNOIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x88FE300", Offset = "0x88FCF00", VA = "0x1888FE300", Slot = "9")]
	public void KEPDCOKDHJN(AGAICHLALAG FPDMHGECAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x88FCC20", Offset = "0x88FB820", VA = "0x1888FCC20", Slot = "10")]
	public void CMDCEEPDKIB(EEHGLNGJALI HMGDINOCJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x88FC8C0", Offset = "0x88FB4C0", VA = "0x1888FC8C0", Slot = "11")]
	public void CMDCEEPDKIB(PLBHNIEEDEN DAAJJNMMALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x88FDA60", Offset = "0x88FC660", VA = "0x1888FDA60", Slot = "12")]
	public void HHLBMGDJALJ(PLBHNIEEDEN DAAJJNMMALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x88FD460", Offset = "0x88FC060", VA = "0x1888FD460", Slot = "13")]
	public void GGHPLAKACLJ(PLBHNIEEDEN DAAJJNMMALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x88FE540", Offset = "0x88FD140", VA = "0x1888FE540")]
	private void NFALBLEDFDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x145C020", Offset = "0x145AC20", VA = "0x18145C020", Slot = "14")]
	public void OIODOMMNACN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x88FDB30", Offset = "0x88FC730", VA = "0x1888FDB30", Slot = "15")]
	public void IONLCJNPICL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x88FDC50", Offset = "0x88FC850", VA = "0x1888FDC50", Slot = "16")]
	public void JGCLAIBBMGC(EEHGLNGJALI HMGDINOCJAI, JOMANKOGPON OPOPAMPKKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x88FE470", Offset = "0x88FD070", VA = "0x1888FE470", Slot = "17")]
	public void MMHCAICBNGM(PLBHNIEEDEN DAAJJNMMALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x88FC7F0", Offset = "0x88FB3F0", VA = "0x1888FC7F0", Slot = "18")]
	public void BOCMDMEELHL(PLBHNIEEDEN DAAJJNMMALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38A50", VA = "0x180D39E50", Slot = "19")]
	public void IMDFPKBOKGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x88FE7B0", Offset = "0x88FD3B0", VA = "0x1888FE7B0", Slot = "20")]
	public void PMHDIHENKBI(JOMANKOGPON OPOPAMPKKGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x88FD040", Offset = "0x88FBC40", VA = "0x1888FD040")]
	private void DPKILJJHFLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x88FC420", Offset = "0x88FB020", VA = "0x1888FC420", Slot = "21")]
	public void BGGFPGDIENP(EEHGLNGJALI HMGDINOCJAI, Vector3 OFJNCJJBDIF, Vector3 JKNKAKBDBIK, Vector3 LGGFMHCJENO, float KEBLHPJHFCI, float GLCMHLOEKHJ, IReadOnlyList<Camera> OPNNKODCLCD, JDCOBKHFBGG JGEAKKMMJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x88FBF80", Offset = "0x88FAB80", VA = "0x1888FBF80", Slot = "22")]
	public void BGGFPGDIENP(FDKEBGOKFEA ALGOPHJEAMD, Vector3 OFJNCJJBDIF, Vector3 JKNKAKBDBIK, Vector3 LGGFMHCJENO, float KEBLHPJHFCI, float GLCMHLOEKHJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class BPAKCCFAFEE : APPIDMACBHN, ENGBCAMGFNJ, GJECIOKLOHA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly IEOPPNLCFAO MMGGJKMBNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int LPCJLBHJPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds MBBOELGADJM;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds KALBCKDIGHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x88FA050", Offset = "0x88F8C50", VA = "0x1888FA050", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool NAAICJKCEOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xE0E830", Offset = "0xE0D430", VA = "0x180E0E830")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xE0E540", Offset = "0xE0D140", VA = "0x180E0E540")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 PFPNLGJJNBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int IGFMLGDNBOO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA7BBF0", Offset = "0xA7A7F0", VA = "0x180A7BBF0", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public EOINJNMAHPP JLOGGKFEJEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA24650", Offset = "0xA23250", VA = "0x180A24650")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA24690", Offset = "0xA23290", VA = "0x180A24690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool MHGFEGIJOJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xF63570", Offset = "0xF62170", VA = "0x180F63570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0xA2B6C0", Offset = "0xA2A2C0", VA = "0x180A2B6C0")]
	protected BPAKCCFAFEE(IEOPPNLCFAO HMGDINOCJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x88FA070", Offset = "0x88F8C70", VA = "0x1888FA070", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0", Slot = "18")]
	public virtual bool EAKCBGBNPEF(LNFJEBGBMKD HMGDINOCJAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x88FA200", Offset = "0x88F8E00", VA = "0x1888FA200", Slot = "10")]
	public int GBLBMNPECPM(int JGOEAMMHFGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int OEEGLDJIMLF(CNFDLJNNJAL FEJALILJGHL);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int CPNEDFPJMEM(CNFDLJNNJAL FEJALILJGHL);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract AGIDILLGDFN HEAGJJHEABK();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float JNDEOBNJPCA();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void HDIPHKFNAIG(CNFDLJNNJAL FEJALILJGHL, FIAIMIEBBMJ DLDAFAMDNJN, int DLPFMAPHOKP = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract LNFJEBGBMKD DANAIHCBOCN();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x88FA210", Offset = "0x88F8E10", VA = "0x1888FA210", Slot = "13")]
	public Hash128 KNIBOKHELAP(int FEJALILJGHL)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract ODOLHPKOKHA ADLIMNLFOGK();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract OJJGDKPFBLD CFAJDIOELOM(CNFDLJNNJAL FEJALILJGHL, JobHandle DJIBHNIMKKB);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x88FA1D0", Offset = "0x88F8DD0", VA = "0x1888FA1D0", Slot = "12")]
	public OJJGDKPFBLD EJHALFIEKDM(int FEJALILJGHL)
	{
		return null;
	}
}
namespace RecRoom.ShapeRendering
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class ShapeRendererConfig : SingletonScriptableObject<ShapeRendererConfig>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8909870", Offset = "0x8908470", VA = "0x188909870")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class CBGHHOOEGJK
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class AIHLJNDAKJM : IEnumerable<LBJLEMIJBCP>, IEnumerable, IEnumerator<LBJLEMIJBCP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private LBJLEMIJBCP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private int <p>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private int <l>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private LBJLEMIJBCP System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xF21C60", Offset = "0xF20860", VA = "0x180F21C60")]
		[DebuggerHidden]
		public AIHLJNDAKJM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x88F7020", Offset = "0x88F5C20", VA = "0x1888F7020", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x88F7190", Offset = "0x88F5D90", VA = "0x1888F7190", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x88F70F0", Offset = "0x88F5CF0", VA = "0x1888F70F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<LBJLEMIJBCP> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x88F70F0", Offset = "0x88F5CF0", VA = "0x1888F70F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static LBJLEMIJBCP[][] MNLFIDPOINB;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static OAPCHDEMGOK GAMFGPKAEID;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static ShapeRendererConfig LBJHLAJNNHO;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader HBJJHPDHMKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x88FB290", Offset = "0x88F9E90", VA = "0x1888FB290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer HEGCDCHIAPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x88FBA20", Offset = "0x88FA620", VA = "0x1888FBA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x88FB940", Offset = "0x88FA540", VA = "0x1888FB940")]
	[JPDFIGCCABC]
	internal static void LEIJOMGLGOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x88FB040", Offset = "0x88F9C40", VA = "0x1888FB040")]
	public static Mesh FKHIHEGALGM(KPFEPBPCGON FKAGADIENDA, int FEJALILJGHL = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x88FB730", Offset = "0x88FA330", VA = "0x1888FB730")]
	public static int JFBOADNNDGG(KPFEPBPCGON FKAGADIENDA, int FEJALILJGHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x88FB740", Offset = "0x88FA340", VA = "0x1888FB740")]
	public static OAPCHDEMGOK JFELLKALMOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x88FB2F0", Offset = "0x88F9EF0", VA = "0x1888FB2F0")]
	[IteratorStateMachine(typeof(AIHLJNDAKJM))]
	private static IEnumerable<LBJLEMIJBCP> GINLLNBKLAH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x88FA240", Offset = "0x88F8E40", VA = "0x1888FA240")]
	public static LBJLEMIJBCP ANKOKPBAKNG(KPFEPBPCGON FKAGADIENDA, int FEJALILJGHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x88FB710", Offset = "0x88FA310", VA = "0x1888FB710")]
	public static bool IIDGCOFFKOB(this KPFEPBPCGON FKAGADIENDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x88FB0E0", Offset = "0x88F9CE0", VA = "0x1888FB0E0")]
	public static void GCMLOHPADFH(KPFEPBPCGON FKAGADIENDA, float3 OICGMGKIADE, [Out] CGFHFOOKNPB OJNIDKGKNBD, [Out] float3 GPFJGAIEEOP, [Out] float OAGNGDKHHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x88FB350", Offset = "0x88F9F50", VA = "0x1888FB350")]
	public static void HJFJIJKOFIH(Vector3 OICGMGKIADE, KPFEPBPCGON FKAGADIENDA, [Out] Vector3 GPFJGAIEEOP, [Out] float OAGNGDKHHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x88FBC40", Offset = "0x88FA840", VA = "0x1888FBC40")]
	[NAMAGMJFFPI(0)]
	[ANDJKCFDCCK(DLMFLMIFFFL.ExitingPlayMode, 0)]
	private static void PMDPIEIAHII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x88FBA80", Offset = "0x88FA680", VA = "0x1888FBA80")]
	[NAMAGMJFFPI(0)]
	[ANDJKCFDCCK(DLMFLMIFFFL.ExitingPlayMode, 0)]
	private static void ONCCDOMAIPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class PMMOJDLLJMN : MEFOENIIPMB, IDisposable, HDPCLFCBCPA
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly JPIBGNDAFKP FAOMHPPHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly DGNDEINJLGE<EEHGLNGJALI, IEOPPNLCFAO> MALILLMFKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly DGNDEINJLGE<PLBHNIEEDEN, BPAKCCFAFEE> LMIKJLDMIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly DGNDEINJLGE<FDKEBGOKFEA, LCELBDBACOO> AJPKLHJJEND;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public IEOPPNLCFAO HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8909140", Offset = "0x8907D40", VA = "0x188909140", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public BPAKCCFAFEE HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8909200", Offset = "0x8907E00", VA = "0x188909200", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public LCELBDBACOO HHFPMPGGMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x89091A0", Offset = "0x8907DA0", VA = "0x1889091A0", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool FAEMLNNJBBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xBDFF70", Offset = "0xBDEB70", VA = "0x180BDFF70", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xB3BA30", Offset = "0xB3A630", VA = "0x180B3BA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x89094B0", Offset = "0x89080B0", VA = "0x1889094B0")]
	public PMMOJDLLJMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x8908DD0", Offset = "0x89079D0", VA = "0x188908DD0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8908E60", Offset = "0x8907A60", VA = "0x188908E60", Slot = "4")]
	public EEHGLNGJALI ELCHGMLJKIA(PLLHHFOOEOI PEDMEJIDLNB)
	{
		return default(EEHGLNGJALI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8908E60", Offset = "0x8907A60", VA = "0x188908E60", Slot = "5")]
	public EEHGLNGJALI ELCHGMLJKIA(PLLHHFOOEOI PEDMEJIDLNB, bool BHCBOEMNJGO)
	{
		return default(EEHGLNGJALI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x89093D0", Offset = "0x8907FD0", VA = "0x1889093D0", Slot = "6")]
	public void PMPMKFBKBDP(EEHGLNGJALI HMGDINOCJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x8909020", Offset = "0x8907C20", VA = "0x188909020", Slot = "7")]
	public void HGJECIIJCBG(EEHGLNGJALI HMGDINOCJAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x8908AE0", Offset = "0x89076E0", VA = "0x188908AE0", Slot = "8")]
	public PLBHNIEEDEN BCCNHNEJPAO(EEHGLNGJALI HMGDINOCJAI, FLIFFCNMJBP PEDMEJIDLNB)
	{
		return default(PLBHNIEEDEN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x8908C90", Offset = "0x8907890", VA = "0x188908C90", Slot = "9")]
	public PLBHNIEEDEN DLPCKAECPEI(EEHGLNGJALI HMGDINOCJAI, BKJBENJIBKG PEDMEJIDLNB)
	{
		return default(PLBHNIEEDEN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x89089F0", Offset = "0x89075F0", VA = "0x1889089F0", Slot = "11")]
	public void AAGENEJBIAL(PLBHNIEEDEN DAAJJNMMALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x8909300", Offset = "0x8907F00", VA = "0x188909300", Slot = "10")]
	public void IOJINMAMACM(PLBHNIEEDEN DAAJJNMMALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x8908C20", Offset = "0x8907820", VA = "0x188908C20", Slot = "20")]
	public IEnumerable<Renderer> CDOIFOFFJHG(EEHGLNGJALI HMGDINOCJAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x8908FA0", Offset = "0x8907BA0", VA = "0x188908FA0", Slot = "12")]
	public FDKEBGOKFEA GJHAEJOBDAK(JMKGEOALEPB PEDMEJIDLNB)
	{
		return default(FDKEBGOKFEA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x8909360", Offset = "0x8907F60", VA = "0x188909360", Slot = "14")]
	public void KKODIHKGODL(FDKEBGOKFEA ALGOPHJEAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x8909260", Offset = "0x8907E60", VA = "0x188909260", Slot = "16")]
	public Task ILGKOHFNCHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x89090A0", Offset = "0x8907CA0", VA = "0x1889090A0", Slot = "17")]
	public Task HJIKLLFIBAC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x8908F00", Offset = "0x8907B00", VA = "0x188908F00", Slot = "18")]
	public Task GEJKCMMBNDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x27FC6D0", Offset = "0x27FB2D0", VA = "0x1827FC6D0", Slot = "19")]
	public void LHGKCPEDNCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x8908A80", Offset = "0x8907680", VA = "0x188908A80", Slot = "13")]
	public void AKDHODBJMFL(FDKEBGOKFEA ALGOPHJEAMD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface LFDINEDACOP
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool NMCBGHOAECK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material AAMFMLFAIBN();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material NNHFCEEGBGI();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material LLPMIDOGNMB();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int DGFAFOHMJLP(JLNOJMKJPNC KAHBCHHNKHP);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int BIGNDDICJED(IIDDCNCKDDH HBBBEFNJPID);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GCICHLGAAAB(GameObject KDKJDFFGNJJ);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ELFAIIFPPOO(GameObject KDKJDFFGNJJ, bool PPPHGDBPEGJ);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class JAMKBEAPELO
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static LFDINEDACOP JCPBJCFMJCO;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool NMCBGHOAECK
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8902890", Offset = "0x8901490", VA = "0x188902890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x8902840", Offset = "0x8901440", VA = "0x188902840")]
	public static void MILOLKIDEII(LFDINEDACOP ACOEBJLKCDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x89024F0", Offset = "0x89010F0", VA = "0x1889024F0")]
	public static Material AAMFMLFAIBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x8901EF0", Offset = "0x8900AF0", VA = "0x188901EF0")]
	public static Material NNHFCEEGBGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x89027E0", Offset = "0x89013E0", VA = "0x1889027E0")]
	public static Material LLPMIDOGNMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x89025C0", Offset = "0x89011C0", VA = "0x1889025C0")]
	public static int DGFAFOHMJLP(JLNOJMKJPNC KAHBCHHNKHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x8902550", Offset = "0x8901150", VA = "0x188902550")]
	public static int BIGNDDICJED(IIDDCNCKDDH HBBBEFNJPID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x8902710", Offset = "0x8901310", VA = "0x188902710")]
	public static void GCICHLGAAAB(GameObject KDKJDFFGNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8902630", Offset = "0x8901230", VA = "0x188902630")]
	public static void ELFAIIFPPOO(GameObject KDKJDFFGNJJ, bool PPPHGDBPEGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LCELBDBACOO : LOFJNALBJNK
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class HMFHKOKGLIN : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private Renderer <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public LCELBDBACOO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xF21C60", Offset = "0xF20860", VA = "0x180F21C60")]
		[DebuggerHidden]
		public HMFHKOKGLIN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x8900990", Offset = "0x88FF590", VA = "0x188900990", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8900670", Offset = "0x88FF270", VA = "0x188900670", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8900620", Offset = "0x88FF220", VA = "0x188900620")]
		private void HOIHHFKDFKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8900940", Offset = "0x88FF540", VA = "0x188900940", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8900890", Offset = "0x88FF490", VA = "0x188900890", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x8900890", Offset = "0x88FF490", VA = "0x188900890", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly JMKGEOALEPB MFNHKIJCBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly HDPCLFCBCPA GMOAOFPHJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private BDKCBIIPGGF KLNCJHJMMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<GBNPLAAEKHD> KECKHAIJMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<GBNPLAAEKHD> AHFFOIPOGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private GameObject FEAMFMCPOGP;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x8903B00", Offset = "0x8902700", VA = "0x188903B00")]
	public static LCELBDBACOO PKOOBMPMMPO(JMKGEOALEPB PEDMEJIDLNB, HDPCLFCBCPA GMOAOFPHJNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8903C50", Offset = "0x8902850", VA = "0x188903C50")]
	private LCELBDBACOO(JMKGEOALEPB PEDMEJIDLNB, HDPCLFCBCPA GMOAOFPHJNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x8903400", Offset = "0x8902000", VA = "0x188903400")]
	public void LDCCMKMJIMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x8903380", Offset = "0x8901F80", VA = "0x188903380")]
	[IteratorStateMachine(typeof(HMFHKOKGLIN))]
	public IEnumerable<Renderer> DOBIDMFOOEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x89028F0", Offset = "0x89014F0", VA = "0x1889028F0", Slot = "4")]
	public void AEPCOKJKHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x8903880", Offset = "0x8902480", VA = "0x188903880")]
	private void LIDEFOKIEOP(Vector3 HEKKEJMBPPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x89038B0", Offset = "0x89024B0", VA = "0x1889038B0")]
	public void NJCBLGMIGNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class GBNPLAAEKHD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct HNJBAJEJHEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public FIAIMIEBBMJ JNNKOMEPAAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public LNFJEBGBMKD PNJIHOAHFGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int OPBNMHLPOHJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class ELFNMKPCEJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public GBNPLAAEKHD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public CNFDLJNNJAL lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<HNJBAJEJHEE> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public OKLIIGFAOMH combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public ELFNMKPCEJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x88FBEE0", Offset = "0x88FAAE0", VA = "0x1888FBEE0")]
		internal JobHandle LGBCCJOCEAA()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x88FBEB0", Offset = "0x88FAAB0", VA = "0x1888FBEB0")]
		internal void HCBIBJEIEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x88FBD40", Offset = "0x88FA940", VA = "0x1888FBD40")]
		internal void GJDFKELNMCG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private int[] EJBJFCOLJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private KKLDFMEJAHK FCCGCIGOLED;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Matrix4x4 KIDEKNFLEHM;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh IMHDIMLICOF
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB20", Offset = "0xA1D720", VA = "0x180A1EB20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int NLHDEGLOJPB
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA217D0", Offset = "0xA203D0", VA = "0x180A217D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA21F20", Offset = "0xA20B20", VA = "0x180A21F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x88FF440", Offset = "0x88FE040", VA = "0x1888FF440")]
	public void OEHMHEAINLF(List<LNFJEBGBMKD> FEBFLJDDGDJ, Matrix4x4[] FBFKFKPNAPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x88FE970", Offset = "0x88FD570", VA = "0x1888FE970")]
	public static List<GBNPLAAEKHD> GLOMJONEBBE(List<IEOPPNLCFAO> MCGFAPICIAE, CNFDLJNNJAL FEJALILJGHL, Bounds KEGEMMFMACC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x88FF0E0", Offset = "0x88FDCE0", VA = "0x1888FF0E0")]
	private JobHandle KOBOJFJAOOE(OKLIIGFAOMH IEBLLKFMEME, int OIJBEAFIMMC, int HKCNFKLJMPF, CNFDLJNNJAL FEJALILJGHL, List<HNJBAJEJHEE> GKJHBFDAMJI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x88FF000", Offset = "0x88FDC00", VA = "0x1888FF000")]
	private void JPJILMMNMKL(List<HNJBAJEJHEE> GKJHBFDAMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x88FF7B0", Offset = "0x88FE3B0", VA = "0x1888FF7B0")]
	private GBNPLAAEKHD(List<HNJBAJEJHEE> GKJHBFDAMJI, int OIJBEAFIMMC, int HKCNFKLJMPF, CNFDLJNNJAL FEJALILJGHL, Bounds KEGEMMFMACC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x88FE8E0", Offset = "0x88FD4E0", VA = "0x1888FE8E0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private MaterialPropertyBlock IFAFILPGBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private GBNPLAAEKHD BFDKALDCPEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<LNFJEBGBMKD> AJDCHCNBIKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private RenderTexture NDNMMLKKJLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ComputeBuffer BPKENKJFEBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ComputeShader IHALHEEGELF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Matrix4x4[] HEJGCOMJNOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int JCFGAFOHIBD;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer LHIFFPJNFBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xA1F7B0", Offset = "0xA1E3B0", VA = "0x180A1F7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int EBGJCHKKOIA
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x890A600", Offset = "0x8909200", VA = "0x18890A600")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x89098D0", Offset = "0x89084D0", VA = "0x1889098D0")]
		public static List<SkinnedShapeRenderer> Create(GameObject HMGDINOCJAI, List<GBNPLAAEKHD> FCGKFOHAJFM, List<LNFJEBGBMKD> AJDCHCNBIKJ, Material IMKAMKEPJBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x8909C80", Offset = "0x8908880", VA = "0x188909C80")]
		public void Init(GBNPLAAEKHD BFDKALDCPEN, List<LNFJEBGBMKD> AJDCHCNBIKJ, Material IMKAMKEPJBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x890A560", Offset = "0x8909160", VA = "0x18890A560")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x890A4C0", Offset = "0x89090C0", VA = "0x18890A4C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x890A480", Offset = "0x8909080", VA = "0x18890A480")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8909BC0", Offset = "0x89087C0", VA = "0x188909BC0")]
		private void IKAGONBMEKP(ScriptableRenderContext CBLPKFIJGLH, Camera[] BNCPEEPEIJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x890A110", Offset = "0x8908D10", VA = "0x18890A110")]
		private void OEHMHEAINLF(CommandBuffer NEJGIBHBGHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA1DE70", Offset = "0xA1CA70", VA = "0x180A1DE70")]
		public SkinnedShapeRenderer()
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
