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
	public class LogRegistrationIndex : NELPCBNCFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7F03D90", Offset = "0x7F02990", VA = "0x187F03D90", Slot = "4")]
		public override void CHOGICNNBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F07750", Offset = "0x7F06350", VA = "0x187F07750", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x240ECE0", Offset = "0x240D8E0", VA = "0x18240ECE0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class NGONKLBNDMH : FLLBBDCAKFK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private byte APNOHDIMGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly List<SkinnedShapeRenderer>[] PCKKMFOHDIK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JMIFPKJCMOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA90E00", Offset = "0xA8FA00", VA = "0x180A90E00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xB42EE0", Offset = "0xB41AE0", VA = "0x180B42EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int NHCELMKAOMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9994B0", Offset = "0x9980B0", VA = "0x1809994B0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x998AA0", Offset = "0x9976A0", VA = "0x180998AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float IJLLCDMLONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD6E740", Offset = "0xD6D340", VA = "0x180D6E740", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1028750", Offset = "0x1027350", VA = "0x181028750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float MAJNOKONBPA
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xAF2900", Offset = "0xAF1500", VA = "0x180AF2900", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAF2910", Offset = "0xAF1510", VA = "0x180AF2910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public List<SkinnedShapeRenderer> LDNBMJCJBIP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7F04360", Offset = "0x7F02F60", VA = "0x187F04360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public List<SkinnedShapeRenderer> JEMDDODGKPA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7F04330", Offset = "0x7F02F30", VA = "0x187F04330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public GameObject JHCLOFMDCND
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9574D0", Offset = "0x9560D0", VA = "0x1809574D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9574E0", Offset = "0x9560E0", VA = "0x1809574E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public byte CMGKHMCCAHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F043F0", Offset = "0x7F02FF0", VA = "0x187F043F0", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7F04440", Offset = "0x7F03040", VA = "0x187F04440")]
	public NGONKLBNDMH(List<DLJPLGHMGCG> EGPMLOFLOMO, List<DLJPLGHMGCG> BOKGPNACGOK, List<MLDOPOKHGBO> JJNNFMINDGB, Material LBEFIBKFEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7F03E60", Offset = "0x7F02A60", VA = "0x187F03E60")]
	private int BONDIKJEMKP(List<DLJPLGHMGCG> HMICJGHEICD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7F041D0", Offset = "0x7F02DD0", VA = "0x187F041D0")]
	private void EBDLHECKAPO(int MOMJAHLEMFD, bool LBOHKFHGEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7F03F80", Offset = "0x7F02B80", VA = "0x187F03F80")]
	public void DPFBAPLIMLD(Vector3 OEHBGCCAEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7F040D0", Offset = "0x7F02CD0", VA = "0x187F040D0", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7F043B0", Offset = "0x7F02FB0", VA = "0x187F043B0")]
	public void PCKOIICPKGN(Transform ENJONACJCLB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GHPBHILJBAO : LJJHIIGOFKI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class LLCDLMCOFFN : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public GHPBHILJBAO <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD30330", Offset = "0xD2EF30", VA = "0x180D30330")]
		[DebuggerHidden]
		public LLCDLMCOFFN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7F03BA0", Offset = "0x7F027A0", VA = "0x187F03BA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7F03590", Offset = "0x7F02190", VA = "0x187F03590", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7F034A0", Offset = "0x7F020A0", VA = "0x187F034A0")]
		private void AOMOFJGADBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7F03540", Offset = "0x7F02140", VA = "0x187F03540")]
		private void BENEFBJOBNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7F034F0", Offset = "0x7F020F0", VA = "0x187F034F0")]
		private void BANAEMOEOKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7F03B50", Offset = "0x7F02750", VA = "0x187F03B50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7F03AA0", Offset = "0x7F026A0", VA = "0x187F03AA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7F03AA0", Offset = "0x7F026A0", VA = "0x187F03AA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class EKKCGFBIADC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public GHPBHILJBAO <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xD30330", Offset = "0xD2EF30", VA = "0x180D30330")]
		[DebuggerHidden]
		public EKKCGFBIADC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9460", Offset = "0x7EF8060", VA = "0x187EF9460", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8FF0", Offset = "0x7EF7BF0", VA = "0x187EF8FF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8F50", Offset = "0x7EF7B50", VA = "0x187EF8F50")]
		private void AOMOFJGADBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8FA0", Offset = "0x7EF7BA0", VA = "0x187EF8FA0")]
		private void BENEFBJOBNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9410", Offset = "0x7EF8010", VA = "0x187EF9410", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9360", Offset = "0x7EF7F60", VA = "0x187EF9360", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9360", Offset = "0x7EF7F60", VA = "0x187EF9360", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly ECMOINEGHPA BDMCKILHPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly List<KGKBNBDBONE> NFGDFCAAPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private List<ClusterMeshRenderer> LDMNMKDJHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private BatchedMeshRenderer OPAAEPGEBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool HCJGOOKKLOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly bool MHIGJABGGLA;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IEnumerable<LAAACBDNNIL> NBBFOFMICKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int CFCNIDGKONC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7EFCF90", Offset = "0x7EFBB90", VA = "0x187EFCF90", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MLDOPOKHGBO FFFPHMFPBFB
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7EFC900", Offset = "0x7EFB500", VA = "0x187EFC900", Slot = "8")]
		get
		{
			return default(MLDOPOKHGBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public List<SkinnedShapeRenderer> KGIJIFJGPEE
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x95CEF0", Offset = "0x95BAF0", VA = "0x18095CEF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x95D140", Offset = "0x95BD40", VA = "0x18095D140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7EFBBB0", Offset = "0x7EFA7B0", VA = "0x187EFBBB0")]
	private bool EHMGLDDPPJL(KGKBNBDBONE PKCKJCGKEIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7EFD0D0", Offset = "0x7EFBCD0", VA = "0x187EFD0D0")]
	private static bool PAAAKJJGLBE(KGKBNBDBONE PKCKJCGKEIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7EFD0F0", Offset = "0x7EFBCF0", VA = "0x187EFD0F0")]
	public GHPBHILJBAO(ECMOINEGHPA LLDJIJICLJF, bool MAGLNOANPDK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7EFB940", Offset = "0x7EFA540", VA = "0x187EFB940", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7EFC4C0", Offset = "0x7EFB0C0", VA = "0x187EFC4C0")]
	public void GFCJDEIJPEO(KGKBNBDBONE PKCKJCGKEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7EFB7E0", Offset = "0x7EFA3E0", VA = "0x187EFB7E0")]
	public void BLAPNJAELFA(KGKBNBDBONE PKCKJCGKEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7EFCA90", Offset = "0x7EFB690", VA = "0x187EFCA90", Slot = "4")]
	public void LDHBKAMKMJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7EFC690", Offset = "0x7EFB290", VA = "0x187EFC690")]
	public void KAFGFLAKMPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7EFBC80", Offset = "0x7EFA880", VA = "0x187EFBC80")]
	private void FFCPPEIFJHK(List<KGKBNBDBONE> NFGDFCAAPOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9A60", Offset = "0x7EF8660", VA = "0x187EF9A60")]
	private static Material DLFNGPKFOKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7EFBBD0", Offset = "0x7EFA7D0", VA = "0x187EFBBD0")]
	private void FFCPPEIFJHK(KGKBNBDBONE PKCKJCGKEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7EFC3F0", Offset = "0x7EFAFF0", VA = "0x187EFC3F0")]
	private void FPDFLJHJFLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7EFBE40", Offset = "0x7EFAA40", VA = "0x187EFBE40")]
	public void FHAOPEKPFGI(bool PDKODIKKEOL, bool EFGFDOLGIKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7EFC9D0", Offset = "0x7EFB5D0", VA = "0x187EFC9D0")]
	protected void KOGCJBDIIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7EFBB30", Offset = "0x7EFA730", VA = "0x187EFBB30")]
	public void ECCGMDCHHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7EFCFD0", Offset = "0x7EFBBD0", VA = "0x187EFCFD0")]
	[IteratorStateMachine(typeof(LLCDLMCOFFN))]
	public IEnumerable<Renderer> NMBAGICBLIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7EFD050", Offset = "0x7EFBC50", VA = "0x187EFD050")]
	[IteratorStateMachine(typeof(EKKCGFBIADC))]
	public IEnumerable<Renderer> OFHMEDBOLJP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal class FPDIFDIMOLC : KGKBNBDBONE
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct CGJDPDOEENA : OBCFEJJADBD, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private IKFMJHEMOMC LDLKDBPEDDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private JobHandle IEMHNEHKIEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private ONIKJPPAAFE BEADEDDDBBH;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7EF3B10", Offset = "0x7EF2710", VA = "0x187EF3B10")]
		public CGJDPDOEENA(IKFMJHEMOMC LDLKDBPEDDB, JobHandle IEMHNEHKIEH, ONIKJPPAAFE BEADEDDDBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7EF3A90", Offset = "0x7EF2690", VA = "0x187EF3A90", Slot = "4")]
		public IKFMJHEMOMC BAHMIJKKLIG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7EF3AC0", Offset = "0x7EF26C0", VA = "0x187EF3AC0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal readonly PBHNFJGKOIJ EJNGNCBJNEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private float BIALPJMIPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Hash128 LLLHIIFIPLA;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	protected override Hash128 GFFOHFAACBP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7EFB600", Offset = "0x7EFA200", VA = "0x187EFB600", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7EFB730", Offset = "0x7EFA330", VA = "0x187EFB730")]
	public FPDIFDIMOLC(GHPBHILJBAO EBMDCHEPJIM, PBHNFJGKOIJ LLDJIJICLJF, bool MAGLNOANPDK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "18")]
	public override bool KPMPEEGIFLC(MLDOPOKHGBO EBMDCHEPJIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9DF0", Offset = "0x7EF89F0", VA = "0x187EF9DF0", Slot = "19")]
	public override int BONDIKJEMKP(MGDBPAMBEJB IMJJMIHFOFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7EFB430", Offset = "0x7EFA030", VA = "0x187EFB430", Slot = "20")]
	public override int LAPJOPLFMGI(MGDBPAMBEJB IMJJMIHFOFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7EFAE40", Offset = "0x7EF9A40", VA = "0x187EFAE40", Slot = "21")]
	public override LFGAPABEHMN HHEHLAHMHKN()
	{
		return default(LFGAPABEHMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0xAB79F0", Offset = "0xAB65F0", VA = "0x180AB79F0", Slot = "22")]
	public override float LKMMIOAAIAI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7EFA860", Offset = "0x7EF9460", VA = "0x187EFA860", Slot = "23")]
	public override void EGKHEFNLBPF(MGDBPAMBEJB IMJJMIHFOFD, DHJACBEOCJB CBDENEFPCEB, int KANFLGEMNAD = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7EFA790", Offset = "0x7EF9390", VA = "0x187EFA790", Slot = "24")]
	public override MLDOPOKHGBO EBFDBMJNJMC()
	{
		return default(MLDOPOKHGBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7EFB280", Offset = "0x7EF9E80", VA = "0x187EFB280", Slot = "26")]
	public override IFHPDJDEHJG JACCFIHMKDB()
	{
		return default(IFHPDJDEHJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9FC0", Offset = "0x7EF8BC0", VA = "0x187EF9FC0", Slot = "27")]
	public override OBCFEJJADBD COMKPFFAHDM(MGDBPAMBEJB IMJJMIHFOFD, JobHandle IEMHNEHKIEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[DefaultMember("Item")]
public interface CBOJDCAGDMO
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	GHPBHILJBAO MPDHFMNHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	KGKBNBDBONE MPDHFMNHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	PBJMHODEBFG MPDHFMNHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[DefaultMember("Item")]
public class DIOOGJPIOCF : LAHFEONIIDI, IDisposable, CBOJDCAGDMO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OBKLJIBEKOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public DIOOGJPIOCF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x7F04760", Offset = "0x7F03360", VA = "0x187F04760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x7F04CC0", Offset = "0x7F038C0", VA = "0x187F04CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly FFGKLPIFKEC<IIPDOOIGMOL, GHPBHILJBAO> EGONDDMJFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly FFGKLPIFKEC<OJNLEJKNADA, KGKBNBDBONE> NFGDFCAAPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly FFGKLPIFKEC<NKNDDOIODOM, PBJMHODEBFG> FMIMGCEHCNG;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public GHPBHILJBAO MPDHFMNHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7EF72E0", Offset = "0x7EF5EE0", VA = "0x187EF72E0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public KGKBNBDBONE MPDHFMNHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7EF73A0", Offset = "0x7EF5FA0", VA = "0x187EF73A0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public PBJMHODEBFG MPDHFMNHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7340", Offset = "0x7EF5F40", VA = "0x187EF7340", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool LLOKLODACHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xC76630", Offset = "0xC75230", VA = "0x180C76630", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xC764F0", Offset = "0xC750F0", VA = "0x180C764F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7EF77D0", Offset = "0x7EF63D0", VA = "0x187EF77D0")]
	public DIOOGJPIOCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5D80", Offset = "0x7EF4980", VA = "0x187EF5D80", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5680", Offset = "0x7EF4280", VA = "0x187EF5680", Slot = "4")]
	public IIPDOOIGMOL BDEPEPJPJNG(ECMOINEGHPA LLDJIJICLJF)
	{
		return default(IIPDOOIGMOL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5690", Offset = "0x7EF4290", VA = "0x187EF5690", Slot = "5")]
	public IIPDOOIGMOL BDEPEPJPJNG(ECMOINEGHPA LLDJIJICLJF, bool MAGLNOANPDK)
	{
		return default(IIPDOOIGMOL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6710", Offset = "0x7EF5310", VA = "0x187EF6710", Slot = "6")]
	public void IFICAOANFLG(IIPDOOIGMOL EBMDCHEPJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7EF62E0", Offset = "0x7EF4EE0", VA = "0x187EF62E0", Slot = "7")]
	public void ENKDEBBIPPD(IIPDOOIGMOL EBMDCHEPJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6960", Offset = "0x7EF5560", VA = "0x187EF6960", Slot = "8")]
	public OJNLEJKNADA IPJLEMEFKLK(IIPDOOIGMOL EBMDCHEPJIM, PPIKABHIOAG LLDJIJICLJF)
	{
		return default(OJNLEJKNADA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6E20", Offset = "0x7EF5A20", VA = "0x187EF6E20", Slot = "9")]
	public OJNLEJKNADA KCKNPFDDFLG(IIPDOOIGMOL EBMDCHEPJIM, PBHNFJGKOIJ LLDJIJICLJF)
	{
		return default(OJNLEJKNADA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7EF59E0", Offset = "0x7EF45E0", VA = "0x187EF59E0", Slot = "11")]
	public void CPDIHHFAFFI(OJNLEJKNADA PKCKJCGKEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5F40", Offset = "0x7EF4B40", VA = "0x187EF5F40", Slot = "10")]
	public void EDDLBNGINKJ(OJNLEJKNADA PKCKJCGKEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5970", Offset = "0x7EF4570", VA = "0x187EF5970", Slot = "20")]
	public IEnumerable<Renderer> CBDHJDLNFKE(IIPDOOIGMOL EBMDCHEPJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6190", Offset = "0x7EF4D90", VA = "0x187EF6190", Slot = "12")]
	public NKNDDOIODOM EEOFKABPEGK(JODDCIOIFLC LLDJIJICLJF)
	{
		return default(NKNDDOIODOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5900", Offset = "0x7EF4500", VA = "0x187EF5900", Slot = "14")]
	public void BOMOBKKHDCG(NKNDDOIODOM NNGMIJFEMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7610", Offset = "0x7EF6210", VA = "0x187EF7610", Slot = "16")]
	public Task PIGACLDFCGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7460", Offset = "0x7EF6060", VA = "0x187EF7460", Slot = "17")]
	public Task PGHAOOIGDJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6210", Offset = "0x7EF4E10", VA = "0x187EF6210", Slot = "18")]
	[AsyncStateMachine(typeof(OBKLJIBEKOK))]
	public Task EINJCNPGHCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6620", Offset = "0x7EF5220", VA = "0x187EF6620", Slot = "19")]
	public void HAHNFFCMDCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7400", Offset = "0x7EF6000", VA = "0x187EF7400", Slot = "13")]
	public void OKJAOCPOPFI(NKNDDOIODOM NNGMIJFEMLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
internal class HOLJHBHNEAP : KGKBNBDBONE
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private struct ONEAHPCBIKJ : OBCFEJJADBD, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private IKFMJHEMOMC LDLKDBPEDDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NativeArray<int> KBBOKAHHCIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private JobHandle IEMHNEHKIEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private KFCDDGFGGJB BEADEDDDBBH;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7F04E20", Offset = "0x7F03A20", VA = "0x187F04E20")]
		public ONEAHPCBIKJ(IKFMJHEMOMC LDLKDBPEDDB, NativeArray<int> KBBOKAHHCIC, JobHandle IEMHNEHKIEH, KFCDDGFGGJB BEADEDDDBBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7F04D20", Offset = "0x7F03920", VA = "0x187F04D20", Slot = "4")]
		public IKFMJHEMOMC BAHMIJKKLIG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7F04D80", Offset = "0x7F03980", VA = "0x187F04D80", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly PPIKABHIOAG JBDHCGELIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int[] ODMPMMNFCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Hash128 LLLHIIFIPLA;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Vector3 COIFMMLKOHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7EFF270", Offset = "0x7EFDE70", VA = "0x187EFF270")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	protected override Hash128 GFFOHFAACBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7EFF4A0", Offset = "0x7EFE0A0", VA = "0x187EFF4A0", Slot = "25")]
		get
		{
			return default(Hash128);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7EFF5D0", Offset = "0x7EFE1D0", VA = "0x187EFF5D0")]
	public HOLJHBHNEAP(GHPBHILJBAO EBMDCHEPJIM, PPIKABHIOAG LLDJIJICLJF, bool FFFBOIMMJCN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7EFED80", Offset = "0x7EFD980", VA = "0x187EFED80", Slot = "18")]
	public override bool KPMPEEGIFLC(MLDOPOKHGBO EBMDCHEPJIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7EFE580", Offset = "0x7EFD180", VA = "0x187EFE580", Slot = "21")]
	public override LFGAPABEHMN HHEHLAHMHKN()
	{
		return default(LFGAPABEHMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7EFE5C0", Offset = "0x7EFD1C0", VA = "0x187EFE5C0")]
	private LFGAPABEHMN HHEHLAHMHKN(MLDOPOKHGBO EBMDCHEPJIM)
	{
		return default(LFGAPABEHMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7EFDA60", Offset = "0x7EFC660", VA = "0x187EFDA60")]
	private DGAFACKGDIA DLFFMLDHMDH([In] UniformTRS NKNHMFFFNAJ, [In] float3 AHOEGMFCFON)
	{
		return default(DGAFACKGDIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7EFD1E0", Offset = "0x7EFBDE0", VA = "0x187EFD1E0", Slot = "19")]
	public override int BONDIKJEMKP(MGDBPAMBEJB IMJJMIHFOFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7EFEE50", Offset = "0x7EFDA50", VA = "0x187EFEE50", Slot = "20")]
	public override int LAPJOPLFMGI(MGDBPAMBEJB IMJJMIHFOFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7EFF180", Offset = "0x7EFDD80", VA = "0x187EFF180", Slot = "22")]
	public override float LKMMIOAAIAI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7EFEF00", Offset = "0x7EFDB00", VA = "0x187EFEF00")]
	private int LIKFGBAOCOD(MGDBPAMBEJB IMJJMIHFOFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7EFDD30", Offset = "0x7EFC930", VA = "0x187EFDD30", Slot = "23")]
	public override void EGKHEFNLBPF(MGDBPAMBEJB IMJJMIHFOFD, DHJACBEOCJB CBDENEFPCEB, int KANFLGEMNAD = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7EFDC60", Offset = "0x7EFC860", VA = "0x187EFDC60", Slot = "24")]
	public override MLDOPOKHGBO EBFDBMJNJMC()
	{
		return default(MLDOPOKHGBO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7EFEBD0", Offset = "0x7EFD7D0", VA = "0x187EFEBD0", Slot = "26")]
	public override IFHPDJDEHJG JACCFIHMKDB()
	{
		return default(IFHPDJDEHJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7EFD290", Offset = "0x7EFBE90", VA = "0x187EFD290", Slot = "27")]
	public override OBCFEJJADBD COMKPFFAHDM(MGDBPAMBEJB IMJJMIHFOFD, JobHandle IEMHNEHKIEH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface FMHOLAEGHGG
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PBBIFMLHLCJ(EOGPNMLBPJG ADFFEBFOCBD, Renderer HHBLCPHFAAG, int ENEGBKPHADB);

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PGJPEKIAFCL(Renderer HHBLCPHFAAG, NMKBMCNJDOD HKPDLOOMFFD, Vector3 PIDIPIIBMGP, Vector3 DKHBAPGMEPM, Vector3 EGNDGLCMLCM, float GLACLAGAINO, float CKENNCOODHE, float NJDLGKCOHBF = -1f, [Optional] Color? PFOKHHCFPNE, [Optional] IReadOnlyList<Camera> OBCIAHDFCDE);

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HGPCHCHPNHO(Renderer HHBLCPHFAAG, int ENEGBKPHADB);

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int HHKIPOODKHM();

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NFCBJECFFID(int GPFADMAKCLD, JCPBLDHJLEF ADFFEBFOCBD, Renderer HHBLCPHFAAG, int ENEGBKPHADB);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KFNIIFIFOBM : NPIAAOHMPJM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private class LDGCEFAEANI : PHMOOGMIKDB<int>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7F03450", Offset = "0x7F02050", VA = "0x187F03450")]
		public LDGCEFAEANI(string BGKKCEGMOKH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly FMHOLAEGHGG JCFBKHFKCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly CBOJDCAGDMO GOGGCDOCLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private MeshRenderer OJPCLIJJNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private LDGCEFAEANI CEFCHDOAKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private bool BGMJGHEDEEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private MeshRenderer CNHGJDDKOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private LDGCEFAEANI JLJDPKILKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private bool PONJLEFJCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private MeshRenderer PBNOEKMBBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private LDGCEFAEANI NDJLHLIBINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool HNLEPAMPAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private bool EIHBPFOIIHI;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x9677A0", Offset = "0x9663A0", VA = "0x1809677A0")]
	public KFNIIFIFOBM(FMHOLAEGHGG BMAODIIHJOI, CBOJDCAGDMO GOGGCDOCLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7F00E00", Offset = "0x7EFFA00", VA = "0x187F00E00", Slot = "23")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7F02170", Offset = "0x7F00D70", VA = "0x187F02170")]
	private void OGIOAPFJIIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7F00800", Offset = "0x7EFF400", VA = "0x187F00800", Slot = "4")]
	public void DIHCMGOANFI(IIPDOOIGMOL EBMDCHEPJIM, JCPBLDHJLEF PELCJAFICFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7F00B10", Offset = "0x7EFF710", VA = "0x187F00B10", Slot = "5")]
	public void DIHCMGOANFI(OJNLEJKNADA PKCKJCGKEIP, JCPBLDHJLEF PELCJAFICFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7F00FB0", Offset = "0x7EFFBB0", VA = "0x187F00FB0", Slot = "6")]
	public void FOJBJFMLFKB(OJNLEJKNADA PKCKJCGKEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7F003D0", Offset = "0x7EFEFD0", VA = "0x187F003D0", Slot = "7")]
	public void CFJBDCAAMCD(OJNLEJKNADA PKCKJCGKEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7F011E0", Offset = "0x7EFFDE0", VA = "0x187F011E0", Slot = "24")]
	public void HGMDAKBNFLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xEC8510", Offset = "0xEC7110", VA = "0x180EC8510", Slot = "8")]
	public void BIBIOCIAELN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7F01ED0", Offset = "0x7F00AD0", VA = "0x187F01ED0", Slot = "9")]
	public void KGHMNJKCDMF(JCPBLDHJLEF PELCJAFICFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7F01580", Offset = "0x7F00180", VA = "0x187F01580", Slot = "10")]
	public void ILIABCJLFGO(IIPDOOIGMOL EBMDCHEPJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7F01220", Offset = "0x7EFFE20", VA = "0x187F01220", Slot = "11")]
	public void ILIABCJLFGO(OJNLEJKNADA PKCKJCGKEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7F00D30", Offset = "0x7EFF930", VA = "0x187F00D30", Slot = "12")]
	public void DOOCMOOAIFE(OJNLEJKNADA PKCKJCGKEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7F01110", Offset = "0x7EFFD10", VA = "0x187F01110", Slot = "13")]
	public void GPOOKEAKBIH(OJNLEJKNADA PKCKJCGKEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7F01B90", Offset = "0x7F00790", VA = "0x187F01B90")]
	private void JMAFDLLJOKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x1124F60", Offset = "0x1123B60", VA = "0x181124F60", Slot = "14")]
	public void NCJAGAAEPON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7EFFA40", Offset = "0x7EFE640", VA = "0x187EFFA40", Slot = "15")]
	public void AEGDDNLHOFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7F00520", Offset = "0x7EFF120", VA = "0x187F00520", Slot = "16")]
	public void CKKHIODBLLG(IIPDOOIGMOL EBMDCHEPJIM, EOGPNMLBPJG ADFFEBFOCBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7F01850", Offset = "0x7F00450", VA = "0x187F01850", Slot = "17")]
	public void INFNCLGCEOP(OJNLEJKNADA PKCKJCGKEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7F01E00", Offset = "0x7F00A00", VA = "0x187F01E00", Slot = "18")]
	public void JPLKMMMCNEA(OJNLEJKNADA PKCKJCGKEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0xB4FC20", Offset = "0xB4E820", VA = "0x180B4FC20", Slot = "19")]
	public void PIDHCLHFGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7F02040", Offset = "0x7F00C40", VA = "0x187F02040", Slot = "20")]
	public void NJDCMFDCCNI(EOGPNMLBPJG ADFFEBFOCBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7F01920", Offset = "0x7F00520", VA = "0x187F01920")]
	private void JHANNDHGHDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7F00000", Offset = "0x7EFEC00", VA = "0x187F00000", Slot = "21")]
	public void AKCKGDFABGK(IIPDOOIGMOL EBMDCHEPJIM, Vector3 PIDIPIIBMGP, Vector3 DKHBAPGMEPM, Vector3 EGNDGLCMLCM, float GLACLAGAINO, float CKENNCOODHE, IReadOnlyList<Camera> GMJEEJJBFLG, NMKBMCNJDOD HKPDLOOMFFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7EFFB60", Offset = "0x7EFE760", VA = "0x187EFFB60", Slot = "22")]
	public void AKCKGDFABGK(NKNDDOIODOM NNGMIJFEMLD, Vector3 PIDIPIIBMGP, Vector3 DKHBAPGMEPM, Vector3 EGNDGLCMLCM, float GLACLAGAINO, float CKENNCOODHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public abstract class KGKBNBDBONE : IEBLKOFFNGF, LAAACBDNNIL, LINLHHGGFAC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly GHPBHILJBAO JHCLOFMDCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private int EGLEMHHKCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	protected Bounds GGKEJKIFFNL;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Bounds IAPNGBBNEDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7F03430", Offset = "0x7F02030", VA = "0x187F03430", Slot = "4")]
		get
		{
			return default(Bounds);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool MHIGJABGGLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xC086C0", Offset = "0xC072C0", VA = "0x180C086C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xC08AC0", Offset = "0xC076C0", VA = "0x180C08AC0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	protected abstract Hash128 GFFOHFAACBP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "25")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int HFKEOGMINFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA78B70", Offset = "0xA77770", VA = "0x180A78B70", Slot = "11")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public BKDPPLPONJM BCBMEPANFAH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x95CEF0", Offset = "0x95BAF0", VA = "0x18095CEF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x95D140", Offset = "0x95BD40", VA = "0x18095D140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool NLEJIJFCKOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xD25100", Offset = "0xD23D00", VA = "0x180D25100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x95A080", Offset = "0x958C80", VA = "0x18095A080")]
	protected KGKBNBDBONE(GHPBHILJBAO EBMDCHEPJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7F03260", Offset = "0x7F01E60", VA = "0x187F03260", Slot = "17")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "18")]
	public virtual bool KPMPEEGIFLC(MLDOPOKHGBO EBMDCHEPJIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7F033F0", Offset = "0x7F01FF0", VA = "0x187F033F0", Slot = "10")]
	public int JMKBIDDMHJF(int OKAKCJBCDHC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	public abstract int BONDIKJEMKP(MGDBPAMBEJB IMJJMIHFOFD);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	public abstract int LAPJOPLFMGI(MGDBPAMBEJB IMJJMIHFOFD);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	public abstract LFGAPABEHMN HHEHLAHMHKN();

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract float LKMMIOAAIAI();

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void EGKHEFNLBPF(MGDBPAMBEJB IMJJMIHFOFD, DHJACBEOCJB CBDENEFPCEB, int KANFLGEMNAD = -1);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract MLDOPOKHGBO EBFDBMJNJMC();

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7F03400", Offset = "0x7F02000", VA = "0x187F03400", Slot = "13")]
	public Hash128 NLKLAGANLON(int IMJJMIHFOFD)
	{
		return default(Hash128);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract IFHPDJDEHJG JACCFIHMKDB();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract OBCFEJJADBD COMKPFFAHDM(MGDBPAMBEJB IMJJMIHFOFD, JobHandle IEMHNEHKIEH);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7F033C0", Offset = "0x7F01FC0", VA = "0x187F033C0", Slot = "12")]
	public OBCFEJJADBD GHOMNLIBKAI(int IMJJMIHFOFD)
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
		[Cpp2IlInjected.Address(RVA = "0x7F062C0", Offset = "0x7F04EC0", VA = "0x187F062C0")]
		public ShapeRendererConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class COAOKFKBMFB
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class IPOLEDIALCJ : IEnumerable<HANIJGBBFMA>, IEnumerable, IEnumerator<HANIJGBBFMA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private HANIJGBBFMA <>2__current;

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
		private HANIJGBBFMA System.Collections.Generic.IEnumerator<RecRoom.Core.Creation.PrimitiveShapeMeshData>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xD30330", Offset = "0xD2EF30", VA = "0x180D30330")]
		[DebuggerHidden]
		public IPOLEDIALCJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7EFF880", Offset = "0x7EFE480", VA = "0x187EFF880", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x7EFF9F0", Offset = "0x7EFE5F0", VA = "0x187EFF9F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7EFF950", Offset = "0x7EFE550", VA = "0x187EFF950", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<HANIJGBBFMA> System.Collections.Generic.IEnumerable<RecRoom.Core.Creation.PrimitiveShapeMeshData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x7EFF950", Offset = "0x7EFE550", VA = "0x187EFF950", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static HANIJGBBFMA[][] HPIJACCLPNN;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static POBMPGOKGAJ CLKGMLIMLBH;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static ShapeRendererConfig CBIOFCFCOFD;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public static ComputeShader MJKFLMEOJCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x7EF3D20", Offset = "0x7EF2920", VA = "0x187EF3D20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public static SkinnedShapeRenderer KDAOAIKKPIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x7EF4E70", Offset = "0x7EF3A70", VA = "0x187EF4E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7EF3D80", Offset = "0x7EF2980", VA = "0x187EF3D80")]
	[DCPAEAFJNOM]
	internal static void AIMKJDEKJHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5480", Offset = "0x7EF4080", VA = "0x187EF5480")]
	public static Mesh MEONCFDCFJN(LKLBAIDKPCN LOONHEDKGAG, int IMJJMIHFOFD = 0)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5520", Offset = "0x7EF4120", VA = "0x187EF5520")]
	public static int MNEEPGMPBFD(LKLBAIDKPCN LOONHEDKGAG, int IMJJMIHFOFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7EF4C70", Offset = "0x7EF3870", VA = "0x187EF4C70")]
	public static POBMPGOKGAJ BGHOKEOLJJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5530", Offset = "0x7EF4130", VA = "0x187EF5530")]
	[IteratorStateMachine(typeof(IPOLEDIALCJ))]
	private static IEnumerable<HANIJGBBFMA> MOMKGJGJEBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7EF3E60", Offset = "0x7EF2A60", VA = "0x187EF3E60")]
	public static HANIJGBBFMA AJAPMKFLAHC(LKLBAIDKPCN LOONHEDKGAG, int IMJJMIHFOFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5460", Offset = "0x7EF4060", VA = "0x187EF5460")]
	public static bool GPHOFDNJLIO(this LKLBAIDKPCN LOONHEDKGAG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7EF3B70", Offset = "0x7EF2770", VA = "0x187EF3B70")]
	public static void ABEBFBOPNGG(LKLBAIDKPCN LOONHEDKGAG, float3 COHPDMAKINF, [Out] CPCEDGFGHAN GLHCAOECPEP, [Out] float3 KPKFKGCKCAO, [Out] float JIKGNKIAJLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5090", Offset = "0x7EF3C90", VA = "0x187EF5090")]
	public static void FEKPEMDJBPF(Vector3 COHPDMAKINF, LKLBAIDKPCN LOONHEDKGAG, [Out] Vector3 KPKFKGCKCAO, [Out] float JIKGNKIAJLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5450", Offset = "0x7EF4050", VA = "0x187EF5450")]
	[HGFAIBFGKGI(0)]
	[CBLJHIHADGM(HEJIADEAGNL.ExitingPlayMode, 0)]
	private static void GJJGIOBHLMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7EF4ED0", Offset = "0x7EF3AD0", VA = "0x187EF4ED0")]
	[HGFAIBFGKGI(0)]
	[CBLJHIHADGM(HEJIADEAGNL.ExitingPlayMode, 0)]
	private static void BHDMNBFKIAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class KGAOLHFBLOJ : LAHFEONIIDI, IDisposable, CBOJDCAGDMO
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly FFGKLPIFKEC<IIPDOOIGMOL, GHPBHILJBAO> EGONDDMJFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly FFGKLPIFKEC<OJNLEJKNADA, KGKBNBDBONE> NFGDFCAAPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly FFGKLPIFKEC<NKNDDOIODOM, PBJMHODEBFG> FMIMGCEHCNG;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public GHPBHILJBAO MPDHFMNHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x7F02B60", Offset = "0x7F01760", VA = "0x187F02B60", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public KGKBNBDBONE MPDHFMNHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x7F02BC0", Offset = "0x7F017C0", VA = "0x187F02BC0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public PBJMHODEBFG MPDHFMNHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7F02C20", Offset = "0x7F01820", VA = "0x187F02C20", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool LLOKLODACHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xC76630", Offset = "0xC75230", VA = "0x180C76630", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xC764F0", Offset = "0xC750F0", VA = "0x180C764F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7F02EA0", Offset = "0x7F01AA0", VA = "0x187F02EA0")]
	public KGAOLHFBLOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7F025F0", Offset = "0x7F011F0", VA = "0x187F025F0", Slot = "21")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7F023E0", Offset = "0x7F00FE0", VA = "0x187F023E0", Slot = "4")]
	public IIPDOOIGMOL BDEPEPJPJNG(ECMOINEGHPA LLDJIJICLJF)
	{
		return default(IIPDOOIGMOL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7F023E0", Offset = "0x7F00FE0", VA = "0x187F023E0", Slot = "5")]
	public IIPDOOIGMOL BDEPEPJPJNG(ECMOINEGHPA LLDJIJICLJF, bool MAGLNOANPDK)
	{
		return default(IIPDOOIGMOL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7F02880", Offset = "0x7F01480", VA = "0x187F02880", Slot = "6")]
	public void IFICAOANFLG(IIPDOOIGMOL EBMDCHEPJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7F02800", Offset = "0x7F01400", VA = "0x187F02800", Slot = "7")]
	public void ENKDEBBIPPD(IIPDOOIGMOL EBMDCHEPJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7F028E0", Offset = "0x7F014E0", VA = "0x187F028E0", Slot = "8")]
	public OJNLEJKNADA IPJLEMEFKLK(IIPDOOIGMOL EBMDCHEPJIM, PPIKABHIOAG LLDJIJICLJF)
	{
		return default(OJNLEJKNADA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7F02A20", Offset = "0x7F01620", VA = "0x187F02A20", Slot = "9")]
	public OJNLEJKNADA KCKNPFDDFLG(IIPDOOIGMOL EBMDCHEPJIM, PBHNFJGKOIJ LLDJIJICLJF)
	{
		return default(OJNLEJKNADA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7F02560", Offset = "0x7F01160", VA = "0x187F02560", Slot = "11")]
	public void CPDIHHFAFFI(OJNLEJKNADA PKCKJCGKEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7F02680", Offset = "0x7F01280", VA = "0x187F02680", Slot = "10")]
	public void EDDLBNGINKJ(OJNLEJKNADA PKCKJCGKEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7F024F0", Offset = "0x7F010F0", VA = "0x187F024F0", Slot = "20")]
	public IEnumerable<Renderer> CBDHJDLNFKE(IIPDOOIGMOL EBMDCHEPJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7F026E0", Offset = "0x7F012E0", VA = "0x187F026E0", Slot = "12")]
	public NKNDDOIODOM EEOFKABPEGK(JODDCIOIFLC LLDJIJICLJF)
	{
		return default(NKNDDOIODOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7F02480", Offset = "0x7F01080", VA = "0x187F02480", Slot = "14")]
	public void BOMOBKKHDCG(NKNDDOIODOM NNGMIJFEMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7F02D80", Offset = "0x7F01980", VA = "0x187F02D80", Slot = "16")]
	public Task PIGACLDFCGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7F02CE0", Offset = "0x7F018E0", VA = "0x187F02CE0", Slot = "17")]
	public Task PGHAOOIGDJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7F02760", Offset = "0x7F01360", VA = "0x187F02760", Slot = "18")]
	public Task EINJCNPGHCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x243CC00", Offset = "0x243B800", VA = "0x18243CC00", Slot = "19")]
	public void HAHNFFCMDCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7F02C80", Offset = "0x7F01880", VA = "0x187F02C80", Slot = "13")]
	public void OKJAOCPOPFI(NKNDDOIODOM NNGMIJFEMLD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface HEOMIHBOIGB
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool MLOBBLDPIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Material NCEFCOONLGG();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Material DLFNGPKFOKC();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Material DABONGEOFOF();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int IEGIHICPBAF(IIENBPKDKHB PCPKKEMBCIC);

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int DFJIDNEJIIC(DLFEHIBNHLA IFFPFJHOMFL);

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NKKDLNKBDND(GameObject CFMCKCBBBKK);

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OBCMKOEGMLI(GameObject CFMCKCBBBKK, bool NIMNNCKEDOD);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class FOOOBHGHAGC
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private static HEOMIHBOIGB FOBBPKHANPP;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public static bool MLOBBLDPIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9AC0", Offset = "0x7EF86C0", VA = "0x187EF9AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9B90", Offset = "0x7EF8790", VA = "0x187EF9B90")]
	public static void MBNJPOKGHEC(HEOMIHBOIGB FHIMODDCKKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9BE0", Offset = "0x7EF87E0", VA = "0x187EF9BE0")]
	public static Material NCEFCOONLGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9A60", Offset = "0x7EF8660", VA = "0x187EF9A60")]
	public static Material DLFNGPKFOKC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9990", Offset = "0x7EF8590", VA = "0x187EF9990")]
	public static Material DABONGEOFOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9B20", Offset = "0x7EF8720", VA = "0x187EF9B20")]
	public static int IEGIHICPBAF(IIENBPKDKHB PCPKKEMBCIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7EF99F0", Offset = "0x7EF85F0", VA = "0x187EF99F0")]
	public static int DFJIDNEJIIC(DLFEHIBNHLA IFFPFJHOMFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9C40", Offset = "0x7EF8840", VA = "0x187EF9C40")]
	public static void NKKDLNKBDND(GameObject CFMCKCBBBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9D10", Offset = "0x7EF8910", VA = "0x187EF9D10")]
	public static void OBCMKOEGMLI(GameObject CFMCKCBBBKK, bool NIMNNCKEDOD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PBJMHODEBFG : LJJHIIGOFKI
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class FBFADCPKFGD : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
		public PBJMHODEBFG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private List<SkinnedShapeRenderer>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		Renderer IEnumerator<Renderer>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xD30330", Offset = "0xD2EF30", VA = "0x180D30330")]
		[DebuggerHidden]
		public FBFADCPKFGD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9900", Offset = "0x7EF8500", VA = "0x187EF9900", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7EF95E0", Offset = "0x7EF81E0", VA = "0x187EF95E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9590", Offset = "0x7EF8190", VA = "0x187EF9590")]
		private void AOMOFJGADBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7EF98B0", Offset = "0x7EF84B0", VA = "0x187EF98B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9800", Offset = "0x7EF8400", VA = "0x187EF9800", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9800", Offset = "0x7EF8400", VA = "0x187EF9800", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly JODDCIOIFLC BPKGFGKPHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly CBOJDCAGDMO GOGGCDOCLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NGONKLBNDMH PKMGCPICCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private List<DLJPLGHMGCG> IPPGMAJOIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<DLJPLGHMGCG> IFCEPELJGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private GameObject EBMLNMCOMEI;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7F05B90", Offset = "0x7F04790", VA = "0x187F05B90")]
	public static PBJMHODEBFG MNKELPCJNDP(JODDCIOIFLC LLDJIJICLJF, CBOJDCAGDMO GOGGCDOCLAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7F061E0", Offset = "0x7F04DE0", VA = "0x187F061E0")]
	private PBJMHODEBFG(JODDCIOIFLC LLDJIJICLJF, CBOJDCAGDMO GOGGCDOCLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7F05CE0", Offset = "0x7F048E0", VA = "0x187F05CE0")]
	public void MPDBLNIHPLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7F06160", Offset = "0x7F04D60", VA = "0x187F06160")]
	[IteratorStateMachine(typeof(FBFADCPKFGD))]
	public IEnumerable<Renderer> NMBAGICBLIL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7F05100", Offset = "0x7F03D00", VA = "0x187F05100", Slot = "4")]
	public void LDHBKAMKMJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7F04E80", Offset = "0x7F03A80", VA = "0x187F04E80")]
	private void EDGLKMIHOFK(Vector3 OEHBGCCAEMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7F04EB0", Offset = "0x7F03AB0", VA = "0x187F04EB0")]
	public void KAFGFLAKMPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DLJPLGHMGCG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private struct DBGEOENIDBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public DHJACBEOCJB DLNIJEDMBLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public MLDOPOKHGBO ONKGBHCHODN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public int DPAOEBLAIGK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class IAANILIDBFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public DLJPLGHMGCG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public int numVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public int numIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public MGDBPAMBEJB lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<DBGEOENIDBO> boneMeshInfos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public IKFMJHEMOMC combinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public IAANILIDBFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7EFF6B0", Offset = "0x7EFE2B0", VA = "0x187EFF6B0")]
		internal JobHandle IAJIPBONKMF()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x7EFF680", Offset = "0x7EFE280", VA = "0x187EFF680")]
		internal void EHAFEAADPFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7EFF710", Offset = "0x7EFE310", VA = "0x187EFF710")]
		internal void LJCDHCMKMLP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private int[] DLHFHENHKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private KJKNPLLHMPI NEPFIGBNMNN;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private static Matrix4x4 LGGLKNLBDPP;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Mesh JDDPHIBIJCF
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x957520", Offset = "0x956120", VA = "0x180957520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int JCNFNBFILJD
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x95B870", Offset = "0x95A470", VA = "0x18095B870")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x95B860", Offset = "0x95A460", VA = "0x18095B860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7C50", Offset = "0x7EF6850", VA = "0x187EF7C50")]
	public void BLENIEBDJKE(List<MLDOPOKHGBO> EDGCBDLLIEH, Matrix4x4[] DDACOOFELAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7ED0", Offset = "0x7EF6AD0", VA = "0x187EF7ED0")]
	public static List<DLJPLGHMGCG> EPPBBCFCJMI(List<GHPBHILJBAO> BJGMHHLMHFI, MGDBPAMBEJB IMJJMIHFOFD, Bounds OLFOCEILLOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8560", Offset = "0x7EF7160", VA = "0x187EF8560")]
	private JobHandle GNDLLGDOIMO(IKFMJHEMOMC JGHBKFDNHCJ, int NAAHENGHIMH, int EIEMIDPEPMN, MGDBPAMBEJB IMJJMIHFOFD, List<DBGEOENIDBO> FINOJBOLIHJ)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7EF88C0", Offset = "0x7EF74C0", VA = "0x187EF88C0")]
	private void HBPIIFACJEN(List<DBGEOENIDBO> FINOJBOLIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8B30", Offset = "0x7EF7730", VA = "0x187EF8B30")]
	private DLJPLGHMGCG(List<DBGEOENIDBO> FINOJBOLIHJ, int NAAHENGHIMH, int EIEMIDPEPMN, MGDBPAMBEJB IMJJMIHFOFD, Bounds OLFOCEILLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7E30", Offset = "0x7EF6A30", VA = "0x187EF7E30", Slot = "4")]
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
		private MaterialPropertyBlock BIONPCGDGNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private DLJPLGHMGCG LDLKDBPEDDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private List<MLDOPOKHGBO> JJNNFMINDGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private RenderTexture JFNFENECLPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private ComputeBuffer PAMGCHNOEPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private ComputeShader BIHGOGNANMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private Matrix4x4[] EKDCDNHJIOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int PCJFAEBIMNI;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer LEGNIIGNOHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x957510", Offset = "0x956110", VA = "0x180957510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int CGGHNFGKBEE
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7F06FF0", Offset = "0x7F05BF0", VA = "0x187F06FF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7F06690", Offset = "0x7F05290", VA = "0x187F06690")]
		public static List<SkinnedShapeRenderer> Create(GameObject EBMDCHEPJIM, List<DLJPLGHMGCG> HMICJGHEICD, List<MLDOPOKHGBO> JJNNFMINDGB, Material LBEFIBKFEIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x7F06920", Offset = "0x7F05520", VA = "0x187F06920")]
		public void Init(DLJPLGHMGCG LDLKDBPEDDB, List<MLDOPOKHGBO> JJNNFMINDGB, Material LBEFIBKFEIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x7F06E90", Offset = "0x7F05A90", VA = "0x187F06E90")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x7F06DF0", Offset = "0x7F059F0", VA = "0x187F06DF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7F06DB0", Offset = "0x7F059B0", VA = "0x187F06DB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7F06F30", Offset = "0x7F05B30", VA = "0x187F06F30")]
		private void PNFEHAJDEHJ(ScriptableRenderContext HJIAOGEIAJO, Camera[] PPCKGADDGAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7F06320", Offset = "0x7F04F20", VA = "0x187F06320")]
		private void BLENIEBDJKE(CommandBuffer KLHMGKEFLPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x959590", Offset = "0x958190", VA = "0x180959590")]
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
