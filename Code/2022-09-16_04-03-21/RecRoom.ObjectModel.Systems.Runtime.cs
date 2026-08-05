using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using Google.Protobuf;
using Mono.Math;
using RecRoom.Components;
using RecRoom.ObjectModel;
using RecRoom.ObjectModel.Systems;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Entities.CodeGeneratedJobForEach;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DebuggerDisplay("Count = {Count}, Capacity = {Capacity}")]
[DefaultMember("Item")]
public sealed class ECDCFAJJCCI<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[DebuggerNonUserCode]
	private sealed class BKPAOMBIHHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly global::ECDCFAJJCCI<T> MIBBAGKEBGA;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public T[] GBOKIJNALFI
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		public BKPAOMBIHHI(global::ECDCFAJJCCI<T> MIBBAGKEBGA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	private sealed class JLHKPGJENNF : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public global::ECDCFAJJCCI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int <count>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "4")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[DebuggerHidden]
		public JLHKPGJENNF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private const int AMHNMKEHJFB = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeArray<T> HGLBDAFDPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private int EPGDKNGMJOE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public T NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private bool MFEILNJHDIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private bool EDOEMNJCOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private bool PDLEOJPJPPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int JKGEEOBIBFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	public ECDCFAJJCCI(int JPMPKCEDKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	public ECDCFAJJCCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	public void JKMEJHNIIKP(int AKLHCIJHJKB, T FJMIPHLNAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	public void NGEIKIGMGGE(int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	public T[] JKBLAANMFMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	private void JPMDICKLDPN(NativeArray<T> FPMNAPBFAMJ, int DDFINIJOFGB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	[IteratorStateMachine(typeof(global::ECDCFAJJCCI<>.JLHKPGJENNF))]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	public int DCILMOLDEAH(T FJMIPHLNAEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	public bool NHIAFFMKOAF(T FJMIPHLNAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	private static void PNDOFPODBKD(int EPJIBMIPBOL, int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	private static void KNAHCDIFIOG(int EPJIBMIPBOL, int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	private static void ACMMOMMNIMF(int EPJIBMIPBOL, int IBIPCEJMDGF, int FKDPJOHPNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	private int GKGOHLGJCNB(int AKLHCIJHJKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	private T DHCBHGCOFLG(int AKLHCIJHJKB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	private void GNLJNEGHCCN(int AKLHCIJHJKB, T FJMIPHLNAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	private void MBJIOPKHGKH(int AKLHCIJHJKB, T FJMIPHLNAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	private void POHBLCFAFOB(int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	private int FLLOOKEMMLJ(int CJMMBFLIBMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	private int KGFNHPGDJGL(int CJMMBFLIBMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	private void KDHHFAKICHK(T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	private void FLJCJLIJHCA(T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	private T IKPOKLCGEJL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	private T OGHODKCKPFL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	private void LDHBCMPHAIJ(int AKLHCIJHJKB, IReadOnlyCollection<T> MGCOKKBNFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	private void DCFBJJMADBH(int AKLHCIJHJKB, int FCDHLMEKFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	private void APGNDABFPGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	public void LPHJPPBEAKE(T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	public void CNIEEDEENEH(T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	public void FLNPMJDEINO(int IBIPCEJMDGF, int FKDPJOHPNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public T JBGGHMFPEEN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	public T FIODMJKFHME()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AAJOBPJHKPG]
public static class KNHEFDHIAFE
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x50CE840", Offset = "0x50CD040", VA = "0x1850CE840")]
	static KNHEFDHIAFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0xC5F820", Offset = "0xC5E020", VA = "0x180C5F820")]
	public static void AFABAMMDGPO<T>(T HOIDFJHLMNC, ref T DPNNIFJNEJJ, EDEBCBMIEIE NIBNAFJNIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x50CE810", Offset = "0x50CD010", VA = "0x1850CE810")]
	public static void AFABAMMDGPO(FixedString32 HOIDFJHLMNC, ref string DPNNIFJNEJJ, EDEBCBMIEIE NIBNAFJNIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x50CE670", Offset = "0x50CCE70", VA = "0x1850CE670")]
	public static void AFABAMMDGPO(string HOIDFJHLMNC, ref FixedString32 DPNNIFJNEJJ, EDEBCBMIEIE NIBNAFJNIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x50CE5D0", Offset = "0x50CCDD0", VA = "0x1850CE5D0")]
	public static void AFABAMMDGPO(FixedString64 HOIDFJHLMNC, ref string DPNNIFJNEJJ, EDEBCBMIEIE NIBNAFJNIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x50CE720", Offset = "0x50CCF20", VA = "0x1850CE720")]
	public static void AFABAMMDGPO(string HOIDFJHLMNC, ref FixedString64 DPNNIFJNEJJ, EDEBCBMIEIE NIBNAFJNIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0xAF8E60", Offset = "0xAF7660", VA = "0x180AF8E60")]
	public static void AFABAMMDGPO(DJCDCPNMAEN HOIDFJHLMNC, ref Vector3 DPNNIFJNEJJ, EDEBCBMIEIE NIBNAFJNIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x50CE6C0", Offset = "0x50CCEC0", VA = "0x1850CE6C0")]
	public static void AFABAMMDGPO(Vector3 HOIDFJHLMNC, ref DJCDCPNMAEN DPNNIFJNEJJ, EDEBCBMIEIE NIBNAFJNIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x50CE550", Offset = "0x50CCD50", VA = "0x1850CE550")]
	public static void AFABAMMDGPO(DLCOHHEAPIG HOIDFJHLMNC, ref Vector4 DPNNIFJNEJJ, EDEBCBMIEIE NIBNAFJNIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x50CE580", Offset = "0x50CCD80", VA = "0x1850CE580")]
	public static void AFABAMMDGPO(Vector4 HOIDFJHLMNC, ref DLCOHHEAPIG DPNNIFJNEJJ, EDEBCBMIEIE NIBNAFJNIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x50CE550", Offset = "0x50CCD50", VA = "0x1850CE550")]
	public static void AFABAMMDGPO(DLCOHHEAPIG HOIDFJHLMNC, ref Quaternion DPNNIFJNEJJ, EDEBCBMIEIE NIBNAFJNIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x50CE580", Offset = "0x50CCD80", VA = "0x1850CE580")]
	public static void AFABAMMDGPO(Quaternion HOIDFJHLMNC, ref DLCOHHEAPIG DPNNIFJNEJJ, EDEBCBMIEIE NIBNAFJNIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x50CE7B0", Offset = "0x50CCFB0", VA = "0x1850CE7B0")]
	public static void AFABAMMDGPO(DJCDCPNMAEN HOIDFJHLMNC, ref float3 DPNNIFJNEJJ, EDEBCBMIEIE NIBNAFJNIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x50CE6C0", Offset = "0x50CCEC0", VA = "0x1850CE6C0")]
	public static void AFABAMMDGPO(float3 HOIDFJHLMNC, ref DJCDCPNMAEN DPNNIFJNEJJ, EDEBCBMIEIE NIBNAFJNIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x50CE790", Offset = "0x50CCF90", VA = "0x1850CE790")]
	public static void AFABAMMDGPO(DLCOHHEAPIG HOIDFJHLMNC, ref float4 DPNNIFJNEJJ, EDEBCBMIEIE NIBNAFJNIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x50CE580", Offset = "0x50CCD80", VA = "0x1850CE580")]
	public static void AFABAMMDGPO(float4 HOIDFJHLMNC, ref DLCOHHEAPIG DPNNIFJNEJJ, EDEBCBMIEIE NIBNAFJNIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x50CE790", Offset = "0x50CCF90", VA = "0x1850CE790")]
	public static void AFABAMMDGPO(DLCOHHEAPIG HOIDFJHLMNC, ref quaternion DPNNIFJNEJJ, EDEBCBMIEIE NIBNAFJNIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x50CE600", Offset = "0x50CCE00", VA = "0x1850CE600")]
	public static void AFABAMMDGPO(quaternion HOIDFJHLMNC, ref DLCOHHEAPIG DPNNIFJNEJJ, EDEBCBMIEIE NIBNAFJNIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x50CE630", Offset = "0x50CCE30", VA = "0x1850CE630")]
	public static void AFABAMMDGPO(Entity HOIDFJHLMNC, ref FMAHEDKOOMM DPNNIFJNEJJ, EDEBCBMIEIE NIBNAFJNIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x50CE7F0", Offset = "0x50CCFF0", VA = "0x1850CE7F0")]
	public static void AFABAMMDGPO(FMAHEDKOOMM HOIDFJHLMNC, ref Entity DPNNIFJNEJJ, EDEBCBMIEIE NIBNAFJNIDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface ICHIOKBIGBA : CAMIJMPEPJA
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	int HHNNMJFIKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KENLICLHJFC DJDCAMAPDEM(Entity NBIJCGHBCCI);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GGMDHHKNIHM(NativeArray<KENLICLHJFC> CEOIMONPOFG, NativeArray<HFDMILLIKNN> ENJDOAHDOJE);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NPCCKHKNNJO(KENLICLHJFC LPPHLKEKIOC);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ANPJJGDKHJE(KENLICLHJFC LPPHLKEKIOC, out Collider OKCFJNOIDBD);
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[MIDOOGOCAPK]
public class IJBGBHOIBMH : ComponentSystem, DKFAOOPHPAH
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FBKJAGMDHMF FJPFHCMMMDD
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6186B0", Offset = "0x616EB0", VA = "0x1806186B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x639660", Offset = "0x637E60", VA = "0x180639660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GIDONOBPNKN BLAHOJHKOBM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6186A0", Offset = "0x616EA0", VA = "0x1806186A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x637290", Offset = "0x635A90", VA = "0x180637290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x50C7090", Offset = "0x50C5890", VA = "0x1850C7090", Slot = "14")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x606E30", Offset = "0x605630", VA = "0x180606E30")]
	public IJBGBHOIBMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CreateAssetMenu]
	public class ObjectModelConfigAsset : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public const string RUNTIME_CONFIG_FOLDER = "ObjectModelConfig";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private EmbodiedObject objectPrefab;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public EmbodiedObject ObjectPrefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xE57980", Offset = "0xE56180", VA = "0x180E57980")]
		public static ObjectModelConfigAsset BIPBKMHLFNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7BE260", Offset = "0x7BCA60", VA = "0x1807BE260")]
		public ObjectModelConfigAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[DOHCKPDOJMD(PAPAHBCPMGP.Default)]
	public static class ObjectModelManager
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[DOHCKPDOJMD(PAPAHBCPMGP.Serialization)]
		public static class Persistence
		{
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public const int EOOIPOMJEJG = 0;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private static readonly FLAFLKKHHEA APOHKGBDLNO;

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xE5CEF0", Offset = "0xE5B6F0", VA = "0x180E5CEF0")]
			public static MCOCAFPBHKN GFLLDOEEJHC(int JJOBCIMKEMK)
			{
				return default(MCOCAFPBHKN);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xE5D080", Offset = "0xE5B880", VA = "0x180E5D080")]
			public static int HEMDHNOHLDI(GameObject KFNNOPCEBCG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xE5D1F0", Offset = "0xE5B9F0", VA = "0x180E5D1F0")]
			[Conditional("DEBUG_BUILD")]
			[Conditional("UNITY_EDITOR")]
			private static void JMNLKMIOHIP(CFBEFPIPHOM LEPHKDIHJFD, int JJOBCIMKEMK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static IDLHNLLMOOO IGEIPKGINDO;

		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private static NIPPBJJLFPM FLIFGDEMFID;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public static IDLHNLLMOOO NGFOBAKDFNP
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xE58B20", Offset = "0xE57320", VA = "0x180E58B20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xE581E0", Offset = "0xE569E0", VA = "0x180E581E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static NIPPBJJLFPM HFEICCLODGI
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xE58EB0", Offset = "0xE576B0", VA = "0x180E58EB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xE58900", Offset = "0xE57100", VA = "0x180E58900")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static bool CBDOMBPIECL
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xE57CC0", Offset = "0xE564C0", VA = "0x180E57CC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static GIDONOBPNKN BLAHOJHKOBM
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xE586E0", Offset = "0xE56EE0", VA = "0x180E586E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static DGGIPLGOKHJ JHMPKHIMHCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xE59140", Offset = "0xE57940", VA = "0x180E59140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static FHCDFMOJBCC FJOJPJBILFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xE58A50", Offset = "0xE57250", VA = "0x180E58A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static FOJPBIGOEBJ COKDEHMBBIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xE58480", Offset = "0xE56C80", VA = "0x180E58480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public static DEGKEFODIJP ABMNDBMJIJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xE58CF0", Offset = "0xE574F0", VA = "0x180E58CF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public static bool PIIGAGDECED
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xE580A0", Offset = "0xE568A0", VA = "0x180E580A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xE58DC0", Offset = "0xE575C0", VA = "0x180E58DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public static bool POCBINAGLEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xE57C60", Offset = "0xE56460", VA = "0x180E57C60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xE588A0", Offset = "0xE570A0", VA = "0x180E588A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public static bool CCBAEHCCBKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xE57B90", Offset = "0xE56390", VA = "0x180E57B90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xE58420", Offset = "0xE56C20", VA = "0x180E58420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public static event Action EBDAALAPLOC
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xE57E80", Offset = "0xE56680", VA = "0x180E57E80")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xE57D80", Offset = "0xE56580", VA = "0x180E57D80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xE59010", Offset = "0xE57810", VA = "0x180E59010")]
		public static CFBEFPIPHOM PGAAHFGOMDE(GameObject KFNNOPCEBCG)
		{
			return default(CFBEFPIPHOM);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xE57BF0", Offset = "0xE563F0", VA = "0x180E57BF0")]
		public static MCOCAFPBHKN DCDNMCENJCL(GameObject KFNNOPCEBCG)
		{
			return default(MCOCAFPBHKN);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xE58790", Offset = "0xE56F90", VA = "0x180E58790")]
		public static BKIEEIBJMKG HONEOBOCGAJ(MCOCAFPBHKN GFKNINEELBB)
		{
			return default(BKIEEIBJMKG);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xE58750", Offset = "0xE56F50", VA = "0x180E58750")]
		public static BKIEEIBJMKG HONEOBOCGAJ(CFBEFPIPHOM LEPHKDIHJFD)
		{
			return default(BKIEEIBJMKG);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xE57A00", Offset = "0xE56200", VA = "0x180E57A00")]
		public static (ByteString, IDisposable) BAGHAKDDGPK()
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xE58550", Offset = "0xE56D50", VA = "0x180E58550")]
		public static (ByteString, IDisposable) HHMIJEBODEF(IEnumerable<CFBEFPIPHOM> KPNLPNEALHL)
		{
			return default((ByteString, IDisposable));
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xE58B80", Offset = "0xE57380", VA = "0x180E58B80")]
		public static bool LNAIEDLKPEB(GameObject KFNNOPCEBCG, out MCOCAFPBHKN GFKNINEELBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xE582B0", Offset = "0xE56AB0", VA = "0x180E582B0")]
		public static bool HCJDBFMGBJC(GameObject KFNNOPCEBCG, out bool NNMGNADFEAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xE57F80", Offset = "0xE56780", VA = "0x180E57F80")]
		private static NIPPBJJLFPM FPENPGNMHAO()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class NBHABIHPNBH
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static readonly FLAFLKKHHEA APOHKGBDLNO;

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x50D36D0", Offset = "0x50D1ED0", VA = "0x1850D36D0")]
	public static NNCLEEGIIBK DAFBLBFDDID(GameObject KFNNOPCEBCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x50D34F0", Offset = "0x50D1CF0", VA = "0x1850D34F0")]
	public static NNCLEEGIIBK DAFBLBFDDID(GameObject KFNNOPCEBCG, MCOCAFPBHKN GFKNINEELBB)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class DisembodiedObjectView : MonoBehaviour, JEBFPKINFDH
	{
		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public CFBEFPIPHOM BNLNJFHLOKF
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x68E570", Offset = "0x68CD70", VA = "0x18068E570", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(CFBEFPIPHOM);
			}
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xE52EF0", Offset = "0xE516F0", VA = "0x180E52EF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x628F80", Offset = "0x627780", VA = "0x180628F80")]
		public DisembodiedObjectView()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[DisallowMultipleComponent]
	[DOHCKPDOJMD(PAPAHBCPMGP.Embodiment)]
	public sealed class EmbodiedObject : MonoBehaviour, NNCLEEGIIBK, JEBFPKINFDH
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private const string NPDIHEGNDOF = "GameplaySpawned";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private CFBEFPIPHOM MEDLGIKFPNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private bool isGameplaySpawned;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private FGDPNBCKGJP KCDMBPDEAMJ;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public CFBEFPIPHOM BNLNJFHLOKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x771F00", Offset = "0x770700", VA = "0x180771F00", Slot = "11")]
			get
			{
				return default(CFBEFPIPHOM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public BKIEEIBJMKG DHANKKIIMNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xE53A40", Offset = "0xE52240", VA = "0x180E53A40", Slot = "4")]
			get
			{
				return default(BKIEEIBJMKG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private GIDONOBPNKN BLAHOJHKOBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xE53110", Offset = "0xE51910", VA = "0x180E53110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private HIPDIEDHHMJ LCEJKDDCKLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xE52FC0", Offset = "0xE517C0", VA = "0x180E52FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public FGDPNBCKGJP HKCNKIGLIMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x65F060", Offset = "0x65D860", VA = "0x18065F060", Slot = "5")]
			get
			{
				return default(FGDPNBCKGJP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool BDHGNDIDKCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6ABFC0", Offset = "0x6AA7C0", VA = "0x1806ABFC0", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x6ABFB0", Offset = "0x6AA7B0", VA = "0x1806ABFB0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<bool> FMBPHFCCOKE
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xE539A0", Offset = "0xE521A0", VA = "0x180E539A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xE53A70", Offset = "0xE52270", VA = "0x180E53A70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xE53040", Offset = "0xE51840", VA = "0x180E53040")]
		internal void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xE53850", Offset = "0xE52050", VA = "0x180E53850", Slot = "13")]
		public void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xE534B0", Offset = "0xE51CB0", VA = "0x180E534B0", Slot = "14")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xE537C0", Offset = "0xE51FC0", VA = "0x180E537C0", Slot = "8")]
		public void OnEmbody(HFEGCOONMAM LMKNNIPOPLE, CFBEFPIPHOM MEDLGIKFPNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xE53840", Offset = "0xE52040", VA = "0x180E53840", Slot = "9")]
		public void OnPreDisembody()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xE53570", Offset = "0xE51D70", VA = "0x180E53570", Slot = "10")]
		public void OnDisembody(bool LGHILPKOFIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xE532E0", Offset = "0xE51AE0", VA = "0x180E532E0")]
		private void MGGJFCMLMIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xE533F0", Offset = "0xE51BF0", VA = "0x180E533F0")]
		private void NNFMMHNMGDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xE53160", Offset = "0xE51960", VA = "0x180E53160")]
		private void LLPAADGNHCK(bool KFKHPBHPOGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x628F80", Offset = "0x627780", VA = "0x180628F80")]
		public EmbodiedObject()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6782E0", Offset = "0x676AE0", VA = "0x1806782E0", Slot = "7")]
		private GameObject GKDGBMNPEFL()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class EntityReference : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public Entity entity;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x628F80", Offset = "0x627780", VA = "0x180628F80")]
		public EntityReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[DisallowMultipleComponent]
	[DOHCKPDOJMD(PAPAHBCPMGP.Registration)]
	public sealed class TransformEntity : MonoBehaviour, JEBFPKINFDH
	{
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private HEIIJIHIAKK prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private CFBEFPIPHOM LEPHKDIHJFD;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public HEIIJIHIAKK AHPMGMONBLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x6EFB50", Offset = "0x6EE350", VA = "0x1806EFB50")]
			get
			{
				return default(HEIIJIHIAKK);
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xBAAFF0", Offset = "0xBA97F0", VA = "0x180BAAFF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public CFBEFPIPHOM BNLNJFHLOKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x771F00", Offset = "0x770700", VA = "0x180771F00", Slot = "4")]
			get
			{
				return default(CFBEFPIPHOM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		internal Entity LLFIHJDDJGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x6186A0", Offset = "0x616EA0", VA = "0x1806186A0")]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		internal FOJPBIGOEBJ COKDEHMBBIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0x6186B0", Offset = "0x616EB0", VA = "0x1806186B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		internal HIPDIEDHHMJ CHAOBDNLKEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xBAAAE0", Offset = "0xBA92E0", VA = "0x180BAAAE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xBAAAD0", Offset = "0xBA92D0", VA = "0x180BAAAD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xBAADC0", Offset = "0xBA95C0", VA = "0x180BAADC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xBAAB50", Offset = "0xBA9350", VA = "0x180BAAB50")]
		internal void LGHMODLDJCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xBAADC0", Offset = "0xBA95C0", VA = "0x180BAADC0")]
		internal void OIFOPNNBDMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xBAAEC0", Offset = "0xBA96C0", VA = "0x180BAAEC0")]
		internal void OnTransformParentChanged()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xBAAFE0", Offset = "0xBA97E0", VA = "0x180BAAFE0")]
		public TransformEntity()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[Flags]
public enum LLAPJDDJMKL
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	ExcludeIgnore = 1,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	ExcludePhoton = 2,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	IncludeMock = 4,
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	IncludeEditor = 8,
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	Default = 1
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[CEFINOONOIN(typeof(NIPPBJJLFPM), new string[] { })]
public class GFKCEJDICGD : NIPPBJJLFPM, IDisposable, HMDOLFAFEDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private bool NMANPNFCCCL;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public FBKJAGMDHMF FJPFHCMMMDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x643F60", Offset = "0x642760", VA = "0x180643F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public ENJAHHPPGPN FFIHAAFFBCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6186B0", Offset = "0x616EB0", VA = "0x1806186B0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x639660", Offset = "0x637E60", VA = "0x180639660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public GIDONOBPNKN BLAHOJHKOBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6186A0", Offset = "0x616EA0", VA = "0x1806186A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x637290", Offset = "0x635A90", VA = "0x180637290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool PIIGAGDECED
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5047730", Offset = "0x5045F30", VA = "0x185047730", Slot = "5")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5047C60", Offset = "0x5046460", VA = "0x185047C60", Slot = "18")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public OCMAMGCKJDD HHEFABBGDDN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x76C9A0", Offset = "0x76B1A0", VA = "0x18076C9A0", Slot = "15")]
		get
		{
			return default(OCMAMGCKJDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x50470D0", Offset = "0x50458D0", VA = "0x1850470D0")]
	public static GFKCEJDICGD BHNJDAHDLKD(KBPHJHJAJFK GPHFNNBDCHL, LLAPJDDJMKL AGFHKAICCAO = LLAPJDDJMKL.ExcludeIgnore)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5047A90", Offset = "0x5046290", VA = "0x185047A90")]
	private static void MCBGMDKCEAK(KBPHJHJAJFK GPHFNNBDCHL, LLAPJDDJMKL AGFHKAICCAO = LLAPJDDJMKL.ExcludeIgnore)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5047240", Offset = "0x5045A40", VA = "0x185047240")]
	private static void BNMIAFOMHPF(KBPHJHJAJFK GPHFNNBDCHL, LLAPJDDJMKL AGFHKAICCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x5047D30", Offset = "0x5046530", VA = "0x185047D30")]
	private static string[] OOEBPLDBIIN(LLAPJDDJMKL AGFHKAICCAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5047E70", Offset = "0x5046670", VA = "0x185047E70")]
	private static bool PDBLADIJFLL(LLAPJDDJMKL AGFHKAICCAO, out string[] CGEKPBABBPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x5047790", Offset = "0x5045F90", VA = "0x185047790")]
	private static void GNEBNEDDAEM(KBPHJHJAJFK GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5047650", Offset = "0x5045E50", VA = "0x185047650", Slot = "16")]
	public void EDNJKGFKFJN(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x1943980", Offset = "0x1942180", VA = "0x181943980")]
	private void FNNKDMJCDCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x50475D0", Offset = "0x5045DD0", VA = "0x1850475D0")]
	private void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
	private void BCKGPNKBBNF(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5047540", Offset = "0x5045D40", VA = "0x185047540", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5047850", Offset = "0x5046050", VA = "0x185047850", Slot = "19")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5047B80", Offset = "0x5046380", VA = "0x185047B80", Slot = "9")]
	public void MFDBKIPJIIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "10")]
	public void PHEODFNJOHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5047A20", Offset = "0x5046220", VA = "0x185047A20", Slot = "11")]
	public void JFFAIIABHKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5047930", Offset = "0x5046130", VA = "0x185047930", Slot = "7")]
	public void JDKEMADGCJE(ByteString DMDONNOOOJK, AAEGGCGNJEL AGFHKAICCAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5047BF0", Offset = "0x50463F0", VA = "0x185047BF0", Slot = "8")]
	public void ODKGJHJEKNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x50478C0", Offset = "0x50460C0", VA = "0x1850478C0", Slot = "12")]
	public void IFPNJNOFHPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x50474D0", Offset = "0x5045CD0", VA = "0x1850474D0", Slot = "13")]
	public void COJMMEGIOJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5046FF0", Offset = "0x50457F0", VA = "0x185046FF0", Slot = "20")]
	public ByteString BAGHAKDDGPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020")]
	private static bool LEPGPGNMAMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public GFKCEJDICGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class CBCPIIIGHFO
{
	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x503F590", Offset = "0x503DD90", VA = "0x18503F590")]
	public static BKIEEIBJMKG KLLAAEAJMPK(this NIPPBJJLFPM FLIFGDEMFID, MCOCAFPBHKN GFKNINEELBB, HEIIJIHIAKK GPMEIOIEDNN)
	{
		return default(BKIEEIBJMKG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x503F6B0", Offset = "0x503DEB0", VA = "0x18503F6B0")]
	public static CLMHOEMCILK NJIEKEKJKAE(this NIPPBJJLFPM FLIFGDEMFID)
	{
		return default(CLMHOEMCILK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x503F7B0", Offset = "0x503DFB0", VA = "0x18503F7B0")]
	public static CFBEFPIPHOM PGAAHFGOMDE(this NIPPBJJLFPM FLIFGDEMFID, Entity NBIJCGHBCCI)
	{
		return default(CFBEFPIPHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x503F850", Offset = "0x503E050", VA = "0x18503F850")]
	public static CFBEFPIPHOM PGAAHFGOMDE(this NIPPBJJLFPM FLIFGDEMFID, MCOCAFPBHKN GFKNINEELBB)
	{
		return default(CFBEFPIPHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x503F490", Offset = "0x503DC90", VA = "0x18503F490")]
	public static MCOCAFPBHKN DCDNMCENJCL(this NIPPBJJLFPM FLIFGDEMFID, CFBEFPIPHOM LEPHKDIHJFD)
	{
		return default(MCOCAFPBHKN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public class KONLOKIOKCA<T> : global::LCHBJNMGJAE<T>, global::KMAABHDKKLE<MCOCAFPBHKN, T>, global::FEFJONNJDKD<MCOCAFPBHKN>, PMNGPOALGLO, IDisposable, NJFOBBNGILB where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly global::FEFJONNJDKD<Entity> IOADAIMHMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly FOJPBIGOEBJ NLJLBCPPCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private Delegate DKBHLOPAKCC;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public string JMBPOHFOGFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x56DB210", Offset = "0x56D9A10", VA = "0x1856DB210", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Type JFKJECAFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x56DC000", Offset = "0x56DA800", VA = "0x1856DC000", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public IHMDKDJBAJD AOKBBEFJPHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x56DAE30", Offset = "0x56D9630", VA = "0x1856DAE30", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int GLFFKNHCEPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x56DB680", Offset = "0x56D9E80", VA = "0x1856DB680", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public CEKBALINDDI MLNLEOBNFKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x56DC060", Offset = "0x56DA860", VA = "0x1856DC060", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public T NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x557A5C0", Offset = "0x5578DC0", VA = "0x18557A5C0", Slot = "24")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x557A600", Offset = "0x5578E00", VA = "0x18557A600", Slot = "25")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event global::MPLPEFLENOP<MCOCAFPBHKN> LCFCFKMCPML
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x56DB720", Offset = "0x56D9F20", VA = "0x1856DB720", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x56DB090", Offset = "0x56D9890", VA = "0x1856DB090", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x5571AC0", Offset = "0x55702C0", VA = "0x185571AC0")]
	public KONLOKIOKCA(global::FEFJONNJDKD<Entity> IOADAIMHMFG, FOJPBIGOEBJ NLJLBCPPCEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x56D9BB0", Offset = "0x56D83B0", VA = "0x1856D9BB0")]
	private Entity ACNIJINECFL(MCOCAFPBHKN GFKNINEELBB)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5579B00", Offset = "0x5578300", VA = "0x185579B00")]
	private MCOCAFPBHKN ACNIJINECFL(Entity NBIJCGHBCCI)
	{
		return default(MCOCAFPBHKN);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x56DC290", Offset = "0x56DAA90", VA = "0x1856DC290", Slot = "4")]
	public T NOBGIOELFLB(MCOCAFPBHKN GFKNINEELBB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x56DB4E0", Offset = "0x56D9CE0", VA = "0x1856DB4E0")]
	public bool HEMBJNPDPPJ(MCOCAFPBHKN GFKNINEELBB, in T JFBNMEBIPAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x56DA1D0", Offset = "0x56D89D0", VA = "0x1856DA1D0")]
	public bool BCDIFACBMLJ(MCOCAFPBHKN GFKNINEELBB, in T JFBNMEBIPAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x56DC190", Offset = "0x56DA990", VA = "0x1856DC190", Slot = "9")]
	public bool NKBMJECLOCI(MCOCAFPBHKN GFKNINEELBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x557CDD0", Offset = "0x557B5D0", VA = "0x18557CDD0", Slot = "26")]
	public object EBDIGNBDMEC(MCOCAFPBHKN GFKNINEELBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x56DBC00", Offset = "0x56DA400", VA = "0x1856DBC00")]
	public bool LBKOCBFDDHB(MCOCAFPBHKN GFKNINEELBB, in object JFBNMEBIPAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x55800F0", Offset = "0x557E8F0", VA = "0x1855800F0")]
	public void NOBGIOELFLB(MCOCAFPBHKN GFKNINEELBB, in IOLFMJOGIFF CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x557DA70", Offset = "0x557C270", VA = "0x18557DA70")]
	public bool HEMBJNPDPPJ(MCOCAFPBHKN GFKNINEELBB, in BJHFEKKLKGB JFBNMEBIPAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x557A970", Offset = "0x5579170", VA = "0x18557A970")]
	public bool BCDIFACBMLJ(MCOCAFPBHKN GFKNINEELBB, in BJHFEKKLKGB JFBNMEBIPAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x556D7E0", Offset = "0x556BFE0", VA = "0x18556D7E0", Slot = "21")]
	public void CIHAKFOOKLK(FPOPHNFOKFP LBEBNBLLNKK, [Optional] object ALLCABKLNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x56DAC90", Offset = "0x56D9490", VA = "0x1856DAC90", Slot = "15")]
	public void CIHAKFOOKLK(MCOCAFPBHKN BAGMDNPKAJL, AEEOODALKLG LBEBNBLLNKK, object ALLCABKLNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x557D230", Offset = "0x557BA30", VA = "0x18557D230", Slot = "14")]
	public bool GBMPOEGKMCI(MCOCAFPBHKN DPNNIFJNEJJ, MCOCAFPBHKN HOIDFJHLMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x1739240", Offset = "0x1737A40", VA = "0x181739240", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x56DCF20", Offset = "0x56DB720", VA = "0x1856DCF20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x56DAF20", Offset = "0x56D9720", VA = "0x1856DAF20")]
	public string EADEMHAIMKE(in BJHFEKKLKGB PLOINAJNNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x56DBA40", Offset = "0x56DA240", VA = "0x1856DBA40")]
	private void KCIEHHPIEJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x56D9C80", Offset = "0x56D8480", VA = "0x1856D9C80")]
	private void AEPLIKNHMPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x56DA400", Offset = "0x56D8C00", VA = "0x1856DA400")]
	private void CAEDHCBFELG(Entity NBIJCGHBCCI, in BJHFEKKLKGB OEFKKBELGHM, in BJHFEKKLKGB JFBNMEBIPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x56DCD60", Offset = "0x56DB560", VA = "0x1856DCD60")]
	private void POBNEDEJELI(Entity NBIJCGHBCCI, in BJHFEKKLKGB OEFKKBELGHM, in BJHFEKKLKGB JFBNMEBIPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x56DCA50", Offset = "0x56DB250", VA = "0x1856DCA50")]
	[Conditional("DEBUG_BUILD")]
	private static void PECFDJMAGHG(Entity NBIJCGHBCCI, MCOCAFPBHKN GFKNINEELBB, string EMMPAJPIILL, string JGLCEOHPBKI, [CallerMemberName] string KLCEMPILFNJ = "")
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x1208F50", Offset = "0x1207750", VA = "0x181208F50", Slot = "5")]
	private bool GOIGLAJNIGD(MCOCAFPBHKN BAGMDNPKAJL, in T JFBNMEBIPAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x1209380", Offset = "0x1207B80", VA = "0x181209380", Slot = "6")]
	private bool GLCGJKALELJ(MCOCAFPBHKN BAGMDNPKAJL, in T JFBNMEBIPAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0xE2AA70", Offset = "0xE29270", VA = "0x180E2AA70", Slot = "23")]
	private string LHOOCGPAMPF(in BJHFEKKLKGB CJMMBFLIBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0xE2A5C0", Offset = "0xE28DC0", VA = "0x180E2A5C0", Slot = "10")]
	private bool NCPLICKBMIJ(MCOCAFPBHKN BAGMDNPKAJL, in object JFBNMEBIPAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0xE2A4A0", Offset = "0xE28CA0", VA = "0x180E2A4A0", Slot = "11")]
	private void BIILDONHICD(MCOCAFPBHKN BAGMDNPKAJL, in IOLFMJOGIFF CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5580940", Offset = "0x557F140", VA = "0x185580940", Slot = "12")]
	private bool OCDIAMGPJAA(MCOCAFPBHKN BAGMDNPKAJL, in BJHFEKKLKGB JFBNMEBIPAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0xE2A680", Offset = "0xE28E80", VA = "0x180E2A680", Slot = "13")]
	private bool LMMOINGKAKA(MCOCAFPBHKN BAGMDNPKAJL, in BJHFEKKLKGB JFBNMEBIPAN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public class BPPGPOODLGE<T> : global::FMGDPJPCCFA<T>, global::KMAABHDKKLE<CFBEFPIPHOM, T>, global::FEFJONNJDKD<CFBEFPIPHOM>, PMNGPOALGLO, IDisposable, HMMELKFLGKD where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly global::FEFJONNJDKD<Entity> IOADAIMHMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly FOJPBIGOEBJ NLJLBCPPCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private Delegate DKBHLOPAKCC;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public string JMBPOHFOGFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x556E8B0", Offset = "0x556D0B0", VA = "0x18556E8B0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Type JFKJECAFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x55704C0", Offset = "0x556ECC0", VA = "0x1855704C0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public IHMDKDJBAJD AOKBBEFJPHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x556DF80", Offset = "0x556C780", VA = "0x18556DF80", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int GLFFKNHCEPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x556F1C0", Offset = "0x556D9C0", VA = "0x18556F1C0", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public CEKBALINDDI MLNLEOBNFKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x55706E0", Offset = "0x556EEE0", VA = "0x1855706E0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public T NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x556C060", Offset = "0x556A860", VA = "0x18556C060", Slot = "23")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x556C170", Offset = "0x556A970", VA = "0x18556C170", Slot = "24")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event global::MPLPEFLENOP<CFBEFPIPHOM> LCFCFKMCPML
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x556F510", Offset = "0x556DD10", VA = "0x18556F510", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x556E3C0", Offset = "0x556CBC0", VA = "0x18556E3C0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5571AC0", Offset = "0x55702C0", VA = "0x185571AC0")]
	public BPPGPOODLGE(global::FEFJONNJDKD<Entity> IOADAIMHMFG, FOJPBIGOEBJ NLJLBCPPCEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x25BD960", Offset = "0x25BC160", VA = "0x1825BD960")]
	private Entity ACNIJINECFL(CFBEFPIPHOM LEPHKDIHJFD)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x556B930", Offset = "0x556A130", VA = "0x18556B930")]
	private CFBEFPIPHOM ACNIJINECFL(Entity NBIJCGHBCCI)
	{
		return default(CFBEFPIPHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5570A40", Offset = "0x556F240", VA = "0x185570A40", Slot = "4")]
	public T NOBGIOELFLB(CFBEFPIPHOM LEPHKDIHJFD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x556EFD0", Offset = "0x556D7D0", VA = "0x18556EFD0")]
	public bool HEMBJNPDPPJ(CFBEFPIPHOM LEPHKDIHJFD, in T JFBNMEBIPAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x556C3E0", Offset = "0x556ABE0", VA = "0x18556C3E0")]
	public bool BCDIFACBMLJ(CFBEFPIPHOM LEPHKDIHJFD, in T JFBNMEBIPAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5570900", Offset = "0x556F100", VA = "0x185570900", Slot = "9")]
	public bool NKBMJECLOCI(CFBEFPIPHOM LEPHKDIHJFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x556E050", Offset = "0x556C850", VA = "0x18556E050", Slot = "25")]
	public object EBDIGNBDMEC(CFBEFPIPHOM LEPHKDIHJFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x556FF20", Offset = "0x556E720", VA = "0x18556FF20")]
	public bool LBKOCBFDDHB(CFBEFPIPHOM LEPHKDIHJFD, in object JFBNMEBIPAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5570F50", Offset = "0x556F750", VA = "0x185570F50")]
	public void NOBGIOELFLB(CFBEFPIPHOM LEPHKDIHJFD, in IOLFMJOGIFF CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x556ED80", Offset = "0x556D580", VA = "0x18556ED80")]
	public bool HEMBJNPDPPJ(CFBEFPIPHOM LEPHKDIHJFD, in BJHFEKKLKGB JFBNMEBIPAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x556C590", Offset = "0x556AD90", VA = "0x18556C590")]
	public bool BCDIFACBMLJ(CFBEFPIPHOM LEPHKDIHJFD, in BJHFEKKLKGB JFBNMEBIPAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x556D7E0", Offset = "0x556BFE0", VA = "0x18556D7E0", Slot = "21")]
	public void CIHAKFOOKLK(FPOPHNFOKFP LBEBNBLLNKK, [Optional] object ALLCABKLNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x556DD20", Offset = "0x556C520", VA = "0x18556DD20", Slot = "15")]
	public void CIHAKFOOKLK(CFBEFPIPHOM BAGMDNPKAJL, AEEOODALKLG LBEBNBLLNKK, object ALLCABKLNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x556E5B0", Offset = "0x556CDB0", VA = "0x18556E5B0", Slot = "14")]
	public bool GBMPOEGKMCI(CFBEFPIPHOM DPNNIFJNEJJ, CFBEFPIPHOM HOIDFJHLMNC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x556F640", Offset = "0x556DE40", VA = "0x18556F640")]
	private void KCIEHHPIEJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x556BCE0", Offset = "0x556A4E0", VA = "0x18556BCE0")]
	private void AEPLIKNHMPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x556D0E0", Offset = "0x556B8E0", VA = "0x18556D0E0")]
	private void CAEDHCBFELG(Entity NBIJCGHBCCI, in BJHFEKKLKGB OEFKKBELGHM, in BJHFEKKLKGB JFBNMEBIPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5571660", Offset = "0x556FE60", VA = "0x185571660")]
	private void POBNEDEJELI(Entity NBIJCGHBCCI, in BJHFEKKLKGB OEFKKBELGHM, in BJHFEKKLKGB JFBNMEBIPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x556E020", Offset = "0x556C820", VA = "0x18556E020", Slot = "22")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5571840", Offset = "0x5570040", VA = "0x185571840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x556C170", Offset = "0x556A970", VA = "0x18556C170", Slot = "5")]
	private bool PIOKEHMPILE(CFBEFPIPHOM BAGMDNPKAJL, in T JFBNMEBIPAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x556F600", Offset = "0x556DE00", VA = "0x18556F600", Slot = "6")]
	private bool JGGEPLBMBNF(CFBEFPIPHOM BAGMDNPKAJL, in T JFBNMEBIPAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x556E470", Offset = "0x556CC70", VA = "0x18556E470", Slot = "10")]
	private bool EPKGNHLMEMH(CFBEFPIPHOM BAGMDNPKAJL, in object JFBNMEBIPAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x556F180", Offset = "0x556D980", VA = "0x18556F180", Slot = "11")]
	private void IDADMBCGNBB(CFBEFPIPHOM BAGMDNPKAJL, in IOLFMJOGIFF CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5570780", Offset = "0x556EF80", VA = "0x185570780", Slot = "12")]
	private bool MPJIEEJGJCD(CFBEFPIPHOM BAGMDNPKAJL, in BJHFEKKLKGB JFBNMEBIPAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x556F5C0", Offset = "0x556DDC0", VA = "0x18556F5C0", Slot = "13")]
	private bool JENNNIJLIDB(CFBEFPIPHOM BAGMDNPKAJL, in BJHFEKKLKGB JFBNMEBIPAN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DPHGPHNEGBI : IDisposable, LHHFLKFIFDL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeArray<EntityRemapUtility.EntityRemapInfo> IAAOHCGIMLK;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public NativeArray<EntityRemapUtility.EntityRemapInfo> JGNNHLILKCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6ABEC0", Offset = "0x6AA6C0", VA = "0x1806ABEC0", Slot = "5")]
		get
		{
			return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x1D4F320", Offset = "0x1D4DB20", VA = "0x181D4F320")]
	public DPHGPHNEGBI(NativeArray<EntityRemapUtility.EntityRemapInfo> IAAOHCGIMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5042060", Offset = "0x5040860", VA = "0x185042060", Slot = "6")]
	public CFBEFPIPHOM HHLMHCFLMDK(CFBEFPIPHOM LEPHKDIHJFD)
	{
		return default(CFBEFPIPHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x346B310", Offset = "0x3469B10", VA = "0x18346B310", Slot = "7")]
	public Entity HHLMHCFLMDK(Entity NBIJCGHBCCI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5041FD0", Offset = "0x50407D0", VA = "0x185041FD0", Slot = "8")]
	public IEnumerable<CFBEFPIPHOM> HHLMHCFLMDK(IEnumerable<CFBEFPIPHOM> KPNLPNEALHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x5041F70", Offset = "0x5040770", VA = "0x185041F70", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[DOHCKPDOJMD(PAPAHBCPMGP.Serialization, new string[] { "Remap" })]
	internal struct SerializationRemapScope : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const string CCHLLAKPDCN = "Remap";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private static readonly FLAFLKKHHEA NNDKFNCIENJ;

		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private static int IBAFDCDPMOA;

		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private static LHHFLKFIFDL GBOBFMNNGDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool ACKBDCBKFDH;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public static NativeArray<EntityRemapUtility.EntityRemapInfo> JGNNHLILKCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xE5E8E0", Offset = "0xE5D0E0", VA = "0x180E5E8E0")]
			get
			{
				return default(NativeArray<EntityRemapUtility.EntityRemapInfo>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public static bool OMLOBFJEOAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xE5E5D0", Offset = "0xE5CDD0", VA = "0x180E5E5D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xE5E470", Offset = "0xE5CC70", VA = "0x180E5E470")]
		public static SerializationRemapScope CNPBBICIOPN()
		{
			return default(SerializationRemapScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xE5EA60", Offset = "0xE5D260", VA = "0x180E5EA60")]
		public SerializationRemapScope(LHHFLKFIFDL JKHJHPMDMAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xE5E4D0", Offset = "0xE5CCD0", VA = "0x180E5E4D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xE5E790", Offset = "0xE5CF90", VA = "0x180E5E790")]
		public static CFBEFPIPHOM HHLMHCFLMDK(CFBEFPIPHOM LEPHKDIHJFD)
		{
			return default(CFBEFPIPHOM);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xE5E660", Offset = "0xE5CE60", VA = "0x180E5E660")]
		public static Entity HHLMHCFLMDK(Entity NBIJCGHBCCI)
		{
			return default(Entity);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[CEFINOONOIN(typeof(DEGKEFODIJP), new string[] { })]
public class FHKJPHHJGBK : DEGKEFODIJP, JIOLBCKAPBA, CMBMJNFKKCN, DKFAOOPHPAH, GHNBGLLDFLL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private FOJPBIGOEBJ NLJLBCPPCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private EntityHierarchyParents GJNHJKBKEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private EntityHierarchyChildren DFGJAHNNJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private EBPKDLGCKDG DJMDBGODMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private ObjectEmbodimentService MDLJNEBAIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private bool NMANPNFCCCL;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public global::FMGDPJPCCFA<CFBEFPIPHOM> OLJDFKOJMEF
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5F9990", Offset = "0x5F8190", VA = "0x1805F9990", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5F9350", Offset = "0x5F7B50", VA = "0x1805F9350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x8179E0", Offset = "0x8161E0", VA = "0x1808179E0", Slot = "13")]
	public void FNNKDMJCDCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x50451E0", Offset = "0x50439E0", VA = "0x1850451E0", Slot = "14")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5044E10", Offset = "0x5043610", VA = "0x185044E10", Slot = "15")]
	public void BCKGPNKBBNF(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5045480", Offset = "0x5043C80", VA = "0x185045480")]
	private CFBEFPIPHOM JOPPPBPGJMA(Entity NBIJCGHBCCI)
	{
		return default(CFBEFPIPHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x50459B0", Offset = "0x50441B0", VA = "0x1850459B0", Slot = "18")]
	public CFBEFPIPHOM PAECMEAAFNB(CFBEFPIPHOM LEPHKDIHJFD)
	{
		return default(CFBEFPIPHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x50457F0", Offset = "0x5043FF0", VA = "0x1850457F0", Slot = "19")]
	public void OLCHMPOLLGP(ref List<CFBEFPIPHOM> BBHLGJGEJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5044FE0", Offset = "0x50437E0", VA = "0x185044FE0", Slot = "20")]
	public IEnumerable<CFBEFPIPHOM> CFCGEAOGLKA(CFBEFPIPHOM LEPHKDIHJFD, bool CPJDMHMNGCL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5045170", Offset = "0x5043970", VA = "0x185045170", Slot = "21")]
	public CFBEFPIPHOM CPPPKAEFNAP(CFBEFPIPHOM LEPHKDIHJFD, int AKLHCIJHJKB)
	{
		return default(CFBEFPIPHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x50453D0", Offset = "0x5043BD0", VA = "0x1850453D0", Slot = "22")]
	public int IMDGMLFCKDH(CFBEFPIPHOM LEPHKDIHJFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x50452B0", Offset = "0x5043AB0", VA = "0x1850452B0", Slot = "7")]
	public int EDJIMEHBLAH(CFBEFPIPHOM LEPHKDIHJFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5044D70", Offset = "0x5043570", VA = "0x185044D70", Slot = "8")]
	public FCCBMJGNNEF AJHEBEBEEGH(CFBEFPIPHOM LEPHKDIHJFD)
	{
		return default(FCCBMJGNNEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x50455F0", Offset = "0x5043DF0", VA = "0x1850455F0", Slot = "23")]
	public IEnumerable<CFBEFPIPHOM> MOAJPFKPOBK(CFBEFPIPHOM LEPHKDIHJFD, bool CPJDMHMNGCL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x50452E0", Offset = "0x5043AE0", VA = "0x1850452E0", Slot = "11")]
	public CFBEFPIPHOM GHFKNMIKJEG(CFBEFPIPHOM KILCGFPNBMC, CFBEFPIPHOM BBAPJHOFLJP)
	{
		return default(CFBEFPIPHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x50454B0", Offset = "0x5043CB0", VA = "0x1850454B0", Slot = "12")]
	public bool MAIKBHHOMHF(CFBEFPIPHOM KILCGFPNBMC, CFBEFPIPHOM BBAPJHOFLJP, out CFBEFPIPHOM JDBIDILANEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5045780", Offset = "0x5043F80", VA = "0x185045780", Slot = "4")]
	public CFBEFPIPHOM MOLCNOANCBK(CFBEFPIPHOM LEPHKDIHJFD)
	{
		return default(CFBEFPIPHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x50455C0", Offset = "0x5043DC0", VA = "0x1850455C0", Slot = "10")]
	public bool MFEJJMDALEL(CFBEFPIPHOM LEPHKDIHJFD, CFBEFPIPHOM ELKNCMDOGDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5044EE0", Offset = "0x50436E0", VA = "0x185044EE0", Slot = "24")]
	public bool BCMMBEKINFE(CFBEFPIPHOM LEPHKDIHJFD, CFBEFPIPHOM CPANDONOICF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5044FB0", Offset = "0x50437B0", VA = "0x185044FB0", Slot = "9")]
	public bool BIPHIMNHBID(CFBEFPIPHOM LEPHKDIHJFD, CFBEFPIPHOM KILCGFPNBMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5045590", Offset = "0x5043D90", VA = "0x185045590", Slot = "5")]
	public bool MEIKIKOFGKA(CFBEFPIPHOM LEPHKDIHJFD, CFBEFPIPHOM CELKNCFBAOE, bool BONIBHBAFFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5044DE0", Offset = "0x50435E0", VA = "0x185044DE0", Slot = "6")]
	public bool BCIMKCBBIFF(CFBEFPIPHOM LEPHKDIHJFD, CFBEFPIPHOM CELKNCFBAOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x817920", Offset = "0x816120", VA = "0x180817920", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public FHKJPHHJGBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class EAEMBLGCFOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private NativeList<IMKIELOKPIN> FJPOCPNIALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private NativeList<GCIIMAMNELL> KDLPCNNELAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private NativeList<IMKIELOKPIN> OPIMMALPHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private bool NMANPNFCCCL;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public NativeList<IMKIELOKPIN> IPJCDJBCAKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6ABEC0", Offset = "0x6AA6C0", VA = "0x1806ABEC0")]
		get
		{
			return default(NativeList<IMKIELOKPIN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NativeList<GCIIMAMNELL> DIFCNAGBEIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x771F00", Offset = "0x770700", VA = "0x180771F00")]
		get
		{
			return default(NativeList<GCIIMAMNELL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public NativeList<IMKIELOKPIN> GEKBIPCIANN
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x638A70", Offset = "0x637270", VA = "0x180638A70")]
		get
		{
			return default(NativeList<IMKIELOKPIN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool OGGCLHGKINP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x50420B0", Offset = "0x50408B0", VA = "0x1850420B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x50423F0", Offset = "0x5040BF0", VA = "0x1850423F0")]
	public EAEMBLGCFOG(Allocator DDJPHGFEOFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x5042130", Offset = "0x5040930", VA = "0x185042130")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5042190", Offset = "0x5040990", VA = "0x185042190")]
	public void KFAGLIPHBHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5042230", Offset = "0x5040A30", VA = "0x185042230")]
	public void NLKJJINIDJF(Entity NBIJCGHBCCI, Entity NHAJDPLICDA, Entity ACODEJEKDBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[CEFINOONOIN(typeof(JHKDIDOGONB), new string[] { })]
[OJBFCHOEMHJ(typeof(FBFMOHPHODB))]
internal class JHKDIDOGONB : DKFAOOPHPAH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly Dictionary<int, EAEMBLGCFOG> FLKCFKNGBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private KCHBCAHHFGL PFKPKGFJONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private FBFMOHPHODB AFJGLEGGBOF;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x50C9B70", Offset = "0x50C8370", VA = "0x1850C9B70", Slot = "4")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x50C9E70", Offset = "0x50C8670", VA = "0x1850C9E70")]
	public EAEMBLGCFOG LENPIOMJOBP(OMOEODCFEGL EMMPAJPIILL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x50C9D60", Offset = "0x50C8560", VA = "0x1850C9D60")]
	public EAEMBLGCFOG LENPIOMJOBP(MIPCILJMDGJ KBHHIDGOLNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x50C9C30", Offset = "0x50C8430", VA = "0x1850C9C30")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x50C99E0", Offset = "0x50C81E0", VA = "0x1850C99E0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x50CA040", Offset = "0x50C8840", VA = "0x1850CA040")]
	public JHKDIDOGONB()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[DOHCKPDOJMD(PAPAHBCPMGP.History)]
	[DebuggerTypeProxy(typeof(ICGHJAJAEBG))]
	public class ActionBuffer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		internal class ICGHJAJAEBG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private readonly ActionBuffer POKOCMHLPLN;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			public int KKHILPEBPDN
			{
				[Cpp2IlInjected.Token(Token = "0x6000155")]
				[Cpp2IlInjected.Address(RVA = "0xE55980", Offset = "0xE54180", VA = "0x180E55980")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public IKDFCFJMMDJ[] PIHHGFEHAIH
			{
				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0xE55800", Offset = "0xE54000", VA = "0x180E55800")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x60E9F0", Offset = "0x60D1F0", VA = "0x18060E9F0")]
			public ICGHJAJAEBG(ActionBuffer HHJJPMKNAIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0xE558A0", Offset = "0xE540A0", VA = "0x180E558A0")]
			[CompilerGenerated]
			private IKDFCFJMMDJ FGAFBDEHLFB(LGDKNEJIEJC MJHIGMCCOPA)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		internal class IKDFCFJMMDJ : FPOPHNFOKFP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private readonly ActionBuffer POKOCMHLPLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private readonly LGDKNEJIEJC MJHIGMCCOPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private List<(DEHDDPNGACK, string, object)> HKICLIFPELN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private INPOMIBOOKM AMCNLEFBMOK;

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public int KKHILPEBPDN
			{
				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0xE55D10", Offset = "0xE54510", VA = "0x180E55D10")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public List<(DEHDDPNGACK, string, object)> CIKMDJFINGN
			{
				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0x6186A0", Offset = "0x616EA0", VA = "0x1806186A0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xE56040", Offset = "0xE54840", VA = "0x180E56040")]
			public IKDFCFJMMDJ(ActionBuffer HHJJPMKNAIK, LGDKNEJIEJC MJHIGMCCOPA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xE55C20", Offset = "0xE54420", VA = "0x180E55C20")]
			private string JDCBCAOBAFK(DEHDDPNGACK DMIIFDEEEIP)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0xE55D60", Offset = "0xE54560", VA = "0x180E55D60")]
			private void NNHCHCFNJFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x4FFC800", Offset = "0x4FFB000", VA = "0x184FFC800", Slot = "4")]
			public void PLCDFANINMD<TKey, T>(global::KMAABHDKKLE<TKey, T> IOADAIMHMFG, [Optional] object ALLCABKLNNG) where T : struct
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private NativeList<byte> OLHHGMIKFBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private readonly Stack<LGDKNEJIEJC> GMHDOLDAPCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly PIFJJDILICO DODJOJJHHNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private readonly LAIILCPKBAD FHGJEPMFKBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private readonly DNHMPLANJOC AFJGLEGGBOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly bool KALMELICGBP;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public AJGLDHBFLPA HLHDNNKPFLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xE4AFC0", Offset = "0xE497C0", VA = "0x180E4AFC0")]
			get
			{
				return default(AJGLDHBFLPA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public int KKHILPEBPDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xE4B000", Offset = "0xE49800", VA = "0x180E4B000")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xE4B4E0", Offset = "0xE49CE0", VA = "0x180E4B4E0")]
		public ActionBuffer(LAIILCPKBAD FHGJEPMFKBJ, DNHMPLANJOC AFJGLEGGBOF, bool KALMELICGBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xE4AEA0", Offset = "0xE496A0", VA = "0x180E4AEA0")]
		public bool GDIFIIOHJKD(out LGDKNEJIEJC MJHIGMCCOPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0xE4AF30", Offset = "0xE49730", VA = "0x180E4AF30")]
		public void IDPJIGKEBOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xE4AB80", Offset = "0xE49380", VA = "0x180E4AB80")]
		public LGDKNEJIEJC FAGONPKNJKM(KAEEGKMKAOK HKICLIFPELN, AINAIEJMCHG LMOAGPFPMDB, uint BLBPBLODIPP)
		{
			return default(LGDKNEJIEJC);
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0xE4AF90", Offset = "0xE49790", VA = "0x180E4AF90")]
		public bool JDIAAPOJLMD(uint BLBPBLODIPP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0xE4A9C0", Offset = "0xE491C0", VA = "0x180E4A9C0")]
		public bool EKNHBKOBNLP(uint BLBPBLODIPP, out LGDKNEJIEJC GPGPHLEMPIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xE4ACE0", Offset = "0xE494E0", VA = "0x180E4ACE0")]
		public void FDIMALGIGOM(LGDKNEJIEJC GPGPHLEMPIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xE4B350", Offset = "0xE49B50", VA = "0x180E4B350")]
		[Conditional("DEBUG_BUILD")]
		private void PEFJHBGBNIP(LGDKNEJIEJC GPGPHLEMPIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xE4A8E0", Offset = "0xE490E0", VA = "0x180E4A8E0")]
		private void AAFECAFKDPE(LGDKNEJIEJC CKHLBNKFAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xE4B040", Offset = "0xE49840", VA = "0x180E4B040")]
		private void NCCBPJBEFDN(INPOMIBOOKM JCABMDFJALK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xE4AE40", Offset = "0xE49640", VA = "0x180E4AE40")]
		private void FLKGJDDNJAG(LGDKNEJIEJC MJHIGMCCOPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xE4B290", Offset = "0xE49A90", VA = "0x180E4B290")]
		private INPOMIBOOKM NCNCKCEPLAK(LGDKNEJIEJC MJHIGMCCOPA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xE4A960", Offset = "0xE49160", VA = "0x180E4A960", Slot = "4")]
		public void Dispose()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
internal class PIFJJDILICO : FPOPHNFOKFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly LAIILCPKBAD FHGJEPMFKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly DNHMPLANJOC AFJGLEGGBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private MCOCAFPBHKN MEDLGIKFPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private INPOMIBOOKM BEONHNLICNI;

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6FEAF0", Offset = "0x6FD2F0", VA = "0x1806FEAF0")]
	public PIFJJDILICO(LAIILCPKBAD FHGJEPMFKBJ, DNHMPLANJOC AFJGLEGGBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5734600", Offset = "0x5732E00", VA = "0x185734600", Slot = "4")]
	public void PLCDFANINMD<TKey, T>(global::KMAABHDKKLE<TKey, T> KNJELNFAEIL, [Optional] object ALLCABKLNNG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0xE5A390", Offset = "0xE58B90", VA = "0x180E5A390")]
	public void CIHAKFOOKLK(DEHDDPNGACK DMIIFDEEEIP, ref INPOMIBOOKM JCABMDFJALK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ABJEGJACCLD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct BLIAEFHKIDP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly ABJEGJACCLD CELKNCFBAOE;

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x503E010", Offset = "0x503C810", VA = "0x18503E010")]
		public BLIAEFHKIDP(ABJEGJACCLD CELKNCFBAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x503DF20", Offset = "0x503C720", VA = "0x18503DF20", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	protected KAEEGKMKAOK HKICLIFPELN;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public KAEEGKMKAOK CIKMDJFINGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xB6A210", Offset = "0xB68A10", VA = "0x180B6A210")]
		get
		{
			return default(KAEEGKMKAOK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool EDKBEOFIDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x5038F30", Offset = "0x5037730", VA = "0x185038F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5038FB0", Offset = "0x50377B0", VA = "0x185038FB0")]
	public ABJEGJACCLD(KAEEGKMKAOK.KMEHOBEMLIA DLFFDDECBCI = KAEEGKMKAOK.KMEHOBEMLIA.Last)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5038D30", Offset = "0x5037530", VA = "0x185038D30")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x5038D40", Offset = "0x5037540", VA = "0x185038D40")]
	public void JDCINKDFFNF(MCOCAFPBHKN MEDLGIKFPNL, MABIDPJIHBP BNEGJHHOEJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x5038F40", Offset = "0x5037740", VA = "0x185038F40")]
	public void OPPLOKABCLC(MCOCAFPBHKN MEDLGIKFPNL, MIPCILJMDGJ KBHHIDGOLNC, in BJHFEKKLKGB JFBNMEBIPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5038C60", Offset = "0x5037460", VA = "0x185038C60")]
	public void AEKFCCGOHEB(MCOCAFPBHKN MEDLGIKFPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5038B80", Offset = "0x5037380", VA = "0x185038B80")]
	public void AEFDAAEMODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5038E20", Offset = "0x5037620", VA = "0x185038E20")]
	public void LBKLLANPPNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x4071780", Offset = "0x406FF80", VA = "0x184071780", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5038F00", Offset = "0x5037700", VA = "0x185038F00")]
	public BLIAEFHKIDP LGKPDPNHBOL()
	{
		return default(BLIAEFHKIDP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct DEHDDPNGACK : IComparable<DEHDDPNGACK>, IEquatable<DEHDDPNGACK>
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly DEHDDPNGACK EOOIPOMJEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public MCOCAFPBHKN MEDLGIKFPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public MIPCILJMDGJ KBHHIDGOLNC;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool CPNLIKCPMHB
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x5041B20", Offset = "0x5040320", VA = "0x185041B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x76F510", Offset = "0x76DD10", VA = "0x18076F510")]
	public DEHDDPNGACK(MCOCAFPBHKN MEDLGIKFPNL, MIPCILJMDGJ KBHHIDGOLNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5041C60", Offset = "0x5040460", VA = "0x185041C60")]
	public void JKMNAOJFPCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5041AE0", Offset = "0x50402E0", VA = "0x185041AE0", Slot = "4")]
	public int CompareTo(DEHDDPNGACK ALBOAABJIJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x5041D00", Offset = "0x5040500", VA = "0x185041D00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x5041B30", Offset = "0x5040330", VA = "0x185041B30", Slot = "0")]
	public override bool Equals(object DEGGOOGCHFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5041BD0", Offset = "0x50403D0", VA = "0x185041BD0", Slot = "5")]
	public bool Equals(DEHDDPNGACK ALBOAABJIJF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5041C70", Offset = "0x5040470", VA = "0x185041C70")]
	public static bool LLPKNBIICCC(DEHDDPNGACK MEHHMGBDHKJ, DEHDDPNGACK MLOFKBADEJB)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5041CB0", Offset = "0x50404B0", VA = "0x185041CB0")]
	public static bool PNNBKKFLHKP(DEHDDPNGACK MEHHMGBDHKJ, DEHDDPNGACK MLOFKBADEJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5041C20", Offset = "0x5040420", VA = "0x185041C20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class IBPBFBKDJCD : AEEOODALKLG
{
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static readonly FLAFLKKHHEA APOHKGBDLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private LAIILCPKBAD FHGJEPMFKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private MCOCAFPBHKN MEDLGIKFPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private OMJIOCDDDDJ MBCGBGIEAEF;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x50C6B80", Offset = "0x50C5380", VA = "0x1850C6B80")]
	public void FCLAMECHFIJ(MCOCAFPBHKN MEDLGIKFPNL, LAIILCPKBAD FHGJEPMFKBJ, OMJIOCDDDDJ MBCGBGIEAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x50C6AC0", Offset = "0x50C52C0", VA = "0x1850C6AC0", Slot = "4")]
	private void DAADAHGCNMP(PMNGPOALGLO IOADAIMHMFG, in BJHFEKKLKGB CJMMBFLIBMO, object ALLCABKLNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public IBPBFBKDJCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class EMGEAIMGJNO
{
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x50443E0", Offset = "0x5042BE0", VA = "0x1850443E0")]
	public static void DJLGKBMBCLL(KAEEGKMKAOK HKICLIFPELN, DEHDDPNGACK DMIIFDEEEIP, MABIDPJIHBP BNEGJHHOEJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x50445D0", Offset = "0x5042DD0", VA = "0x1850445D0")]
	public static void FMLEHECOFID(KAEEGKMKAOK HKICLIFPELN, DEHDDPNGACK DMIIFDEEEIP, in BJHFEKKLKGB JFBNMEBIPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x50446C0", Offset = "0x5042EC0", VA = "0x1850446C0")]
	public static void KAAFCBHALKM(KAEEGKMKAOK HKICLIFPELN, DEHDDPNGACK DMIIFDEEEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5044500", Offset = "0x5042D00", VA = "0x185044500")]
	public static void ENGADCMPLFA(KAEEGKMKAOK HKICLIFPELN, DEHDDPNGACK DMIIFDEEEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5044710", Offset = "0x5042F10", VA = "0x185044710")]
	public static MABIDPJIHBP PCNDPCIFGIP(KAEEGKMKAOK HKICLIFPELN, DEHDDPNGACK DMIIFDEEEIP)
	{
		return default(MABIDPJIHBP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x1C33930", Offset = "0x1C32130", VA = "0x181C33930")]
	public static T PHNNEPCLCFD<T>(KAEEGKMKAOK HKICLIFPELN, DEHDDPNGACK DMIIFDEEEIP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x1C33960", Offset = "0x1C32160", VA = "0x181C33960")]
	public static T PHNNEPCLCFD<T>(ref INPOMIBOOKM DMDONNOOOJK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5044760", Offset = "0x5042F60", VA = "0x185044760")]
	public static MABIDPJIHBP PCNDPCIFGIP(ref INPOMIBOOKM DMDONNOOOJK)
	{
		return default(MABIDPJIHBP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[CEFINOONOIN(typeof(OMJIOCDDDDJ), new string[] { })]
[DLFDCKAKPAE(typeof(FHCDFMOJBCC))]
public class OMJIOCDDDDJ : DKFAOOPHPAH, IDisposable, FHCDFMOJBCC
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	private enum KIMEDFIAHNG
	{
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		Undoing,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		Normal,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Redoing
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct AGKOKDBHAPB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly KIMEDFIAHNG JMOGOCBDLAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly OMJIOCDDDDJ CCOJAKINIDK;

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x50C43A0", Offset = "0x50C2BA0", VA = "0x1850C43A0")]
		public AGKOKDBHAPB(OMJIOCDDDDJ CCOJAKINIDK, bool GLOACLAIGNA, uint KAGEGNEPBEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x50C4370", Offset = "0x50C2B70", VA = "0x1850C4370", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class JNKAKMGPDAC
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public struct BMGNJGPKJLL : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private readonly JNKAKMGPDAC LNGJAMBEIJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private readonly bool DFDHMBJJIOD;

			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x50C4AD0", Offset = "0x50C32D0", VA = "0x1850C4AD0")]
			public BMGNJGPKJLL(JNKAKMGPDAC LNGJAMBEIJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x50C4AA0", Offset = "0x50C32A0", VA = "0x1850C4AA0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public struct KGIDFBMMIML : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private readonly JNKAKMGPDAC LNGJAMBEIJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private readonly bool DFDHMBJJIOD;

			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x50CE4F0", Offset = "0x50CCCF0", VA = "0x1850CE4F0")]
			public KGIDFBMMIML(JNKAKMGPDAC LNGJAMBEIJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x50C4AA0", Offset = "0x50C32A0", VA = "0x1850C4AA0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private readonly OMJIOCDDDDJ MBCGBGIEAEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private bool NNHCAFCEKMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int KOJGJEGBPGH;

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x50CB110", Offset = "0x50C9910", VA = "0x1850CB110")]
		public JNKAKMGPDAC(OMJIOCDDDDJ MBCGBGIEAEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x50CB040", Offset = "0x50C9840", VA = "0x1850CB040")]
		public bool ADHKAADLIKC(MCOCAFPBHKN MEDLGIKFPNL, MIPCILJMDGJ KBHHIDGOLNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x50CB0C0", Offset = "0x50C98C0", VA = "0x1850CB0C0")]
		public KGIDFBMMIML KIBCDAGPKKM()
		{
			return default(KGIDFBMMIML);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x50CB070", Offset = "0x50C9870", VA = "0x1850CB070")]
		public BMGNJGPKJLL CMNAPIDLPGK()
		{
			return default(BMGNJGPKJLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class EHAMOIAEPEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public OMJIOCDDDDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public UndoAction target;

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public EHAMOIAEPEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x50C5760", Offset = "0x50C3F60", VA = "0x1850C5760")]
		internal RedoAction <Undo>b__0()
		{
			return default(RedoAction);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class ENHOAHACNHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public OMJIOCDDDDJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public RedoAction target;

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public ENHOAHACNHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x50C57D0", Offset = "0x50C3FD0", VA = "0x1850C57D0")]
		internal UndoAction <Redo>b__0()
		{
			return default(UndoAction);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class AIONCMJDNGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public AIONCMJDNGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x50C4410", Offset = "0x50C2C10", VA = "0x1850C4410")]
		internal bool <SyncProperties>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly FLAFLKKHHEA APOHKGBDLNO;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static readonly UndoAction GLMIPBOJDCA;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static readonly RedoAction CMAIFEHLBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private ABJEGJACCLD OGEJIHJGEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private ActionBuffer OBCOKNIGBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private ActionBuffer FEOOCFHKHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private KCHBCAHHFGL PFKPKGFJONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private AAPGCMMFDCP EOGKNBGMCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private TransformOwnershipPhase LLHFKMDNGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private AINAIEJMCHG LMOAGPFPMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private KIMEDFIAHNG FODAHLOLEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private uint IOGJOJDGMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private uint EODJNIFONEJ;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private JNKAKMGPDAC ANNEKHAJNAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x61B9D0", Offset = "0x61A1D0", VA = "0x18061B9D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool KODDJCPCLLO
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x50D7470", Offset = "0x50D5C70", VA = "0x1850D7470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool KBBDFALLGBC
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x50D7120", Offset = "0x50D5920", VA = "0x1850D7120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool NGKNNJCBNNC
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x50D6F50", Offset = "0x50D5750", VA = "0x1850D6F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public int MAKNDMENOIB
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x50D75E0", Offset = "0x50D5DE0", VA = "0x1850D75E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public int OKLCCFKICPK
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x50D75C0", Offset = "0x50D5DC0", VA = "0x1850D75C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	private bool DIONDFIIFPH
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x50D6540", Offset = "0x50D4D40", VA = "0x1850D6540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	private bool KOLEOIJLEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x50D6890", Offset = "0x50D5090", VA = "0x1850D6890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool LHDOFMLIPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x630BF0", Offset = "0x62F3F0", VA = "0x180630BF0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7846C0", Offset = "0x782EC0", VA = "0x1807846C0", Slot = "13")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private ActionBuffer IJOIPCOFDFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x50D68A0", Offset = "0x50D50A0", VA = "0x1850D68A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	public event Action CGBNKPBKOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x50D7520", Offset = "0x50D5D20", VA = "0x1850D7520", Slot = "10")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x50D6EB0", Offset = "0x50D56B0", VA = "0x1850D6EB0", Slot = "11")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	public event Action NAKOMELMOCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x50D7820", Offset = "0x50D6020", VA = "0x1850D7820")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x50D7170", Offset = "0x50D5970", VA = "0x1850D7170")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x50D7AD0", Offset = "0x50D62D0", VA = "0x1850D7AD0")]
	public OMJIOCDDDDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x50D69A0", Offset = "0x50D51A0", VA = "0x1850D69A0", Slot = "4")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x50D68B0", Offset = "0x50D50B0", VA = "0x1850D68B0", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x50D74A0", Offset = "0x50D5CA0", VA = "0x1850D74A0", Slot = "14")]
	public IDisposable LNJBJJIDLIP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x50D6810", Offset = "0x50D5010", VA = "0x1850D6810", Slot = "9")]
	public IDisposable BPIPLGJBJAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x50D6D10", Offset = "0x50D5510", VA = "0x1850D6D10", Slot = "6")]
	public UndoAction FAGONPKNJKM()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x50D6640", Offset = "0x50D4E40", VA = "0x1850D6640", Slot = "15")]
	public RedoAction ADHHPMDACID()
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x50D7790", Offset = "0x50D5F90", VA = "0x1850D7790", Slot = "16")]
	public UndoAction OKFJFAKGOAI()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x50D6550", Offset = "0x50D4D50", VA = "0x1850D6550", Slot = "7")]
	public RedoAction ADHHPMDACID(UndoAction GPGPHLEMPIJ)
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x50D76A0", Offset = "0x50D5EA0", VA = "0x1850D76A0", Slot = "8")]
	public UndoAction OKFJFAKGOAI(RedoAction GPGPHLEMPIJ)
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x50D79B0", Offset = "0x50D61B0", VA = "0x1850D79B0")]
	public bool PMKMAEDCHBK(PDNOMKJLIJL BNMFAFGFBJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x50D7020", Offset = "0x50D5820", VA = "0x1850D7020", Slot = "17")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x50D7070", Offset = "0x50D5870", VA = "0x1850D7070")]
	public void JDCINKDFFNF(MCOCAFPBHKN MEDLGIKFPNL, MABIDPJIHBP BNEGJHHOEJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x50D78C0", Offset = "0x50D60C0", VA = "0x1850D78C0")]
	public void OPPLOKABCLC(MCOCAFPBHKN MEDLGIKFPNL, MIPCILJMDGJ KBHHIDGOLNC, in BJHFEKKLKGB JFBNMEBIPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x50D66D0", Offset = "0x50D4ED0", VA = "0x1850D66D0")]
	public void AEKFCCGOHEB(MCOCAFPBHKN MEDLGIKFPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x50D7210", Offset = "0x50D5A10", VA = "0x1850D7210")]
	private void KBICBKMIAMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x50D6FE0", Offset = "0x50D57E0", VA = "0x1850D6FE0")]
	private void HJANEHLMFAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x50D7990", Offset = "0x50D6190", VA = "0x1850D7990")]
	private void PGAKCHMOMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x50D6DC0", Offset = "0x50D55C0", VA = "0x1850D6DC0")]
	private LGDKNEJIEJC FFBLCNFGNLM()
	{
		return default(LGDKNEJIEJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x50D67F0", Offset = "0x50D4FF0", VA = "0x1850D67F0")]
	private uint AOBNKFDLCBN()
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x50D6DA0", Offset = "0x50D55A0", VA = "0x1850D6DA0")]
	private bool FEKMJFGAHKA(out LGDKNEJIEJC MJHIGMCCOPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x50D6770", Offset = "0x50D4F70", VA = "0x1850D6770")]
	private bool AKLBGJGLBJE(out LGDKNEJIEJC MJHIGMCCOPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x50D6790", Offset = "0x50D4F90", VA = "0x1850D6790")]
	private RedoAction AMFGNDCLGMH(LGDKNEJIEJC MJHIGMCCOPA)
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x50D6F80", Offset = "0x50D5780", VA = "0x1850D6F80")]
	private UndoAction GJOHFPEOPOI(LGDKNEJIEJC MJHIGMCCOPA)
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x50D6280", Offset = "0x50D4A80", VA = "0x1850D6280")]
	private LGDKNEJIEJC AAFECAFKDPE(LGDKNEJIEJC MJHIGMCCOPA, ActionBuffer KDNIOOGINFA, bool GLOACLAIGNA)
	{
		return default(LGDKNEJIEJC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x50D6B50", Offset = "0x50D5350", VA = "0x1850D6B50")]
	private void EGJAAPMJGHP(Action MJHIGMCCOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0xA893B0", Offset = "0xA87BB0", VA = "0x180A893B0")]
	private T EGJAAPMJGHP<T>(Func<T> JBFLKEELCDJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x50D7630", Offset = "0x50D5E30", VA = "0x1850D7630")]
	private AGKOKDBHAPB NNNKFOLDEJI(bool GLOACLAIGNA, uint KAGEGNEPBEI)
	{
		return default(AGKOKDBHAPB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x50D7250", Offset = "0x50D5A50", VA = "0x1850D7250")]
	[CompilerGenerated]
	private UndoAction KCEDBFPNNID()
	{
		return default(UndoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x50D7350", Offset = "0x50D5B50", VA = "0x1850D7350")]
	[CompilerGenerated]
	private RedoAction KINKFGIOHLA()
	{
		return default(RedoAction);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x50D6C00", Offset = "0x50D5400", VA = "0x1850D6C00")]
	[CompilerGenerated]
	private UndoAction EOHFCPJEILL()
	{
		return default(UndoAction);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public struct KAEEGKMKAOK : IEnumerable<DEHDDPNGACK>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public enum KMEHOBEMLIA
	{
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		Last,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		First
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private struct DJBFAPLOMNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private readonly KAEEGKMKAOK BAKFHBILFME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private readonly AINAIEJMCHG LMOAGPFPMDB;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x50C5680", Offset = "0x50C3E80", VA = "0x1850C5680")]
		public DJBFAPLOMNL(KAEEGKMKAOK BAKFHBILFME, AINAIEJMCHG LMOAGPFPMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x50C50F0", Offset = "0x50C38F0", VA = "0x1850C50F0")]
		public void GBLKABNEKBK(NativeList<byte> ILAPMFLBPJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x50C50A0", Offset = "0x50C38A0", VA = "0x1850C50A0")]
		private void FLKDDNDMGPD(DEHDDPNGACK DMIIFDEEEIP, ref IJFMDKMPGJM JCFPMBGDIAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x50C53B0", Offset = "0x50C3BB0", VA = "0x1850C53B0")]
		private void HLOGFMBBNBD(DEHDDPNGACK DMIIFDEEEIP, ref IJFMDKMPGJM JCFPMBGDIAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x50C55A0", Offset = "0x50C3DA0", VA = "0x1850C55A0")]
		private NativeArray<byte> PGBGHFPLNPG(NativeList<byte> ILAPMFLBPJO)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x50C4FD0", Offset = "0x50C37D0", VA = "0x1850C4FD0")]
		private NativeArray<byte> FLCNNMCPKHE(NativeList<byte> ILAPMFLBPJO, int ABGIPDMABIG)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x50C4DB0", Offset = "0x50C35B0", VA = "0x1850C4DB0")]
		private int DFMFPLNNGLG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x50C5440", Offset = "0x50C3C40", VA = "0x1850C5440")]
		private bool IDHBBEMMILF(DEHDDPNGACK DMIIFDEEEIP, out NativeArray<byte> CGLMDKMDBCI)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public struct BIDPLLGJLNI : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private NativeList<byte> DMDONNOOOJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private KAEEGKMKAOK BAKFHBILFME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly DEHDDPNGACK MOLPKNIJMDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly int MMECDMIFJKL;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x50C4730", Offset = "0x50C2F30", VA = "0x1850C4730")]
		internal BIDPLLGJLNI(KAEEGKMKAOK BAKFHBILFME, DEHDDPNGACK MOLPKNIJMDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x50C46F0", Offset = "0x50C2EF0", VA = "0x1850C46F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x50C4500", Offset = "0x50C2D00", VA = "0x1850C4500")]
		public void AELGPMKKMHL(NativeArray<byte> CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x50C44A0", Offset = "0x50C2CA0", VA = "0x1850C44A0")]
		public void ACFAMILIBGE(NativeArray<byte> CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x50C4720", Offset = "0x50C2F20", VA = "0x1850C4720")]
		public void HLOGFMBBNBD(in BJHFEKKLKGB CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xC52A50", Offset = "0xC51250", VA = "0x180C52A50")]
		public void HLOGFMBBNBD<T>(T CJMMBFLIBMO) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x50C4680", Offset = "0x50C2E80", VA = "0x1850C4680")]
		private void BOMNJOOOGNC(int CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x50C45C0", Offset = "0x50C2DC0", VA = "0x1850C45C0")]
		private void BOMNJOOOGNC(in BJHFEKKLKGB CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x50C4560", Offset = "0x50C2D60", VA = "0x1850C4560")]
		private unsafe void BOMNJOOOGNC(void* OLIOEEOLCBP, int ABGIPDMABIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x50C4500", Offset = "0x50C2D00", VA = "0x1850C4500")]
		private void BOMNJOOOGNC(NativeArray<byte> HOIDFJHLMNC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct LJIFAGLCNHB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private KAEEGKMKAOK BAKFHBILFME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private NativeArray<byte> DMDONNOOOJK;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x50D02F0", Offset = "0x50CEAF0", VA = "0x1850D02F0")]
		internal LJIFAGLCNHB(KAEEGKMKAOK BAKFHBILFME, NativeArray<byte> DMDONNOOOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x50D01F0", Offset = "0x50CE9F0", VA = "0x1850D01F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x50D0100", Offset = "0x50CE900", VA = "0x1850D0100")]
		public NativeArray<byte> BDOHIHHKCNO(int ABGIPDMABIG)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x50D0280", Offset = "0x50CEA80", VA = "0x1850D0280")]
		public NativeArray<byte> NPFIGCIJCNJ()
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1C40640", Offset = "0x1C3EE40", VA = "0x181C40640")]
		public T IDJGKALFFNN<T>() where T : struct
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x50D0200", Offset = "0x50CEA00", VA = "0x1850D0200")]
		public void IDJGKALFFNN(in IOLFMJOGIFF CJMMBFLIBMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public struct ENLNIPAPLCN : IEnumerator<DEHDDPNGACK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly NativeArray<DEHDDPNGACK> FPMNAPBFAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int AKLHCIJHJKB;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public DEHDDPNGACK HLHDNNKPFLO
		{
			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x50C5960", Offset = "0x50C4160", VA = "0x1850C5960", Slot = "4")]
			get
			{
				return default(DEHDDPNGACK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x50C5910", Offset = "0x50C4110", VA = "0x1850C5910", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x1131DA0", Offset = "0x11305A0", VA = "0x181131DA0")]
		internal ENLNIPAPLCN(NativeArray<DEHDDPNGACK> HOIDFJHLMNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x50C5840", Offset = "0x50C4040", VA = "0x1850C5840", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x50C58C0", Offset = "0x50C40C0", VA = "0x1850C58C0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private struct KOAKNNFCNJC : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private const int LKAPGMAHIMI = 0;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private const int KAPMCGLEJGM = 1;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private const int MCLNOFIPFJJ = 2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private NativeArray<int> DMDONNOOOJK;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public int MHHLEFKBIFI
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x50CEE80", Offset = "0x50CD680", VA = "0x1850CEE80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x3B660A0", Offset = "0x3B648A0", VA = "0x183B660A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public KMEHOBEMLIA KKNMBBNNGNF
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x50CEE10", Offset = "0x50CD610", VA = "0x1850CEE10")]
			get
			{
				return default(KMEHOBEMLIA);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x50CEE60", Offset = "0x50CD660", VA = "0x1850CEE60")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool EDKBEOFIDNO
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x50CEEE0", Offset = "0x50CD6E0", VA = "0x1850CEEE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x50CEDA0", Offset = "0x50CD5A0", VA = "0x1850CEDA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool HNPCPFCFMOG
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x50CEE00", Offset = "0x50CD600", VA = "0x1850CEE00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x50CEEC0", Offset = "0x50CD6C0", VA = "0x1850CEEC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x50CEEF0", Offset = "0x50CD6F0", VA = "0x1850CEEF0")]
		public KOAKNNFCNJC(KMEHOBEMLIA DLFFDDECBCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x50CEE90", Offset = "0x50CD690", VA = "0x1850CEE90")]
		private int NOBGIOELFLB(int IBIPCEJMDGF, int BPLIBLLAEJE = 1)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x50CEE20", Offset = "0x50CD620", VA = "0x1850CEE20")]
		private void HEMBJNPDPPJ(int IBIPCEJMDGF, int CJMMBFLIBMO, int BPLIBLLAEJE = 1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x50CEDC0", Offset = "0x50CD5C0", VA = "0x1850CEDC0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private const int JFLNJIFFONI = -1;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private const int FIEDGGHEJMI = 0;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static readonly DEHDDPNGACK JECAKJLIGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private NativeHashMap<DEHDDPNGACK, int> MHNGOJDMBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private NativeList<DEHDDPNGACK> HKICLIFPELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private NativeList<int> DIFJIBDFPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private NativeList<byte> DDPFEDBHMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private NativeList<byte> DMDONNOOOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private KOAKNNFCNJC IEOIKHEEPLI;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool EDKBEOFIDNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x50CBEF0", Offset = "0x50CA6F0", VA = "0x1850CBEF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool OGGCLHGKINP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x50CB700", Offset = "0x50C9F00", VA = "0x1850CB700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int MHHLEFKBIFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x50CBD20", Offset = "0x50CA520", VA = "0x1850CBD20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int BIPDFAKOKPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x50CB540", Offset = "0x50C9D40", VA = "0x1850CB540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x50CB4E0", Offset = "0x50C9CE0", VA = "0x1850CB4E0")]
	public static KAEEGKMKAOK BHNJDAHDLKD(KMEHOBEMLIA DLFFDDECBCI = KMEHOBEMLIA.Last, int NKPHNAOFMOB = 16, int MECGPDLPBKK = 256)
	{
		return default(KAEEGKMKAOK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x50CC0E0", Offset = "0x50CA8E0", VA = "0x1850CC0E0")]
	private KAEEGKMKAOK(KMEHOBEMLIA DLFFDDECBCI, int NKPHNAOFMOB, int MECGPDLPBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x50CB580", Offset = "0x50C9D80", VA = "0x1850CB580", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x50CBB00", Offset = "0x50CA300", VA = "0x1850CBB00")]
	public BIDPLLGJLNI IONHNFOLGKH(DEHDDPNGACK MOLPKNIJMDK)
	{
		return default(BIDPLLGJLNI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x50CB710", Offset = "0x50C9F10", VA = "0x1850CB710")]
	public LJIFAGLCNHB GJILDBEMEAG(DEHDDPNGACK MOLPKNIJMDK)
	{
		return default(LJIFAGLCNHB);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x50CBD80", Offset = "0x50CA580", VA = "0x1850CBD80")]
	public bool OLAGMGECLIL(DEHDDPNGACK MOLPKNIJMDK, out LJIFAGLCNHB NENEJICOPCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x50CBD30", Offset = "0x50CA530", VA = "0x1850CBD30")]
	public bool OFPMBIHDFGG(DEHDDPNGACK MOLPKNIJMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x50CB650", Offset = "0x50C9E50", VA = "0x1850CB650")]
	public bool EAGOIFINECB(DEHDDPNGACK MOLPKNIJMDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x50CBF00", Offset = "0x50CA700", VA = "0x1850CBF00")]
	public void PPBLELMELDH(NativeList<byte> ILAPMFLBPJO, AINAIEJMCHG LMOAGPFPMDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x1C3BA80", Offset = "0x1C3A280", VA = "0x181C3BA80")]
	public T JPOEPEFFBGI<T>(DEHDDPNGACK MOLPKNIJMDK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x50CBA70", Offset = "0x50CA270", VA = "0x1850CBA70")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x50CBCB0", Offset = "0x50CA4B0", VA = "0x1850CBCB0")]
	public ENLNIPAPLCN JMGPEBMNFFJ()
	{
		return default(ENLNIPAPLCN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x50CB7F0", Offset = "0x50C9FF0", VA = "0x1850CB7F0")]
	private void GLFOFHCJOAH(DEHDDPNGACK MOLPKNIJMDK, int MMECDMIFJKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x50CBBF0", Offset = "0x50CA3F0", VA = "0x1850CBBF0")]
	private void JKMNAOJFPCB(int JGBOOIBFCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x50CB9B0", Offset = "0x50CA1B0", VA = "0x1850CB9B0")]
	private void GNJPMKNJNNM(DEHDDPNGACK MOLPKNIJMDK, int MMECDMIFJKL, int ABGIPDMABIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x1C3B9E0", Offset = "0x1C3A1E0", VA = "0x181C3B9E0")]
	private static T JPOEPEFFBGI<T>(NativeArray<byte> FPMNAPBFAMJ, int IBIPCEJMDGF = 0) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x50CC020", Offset = "0x50CA820", VA = "0x1850CC020", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x50CBFD0", Offset = "0x50CA7D0", VA = "0x1850CBFD0", Slot = "4")]
	private IEnumerator<DEHDDPNGACK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.EventSource>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class KFGFHLPNBCL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private NativeArray<byte> FPMNAPBFAMJ;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int KJDFLCMLCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB50", Offset = "0x6EE350", VA = "0x1806EFB50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x1D4F320", Offset = "0x1D4DB20", VA = "0x181D4F320")]
	public KFGFHLPNBCL(NativeArray<byte> FPMNAPBFAMJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x50CCD70", Offset = "0x50CB570", VA = "0x1850CCD70")]
	public static KFGFHLPNBCL HLHIMDAEEEO(NativeArray<byte> FPMNAPBFAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	public T IDJGKALFFNN<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	public NativeArray<T> BDOHIHHKCNO<T>(int ABGIPDMABIG, Allocator DDJPHGFEOFF) where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	public NativeArray<T> NPFIGCIJCNJ<T>(Allocator DDJPHGFEOFF) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class INPOMIBOOKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private NativeArray<byte> FPMNAPBFAMJ;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int KJDFLCMLCGF
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB50", Offset = "0x6EE350", VA = "0x1806EFB50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x1D4F320", Offset = "0x1D4DB20", VA = "0x181D4F320")]
	public INPOMIBOOKM(NativeArray<byte> FPMNAPBFAMJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x50C7B60", Offset = "0x50C6360", VA = "0x1850C7B60")]
	public static INPOMIBOOKM HLHIMDAEEEO(NativeArray<byte> FPMNAPBFAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x1C38620", Offset = "0x1C36E20", VA = "0x181C38620")]
	public T IDJGKALFFNN<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	public NativeArray<T> BDOHIHHKCNO<T>(int ABGIPDMABIG, Allocator DDJPHGFEOFF) where T : struct
	{
		return default(NativeArray<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class IJFMDKMPGJM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private NativeArray<byte> FPMNAPBFAMJ;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int KJDFLCMLCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB50", Offset = "0x6EE350", VA = "0x1806EFB50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x1D4F320", Offset = "0x1D4DB20", VA = "0x181D4F320")]
	public IJFMDKMPGJM(NativeArray<byte> FPMNAPBFAMJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x50C7100", Offset = "0x50C5900", VA = "0x1850C7100")]
	public static IJFMDKMPGJM HLHIMDAEEEO(NativeArray<byte> FPMNAPBFAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0xC54110", Offset = "0xC52910", VA = "0x180C54110")]
	public void LKOEONBKGNN<T>(in T CJMMBFLIBMO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0xC54170", Offset = "0xC52970", VA = "0x180C54170")]
	public void OCBMHIKPDJE<T>(NativeArray<T> HOIDFJHLMNC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	public void JHGIDKDHBMF<T>(NativeArray<T> CJMMBFLIBMO) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class OIGHGCCDPCC
{
	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x50D5C20", Offset = "0x50D4420", VA = "0x1850D5C20")]
	public static Span<byte> IOCHJJGAJFO(this NativeArray<byte> FPMNAPBFAMJ)
	{
		return default(Span<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x50D59D0", Offset = "0x50D41D0", VA = "0x1850D59D0")]
	public static ReadOnlySpan<byte> DJLGDGJEPEK(this NativeArray<byte> FPMNAPBFAMJ)
	{
		return default(ReadOnlySpan<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x50D5B40", Offset = "0x50D4340", VA = "0x1850D5B40")]
	public static NativeArray<byte> EPKHPJIIAAB(this NativeArray<byte> FPMNAPBFAMJ, int MMECDMIFJKL)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x50D5D10", Offset = "0x50D4510", VA = "0x1850D5D10")]
	public static NativeArray<byte> OPPCIAADKFF(this NativeArray<byte> FPMNAPBFAMJ, int FKDPJOHPNNG = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x198A340", Offset = "0x1988B40", VA = "0x18198A340")]
	public static NativeArray<byte> OPPCIAADKFF<T>(this NativeArray<byte> FPMNAPBFAMJ, int FKDPJOHPNNG = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x50D5CA0", Offset = "0x50D44A0", VA = "0x1850D5CA0")]
	public static NativeArray<byte> ODKKPHDHAEO(this NativeArray<byte> FPMNAPBFAMJ, int FKDPJOHPNNG)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x198A2E0", Offset = "0x1988AE0", VA = "0x18198A2E0")]
	public static NativeArray<byte> ODKKPHDHAEO<T>(this NativeArray<byte> FPMNAPBFAMJ, int FKDPJOHPNNG = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x50D5BB0", Offset = "0x50D43B0", VA = "0x1850D5BB0")]
	public static NativeArray<byte> GNJDJCNONFG(this NativeArray<byte> FPMNAPBFAMJ, int FKDPJOHPNNG = 1)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x1989020", Offset = "0x1987820", VA = "0x181989020")]
	public static NativeArray<byte> GNJDJCNONFG<T>(this NativeArray<byte> FPMNAPBFAMJ, int FKDPJOHPNNG = 1) where T : struct
	{
		return default(NativeArray<byte>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class DAFJOIJKKNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private NativeList<byte> BAKFHBILFME;

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x1D4F320", Offset = "0x1D4DB20", VA = "0x181D4F320")]
	public DAFJOIJKKNE(NativeList<byte> BAKFHBILFME)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x5041320", Offset = "0x503FB20", VA = "0x185041320")]
	public static DAFJOIJKKNE HLHIMDAEEEO(NativeList<byte> FPMNAPBFAMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	public void LKOEONBKGNN<T>(in T CJMMBFLIBMO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	public void OCBMHIKPDJE<T>(NativeArray<T> CJMMBFLIBMO) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	public void JHGIDKDHBMF<T>(NativeArray<T> CJMMBFLIBMO) where T : struct
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[DOHCKPDOJMD(PAPAHBCPMGP.PropertyChanges)]
	[CEFINOONOIN(typeof(PropertyChangeNetworkRouter), new string[] { })]
	public class PropertyChangeNetworkRouter : CMBMJNFKKCN, DKFAOOPHPAH, FPOPHNFOKFP, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private ABJEGJACCLD DIFGCKNOINJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private CCOPBFAPCJI HELLEMCMMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private DNHMPLANJOC AFJGLEGGBOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private JPCKFLHNHDI EIFPMNLJMAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private DEHDDPNGACK DMIIFDEEEIP;

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public ABJEGJACCLD JCLPNLJFKIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0xE5E150", Offset = "0xE5C950", VA = "0x180E5E150")]
		public ABJEGJACCLD.BLIAEFHKIDP LGKPDPNHBOL()
		{
			return default(ABJEGJACCLD.BLIAEFHKIDP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xE5DDF0", Offset = "0xE5C5F0", VA = "0x180E5DDF0", Slot = "4")]
		public void FNNKDMJCDCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xE5DC10", Offset = "0xE5C410", VA = "0x180E5DC10", Slot = "5")]
		public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xE5DCA0", Offset = "0xE5C4A0", VA = "0x180E5DCA0")]
		public void FAGONPKNJKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xE5DE80", Offset = "0xE5C680", VA = "0x180E5DE80")]
		private void IONHNFOLGKH(DEHDDPNGACK MOLPKNIJMDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0xE5DAB0", Offset = "0xE5C2B0", VA = "0x180E5DAB0")]
		private void DJLGKBMBCLL(DEHDDPNGACK MOLPKNIJMDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xE5E0D0", Offset = "0xE5C8D0", VA = "0x180E5E0D0")]
		private void KAAFCBHALKM(DEHDDPNGACK MOLPKNIJMDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xE5DA90", Offset = "0xE5C290", VA = "0x180E5DA90")]
		private void AEFDAAEMODH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xE5E130", Offset = "0xE5C930", VA = "0x180E5E130")]
		private void LBKLLANPPNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0xE5E170", Offset = "0xE5C970", VA = "0x180E5E170")]
		private void MAFCAGECADD(DEHDDPNGACK MOLPKNIJMDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x5004770", Offset = "0x5002F70", VA = "0x185004770", Slot = "6")]
		private void CMHEFNIGHGI<TKey, T>(global::KMAABHDKKLE<TKey, T> IOADAIMHMFG, object ALLCABKLNNG) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0xE5DBE0", Offset = "0xE5C3E0", VA = "0x180E5DBE0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public PropertyChangeNetworkRouter()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[CEFINOONOIN(typeof(NNPAEFJMGDF), new string[] { })]
public class NNPAEFJMGDF : DKFAOOPHPAH, GHNBGLLDFLL
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static readonly FLAFLKKHHEA APOHKGBDLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly IBPBFBKDJCD FAGLOPOGLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private LAIILCPKBAD FHGJEPMFKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private FBFMOHPHODB AFJGLEGGBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private OMJIOCDDDDJ MBCGBGIEAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private PropertyChangeNetworkRouter CCPKMLPHGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private MIPCILJMDGJ HKHILDACEJN;

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x50D42D0", Offset = "0x50D2AD0", VA = "0x1850D42D0", Slot = "4")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x50D4150", Offset = "0x50D2950", VA = "0x1850D4150", Slot = "5")]
	public void BCKGPNKBBNF(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x50D43B0", Offset = "0x50D2BB0", VA = "0x1850D43B0")]
	public void JDCINKDFFNF(MCOCAFPBHKN MEDLGIKFPNL, MABIDPJIHBP BNEGJHHOEJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x50D4670", Offset = "0x50D2E70", VA = "0x1850D4670")]
	public void OPPLOKABCLC(MCOCAFPBHKN MEDLGIKFPNL, MIPCILJMDGJ KBHHIDGOLNC, in BJHFEKKLKGB DCKOFIOPMNA, in BJHFEKKLKGB JFBNMEBIPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x50D4100", Offset = "0x50D2900", VA = "0x1850D4100")]
	public void AEKFCCGOHEB(MCOCAFPBHKN MEDLGIKFPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x50D4220", Offset = "0x50D2A20", VA = "0x1850D4220")]
	private void DEIJAMJDACG(MCOCAFPBHKN MEDLGIKFPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x50D4380", Offset = "0x50D2B80", VA = "0x1850D4380")]
	public void ILKJLLGIGOB(MCOCAFPBHKN MEDLGIKFPNL, MIPCILJMDGJ KBHHIDGOLNC, in BJHFEKKLKGB DCKOFIOPMNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x50D4480", Offset = "0x50D2C80", VA = "0x1850D4480")]
	private void LEMKJDOEIAH(MCOCAFPBHKN MEDLGIKFPNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x50D4700", Offset = "0x50D2F00", VA = "0x1850D4700")]
	public NNPAEFJMGDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
internal abstract class LDBFDIJJJAI : DKFAOOPHPAH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private KCHBCAHHFGL PFKPKGFJONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private uint MDFNKBFMBFN;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public abstract uint PICIAJBOPCC
	{
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x50CFE00", Offset = "0x50CE600", VA = "0x1850CFE00", Slot = "7")]
	public virtual void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x50CFD80", Offset = "0x50CE580", VA = "0x1850CFD80", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x50CFEA0", Offset = "0x50CE6A0", VA = "0x1850CFEA0")]
	public MCOCAFPBHKN EPGIPHKDHIO()
	{
		return default(MCOCAFPBHKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x50CFD00", Offset = "0x50CE500", VA = "0x1850CFD00")]
	public void BJEAFJNBKOO(MCOCAFPBHKN CLBACPKJNKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x1DAD210", Offset = "0x1DABA10", VA = "0x181DAD210", Slot = "8")]
	public virtual void LCAEFMHIJAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	protected LDBFDIJJJAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[CEFINOONOIN(typeof(ABEBEECDLPD), new string[] { })]
internal sealed class ABEBEECDLPD : LDBFDIJJJAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private ENJAHHPPGPN AGONKCODOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private uint PPNGDOLAPDM;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public override uint PICIAJBOPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x630C00", Offset = "0x62F400", VA = "0x180630C00", Slot = "6")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x5038A30", Offset = "0x5037230", VA = "0x185038A30", Slot = "7")]
	public override void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x5038AD0", Offset = "0x50372D0", VA = "0x185038AD0")]
	private void JNPIIBGEELF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x5038B20", Offset = "0x5037320", VA = "0x185038B20", Slot = "8")]
	public override void LCAEFMHIJAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x606E30", Offset = "0x605630", VA = "0x180606E30")]
	public ABEBEECDLPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[CEFINOONOIN(typeof(IDCKAKEMNNI), new string[] { })]
internal sealed class IDCKAKEMNNI : LDBFDIJJJAI
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public override uint PICIAJBOPCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x606B10", Offset = "0x605310", VA = "0x180606B10", Slot = "6")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public IDCKAKEMNNI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[OJBFCHOEMHJ(typeof(HFEGCOONMAM))]
[CEFINOONOIN(typeof(BAEDAPKGADH), new string[] { })]
internal sealed class BAEDAPKGADH : JIOLBCKAPBA, CMBMJNFKKCN, DKFAOOPHPAH, GHNBGLLDFLL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private HFEGCOONMAM LMKNNIPOPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private FOJPBIGOEBJ NLJLBCPPCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private EntityQuery IDFLKIFANNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private EntityQuery ADKECPBKMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private EntityQuery DAJDCBKAPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool NMANPNFCCCL;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private EntityManager BNFBCOAMLJO
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x503D830", Offset = "0x503C030", VA = "0x18503D830")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public EntityQuery LBHNCONAPIM
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x638A70", Offset = "0x637270", VA = "0x180638A70")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public EntityQuery JEGGNDJCFOP
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x638A30", Offset = "0x637230", VA = "0x180638A30")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public EntityQuery HPIFCPEGFFP
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x503D4B0", Offset = "0x503BCB0", VA = "0x18503D4B0")]
		get
		{
			return default(EntityQuery);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int HKCLANABCJN
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x503D310", Offset = "0x503BB10", VA = "0x18503D310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public int CADHINJENAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x503D3E0", Offset = "0x503BBE0", VA = "0x18503D3E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public int DFDIDPDLKND
	{
		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x503D190", Offset = "0x503B990", VA = "0x18503D190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "4")]
	public void FNNKDMJCDCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x503D1F0", Offset = "0x503B9F0", VA = "0x18503D1F0", Slot = "5")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x503CFC0", Offset = "0x503B7C0", VA = "0x18503CFC0", Slot = "6")]
	public void BCKGPNKBBNF(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x503D630", Offset = "0x503BE30", VA = "0x18503D630")]
	public FCCBMJGNNEF OBPLLDFCCBJ()
	{
		return default(FCCBMJGNNEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x503D530", Offset = "0x503BD30", VA = "0x18503D530")]
	public FCCBMJGNNEF NDAHCABFMLE()
	{
		return default(FCCBMJGNNEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x503D270", Offset = "0x503BA70", VA = "0x18503D270")]
	public FCCBMJGNNEF FIKDBPAILDH()
	{
		return default(FCCBMJGNNEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x503D780", Offset = "0x503BF80", VA = "0x18503D780")]
	public MNBPBHNFCPJ OOHEKPANOLH(CFBEFPIPHOM MEDLGIKFPNL)
	{
		return default(MNBPBHNFCPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x503D6D0", Offset = "0x503BED0", VA = "0x18503D6D0")]
	public MNBPBHNFCPJ OOHEKPANOLH(Entity NBIJCGHBCCI)
	{
		return default(MNBPBHNFCPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x503D330", Offset = "0x503BB30", VA = "0x18503D330")]
	public HEIIJIHIAKK IILOCACPEEL(Entity NBIJCGHBCCI)
	{
		return default(HEIIJIHIAKK);
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x503D1B0", Offset = "0x503B9B0", VA = "0x18503D1B0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x503D400", Offset = "0x503BC00", VA = "0x18503D400")]
	private FCCBMJGNNEF KDBKLIEOBBD(EntityQuery JIDAALIOAFE)
	{
		return default(FCCBMJGNNEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x503D880", Offset = "0x503C080", VA = "0x18503D880")]
	public BAEDAPKGADH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[CEFINOONOIN(typeof(FOJPBIGOEBJ), new string[] { })]
public class MBDNHBAPCGG : DKFAOOPHPAH, FOJPBIGOEBJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private HFEGCOONMAM LMKNNIPOPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private ENJAHHPPGPN AGONKCODOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private ObjectLifecycleService IGCMNAMAMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private ObjectEmbodimentService MDLJNEBAIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private ObjectPrefabCreationService PCNDCGBMEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private ObjectNetworkToLocalMapService FFAFHLPEJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private BAEDAPKGADH DJMDBGODMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private KCHBCAHHFGL PFKPKGFJONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool NMANPNFCCCL;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public GIDONOBPNKN BLAHOJHKOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x50D1400", Offset = "0x50CFC00", VA = "0x1850D1400", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	private EntityManager BNFBCOAMLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x50D1F70", Offset = "0x50D0770", VA = "0x1850D1F70")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public int HKCLANABCJN
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x50D13E0", Offset = "0x50CFBE0", VA = "0x1850D13E0", Slot = "39")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public int CADHINJENAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x50D1740", Offset = "0x50CFF40", VA = "0x1850D1740", Slot = "10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public int DFDIDPDLKND
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x50D0BC0", Offset = "0x50CF3C0", VA = "0x1850D0BC0", Slot = "40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public int JGMMMCHPMBF
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x50D1270", Offset = "0x50CFA70", VA = "0x1850D1270", Slot = "14")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public int FOENCACNGPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x50D1870", Offset = "0x50D0070", VA = "0x1850D1870", Slot = "44")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000007")]
	public event Action<CFBEFPIPHOM, HEIIJIHIAKK> HLDCKKIBNFH
	{
		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x50D0760", Offset = "0x50CEF60", VA = "0x1850D0760", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x50D17D0", Offset = "0x50CFFD0", VA = "0x1850D17D0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	public event Action<CFBEFPIPHOM> PPMNIDEBOPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x50D0B20", Offset = "0x50CF320", VA = "0x1850D0B20", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x50D11D0", Offset = "0x50CF9D0", VA = "0x1850D11D0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x50D0EB0", Offset = "0x50CF6B0", VA = "0x1850D0EB0", Slot = "4")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x50D19E0", Offset = "0x50D01E0", VA = "0x1850D19E0")]
	private void LFMFMPPBACJ(Entity NBIJCGHBCCI, HEIIJIHIAKK GPMEIOIEDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x50D0A20", Offset = "0x50CF220", VA = "0x1850D0A20")]
	private void ALOADGCDHCC(Entity NBIJCGHBCCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x50D17A0", Offset = "0x50CFFA0", VA = "0x1850D17A0")]
	internal CFBEFPIPHOM JOPPPBPGJMA(Entity NBIJCGHBCCI)
	{
		return default(CFBEFPIPHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x50D1450", Offset = "0x50CFC50", VA = "0x1850D1450", Slot = "36")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
	private void DKBIAIGLAMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x50D0C60", Offset = "0x50CF460", VA = "0x1850D0C60", Slot = "38")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x50D1DE0", Offset = "0x50D05E0", VA = "0x1850D1DE0", Slot = "11")]
	public FCCBMJGNNEF OBPLLDFCCBJ()
	{
		return default(FCCBMJGNNEF);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x50D1C10", Offset = "0x50D0410", VA = "0x1850D1C10", Slot = "41")]
	public FCCBMJGNNEF NDAHCABFMLE()
	{
		return default(FCCBMJGNNEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x50D1290", Offset = "0x50CFA90", VA = "0x1850D1290", Slot = "42")]
	public FCCBMJGNNEF FIKDBPAILDH()
	{
		return default(FCCBMJGNNEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x50D1F40", Offset = "0x50D0740", VA = "0x1850D1F40", Slot = "12")]
	public MNBPBHNFCPJ OOHEKPANOLH(CFBEFPIPHOM LEPHKDIHJFD)
	{
		return default(MNBPBHNFCPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x50D1680", Offset = "0x50CFE80", VA = "0x1850D1680", Slot = "13")]
	public HEIIJIHIAKK IILOCACPEEL(CFBEFPIPHOM LEPHKDIHJFD)
	{
		return default(HEIIJIHIAKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x50D1DB0", Offset = "0x50D05B0", VA = "0x1850D1DB0", Slot = "35")]
	public bool NKBMJECLOCI(CFBEFPIPHOM LEPHKDIHJFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(RVA = "0x50D1A80", Offset = "0x50D0280", VA = "0x1850D1A80", Slot = "31")]
	public void LIPJKPPEBGH(CFBEFPIPHOM LEPHKDIHJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x50D0AB0", Offset = "0x50CF2B0", VA = "0x1850D0AB0", Slot = "32")]
	public void APJLKFMLABG(CFBEFPIPHOM LEPHKDIHJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x50D1B10", Offset = "0x50D0310", VA = "0x1850D1B10", Slot = "33")]
	public void NAPPOONKJCM(CFBEFPIPHOM LEPHKDIHJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x50D0C30", Offset = "0x50CF430", VA = "0x1850D0C30", Slot = "37")]
	public void DMPAKMCFACH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x50D16C0", Offset = "0x50CFEC0", VA = "0x1850D16C0", Slot = "25")]
	public BKIEEIBJMKG JDCINKDFFNF(HEIIJIHIAKK GPMEIOIEDNN)
	{
		return default(BKIEEIBJMKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x50D12D0", Offset = "0x50CFAD0", VA = "0x1850D12D0", Slot = "26")]
	public BKIEEIBJMKG FNHIIMHAIEO(HEIIJIHIAKK GPMEIOIEDNN)
	{
		return default(BKIEEIBJMKG);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x50D1900", Offset = "0x50D0100", VA = "0x1850D1900", Slot = "27")]
	public BKIEEIBJMKG KLLAAEAJMPK(MCOCAFPBHKN GFKNINEELBB, HEIIJIHIAKK GPMEIOIEDNN)
	{
		return default(BKIEEIBJMKG);
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x50D1D00", Offset = "0x50D0500", VA = "0x1850D1D00", Slot = "28")]
	public CLMHOEMCILK NJIEKEKJKAE()
	{
		return default(CLMHOEMCILK);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x50D1C50", Offset = "0x50D0450", VA = "0x1850D1C50", Slot = "43")]
	public PPAOPCOFLAL NHAIFAADBOP(HALBGGLKEOJ BKDBLJPNPPJ)
	{
		return default(PPAOPCOFLAL);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x50D1B40", Offset = "0x50D0340", VA = "0x1850D1B40", Slot = "29")]
	public CELEFKODKGB NBMMMGOIFIH()
	{
		return default(CELEFKODKGB);
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x50D1E70", Offset = "0x50D0670", VA = "0x1850D1E70", Slot = "30")]
	public CNGONJFLFDO OECKONEOFKD(JPMNNMNBHIP BKDBLJPNPPJ)
	{
		return default(CNGONJFLFDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x50D0BE0", Offset = "0x50CF3E0", VA = "0x1850D0BE0", Slot = "15")]
	public void DAFBLBFDDID(MCOCAFPBHKN GFKNINEELBB, NNCLEEGIIBK CDBBAPHDBIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x50D10A0", Offset = "0x50CF8A0", VA = "0x1850D10A0", Slot = "16")]
	public BKIEEIBJMKG EIDBIEHIAEK(CFBEFPIPHOM LEPHKDIHJFD, [Optional] object HMOHICKINOJ)
	{
		return default(BKIEEIBJMKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(RVA = "0x50D1390", Offset = "0x50CFB90", VA = "0x1850D1390", Slot = "17")]
	public bool GOFIPHNJIDA(CFBEFPIPHOM LEPHKDIHJFD, out NNCLEEGIIBK FNPLEFBJGJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(RVA = "0x50D1630", Offset = "0x50CFE30", VA = "0x1850D1630", Slot = "45")]
	public Transform IIJCCMOMBPF(CFBEFPIPHOM LEPHKDIHJFD, [Optional] object HMOHICKINOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x50D1890", Offset = "0x50D0090", VA = "0x1850D1890", Slot = "19")]
	public bool KFAIBMCBPEJ(CFBEFPIPHOM LEPHKDIHJFD, out Transform EOBPGPELLLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x50D1350", Offset = "0x50CFB50", VA = "0x1850D1350", Slot = "20")]
	public bool GJPEFJBAECC(CFBEFPIPHOM LEPHKDIHJFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x50D1610", Offset = "0x50CFE10", VA = "0x1850D1610")]
	public bool IFKIHNAEHAF(NNCLEEGIIBK CJMMBFLIBMO, [Optional] object HMOHICKINOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x50D15E0", Offset = "0x50CFDE0", VA = "0x1850D15E0", Slot = "46")]
	public bool IFKIHNAEHAF(CFBEFPIPHOM LEPHKDIHJFD, [Optional] object HMOHICKINOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x50D0B00", Offset = "0x50CF300", VA = "0x1850D0B00", Slot = "47")]
	public void BDEKACCGGFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x50D0800", Offset = "0x50CF000", VA = "0x1850D0800", Slot = "18")]
	public void ADKEHJNDCIK(NNCLEEGIIBK DEGGOOGCHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x50D1760", Offset = "0x50CFF60", VA = "0x1850D1760", Slot = "48")]
	public void JJECKBCFCLO(CFBEFPIPHOM LEPHKDIHJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x50D18E0", Offset = "0x50D00E0", VA = "0x1850D18E0", Slot = "21")]
	public void KGEPALGALDH(Entity NBIJCGHBCCI, object HMOHICKINOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x50D1AF0", Offset = "0x50D02F0", VA = "0x1850D1AF0", Slot = "22")]
	public bool MNFPKMAEIFA(Entity NBIJCGHBCCI, object HMOHICKINOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x50D1AD0", Offset = "0x50D02D0", VA = "0x1850D1AD0", Slot = "49")]
	public bool MKGJHKHJNAI(Entity NBIJCGHBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028F")]
	[Cpp2IlInjected.Address(RVA = "0x50D11B0", Offset = "0x50CF9B0", VA = "0x1850D11B0", Slot = "50")]
	public bool EJJHDDFLHDF(Entity NBIJCGHBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x50D1E20", Offset = "0x50D0620", VA = "0x1850D1E20", Slot = "34")]
	public NativeArray<(CFBEFPIPHOM, CFBEFPIPHOM)> ODJPPNHBFCL(NativeArray<CFBEFPIPHOM> OMHJJDKCAJM, Allocator DDJPHGFEOFF)
	{
		return default(NativeArray<(CFBEFPIPHOM, CFBEFPIPHOM)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x50D0C00", Offset = "0x50CF400", VA = "0x1850D0C00", Slot = "24")]
	public MCOCAFPBHKN DCDNMCENJCL(CFBEFPIPHOM LEPHKDIHJFD)
	{
		return default(MCOCAFPBHKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x50D1FC0", Offset = "0x50D07C0", VA = "0x1850D1FC0", Slot = "23")]
	public CFBEFPIPHOM PGAAHFGOMDE(MCOCAFPBHKN GFKNINEELBB)
	{
		return default(CFBEFPIPHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public MBDNHBAPCGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[CEFINOONOIN(typeof(AKFDHJFDBOF), new string[] { })]
internal sealed class AKFDHJFDBOF : DKFAOOPHPAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private ObjectPrefabCreationService PCNDCGBMEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private BAEDAPKGADH DJMDBGODMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private FDJJGOGKMHG LMKNNIPOPLE;

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x503C130", Offset = "0x503A930", VA = "0x18503C130", Slot = "4")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x503C660", Offset = "0x503AE60", VA = "0x18503C660")]
	public NativeArray<(CFBEFPIPHOM, CFBEFPIPHOM)> ODJPPNHBFCL(NativeArray<CFBEFPIPHOM> OMHJJDKCAJM, Allocator DDJPHGFEOFF)
	{
		return default(NativeArray<(CFBEFPIPHOM, CFBEFPIPHOM)>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x503C790", Offset = "0x503AF90", VA = "0x18503C790")]
	private void PGDBFNFDPPI(NativeMultiHashMap<int, (CFBEFPIPHOM src, CFBEFPIPHOM dst)> PJHAKEINDLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x503C920", Offset = "0x503B120", VA = "0x18503C920")]
	private void PHAGDOIDFCD(NativeMultiHashMap<int, (CFBEFPIPHOM src, CFBEFPIPHOM dst)> PJHAKEINDLO, int GPMEIOIEDNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x503C4E0", Offset = "0x503ACE0", VA = "0x18503C4E0")]
	private void JPIENODDFJC(NativeMultiHashMap<int, (CFBEFPIPHOM src, CFBEFPIPHOM dst)> PJHAKEINDLO, int GPMEIOIEDNN, AIGPFJAOAFB AFJGLEGGBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x503C1E0", Offset = "0x503A9E0", VA = "0x18503C1E0")]
	private NativeMultiHashMap<int, (CFBEFPIPHOM, CFBEFPIPHOM)> JEMLBNABPJF(Allocator DDJPHGFEOFF, NativeArray<CFBEFPIPHOM> OMHJJDKCAJM, out NativeArray<(CFBEFPIPHOM src, CFBEFPIPHOM dst)> OEDDIOPPMAK)
	{
		return default(NativeMultiHashMap<int, (CFBEFPIPHOM, CFBEFPIPHOM)>);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public AKFDHJFDBOF()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CEFINOONOIN(typeof(MGIHGMHOKEE), new string[] { })]
	[DOHCKPDOJMD(PAPAHBCPMGP.Physics, new string[] { "Callbacks" })]
	public class PhysicsService : DKFAOOPHPAH, GHNBGLLDFLL, MGIHGMHOKEE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private const string CMGMDHKFGFN = "Callbacks";

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private static readonly FLAFLKKHHEA HABKADCFIOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private EntityManager FNBDEMCEOPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private FOJPBIGOEBJ NLJLBCPPCEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private HFEGCOONMAM LMKNNIPOPLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private ICHIOKBIGBA APOONLJNOJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private PropertyEventCallbacksService CFHAALIELBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private global::MEBPHBGNBLO<GCCNGCMPMGI> LJNDOLIPKCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private bool NMANPNFCCCL;

		[Cpp2IlInjected.Token(Token = "0x14000009")]
		public event Action<CFBEFPIPHOM, GCCNGCMPMGI> JJPKNJHCHIO
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0xE5D820", Offset = "0xE5C020", VA = "0x180E5D820", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0xE5D6D0", Offset = "0xE5BED0", VA = "0x180E5D6D0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xE5D5E0", Offset = "0xE5BDE0", VA = "0x180E5D5E0", Slot = "4")]
		public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0xE5D300", Offset = "0xE5BB00", VA = "0x180E5D300", Slot = "5")]
		public void BCKGPNKBBNF(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0xE5D550", Offset = "0xE5BD50", VA = "0x180E5D550", Slot = "11")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xE5D960", Offset = "0xE5C160", VA = "0x180E5D960", Slot = "8")]
		public void PGECBNGPHCG(CFBEFPIPHOM LEPHKDIHJFD, Vector3 IONIHDHIJOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xE5D430", Offset = "0xE5BC30", VA = "0x180E5D430", Slot = "9")]
		public bool CONCKEJJICO(CFBEFPIPHOM LEPHKDIHJFD, out Collider OKCFJNOIDBD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xE5D770", Offset = "0xE5BF70", VA = "0x180E5D770")]
		private void FJIMCKHJGFF(Entity NBIJCGHBCCI, MIPCILJMDGJ KBHHIDGOLNC, BJHFEKKLKGB JCEACLPGDMD, BJHFEKKLKGB CMJHENLPPFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xE5D8C0", Offset = "0xE5C0C0", VA = "0x180E5D8C0", Slot = "10")]
		public void OLGGKPMALKJ(CFBEFPIPHOM LEPHKDIHJFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public PhysicsService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class GLHLMMHJFOL : NONOFHBMPEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly string FAAEINEDOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public readonly GLHLMMHJFOL AOABEAKEPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public readonly List<GLHLMMHJFOL> LBCDBKGCIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	public readonly List<HMMELKFLGKD> AFJGLEGGBOF;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public string CLKEGIDEGCG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public NONOFHBMPEN KNNHFNODLGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public IEnumerable<NONOFHBMPEN> KHAHDCBPAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6186B0", Offset = "0x616EB0", VA = "0x1806186B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public IEnumerable<HMMELKFLGKD> ECHCFPCIPDI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6186A0", Offset = "0x616EA0", VA = "0x1806186A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x504A7B0", Offset = "0x5048FB0", VA = "0x18504A7B0")]
	public GLHLMMHJFOL(string JNAACNJBHOF, GLHLMMHJFOL CELKNCFBAOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[CEFINOONOIN(typeof(IECNLFJIGBE), new string[] { })]
[OJBFCHOEMHJ(typeof(AINBLNOJEEC))]
public sealed class PMKKDNPOEBF : IECNLFJIGBE, JIOLBCKAPBA, CMBMJNFKKCN, DKFAOOPHPAH, GHNBGLLDFLL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class JJLDEJGFKKP : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private (string path, string token) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private string groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public string <>3__groupPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private string[] <tokens>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private StringBuilder <path>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private int <i>5__4;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.Stringpath,System.Stringtoken)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002C4")]
			[Cpp2IlInjected.Address(RVA = "0x68E570", Offset = "0x68CD70", VA = "0x18068E570", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60002C6")]
			[Cpp2IlInjected.Address(RVA = "0xE563F0", Offset = "0xE54BF0", VA = "0x180E563F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0xE4C760", Offset = "0xE4AF60", VA = "0x180E4C760")]
		[DebuggerHidden]
		public JJLDEJGFKKP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xE560F0", Offset = "0xE548F0", VA = "0x180E560F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xE563A0", Offset = "0xE54BA0", VA = "0x180E563A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xE56300", Offset = "0xE54B00", VA = "0x180E56300", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.Stringpath,System.Stringtoken)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xE56300", Offset = "0xE54B00", VA = "0x180E56300", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly JAGBCLPLLCC AIEPCFEJKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly Dictionary<string, GLHLMMHJFOL> CAPEFOOLFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly Dictionary<int, NONOFHBMPEN> IGAGFNBJBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly List<HMMELKFLGKD> ABCJBKEMJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private AINBLNOJEEC AFJGLEGGBOF;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public NONOFHBMPEN IMFAMLKJPEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xE5B070", Offset = "0xE59870", VA = "0x180E5B070", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public List<HMMELKFLGKD> FMNJCLMNMPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6186A0", Offset = "0x616EA0", VA = "0x1806186A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "7")]
	public void FNNKDMJCDCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0xE5B560", Offset = "0xE59D60", VA = "0x180E5B560", Slot = "8")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0xE5B050", Offset = "0xE59850", VA = "0x180E5B050", Slot = "9")]
	public void BCKGPNKBBNF(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0xE5B510", Offset = "0xE59D10", VA = "0x180E5B510", Slot = "10")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0xE5BCF0", Offset = "0xE5A4F0", VA = "0x180E5BCF0", Slot = "6")]
	public bool PAPAKKEPEPG(HMMELKFLGKD IOADAIMHMFG, out NONOFHBMPEN AKCNNHAPOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0xE5B6B0", Offset = "0xE59EB0", VA = "0x180E5B6B0")]
	private void HJNEAFPACOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0xE5B140", Offset = "0xE59940", VA = "0x180E5B140")]
	private void CLPFFDOKLDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0xE5BC90", Offset = "0xE5A490", VA = "0x180E5BC90")]
	private GLHLMMHJFOL NOJGDEIFJGN(string ICLFJKEMBKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0xE5B070", Offset = "0xE59870", VA = "0x180E5B070")]
	private GLHLMMHJFOL NHBNIOPMCGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0xE5B2C0", Offset = "0xE59AC0", VA = "0x180E5B2C0")]
	private GLHLMMHJFOL COBIJIICCPH(string ICLFJKEMBKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0xE5B5C0", Offset = "0xE59DC0", VA = "0x180E5B5C0")]
	private GLHLMMHJFOL ECKAPCCGAJM(string BGKDPPEDMBJ, string HMOHICKINOJ, [Optional] GLHLMMHJFOL AOABEAKEPMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0xE5B0D0", Offset = "0xE598D0", VA = "0x180E5B0D0")]
	[IteratorStateMachine(typeof(JJLDEJGFKKP))]
	private IEnumerable<(string, string)> CHABJEJBDCN(string ICLFJKEMBKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0xE5BC40", Offset = "0xE5A440", VA = "0x180E5BC40")]
	private bool NDNPGCLHGAL(HMMELKFLGKD IOADAIMHMFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0xE5AF20", Offset = "0xE59720", VA = "0x180E5AF20")]
	private JAGBCLPLLCC ABEABBAFEFP(HMMELKFLGKD IOADAIMHMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0xE5BA80", Offset = "0xE5A280", VA = "0x180E5BA80")]
	private JAGBCLPLLCC JFGAAGFLHDP(HMMELKFLGKD IOADAIMHMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0xE5AFE0", Offset = "0xE597E0", VA = "0x180E5AFE0")]
	private JAGBCLPLLCC BBEBABCJDEH(HMMELKFLGKD IOADAIMHMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0xA8ED90", Offset = "0xA8D590", VA = "0x180A8ED90")]
	private T JOLJKKKFFKF<T>(HMMELKFLGKD IOADAIMHMFG) where T : Attribute
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0xE5BB70", Offset = "0xE5A370", VA = "0x180E5BB70")]
	private FieldInfo MIJPAHBJEAE(HMMELKFLGKD IOADAIMHMFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0xE5BD70", Offset = "0xE5A570", VA = "0x180E5BD70")]
	public PMKKDNPOEBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0xE5BAD0", Offset = "0xE5A2D0", VA = "0x180E5BAD0")]
	[CompilerGenerated]
	private int LIBADFAAMJG(HMMELKFLGKD DKLHMFCLOAB, HMMELKFLGKD FLEBMPFFCAA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[OJBFCHOEMHJ(typeof(KFEICEPFNDF))]
[CEFINOONOIN(typeof(FBFMOHPHODB), new string[] { })]
[DefaultMember("Item")]
public class AGLLMLLMAIG : FBFMOHPHODB, IEnumerable<NOPBMJOJCGP>, IEnumerable, JIOLBCKAPBA, CMBMJNFKKCN, DKFAOOPHPAH, GHNBGLLDFLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly Dictionary<(Type, string), int> EACIGABFBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private KFEICEPFNDF AFJGLEGGBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private BACGAADCGAE GJNPFLDOAGG;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x503ACB0", Offset = "0x50394B0", VA = "0x18503ACB0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public NOPBMJOJCGP NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x503A9B0", Offset = "0x50391B0", VA = "0x18503A9B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public NOPBMJOJCGP NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x503A9B0", Offset = "0x50391B0", VA = "0x18503A9B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x503AB30", Offset = "0x5039330", VA = "0x18503AB30", Slot = "11")]
	public void FNNKDMJCDCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(RVA = "0x503AAB0", Offset = "0x50392B0", VA = "0x18503AAB0", Slot = "12")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "13")]
	public void BCKGPNKBBNF(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(RVA = "0x503ACD0", Offset = "0x50394D0", VA = "0x18503ACD0")]
	private void MFHKIELFBPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x9A7FF0", Offset = "0x9A67F0", VA = "0x1809A7FF0")]
	private string PBKAFEDAKJC(string JNAACNJBHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x503A9D0", Offset = "0x50391D0", VA = "0x18503A9D0", Slot = "7")]
	public NOPBMJOJCGP ANIGAEEOCNL(OMOEODCFEGL EMMPAJPIILL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x503AF30", Offset = "0x5039730", VA = "0x18503AF30")]
	private bool OJFCMCNIJNA(Type MHMHPHOEJMA, string JNAACNJBHOF, out NOPBMJOJCGP EPIPKLFKPPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x503ABA0", Offset = "0x50393A0", VA = "0x18503ABA0", Slot = "8")]
	public MIPCILJMDGJ KJPBFOEADCJ(OMOEODCFEGL EMMPAJPIILL)
	{
		return default(MIPCILJMDGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x503AB80", Offset = "0x5039380", VA = "0x18503AB80", Slot = "9")]
	public IEnumerator<NOPBMJOJCGP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x503AB80", Offset = "0x5039380", VA = "0x18503AB80", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(RVA = "0x503B1A0", Offset = "0x50399A0", VA = "0x18503B1A0")]
	public AGLLMLLMAIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[DefaultMember("Item")]
public interface AINAIEJMCHG
{
	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	int NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OJJNKGLHAPM(MIPCILJMDGJ OCNCOBFEOBE, out int OCAKIKBDFGC);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[OJBFCHOEMHJ(typeof(DNHMPLANJOC))]
[CEFINOONOIN(typeof(AINAIEJMCHG), new string[] { })]
[DefaultMember("Item")]
public class JKACMHLPDIN : DKFAOOPHPAH, GHNBGLLDFLL, AINAIEJMCHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Dictionary<MIPCILJMDGJ, int> GABGBPPMFNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private DNHMPLANJOC AFJGLEGGBOF;

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public int NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x50CAC30", Offset = "0x50C9430", VA = "0x1850CAC30", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x50CAF50", Offset = "0x50C9750", VA = "0x1850CAF50", Slot = "6")]
	public bool OJJNKGLHAPM(MIPCILJMDGJ OCNCOBFEOBE, out int OCAKIKBDFGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x50CAEF0", Offset = "0x50C96F0", VA = "0x1850CAEF0", Slot = "4")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x50CAC90", Offset = "0x50C9490", VA = "0x1850CAC90", Slot = "5")]
	public void BCKGPNKBBNF(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x50CACA0", Offset = "0x50C94A0", VA = "0x1850CACA0")]
	private void BHFNPALMNEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x50CAFC0", Offset = "0x50C97C0", VA = "0x1850CAFC0")]
	public JKACMHLPDIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[DefaultMember("Item")]
[CEFINOONOIN(typeof(DNHMPLANJOC), new string[] { })]
[OJBFCHOEMHJ(typeof(FBFMOHPHODB))]
public class NBMEIHKPMFD : DNHMPLANJOC, IEnumerable<NJFOBBNGILB>, IEnumerable, JIOLBCKAPBA, CMBMJNFKKCN, DKFAOOPHPAH, GHNBGLLDFLL, FPOPHNFOKFP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private FOJPBIGOEBJ NLJLBCPPCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private FBFMOHPHODB EMPDGALOEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private NJFOBBNGILB[] EOFBLFNJHAO;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x50D3EB0", Offset = "0x50D26B0", VA = "0x1850D3EB0", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public NJFOBBNGILB NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x50D37F0", Offset = "0x50D1FF0", VA = "0x1850D37F0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public NJFOBBNGILB NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x50D37F0", Offset = "0x50D1FF0", VA = "0x1850D37F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "10")]
	public void FNNKDMJCDCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x50D3AA0", Offset = "0x50D22A0", VA = "0x1850D3AA0", Slot = "11")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "12")]
	public void BCKGPNKBBNF(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x50D3830", Offset = "0x50D2030", VA = "0x1850D3830", Slot = "6")]
	public NJFOBBNGILB ANIGAEEOCNL(OMOEODCFEGL EMMPAJPIILL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x50D3DE0", Offset = "0x50D25E0", VA = "0x1850D3DE0", Slot = "7")]
	public MIPCILJMDGJ KJPBFOEADCJ(OMOEODCFEGL EMMPAJPIILL)
	{
		return default(MIPCILJMDGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x50D3D30", Offset = "0x50D2530", VA = "0x1850D3D30", Slot = "8")]
	public IEnumerator<NJFOBBNGILB> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x50D3EC0", Offset = "0x50D26C0", VA = "0x1850D3EC0", Slot = "9")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0xC635E0", Offset = "0xC61DE0", VA = "0x180C635E0", Slot = "13")]
	public void PLCDFANINMD<TKey, T>(global::KMAABHDKKLE<TKey, T> IOADAIMHMFG, [Optional] object ALLCABKLNNG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x50D3960", Offset = "0x50D2160", VA = "0x1850D3960", Slot = "14")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public NBMEIHKPMFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x50D37F0", Offset = "0x50D1FF0", VA = "0x1850D37F0")]
	[CompilerGenerated]
	private NJFOBBNGILB HOEIHDPPAKC(int GDBELOJNNFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[CEFINOONOIN(typeof(AINBLNOJEEC), new string[] { })]
[DefaultMember("Item")]
[OJBFCHOEMHJ(typeof(FBFMOHPHODB))]
public class HJDMBNNIBDO : AINBLNOJEEC, IEnumerable<HMMELKFLGKD>, IEnumerable, JIOLBCKAPBA, CMBMJNFKKCN, DKFAOOPHPAH, GHNBGLLDFLL, FPOPHNFOKFP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private FOJPBIGOEBJ NLJLBCPPCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private FBFMOHPHODB EMPDGALOEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private HMMELKFLGKD[] EOFBLFNJHAO;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x50C6540", Offset = "0x50C4D40", VA = "0x1850C6540", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public HMMELKFLGKD NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x50C5E10", Offset = "0x50C4610", VA = "0x1850C5E10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public HMMELKFLGKD NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x50C5E10", Offset = "0x50C4610", VA = "0x1850C5E10", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "9")]
	public void FNNKDMJCDCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x50C6230", Offset = "0x50C4A30", VA = "0x1850C6230", Slot = "10")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x50C5F40", Offset = "0x50C4740", VA = "0x1850C5F40", Slot = "11")]
	public void BCKGPNKBBNF(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(RVA = "0x50C62B0", Offset = "0x50C4AB0", VA = "0x1850C62B0")]
	private HMMELKFLGKD GMMEHKHJGCG(int AKLHCIJHJKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x50C5E20", Offset = "0x50C4620", VA = "0x1850C5E20", Slot = "6")]
	public HMMELKFLGKD ANIGAEEOCNL(OMOEODCFEGL EMMPAJPIILL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x50C6470", Offset = "0x50C4C70", VA = "0x1850C6470", Slot = "15")]
	public MIPCILJMDGJ KJPBFOEADCJ(OMOEODCFEGL EMMPAJPIILL)
	{
		return default(MIPCILJMDGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x50C6390", Offset = "0x50C4B90", VA = "0x1850C6390", Slot = "7")]
	public IEnumerator<HMMELKFLGKD> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x50C6390", Offset = "0x50C4B90", VA = "0x1850C6390", Slot = "8")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x3161E20", Offset = "0x3160620", VA = "0x183161E20", Slot = "12")]
	public void PLCDFANINMD<TKey, T>(global::KMAABHDKKLE<TKey, T> IOADAIMHMFG, [Optional] object ALLCABKLNNG) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x50C6190", Offset = "0x50C4990", VA = "0x1850C6190", Slot = "13")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public HJDMBNNIBDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x50C5E10", Offset = "0x50C4610", VA = "0x1850C5E10")]
	[CompilerGenerated]
	private HMMELKFLGKD DBLEAEJKAIC(int GDBELOJNNFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[OJBFCHOEMHJ(typeof(HFEGCOONMAM))]
[CEFINOONOIN(typeof(KFEICEPFNDF), new string[] { })]
internal class KFEICEPFNDF : DKFAOOPHPAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private HFEGCOONMAM LMKNNIPOPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private FBFMOHPHODB EMPDGALOEMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private AINBLNOJEEC ONDLHCOJKIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private DNHMPLANJOC EEOLILGBGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private global::NDHHJFCALDI<AIGPFJAOAFB> EHFBBJILGFE;

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public BACGAADCGAE DFFPCFHODAA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x5F99A0", Offset = "0x5F81A0", VA = "0x1805F99A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x6D6440", Offset = "0x6D4C40", VA = "0x1806D6440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x50CC910", Offset = "0x50CB110", VA = "0x1850CC910", Slot = "4")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x50CCA10", Offset = "0x50CB210", VA = "0x1850CCA10")]
	private void EOPMGBEBGAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x12E70B0", Offset = "0x12E58B0", VA = "0x1812E70B0")]
	public T KBPLGNOELGP<T>() where T : AIGPFJAOAFB
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x50CCBD0", Offset = "0x50CB3D0", VA = "0x1850CCBD0")]
	public NOPBMJOJCGP IKPCDFAFAJF(OMOEODCFEGL JNAACNJBHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	public global::MEBPHBGNBLO<T> IKPCDFAFAJF<T>(OMOEODCFEGL JNAACNJBHOF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x50CCB00", Offset = "0x50CB300", VA = "0x1850CCB00")]
	public HMMELKFLGKD HLFGLBABHCN(OMOEODCFEGL JNAACNJBHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x4F28210", Offset = "0x4F26A10", VA = "0x184F28210")]
	public global::BPPGPOODLGE<T> HLFGLBABHCN<T>(OMOEODCFEGL JNAACNJBHOF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x50CCCA0", Offset = "0x50CB4A0", VA = "0x1850CCCA0")]
	public NJFOBBNGILB ILGDEJOEOJP(OMOEODCFEGL JNAACNJBHOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	public global::KONLOKIOKCA<T> ILGDEJOEOJP<T>(OMOEODCFEGL JNAACNJBHOF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public KFEICEPFNDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
internal static class CDHAGBINEIK
{
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0xDA1D60", Offset = "0xDA0560", VA = "0x180DA1D60")]
	public static global::MEBPHBGNBLO<T> IKPCDFAFAJF<T>(this KFEICEPFNDF DFHCGIKDFPL, global::NNAELPPPNEG<T> JNAACNJBHOF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	public static global::BPPGPOODLGE<T> HLFGLBABHCN<T>(this KFEICEPFNDF DFHCGIKDFPL, global::NNAELPPPNEG<T> JNAACNJBHOF) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	public static global::KONLOKIOKCA<T> ILGDEJOEOJP<T>(this KFEICEPFNDF DFHCGIKDFPL, global::NNAELPPPNEG<T> JNAACNJBHOF) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[CEFINOONOIN(typeof(GJAJFGFOJLK), new string[] { })]
public sealed class GJAJFGFOJLK : DKFAOOPHPAH, GHNBGLLDFLL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class BNOAAFFGBLJ : IEnumerable<RRCustomPropTag>, IEnumerable, IEnumerator<RRCustomPropTag>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private RRCustomPropTag <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private List<RRCustomPropTag> <list>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <i>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private GameObject[] <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private List<RRCustomPropTag>.Enumerator <>7__wrap5;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		RRCustomPropTag IEnumerator<RRCustomPropTag>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x61A260", Offset = "0x618A60", VA = "0x18061A260")]
		[DebuggerHidden]
		public BNOAAFFGBLJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x503EB80", Offset = "0x503D380", VA = "0x18503EB80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x503E800", Offset = "0x503D000", VA = "0x18503E800", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x503EC20", Offset = "0x503D420", VA = "0x18503EC20")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x503EB30", Offset = "0x503D330", VA = "0x18503EB30", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x503EAA0", Offset = "0x503D2A0", VA = "0x18503EAA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<RRCustomPropTag> IEnumerable<RRCustomPropTag>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x503EAA0", Offset = "0x503D2A0", VA = "0x18503EAA0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const string ENCMPJFEIAO = "CustomPropsAreAlwaysEmbodied";

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly Dictionary<SerializableGuid, MINFGCMJKBL> NHDHHPMPACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly List<SerializableGuid> GHMFEPKJJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly Dictionary<SerializableGuid, GameObject> PCNDCGBMEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private FOJPBIGOEBJ NLJLBCPPCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private AINBLNOJEEC AFJGLEGGBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private ENJAHHPPGPN AGONKCODOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private FCGCJNHMCDH HAFBOCLMCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private HFEGCOONMAM LMKNNIPOPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private ADAIPEODNMG KKMCNGMCKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private global::FMGDPJPCCFA<MINFGCMJKBL> AFGEKIHIGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private GameObject PPFEFJEJHKH;

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x5049620", Offset = "0x5047E20", VA = "0x185049620", Slot = "4")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x5049120", Offset = "0x5047920", VA = "0x185049120", Slot = "5")]
	public void BCKGPNKBBNF(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x50494D0", Offset = "0x5047CD0", VA = "0x1850494D0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x5049970", Offset = "0x5048170", VA = "0x185049970")]
	private void LPIOLJJEJKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x5049980", Offset = "0x5048180", VA = "0x185049980")]
	internal void MCCMDMHCCOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x50497A0", Offset = "0x5047FA0", VA = "0x1850497A0")]
	private void LKFDACALFDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x50493F0", Offset = "0x5047BF0", VA = "0x1850493F0")]
	private void DNJKOLNNOPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x50496F0", Offset = "0x5047EF0", VA = "0x1850496F0")]
	[IteratorStateMachine(typeof(BNOAAFFGBLJ))]
	private IEnumerable<RRCustomPropTag> GCMIJLFILGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x504A250", Offset = "0x5048A50", VA = "0x18504A250")]
	private void PILEAKMMOLO(CFBEFPIPHOM LEPHKDIHJFD, in BJHFEKKLKGB OEFKKBELGHM, in BJHFEKKLKGB JFBNMEBIPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x50492E0", Offset = "0x5047AE0", VA = "0x1850492E0")]
	private void DAFBLBFDDID(SerializableGuid NKEBGFDENCD, GameObject KFNNOPCEBCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x5049F10", Offset = "0x5048710", VA = "0x185049F10")]
	private void OBOKGBIJFEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x5049D60", Offset = "0x5048560", VA = "0x185049D60")]
	private bool NNKFPNHEFJM(MINFGCMJKBL BCDIBHFAEEF, Transform CELKNCFBAOE, out GameObject LHFAIDGNGGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x5049750", Offset = "0x5047F50", VA = "0x185049750")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x504A680", Offset = "0x5048E80", VA = "0x18504A680")]
	public GJAJFGFOJLK()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public sealed class RRCustomPropTag : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[SerializeField]
		private SerializableGuid guid;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public SerializableGuid IPJLCAGIGAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x68E570", Offset = "0x68CD70", VA = "0x18068E570")]
			get
			{
				return default(SerializableGuid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0xE5E250", Offset = "0xE5CA50", VA = "0x180E5E250")]
		[ContextMenu("Generate Guid")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x628F80", Offset = "0x627780", VA = "0x180628F80")]
		public RRCustomPropTag()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[CEFINOONOIN(typeof(DGGIPLGOKHJ), new string[] { })]
public class LABIEHJFAHD : DKFAOOPHPAH, DGGIPLGOKHJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private const string MKIIJBFNLFM = "ScopeService";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private BKIEEIBJMKG NENEJICOPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private FOJPBIGOEBJ NLJLBCPPCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private DEGKEFODIJP KHFIJNGHNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private BOMMAODPLGI KABIKJDADHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private ObjectEmbodimentService MDLJNEBAIPD;

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public CFBEFPIPHOM OHCJLKLDMPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x68E570", Offset = "0x68CD70", VA = "0x18068E570", Slot = "7")]
		get
		{
			return default(CFBEFPIPHOM);
		}
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(RVA = "0x50CF570", Offset = "0x50CDD70", VA = "0x1850CF570", Slot = "8")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public BKIEEIBJMKG NMKJGNNIJAO
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x68E570", Offset = "0x68CD70", VA = "0x18068E570", Slot = "9")]
		get
		{
			return default(BKIEEIBJMKG);
		}
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x50CF570", Offset = "0x50CDD70", VA = "0x1850CF570", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	public event KCAPIKBFAKO BBGCFIDDLAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x50CFBF0", Offset = "0x50CE3F0", VA = "0x1850CFBF0", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x50CF760", Offset = "0x50CDF60", VA = "0x1850CF760", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x50CF270", Offset = "0x50CDA70", VA = "0x1850CF270", Slot = "4")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x50CF1A0", Offset = "0x50CD9A0", VA = "0x1850CF1A0", Slot = "16")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x50CF460", Offset = "0x50CDC60", VA = "0x1850CF460", Slot = "11")]
	public CFBEFPIPHOM GHFKNMIKJEG(CFBEFPIPHOM KILCGFPNBMC, CFBEFPIPHOM BBAPJHOFLJP)
	{
		return default(CFBEFPIPHOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600032E")]
	[Cpp2IlInjected.Address(RVA = "0x50CF9D0", Offset = "0x50CE1D0", VA = "0x1850CF9D0", Slot = "12")]
	public bool MAIKBHHOMHF(CFBEFPIPHOM KILCGFPNBMC, CFBEFPIPHOM BBAPJHOFLJP, out CFBEFPIPHOM JDBIDILANEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032F")]
	[Cpp2IlInjected.Address(RVA = "0x50CF340", Offset = "0x50CDB40", VA = "0x1850CF340", Slot = "13")]
	public void EKIBEIGCHHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x50CF170", Offset = "0x50CD970", VA = "0x1850CF170", Slot = "14")]
	public void CLJHKKIDENI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x50CFAD0", Offset = "0x50CE2D0", VA = "0x1850CFAD0", Slot = "15")]
	public bool MNIGEBADBKD(CFBEFPIPHOM GPGPHLEMPIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x50CF800", Offset = "0x50CE000", VA = "0x1850CF800")]
	private bool LPLPFKCODCC(CFBEFPIPHOM DIKBIKHEGLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x50CF590", Offset = "0x50CDD90", VA = "0x1850CF590")]
	private void JKPKFGDHGCA(BKIEEIBJMKG DEGGOOGCHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public LABIEHJFAHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[CEFINOONOIN(typeof(BOMMAODPLGI), new string[] { })]
public class CLLMHFPOCOM : DKFAOOPHPAH, BOMMAODPLGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private EntityManager FNBDEMCEOPA;

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x5041090", Offset = "0x503F890", VA = "0x185041090", Slot = "4")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x5041020", Offset = "0x503F820", VA = "0x185041020", Slot = "5")]
	public void DEBIPMHGPHG(CFBEFPIPHOM MEDLGIKFPNL, bool CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0xB53420", Offset = "0xB51C20", VA = "0x180B53420")]
	private void HEMBJNPDPPJ<T>(CFBEFPIPHOM MEDLGIKFPNL, bool CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public CLLMHFPOCOM()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[DOHCKPDOJMD(PAPAHBCPMGP.RenderEffects)]
	[CEFINOONOIN(typeof(DIAELLIMJAK), new string[] { })]
	public class SelectionService : DKFAOOPHPAH, DIAELLIMJAK
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private EntityManager FNBDEMCEOPA;

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0xE5E2D0", Offset = "0xE5CAD0", VA = "0x180E5E2D0", Slot = "4")]
		public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0xE5E3B0", Offset = "0xE5CBB0", VA = "0x180E5E3B0", Slot = "5")]
		public void NPBCOPCMENI(CFBEFPIPHOM MEDLGIKFPNL, bool CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0xE5E340", Offset = "0xE5CB40", VA = "0x180E5E340", Slot = "6")]
		public void FCDHMLDDIEE(CFBEFPIPHOM MEDLGIKFPNL, bool CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0xB53420", Offset = "0xB51C20", VA = "0x180B53420")]
		private void HEMBJNPDPPJ<T>(CFBEFPIPHOM MEDLGIKFPNL, bool CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public SelectionService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[CEFINOONOIN(typeof(NBEIBLIFPGD), new string[] { })]
public class AMOICONDOPE : NBEIBLIFPGD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private bool CNADJDKPEJP;

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public bool PIIGAGDECED
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6358A0", Offset = "0x6340A0", VA = "0x1806358A0", Slot = "4")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x503CF60", Offset = "0x503B760", VA = "0x18503CF60", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	public event Action<bool> COONBLCBNMA
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x503CE20", Offset = "0x503B620", VA = "0x18503CE20", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x503CEC0", Offset = "0x503B6C0", VA = "0x18503CEC0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public AMOICONDOPE()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CEFINOONOIN(typeof(FCGCJNHMCDH), new string[] { })]
	[DOHCKPDOJMD(PAPAHBCPMGP.Serialization, new string[] { "Timing" })]
	public class SerializationService : DKFAOOPHPAH, FCGCJNHMCDH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		private struct PHBPDHGFPAB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			public LIIIPBEHNDK HOEEMPBIEJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			public LIIIPBEHNDK MFPMMGJNOCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
			[Cpp2IlInjected.Token(Token = "0x400012B")]
			public LIIIPBEHNDK CCCMDJEPFBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			public LIIIPBEHNDK HMBACJPKPEC;

			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0xE5A360", Offset = "0xE58B60", VA = "0x180E5A360")]
			public static PHBPDHGFPAB NNHCHCFNJFN()
			{
				return default(PHBPDHGFPAB);
			}

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
			[Conditional("DEBUG_WORLDS")]
			public void KFAGLIPHBHL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private struct LIIIPBEHNDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
			public LIIIPBEHNDK(string IIFJOCIBPGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
			public void GBMPOEGKMCI(EntityManager IIFJOCIBPGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
			public void KFAGLIPHBHL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private const string HCGCJGFPGOI = "Timing";

		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private static readonly FLAFLKKHHEA PONIDKHMHNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private FBKJAGMDHMF GPHFNNBDCHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private HFEGCOONMAM LMKNNIPOPLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private NBEIBLIFPGD GFNNFDLOINI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private FOJPBIGOEBJ NLJLBCPPCEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private SerializationRemapScope HKKEDPNHGPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private BAEDAPKGADH DJMDBGODMGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private HEFFJMOCEIC OILKEJABGEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private bool? JDPPINOPJDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x72")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private PHBPDHGFPAB BFFCJCDCAKO;

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool DALJHAPDDMA
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0xE5F530", Offset = "0xE5DD30", VA = "0x180E5F530", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xE5FCE0", Offset = "0xE5E4E0", VA = "0x180E5FCE0", Slot = "26")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000C")]
		public event Action JFFAIIABHKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0xE5EAF0", Offset = "0xE5D2F0", VA = "0x180E5EAF0", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xE5EE40", Offset = "0xE5D640", VA = "0x180E5EE40", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000D")]
		public event Action<LHHFLKFIFDL> PACIOEMMGKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0xE5FCF0", Offset = "0xE5E4F0", VA = "0x180E5FCF0", Slot = "21")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xE60C90", Offset = "0xE5F490", VA = "0x180E60C90", Slot = "22")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000E")]
		public event Action ECBGBFEFLPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0xE5F490", Offset = "0xE5DC90", VA = "0x180E5F490", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0xE60BB0", Offset = "0xE5F3B0", VA = "0x180E60BB0", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400000F")]
		public event Action NDPELOONAKM
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0xE5F7D0", Offset = "0xE5DFD0", VA = "0x180E5F7D0", Slot = "9")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0xE5FC40", Offset = "0xE5E440", VA = "0x180E5FC40", Slot = "10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000010")]
		public event Action<LHHFLKFIFDL> IALMDFAABDH
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0xE60A80", Offset = "0xE5F280", VA = "0x180E60A80", Slot = "23")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0xE61A00", Offset = "0xE60200", VA = "0x180E61A00", Slot = "24")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0xE5F8D0", Offset = "0xE5E0D0", VA = "0x180E5F8D0", Slot = "4")]
		public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "20")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0xE60480", Offset = "0xE5EC80", VA = "0x180E60480", Slot = "11")]
		public void IBNNJBDJGFI(bool MAGFABKGNKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0xE5EEE0", Offset = "0xE5D6E0", VA = "0x180E5EEE0", Slot = "13")]
		public ByteString BAGHAKDDGPK(out IDisposable HKKEDPNHGPK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0xE5F140", Offset = "0xE5D940", VA = "0x180E5F140", Slot = "12")]
		public ByteString BAGHAKDDGPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0xE60C50", Offset = "0xE5F450", VA = "0x180E60C50", Slot = "16")]
		public bool JDKEMADGCJE(ByteString LHBBKEDIBLE, AAEGGCGNJEL AGFHKAICCAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0xE61790", Offset = "0xE5FF90", VA = "0x180E61790", Slot = "17")]
		public bool ODKGJHJEKNG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0xE614C0", Offset = "0xE5FCC0", VA = "0x180E614C0", Slot = "14")]
		public void MFDBKIPJIIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0xE61860", Offset = "0xE60060", VA = "0x180E61860", Slot = "27")]
		public void OHJHBHEOLKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0xE5F2F0", Offset = "0xE5DAF0", VA = "0x180E5F2F0", Slot = "15")]
		public void BMDAHBGMMID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0xE60790", Offset = "0xE5EF90", VA = "0x180E60790", Slot = "18")]
		public bool IFPNJNOFHPP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0xE5F540", Offset = "0xE5DD40", VA = "0x180E5F540", Slot = "19")]
		public bool COJMMEGIOJN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0xE61AA0", Offset = "0xE602A0", VA = "0x180E61AA0")]
		private void PFAIEBMLJAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0xE60460", Offset = "0xE5EC60", VA = "0x180E60460")]
		private void HOIGGNBEPIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0xE60D30", Offset = "0xE5F530", VA = "0x180E60D30")]
		private void JPBONKJFMOG(DPHGPHNEGBI GBOBFMNNGDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0xE5F870", Offset = "0xE5E070", VA = "0x180E5F870")]
		private ByteString DJGMJFPPMNH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0xE614D0", Offset = "0xE5FCD0", VA = "0x180E614D0")]
		private ByteString MLPCJDLFBFL(ByteString HDPBFIPIIDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0xE60390", Offset = "0xE5EB90", VA = "0x180E60390")]
		private bool HILDHFJODDK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0xE60E50", Offset = "0xE5F650", VA = "0x180E60E50")]
		private void KGOPKPBAMCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0xE60040", Offset = "0xE5E840", VA = "0x180E60040")]
		private void HDBNDDBCIJK(out ByteString HDPBFIPIIDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0xE611C0", Offset = "0xE5F9C0", VA = "0x180E611C0")]
		private bool MCOOCBEJPGG(ByteString LHBBKEDIBLE, AAEGGCGNJEL AGFHKAICCAO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0xE5EB90", Offset = "0xE5D390", VA = "0x180E5EB90")]
		private bool AENGMLLPLHG(ByteString LHBBKEDIBLE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0xE5F9D0", Offset = "0xE5E1D0", VA = "0x180E5F9D0")]
		private bool EKNOLLIHJHB(HEFFJMOCEIC.EIDMIABKLDM.LCEHHNNAPJJ DEOJEDAGPED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0xE5FD90", Offset = "0xE5E590", VA = "0x180E5FD90")]
		private void GNDOENHNHNO(LHHFLKFIFDL GBOBFMNNGDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0xE5FBA0", Offset = "0xE5E3A0", VA = "0x180E5FBA0")]
		private DPHGPHNEGBI ENCADJLDLIB(EntityManager GIMHPNFOOOP, EntityManager JKPLEMDGMMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0xE615D0", Offset = "0xE5FDD0", VA = "0x180E615D0")]
		private void NNNGJDNINLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0xE605D0", Offset = "0xE5EDD0", VA = "0x180E605D0")]
		private void IDPJIGKEBOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0xE5F790", Offset = "0xE5DF90", VA = "0x180E5F790")]
		private void DGHKJCODKMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0xE60B20", Offset = "0xE5F320", VA = "0x180E60B20")]
		private HEFFJMOCEIC.EIDMIABKLDM.LCEHHNNAPJJ IHOGKLCPILB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public SerializationService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[CEFINOONOIN(typeof(AKKMCDBNALD), new string[] { })]
public class AKKMCDBNALD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private readonly Dictionary<JPMNNMNBHIP, string> KJOJEDGKAEL;

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x503CB20", Offset = "0x503B320", VA = "0x18503CB20")]
	public GameObject DIDFKKDCLGH(JPMNNMNBHIP KBFNMONPHFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x503CBD0", Offset = "0x503B3D0", VA = "0x18503CBD0")]
	public AKKMCDBNALD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[CEFINOONOIN(typeof(MOHILIKEMJO), new string[] { })]
public class IEAJFCJEOPN : MOHILIKEMJO
{
	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x50C6DA0", Offset = "0x50C55A0", VA = "0x1850C6DA0", Slot = "5")]
	public void GDOCEJENNAC(object MEKFJFMIPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x50C6CE0", Offset = "0x50C54E0", VA = "0x1850C6CE0", Slot = "6")]
	public void BBAMLHAJCMB(object MEKFJFMIPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x50C6E60", Offset = "0x50C5660", VA = "0x1850C6E60", Slot = "7")]
	public void LEANCOPEJOH(object MEKFJFMIPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x50C6F20", Offset = "0x50C5720", VA = "0x1850C6F20", Slot = "4")]
	public IDisposable MHDMKDHEJNK(object MEKFJFMIPGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public IEAJFCJEOPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
[CEFINOONOIN(typeof(HCGLAJOCALO), new string[] { })]
public class OONFDCBPFIP : DKFAOOPHPAH, HCGLAJOCALO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private HFEGCOONMAM LMKNNIPOPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private CKLENHMGEIH POFKJMFPBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private NBEIBLIFPGD IMBKEKDGMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private TransformOwnershipPhase LLHFKMDNGLL;

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0xE57640", Offset = "0xE55E40", VA = "0x180E57640", Slot = "4")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0xE57760", Offset = "0xE55F60", VA = "0x180E57760", Slot = "6")]
	public void MJGHHDLHBGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0xE572E0", Offset = "0xE55AE0", VA = "0x180E572E0", Slot = "5")]
	public void CGHJIKEEDBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0xE57860", Offset = "0xE56060", VA = "0x180E57860", Slot = "7")]
	public void OIBDPPPLFAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0xE571E0", Offset = "0xE559E0", VA = "0x180E571E0", Slot = "8")]
	public void BFIFEKCCGLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0xE57480", Offset = "0xE55C80", VA = "0x180E57480", Slot = "9")]
	public void DIGEMLMICNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0xE576F0", Offset = "0xE55EF0", VA = "0x180E576F0", Slot = "10")]
	public void LGBICGPCPBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0xE573E0", Offset = "0xE55BE0", VA = "0x180E573E0", Slot = "11")]
	public void DFFPPODOBNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public OONFDCBPFIP()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CEFINOONOIN(typeof(HIPDIEDHHMJ), new string[] { })]
	[DOHCKPDOJMD(PAPAHBCPMGP.TransformSyncing)]
	public class TransformService : HIPDIEDHHMJ, DKFAOOPHPAH, GHNBGLLDFLL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private HFEGCOONMAM LMKNNIPOPLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private FOJPBIGOEBJ NLJLBCPPCEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private DEGKEFODIJP KHFIJNGHNDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private TransformOwnershipPhase DILKPMNAECF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private global::MEBPHBGNBLO<Entity> CELKNCFBAOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private ObjectEmbodimentService DMLIGOGCPEG;

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		private EntityManager BNFBCOAMLJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0xBAFB60", Offset = "0xBAE360", VA = "0x180BAFB60")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		private ADAIPEODNMG HOCMGGGFBDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0xBAC040", Offset = "0xBAA840", VA = "0x180BAC040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0xBABF70", Offset = "0xBAA770", VA = "0x180BABF70", Slot = "33")]
		public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0xBAB1A0", Offset = "0xBA99A0", VA = "0x180BAB1A0", Slot = "34")]
		public void BCKGPNKBBNF(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0xBABEF0", Offset = "0xBAA6F0", VA = "0x180BABEF0", Slot = "35")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0xBAB610", Offset = "0xBA9E10", VA = "0x180BAB610", Slot = "36")]
		public bool CHEDKKCEBGO(Transform EOBPGPELLLJ, out CFBEFPIPHOM LEPHKDIHJFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0xBAB480", Offset = "0xBA9C80", VA = "0x180BAB480", Slot = "37")]
		public Transform CANJLIECPNJ(Entity NBIJCGHBCCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0xBAE8A0", Offset = "0xBAD0A0", VA = "0x180BAE8A0", Slot = "31")]
		public bool KFAIBMCBPEJ(Entity NBIJCGHBCCI, out Transform EOBPGPELLLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0xBABA70", Offset = "0xBAA270", VA = "0x180BABA70")]
		private void DGCNOIOEGJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0xBAD380", Offset = "0xBABB80", VA = "0x180BAD380", Slot = "30")]
		public void IGENMEJMCEG(Entity NBIJCGHBCCI, out Matrix4x4 DBDABIIGHGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0xBAEFD0", Offset = "0xBAD7D0", VA = "0x180BAEFD0", Slot = "4")]
		public void NNFMMHNMGDP(Entity NBIJCGHBCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xBAF7A0", Offset = "0xBADFA0", VA = "0x180BAF7A0")]
		private void OPLFOGHGLMM(Entity NBIJCGHBCCI, Vector3 NDFADLNAIEP, Quaternion DEOODMICGDD, Vector3 HFOIPKHMCBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0xBAC410", Offset = "0xBAAC10", VA = "0x180BAC410")]
		private void FEIHKFDGKFL(Entity NBIJCGHBCCI, Vector3 NDFADLNAIEP, Quaternion DEOODMICGDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0xBAD370", Offset = "0xBABB70", VA = "0x180BAD370", Slot = "28")]
		public void IFIDHGKCBNB(Entity NBIJCGHBCCI, out Matrix4x4 CDGLHEJLHNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0xBABA90", Offset = "0xBAA290", VA = "0x180BABA90")]
		public void DHBBMBKEDLI(Entity NBIJCGHBCCI, in Matrix4x4 DBDABIIGHGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0xBAF950", Offset = "0xBAE150", VA = "0x180BAF950")]
		private void PAEDFCMPPLL(Entity NBIJCGHBCCI, in Matrix4x4 JOLDEMJPCFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xBAF670", Offset = "0xBADE70", VA = "0x180BAF670", Slot = "5")]
		public void OMLCGAIBOJA(Entity NBIJCGHBCCI, Vector3 CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0xBAC940", Offset = "0xBAB140", VA = "0x180BAC940", Slot = "6")]
		public Vector3 FOFKBPCDHCC(Entity NBIJCGHBCCI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xBAFE10", Offset = "0xBAE610", VA = "0x180BAFE10", Slot = "7")]
		public void PFHEPKJLKOF(Entity NBIJCGHBCCI, Quaternion CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0xBAC2B0", Offset = "0xBAAAB0", VA = "0x180BAC2B0", Slot = "8")]
		public Quaternion FCNFIPICALP(Entity NBIJCGHBCCI)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xBAFF60", Offset = "0xBAE760", VA = "0x180BAFF60", Slot = "13")]
		public void PPGBCHDDCHP(Entity NBIJCGHBCCI, Vector3 CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0xBADED0", Offset = "0xBAC6D0", VA = "0x180BADED0", Slot = "12")]
		public Vector3 JBIEIPJKHEE(Entity NBIJCGHBCCI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0xBAE010", Offset = "0xBAC810", VA = "0x180BAE010")]
		private void JCKMHLHHLKA(Entity NBIJCGHBCCI, Vector3 CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0xBAB540", Offset = "0xBA9D40", VA = "0x180BAB540")]
		private Vector3 CFKGLDKPHDI(Entity NBIJCGHBCCI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xBACB50", Offset = "0xBAB350", VA = "0x180BACB50", Slot = "15")]
		public float HIEDNFCJPCA(Entity NBIJCGHBCCI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0xBAEA80", Offset = "0xBAD280", VA = "0x180BAEA80", Slot = "14")]
		public void LHCHEMGBINM(Entity NBIJCGHBCCI, float CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0xBAEEF0", Offset = "0xBAD6F0", VA = "0x180BAEEF0")]
		private float NBMFGBLNBKJ(Entity NBIJCGHBCCI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xBAB110", Offset = "0xBA9910", VA = "0x180BAB110")]
		private void AIEPKNMALLK(Entity NBIJCGHBCCI, float AFJBCCBMFDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0xBAC1D0", Offset = "0xBAA9D0", VA = "0x180BAC1D0", Slot = "17")]
		public Vector3 EMGOAMPKKGE(Entity NBIJCGHBCCI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0xBAB8F0", Offset = "0xBAA0F0", VA = "0x180BAB8F0", Slot = "16")]
		public void CKIGJDHKJHC(Entity NBIJCGHBCCI, Vector3 BCFMPMAAJJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0xBAD550", Offset = "0xBABD50", VA = "0x180BAD550")]
		private Vector3 IGJPJMBADIA(Entity NBIJCGHBCCI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0xBAC100", Offset = "0xBAA900", VA = "0x180BAC100")]
		private void EIGJNCFJFPF(Entity NBIJCGHBCCI, Vector3 CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xBAE2E0", Offset = "0xBACAE0", VA = "0x180BAE2E0")]
		[Conditional("DEBUG_BUILD")]
		private void JFPKKGNFFPO(Entity NBIJCGHBCCI, Vector3 CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0xBAB2A0", Offset = "0xBA9AA0", VA = "0x180BAB2A0", Slot = "9")]
		public void BKIMJMIPHBH(Entity NBIJCGHBCCI, Vector3 BAFCICKIIDG, Quaternion ALKIIOKOBPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0xBAE0B0", Offset = "0xBAC8B0", VA = "0x180BAE0B0", Slot = "10")]
		public void JCOCHMIBGHF(Entity NBIJCGHBCCI, out Vector3 BAFCICKIIDG, out Quaternion ALKIIOKOBPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0xBAC6C0", Offset = "0xBAAEC0", VA = "0x180BAC6C0", Slot = "11")]
		public void FKJLMKDKIFB(Entity NBIJCGHBCCI, out Vector3 BAFCICKIIDG, out Quaternion ALKIIOKOBPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0xBAFBB0", Offset = "0xBAE3B0", VA = "0x180BAFBB0", Slot = "18")]
		public void PFGIPJBCEHB(Entity NBIJCGHBCCI, Vector3 CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0xBAC560", Offset = "0xBAAD60", VA = "0x180BAC560", Slot = "19")]
		public Vector3 FGIJGFMAGEB(Entity NBIJCGHBCCI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0xBAE5C0", Offset = "0xBACDC0", VA = "0x180BAE5C0", Slot = "20")]
		public void KBAMKMOPIEE(Entity NBIJCGHBCCI, Quaternion CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0xBAE980", Offset = "0xBAD180", VA = "0x180BAE980", Slot = "21")]
		public Quaternion KPECDGKPIDK(Entity NBIJCGHBCCI)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0xBAF290", Offset = "0xBADA90", VA = "0x180BAF290", Slot = "23")]
		public void OFNKNCBDEAE(Entity NBIJCGHBCCI, Vector3 CJMMBFLIBMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xBACA50", Offset = "0xBAB250", VA = "0x180BACA50", Slot = "22")]
		public Vector3 GJKGHMFKPIF(Entity NBIJCGHBCCI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0xBAEBF0", Offset = "0xBAD3F0", VA = "0x180BAEBF0", Slot = "24")]
		public void MPLLAANJBNG(Entity NBIJCGHBCCI, float ENGDFGHFGME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0xBAE4A0", Offset = "0xBACCA0", VA = "0x180BAE4A0", Slot = "25")]
		public float JMBJHIBKJDM(Entity NBIJCGHBCCI)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xBAD670", Offset = "0xBABE70", VA = "0x180BAD670", Slot = "26")]
		public void IKIIOKEPGHI(Entity NBIJCGHBCCI, Vector3 MBFPPHLJNAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0xBAB7A0", Offset = "0xBA9FA0", VA = "0x180BAB7A0", Slot = "27")]
		public Vector3 CHIDJLFBBNO(Entity NBIJCGHBCCI)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xBACBF0", Offset = "0xBAB3F0", VA = "0x180BACBF0", Slot = "32")]
		public void HNLDCIKCBDF(Entity NBIJCGHBCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xBADBF0", Offset = "0xBAC3F0", VA = "0x180BADBF0")]
		private void IMJPDEMMKFO(Entity NBIJCGHBCCI, in BJHFEKKLKGB OEFKKBELGHM, in BJHFEKKLKGB JFBNMEBIPAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xBADAC0", Offset = "0xBAC2C0", VA = "0x180BADAC0")]
		private void IMJPDEMMKFO(Entity NBIJCGHBCCI, in Entity NHAJDPLICDA, in Entity ACODEJEKDBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0xBAE260", Offset = "0xBACA60", VA = "0x180BAE260")]
		private CBCBLOOOOCG JCOCHMIBGHF(Entity NBIJCGHBCCI)
		{
			return default(CBCBLOOOOCG);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0xBAC860", Offset = "0xBAB060", VA = "0x180BAC860")]
		private bool FNGCHLJJHHN(Entity NBIJCGHBCCI, out Entity CELKNCFBAOE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xBADCB0", Offset = "0xBAC4B0", VA = "0x180BADCB0")]
		private void IOAKEDDPFFH(Entity NBIJCGHBCCI, out Matrix4x4 DBDABIIGHGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0xBACFF0", Offset = "0xBAB7F0", VA = "0x180BACFF0")]
		public void IDBFFDKKGJH(Entity NBIJCGHBCCI, out Matrix4x4 JOLDEMJPCFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public TransformService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0xBABA60", Offset = "0xBAA260", VA = "0x180BABA60", Slot = "29")]
		private void CPCMONNFAGG(Entity NBIJCGHBCCI, in Matrix4x4 CDGLHEJLHNI)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[CEFINOONOIN(typeof(JPCKFLHNHDI), new string[] { })]
public class JPCKFLHNHDI
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct FHFGNBOCEKP : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private readonly JPCKFLHNHDI CELKNCFBAOE;

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x50C5D50", Offset = "0x50C4550", VA = "0x1850C5D50")]
		public FHFGNBOCEKP(JPCKFLHNHDI CELKNCFBAOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x50C5D10", Offset = "0x50C4510", VA = "0x1850C5D10", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private int DFMHHDOCEHG;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool CFNFMNGFPDB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x44861E0", Offset = "0x44849E0", VA = "0x1844861E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000011")]
	public event Action FDDONBDLMGC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x50CB340", Offset = "0x50C9B40", VA = "0x1850CB340")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x50CB3E0", Offset = "0x50C9BE0", VA = "0x1850CB3E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x50CB4A0", Offset = "0x50C9CA0", VA = "0x1850CB4A0")]
	public FHFGNBOCEKP LGKPDPNHBOL()
	{
		return default(FHFGNBOCEKP);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x20B58F0", Offset = "0x20B40F0", VA = "0x1820B58F0")]
	public void AEFDAAEMODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x50CB480", Offset = "0x50C9C80", VA = "0x1850CB480")]
	public void LBKLLANPPNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public JPCKFLHNHDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[CEFINOONOIN(typeof(HFEGCOONMAM), new string[] { })]
[OJBFCHOEMHJ(typeof(NIPPBJJLFPM))]
public class HGOMDMPADBH : HFEGCOONMAM, IDisposable, JIOLBCKAPBA, CMBMJNFKKCN, DKFAOOPHPAH, GHNBGLLDFLL
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class PGKFJDMOIMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public FBKJAGMDHMF services;

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public PGKFJDMOIMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x50D7D20", Offset = "0x50D6520", VA = "0x1850D7D20")]
		internal void <InitReferences>b__0(DKFAOOPHPAH svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class BFCCLPBMMDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public FBKJAGMDHMF services;

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public BFCCLPBMMDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x50C4440", Offset = "0x50C2C40", VA = "0x1850C4440")]
		internal void <InitExternal>b__0(GHNBGLLDFLL svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly FLAFLKKHHEA APOHKGBDLNO;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly ProfilerMarker JIDADEMBKJO;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly ProfilerMarker FPGDLDHDGJI;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly ProfilerMarker IKGJBFPDGAF;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly ProfilerMarker BJCBEOMBOOJ;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly ProfilerMarker JDDEOEKFJHJ;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly ProfilerMarker GPLHPLOPMOK;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private static readonly ProfilerMarker MNMJCGAGFEJ;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static readonly ProfilerMarker JIBGCEGHEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private FDJJGOGKMHG LMKNNIPOPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private bool NMANPNFCCCL;

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public FDJJGOGKMHG JAGNOKIGICD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public ADAIPEODNMG HOCMGGGFBDD
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x29835A0", Offset = "0x2981DA0", VA = "0x1829835A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public EntityManager BNFBCOAMLJO
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0xEDB1D0", Offset = "0xED99D0", VA = "0x180EDB1D0", Slot = "9")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public GIDONOBPNKN BLAHOJHKOBM
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x6186A0", Offset = "0x616EA0", VA = "0x1806186A0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x637290", Offset = "0x635A90", VA = "0x180637290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000012")]
	public event Action AJPKEHIOGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x504BA60", Offset = "0x504A260", VA = "0x18504BA60", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x504BE20", Offset = "0x504A620", VA = "0x18504BE20", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x504B820", Offset = "0x504A020", VA = "0x18504B820", Slot = "21")]
	public void FNNKDMJCDCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x504B710", Offset = "0x5049F10", VA = "0x18504B710", Slot = "22")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x504AF10", Offset = "0x5049710", VA = "0x18504AF10", Slot = "23")]
	public void BCKGPNKBBNF(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x504B210", Offset = "0x5049A10", VA = "0x18504B210", Slot = "11")]
	public void CAHGKFOGDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x504AFC0", Offset = "0x50497C0", VA = "0x18504AFC0", Slot = "12")]
	public void BGEFLJGNICF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x504BD30", Offset = "0x504A530", VA = "0x18504BD30", Slot = "14")]
	public void NKFIBHOPCHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x504BC20", Offset = "0x504A420", VA = "0x18504BC20", Slot = "15")]
	public void LPLNHNICGJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x504BB00", Offset = "0x504A300", VA = "0x18504BB00", Slot = "13")]
	public void KCELMCCJFKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x504BEC0", Offset = "0x504A6C0", VA = "0x18504BEC0", Slot = "16")]
	public void PKHOCIAIPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x504B430", Offset = "0x5049C30", VA = "0x18504B430", Slot = "17")]
	public void DFMCHFJPHOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x504B340", Offset = "0x5049B40", VA = "0x18504B340", Slot = "18")]
	public void DEDKCCDALPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x504BBF0", Offset = "0x504A3F0", VA = "0x18504BBF0", Slot = "19")]
	public void LEDANGKKEKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x504B300", Offset = "0x5049B00", VA = "0x18504B300", Slot = "24")]
	public void CHDNICDAHOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x504B0B0", Offset = "0x50498B0", VA = "0x18504B0B0")]
	private void BHNJDAHDLKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x504B520", Offset = "0x5049D20", VA = "0x18504B520", Slot = "20")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x504BD10", Offset = "0x504A510", VA = "0x18504BD10", Slot = "10")]
	public ComponentSystemBase NJNMKMBNAAI(Type BKDBLJPNPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x504B7F0", Offset = "0x5049FF0", VA = "0x18504B7F0")]
	public bool EOLJNDGJLOB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public HGOMDMPADBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DefaultMember("Item")]
public class NOCFOAECLPA<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private readonly Func<From, To> NOAHEACFGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly Func<To, From> FCOMJEEDKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public DynamicBuffer<From> POKOCMHLPLN;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public To NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public bool FKKNEPJPEKA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	public NOCFOAECLPA(Func<From, To> NOAHEACFGIF, Func<To, From> FCOMJEEDKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To FJMIPHLNAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To FJMIPHLNAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] FPMNAPBFAMJ, int DDFINIJOFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To FJMIPHLNAEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int AKLHCIJHJKB, To FJMIPHLNAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To FJMIPHLNAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[DefaultMember("Item")]
public class OMDJPPFPKEK<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private readonly Func<From, To> NOAHEACFGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly Func<To, From> FCOMJEEDKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public List<From> BAKFHBILFME;

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public To NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x55DB560", Offset = "0x55D9D60", VA = "0x1855DB560", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x55DB5C0", Offset = "0x55D9DC0", VA = "0x1855DB5C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x55DB530", Offset = "0x55D9D30", VA = "0x1855DB530", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool FKKNEPJPEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000407")]
		[Cpp2IlInjected.Address(RVA = "0x7294F0", Offset = "0x727CF0", VA = "0x1807294F0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0x729510", Offset = "0x727D10", VA = "0x180729510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x55DB4A0", Offset = "0x55D9CA0", VA = "0x1855DB4A0")]
	public OMDJPPFPKEK(Func<From, To> NOAHEACFGIF, Func<To, From> FCOMJEEDKKP, bool OCJHDMOBOMD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x55DB0F0", Offset = "0x55D98F0", VA = "0x1855DB0F0", Slot = "11")]
	public void Add(To FJMIPHLNAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x4E7DBC0", Offset = "0x4E7C3C0", VA = "0x184E7DBC0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x55DB150", Offset = "0x55D9950", VA = "0x1855DB150", Slot = "13")]
	public bool Contains(To FJMIPHLNAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x55DB1B0", Offset = "0x55D99B0", VA = "0x1855DB1B0", Slot = "14")]
	public void CopyTo(To[] FPMNAPBFAMJ, int DDFINIJOFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x55DB2C0", Offset = "0x55D9AC0", VA = "0x1855DB2C0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x55DB330", Offset = "0x55D9B30", VA = "0x1855DB330", Slot = "6")]
	public int IndexOf(To FJMIPHLNAEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x55DB390", Offset = "0x55D9B90", VA = "0x1855DB390", Slot = "7")]
	public void Insert(int AKLHCIJHJKB, To FJMIPHLNAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x55DB440", Offset = "0x55D9C40", VA = "0x1855DB440", Slot = "15")]
	public bool Remove(To FJMIPHLNAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x55DB410", Offset = "0x55D9C10", VA = "0x1855DB410", Slot = "8")]
	public void RemoveAt(int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x5502F40", Offset = "0x5501740", VA = "0x185502F40", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DefaultMember("Item")]
public class JACJMANBCPD<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly Func<From, To> NOAHEACFGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private readonly Func<To, From> FCOMJEEDKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public NativeArray<From> FPMNAPBFAMJ;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public To NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x5100C00", Offset = "0x50FF400", VA = "0x185100C00", Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x5100C50", Offset = "0x50FF450", VA = "0x185100C50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x5100BC0", Offset = "0x50FF3C0", VA = "0x185100BC0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool FKKNEPJPEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(RVA = "0x6120B0", Offset = "0x6108B0", VA = "0x1806120B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0xE2AC20", Offset = "0xE29420", VA = "0x180E2AC20")]
	public JACJMANBCPD(Func<From, To> NOAHEACFGIF, Func<To, From> FCOMJEEDKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x5100780", Offset = "0x50FEF80", VA = "0x185100780", Slot = "11")]
	public void Add(To FJMIPHLNAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x51007D0", Offset = "0x50FEFD0", VA = "0x1851007D0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x5100820", Offset = "0x50FF020", VA = "0x185100820", Slot = "13")]
	public bool Contains(To FJMIPHLNAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x51008E0", Offset = "0x50FF0E0", VA = "0x1851008E0", Slot = "14")]
	public void CopyTo(To[] FPMNAPBFAMJ, int DDFINIJOFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x51009A0", Offset = "0x50FF1A0", VA = "0x1851009A0", Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x5100A60", Offset = "0x50FF260", VA = "0x185100A60", Slot = "6")]
	public int IndexOf(To FJMIPHLNAEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x5100AD0", Offset = "0x50FF2D0", VA = "0x185100AD0", Slot = "7")]
	public void Insert(int AKLHCIJHJKB, To FJMIPHLNAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x5100B70", Offset = "0x50FF370", VA = "0x185100B70", Slot = "15")]
	public bool Remove(To FJMIPHLNAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x5100B20", Offset = "0x50FF320", VA = "0x185100B20", Slot = "8")]
	public void RemoveAt(int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x257EDA0", Offset = "0x257D5A0", VA = "0x18257EDA0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[DefaultMember("Item")]
public class MJFLICKHFOI<From, To> : IList<To>, ICollection<To>, IEnumerable<To>, IEnumerable, IReadOnlyList<To>, IReadOnlyCollection<To> where From : struct, IEquatable<From>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private readonly Func<From, To> NOAHEACFGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private readonly Func<To, From> FCOMJEEDKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public NativeList<From> BAKFHBILFME;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public To NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get
		{
			return (To)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000425")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public bool FKKNEPJPEKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	public MJFLICKHFOI(Func<From, To> NOAHEACFGIF, Func<To, From> FCOMJEEDKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public void Add(To FJMIPHLNAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "13")]
	public bool Contains(To FJMIPHLNAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	public void CopyTo(To[] FPMNAPBFAMJ, int DDFINIJOFGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(Slot = "16")]
	public IEnumerator<To> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public int IndexOf(To FJMIPHLNAEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public void Insert(int AKLHCIJHJKB, To FJMIPHLNAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "15")]
	public bool Remove(To FJMIPHLNAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public void RemoveAt(int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class DOGBFFGPEPL
{
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public const string CAFKGKCLMJP = "Don't Destroy Embodied OM Objects! Use ObjectModel.Disembody(obj) instead!";

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public const string LABMMJOJAHF = "Embodied OM Objects must be kept in the same hierarchy as any Embodied ancestors!";

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public const string OJGHFPAINEG = "Setting parent would have caused a cycle in the hierarchy, preventing modification.";

	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public const string CEFLFLLOMAH = "Networked objects can only be children of Containers or Gizmos";

	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public const string DEKLEJJPLAC = "Networked Objects can only be children of other networked objects";

	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public const string OANBGMKIBOI = "Untracked Transform used as parent";

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public const string KGAFDAHCMIK = "Can't set parent with a dead entity";
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class CNNNHFDMAJK
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class FEIIJCNDMFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public FBKJAGMDHMF services;

		[Cpp2IlInjected.Token(Token = "0x6000438")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public FEIIJCNDMFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(RVA = "0x5044CB0", Offset = "0x50434B0", VA = "0x185044CB0")]
		internal void <InitServices>b__1(DKFAOOPHPAH svc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x5044D10", Offset = "0x5043510", VA = "0x185044D10")]
		internal void <InitServices>b__2(GHNBGLLDFLL svc)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x5041100", Offset = "0x503F900", VA = "0x185041100")]
	public static void EGINKGBLNOM(this FDJJGOGKMHG LMKNNIPOPLE, FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0xB537B0", Offset = "0xB51FB0", VA = "0x180B537B0")]
	public static void EGNBFAGPHLC<T>(this FDJJGOGKMHG LMKNNIPOPLE, Action<T> ONFDLKKBEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0xB538E0", Offset = "0xB520E0", VA = "0x180B538E0")]
	public static void NFDPHIHKCLK<T>(this FDJJGOGKMHG LMKNNIPOPLE, Action<T> ONFDLKKBEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0xB53C50", Offset = "0xB52450", VA = "0x180B53C50")]
	public static void OHKLDIEDOHH<T>(this FDJJGOGKMHG LMKNNIPOPLE, Action<T> ONFDLKKBEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(RVA = "0xB53610", Offset = "0xB51E10", VA = "0x180B53610")]
	public static void AKLEMNGLBKB<T>(this FDJJGOGKMHG LMKNNIPOPLE, Action<T> ONFDLKKBEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0xB53AB0", Offset = "0xB522B0", VA = "0x180B53AB0")]
	public static void NNMLMNDCKEC<T>(this FDJJGOGKMHG LMKNNIPOPLE, Action<T> ONFDLKKBEBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0xB53820", Offset = "0xB52020", VA = "0x180B53820")]
	private static void LEGEBGPBCCK<T>(object EDDAMLAHJFN, Action<T> ONFDLKKBEBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public static class IOBKBOAOKFP
{
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class DIBEDJDOJDF
{
	[Cpp2IlInjected.Token(Token = "0x600043E")]
	public static bool NCBDEMKPHPL<T>(ref T DKLHMFCLOAB, ref T FLEBMPFFCAA) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public static class DBLMNHGMKFL
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class PKGFLONGNLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Transform transform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public Transform target;

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public PKGFLONGNLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x5041380", Offset = "0x503FB80", VA = "0x185041380")]
	public static string FELMDNEGICM(Transform EOBPGPELLLJ, Transform GPGPHLEMPIJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public abstract class DGHMMGAPHAH : MGHPJLKCEOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private readonly MethodInfo PAIMKOLFDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private readonly Type[] MIOMNNIBEOC;

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x5040BE0", Offset = "0x503F3E0", VA = "0x185040BE0")]
	public DGHMMGAPHAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract Action IJFAMDAIFGB();

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(RVA = "0x5041F30", Offset = "0x5040730", VA = "0x185041F30")]
	public MethodInfo ELBLNHNIIEK(Action MJHIGMCCOPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(RVA = "0x5041DA0", Offset = "0x50405A0", VA = "0x185041DA0", Slot = "4")]
	public void DAFBLBFDDID(Type BKDBLJPNPPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public abstract class OHEBKFPOPKH : DGHMMGAPHAH
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private enum DEADAAIFFPA
	{

	}

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x50D58D0", Offset = "0x50D40D0", VA = "0x1850D58D0", Slot = "5")]
	public override Action IJFAMDAIFGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void NHAPEFIDCHE<T>() where T : struct, Enum;

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x50D5950", Offset = "0x50D4150", VA = "0x1850D5950")]
	[Preserve]
	public void KDIOKLJAINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(RVA = "0x50C4B90", Offset = "0x50C3390", VA = "0x1850C4B90")]
	protected OHEBKFPOPKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public abstract class MLKDGGKPOGK : DGHMMGAPHAH
{
	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(RVA = "0x50D32E0", Offset = "0x50D1AE0", VA = "0x1850D32E0", Slot = "5")]
	public override Action IJFAMDAIFGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void KGHEHOPEDLE<T>() where T : JJELBHOACBE;

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x50D3360", Offset = "0x50D1B60", VA = "0x1850D3360")]
	[Preserve]
	public void KDIOKLJAINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(RVA = "0x50C4B90", Offset = "0x50C3390", VA = "0x1850C4B90")]
	protected MLKDGGKPOGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public abstract class CKHBLBBJIGM : DGHMMGAPHAH
{
	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(RVA = "0x5040AE0", Offset = "0x503F2E0", VA = "0x185040AE0", Slot = "5")]
	public override Action IJFAMDAIFGB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "6")]
	[Preserve]
	public abstract void IFFAIIODICB<T>() where T : struct;

	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x5040B60", Offset = "0x503F360", VA = "0x185040B60")]
	[Preserve]
	public void KDIOKLJAINN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	[Cpp2IlInjected.Address(RVA = "0x5040BE0", Offset = "0x503F3E0", VA = "0x185040BE0")]
	protected CKHBLBBJIGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[CEFINOONOIN(typeof(GIDONOBPNKN), new string[] { })]
public class FNMFMCCMDMB : HMDOLFAFEDD, GIDONOBPNKN
{
	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public FBKJAGMDHMF FJPFHCMMMDD
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(RVA = "0x5F6790", Offset = "0x5F4F90", VA = "0x1805F6790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public ENJAHHPPGPN FFIHAAFFBCC
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(RVA = "0x60FBA0", Offset = "0x60E3A0", VA = "0x18060FBA0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(RVA = "0x643F60", Offset = "0x642760", VA = "0x180643F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public HFEGCOONMAM JAGNOKIGICD
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(RVA = "0x6186B0", Offset = "0x616EB0", VA = "0x1806186B0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(RVA = "0x639660", Offset = "0x637E60", VA = "0x180639660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public HCGLAJOCALO AFLJABEFILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0x6186A0", Offset = "0x616EA0", VA = "0x1806186A0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x637290", Offset = "0x635A90", VA = "0x180637290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public NIPPBJJLFPM HFEICCLODGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(RVA = "0x638B30", Offset = "0x637330", VA = "0x180638B30", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000463")]
		[Cpp2IlInjected.Address(RVA = "0x671B60", Offset = "0x670360", VA = "0x180671B60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public FOJPBIGOEBJ COKDEHMBBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(RVA = "0x5F99A0", Offset = "0x5F81A0", VA = "0x1805F99A0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000465")]
		[Cpp2IlInjected.Address(RVA = "0x6D6440", Offset = "0x6D4C40", VA = "0x1806D6440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public DEGKEFODIJP ABMNDBMJIJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000466")]
		[Cpp2IlInjected.Address(RVA = "0x5F9990", Offset = "0x5F8190", VA = "0x1805F9990", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000467")]
		[Cpp2IlInjected.Address(RVA = "0x5F9350", Offset = "0x5F7B50", VA = "0x1805F9350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public HIPDIEDHHMJ CHAOBDNLKEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x638B60", Offset = "0x637360", VA = "0x180638B60", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x638B80", Offset = "0x637380", VA = "0x180638B80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public FCGCJNHMCDH DCMPMMMNCFA
	{
		[Cpp2IlInjected.Token(Token = "0x600046A")]
		[Cpp2IlInjected.Address(RVA = "0x622180", Offset = "0x620980", VA = "0x180622180", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046B")]
		[Cpp2IlInjected.Address(RVA = "0x6B3BA0", Offset = "0x6B23A0", VA = "0x1806B3BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public CKLENHMGEIH OJOPOBEELHA
	{
		[Cpp2IlInjected.Token(Token = "0x600046C")]
		[Cpp2IlInjected.Address(RVA = "0x68E670", Offset = "0x68CE70", VA = "0x18068E670", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046D")]
		[Cpp2IlInjected.Address(RVA = "0x69A480", Offset = "0x698C80", VA = "0x18069A480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public NBEIBLIFPGD GPDGCAFEFPC
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(RVA = "0x61B9C0", Offset = "0x61A1C0", VA = "0x18061B9C0", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600046F")]
		[Cpp2IlInjected.Address(RVA = "0x628460", Offset = "0x626C60", VA = "0x180628460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public AINBLNOJEEC ECHCFPCIPDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(RVA = "0x61B9D0", Offset = "0x61A1D0", VA = "0x18061B9D0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000471")]
		[Cpp2IlInjected.Address(RVA = "0x6D4F00", Offset = "0x6D3700", VA = "0x1806D4F00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public GMIEFABEJHP KOBOGKHACLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000472")]
		[Cpp2IlInjected.Address(RVA = "0x68E690", Offset = "0x68CE90", VA = "0x18068E690", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000473")]
		[Cpp2IlInjected.Address(RVA = "0x6D5680", Offset = "0x6D3E80", VA = "0x1806D5680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public OPJJGBNKIAF KNIIIEIDDKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000474")]
		[Cpp2IlInjected.Address(RVA = "0x68E640", Offset = "0x68CE40", VA = "0x18068E640", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000475")]
		[Cpp2IlInjected.Address(RVA = "0x68F510", Offset = "0x68DD10", VA = "0x18068F510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public DGGIPLGOKHJ JHMPKHIMHCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x627660", Offset = "0x625E60", VA = "0x180627660", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x625C90", Offset = "0x624490", VA = "0x180625C90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public FHCDFMOJBCC FJOJPJBILFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000478")]
		[Cpp2IlInjected.Address(RVA = "0x68E5F0", Offset = "0x68CDF0", VA = "0x18068E5F0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000479")]
		[Cpp2IlInjected.Address(RVA = "0x69B450", Offset = "0x699C50", VA = "0x18069B450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public MGIHGMHOKEE HGMDBOMADIK
	{
		[Cpp2IlInjected.Token(Token = "0x600047A")]
		[Cpp2IlInjected.Address(RVA = "0x606E20", Offset = "0x605620", VA = "0x180606E20", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047B")]
		[Cpp2IlInjected.Address(RVA = "0x606E00", Offset = "0x605600", VA = "0x180606E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public BOMMAODPLGI AIPGJHJHOIC
	{
		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x608630", Offset = "0x606E30", VA = "0x180608630", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x6089C0", Offset = "0x6071C0", VA = "0x1806089C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public DIAELLIMJAK PJPGLNLHADD
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(RVA = "0x68E5A0", Offset = "0x68CDA0", VA = "0x18068E5A0", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600047F")]
		[Cpp2IlInjected.Address(RVA = "0x6D9D30", Offset = "0x6D8530", VA = "0x1806D9D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public OCMAMGCKJDD HHEFABBGDDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000480")]
		[Cpp2IlInjected.Address(RVA = "0x606DF0", Offset = "0x6055F0", VA = "0x180606DF0", Slot = "4")]
		get
		{
			return default(OCMAMGCKJDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x5046570", Offset = "0x5044D70", VA = "0x185046570", Slot = "5")]
	public void EDNJKGFKFJN(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public FNMFMCCMDMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[DefaultMember("Item")]
public class MKJKDJLAKNP : IEnumerable<int>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[CompilerGenerated]
	private sealed class CIAJLHGKGAA : IEnumerator<int>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private int <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public MKJKDJLAKNP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private int <indexOffset>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private int <intCount>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private int <i>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private ulong <value>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private int <index>5__6;

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		int IEnumerator<int>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600049E")]
			[Cpp2IlInjected.Address(RVA = "0x6866E0", Offset = "0x684EE0", VA = "0x1806866E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60004A0")]
			[Cpp2IlInjected.Address(RVA = "0x50C4D60", Offset = "0x50C3560", VA = "0x1850C4D60", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600049B")]
		[Cpp2IlInjected.Address(RVA = "0x60FD00", Offset = "0x60E500", VA = "0x18060FD00")]
		[DebuggerHidden]
		public CIAJLHGKGAA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049C")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600049D")]
		[Cpp2IlInjected.Address(RVA = "0x50C4BA0", Offset = "0x50C33A0", VA = "0x1850C4BA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600049F")]
		[Cpp2IlInjected.Address(RVA = "0x50C4D10", Offset = "0x50C3510", VA = "0x1850C4D10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400018D")]
	protected const ulong JMLKJHPMEIF = 1uL;

	[Cpp2IlInjected.Token(Token = "0x400018E")]
	protected const ulong KIIBDPJGCHK = ulong.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x400018F")]
	protected const int NLOLNALBOMM = 8;

	[Cpp2IlInjected.Token(Token = "0x4000190")]
	protected const int HEGKPMBPJOE = 6;

	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public const int DOFPPMGPLNJ = 64;

	[Cpp2IlInjected.Token(Token = "0x4000192")]
	protected const int JBFLMPOMLMN = 63;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private readonly List<ulong> OKBGKBPHLLK;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000483")]
		[Cpp2IlInjected.Address(RVA = "0x6EFB50", Offset = "0x6EE350", VA = "0x1806EFB50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(RVA = "0xBAAFF0", Offset = "0xBA97F0", VA = "0x180BAAFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public int FALGKGKIFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000485")]
		[Cpp2IlInjected.Address(RVA = "0x76ED20", Offset = "0x76D520", VA = "0x18076ED20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000486")]
		[Cpp2IlInjected.Address(RVA = "0x76ECC0", Offset = "0x76D4C0", VA = "0x18076ECC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000489")]
		[Cpp2IlInjected.Address(RVA = "0x50D2460", Offset = "0x50D0C60", VA = "0x1850D2460")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600048A")]
		[Cpp2IlInjected.Address(RVA = "0x50D2500", Offset = "0x50D0D00", VA = "0x1850D2500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(RVA = "0x50D3150", Offset = "0x50D1950", VA = "0x1850D3150")]
	public MKJKDJLAKNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x50D31C0", Offset = "0x50D19C0", VA = "0x1850D31C0")]
	public MKJKDJLAKNP(int MAADOFIJONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600048B")]
	[Cpp2IlInjected.Address(RVA = "0x50D26B0", Offset = "0x50D0EB0", VA = "0x1850D26B0")]
	public bool EBBKAHJAHFD(int AKLHCIJHJKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048C")]
	[Cpp2IlInjected.Address(RVA = "0x50D2DD0", Offset = "0x50D15D0", VA = "0x1850D2DD0")]
	public bool MLBBCAAICFB(int AKLHCIJHJKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048D")]
	[Cpp2IlInjected.Address(RVA = "0x50D2780", Offset = "0x50D0F80", VA = "0x1850D2780")]
	public bool GKJMOKIGIJN(int AKLHCIJHJKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048E")]
	[Cpp2IlInjected.Address(RVA = "0x50D26A0", Offset = "0x50D0EA0", VA = "0x1850D26A0")]
	public bool CPNLIKCPMHB(int AKLHCIJHJKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600048F")]
	[Cpp2IlInjected.Address(RVA = "0x50D2D50", Offset = "0x50D1550", VA = "0x1850D2D50")]
	public void LAMMAHBDJJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000490")]
	[Cpp2IlInjected.Address(RVA = "0x50D2EB0", Offset = "0x50D16B0", VA = "0x1850D2EB0")]
	public void NECOEFDLBDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000491")]
	[Cpp2IlInjected.Address(RVA = "0x50D2870", Offset = "0x50D1070", VA = "0x1850D2870")]
	public void HEMBJNPDPPJ(int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000492")]
	[Cpp2IlInjected.Address(RVA = "0x50D2B00", Offset = "0x50D1300", VA = "0x1850D2B00")]
	public void IDPJIGKEBOL(int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000493")]
	[Cpp2IlInjected.Address(RVA = "0x50D30C0", Offset = "0x50D18C0", VA = "0x1850D30C0")]
	public bool PBJGOKIMKCM(int AKLHCIJHJKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000494")]
	[Cpp2IlInjected.Address(RVA = "0x50D2C40", Offset = "0x50D1440", VA = "0x1850D2C40")]
	public void KPCJFCPMGEG(int IBIPCEJMDGF, int FKDPJOHPNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000495")]
	[Cpp2IlInjected.Address(RVA = "0x50D2960", Offset = "0x50D1160", VA = "0x1850D2960")]
	public void HPLGEDOBMOC(int GLKAGFOBJCF, int DBLPJHCGOKC, int FKDPJOHPNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000496")]
	[Cpp2IlInjected.Address(RVA = "0x50D3000", Offset = "0x50D1800", VA = "0x1850D3000")]
	public int NLKJJINIDJF(int FKDPJOHPNNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000497")]
	[Cpp2IlInjected.Address(RVA = "0x50D2F90", Offset = "0x50D1790", VA = "0x1850D2F90")]
	public int NLKJJINIDJF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000498")]
	[Cpp2IlInjected.Address(RVA = "0x50D2BF0", Offset = "0x50D13F0", VA = "0x1850D2BF0")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000499")]
	[Cpp2IlInjected.Address(RVA = "0x50D2800", Offset = "0x50D1000", VA = "0x1850D2800", Slot = "4")]
	[IteratorStateMachine(typeof(CIAJLHGKGAA))]
	public IEnumerator<int> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600049A")]
	[Cpp2IlInjected.Address(RVA = "0x50D2800", Offset = "0x50D1000", VA = "0x1850D2800", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public class BPAPPHGPFEJ<T> : global::BDCHGLLPJGG<T> where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	protected global::DKMHFCMPOEP<T> ADKKBALLFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	protected global::BFGBMJDFBJC<T> EJFGPNDJGLB;

	[Cpp2IlInjected.Token(Token = "0x60004A1")]
	[Cpp2IlInjected.Address(RVA = "0x11F76D0", Offset = "0x11F5ED0", VA = "0x1811F76D0")]
	public BPAPPHGPFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A2")]
	[Cpp2IlInjected.Address(RVA = "0x556B3B0", Offset = "0x5569BB0", VA = "0x18556B3B0")]
	public BPAPPHGPFEJ(global::DKMHFCMPOEP<T> ADKKBALLFIO, global::BFGBMJDFBJC<T> EJFGPNDJGLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A3")]
	[Cpp2IlInjected.Address(RVA = "0x302BD70", Offset = "0x302A570", VA = "0x18302BD70", Slot = "11")]
	public override T JDKEMADGCJE(BFPHBAFEECN IAAPJBOKIIH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A4")]
	[Cpp2IlInjected.Address(RVA = "0xE2AB90", Offset = "0xE29390", VA = "0x180E2AB90", Slot = "12")]
	public override void BAGHAKDDGPK(BFPHBAFEECN IAAPJBOKIIH, T CJMMBFLIBMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public static class OGHLBGEKLCL
{
	[Cpp2IlInjected.Token(Token = "0x60004A5")]
	[Cpp2IlInjected.Address(RVA = "0xDAEE30", Offset = "0xDAD630", VA = "0x180DAEE30")]
	public static MIPCILJMDGJ DAFBLBFDDID<T>(this FDEECNODPGL AFJGLEGGBOF, global::NNAELPPPNEG<T> JNAACNJBHOF, global::DKMHFCMPOEP<T> ADKKBALLFIO, global::BFGBMJDFBJC<T> EJFGPNDJGLB) where T : struct
	{
		return default(MIPCILJMDGJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public sealed class DLJKOPPNPHA<T> : global::BPAPPHGPFEJ<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x60004A6")]
	[Cpp2IlInjected.Address(RVA = "0x52D95D0", Offset = "0x52D7DD0", VA = "0x1852D95D0")]
	public DLJKOPPNPHA(T NFMJKCMCOPK, T AHIONLKAMCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public sealed class IMKMJIEAGFJ<T> : global::BDCHGLLPJGG<T> where T : struct, JJELBHOACBE
{
	[Cpp2IlInjected.Token(Token = "0x60004A7")]
	[Cpp2IlInjected.Address(RVA = "0x50FC5B0", Offset = "0x50FADB0", VA = "0x1850FC5B0", Slot = "11")]
	public override T JDKEMADGCJE(BFPHBAFEECN IAAPJBOKIIH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60004A8")]
	[Cpp2IlInjected.Address(RVA = "0x50FC580", Offset = "0x50FAD80", VA = "0x1850FC580", Slot = "12")]
	public override void BAGHAKDDGPK(BFPHBAFEECN IAAPJBOKIIH, T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004A9")]
	[Cpp2IlInjected.Address(RVA = "0x17344A0", Offset = "0x1732CA0", VA = "0x1817344A0")]
	public IMKMJIEAGFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public abstract class IPDPKHANAIA : LANHGMANLOK
{
	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public abstract Type OHHOKIOJPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60004AA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60004AB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract void JDKEMADGCJE(BFPHBAFEECN IAAPJBOKIIH, in IOLFMJOGIFF CJMMBFLIBMO);

	[Cpp2IlInjected.Token(Token = "0x60004AC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void BAGHAKDDGPK(BFPHBAFEECN IAAPJBOKIIH, in BJHFEKKLKGB CJMMBFLIBMO);

	[Cpp2IlInjected.Token(Token = "0x60004AD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void CIHAKFOOKLK(BFPHBAFEECN IAAPJBOKIIH, BBJMOOHBLPF LBEBNBLLNKK, [Optional] object ALLCABKLNNG);

	[Cpp2IlInjected.Token(Token = "0x60004AE")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	protected IPDPKHANAIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public abstract class BDCHGLLPJGG<T> : IPDPKHANAIA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public override Type OHHOKIOJPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60004B1")]
		[Cpp2IlInjected.Address(RVA = "0x54089C0", Offset = "0x54071C0", VA = "0x1854089C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004AF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	public abstract T JDKEMADGCJE(BFPHBAFEECN IAAPJBOKIIH);

	[Cpp2IlInjected.Token(Token = "0x60004B0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void BAGHAKDDGPK(BFPHBAFEECN IAAPJBOKIIH, T CJMMBFLIBMO);

	[Cpp2IlInjected.Token(Token = "0x60004B2")]
	[Cpp2IlInjected.Address(RVA = "0x5408210", Offset = "0x5406A10", VA = "0x185408210", Slot = "8")]
	public override void JDKEMADGCJE(BFPHBAFEECN IAAPJBOKIIH, in IOLFMJOGIFF GPGPHLEMPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B3")]
	[Cpp2IlInjected.Address(RVA = "0x5406220", Offset = "0x5404A20", VA = "0x185406220", Slot = "9")]
	public override void BAGHAKDDGPK(BFPHBAFEECN IAAPJBOKIIH, in BJHFEKKLKGB MOLPKNIJMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B4")]
	[Cpp2IlInjected.Address(RVA = "0x5407170", Offset = "0x5405970", VA = "0x185407170", Slot = "10")]
	public override void CIHAKFOOKLK(BFPHBAFEECN IAAPJBOKIIH, BBJMOOHBLPF LBEBNBLLNKK, object ALLCABKLNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B5")]
	[Cpp2IlInjected.Address(RVA = "0x11F4EB0", Offset = "0x11F36B0", VA = "0x1811F4EB0")]
	protected BDCHGLLPJGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class JHJPNJKMCPH
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private class HENHPGKNELM
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class NFBJMGIGKKK<T> where T : struct, INativeList<byte>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public int max;

			[Cpp2IlInjected.Token(Token = "0x60004BE")]
			[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
			public NFBJMGIGKKK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004BF")]
			[Cpp2IlInjected.Address(RVA = "0x537F310", Offset = "0x537DB10", VA = "0x18537F310")]
			internal void <RegisterFixedString>b__0(BFPHBAFEECN p, T v)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60004C0")]
			[Cpp2IlInjected.Address(RVA = "0x537F740", Offset = "0x537DF40", VA = "0x18537F740")]
			internal T <RegisterFixedString>b__1(BFPHBAFEECN p)
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60004B9")]
		[Cpp2IlInjected.Address(RVA = "0x50C5D80", Offset = "0x50C4580", VA = "0x1850C5D80")]
		public static void NGJJOEHGMMF(CJFDIMPGEHE NEDLOHNFGOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BA")]
		[Cpp2IlInjected.Address(RVA = "0xC52C60", Offset = "0xC51460", VA = "0x180C52C60")]
		private static void ENKHDGGPJCD<T>(CJFDIMPGEHE NEDLOHNFGOO, int AHIONLKAMCJ) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BB")]
		[Cpp2IlInjected.Address(RVA = "0xC52D80", Offset = "0xC51580", VA = "0x180C52D80")]
		private static void KMAMMHIHBJK<T>(BFPHBAFEECN CKNEEGNOOIB, T BKEAIPINHOO, int AHIONLKAMCJ) where T : struct, INativeList<byte>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004BC")]
		[Cpp2IlInjected.Address(RVA = "0x1C36110", Offset = "0x1C34910", VA = "0x181C36110")]
		private static T CCNDHNFJEFK<T>(BFPHBAFEECN CKNEEGNOOIB, int AHIONLKAMCJ) where T : struct, INativeList<byte>
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60004BD")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public HENHPGKNELM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200007E")]
	private class CCBEJLEBDEA : OHEBKFPOPKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private CJFDIMPGEHE NEDLOHNFGOO;

		[Cpp2IlInjected.Token(Token = "0x60004C1")]
		[Cpp2IlInjected.Address(RVA = "0xC52AB0", Offset = "0xC512B0", VA = "0x180C52AB0", Slot = "6")]
		public override void NHAPEFIDCHE<T>()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C2")]
		[Cpp2IlInjected.Address(RVA = "0x50C4B10", Offset = "0x50C3310", VA = "0x1850C4B10")]
		public static void BHOGEJGNLGM(CJFDIMPGEHE NEDLOHNFGOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60004C3")]
		[Cpp2IlInjected.Address(RVA = "0x50C4B90", Offset = "0x50C3390", VA = "0x1850C4B90")]
		public CCBEJLEBDEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004B6")]
	[Cpp2IlInjected.Address(RVA = "0x50C8400", Offset = "0x50C6C00", VA = "0x1850C8400")]
	public static void GFBIEFOCJHN(CJFDIMPGEHE NEDLOHNFGOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B7")]
	[Cpp2IlInjected.Address(RVA = "0xC59D60", Offset = "0xC58560", VA = "0x180C59D60")]
	public static void KNJMEAJMBBF<T>(CJFDIMPGEHE NEDLOHNFGOO, global::DKMHFCMPOEP<T> ADKKBALLFIO, global::BFGBMJDFBJC<T> EJFGPNDJGLB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004B8")]
	[Cpp2IlInjected.Address(RVA = "0xC59DF0", Offset = "0xC585F0", VA = "0x180C59DF0")]
	public static void NKEHIMLFKDL<T>(CJFDIMPGEHE MEBJIKNMLPK) where T : struct, JJELBHOACBE
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface CJFDIMPGEHE : global::MFLLONONPMG<CJFDIMPGEHE>
{
	[Cpp2IlInjected.Token(Token = "0x60004E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DAFBLBFDDID(Type BKDBLJPNPPJ, LANHGMANLOK MEBJIKNMLPK);

	[Cpp2IlInjected.Token(Token = "0x60004E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool APHJBAJPDLG(Type BKDBLJPNPPJ, out LANHGMANLOK MEBJIKNMLPK);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public static class DCGNLHKMIIN
{
	[Cpp2IlInjected.Token(Token = "0x60004E6")]
	[Cpp2IlInjected.Address(RVA = "0x5041480", Offset = "0x503FC80", VA = "0x185041480")]
	public static void DAFBLBFDDID(this CJFDIMPGEHE CCOJAKINIDK, LANHGMANLOK MEBJIKNMLPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[CEFINOONOIN(typeof(FDEECNODPGL), new string[] { })]
public sealed class EBPBLNEOGCA : FDEECNODPGL, global::MFLLONONPMG<FDEECNODPGL>, CMBMJNFKKCN, DKFAOOPHPAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private readonly Dictionary<MIPCILJMDGJ, LANHGMANLOK> NEDLOHNFGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private CJFDIMPGEHE NIEKPIHMJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private DNHMPLANJOC AFJGLEGGBOF;

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool EHGOCPHEMPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004E7")]
		[Cpp2IlInjected.Address(RVA = "0x7294F0", Offset = "0x727CF0", VA = "0x1807294F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004E8")]
		[Cpp2IlInjected.Address(RVA = "0x729510", Offset = "0x727D10", VA = "0x180729510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004E9")]
	[Cpp2IlInjected.Address(RVA = "0x5042B20", Offset = "0x5041320", VA = "0x185042B20")]
	public EBPBLNEOGCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EA")]
	[Cpp2IlInjected.Address(RVA = "0x5042B90", Offset = "0x5041390", VA = "0x185042B90")]
	public EBPBLNEOGCA(Dictionary<MIPCILJMDGJ, LANHGMANLOK> NEDLOHNFGOO, bool OMDDBNBDIPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EB")]
	[Cpp2IlInjected.Address(RVA = "0x50427D0", Offset = "0x5040FD0", VA = "0x1850427D0", Slot = "7")]
	public void FNNKDMJCDCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EC")]
	[Cpp2IlInjected.Address(RVA = "0x5042750", Offset = "0x5040F50", VA = "0x185042750", Slot = "8")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004ED")]
	[Cpp2IlInjected.Address(RVA = "0x5042930", Offset = "0x5041130", VA = "0x185042930", Slot = "9")]
	public void IDPJIGKEBOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004EE")]
	[Cpp2IlInjected.Address(RVA = "0x5042980", Offset = "0x5041180", VA = "0x185042980", Slot = "4")]
	public MIPCILJMDGJ KJPBFOEADCJ(OMOEODCFEGL JNAACNJBHOF)
	{
		return default(MIPCILJMDGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60004EF")]
	[Cpp2IlInjected.Address(RVA = "0x5042630", Offset = "0x5040E30", VA = "0x185042630", Slot = "5")]
	public void DAFBLBFDDID(MIPCILJMDGJ OCNCOBFEOBE, LANHGMANLOK MEBJIKNMLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F0")]
	[Cpp2IlInjected.Address(RVA = "0x5042820", Offset = "0x5041020", VA = "0x185042820")]
	[Conditional("DEBUG_BUILD")]
	private void GLILNFBCCDE(MIPCILJMDGJ OCNCOBFEOBE, Type BKDBLJPNPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F1")]
	[Cpp2IlInjected.Address(RVA = "0x50424B0", Offset = "0x5040CB0", VA = "0x1850424B0", Slot = "6")]
	public bool APHJBAJPDLG(MIPCILJMDGJ OCNCOBFEOBE, out LANHGMANLOK MEBJIKNMLPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004F2")]
	[Cpp2IlInjected.Address(RVA = "0x5042A50", Offset = "0x5041250", VA = "0x185042A50", Slot = "10")]
	public FDEECNODPGL LGOGCJIBEJA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[CEFINOONOIN(typeof(CJFDIMPGEHE), new string[] { })]
public sealed class IMBCOHFDCGL : CMBMJNFKKCN, CJFDIMPGEHE, global::MFLLONONPMG<CJFDIMPGEHE>
{
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static readonly FLAFLKKHHEA APOHKGBDLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private readonly Dictionary<Type, LANHGMANLOK> NEDLOHNFGOO;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool EHGOCPHEMPD
	{
		[Cpp2IlInjected.Token(Token = "0x60004F3")]
		[Cpp2IlInjected.Address(RVA = "0x6ACCD0", Offset = "0x6AB4D0", VA = "0x1806ACCD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60004F4")]
		[Cpp2IlInjected.Address(RVA = "0x6E09B0", Offset = "0x6DF1B0", VA = "0x1806E09B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60004F5")]
	[Cpp2IlInjected.Address(RVA = "0x50C7A00", Offset = "0x50C6200", VA = "0x1850C7A00")]
	public IMBCOHFDCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F6")]
	[Cpp2IlInjected.Address(RVA = "0x50C7A70", Offset = "0x50C6270", VA = "0x1850C7A70")]
	public IMBCOHFDCGL(Dictionary<Type, LANHGMANLOK> NEDLOHNFGOO, bool OMDDBNBDIPC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F7")]
	[Cpp2IlInjected.Address(RVA = "0x50C7890", Offset = "0x50C6090", VA = "0x1850C7890", Slot = "4")]
	public void FNNKDMJCDCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F8")]
	[Cpp2IlInjected.Address(RVA = "0x50C77A0", Offset = "0x50C5FA0", VA = "0x1850C77A0", Slot = "5")]
	public void DAFBLBFDDID(Type BKDBLJPNPPJ, LANHGMANLOK MEBJIKNMLPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004F9")]
	[Cpp2IlInjected.Address(RVA = "0x50C76E0", Offset = "0x50C5EE0", VA = "0x1850C76E0", Slot = "6")]
	public bool APHJBAJPDLG(Type BKDBLJPNPPJ, out LANHGMANLOK MEBJIKNMLPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60004FA")]
	[Cpp2IlInjected.Address(RVA = "0x50C78F0", Offset = "0x50C60F0", VA = "0x1850C78F0", Slot = "7")]
	public CJFDIMPGEHE LGOGCJIBEJA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
[CEFINOONOIN(typeof(IEDMOKDLMMK), new string[] { })]
internal sealed class EKGKAOCMADB : IEDMOKDLMMK, CMBMJNFKKCN, DKFAOOPHPAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private readonly Dictionary<MIPCILJMDGJ, GAPEKCIFGNC> AIJFGHJPPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private DNHMPLANJOC AFJGLEGGBOF;

	[Cpp2IlInjected.Token(Token = "0x60004FC")]
	[Cpp2IlInjected.Address(RVA = "0x5044160", Offset = "0x5042960", VA = "0x185044160", Slot = "6")]
	public void FNNKDMJCDCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FD")]
	[Cpp2IlInjected.Address(RVA = "0x5044100", Offset = "0x5042900", VA = "0x185044100", Slot = "7")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FE")]
	[Cpp2IlInjected.Address(RVA = "0x5044090", Offset = "0x5042890", VA = "0x185044090", Slot = "4")]
	public void DAFBLBFDDID(MIPCILJMDGJ KBHHIDGOLNC, Type PJHBOMGCKND, GAPEKCIFGNC OOAKNNCEGCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60004FF")]
	[Cpp2IlInjected.Address(RVA = "0x5044300", Offset = "0x5042B00", VA = "0x185044300", Slot = "5")]
	public bool JKOEIOCEBNB(MIPCILJMDGJ KBHHIDGOLNC, out GAPEKCIFGNC OOAKNNCEGCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000500")]
	[Cpp2IlInjected.Address(RVA = "0x50441B0", Offset = "0x50429B0", VA = "0x1850441B0")]
	[Conditional("DEBUG_BUILD")]
	private void GELABPGJEID(MIPCILJMDGJ KBHHIDGOLNC, Type PJHBOMGCKND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000501")]
	[Cpp2IlInjected.Address(RVA = "0x5044370", Offset = "0x5042B70", VA = "0x185044370")]
	public EKGKAOCMADB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
[OJBFCHOEMHJ(typeof(DNHMPLANJOC))]
[CEFINOONOIN(typeof(IPKLKAMJJNH), new string[] { })]
internal sealed class EFJGMFDOMGM : IPKLKAMJJNH, JIOLBCKAPBA, CMBMJNFKKCN, DKFAOOPHPAH, GHNBGLLDFLL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private readonly MKJKDJLAKNP EHOMONNKGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private readonly Dictionary<MCOCAFPBHKN, int> JAOEEPNNHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private readonly Stack<int> HGCFNEKDDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private DNHMPLANJOC AFJGLEGGBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private FOJPBIGOEBJ NLJLBCPPCEG;

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private int FEAMFFNHEBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000502")]
		[Cpp2IlInjected.Address(RVA = "0x50437D0", Offset = "0x5041FD0", VA = "0x1850437D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool PHFNKLFKPOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000503")]
		[Cpp2IlInjected.Address(RVA = "0x630480", Offset = "0x62EC80", VA = "0x180630480", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000504")]
		[Cpp2IlInjected.Address(RVA = "0x6D9AB0", Offset = "0x6D82B0", VA = "0x1806D9AB0", Slot = "11")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000505")]
	[Cpp2IlInjected.Address(RVA = "0x5043950", Offset = "0x5042150", VA = "0x185043950", Slot = "6")]
	public void FNNKDMJCDCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000506")]
	[Cpp2IlInjected.Address(RVA = "0x5043A20", Offset = "0x5042220", VA = "0x185043A20", Slot = "7")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000507")]
	[Cpp2IlInjected.Address(RVA = "0x5043820", Offset = "0x5042020", VA = "0x185043820", Slot = "8")]
	public void BCKGPNKBBNF(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000508")]
	[Cpp2IlInjected.Address(RVA = "0x50438B0", Offset = "0x50420B0", VA = "0x1850438B0")]
	private void CBCAMDOKCBC(CFBEFPIPHOM LEPHKDIHJFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000509")]
	[Cpp2IlInjected.Address(RVA = "0x5043AA0", Offset = "0x50422A0", VA = "0x185043AA0", Slot = "4")]
	public bool MDCLHEKMCMO(MCOCAFPBHKN GFKNINEELBB, MIPCILJMDGJ IOADAIMHMFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600050A")]
	[Cpp2IlInjected.Address(RVA = "0x5043B50", Offset = "0x5042350", VA = "0x185043B50", Slot = "5")]
	public void PIPBNBHHBLC(MCOCAFPBHKN GFKNINEELBB, Span<MIPCILJMDGJ> AFJGLEGGBOF, bool PMEJKGPCEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050B")]
	[Cpp2IlInjected.Address(RVA = "0x5043950", Offset = "0x5042150", VA = "0x185043950", Slot = "9")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050C")]
	[Cpp2IlInjected.Address(RVA = "0x5043D40", Offset = "0x5042540", VA = "0x185043D40")]
	public EFJGMFDOMGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public static class KCLFKGGELGB
{
	[Cpp2IlInjected.Token(Token = "0x600050D")]
	[Cpp2IlInjected.Address(RVA = "0x50CC860", Offset = "0x50CB060", VA = "0x1850CC860")]
	public static void ILGHNEPCJKL(this BFPHBAFEECN IAAPJBOKIIH, ReadOnlyMemory<byte> HNGHEBPIOJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050E")]
	[Cpp2IlInjected.Address(RVA = "0xC5F3A0", Offset = "0xC5DBA0", VA = "0x180C5F3A0")]
	public static void HEIFACBBJFA<T>(this BFPHBAFEECN IAAPJBOKIIH, in T CJMMBFLIBMO) where T : struct, JJELBHOACBE
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600050F")]
	[Cpp2IlInjected.Address(RVA = "0x1C3F4A0", Offset = "0x1C3DCA0", VA = "0x181C3F4A0")]
	public static T LDFNNBCNCNI<T>(this BFPHBAFEECN IAAPJBOKIIH) where T : struct, JJELBHOACBE
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000510")]
	[Cpp2IlInjected.Address(RVA = "0x50CC680", Offset = "0x50CAE80", VA = "0x1850CC680")]
	public static void HEIFACBBJFA(this BFPHBAFEECN IAAPJBOKIIH, JACJLCPOLIH LJDPEMEGKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000511")]
	[Cpp2IlInjected.Address(RVA = "0x50CC8E0", Offset = "0x50CB0E0", VA = "0x1850CC8E0")]
	public static JACJLCPOLIH PBHKFCGKJKI(this BFPHBAFEECN IAAPJBOKIIH)
	{
		return default(JACJLCPOLIH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000512")]
	[Cpp2IlInjected.Address(RVA = "0x50CC6B0", Offset = "0x50CAEB0", VA = "0x1850CC6B0")]
	public static void HNOBDFJJNOF(this BFPHBAFEECN HELLEMCMMHJ, uint NBJMBCENLLC, bool KIFCHBNLLNF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000513")]
	[Cpp2IlInjected.Address(RVA = "0x50CC560", Offset = "0x50CAD60", VA = "0x1850CC560")]
	public static uint AIEIBHDHHCE(this BFPHBAFEECN AMCNLEFBMOK, bool KIFCHBNLLNF = false)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public static class IAMEGKENKBG
{
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[CompilerGenerated]
	private sealed class BBCPICDOLAN<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		public byte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		public byte vMax;

		[Cpp2IlInjected.Token(Token = "0x600051B")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		public BBCPICDOLAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051C")]
		[Cpp2IlInjected.Address(RVA = "0x5357490", Offset = "0x5355C90", VA = "0x185357490")]
		internal void <GetByteEnumDelegates>b__0(BFPHBAFEECN b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051D")]
		[Cpp2IlInjected.Address(RVA = "0x5357500", Offset = "0x5355D00", VA = "0x185357500")]
		internal T <GetByteEnumDelegates>b__1(BFPHBAFEECN b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[CompilerGenerated]
	private sealed class OBOHBBNKHLM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public sbyte vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public sbyte vMax;

		[Cpp2IlInjected.Token(Token = "0x600051E")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		public OBOHBBNKHLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600051F")]
		[Cpp2IlInjected.Address(RVA = "0x5365650", Offset = "0x5363E50", VA = "0x185365650")]
		internal void <GetSByteEnumDelegates>b__0(BFPHBAFEECN b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000520")]
		[Cpp2IlInjected.Address(RVA = "0x53656C0", Offset = "0x5363EC0", VA = "0x1853656C0")]
		internal T <GetSByteEnumDelegates>b__1(BFPHBAFEECN b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[CompilerGenerated]
	private sealed class GCFMMKDABAP<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public short vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public short vMax;

		[Cpp2IlInjected.Token(Token = "0x6000521")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		public GCFMMKDABAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000522")]
		[Cpp2IlInjected.Address(RVA = "0x535BB70", Offset = "0x535A370", VA = "0x18535BB70")]
		internal void <GetShortEnumDelegates>b__0(BFPHBAFEECN b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000523")]
		[Cpp2IlInjected.Address(RVA = "0x535BBE0", Offset = "0x535A3E0", VA = "0x18535BBE0")]
		internal T <GetShortEnumDelegates>b__1(BFPHBAFEECN b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[CompilerGenerated]
	private sealed class JPNGJDIMNCJ<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public ushort vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		public ushort vMax;

		[Cpp2IlInjected.Token(Token = "0x6000524")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		public JPNGJDIMNCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000525")]
		[Cpp2IlInjected.Address(RVA = "0x5363D90", Offset = "0x5362590", VA = "0x185363D90")]
		internal void <GetUShortEnumDelegates>b__0(BFPHBAFEECN b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000526")]
		[Cpp2IlInjected.Address(RVA = "0x5363E00", Offset = "0x5362600", VA = "0x185363E00")]
		internal T <GetUShortEnumDelegates>b__1(BFPHBAFEECN b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[CompilerGenerated]
	private sealed class DBMODNNCAGH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		public int vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public int vMax;

		[Cpp2IlInjected.Token(Token = "0x6000527")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		public DBMODNNCAGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000528")]
		[Cpp2IlInjected.Address(RVA = "0x5357F60", Offset = "0x5356760", VA = "0x185357F60")]
		internal void <GetIntEnumDelegates>b__0(BFPHBAFEECN b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000529")]
		[Cpp2IlInjected.Address(RVA = "0x5357FC0", Offset = "0x53567C0", VA = "0x185357FC0")]
		internal T <GetIntEnumDelegates>b__1(BFPHBAFEECN b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[CompilerGenerated]
	private sealed class CHCCMGFJPCM<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public uint vMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public uint vMax;

		[Cpp2IlInjected.Token(Token = "0x600052A")]
		[Cpp2IlInjected.Address(RVA = "0xB6A800", Offset = "0xB69000", VA = "0x180B6A800")]
		public CHCCMGFJPCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052B")]
		[Cpp2IlInjected.Address(RVA = "0x5357EA0", Offset = "0x53566A0", VA = "0x185357EA0")]
		internal void <GetUIntEnumDelegates>b__0(BFPHBAFEECN b, T v)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600052C")]
		[Cpp2IlInjected.Address(RVA = "0x5357F00", Offset = "0x5356700", VA = "0x185357F00")]
		internal T <GetUIntEnumDelegates>b__1(BFPHBAFEECN b)
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000514")]
	[Cpp2IlInjected.Address(RVA = "0xC53A10", Offset = "0xC52210", VA = "0x180C53A10")]
	public static void MDEALMILMAM<T>(T NFMJKCMCOPK, T AHIONLKAMCJ, out global::DKMHFCMPOEP<T> KOBEPNPNFDJ, out global::BFGBMJDFBJC<T> HFLBNFKFLHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000515")]
	[Cpp2IlInjected.Address(RVA = "0xC53620", Offset = "0xC51E20", VA = "0x180C53620")]
	private static void KFKPEONEMLH<T>(T NFMJKCMCOPK, T AHIONLKAMCJ, out global::DKMHFCMPOEP<T> KOBEPNPNFDJ, out global::BFGBMJDFBJC<T> HFLBNFKFLHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000516")]
	[Cpp2IlInjected.Address(RVA = "0xC53620", Offset = "0xC51E20", VA = "0x180C53620")]
	private static void BJIAEDHGEMD<T>(T NFMJKCMCOPK, T AHIONLKAMCJ, out global::DKMHFCMPOEP<T> KOBEPNPNFDJ, out global::BFGBMJDFBJC<T> HFLBNFKFLHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000517")]
	[Cpp2IlInjected.Address(RVA = "0xC53770", Offset = "0xC51F70", VA = "0x180C53770")]
	private static void CHPAIBLJHHH<T>(T NFMJKCMCOPK, T AHIONLKAMCJ, out global::DKMHFCMPOEP<T> KOBEPNPNFDJ, out global::BFGBMJDFBJC<T> HFLBNFKFLHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000518")]
	[Cpp2IlInjected.Address(RVA = "0xC53770", Offset = "0xC51F70", VA = "0x180C53770")]
	private static void HOHMMDGECBL<T>(T NFMJKCMCOPK, T AHIONLKAMCJ, out global::DKMHFCMPOEP<T> KOBEPNPNFDJ, out global::BFGBMJDFBJC<T> HFLBNFKFLHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000519")]
	[Cpp2IlInjected.Address(RVA = "0xC538C0", Offset = "0xC520C0", VA = "0x180C538C0")]
	private static void DCNNAEPBPJE<T>(T NFMJKCMCOPK, T AHIONLKAMCJ, out global::DKMHFCMPOEP<T> KOBEPNPNFDJ, out global::BFGBMJDFBJC<T> HFLBNFKFLHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600051A")]
	[Cpp2IlInjected.Address(RVA = "0xC538C0", Offset = "0xC520C0", VA = "0x180C538C0")]
	private static void NFGGKNPKEPD<T>(T NFMJKCMCOPK, T AHIONLKAMCJ, out global::DKMHFCMPOEP<T> KOBEPNPNFDJ, out global::BFGBMJDFBJC<T> HFLBNFKFLHE) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public abstract class HCMGPLOANAC : GLALDLOMEOC, GHNBGLLDFLL
{
	[Cpp2IlInjected.Token(Token = "0x600052D")]
	[Cpp2IlInjected.Address(RVA = "0x504AE10", Offset = "0x5049610", VA = "0x18504AE10", Slot = "4")]
	private void LDHBHGNNOJL(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600052E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract void OIACCDLMMMM(FDEECNODPGL AFJGLEGGBOF);

	[Cpp2IlInjected.Token(Token = "0x600052F")]
	[Cpp2IlInjected.Address(RVA = "0x606E30", Offset = "0x605630", VA = "0x180606E30")]
	protected HCMGPLOANAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[LBJGPGJMNEL(typeof(LocalPoseData))]
public sealed class JOGOHGHCKBI : HCMGPLOANAC
{
	[Cpp2IlInjected.Token(Token = "0x6000530")]
	[Cpp2IlInjected.Address(RVA = "0x50CB150", Offset = "0x50C9950", VA = "0x1850CB150", Slot = "5")]
	protected override void OIACCDLMMMM(FDEECNODPGL AFJGLEGGBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000531")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50")]
	public JOGOHGHCKBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[InternalBufferCapacity(1)]
internal struct PMNOLDCLIGM : ISystemStateBufferElementData, IBufferElementData, IEquatable<PMNOLDCLIGM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public FLCKNCKMGDM LPPHLKEKIOC;

	[Cpp2IlInjected.Token(Token = "0x6000536")]
	[Cpp2IlInjected.Address(RVA = "0xE5BE80", Offset = "0xE5A680", VA = "0x180E5BE80", Slot = "4")]
	public bool Equals(PMNOLDCLIGM ALBOAABJIJF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000537")]
	[Cpp2IlInjected.Address(RVA = "0x86BBC0", Offset = "0x86A3C0", VA = "0x18086BBC0")]
	public static PMNOLDCLIGM HLHIMDAEEEO(FLCKNCKMGDM LPPHLKEKIOC)
	{
		return default(PMNOLDCLIGM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[InternalBufferCapacity(4)]
internal struct DCKGNMEJOED : ISystemStateBufferElementData, IBufferElementData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public FLCKNCKMGDM LPPHLKEKIOC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000538")]
	[Cpp2IlInjected.Address(RVA = "0x86BBC0", Offset = "0x86A3C0", VA = "0x18086BBC0")]
	public static DCKGNMEJOED HLHIMDAEEEO(FLCKNCKMGDM LPPHLKEKIOC)
	{
		return default(DCKGNMEJOED);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
internal struct FLCKNCKMGDM : global::KDFMKIHLJFP<FLCKNCKMGDM>, ECOGJIGKDHI, IEquatable<FLCKNCKMGDM>
{
	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public int PDGADEKDACK
	{
		[Cpp2IlInjected.Token(Token = "0x6000539")]
		[Cpp2IlInjected.Address(RVA = "0x7E9EC0", Offset = "0x7E86C0", VA = "0x1807E9EC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600053A")]
		[Cpp2IlInjected.Address(RVA = "0x825F70", Offset = "0x824770", VA = "0x180825F70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public int JLICIKJPFHO
	{
		[Cpp2IlInjected.Token(Token = "0x600053B")]
		[Cpp2IlInjected.Address(RVA = "0xECE690", Offset = "0xECCE90", VA = "0x180ECE690", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600053C")]
		[Cpp2IlInjected.Address(RVA = "0xF35920", Offset = "0xF34120", VA = "0x180F35920", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public bool CPNLIKCPMHB
	{
		[Cpp2IlInjected.Token(Token = "0x600053D")]
		[Cpp2IlInjected.Address(RVA = "0x5046490", Offset = "0x5044C90", VA = "0x185046490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600053E")]
	[Cpp2IlInjected.Address(RVA = "0x50464D0", Offset = "0x5044CD0", VA = "0x1850464D0", Slot = "8")]
	public bool Equals(FLCKNCKMGDM ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600053F")]
	[Cpp2IlInjected.Address(RVA = "0x5046520", Offset = "0x5044D20", VA = "0x185046520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public class BMICAOOFJOO : ParentSystemBase<AuthoredParentData, IIGFJFAPCCG, AuthoredChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x6000540")]
	[Cpp2IlInjected.Address(RVA = "0x503E110", Offset = "0x503C910", VA = "0x18503E110", Slot = "14")]
	protected override EntityQueryDesc AJBDOGOFGIF(EntityQueryDesc JIDAALIOAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000541")]
	[Cpp2IlInjected.Address(RVA = "0x79F5B0", Offset = "0x79DDB0", VA = "0x18079F5B0", Slot = "15")]
	protected override EntityQueryDesc IAAOHDADEAD(EntityQueryDesc JIDAALIOAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000542")]
	[Cpp2IlInjected.Address(RVA = "0x503E190", Offset = "0x503C990", VA = "0x18503E190", Slot = "16")]
	protected override EntityQueryDesc KCCKAJAIOLF(EntityQueryDesc JIDAALIOAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000543")]
	[Cpp2IlInjected.Address(RVA = "0x503E150", Offset = "0x503C950", VA = "0x18503E150", Slot = "17")]
	protected override EntityQueryDesc EJCJMBFJMIP(EntityQueryDesc JIDAALIOAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000544")]
	[Cpp2IlInjected.Address(RVA = "0x503E210", Offset = "0x503CA10", VA = "0x18503E210")]
	public BMICAOOFJOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000545")]
	[Cpp2IlInjected.Address(RVA = "0x503E1D0", Offset = "0x503C9D0", VA = "0x18503E1D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[DOHCKPDOJMD(PAPAHBCPMGP.Connectables)]
	public class UpdateConnectableVisuals : IHCMLLDKAMA, DKFAOOPHPAH
	{
		[Cpp2IlInjected.Token(Token = "0x2000096")]
		private struct PFEMNFLABGN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F5")]
			public FLCKNCKMGDM LPPHLKEKIOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001F6")]
			public float3 BAFCICKIIDG;

			[Cpp2IlInjected.Token(Token = "0x6000568")]
			[Cpp2IlInjected.Address(RVA = "0xBA39A0", Offset = "0xBA21A0", VA = "0x180BA39A0")]
			public PFEMNFLABGN(FLCKNCKMGDM LPPHLKEKIOC, float3 BAFCICKIIDG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000569")]
			[Cpp2IlInjected.Address(RVA = "0xBA3980", Offset = "0xBA2180", VA = "0x180BA3980")]
			public void JEEEGHBGKHP(out FLCKNCKMGDM LPPHLKEKIOC, out float3 BAFCICKIIDG)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000098")]
		[CompilerGenerated]
		private struct KFMBECLGPCG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001F9")]
			public UpdateConnectableVisuals <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001FA")]
			public NativeList<PFEMNFLABGN> list;

			[Cpp2IlInjected.Token(Token = "0x600056D")]
			[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
			public KFMBECLGPCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600056E")]
			[Cpp2IlInjected.Address(RVA = "0xB9AE70", Offset = "0xB99670", VA = "0x180B9AE70")]
			internal void <GetLegacyGizmoParentLinkPositions>b__0(Entity entity, WorldPoseData pose, in DynamicBuffer<DCKGNMEJOED> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000099")]
		[CompilerGenerated]
		private struct FOCOAOHHGLB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FB")]
			public NativeList<PFEMNFLABGN> list;

			[Cpp2IlInjected.Token(Token = "0x600056F")]
			[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
			public FOCOAOHHGLB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000570")]
			[Cpp2IlInjected.Address(RVA = "0xB9AE70", Offset = "0xB99670", VA = "0x180B9AE70")]
			internal void <GetChildLinkPositionsWoutCoM>b__0(in WorldPoseData pose, in DynamicBuffer<PMNOLDCLIGM> state)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200009A")]
		[CompilerGenerated]
		private struct NAOJPDPNAKP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FC")]
			public NativeList<PFEMNFLABGN> list;

			[Cpp2IlInjected.Token(Token = "0x6000571")]
			[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
			public NAOJPDPNAKP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000572")]
			[Cpp2IlInjected.Address(RVA = "0xB9AE70", Offset = "0xB99670", VA = "0x180B9AE70")]
			internal void <GetChildLinkPositionsWithCoM>b__0(in WorldPoseData pose, in DFOPADAJPFE com, in DynamicBuffer<PMNOLDCLIGM> state)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009B")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct CHHGCJOCDFO : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200009C")]
			private struct ALEMIFLNPCF
			{
				[Cpp2IlInjected.Token(Token = "0x200009D")]
				public struct JNDOEONHHDA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000205")]
					public LambdaParameterValueProvider_Entity.Runtime JHKKGOELPEG;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000206")]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime BOMLPBAHILP;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000207")]
					public LambdaParameterValueProvider_DynamicBuffer<DCKGNMEJOED>.Runtime HKBEPOPCONJ;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000202")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity LBGHHAFFEOM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000203")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> OOFKNIPOFGL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x4000204")]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<DCKGNMEJOED> BFEDIKMPFNP;

				[Cpp2IlInjected.Token(Token = "0x600057A")]
				[Cpp2IlInjected.Address(RVA = "0xB9A330", Offset = "0xB98B30", VA = "0x180B9A330")]
				public void LNGFEFINAKH(UpdateConnectableVisuals JNPNDBIIELC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600057B")]
				[Cpp2IlInjected.Address(RVA = "0xB9A280", Offset = "0xB98A80", VA = "0x180B9A280")]
				public JNDOEONHHDA FJADKACAIMI(ref ArchetypeChunk KGKNEONCAKP, int JKMLLEJBOIE, int CEJIHAPILEF)
				{
					return default(JNDOEONHHDA);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public UpdateConnectableVisuals LKHHMLPCBMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public NativeList<PFEMNFLABGN> BAKFHBILFME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			private ALEMIFLNPCF ICGPFDNJJFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe ALEMIFLNPCF.JNDOEONHHDA* DACPFDLDMPF;

			[Cpp2IlInjected.Token(Token = "0x4000201")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate INAKAPMMIIH;

			[Cpp2IlInjected.Token(Token = "0x6000573")]
			[Cpp2IlInjected.Address(RVA = "0xB9A5A0", Offset = "0xB98DA0", VA = "0x180B9A5A0")]
			internal void KFAKMCGDEPE(Entity NBIJCGHBCCI, WorldPoseData IKJFDBDPJHP, in DynamicBuffer<DCKGNMEJOED> KCDMBPDEAMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000574")]
			[Cpp2IlInjected.Address(RVA = "0xB9A990", Offset = "0xB99190", VA = "0x180B9A990", Slot = "5")]
			public void ReadFromDisplayClass(ref KFMBECLGPCG AMPNHBNMCND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000575")]
			[Cpp2IlInjected.Address(RVA = "0xB9A9C0", Offset = "0xB991C0", VA = "0x180B9A9C0", Slot = "6")]
			public void WriteToDisplayClass(ref KFMBECLGPCG AMPNHBNMCND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000576")]
			[Cpp2IlInjected.Address(RVA = "0xB9A4C0", Offset = "0xB98CC0", VA = "0x180B9A4C0", Slot = "4")]
			public void Execute(ArchetypeChunk ENPKJHPNEAL, int CLJFBMDOKCI, int LHMFKCGLDPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000577")]
			[Cpp2IlInjected.Address(RVA = "0xB9A800", Offset = "0xB99000", VA = "0x180B9A800")]
			public void NLDAPEGBEMO(ref ArchetypeChunk ENPKJHPNEAL, ref ALEMIFLNPCF.JNDOEONHHDA GJDLAKGIODP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000578")]
			[Cpp2IlInjected.Address(RVA = "0xB9A7C0", Offset = "0xB98FC0", VA = "0x180B9A7C0")]
			public void LNGFEFINAKH(UpdateConnectableVisuals JNPNDBIIELC, ref KFMBECLGPCG AMPNHBNMCND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000579")]
			[Cpp2IlInjected.Address(RVA = "0xB9A930", Offset = "0xB99130", VA = "0x180B9A930")]
			public unsafe static void NNJMFIJBDKK(ArchetypeChunkIterator* PBAMKHEMGLK, void* OFPFIAGIKFE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200009E")]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		[NoAlias]
		private struct HPCDLJALEJD : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200009F")]
			private struct DHEJPACBMOL
			{
				[Cpp2IlInjected.Token(Token = "0x20000A0")]
				[NoAlias]
				public struct PGDAAEDCIOO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x400020D")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime BOMLPBAHILP;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x400020E")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<PMNOLDCLIGM>.Runtime HKBEPOPCONJ;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400020B")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> OOFKNIPOFGL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400020C")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<PMNOLDCLIGM> BFEDIKMPFNP;

				[Cpp2IlInjected.Token(Token = "0x6000581")]
				[Cpp2IlInjected.Address(RVA = "0xB9AAA0", Offset = "0xB992A0", VA = "0x180B9AAA0")]
				public void LNGFEFINAKH(UpdateConnectableVisuals JNPNDBIIELC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000582")]
				[Cpp2IlInjected.Address(RVA = "0xB9AA00", Offset = "0xB99200", VA = "0x180B9AA00")]
				public PGDAAEDCIOO FJADKACAIMI(ref ArchetypeChunk KGKNEONCAKP, int JKMLLEJBOIE, int CEJIHAPILEF)
				{
					return default(PGDAAEDCIOO);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public NativeList<PFEMNFLABGN> BAKFHBILFME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			private DHEJPACBMOL ICGPFDNJJFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe DHEJPACBMOL.PGDAAEDCIOO* DACPFDLDMPF;

			[Cpp2IlInjected.Token(Token = "0x600057C")]
			[Cpp2IlInjected.Address(RVA = "0xB9BAC0", Offset = "0xB9A2C0", VA = "0x180B9BAC0")]
			internal void KFAKMCGDEPE(in WorldPoseData IKJFDBDPJHP, in DynamicBuffer<PMNOLDCLIGM> KCDMBPDEAMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057D")]
			[Cpp2IlInjected.Address(RVA = "0xB9AE60", Offset = "0xB99660", VA = "0x180B9AE60", Slot = "5")]
			public void ReadFromDisplayClass(ref FOCOAOHHGLB AMPNHBNMCND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057E")]
			[Cpp2IlInjected.Address(RVA = "0xB9B9F0", Offset = "0xB9A1F0", VA = "0x180B9B9F0", Slot = "4")]
			public void Execute(ArchetypeChunk ENPKJHPNEAL, int CLJFBMDOKCI, int LHMFKCGLDPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600057F")]
			[Cpp2IlInjected.Address(RVA = "0xB9BC50", Offset = "0xB9A450", VA = "0x180B9BC50")]
			public void NLDAPEGBEMO(ref ArchetypeChunk ENPKJHPNEAL, [NoAlias] ref DHEJPACBMOL.PGDAAEDCIOO GJDLAKGIODP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000580")]
			[Cpp2IlInjected.Address(RVA = "0xB9BBC0", Offset = "0xB9A3C0", VA = "0x180B9BBC0")]
			public void LNGFEFINAKH(UpdateConnectableVisuals JNPNDBIIELC, ref FOCOAOHHGLB AMPNHBNMCND)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000A1")]
		[NoAlias]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct EFFHAPGPFNI : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x20000A2")]
			private struct JFONJKKEAED
			{
				[Cpp2IlInjected.Token(Token = "0x20000A3")]
				[NoAlias]
				public struct NAHIOCKCEKM
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000215")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<WorldPoseData>.Runtime BOMLPBAHILP;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000216")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<DFOPADAJPFE>.Runtime AGHLNLMPDHA;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000217")]
					[NoAlias]
					public LambdaParameterValueProvider_DynamicBuffer<PMNOLDCLIGM>.Runtime HKBEPOPCONJ;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000212")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<WorldPoseData> OOFKNIPOFGL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000213")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<DFOPADAJPFE> ILKDJJOGIEL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000214")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_DynamicBuffer<PMNOLDCLIGM> BFEDIKMPFNP;

				[Cpp2IlInjected.Token(Token = "0x6000588")]
				[Cpp2IlInjected.Address(RVA = "0xB9C270", Offset = "0xB9AA70", VA = "0x180B9C270")]
				public void LNGFEFINAKH(UpdateConnectableVisuals JNPNDBIIELC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000589")]
				[Cpp2IlInjected.Address(RVA = "0xB9C1C0", Offset = "0xB9A9C0", VA = "0x180B9C1C0")]
				public NAHIOCKCEKM FJADKACAIMI(ref ArchetypeChunk KGKNEONCAKP, int JKMLLEJBOIE, int CEJIHAPILEF)
				{
					return default(NAHIOCKCEKM);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400020F")]
			public NativeList<PFEMNFLABGN> BAKFHBILFME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			private JFONJKKEAED ICGPFDNJJFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe JFONJKKEAED.NAHIOCKCEKM* DACPFDLDMPF;

			[Cpp2IlInjected.Token(Token = "0x6000583")]
			[Cpp2IlInjected.Address(RVA = "0xB9ABE0", Offset = "0xB993E0", VA = "0x180B9ABE0")]
			internal void KFAKMCGDEPE(in WorldPoseData IKJFDBDPJHP, in DFOPADAJPFE HADFEKFKJFG, in DynamicBuffer<PMNOLDCLIGM> KCDMBPDEAMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000584")]
			[Cpp2IlInjected.Address(RVA = "0xB9AE60", Offset = "0xB99660", VA = "0x180B9AE60", Slot = "5")]
			public void ReadFromDisplayClass(ref NAOJPDPNAKP AMPNHBNMCND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000585")]
			[Cpp2IlInjected.Address(RVA = "0xB9AB00", Offset = "0xB99300", VA = "0x180B9AB00", Slot = "4")]
			public void Execute(ArchetypeChunk ENPKJHPNEAL, int CLJFBMDOKCI, int LHMFKCGLDPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000586")]
			[Cpp2IlInjected.Address(RVA = "0xB9AD70", Offset = "0xB99570", VA = "0x180B9AD70")]
			public void NLDAPEGBEMO(ref ArchetypeChunk ENPKJHPNEAL, [NoAlias] ref JFONJKKEAED.NAHIOCKCEKM GJDLAKGIODP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000587")]
			[Cpp2IlInjected.Address(RVA = "0xB9AD30", Offset = "0xB99530", VA = "0x180B9AD30")]
			public void LNGFEFINAKH(UpdateConnectableVisuals JNPNDBIIELC, ref NAOJPDPNAKP AMPNHBNMCND)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private EntityQuery MHHEHOFHHBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private EntityQuery CKPLEAJABAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private EntityQuery PPMHOHOEGIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private EntityQuery BFPMHEAAPBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private EntityQuery NPNLJJCLMMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private EntityQuery CBKFPBIGCIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private EntityQuery KGOJHBMLLFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private EntityQuery MCGAFIHBEGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private EntityQuery GDPOKKMJBEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private global::JPGJBKNMCEO<FLCKNCKMGDM, ELFHFLPLNFA> PFPEIFFOFMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private HFCJOFNPJDG DOCHAPPBPEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private FOJPBIGOEBJ NLJLBCPPCEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private DGGIPLGOKHJ NENEJICOPCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private EntityQuery DEKJKLKEAPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private ProfilerMarker DJMEPPCENOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private EntityQuery JJEOEIKJDDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private EntityQuery BAOPJKHNLBK;

		[Cpp2IlInjected.Token(Token = "0x170000C2")]
		public int KKHILPEBPDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000546")]
			[Cpp2IlInjected.Address(RVA = "0xBB3590", Offset = "0xBB1D90", VA = "0x180BB3590")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000547")]
		[Cpp2IlInjected.Address(RVA = "0xBB1800", Offset = "0xBB0000", VA = "0x180BB1800")]
		internal ELFHFLPLNFA EMENDGGJGCP(FLCKNCKMGDM LPPHLKEKIOC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000548")]
		[Cpp2IlInjected.Address(RVA = "0xBB1650", Offset = "0xBAFE50", VA = "0x180BB1650", Slot = "14")]
		public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000549")]
		[Cpp2IlInjected.Address(RVA = "0xBB3DB0", Offset = "0xBB25B0", VA = "0x180BB3DB0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054A")]
		[Cpp2IlInjected.Address(RVA = "0xBB3BE0", Offset = "0xBB23E0", VA = "0x180BB3BE0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054B")]
		[Cpp2IlInjected.Address(RVA = "0xBB0A20", Offset = "0xBAF220", VA = "0x180BB0A20")]
		private void BJGKIJMPAMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054C")]
		[Cpp2IlInjected.Address(RVA = "0xBB0B00", Offset = "0xBAF300", VA = "0x180BB0B00")]
		private void BKCKKLAHEKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054D")]
		[Cpp2IlInjected.Address(RVA = "0xBB1080", Offset = "0xBAF880", VA = "0x180BB1080")]
		private void CBMENBCCNIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054E")]
		[Cpp2IlInjected.Address(RVA = "0xBB3DF0", Offset = "0xBB25F0", VA = "0x180BB3DF0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600054F")]
		[Cpp2IlInjected.Address(RVA = "0xBB0510", Offset = "0xBAED10", VA = "0x180BB0510")]
		private void APPMGKEFBBH(EntityQuery NIONGONALEF, EntityQuery CEDPHHIKGDN, EntityQuery MLLAKIODMPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000550")]
		[Cpp2IlInjected.Address(RVA = "0xBB1EE0", Offset = "0xBB06E0", VA = "0x180BB1EE0")]
		private void HNPIBKEPMJF(global::AFGHFELLGFP<Entity> GAHHANNLBEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000551")]
		[Cpp2IlInjected.Address(RVA = "0xBB3740", Offset = "0xBB1F40", VA = "0x180BB3740")]
		private void NMPOEFKBHFL(global::AFGHFELLGFP<Entity> BJLKMAHEKHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000552")]
		[Cpp2IlInjected.Address(RVA = "0xBB39A0", Offset = "0xBB21A0", VA = "0x180BB39A0")]
		private void OILKAOFGIPK(global::AFGHFELLGFP<Entity> OEELAKOBFLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000553")]
		[Cpp2IlInjected.Address(RVA = "0xBB03D0", Offset = "0xBAEBD0", VA = "0x180BB03D0")]
		private void AKGJMHMBFIM(NativeList<FLCKNCKMGDM> DCOEECJADEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000554")]
		[Cpp2IlInjected.Address(RVA = "0xBB0C00", Offset = "0xBAF400", VA = "0x180BB0C00")]
		private NativeList<FLCKNCKMGDM> BMIOCCJMIEF(NativeArray<Entity> NLBMCCOBHKD)
		{
			return default(NativeList<FLCKNCKMGDM>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000555")]
		[Cpp2IlInjected.Address(RVA = "0xBB3090", Offset = "0xBB1890", VA = "0x180BB3090")]
		private void LLJAIFAPLCK(NativeArray<Entity> NLBMCCOBHKD, NativeList<FLCKNCKMGDM> DCOEECJADEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000556")]
		[Cpp2IlInjected.Address(RVA = "0xBB1850", Offset = "0xBB0050", VA = "0x180BB1850")]
		private void ENLGGCDPHIN(NativeArray<Entity> FMDFOMPKLAE, NativeArray<Entity> PMCHKCDLCPG, NativeList<FLCKNCKMGDM> HGCFNEKDDAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000557")]
		[Cpp2IlInjected.Address(RVA = "0xBB20E0", Offset = "0xBB08E0", VA = "0x180BB20E0")]
		private void IBALEIIJOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000558")]
		[Cpp2IlInjected.Address(RVA = "0xBB2E40", Offset = "0xBB1640", VA = "0x180BB2E40")]
		private global::DMIPGKGDJEO<PFEMNFLABGN> KKNKCHJJEJF(EntityQuery JIDAALIOAFE, Func<NativeList<PFEMNFLABGN>, JobHandle> HFIJDOIBPOJ)
		{
			return default(global::DMIPGKGDJEO<PFEMNFLABGN>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000559")]
		[Cpp2IlInjected.Address(RVA = "0xBB1480", Offset = "0xBAFC80", VA = "0x180BB1480")]
		private JobHandle CNBDDFIGLPE(NativeList<PFEMNFLABGN> BAKFHBILFME)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600055A")]
		[Cpp2IlInjected.Address(RVA = "0xBB2F70", Offset = "0xBB1770", VA = "0x180BB2F70")]
		private JobHandle LEGNKJEHLCA(NativeList<PFEMNFLABGN> BAKFHBILFME)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600055B")]
		[Cpp2IlInjected.Address(RVA = "0xBB08E0", Offset = "0xBAF0E0", VA = "0x180BB08E0")]
		private JobHandle BDOGKMFMJMD(NativeList<PFEMNFLABGN> BAKFHBILFME)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600055C")]
		[Cpp2IlInjected.Address(RVA = "0xBB01C0", Offset = "0xBAE9C0", VA = "0x180BB01C0")]
		private void ADMGBNGKHPE(global::DMIPGKGDJEO<PFEMNFLABGN> BAKFHBILFME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055D")]
		[Cpp2IlInjected.Address(RVA = "0xBB2C30", Offset = "0xBB1430", VA = "0x180BB2C30")]
		private void KIEJLJNDNNA(global::DMIPGKGDJEO<PFEMNFLABGN> BAKFHBILFME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600055E")]
		[Cpp2IlInjected.Address(RVA = "0xBB1E70", Offset = "0xBB0670", VA = "0x180BB1E70")]
		private bool GOFBFBLINIJ(Entity NBIJCGHBCCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600055F")]
		[Cpp2IlInjected.Address(RVA = "0xBB13B0", Offset = "0xBAFBB0", VA = "0x180BB13B0")]
		private NativeArray<Entity> CHILBLNOKND(Entity NBIJCGHBCCI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000560")]
		[Cpp2IlInjected.Address(RVA = "0xBB35D0", Offset = "0xBB1DD0", VA = "0x180BB35D0")]
		private FLCKNCKMGDM MFAEIGINOCG(NativeList<FLCKNCKMGDM> HGCFNEKDDAK)
		{
			return default(FLCKNCKMGDM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000561")]
		[Cpp2IlInjected.Address(RVA = "0xBB2750", Offset = "0xBB0F50", VA = "0x180BB2750")]
		private void INOCNJJAJLE(FLCKNCKMGDM LPPHLKEKIOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000562")]
		[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
		public UpdateConnectableVisuals()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000564")]
		[Cpp2IlInjected.Address(RVA = "0xBB3AC0", Offset = "0xBB22C0", VA = "0x180BB3AC0", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000565")]
		[Cpp2IlInjected.Address(RVA = "0xBB37D0", Offset = "0xBB1FD0", VA = "0x180BB37D0")]
		public static EntityQuery OALELFBGFOI(ComponentSystemBase JNPNDBIIELC)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000566")]
		[Cpp2IlInjected.Address(RVA = "0xBB27D0", Offset = "0xBB0FD0", VA = "0x180BB27D0")]
		public static EntityQuery KDODKBPKIEC(ComponentSystemBase JNPNDBIIELC)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000567")]
		[Cpp2IlInjected.Address(RVA = "0xBB2A00", Offset = "0xBB1200", VA = "0x180BB2A00")]
		public static EntityQuery KFKPLLPCMPG(ComponentSystemBase JNPNDBIIELC)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
internal class AJPECLGPNJP : IHCMLLDKAMA, DKFAOOPHPAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private EntityQuery NHLLFCJDDIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private ENJAHHPPGPN AGONKCODOEL;

	[Cpp2IlInjected.Token(Token = "0x600058A")]
	[Cpp2IlInjected.Address(RVA = "0x503BCE0", Offset = "0x503A4E0", VA = "0x18503BCE0", Slot = "14")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058B")]
	[Cpp2IlInjected.Address(RVA = "0x503C020", Offset = "0x503A820", VA = "0x18503C020", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058C")]
	[Cpp2IlInjected.Address(RVA = "0x503C0C0", Offset = "0x503A8C0", VA = "0x18503C0C0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058D")]
	[Cpp2IlInjected.Address(RVA = "0x503BDB0", Offset = "0x503A5B0", VA = "0x18503BDB0")]
	protected void NFKBCCCHAFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600058E")]
	[Cpp2IlInjected.Address(RVA = "0x1783450", Offset = "0x1781C50", VA = "0x181783450")]
	private bool PNIDHDHPEGM<TComponentData>(EntityQuery JIDAALIOAFE, out NativeArray<Entity> NLBMCCOBHKD, out NativeArray<TComponentData> COMKKLEOPMA) where TComponentData : struct, IComponentData
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600058F")]
	[Cpp2IlInjected.Address(RVA = "0x503BD30", Offset = "0x503A530", VA = "0x18503BD30")]
	public NNCLEEGIIBK LCOMJDDFAEH(Entity NBIJCGHBCCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000590")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
	public AJPECLGPNJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000591")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(SimulationSystemGroup))]
public class LNDGHILMKGF : IHCMLLDKAMA, DKFAOOPHPAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private ObjectEmbodimentService DMLIGOGCPEG;

	[Cpp2IlInjected.Token(Token = "0x6000592")]
	[Cpp2IlInjected.Address(RVA = "0x50D0560", Offset = "0x50CED60", VA = "0x1850D0560", Slot = "14")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000593")]
	[Cpp2IlInjected.Address(RVA = "0x50D05C0", Offset = "0x50CEDC0", VA = "0x1850D05C0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000594")]
	[Cpp2IlInjected.Address(RVA = "0x50D05F0", Offset = "0x50CEDF0", VA = "0x1850D05F0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000595")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
	public LNDGHILMKGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000596")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public class PMGBAPCJCOJ : IHCMLLDKAMA, DKFAOOPHPAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private EntityQuery MCMKECKDMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private EntityQuery INLPOKIBMOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private EntityQuery HFOBCPGGPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private EntityQuery LPJCCJKLEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	private ObjectEmbodimentService LLFMKLIIHHD;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public int JGMMMCHPMBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000597")]
		[Cpp2IlInjected.Address(RVA = "0xE5A560", Offset = "0xE58D60", VA = "0x180E5A560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public int FOENCACNGPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000598")]
		[Cpp2IlInjected.Address(RVA = "0xE5A880", Offset = "0xE59080", VA = "0x180E5A880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000599")]
	[Cpp2IlInjected.Address(RVA = "0xE5A4C0", Offset = "0xE58CC0", VA = "0x180E5A4C0", Slot = "14")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059A")]
	[Cpp2IlInjected.Address(RVA = "0xE5AC60", Offset = "0xE59460", VA = "0x180E5AC60", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059B")]
	[Cpp2IlInjected.Address(RVA = "0xE5AE10", Offset = "0xE59610", VA = "0x180E5AE10", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059C")]
	[Cpp2IlInjected.Address(RVA = "0xE5A650", Offset = "0xE58E50", VA = "0x180E5A650")]
	protected void HLKJHAGHOMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059D")]
	[Cpp2IlInjected.Address(RVA = "0xE5A960", Offset = "0xE59160", VA = "0x180E5A960")]
	protected void LMHGABDPNKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600059E")]
	[Cpp2IlInjected.Address(RVA = "0xE5AE30", Offset = "0xE59630", VA = "0x180E5AE30")]
	private bool PNIDHDHPEGM(EntityQuery JIDAALIOAFE, out NativeArray<Entity> NLBMCCOBHKD, out NativeArray<MGHDJBPABNH> CEOIMONPOFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600059F")]
	[Cpp2IlInjected.Address(RVA = "0xE5AB90", Offset = "0xE59390", VA = "0x180E5AB90")]
	public global::AFGHFELLGFP<Entity> NMKKIHLKLKE(Allocator DDJPHGFEOFF)
	{
		return default(global::AFGHFELLGFP<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A0")]
	[Cpp2IlInjected.Address(RVA = "0xE5A520", Offset = "0xE58D20", VA = "0x180E5A520")]
	public global::AFGHFELLGFP<Entity> ENBNDCBBPJN(Allocator DDJPHGFEOFF)
	{
		return default(global::AFGHFELLGFP<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A1")]
	[Cpp2IlInjected.Address(RVA = "0xE5ABD0", Offset = "0xE593D0", VA = "0x180E5ABD0")]
	public bool OJLACOGIAKM(Allocator DDJPHGFEOFF, out global::AFGHFELLGFP<Entity> MDLJNEBAIPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A2")]
	[Cpp2IlInjected.Address(RVA = "0xE5A570", Offset = "0xE58D70", VA = "0x180E5A570")]
	public bool GJPEFJBAECC(Entity NBIJCGHBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A3")]
	[Cpp2IlInjected.Address(RVA = "0xE5A8E0", Offset = "0xE590E0", VA = "0x180E5A8E0")]
	public NNCLEEGIIBK LCOMJDDFAEH(Entity NBIJCGHBCCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005A4")]
	[Cpp2IlInjected.Address(RVA = "0xE5A5E0", Offset = "0xE58DE0", VA = "0x180E5A5E0")]
	public bool GOFIPHNJIDA(Entity NBIJCGHBCCI, out ALOMAIDHFHJ MDLJNEBAIPD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A5")]
	[Cpp2IlInjected.Address(RVA = "0xE5A890", Offset = "0xE59090", VA = "0x180E5A890")]
	public void KNGBMEOFNIL(Entity NBIJCGHBCCI, ALOMAIDHFHJ MDLJNEBAIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A6")]
	[Cpp2IlInjected.Address(RVA = "0xE5A450", Offset = "0xE58C50", VA = "0x180E5A450")]
	public bool CNKLLFMNFGN(Entity NBIJCGHBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60005A7")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
	public PMGBAPCJCOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005A8")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public class ALOMAIDHFHJ : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public NNCLEEGIIBK MDLJNEBAIPD;

	[Cpp2IlInjected.Token(Token = "0x60005A9")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public ALOMAIDHFHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AA")]
	[Cpp2IlInjected.Address(RVA = "0x60E9F0", Offset = "0x60D1F0", VA = "0x18060E9F0")]
	public ALOMAIDHFHJ(NNCLEEGIIBK MDLJNEBAIPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(DGAKNMOKBFE))]
public class GDABJACKJJH : IHCMLLDKAMA
{
	[Cpp2IlInjected.Token(Token = "0x60005AB")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AC")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
	public GDABJACKJJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AD")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public abstract class NGHHGCBKEJH : IHCMLLDKAMA, DKFAOOPHPAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private JHKDIDOGONB ECIJJNHFBBE;

	[Cpp2IlInjected.Token(Token = "0x60005AE")]
	[Cpp2IlInjected.Address(RVA = "0x50D3FD0", Offset = "0x50D27D0", VA = "0x1850D3FD0", Slot = "14")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005AF")]
	[Cpp2IlInjected.Address(RVA = "0x50D4030", Offset = "0x50D2830", VA = "0x1850D4030", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B0")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
	protected NGHHGCBKEJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B1")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public class FLAMBJEPNJD : IHCMLLDKAMA, GHNBGLLDFLL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[CompilerGenerated]
	private struct PJKIPOHEHIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		public NativeList<IMKIELOKPIN> newParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		public NativeList<GCIIMAMNELL> changedParents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public NativeList<IMKIELOKPIN> oldParents;

		[Cpp2IlInjected.Token(Token = "0x60005B9")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
		public PJKIPOHEHIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BA")]
		[Cpp2IlInjected.Address(RVA = "0xB9AE70", Offset = "0xB99670", VA = "0x180B9AE70")]
		internal void <OnUpdate>b__0(Entity entity, ParentData current)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BB")]
		[Cpp2IlInjected.Address(RVA = "0xB9AE70", Offset = "0xB99670", VA = "0x180B9AE70")]
		internal void <OnUpdate>b__1(Entity entity, ParentData current, ECIBJLGBGHF previous)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BC")]
		[Cpp2IlInjected.Address(RVA = "0xB9AE70", Offset = "0xB99670", VA = "0x180B9AE70")]
		internal void <OnUpdate>b__2(Entity entity, ECIBJLGBGHF previous)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct FDNOFDPANKG : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000AD")]
		private struct BBGEACKHNEO
		{
			[Cpp2IlInjected.Token(Token = "0x20000AE")]
			[NoAlias]
			public struct DMPMLCNHIFH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400022E")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime JHKKGOELPEG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400022F")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime JAAOIAFPPBM;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400022C")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity LBGHHAFFEOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400022D")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ParentData> PLGOHINFABG;

			[Cpp2IlInjected.Token(Token = "0x60005C2")]
			[Cpp2IlInjected.Address(RVA = "0x503D910", Offset = "0x503C110", VA = "0x18503D910")]
			public void LNGFEFINAKH(FLAMBJEPNJD JNPNDBIIELC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005C3")]
			[Cpp2IlInjected.Address(RVA = "0x503D890", Offset = "0x503C090", VA = "0x18503D890")]
			public DMPMLCNHIFH FJADKACAIMI(ref ArchetypeChunk KGKNEONCAKP, int JKMLLEJBOIE, int CEJIHAPILEF)
			{
				return default(DMPMLCNHIFH);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public NativeList<IMKIELOKPIN> FJPOCPNIALI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		private BBGEACKHNEO ICGPFDNJJFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe BBGEACKHNEO.DMPMLCNHIFH* DACPFDLDMPF;

		[Cpp2IlInjected.Token(Token = "0x60005BD")]
		[Cpp2IlInjected.Address(RVA = "0x50448F0", Offset = "0x50430F0", VA = "0x1850448F0")]
		internal void KFAKMCGDEPE(Entity NBIJCGHBCCI, ParentData DIFGCKNOINJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BE")]
		[Cpp2IlInjected.Address(RVA = "0xB9AE60", Offset = "0xB99660", VA = "0x180B9AE60", Slot = "5")]
		public void ReadFromDisplayClass(ref PJKIPOHEHIC AMPNHBNMCND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005BF")]
		[Cpp2IlInjected.Address(RVA = "0x5044850", Offset = "0x5043050", VA = "0x185044850", Slot = "4")]
		public void Execute(ArchetypeChunk ENPKJHPNEAL, int CLJFBMDOKCI, int LHMFKCGLDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C0")]
		[Cpp2IlInjected.Address(RVA = "0x5044A10", Offset = "0x5043210", VA = "0x185044A10")]
		public void NLDAPEGBEMO(ref ArchetypeChunk ENPKJHPNEAL, [NoAlias] ref BBGEACKHNEO.DMPMLCNHIFH GJDLAKGIODP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C1")]
		[Cpp2IlInjected.Address(RVA = "0x5044980", Offset = "0x5043180", VA = "0x185044980")]
		public void LNGFEFINAKH(FLAMBJEPNJD JNPNDBIIELC, ref PJKIPOHEHIC AMPNHBNMCND)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	[NoAlias]
	private struct PIFOACIFDNF : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000B0")]
		private struct KCMHEIHJKIG
		{
			[Cpp2IlInjected.Token(Token = "0x20000B1")]
			[NoAlias]
			public struct BFLBKFPGGFB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000236")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime JHKKGOELPEG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000237")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ParentData>.Runtime JAAOIAFPPBM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000238")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ECIBJLGBGHF>.Runtime PILCMCCMKPP;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000233")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity LBGHHAFFEOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000234")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ParentData> PLGOHINFABG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000235")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ECIBJLGBGHF> CBLKICHKKLH;

			[Cpp2IlInjected.Token(Token = "0x60005C9")]
			[Cpp2IlInjected.Address(RVA = "0x504DBC0", Offset = "0x504C3C0", VA = "0x18504DBC0")]
			public void LNGFEFINAKH(FLAMBJEPNJD JNPNDBIIELC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005CA")]
			[Cpp2IlInjected.Address(RVA = "0x504DB20", Offset = "0x504C320", VA = "0x18504DB20")]
			public BFLBKFPGGFB FJADKACAIMI(ref ArchetypeChunk KGKNEONCAKP, int JKMLLEJBOIE, int CEJIHAPILEF)
			{
				return default(BFLBKFPGGFB);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		public NativeList<GCIIMAMNELL> KDLPCNNELAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		private KCMHEIHJKIG ICGPFDNJJFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe KCMHEIHJKIG.BFLBKFPGGFB* DACPFDLDMPF;

		[Cpp2IlInjected.Token(Token = "0x60005C4")]
		[Cpp2IlInjected.Address(RVA = "0x504E5B0", Offset = "0x504CDB0", VA = "0x18504E5B0")]
		internal void KFAKMCGDEPE(Entity NBIJCGHBCCI, ParentData DIFGCKNOINJ, ECIBJLGBGHF GCAIDMKNBKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C5")]
		[Cpp2IlInjected.Address(RVA = "0x504E760", Offset = "0x504CF60", VA = "0x18504E760", Slot = "5")]
		public void ReadFromDisplayClass(ref PJKIPOHEHIC AMPNHBNMCND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C6")]
		[Cpp2IlInjected.Address(RVA = "0x504E4E0", Offset = "0x504CCE0", VA = "0x18504E4E0", Slot = "4")]
		public void Execute(ArchetypeChunk ENPKJHPNEAL, int CLJFBMDOKCI, int LHMFKCGLDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C7")]
		[Cpp2IlInjected.Address(RVA = "0x504E690", Offset = "0x504CE90", VA = "0x18504E690")]
		public void NLDAPEGBEMO(ref ArchetypeChunk ENPKJHPNEAL, [NoAlias] ref KCMHEIHJKIG.BFLBKFPGGFB GJDLAKGIODP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005C8")]
		[Cpp2IlInjected.Address(RVA = "0x504E650", Offset = "0x504CE50", VA = "0x18504E650")]
		public void LNGFEFINAKH(FLAMBJEPNJD JNPNDBIIELC, ref PJKIPOHEHIC AMPNHBNMCND)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[NoAlias]
	[Unity.Entities.DOTSCompilerGenerated]
	[BurstCompile]
	private struct JPOPLDCJLKC : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000B3")]
		private struct KANNIKPICJK
		{
			[Cpp2IlInjected.Token(Token = "0x20000B4")]
			[NoAlias]
			public struct MIPPHCMOPBM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400023E")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime JHKKGOELPEG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400023F")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ECIBJLGBGHF>.Runtime PILCMCCMKPP;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400023C")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity LBGHHAFFEOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400023D")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ECIBJLGBGHF> CBLKICHKKLH;

			[Cpp2IlInjected.Token(Token = "0x60005D0")]
			[Cpp2IlInjected.Address(RVA = "0x504DAC0", Offset = "0x504C2C0", VA = "0x18504DAC0")]
			public void LNGFEFINAKH(FLAMBJEPNJD JNPNDBIIELC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005D1")]
			[Cpp2IlInjected.Address(RVA = "0x504DA40", Offset = "0x504C240", VA = "0x18504DA40")]
			public MIPPHCMOPBM FJADKACAIMI(ref ArchetypeChunk KGKNEONCAKP, int JKMLLEJBOIE, int CEJIHAPILEF)
			{
				return default(MIPPHCMOPBM);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		public NativeList<IMKIELOKPIN> OPIMMALPHIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		private KANNIKPICJK ICGPFDNJJFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe KANNIKPICJK.MIPPHCMOPBM* DACPFDLDMPF;

		[Cpp2IlInjected.Token(Token = "0x60005CB")]
		[Cpp2IlInjected.Address(RVA = "0x504D860", Offset = "0x504C060", VA = "0x18504D860")]
		internal void KFAKMCGDEPE(Entity NBIJCGHBCCI, ECIBJLGBGHF GCAIDMKNBKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CC")]
		[Cpp2IlInjected.Address(RVA = "0x504DA30", Offset = "0x504C230", VA = "0x18504DA30", Slot = "5")]
		public void ReadFromDisplayClass(ref PJKIPOHEHIC AMPNHBNMCND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CD")]
		[Cpp2IlInjected.Address(RVA = "0x504D7C0", Offset = "0x504BFC0", VA = "0x18504D7C0", Slot = "4")]
		public void Execute(ArchetypeChunk ENPKJHPNEAL, int CLJFBMDOKCI, int LHMFKCGLDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CE")]
		[Cpp2IlInjected.Address(RVA = "0x504D980", Offset = "0x504C180", VA = "0x18504D980")]
		public void NLDAPEGBEMO(ref ArchetypeChunk ENPKJHPNEAL, [NoAlias] ref KANNIKPICJK.MIPPHCMOPBM GJDLAKGIODP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005CF")]
		[Cpp2IlInjected.Address(RVA = "0x504D8F0", Offset = "0x504C0F0", VA = "0x18504D8F0")]
		public void LNGFEFINAKH(FLAMBJEPNJD JNPNDBIIELC, ref PJKIPOHEHIC AMPNHBNMCND)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private EAEMBLGCFOG FENJNEILPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private EntityQuery IIEFNGBGEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private EntityQuery MPEGEAJIGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private EntityQuery JLICDNGLPAO;

	[Cpp2IlInjected.Token(Token = "0x60005B2")]
	[Cpp2IlInjected.Address(RVA = "0x5045A20", Offset = "0x5044220", VA = "0x185045A20", Slot = "14")]
	public void BCKGPNKBBNF(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B3")]
	[Cpp2IlInjected.Address(RVA = "0x5046140", Offset = "0x5044940", VA = "0x185046140", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B4")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
	public FLAMBJEPNJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B5")]
	[Cpp2IlInjected.Address(RVA = "0x50460E0", Offset = "0x50448E0", VA = "0x1850460E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005B6")]
	[Cpp2IlInjected.Address(RVA = "0x5045AF0", Offset = "0x50442F0", VA = "0x185045AF0")]
	public static EntityQuery IOAFAIGKLKN(ComponentSystemBase JNPNDBIIELC)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B7")]
	[Cpp2IlInjected.Address(RVA = "0x5045D20", Offset = "0x5044520", VA = "0x185045D20")]
	public static EntityQuery JDPCLNDGINB(ComponentSystemBase JNPNDBIIELC)
	{
		return default(EntityQuery);
	}

	[Cpp2IlInjected.Token(Token = "0x60005B8")]
	[Cpp2IlInjected.Address(RVA = "0x5045F20", Offset = "0x5044720", VA = "0x185045F20")]
	public static EntityQuery LLBOCAMNEBI(ComponentSystemBase JNPNDBIIELC)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class KOKPEIHFBPI : ParentSystemBase<ParentData, ECIBJLGBGHF, ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x60005D2")]
	[Cpp2IlInjected.Address(RVA = "0x50CEF80", Offset = "0x50CD780", VA = "0x1850CEF80", Slot = "14")]
	protected override EntityQueryDesc AJBDOGOFGIF(EntityQueryDesc JIDAALIOAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D3")]
	[Cpp2IlInjected.Address(RVA = "0x79F5B0", Offset = "0x79DDB0", VA = "0x18079F5B0", Slot = "15")]
	protected override EntityQueryDesc IAAOHDADEAD(EntityQueryDesc JIDAALIOAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D4")]
	[Cpp2IlInjected.Address(RVA = "0x50CF000", Offset = "0x50CD800", VA = "0x1850CF000", Slot = "16")]
	protected override EntityQueryDesc KCCKAJAIOLF(EntityQueryDesc JIDAALIOAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D5")]
	[Cpp2IlInjected.Address(RVA = "0x50CEFC0", Offset = "0x50CD7C0", VA = "0x1850CEFC0", Slot = "17")]
	protected override EntityQueryDesc EJCJMBFJMIP(EntityQueryDesc JIDAALIOAFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60005D6")]
	[Cpp2IlInjected.Address(RVA = "0x50CF080", Offset = "0x50CD880", VA = "0x1850CF080")]
	public KOKPEIHFBPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60005D7")]
	[Cpp2IlInjected.Address(RVA = "0x50CF040", Offset = "0x50CD840", VA = "0x1850CF040", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public abstract class ParentSystemBase<ParentData, PreviousParentData, ChildrenData> : NODCCJFPGAM where ParentData : struct, IComponentData, HELLHLLCKLJ where PreviousParentData : struct, IComponentData, HELLHLLCKLJ where ChildrenData : struct, ISystemStateBufferElementData, IEquatable<ChildrenData>, HELLHLLCKLJ
	{
		[Cpp2IlInjected.Token(Token = "0x20000B7")]
		[BurstCompile]
		private struct IMCCHFGMHFG : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000248")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter PNAOJELICLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000249")]
			public NativeMultiHashMap<Entity, Entity>.ParallelWriter DOGGJMDLLIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024A")]
			public NativeHashMap<Entity, int>.ParallelWriter JNCJGGPPFBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024B")]
			public ArchetypeChunkComponentType<PreviousParentData> MEGOPFNHFAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024C")]
			[ReadOnly]
			public ArchetypeChunkComponentType<ParentData> BAEONHCJEIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024D")]
			[ReadOnly]
			public ArchetypeChunkEntityType MEDKDOEEGNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024E")]
			public uint PMPLCBFAPFL;

			[Cpp2IlInjected.Token(Token = "0x60005E6")]
			[Cpp2IlInjected.Address(RVA = "0x5294590", Offset = "0x5292D90", VA = "0x185294590", Slot = "4")]
			public void Execute(ArchetypeChunk ENPKJHPNEAL, int CLJFBMDOKCI, int LHMFKCGLDPD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B8")]
		[BurstCompile]
		private struct POHAKMMKJFJ : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400024F")]
			[ReadOnly]
			public NativeHashMap<Entity, int> JNCJGGPPFBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000250")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> OAJHIHKFKHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000251")]
			public NativeList<Entity> KADKOAHOHIE;

			[Cpp2IlInjected.Token(Token = "0x60005E7")]
			[Cpp2IlInjected.Address(RVA = "0x5298860", Offset = "0x5297060", VA = "0x185298860", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000B9")]
		[BurstCompile]
		private struct LHBLLBCBBGM : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000252")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> PNAOJELICLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000253")]
			[ReadOnly]
			public NativeMultiHashMap<Entity, Entity> DOGGJMDLLIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000254")]
			[ReadOnly]
			public NativeHashMap<Entity, int> JNCJGGPPFBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000255")]
			public BufferFromEntity<ChildrenData> OAJHIHKFKHM;

			[Cpp2IlInjected.Token(Token = "0x60005E8")]
			[Cpp2IlInjected.Address(RVA = "0x5295490", Offset = "0x5293C90", VA = "0x185295490")]
			private int KJIGIAKMIFI(DynamicBuffer<ChildrenData> DFGJAHNNJBK, Entity NBIJCGHBCCI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60005E9")]
			[Cpp2IlInjected.Address(RVA = "0x52956E0", Offset = "0x5293EE0", VA = "0x1852956E0")]
			private void MEJMBIHLFJP(Entity CELKNCFBAOE, DynamicBuffer<ChildrenData> DFGJAHNNJBK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EA")]
			[Cpp2IlInjected.Address(RVA = "0x5295130", Offset = "0x5293930", VA = "0x185295130")]
			private void IAJKKPPNHBG(Entity CELKNCFBAOE, DynamicBuffer<ChildrenData> DFGJAHNNJBK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005EB")]
			[Cpp2IlInjected.Address(RVA = "0x5294FA0", Offset = "0x52937A0", VA = "0x185294FA0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BA")]
		[BurstCompile]
		private struct EDAEGPLBKIL : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000256")]
			public NativeArray<Entity> PEONCBLEDNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000257")]
			public NativeList<Entity> EJJNHBDBKNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000258")]
			public BufferFromEntity<ChildrenData> OAJHIHKFKHM;

			[Cpp2IlInjected.Token(Token = "0x60005EC")]
			[Cpp2IlInjected.Address(RVA = "0x5293BC0", Offset = "0x52923C0", VA = "0x185293BC0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		protected EntityQuery LIODNBDFPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		protected EntityQuery KJNFBBNEHNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		protected EntityQuery HCADODFFLFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		protected EntityQuery IHIPOEOAEJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		protected ProfilerMarker GPCKMIMNJPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		protected ProfilerMarker EBOAPKKGLHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		protected ProfilerMarker PBIDAGCIAHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		protected ProfilerMarker LEIFHILGOEB;

		[Cpp2IlInjected.Token(Token = "0x60005D8")]
		[Cpp2IlInjected.Address(RVA = "0x529AA70", Offset = "0x5299270", VA = "0x18529AA70")]
		public ParentSystemBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005D9")]
		[Cpp2IlInjected.Address(RVA = "0x5299C00", Offset = "0x5298400", VA = "0x185299C00")]
		private int KJIGIAKMIFI(DynamicBuffer<ChildrenData> DFGJAHNNJBK, Entity NBIJCGHBCCI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60005DA")]
		[Cpp2IlInjected.Address(RVA = "0x5299A90", Offset = "0x5298290", VA = "0x185299A90")]
		private void CKPMNJJNKKO(Entity EPECHJFHILO, Entity BEKKINMCDGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005DB")]
		[Cpp2IlInjected.Address(RVA = "0x79F5B0", Offset = "0x79DDB0", VA = "0x18079F5B0", Slot = "14")]
		protected virtual EntityQueryDesc AJBDOGOFGIF(EntityQueryDesc JIDAALIOAFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DC")]
		[Cpp2IlInjected.Address(RVA = "0x79F5B0", Offset = "0x79DDB0", VA = "0x18079F5B0", Slot = "15")]
		protected virtual EntityQueryDesc IAAOHDADEAD(EntityQueryDesc JIDAALIOAFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DD")]
		[Cpp2IlInjected.Address(RVA = "0x79F5B0", Offset = "0x79DDB0", VA = "0x18079F5B0", Slot = "16")]
		protected virtual EntityQueryDesc KCCKAJAIOLF(EntityQueryDesc JIDAALIOAFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60005DE")]
		[Cpp2IlInjected.Address(Slot = "17")]
		protected abstract EntityQueryDesc EJCJMBFJMIP(EntityQueryDesc JIDAALIOAFE);

		[Cpp2IlInjected.Token(Token = "0x60005DF")]
		[Cpp2IlInjected.Address(RVA = "0x529A180", Offset = "0x5298980", VA = "0x18529A180", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E0")]
		[Cpp2IlInjected.Address(RVA = "0x529A780", Offset = "0x5298F80", VA = "0x18529A780")]
		private void PCGLJGBCIFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E1")]
		[Cpp2IlInjected.Address(RVA = "0x5299E00", Offset = "0x5298600", VA = "0x185299E00")]
		private void OBHEFOEFCNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E2")]
		[Cpp2IlInjected.Address(RVA = "0x5298FC0", Offset = "0x52977C0", VA = "0x185298FC0")]
		private void BDLNADFNKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E3")]
		[Cpp2IlInjected.Address(RVA = "0x5298960", Offset = "0x5297160", VA = "0x185298960")]
		private void AJKDDIIDOJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005E4")]
		[Cpp2IlInjected.Address(RVA = "0x529A6C0", Offset = "0x5298EC0", VA = "0x18529A6C0", Slot = "13")]
		protected override JobHandle OnUpdate(JobHandle PEALJNBNNCK)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60005E5")]
		[Cpp2IlInjected.Address(RVA = "0x254EA70", Offset = "0x254D270", VA = "0x18254EA70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[AlwaysUpdateSystem]
	[DOHCKPDOJMD(PAPAHBCPMGP.RenderEffects)]
	public abstract class PropagateTagsBase<TRootTag, TDescendantTag, TRootSystemTag> : IHCMLLDKAMA, GHNBGLLDFLL where TRootTag : struct, IComponentData where TDescendantTag : struct, IComponentData where TRootSystemTag : struct, ISystemStateComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x20000BC")]
		private struct PFDJCLDOJIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025D")]
			public global::DMIPGKGDJEO<Entity> DBEOPDHEPCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			public global::DMIPGKGDJEO<Entity> NNBHHJPMPAF;

			[Cpp2IlInjected.Token(Token = "0x60005FA")]
			[Cpp2IlInjected.Address(RVA = "0x5297EC0", Offset = "0x52966C0", VA = "0x185297EC0")]
			public PFDJCLDOJIE(NativeList<Entity> DBEOPDHEPCA, NativeList<Entity> NNBHHJPMPAF, JobHandle LHICIKNDDJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FB")]
			[Cpp2IlInjected.Address(RVA = "0x5297D50", Offset = "0x5296550", VA = "0x185297D50")]
			public JobHandle AFKGKGAEJJG(JobHandle ENADMBLJILB)
			{
				return default(JobHandle);
			}

			[Cpp2IlInjected.Token(Token = "0x60005FC")]
			[Cpp2IlInjected.Address(RVA = "0x5297E20", Offset = "0x5296620", VA = "0x185297E20")]
			public void KFAGLIPHBHL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		[BurstCompile]
		private struct MPOACJNFDIC : IJob
		{
			[Cpp2IlInjected.Token(Token = "0x20000BE")]
			[Flags]
			public enum NJAIFGFGOPN
			{
				[Cpp2IlInjected.Token(Token = "0x400026A")]
				ReadParentFromArray = 1,
				[Cpp2IlInjected.Token(Token = "0x400026B")]
				FetchParentFromEntity = 2,
				[Cpp2IlInjected.Token(Token = "0x400026C")]
				AncestorTagValue = 4,
				[Cpp2IlInjected.Token(Token = "0x400026D")]
				ConstNoAncestorTag = 0,
				[Cpp2IlInjected.Token(Token = "0x400026E")]
				ConstHasAncestorTag = 4
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025F")]
			[WriteOnly]
			public NativeList<Entity> LIJLOODAPON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000260")]
			[WriteOnly]
			public NativeList<Entity> HGKJJPJFJCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000261")]
			[ReadOnly]
			public NativeArray<Entity> COAJEEHKKBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000262")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> OECMINEEMHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000263")]
			[ReadOnly]
			public ComponentDataFromEntity<TRootTag> LAGDHMHHFIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000264")]
			[ReadOnly]
			public ComponentDataFromEntity<TDescendantTag> LHMDFEHCIKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000265")]
			[ReadOnly]
			public ComponentDataFromEntity<ParentData> JDCLMLIAOFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000266")]
			public int DMDGJMAIEOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000267")]
			public int CDFHGOJGJHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000268")]
			private NJAIFGFGOPN FKJMIOCKMOD;

			[Cpp2IlInjected.Token(Token = "0x60005FD")]
			[Cpp2IlInjected.Address(RVA = "0x5295EE0", Offset = "0x52946E0", VA = "0x185295EE0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FE")]
			[Cpp2IlInjected.Address(RVA = "0x5297290", Offset = "0x5295A90", VA = "0x185297290")]
			private void KGNPKJMHJFJ(Entity NBIJCGHBCCI, bool ODDCEAFLNPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60005FF")]
			[Cpp2IlInjected.Address(RVA = "0x5297490", Offset = "0x5295C90", VA = "0x185297490")]
			private void KMEBPMKINFC(Entity NBIJCGHBCCI, bool ODDCEAFLNPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000600")]
			[Cpp2IlInjected.Address(RVA = "0x5297970", Offset = "0x5296170", VA = "0x185297970")]
			public PFDJCLDOJIE PNAGDKPEGEN(NativeArray<Entity> BBHLGJGEJKP, JobHandle ENADMBLJILB)
			{
				return default(PFDJCLDOJIE);
			}

			[Cpp2IlInjected.Token(Token = "0x6000601")]
			[Cpp2IlInjected.Address(RVA = "0x5295AD0", Offset = "0x52942D0", VA = "0x185295AD0")]
			public PFDJCLDOJIE EFMPBOBLPGH(NativeArray<Entity> BBHLGJGEJKP, JobHandle ENADMBLJILB)
			{
				return default(PFDJCLDOJIE);
			}

			[Cpp2IlInjected.Token(Token = "0x6000602")]
			[Cpp2IlInjected.Address(RVA = "0x52976D0", Offset = "0x5295ED0", VA = "0x1852976D0")]
			public PFDJCLDOJIE LKIODMCOIJM(NativeList<IMKIELOKPIN> BAKFHBILFME, JobHandle ENADMBLJILB)
			{
				return default(PFDJCLDOJIE);
			}

			[Cpp2IlInjected.Token(Token = "0x6000603")]
			[Cpp2IlInjected.Address(RVA = "0x5296FF0", Offset = "0x52957F0", VA = "0x185296FF0")]
			public PFDJCLDOJIE JGGLDFJILKJ(NativeList<IMKIELOKPIN> BAKFHBILFME, JobHandle ENADMBLJILB)
			{
				return default(PFDJCLDOJIE);
			}

			[Cpp2IlInjected.Token(Token = "0x6000604")]
			[Cpp2IlInjected.Address(RVA = "0x5296B90", Offset = "0x5295390", VA = "0x185296B90")]
			public PFDJCLDOJIE IJMGMINLHIE(NativeList<GCIIMAMNELL> BAKFHBILFME, JobHandle ENADMBLJILB)
			{
				return default(PFDJCLDOJIE);
			}

			[Cpp2IlInjected.Token(Token = "0x6000605")]
			[Cpp2IlInjected.Address(RVA = "0xDAE020", Offset = "0xDAC820", VA = "0x180DAE020")]
			private PFDJCLDOJIE GNHEDAPKMJA<T>(NativeList<T> BAKFHBILFME, int CDNLHHOJGJC, int KDLCMBPFAAB, NJAIFGFGOPN CHFDMDJDKMA, JobHandle ENADMBLJILB) where T : struct
			{
				return default(PFDJCLDOJIE);
			}

			[Cpp2IlInjected.Token(Token = "0x6000606")]
			[Cpp2IlInjected.Address(RVA = "0x5296380", Offset = "0x5294B80", VA = "0x185296380")]
			private PFDJCLDOJIE GNHEDAPKMJA(NativeArray<Entity> NLBMCCOBHKD, int CDNLHHOJGJC, int KDLCMBPFAAB, NJAIFGFGOPN CHFDMDJDKMA, JobHandle ENADMBLJILB)
			{
				return default(PFDJCLDOJIE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private EntityQuery KAJJHGEFJLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private EntityQuery GOGKODOBMLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private EAEMBLGCFOG DPKGAHEGNDB;

		[Cpp2IlInjected.Token(Token = "0x60005ED")]
		[Cpp2IlInjected.Address(RVA = "0x529ACD0", Offset = "0x52994D0", VA = "0x18529ACD0", Slot = "14")]
		public void BCKGPNKBBNF(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EE")]
		[Cpp2IlInjected.Address(RVA = "0x529B540", Offset = "0x5299D40", VA = "0x18529B540", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005EF")]
		[Cpp2IlInjected.Address(RVA = "0x529C4E0", Offset = "0x529ACE0", VA = "0x18529C4E0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F0")]
		[Cpp2IlInjected.Address(RVA = "0x529DDC0", Offset = "0x529C5C0", VA = "0x18529DDC0")]
		private void PNMNOBKDMJO(NativeArray<Entity> BAKFHBILFME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F1")]
		[Cpp2IlInjected.Address(RVA = "0x529B4D0", Offset = "0x5299CD0", VA = "0x18529B4D0")]
		private void NOCOIAFCGNF(NativeArray<Entity> BAKFHBILFME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F2")]
		[Cpp2IlInjected.Address(RVA = "0x529AE70", Offset = "0x5299670", VA = "0x18529AE70")]
		private void CHKKPAFEBFJ(PFDJCLDOJIE PILONIAPBMJ, string EACHJMJCCBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F3")]
		[Cpp2IlInjected.Address(RVA = "0x529AFC0", Offset = "0x52997C0", VA = "0x18529AFC0")]
		private void CHKKPAFEBFJ(global::DMIPGKGDJEO<Entity> OIGFIFKCPND, string EACHJMJCCBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F4")]
		[Cpp2IlInjected.Address(RVA = "0x529B380", Offset = "0x5299B80", VA = "0x18529B380")]
		private void KCDAOCOLCKC(PFDJCLDOJIE PILONIAPBMJ, string EACHJMJCCBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F5")]
		[Cpp2IlInjected.Address(RVA = "0x529B290", Offset = "0x5299A90", VA = "0x18529B290")]
		private void KCDAOCOLCKC(global::DMIPGKGDJEO<Entity> OIGFIFKCPND, string EACHJMJCCBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F6")]
		[Cpp2IlInjected.Address(RVA = "0x529ABB0", Offset = "0x52993B0", VA = "0x18529ABB0")]
		private bool ACFEKOPOICL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60005F7")]
		[Cpp2IlInjected.Address(RVA = "0x529DEA0", Offset = "0x529C6A0", VA = "0x18529DEA0")]
		protected PropagateTagsBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60005F9")]
		[Cpp2IlInjected.Address(RVA = "0x254EA70", Offset = "0x254D270", VA = "0x18254EA70", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000BF")]
public struct HFDMILLIKNN : ISystemStateComponentData, IComponentData, IEquatable<HFDMILLIKNN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public float3 GFBBEGGKAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public float3 NLIMLLBDGMD;

	[Cpp2IlInjected.Token(Token = "0x6000607")]
	[Cpp2IlInjected.Address(RVA = "0x504AE70", Offset = "0x5049670", VA = "0x18504AE70", Slot = "4")]
	public bool Equals(HFDMILLIKNN ALBOAABJIJF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C0")]
public class AHAAABKNGHO : IHCMLLDKAMA, DKFAOOPHPAH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	[CompilerGenerated]
	private struct FGFBJDBFPDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public AHAAABKNGHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600060E")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
		public FGFBJDBFPDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600060F")]
		[Cpp2IlInjected.Address(RVA = "0xB9AE70", Offset = "0xB99670", VA = "0x180B9AE70")]
		internal void <OnUpdate>b__0(Entity e)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct PDKFICEIEHF : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000C3")]
		private struct PJLIFFBKACN
		{
			[Cpp2IlInjected.Token(Token = "0x20000C4")]
			public struct ICEMJBDOHHP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400027D")]
				public LambdaParameterValueProvider_Entity.Runtime GHJMJAFIFCE;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400027C")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity INAMGPLIODA;

			[Cpp2IlInjected.Token(Token = "0x6000617")]
			[Cpp2IlInjected.Address(RVA = "0x504EB90", Offset = "0x504D390", VA = "0x18504EB90")]
			public void LNGFEFINAKH(AHAAABKNGHO JNPNDBIIELC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000618")]
			[Cpp2IlInjected.Address(RVA = "0x504EB80", Offset = "0x504D380", VA = "0x18504EB80")]
			public ICEMJBDOHHP FJADKACAIMI(ref ArchetypeChunk KGKNEONCAKP, int JKMLLEJBOIE, int CEJIHAPILEF)
			{
				return default(ICEMJBDOHHP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public AHAAABKNGHO LKHHMLPCBMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public EntityCommandBuffer EDBHIBHFPIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		private PJLIFFBKACN ICGPFDNJJFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe PJLIFFBKACN.ICEMJBDOHHP* DACPFDLDMPF;

		[Cpp2IlInjected.Token(Token = "0x400027B")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate INAKAPMMIIH;

		[Cpp2IlInjected.Token(Token = "0x6000610")]
		[Cpp2IlInjected.Address(RVA = "0x504E1A0", Offset = "0x504C9A0", VA = "0x18504E1A0")]
		internal void KFAKMCGDEPE(Entity HFHIFPILNEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000611")]
		[Cpp2IlInjected.Address(RVA = "0xE4C190", Offset = "0xE4A990", VA = "0x180E4C190", Slot = "5")]
		public void ReadFromDisplayClass(ref FGFBJDBFPDE AMPNHBNMCND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000612")]
		[Cpp2IlInjected.Address(RVA = "0xE4C1C0", Offset = "0xE4A9C0", VA = "0x180E4C1C0", Slot = "6")]
		public void WriteToDisplayClass(ref FGFBJDBFPDE AMPNHBNMCND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000613")]
		[Cpp2IlInjected.Address(RVA = "0x504E140", Offset = "0x504C940", VA = "0x18504E140", Slot = "4")]
		public void Execute(ArchetypeChunk ENPKJHPNEAL, int CLJFBMDOKCI, int LHMFKCGLDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000614")]
		[Cpp2IlInjected.Address(RVA = "0x504E2E0", Offset = "0x504CAE0", VA = "0x18504E2E0")]
		public void NLDAPEGBEMO(ref ArchetypeChunk ENPKJHPNEAL, ref PJLIFFBKACN.ICEMJBDOHHP GJDLAKGIODP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000615")]
		[Cpp2IlInjected.Address(RVA = "0x504E2A0", Offset = "0x504CAA0", VA = "0x18504E2A0")]
		public void LNGFEFINAKH(AHAAABKNGHO JNPNDBIIELC, ref FGFBJDBFPDE AMPNHBNMCND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000616")]
		[Cpp2IlInjected.Address(RVA = "0x504E350", Offset = "0x504CB50", VA = "0x18504E350")]
		public unsafe static void NNJMFIJBDKK(ArchetypeChunkIterator* PBAMKHEMGLK, void* OFPFIAGIKFE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private FKLMGALCAMD JKEFJDBNGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private ICHIOKBIGBA GOKPOHIAIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private EntityQuery GJLJOFDAEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private ProfilerMarker JBEAFDJPKOI;

	[Cpp2IlInjected.Token(Token = "0x6000608")]
	[Cpp2IlInjected.Address(RVA = "0x503B600", Offset = "0x5039E00", VA = "0x18503B600", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000609")]
	[Cpp2IlInjected.Address(RVA = "0x503B210", Offset = "0x5039A10", VA = "0x18503B210", Slot = "14")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060A")]
	[Cpp2IlInjected.Address(RVA = "0x503B660", Offset = "0x5039E60", VA = "0x18503B660", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060B")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
	public AHAAABKNGHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060C")]
	[Cpp2IlInjected.Address(RVA = "0x503B400", Offset = "0x5039C00", VA = "0x18503B400", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600060D")]
	[Cpp2IlInjected.Address(RVA = "0x503B270", Offset = "0x5039A70", VA = "0x18503B270")]
	public static EntityQuery EIHDGAHONKD(ComponentSystemBase JNPNDBIIELC)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C5")]
public struct LJDLNCLFAMC : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public KENLICLHJFC LPPHLKEKIOC;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000619")]
	[Cpp2IlInjected.Address(RVA = "0x66E700", Offset = "0x66CF00", VA = "0x18066E700")]
	public static LJDLNCLFAMC HLHIMDAEEEO(in KENLICLHJFC GKMOKPIBFHC)
	{
		return default(LJDLNCLFAMC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600061A")]
	[Cpp2IlInjected.Address(RVA = "0x66E700", Offset = "0x66CF00", VA = "0x18066E700")]
	public static KENLICLHJFC HLHIMDAEEEO(in LJDLNCLFAMC DDNGJGMDFON)
	{
		return default(KENLICLHJFC);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C6")]
[CEFINOONOIN(typeof(ICHIOKBIGBA), new string[] { })]
public sealed class GFLFOIJOBNJ : ICHIOKBIGBA, CAMIJMPEPJA, CMBMJNFKKCN, DKFAOOPHPAH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private const int LDJHMJLDFFN = -1;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private const int HNJMIFGKHPN = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private Collider[] FIDAODLAPFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private RaycastHit[] LFLPLMCINMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private global::JPGJBKNMCEO<KENLICLHJFC, BoxCollider> OKFIABFOODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private Scene KBLKDNCIAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private PhysicsScene OEBLIALDGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private GameObject IIFCAFGLJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private FCGCJNHMCDH HAFBOCLMCGB;

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int HHNNMJFIKHD
	{
		[Cpp2IlInjected.Token(Token = "0x600061E")]
		[Cpp2IlInjected.Address(RVA = "0x5048C60", Offset = "0x5047460", VA = "0x185048C60", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600061B")]
	[Cpp2IlInjected.Address(RVA = "0x5048600", Offset = "0x5046E00", VA = "0x185048600", Slot = "10")]
	public void FNNKDMJCDCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061C")]
	[Cpp2IlInjected.Address(RVA = "0x5048410", Offset = "0x5046C10", VA = "0x185048410", Slot = "11")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061D")]
	[Cpp2IlInjected.Address(RVA = "0x5048330", Offset = "0x5046B30", VA = "0x185048330", Slot = "12")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600061F")]
	[Cpp2IlInjected.Address(RVA = "0x5048210", Offset = "0x5046A10", VA = "0x185048210", Slot = "5")]
	public KENLICLHJFC DJDCAMAPDEM(Entity NBIJCGHBCCI)
	{
		return default(KENLICLHJFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000620")]
	[Cpp2IlInjected.Address(RVA = "0x5048A60", Offset = "0x5047260", VA = "0x185048A60", Slot = "6")]
	public void GGMDHHKNIHM(NativeArray<KENLICLHJFC> CEOIMONPOFG, NativeArray<HFDMILLIKNN> ENJDOAHDOJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000621")]
	[Cpp2IlInjected.Address(RVA = "0x5048FA0", Offset = "0x50477A0", VA = "0x185048FA0", Slot = "7")]
	public void NPCCKHKNNJO(KENLICLHJFC LPPHLKEKIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000622")]
	[Cpp2IlInjected.Address(RVA = "0x5047FA0", Offset = "0x50467A0", VA = "0x185047FA0", Slot = "8")]
	public bool ANPJJGDKHJE(KENLICLHJFC LPPHLKEKIOC, out Collider OKCFJNOIDBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000623")]
	[Cpp2IlInjected.Address(RVA = "0x5048750", Offset = "0x5046F50", VA = "0x185048750")]
	public bool GDOHKFNFMFO(in float3 PILBMAKMDBK, in float3 ABCIPBECLHO, float OHGAJDFAGIK, Allocator DDJPHGFEOFF, out NativeArray<Entity> NLBMCCOBHKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000624")]
	[Cpp2IlInjected.Address(RVA = "0x5049040", Offset = "0x5047840", VA = "0x185049040")]
	private void OHKAGOJCEDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000625")]
	[Cpp2IlInjected.Address(RVA = "0x1944F10", Offset = "0x1943710", VA = "0x181944F10")]
	private void PDMIAMHPHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000626")]
	[Cpp2IlInjected.Address(RVA = "0x50485B0", Offset = "0x5046DB0", VA = "0x1850485B0")]
	private void EBCGPNKEDHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000627")]
	[Cpp2IlInjected.Address(RVA = "0x14BC750", Offset = "0x14BAF50", VA = "0x1814BC750")]
	private void FMJKLLFPLGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000628")]
	[Cpp2IlInjected.Address(RVA = "0x50484C0", Offset = "0x5046CC0", VA = "0x1850484C0")]
	private BoxCollider EALFIDGNGGJ(Entity NBIJCGHBCCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000629")]
	[Cpp2IlInjected.Address(RVA = "0x50490A0", Offset = "0x50478A0", VA = "0x1850490A0")]
	private void PPNGFJHEAFC(BoxCollider OIFEEMFDDIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062A")]
	[Cpp2IlInjected.Address(RVA = "0x5048F20", Offset = "0x5047720", VA = "0x185048F20")]
	[Conditional("UNITY_EDITOR")]
	private void MJEGLNCMOBN(GameObject KFNNOPCEBCG, Entity NBIJCGHBCCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062B")]
	[Cpp2IlInjected.Address(RVA = "0x5048DD0", Offset = "0x50475D0", VA = "0x185048DD0")]
	private void MGDLHIHNOKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062C")]
	[Cpp2IlInjected.Address(RVA = "0x5048CA0", Offset = "0x50474A0", VA = "0x185048CA0")]
	private void IJOJJEGPBIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062D")]
	[Cpp2IlInjected.Address(RVA = "0x5048040", Offset = "0x5046840", VA = "0x185048040")]
	private void CJPMPADNPBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062E")]
	[Cpp2IlInjected.Address(RVA = "0x5048F70", Offset = "0x5047770", VA = "0x185048F70")]
	private void NKGLAFNOKJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600062F")]
	[Cpp2IlInjected.Address(RVA = "0x5048F60", Offset = "0x5047760", VA = "0x185048F60")]
	private void NBHPBHENJLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000630")]
	[Cpp2IlInjected.Address(RVA = "0x5048D90", Offset = "0x5047590", VA = "0x185048D90")]
	private void KOECIEDCOGF(Scene FEOANBBLOCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000631")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public GFLFOIJOBNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000632")]
	[Cpp2IlInjected.Address(RVA = "0x5049090", Offset = "0x5047890", VA = "0x185049090", Slot = "9")]
	private bool PKDNJJMPLFH(in float3 PILBMAKMDBK, in float3 ABCIPBECLHO, float OHGAJDFAGIK, Allocator DDJPHGFEOFF, out NativeArray<Entity> NLBMCCOBHKD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C7")]
public class FKLMGALCAMD : EntityCommandBufferSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000633")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50")]
	public FKLMGALCAMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000634")]
	[Cpp2IlInjected.Address(RVA = "0x606E30", Offset = "0x605630", VA = "0x180606E30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
public class PEJEPBOAHPC : IHCMLLDKAMA, DKFAOOPHPAH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000C9")]
	[CompilerGenerated]
	private struct OALKGLBLNIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public PEJEPBOAHPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x600063B")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
		public OALKGLBLNIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063C")]
		[Cpp2IlInjected.Address(RVA = "0xB9AE70", Offset = "0xB99670", VA = "0x180B9AE70")]
		internal void <OnUpdate>b__0(Entity e, LJDLNCLFAMC ch)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000CA")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct BMJLHEDLHPO : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000CB")]
		private struct BEIBDDAADMO
		{
			[Cpp2IlInjected.Token(Token = "0x20000CC")]
			public struct BDKFHEHKPCP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000295")]
				public LambdaParameterValueProvider_Entity.Runtime GHJMJAFIFCE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000296")]
				public LambdaParameterValueProvider_IComponentData<LJDLNCLFAMC>.Runtime HIPICIBPJDD;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000293")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity INAMGPLIODA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000294")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<LJDLNCLFAMC> BPEECNBICGD;

			[Cpp2IlInjected.Token(Token = "0x6000644")]
			[Cpp2IlInjected.Address(RVA = "0xE4BD30", Offset = "0xE4A530", VA = "0x180E4BD30")]
			public void LNGFEFINAKH(PEJEPBOAHPC JNPNDBIIELC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000645")]
			[Cpp2IlInjected.Address(RVA = "0xE4BCB0", Offset = "0xE4A4B0", VA = "0x180E4BCB0")]
			public BDKFHEHKPCP FJADKACAIMI(ref ArchetypeChunk KGKNEONCAKP, int JKMLLEJBOIE, int CEJIHAPILEF)
			{
				return default(BDKFHEHKPCP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public PEJEPBOAHPC LKHHMLPCBMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public EntityCommandBuffer EDBHIBHFPIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		private BEIBDDAADMO ICGPFDNJJFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe BEIBDDAADMO.BDKFHEHKPCP* DACPFDLDMPF;

		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate INAKAPMMIIH;

		[Cpp2IlInjected.Token(Token = "0x600063D")]
		[Cpp2IlInjected.Address(RVA = "0xE4BEF0", Offset = "0xE4A6F0", VA = "0x180E4BEF0")]
		internal void KFAKMCGDEPE(Entity HFHIFPILNEP, LJDLNCLFAMC PPHIEJCINEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063E")]
		[Cpp2IlInjected.Address(RVA = "0xE4C190", Offset = "0xE4A990", VA = "0x180E4C190", Slot = "5")]
		public void ReadFromDisplayClass(ref OALKGLBLNIE AMPNHBNMCND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600063F")]
		[Cpp2IlInjected.Address(RVA = "0xE4C1C0", Offset = "0xE4A9C0", VA = "0x180E4C1C0", Slot = "6")]
		public void WriteToDisplayClass(ref OALKGLBLNIE AMPNHBNMCND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000640")]
		[Cpp2IlInjected.Address(RVA = "0xE4BE50", Offset = "0xE4A650", VA = "0x180E4BE50", Slot = "4")]
		public void Execute(ArchetypeChunk ENPKJHPNEAL, int CLJFBMDOKCI, int LHMFKCGLDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000641")]
		[Cpp2IlInjected.Address(RVA = "0xE4C080", Offset = "0xE4A880", VA = "0x180E4C080")]
		public void NLDAPEGBEMO(ref ArchetypeChunk ENPKJHPNEAL, ref BEIBDDAADMO.BDKFHEHKPCP GJDLAKGIODP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000642")]
		[Cpp2IlInjected.Address(RVA = "0xE4BFF0", Offset = "0xE4A7F0", VA = "0x180E4BFF0")]
		public void LNGFEFINAKH(PEJEPBOAHPC JNPNDBIIELC, ref OALKGLBLNIE AMPNHBNMCND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000643")]
		[Cpp2IlInjected.Address(RVA = "0xE4C130", Offset = "0xE4A930", VA = "0x180E4C130")]
		public unsafe static void NNJMFIJBDKK(ArchetypeChunkIterator* PBAMKHEMGLK, void* OFPFIAGIKFE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private FKLMGALCAMD JKEFJDBNGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private ICHIOKBIGBA GOKPOHIAIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private EntityQuery BLCOGFEBAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private ProfilerMarker BFOCDCOMNPN;

	[Cpp2IlInjected.Token(Token = "0x6000635")]
	[Cpp2IlInjected.Address(RVA = "0xE597D0", Offset = "0xE57FD0", VA = "0x180E597D0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000636")]
	[Cpp2IlInjected.Address(RVA = "0xE593E0", Offset = "0xE57BE0", VA = "0x180E593E0", Slot = "14")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000637")]
	[Cpp2IlInjected.Address(RVA = "0xE59830", Offset = "0xE58030", VA = "0x180E59830", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000638")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
	public PEJEPBOAHPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000639")]
	[Cpp2IlInjected.Address(RVA = "0xE595D0", Offset = "0xE57DD0", VA = "0x180E595D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600063A")]
	[Cpp2IlInjected.Address(RVA = "0xE59440", Offset = "0xE57C40", VA = "0x180E59440")]
	public static EntityQuery NNDBPONKHIF(ComponentSystemBase JNPNDBIIELC)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000CD")]
	[DOHCKPDOJMD(PAPAHBCPMGP.Physics)]
	public class PhysicsSceneUpdateCollidersSystem : IHCMLLDKAMA, DKFAOOPHPAH
	{
		[Cpp2IlInjected.Token(Token = "0x20000CE")]
		private struct BKOBBOCDLAA : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002A1")]
			public CJCKKBOCBCP CJCNOIMAAPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40002A2")]
			public NativeHashMap<Entity, OKGJCEGJEIG> NLBMCCOBHKD;

			[Cpp2IlInjected.Token(Token = "0x6000654")]
			[Cpp2IlInjected.Address(RVA = "0xB9A420", Offset = "0xB98C20", VA = "0x180B9A420")]
			public BKOBBOCDLAA(int JPMPKCEDKPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000655")]
			[Cpp2IlInjected.Address(RVA = "0xB9A3B0", Offset = "0xB98BB0", VA = "0x180B9A3B0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000CF")]
		[BurstCompile]
		private struct NBHBHJJINLA : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002A3")]
			[ReadOnly]
			public NativeArray<Entity> NLBMCCOBHKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002A4")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> CDAOBNOLFID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002A5")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldDeformableScaleData> PJIEHCKDKPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002A6")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> KAHHCPBLBAL;

			[Cpp2IlInjected.Token(Token = "0x6000656")]
			[Cpp2IlInjected.Address(RVA = "0xB9CE40", Offset = "0xB9B640", VA = "0x180B9CE40", Slot = "4")]
			public void Execute(int AKLHCIJHJKB, TransformAccess EOBPGPELLLJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D0")]
		[BurstCompile]
		private struct GCLBFNMJEKB : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002A7")]
			[ReadOnly]
			public NativeArray<Entity> NLBMCCOBHKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002A8")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldPoseData> CDAOBNOLFID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002A9")]
			[ReadOnly]
			public ComponentDataFromEntity<WorldUniformScaleData> KAHHCPBLBAL;

			[Cpp2IlInjected.Token(Token = "0x6000657")]
			[Cpp2IlInjected.Address(RVA = "0xB9AE80", Offset = "0xB99680", VA = "0x180B9AE80", Slot = "4")]
			public void Execute(int AKLHCIJHJKB, TransformAccess EOBPGPELLLJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private ICHIOKBIGBA GOKPOHIAIDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private EntityQuery OJGOJGNAJNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		private EntityQuery FJLLAJANALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		private EntityQuery LOKGFHCPKHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private EntityQuery PONLLMBGOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		private EntityQuery PHNDEIIBINF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private JobHandle NBLKLOPJNMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private BKOBBOCDLAA HEENGFGBOMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private BKOBBOCDLAA DAEKOAFDBEM;

		[Cpp2IlInjected.Token(Token = "0x6000646")]
		[Cpp2IlInjected.Address(RVA = "0xBA3C10", Offset = "0xBA2410", VA = "0x180BA3C10", Slot = "14")]
		public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000647")]
		[Cpp2IlInjected.Address(RVA = "0xBA4510", Offset = "0xBA2D10", VA = "0x180BA4510", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000648")]
		[Cpp2IlInjected.Address(RVA = "0xBA4750", Offset = "0xBA2F50", VA = "0x180BA4750", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000649")]
		[Cpp2IlInjected.Address(RVA = "0xBA4760", Offset = "0xBA2F60", VA = "0x180BA4760", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064A")]
		[Cpp2IlInjected.Address(RVA = "0xBA4250", Offset = "0xBA2A50", VA = "0x180BA4250")]
		private void JPEIOLKLHCG(EntityQuery JIDAALIOAFE, out (global::AFGHFELLGFP<LJDLNCLFAMC> handles, global::AFGHFELLGFP<HFDMILLIKNN> bounds) DMDONNOOOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064B")]
		[Cpp2IlInjected.Address(RVA = "0xBA3A00", Offset = "0xBA2200", VA = "0x180BA3A00")]
		private void CEGHIPGDIMF((global::AFGHFELLGFP<LJDLNCLFAMC> handles, global::AFGHFELLGFP<HFDMILLIKNN> bounds) DMDONNOOOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064C")]
		[Cpp2IlInjected.Address(RVA = "0xBA3C70", Offset = "0xBA2470", VA = "0x180BA3C70")]
		private void ENAAIAGDODG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064D")]
		[Cpp2IlInjected.Address(RVA = "0xBA43B0", Offset = "0xBA2BB0", VA = "0x180BA43B0")]
		private void NCNMEDBHNNP(EntityQuery JIDAALIOAFE, out (global::AFGHFELLGFP<Entity> entities, global::AFGHFELLGFP<LJDLNCLFAMC> handles) DMDONNOOOJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064E")]
		[Cpp2IlInjected.Address(RVA = "0xBA3EA0", Offset = "0xBA26A0", VA = "0x180BA3EA0")]
		private void GIJDKOIGDBM((global::AFGHFELLGFP<Entity> entities, global::AFGHFELLGFP<LJDLNCLFAMC> handles) DMDONNOOOJK, BKOBBOCDLAA AKABJECIMHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600064F")]
		[Cpp2IlInjected.Address(RVA = "0xBA4100", Offset = "0xBA2900", VA = "0x180BA4100")]
		private JobHandle HKPAGFDBAGG(BKOBBOCDLAA AKABJECIMHD, ComponentDataFromEntity<WorldPoseData> CDAOBNOLFID, ComponentDataFromEntity<WorldUniformScaleData> KAHHCPBLBAL, ComponentDataFromEntity<WorldDeformableScaleData> PJIEHCKDKPN)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000650")]
		[Cpp2IlInjected.Address(RVA = "0xBA3D70", Offset = "0xBA2570", VA = "0x180BA3D70")]
		private JobHandle GHLINBNCAED(BKOBBOCDLAA AKABJECIMHD, ComponentDataFromEntity<WorldPoseData> CDAOBNOLFID, ComponentDataFromEntity<WorldUniformScaleData> KAHHCPBLBAL)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000651")]
		[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
		public PhysicsSceneUpdateCollidersSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000653")]
		[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D1")]
[CEFINOONOIN(typeof(OPJJGBNKIAF), new string[] { })]
public sealed class DEEBKKKFPGM : OPJJGBNKIAF, DKFAOOPHPAH
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x20000D2")]
	private struct KPHDNNJPCGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public float ICAHHELCHEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public uint BLBINEIGPNI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002AA")]
	private CAMIJMPEPJA GKJPHNJHBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	private GCCIHKGPIOM AEMLHGDNABJ;

	[Cpp2IlInjected.Token(Token = "0x6000658")]
	[Cpp2IlInjected.Address(RVA = "0x5041570", Offset = "0x503FD70", VA = "0x185041570", Slot = "5")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000659")]
	[Cpp2IlInjected.Address(RVA = "0x50415D0", Offset = "0x503FDD0", VA = "0x1850415D0")]
	public bool GDOHKFNFMFO(in float3 PILBMAKMDBK, in float3 ABCIPBECLHO, float OHGAJDFAGIK, out FMKJPGNJLOO PDHCKJKKNDJ, out Entity PKJFCACDAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065A")]
	[Cpp2IlInjected.Address(RVA = "0x50419F0", Offset = "0x50401F0", VA = "0x1850419F0")]
	public static bool NNIJNMHPMKM(in Span<FMKJPGNJLOO> FDOCJBDOPFC, float OHGAJDFAGIK, out int AKLHCIJHJKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600065B")]
	[Cpp2IlInjected.Address(RVA = "0x50419C0", Offset = "0x50401C0", VA = "0x1850419C0")]
	public static float NAMFIIHHIJE(float ICAHHELCHEM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600065C")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public DEEBKKKFPGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600065D")]
	[Cpp2IlInjected.Address(RVA = "0x5041560", Offset = "0x503FD60", VA = "0x185041560", Slot = "4")]
	private bool ANNHEGIGHAG(in float3 PILBMAKMDBK, in float3 ABCIPBECLHO, float OHGAJDFAGIK, out FMKJPGNJLOO PDHCKJKKNDJ, out Entity PKJFCACDAKH)
	{
		return default(bool);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D3")]
public struct IEOCNLLJDCG : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000D4")]
	[DOHCKPDOJMD(PAPAHBCPMGP.Physics)]
	public class SplineLocalBoundsSystem : IHCMLLDKAMA
	{
		[Cpp2IlInjected.Token(Token = "0x20000D5")]
		[BurstCompile]
		private struct MCPFHDJKFMP : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B3")]
			[ReadOnly]
			public NativeArray<Entity> CPOLFOOFMFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002B4")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointData> POBEPLPOFGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40002B5")]
			[ReadOnly]
			public ComponentDataFromEntity<HFDMILLIKNN> JFHGEKLFABO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40002B6")]
			[WriteOnly]
			public NativeHashMap<Entity, OKGJCEGJEIG>.ParallelWriter KMPDMHJFAHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40002B7")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter DNFIMGOJJMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40002B8")]
			[WriteOnly]
			public NativeList<Entity>.ParallelWriter KDJMIAMMFIO;

			[Cpp2IlInjected.Token(Token = "0x600066D")]
			[Cpp2IlInjected.Address(RVA = "0xB9C730", Offset = "0xB9AF30", VA = "0x180B9C730", Slot = "4")]
			public void Execute(int AKLHCIJHJKB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000D6")]
		[BurstCompile]
		private struct JBKMOAFJPNA : IJobFor
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40002B9")]
			[ReadOnly]
			public NativeArray<Entity> ODJDACBBAIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40002BA")]
			[ReadOnly]
			public BufferFromEntity<LinkedEntityGroup> LDGLGLJLMNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40002BB")]
			[ReadOnly]
			public ComponentDataFromEntity<SplinePointData> POBEPLPOFGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40002BC")]
			[NativeDisableParallelForRestriction]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<HFDMILLIKNN> MGIFBEOHBLA;

			[Cpp2IlInjected.Token(Token = "0x600066E")]
			[Cpp2IlInjected.Address(RVA = "0xB9BFC0", Offset = "0xB9A7C0", VA = "0x180B9BFC0", Slot = "4")]
			public void Execute(int AKLHCIJHJKB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		private EntityQuery DGAOLKKFJJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private EntityQuery GGHAHFMEKMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		private EntityQuery GALIKPLPEBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		private EntityQuery INNFIIDDOPG;

		[Cpp2IlInjected.Token(Token = "0x600065E")]
		[Cpp2IlInjected.Address(RVA = "0xBAA3A0", Offset = "0xBA8BA0", VA = "0x180BAA3A0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600065F")]
		[Cpp2IlInjected.Address(RVA = "0xBAA540", Offset = "0xBA8D40", VA = "0x180BAA540", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000660")]
		[Cpp2IlInjected.Address(RVA = "0xBA9D90", Offset = "0xBA8590", VA = "0x180BA9D90")]
		private JobHandle MLNAADIMKMK(global::AFGHFELLGFP<Entity> FPMNAPBFAMJ, int ABGIPDMABIG, JobHandle ENADMBLJILB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000661")]
		[Cpp2IlInjected.Address(RVA = "0xBA9E60", Offset = "0xBA8660", VA = "0x180BA9E60")]
		private JobHandle MLNAADIMKMK(NativeArray<Entity> KCEMKMFJPIO, int ABGIPDMABIG, [Optional] JobHandle ENADMBLJILB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000662")]
		[Cpp2IlInjected.Address(RVA = "0xBA9810", Offset = "0xBA8010", VA = "0x180BA9810")]
		private global::AFGHFELLGFP<Entity> FOIMKDCMKEM(EntityQuery JIDAALIOAFE)
		{
			return default(global::AFGHFELLGFP<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000663")]
		[Cpp2IlInjected.Address(RVA = "0xBA99C0", Offset = "0xBA81C0", VA = "0x180BA99C0")]
		private (global::DMIPGKGDJEO<Entity>, global::DMIPGKGDJEO<Entity>) LJDPMPAIPKN(global::AFGHFELLGFP<Entity> EPHPEDEHGGN)
		{
			return default((global::DMIPGKGDJEO<Entity>, global::DMIPGKGDJEO<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000664")]
		[Cpp2IlInjected.Address(RVA = "0xBA9650", Offset = "0xBA7E50", VA = "0x180BA9650")]
		private void BBKOKHFLCJO(out NativeArray<Entity> NLBMCCOBHKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000665")]
		[Cpp2IlInjected.Address(RVA = "0xBA96D0", Offset = "0xBA7ED0", VA = "0x180BA96D0")]
		private void FCLGFBPIAPL(NativeList<Entity> NLBMCCOBHKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000666")]
		[Cpp2IlInjected.Address(RVA = "0xBA9750", Offset = "0xBA7F50", VA = "0x180BA9750")]
		private void FCLGFBPIAPL(NativeArray<Entity> NLBMCCOBHKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000667")]
		[Cpp2IlInjected.Address(RVA = "0xBA98A0", Offset = "0xBA80A0", VA = "0x180BA98A0")]
		private void HDMGIMHHANL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000668")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
		private static void MBHDPHDBHOA(int KDGAEMPJEOD, int APFKENEMMNH, int NOOJEOKCPCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000669")]
		[Cpp2IlInjected.Address(RVA = "0xBAA020", Offset = "0xBA8820", VA = "0x180BAA020")]
		private static HFDMILLIKNN NEIMOKMJIJH(NativeArray<Entity> FHMOKNJBCMG, ComponentDataFromEntity<SplinePointData> POBEPLPOFGF)
		{
			return default(HFDMILLIKNN);
		}

		[Cpp2IlInjected.Token(Token = "0x600066A")]
		[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
		public SplineLocalBoundsSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600066C")]
		[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000D7")]
[CEFINOONOIN(typeof(GCCIHKGPIOM), new string[] { })]
public sealed class EGNIMNCCPFH : GCCIHKGPIOM, DKFAOOPHPAH
{
	[Cpp2IlInjected.Token(Token = "0x20000D8")]
	[BurstCompile]
	private struct JEMNELPNIIG : IJobFor
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		[ReadOnly]
		public NativeArray<Entity> NLBMCCOBHKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		[ReadOnly]
		public float3 LOBGMAOEHLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		[ReadOnly]
		public float3 EKAKOFMMEPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		[ReadOnly]
		public ComponentDataFromEntity<ParentData> GEEALFHEHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		[ReadOnly]
		public ComponentDataFromEntity<LocalToWorldData> PGOOGBDPGKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		[ReadOnly]
		public BufferFromEntity<LinkedEntityGroup> LDGLGLJLMNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		[ReadOnly]
		public ComponentDataFromEntity<SplinePointData> POBEPLPOFGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		[WriteOnly]
		public NativeArray<FMKJPGNJLOO> CNHBHHLNDCI;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		private static readonly FMKJPGNJLOO MDOIIHPCOLB;

		[Cpp2IlInjected.Token(Token = "0x6000673")]
		[Cpp2IlInjected.Address(RVA = "0x504C6E0", Offset = "0x504AEE0", VA = "0x18504C6E0", Slot = "4")]
		public void Execute(int AKLHCIJHJKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000674")]
		[Cpp2IlInjected.Address(RVA = "0x504D460", Offset = "0x504BC60", VA = "0x18504D460")]
		private static float3 JDNMLLKDKCB(in float4x4 FGPPNGCBANK, in float3 CKNEEGNOOIB)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000675")]
		[Cpp2IlInjected.Address(RVA = "0x504C410", Offset = "0x504AC10", VA = "0x18504C410")]
		private static float3 EGPBCFNCKPG(in float4x4 FGPPNGCBANK, in float3 PEAOIEMLDCI)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000676")]
		[Cpp2IlInjected.Address(RVA = "0x504C5E0", Offset = "0x504ADE0", VA = "0x18504C5E0")]
		private static float3 EMJNLFIEJFC(in float4x4 FGPPNGCBANK, in float3 CKNEEGNOOIB)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000677")]
		[Cpp2IlInjected.Address(RVA = "0x504D520", Offset = "0x504BD20", VA = "0x18504D520")]
		private static float3 PJCMPHFOFIE(in float4x4 FGPPNGCBANK, in float3 PEAOIEMLDCI)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000678")]
		[Cpp2IlInjected.Address(RVA = "0x504CA10", Offset = "0x504B210", VA = "0x18504CA10")]
		private bool GMFANKFMBMK(in float3 PILBMAKMDBK, in float3 ABCIPBECLHO, in NativeArray<Entity> EBLHMJIKCNJ, out float3 PDHCKJKKNDJ, out float3 MBODGIHCDNC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000679")]
		[Cpp2IlInjected.Address(RVA = "0x504CD60", Offset = "0x504B560", VA = "0x18504CD60")]
		public static bool GPPMMECAEFJ(in float3 GKFMIKJPCHK, in float3 ENEJIAFICPJ, in float3 HLCJABIENFD, in float3 LINKLMOGHCH, float IBMAIDLHLKG, float OLOAPKFCOPE, out float JFBIOCFAFEC, out float3 JEOCPFHIDHG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private EntityManager FNBDEMCEOPA;

	[Cpp2IlInjected.Token(Token = "0x600066F")]
	[Cpp2IlInjected.Address(RVA = "0x5043E10", Offset = "0x5042610", VA = "0x185043E10", Slot = "5")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000670")]
	[Cpp2IlInjected.Address(RVA = "0x5043E80", Offset = "0x5042680", VA = "0x185043E80")]
	public void GDOHKFNFMFO(in NativeArray<Entity> NLBMCCOBHKD, in float3 PILBMAKMDBK, in float3 ABCIPBECLHO, in NativeArray<FMKJPGNJLOO> LFFIDMKGJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000671")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public EGNIMNCCPFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000672")]
	[Cpp2IlInjected.Address(RVA = "0x5043E80", Offset = "0x5042680", VA = "0x185043E80", Slot = "4")]
	private void HJJNFALKGIC(in NativeArray<Entity> NLBMCCOBHKD, in float3 PILBMAKMDBK, in float3 ABCIPBECLHO, in NativeArray<FMKJPGNJLOO> LFFIDMKGJAG)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000D9")]
public struct GNGMMPKMAEI : ISystemStateComponentData, IComponentData
{
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000DA")]
	[DOHCKPDOJMD(PAPAHBCPMGP.Lifecycle)]
	public class DestroyLocalObjects : IHCMLLDKAMA
	{
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private bool NMANPNFCCCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private EntityQuery HHLDBIFENIH;

		[Cpp2IlInjected.Token(Token = "0x600067B")]
		[Cpp2IlInjected.Address(RVA = "0xE52C70", Offset = "0xE51470", VA = "0x180E52C70")]
		public bool KFLOHOHLEGG(Entity NBIJCGHBCCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600067C")]
		[Cpp2IlInjected.Address(RVA = "0xE52D10", Offset = "0xE51510", VA = "0x180E52D10", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067D")]
		[Cpp2IlInjected.Address(RVA = "0xE52D90", Offset = "0xE51590", VA = "0x180E52D90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067E")]
		[Cpp2IlInjected.Address(RVA = "0x6EC4B0", Offset = "0x6EACB0", VA = "0x1806EC4B0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600067F")]
		[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
		public DestroyLocalObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000681")]
		[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DB")]
	[DOHCKPDOJMD(PAPAHBCPMGP.NetworkSend)]
	public abstract class EnqueuePropertyDifferenceToNetwork : IHCMLLDKAMA, DKFAOOPHPAH
	{
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private AGOANOMDLFL ADJMJMEADHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		private FOJPBIGOEBJ NLJLBCPPCEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		private FBFMOHPHODB ADAGNEOMKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		private CJGJCHJLMJE KCDMBPDEAMJ;

		[Cpp2IlInjected.Token(Token = "0x170000C6")]
		protected abstract ComputePropertyDifferences GHLINMDLBCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000682")]
			[Cpp2IlInjected.Address(Slot = "15")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000683")]
		[Cpp2IlInjected.Address(RVA = "0xE53B10", Offset = "0xE52310", VA = "0x180E53B10", Slot = "14")]
		public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000684")]
		[Cpp2IlInjected.Address(RVA = "0xE53BC0", Offset = "0xE523C0", VA = "0x180E53BC0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000685")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
		private void MCECJEJKIBM(Entity NBIJCGHBCCI, MCOCAFPBHKN GFKNINEELBB, NOPBMJOJCGP EPIPKLFKPPF, CJHGPHIODAJ CHLPJEHHFLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000686")]
		[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
		protected EnqueuePropertyDifferenceToNetwork()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000688")]
		[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000DC")]
	[DOHCKPDOJMD(PAPAHBCPMGP.Callbacks)]
	public abstract class PropertyEventCallbacks : IHCMLLDKAMA, DKFAOOPHPAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		private PropertyEventCallbacksService GGIDAKJKFEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private CJGJCHJLMJE KCDMBPDEAMJ;

		[Cpp2IlInjected.Token(Token = "0x6000689")]
		[Cpp2IlInjected.Address(RVA = "0xBA82F0", Offset = "0xBA6AF0", VA = "0x180BA82F0", Slot = "14")]
		public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068A")]
		[Cpp2IlInjected.Address(RVA = "0xBA8370", Offset = "0xBA6B70", VA = "0x180BA8370", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068B")]
		[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
		protected PropertyEventCallbacks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600068C")]
		[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DD")]
public abstract class CLBIMONENOH : IHCMLLDKAMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D1")]
	private List<(EntityQuery, ComponentType)> DJMDBGODMGE;

	[Cpp2IlInjected.Token(Token = "0x600068D")]
	[Cpp2IlInjected.Address(RVA = "0x5040C90", Offset = "0x503F490", VA = "0x185040C90", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068E")]
	[Cpp2IlInjected.Address(RVA = "0x5040E60", Offset = "0x503F660", VA = "0x185040E60", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600068F")]
	[Cpp2IlInjected.Address(RVA = "0x5040FB0", Offset = "0x503F7B0", VA = "0x185040FB0")]
	protected CLBIMONENOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000690")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000DE")]
internal struct HGGHCKFFLLF : ISystemStateComponentData, IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D2")]
	public int PDGADEKDACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002D3")]
	public int JLICIKJPFHO;

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000691")]
	[Cpp2IlInjected.Address(RVA = "0x504AEF0", Offset = "0x50496F0", VA = "0x18504AEF0")]
	public static Entity HLHIMDAEEEO(HGGHCKFFLLF DMDONNOOOJK)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000692")]
	[Cpp2IlInjected.Address(RVA = "0x504AEF0", Offset = "0x50496F0", VA = "0x18504AEF0")]
	public static HGGHCKFFLLF HLHIMDAEEEO(Entity NBIJCGHBCCI)
	{
		return default(HGGHCKFFLLF);
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x20000DF")]
internal struct DDLIJLJOMOK : IComponentData
{
}
[Cpp2IlInjected.Token(Token = "0x20000E0")]
public struct NODNHCIJAFH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D4")]
	public readonly ComponentType AOLKBDPFIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002D5")]
	public readonly NativeList<int> DPDGILOHPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public readonly NativeList<int> OFADIIPIGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	public readonly NativeArray<Entity> NLBMCCOBHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	public readonly NativeArray<Entity> LLEPKMLLJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	public readonly NativeArray<byte> GCAIDMKNBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002DA")]
	public readonly NativeArray<byte> DIFGCKNOINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40002DB")]
	public readonly int JFPDJBEPHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40002DC")]
	public readonly int JGOIPAMBEEP;

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool ADAKKEKAINH
	{
		[Cpp2IlInjected.Token(Token = "0x6000693")]
		[Cpp2IlInjected.Address(RVA = "0x50D48F0", Offset = "0x50D30F0", VA = "0x1850D48F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000694")]
	[Cpp2IlInjected.Address(RVA = "0x50D4A80", Offset = "0x50D3280", VA = "0x1850D4A80")]
	public NODNHCIJAFH(ComponentType AOLKBDPFIGD, NativeList<int> DPDGILOHPLD, NativeList<int> OFADIIPIGHE, NativeArray<Entity> NLBMCCOBHKD, NativeArray<Entity> LLEPKMLLJAF, NativeArray<byte> GCAIDMKNBKO, NativeArray<byte> DIFGCKNOINJ, int JFPDJBEPHHO, int JGOIPAMBEEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000695")]
	[Cpp2IlInjected.Address(RVA = "0x50D4960", Offset = "0x50D3160", VA = "0x1850D4960")]
	private BJHFEKKLKGB ONJAKOMNPAH(NativeArray<byte> FPMNAPBFAMJ, int AKLHCIJHJKB)
	{
		return default(BJHFEKKLKGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000696")]
	private T ONJAKOMNPAH<T>(NativeArray<byte> FPMNAPBFAMJ, int AKLHCIJHJKB) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000697")]
	[Cpp2IlInjected.Address(RVA = "0x50D4770", Offset = "0x50D2F70", VA = "0x1850D4770")]
	public BJHFEKKLKGB BEBGKMHPAGE(int AKLHCIJHJKB)
	{
		return default(BJHFEKKLKGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000698")]
	public T BEBGKMHPAGE<T>(int AKLHCIJHJKB) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000699")]
	[Cpp2IlInjected.Address(RVA = "0x50D47C0", Offset = "0x50D2FC0", VA = "0x1850D47C0")]
	public BJHFEKKLKGB COGNGDAKIOF(int AKLHCIJHJKB)
	{
		return default(BJHFEKKLKGB);
	}

	[Cpp2IlInjected.Token(Token = "0x600069A")]
	public T COGNGDAKIOF<T>(int AKLHCIJHJKB) where T : struct, IComponentData
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600069B")]
	[Cpp2IlInjected.Address(RVA = "0x50D4810", Offset = "0x50D3010", VA = "0x1850D4810", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E1")]
public struct IHCPPGHBGAC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002DD")]
	public readonly EntityQuery JIDAALIOAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002DE")]
	public readonly NativeArray<OHKFBIFLJDM> AFJGLEGGBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002DF")]
	public readonly ComponentType AOLKBDPFIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002E0")]
	public readonly int JFPDJBEPHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40002E1")]
	public readonly int JGOIPAMBEEP;

	[Cpp2IlInjected.Token(Token = "0x600069C")]
	[Cpp2IlInjected.Address(RVA = "0x50C7060", Offset = "0x50C5860", VA = "0x1850C7060")]
	public IHCPPGHBGAC(ComponentType AOLKBDPFIGD, int JFPDJBEPHHO, int JGOIPAMBEEP, EntityQuery JIDAALIOAFE, NativeArray<OHKFBIFLJDM> AFJGLEGGBOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600069D")]
	[Cpp2IlInjected.Address(RVA = "0x50C7010", Offset = "0x50C5810", VA = "0x1850C7010", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E2")]
internal struct IHCJFNOHDLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E2")]
	public int AKLHCIJHJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002E3")]
	public int FLLPNJMNEAH;

	[Cpp2IlInjected.Token(Token = "0x600069E")]
	[Cpp2IlInjected.Address(RVA = "0x76F510", Offset = "0x76DD10", VA = "0x18076F510")]
	public IHCJFNOHDLO(int AKLHCIJHJKB, int FLLPNJMNEAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E3")]
public struct OHKFBIFLJDM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	public readonly int IBIPCEJMDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002E5")]
	public readonly int OCAKIKBDFGC;

	[Cpp2IlInjected.Token(Token = "0x600069F")]
	[Cpp2IlInjected.Address(RVA = "0x76F510", Offset = "0x76DD10", VA = "0x18076F510")]
	public OHKFBIFLJDM(int IBIPCEJMDGF, int OCAKIKBDFGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E4")]
public struct CJHGPHIODAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002E6")]
	private readonly MIPCILJMDGJ OCNCOBFEOBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002E7")]
	private readonly int JFPDJBEPHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002E8")]
	private unsafe readonly byte* GCAIDMKNBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002E9")]
	private unsafe readonly byte* DIFGCKNOINJ;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool CPNLIKCPMHB
	{
		[Cpp2IlInjected.Token(Token = "0x60006A0")]
		[Cpp2IlInjected.Address(RVA = "0x5040AB0", Offset = "0x503F2B0", VA = "0x185040AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public MIPCILJMDGJ ECMPPMHPHOO
	{
		[Cpp2IlInjected.Token(Token = "0x60006A1")]
		[Cpp2IlInjected.Address(RVA = "0x7E9EC0", Offset = "0x7E86C0", VA = "0x1807E9EC0")]
		get
		{
			return default(MIPCILJMDGJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A2")]
	[Cpp2IlInjected.Address(RVA = "0x50408F0", Offset = "0x503F0F0", VA = "0x1850408F0")]
	public BJHFEKKLKGB AIDIACMLMLH(Type BKDBLJPNPPJ)
	{
		return default(BJHFEKKLKGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A3")]
	[Cpp2IlInjected.Address(RVA = "0x50409D0", Offset = "0x503F1D0", VA = "0x1850409D0")]
	public BJHFEKKLKGB DFGGOCAECMB(Type BKDBLJPNPPJ)
	{
		return default(BJHFEKKLKGB);
	}

	[Cpp2IlInjected.Token(Token = "0x60006A4")]
	[Cpp2IlInjected.Address(RVA = "0x1C31BC0", Offset = "0x1C303C0", VA = "0x181C31BC0")]
	public T AIDIACMLMLH<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A5")]
	[Cpp2IlInjected.Address(RVA = "0x1C31BE0", Offset = "0x1C303E0", VA = "0x181C31BE0")]
	public T DFGGOCAECMB<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006A6")]
	[Cpp2IlInjected.Address(RVA = "0x5040AC0", Offset = "0x503F2C0", VA = "0x185040AC0")]
	public unsafe CJHGPHIODAJ(MIPCILJMDGJ OCNCOBFEOBE, int OCAKIKBDFGC, byte* GCAIDMKNBKO, byte* DIFGCKNOINJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E5")]
public static class LINAGEKEPFF
{
	[Cpp2IlInjected.Token(Token = "0x40002EA")]
	public static readonly (ComponentType removeTag, ComponentType componentTag)[] OAIGJHNPPEC;
}
[Cpp2IlInjected.Token(Token = "0x20000E6")]
[DefaultMember("Item")]
internal class JJNBHFNKGAO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002EB")]
	private readonly FLAFLKKHHEA APOHKGBDLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002EC")]
	private readonly Dictionary<ComponentType, IHCPPGHBGAC> ALJFLPJPFPG;

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public IHCPPGHBGAC NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60006A9")]
		[Cpp2IlInjected.Address(RVA = "0x50CA170", Offset = "0x50C8970", VA = "0x1850CA170")]
		get
		{
			return default(IHCPPGHBGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x60006AA")]
		[Cpp2IlInjected.Address(RVA = "0x50CA850", Offset = "0x50C9050", VA = "0x1850CA850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006A8")]
	[Cpp2IlInjected.Address(RVA = "0x50CAB40", Offset = "0x50C9340", VA = "0x1850CAB40")]
	public JJNBHFNKGAO(HFEGCOONMAM JLFJGJMGNNJ, FLAFLKKHHEA APOHKGBDLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AB")]
	[Cpp2IlInjected.Address(RVA = "0x50CA7C0", Offset = "0x50C8FC0", VA = "0x1850CA7C0")]
	public Dictionary<ComponentType, IHCPPGHBGAC>.Enumerator JMGPEBMNFFJ()
	{
		return default(Dictionary<ComponentType, IHCPPGHBGAC>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AC")]
	[Cpp2IlInjected.Address(RVA = "0x50CA1F0", Offset = "0x50C89F0", VA = "0x1850CA1F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AD")]
	[Cpp2IlInjected.Address(RVA = "0x50CA360", Offset = "0x50C8B60", VA = "0x1850CA360")]
	private void GNFJGIOMGKM(IEnumerable<AIGPFJAOAFB> CMFCFPNMOOI, EntityManager FNBDEMCEOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006AE")]
	[Cpp2IlInjected.Address(RVA = "0x50CA710", Offset = "0x50C8F10", VA = "0x1850CA710")]
	private static int JMDFIFGODLC(AIGPFJAOAFB EHFBBJILGFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60006AF")]
	[Cpp2IlInjected.Address(RVA = "0x50CA8A0", Offset = "0x50C90A0", VA = "0x1850CA8A0")]
	private static NativeArray<OHKFBIFLJDM> NOONDMMLAMI(AIGPFJAOAFB EHFBBJILGFE, Allocator DDJPHGFEOFF = Allocator.Persistent)
	{
		return default(NativeArray<OHKFBIFLJDM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000E7")]
internal interface CJGJCHJLMJE
{
	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	World IBAIKALPOCI
	{
		[Cpp2IlInjected.Token(Token = "0x60006B0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60006B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PDKMHAFFMJG(out NativeArray<int> HPBNAFEANFI, Allocator DDJPHGFEOFF);

	[Cpp2IlInjected.Token(Token = "0x60006B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IBGFGOGOLHM(ComponentType AOLKBDPFIGD, out NODNHCIJAFH CGKCAJAKCHF, out IHCPPGHBGAC BDLMKGGHAEG);

	[Cpp2IlInjected.Token(Token = "0x60006B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IBGFGOGOLHM(ComponentType AOLKBDPFIGD, out NODNHCIJAFH CGKCAJAKCHF);

	[Cpp2IlInjected.Token(Token = "0x60006B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	NODNHCIJAFH MCIODHMGPJB(ComponentType AOLKBDPFIGD);

	[Cpp2IlInjected.Token(Token = "0x60006B5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IJGBLJLAPBE IEDOAFOAMOE();

	[Cpp2IlInjected.Token(Token = "0x60006B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EMJLGPMFDGG(JobHandle LHICIKNDDJI);
}
[Cpp2IlInjected.Token(Token = "0x20000E8")]
internal interface AFFLOOGDDMD
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	World IBAIKALPOCI
	{
		[Cpp2IlInjected.Token(Token = "0x60006B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	JJNBHFNKGAO KNCFEDDBCKO
	{
		[Cpp2IlInjected.Token(Token = "0x60006B8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	GEANDGHLBNB CAMELBFHJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60006B9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	NativeMultiHashMap<Entity, CJHGPHIODAJ> JBHBNEBMHKL
	{
		[Cpp2IlInjected.Token(Token = "0x60006BA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	JobHandle BMLHKBCNHOE
	{
		[Cpp2IlInjected.Token(Token = "0x60006BB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60006BC")]
		[Cpp2IlInjected.Address(Slot = "5")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60006BD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NNHCHCFNJFN();

	[Cpp2IlInjected.Token(Token = "0x60006BE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IDPJIGKEBOL();

	[Cpp2IlInjected.Token(Token = "0x60006BF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EAMNKCKFKBF(ComponentType AOLKBDPFIGD, in NODNHCIJAFH FAFHDFJGAFH);

	[Cpp2IlInjected.Token(Token = "0x60006C0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool DFAKNOLIEGJ(HEIIJIHIAKK GPMEIOIEDNN, out Entity IIFCAFGLJID);
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000E9")]
	[CEFINOONOIN(typeof(PropertyDiffStateService), new string[] { })]
	[DOHCKPDOJMD(PAPAHBCPMGP.PropertyChanges)]
	internal class PropertyDiffStateService : DKFAOOPHPAH, GHNBGLLDFLL, AFFLOOGDDMD, CJGJCHJLMJE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private HFEGCOONMAM JLFJGJMGNNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private ObjectPrefabCreationService PCNDCGBMEJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private KCHBCAHHFGL PFKPKGFJONH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private JJNBHFNKGAO ALJFLPJPFPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private GEANDGHLBNB LFLKKLBPPAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private KFJNAAEEIOD HGJPBACEAGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private List<NODNHCIJAFH> BBMHNGNGFCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private NativeMultiHashMap<Entity, CJHGPHIODAJ> APAMNOPNCOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private NativeHashMap<int, int> DMAFLBICDOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private JobHandle HOIPFDIPMIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private JobHandle GDHAOCKKPNP;

		[Cpp2IlInjected.Token(Token = "0x170000D2")]
		public bool ADAKKEKAINH
		{
			[Cpp2IlInjected.Token(Token = "0x60006C1")]
			[Cpp2IlInjected.Address(RVA = "0xBA6960", Offset = "0xBA5160", VA = "0x180BA6960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D3")]
		private World EOABEHHBPBO
		{
			[Cpp2IlInjected.Token(Token = "0x60006C2")]
			[Cpp2IlInjected.Address(RVA = "0xBA6BE0", Offset = "0xBA53E0", VA = "0x180BA6BE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D4")]
		private JJNBHFNKGAO JDDNJAJDELB
		{
			[Cpp2IlInjected.Token(Token = "0x60006C3")]
			[Cpp2IlInjected.Address(RVA = "0x6186A0", Offset = "0x616EA0", VA = "0x1806186A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D5")]
		private GEANDGHLBNB MMMPAPOGGJF
		{
			[Cpp2IlInjected.Token(Token = "0x60006C4")]
			[Cpp2IlInjected.Address(RVA = "0x638B30", Offset = "0x637330", VA = "0x180638B30", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D6")]
		private NativeMultiHashMap<Entity, CJHGPHIODAJ> BGKCNANKEFL
		{
			[Cpp2IlInjected.Token(Token = "0x60006C5")]
			[Cpp2IlInjected.Address(RVA = "0xA54420", Offset = "0xA52C20", VA = "0x180A54420", Slot = "9")]
			get
			{
				return default(NativeMultiHashMap<Entity, CJHGPHIODAJ>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D7")]
		private JobHandle GIODIOBHOOC
		{
			[Cpp2IlInjected.Token(Token = "0x60006C6")]
			[Cpp2IlInjected.Address(RVA = "0xA62090", Offset = "0xA60890", VA = "0x180A62090", Slot = "10")]
			get
			{
				return default(JobHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x60006C7")]
			[Cpp2IlInjected.Address(RVA = "0xBA6C40", Offset = "0xBA5440", VA = "0x180BA6C40", Slot = "11")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000D8")]
		private World FKPBPKPLJDA
		{
			[Cpp2IlInjected.Token(Token = "0x60006CC")]
			[Cpp2IlInjected.Address(RVA = "0xBA6D20", Offset = "0xBA5520", VA = "0x180BA6D20", Slot = "16")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006C8")]
		[Cpp2IlInjected.Address(RVA = "0xBA6730", Offset = "0xBA4F30", VA = "0x180BA6730", Slot = "13")]
		private void HCGCHFFCMNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006C9")]
		[Cpp2IlInjected.Address(RVA = "0xBA6FD0", Offset = "0xBA57D0", VA = "0x180BA6FD0", Slot = "12")]
		private void OMKAKPHLCKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CA")]
		[Cpp2IlInjected.Address(RVA = "0xBA6C50", Offset = "0xBA5450", VA = "0x180BA6C50", Slot = "14")]
		private void LPBPHMLPNPP(ComponentType AOLKBDPFIGD, in NODNHCIJAFH FAFHDFJGAFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006CB")]
		[Cpp2IlInjected.Address(RVA = "0xBA6660", Offset = "0xBA4E60", VA = "0x180BA6660", Slot = "15")]
		private bool EACFGJEGABN(HEIIJIHIAKK GPMEIOIEDNN, out Entity IIFCAFGLJID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CD")]
		[Cpp2IlInjected.Address(RVA = "0xBA6F40", Offset = "0xBA5740", VA = "0x180BA6F40", Slot = "17")]
		private bool OMJLNJDHKAC(out NativeArray<int> HPBNAFEANFI, Allocator DDJPHGFEOFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CE")]
		[Cpp2IlInjected.Address(RVA = "0xBA6970", Offset = "0xBA5170", VA = "0x180BA6970", Slot = "18")]
		private bool IOGHGIDNOIK(ComponentType AOLKBDPFIGD, out NODNHCIJAFH CGKCAJAKCHF, out IHCPPGHBGAC BDLMKGGHAEG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006CF")]
		[Cpp2IlInjected.Address(RVA = "0xBA6AD0", Offset = "0xBA52D0", VA = "0x180BA6AD0", Slot = "19")]
		private bool IOGHGIDNOIK(ComponentType AOLKBDPFIGD, out NODNHCIJAFH CGKCAJAKCHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D0")]
		[Cpp2IlInjected.Address(RVA = "0xBA6470", Offset = "0xBA4C70", VA = "0x180BA6470", Slot = "20")]
		private NODNHCIJAFH DEMEBJOFBOF(ComponentType AOLKBDPFIGD)
		{
			return default(NODNHCIJAFH);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D1")]
		[Cpp2IlInjected.Address(RVA = "0xBA66F0", Offset = "0xBA4EF0", VA = "0x180BA66F0", Slot = "21")]
		private IJGBLJLAPBE FGLBBNDHDJL()
		{
			return default(IJGBLJLAPBE);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D2")]
		[Cpp2IlInjected.Address(RVA = "0xBA6140", Offset = "0xBA4940", VA = "0x180BA6140", Slot = "22")]
		private void AOFHDMJHMGM(JobHandle LHICIKNDDJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D3")]
		[Cpp2IlInjected.Address(RVA = "0xBA6680", Offset = "0xBA4E80", VA = "0x180BA6680", Slot = "4")]
		public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D4")]
		[Cpp2IlInjected.Address(RVA = "0xBA6180", Offset = "0xBA4980", VA = "0x180BA6180", Slot = "5")]
		public void BCKGPNKBBNF(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D5")]
		[Cpp2IlInjected.Address(RVA = "0xBA65A0", Offset = "0xBA4DA0", VA = "0x180BA65A0", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D6")]
		[Cpp2IlInjected.Address(RVA = "0xBA6740", Offset = "0xBA4F40", VA = "0x180BA6740")]
		private void IDPJIGKEBOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006D7")]
		[Cpp2IlInjected.Address(RVA = "0xBA6D80", Offset = "0xBA5580", VA = "0x180BA6D80")]
		private bool NEDPFBMNADA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D8")]
		[Cpp2IlInjected.Address(RVA = "0xBA6320", Offset = "0xBA4B20", VA = "0x180BA6320")]
		private int CEKEOJAEJLG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60006D9")]
		[Cpp2IlInjected.Address(RVA = "0xBA70D0", Offset = "0xBA58D0", VA = "0x180BA70D0")]
		public PropertyDiffStateService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EA")]
internal struct IJGBLJLAPBE
{
	[Cpp2IlInjected.Token(Token = "0x20000EB")]
	public struct BMFDCBPCHBH : IEnumerator<CJHGPHIODAJ>, IEnumerator, IDisposable, IEnumerable<CJHGPHIODAJ>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private readonly NativeMultiHashMap<Entity, CJHGPHIODAJ> OMEFEABFKAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private readonly Entity NBIJCGHBCCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private NativeMultiHashMapIterator<Entity> PBCJHFHKDLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private CJHGPHIODAJ DIFGCKNOINJ;

		[Cpp2IlInjected.Token(Token = "0x170000DB")]
		public CJHGPHIODAJ HLHDNNKPFLO
		{
			[Cpp2IlInjected.Token(Token = "0x60006E5")]
			[Cpp2IlInjected.Address(RVA = "0xECF500", Offset = "0xECDD00", VA = "0x180ECF500", Slot = "4")]
			get
			{
				return default(CJHGPHIODAJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000DC")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60006E6")]
			[Cpp2IlInjected.Address(RVA = "0x50C4A20", Offset = "0x50C3220", VA = "0x1850C4A20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60006E1")]
		[Cpp2IlInjected.Address(RVA = "0x50C4A70", Offset = "0x50C3270", VA = "0x1850C4A70")]
		internal BMFDCBPCHBH(NativeMultiHashMap<Entity, CJHGPHIODAJ> OMEFEABFKAE, Entity NBIJCGHBCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E2")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E3")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006E4")]
		[Cpp2IlInjected.Address(RVA = "0x50C4800", Offset = "0x50C3000", VA = "0x1850C4800", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E7")]
		[Cpp2IlInjected.Address(RVA = "0x50C47D0", Offset = "0x50C2FD0", VA = "0x1850C47D0")]
		public BMFDCBPCHBH JMGPEBMNFFJ()
		{
			return default(BMFDCBPCHBH);
		}

		[Cpp2IlInjected.Token(Token = "0x60006E8")]
		[Cpp2IlInjected.Address(RVA = "0x50C48C0", Offset = "0x50C30C0", VA = "0x1850C48C0", Slot = "9")]
		private IEnumerator<CJHGPHIODAJ> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.Systems.PropertyChangeData>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60006E9")]
		[Cpp2IlInjected.Address(RVA = "0x50C4970", Offset = "0x50C3170", VA = "0x1850C4970", Slot = "10")]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002F9")]
	private readonly AFFLOOGDDMD KCDMBPDEAMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002FA")]
	private readonly JobHandle KLFCOAFMJBD;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public int FIACODAPHDI
	{
		[Cpp2IlInjected.Token(Token = "0x60006DC")]
		[Cpp2IlInjected.Address(RVA = "0x50C73F0", Offset = "0x50C5BF0", VA = "0x1850C73F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public bool JCLGOONBLNF
	{
		[Cpp2IlInjected.Token(Token = "0x60006DD")]
		[Cpp2IlInjected.Address(RVA = "0x50C75F0", Offset = "0x50C5DF0", VA = "0x1850C75F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006DB")]
	[Cpp2IlInjected.Address(RVA = "0xCFBD50", Offset = "0xCFA550", VA = "0x180CFBD50")]
	public IJGBLJLAPBE(AFFLOOGDDMD KCDMBPDEAMJ, JobHandle KLFCOAFMJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006DE")]
	[Cpp2IlInjected.Address(RVA = "0x50C7160", Offset = "0x50C5960", VA = "0x1850C7160")]
	public bool BAFEBMFMBOL(Allocator DDJPHGFEOFF, out NativeKeyValueArrays<Entity, CJHGPHIODAJ> FNPLEFBJGJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006DF")]
	[Cpp2IlInjected.Address(RVA = "0x50C72A0", Offset = "0x50C5AA0", VA = "0x1850C72A0")]
	public bool BBGOFBKPJNL(Allocator DDJPHGFEOFF, out (NativeArray<Entity> entities, int uniqueCount) FNPLEFBJGJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006E0")]
	[Cpp2IlInjected.Address(RVA = "0x50C74E0", Offset = "0x50C5CE0", VA = "0x1850C74E0")]
	public BMFDCBPCHBH KFJBCIJNHNG(Entity NBIJCGHBCCI)
	{
		return default(BMFDCBPCHBH);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000EC")]
[DefaultMember("Item")]
internal class GEANDGHLBNB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002FF")]
	private readonly FLAFLKKHHEA APOHKGBDLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000300")]
	private readonly List<IHCPPGHBGAC> BAKFHBILFME;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public IHCPPGHBGAC NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x60006EB")]
		[Cpp2IlInjected.Address(RVA = "0x5046950", Offset = "0x5045150", VA = "0x185046950")]
		get
		{
			return default(IHCPPGHBGAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x60006EC")]
		[Cpp2IlInjected.Address(RVA = "0x5046EE0", Offset = "0x50456E0", VA = "0x185046EE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60006EA")]
	[Cpp2IlInjected.Address(RVA = "0x5046F20", Offset = "0x5045720", VA = "0x185046F20")]
	public GEANDGHLBNB(JJNBHFNKGAO ALJFLPJPFPG, HFEGCOONMAM JLFJGJMGNNJ, FLAFLKKHHEA APOHKGBDLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006ED")]
	[Cpp2IlInjected.Address(RVA = "0x5046E60", Offset = "0x5045660", VA = "0x185046E60")]
	public List<IHCPPGHBGAC>.Enumerator JMGPEBMNFFJ()
	{
		return default(List<IHCPPGHBGAC>.Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60006EE")]
	[Cpp2IlInjected.Address(RVA = "0x50469E0", Offset = "0x50451E0", VA = "0x1850469E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006EF")]
	[Cpp2IlInjected.Address(RVA = "0x5046B60", Offset = "0x5045360", VA = "0x185046B60")]
	private void GNFJGIOMGKM(JJNBHFNKGAO ALJFLPJPFPG, EntityManager FNBDEMCEOPA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000ED")]
internal class KFJNAAEEIOD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000301")]
	private readonly FLAFLKKHHEA APOHKGBDLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000302")]
	private readonly ObjectPrefabCreationService PCNDCGBMEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000303")]
	private readonly global::NDHHJFCALDI<AIGPFJAOAFB> GJNPFLDOAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000304")]
	private readonly World MAKCDEHPICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000305")]
	private readonly EntityManager FNBDEMCEOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000306")]
	private NativeHashMap<int, Entity> HGJPBACEAGM;

	[Cpp2IlInjected.Token(Token = "0x60006F0")]
	[Cpp2IlInjected.Address(RVA = "0x50CE400", Offset = "0x50CCC00", VA = "0x1850CE400")]
	public KFJNAAEEIOD(ObjectPrefabCreationService PCNDCGBMEJH, HFEGCOONMAM JLFJGJMGNNJ, FLAFLKKHHEA APOHKGBDLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F1")]
	[Cpp2IlInjected.Address(RVA = "0x50CD5D0", Offset = "0x50CBDD0", VA = "0x1850CD5D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F2")]
	[Cpp2IlInjected.Address(RVA = "0x50CDCF0", Offset = "0x50CC4F0", VA = "0x1850CDCF0")]
	public bool LOIKEFHMCKD(HEIIJIHIAKK GPMEIOIEDNN, out Entity IIFCAFGLJID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F3")]
	[Cpp2IlInjected.Address(RVA = "0x50CDD50", Offset = "0x50CC550", VA = "0x1850CDD50")]
	private void OBNBFGHKDGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F4")]
	[Cpp2IlInjected.Address(RVA = "0x50CCDD0", Offset = "0x50CB5D0", VA = "0x1850CCDD0")]
	private EntityArchetype AFPKCNOBGJM(EntityArchetype BGAMLCPNOLK)
	{
		return default(EntityArchetype);
	}

	[Cpp2IlInjected.Token(Token = "0x60006F5")]
	[Cpp2IlInjected.Address(RVA = "0x50CD810", Offset = "0x50CC010", VA = "0x1850CD810")]
	public static void ECFLCKDDKLF(EntityManager GIMHPNFOOOP, EntityManager JKPLEMDGMMJ, NativeArray<Entity> NIELJKPEJGM, NativeArray<EntityArchetype> IECKEABJMFD, [Optional] NativeArray<Entity> LKOJEHLFEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F6")]
	[Cpp2IlInjected.Address(RVA = "0x50CD2D0", Offset = "0x50CBAD0", VA = "0x1850CD2D0")]
	[Conditional("DEBUG_BUILD")]
	private static void CJIAJJIANFE(NativeArray<EntityArchetype> NBDHPEDKEIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F7")]
	[Cpp2IlInjected.Address(RVA = "0x50CD630", Offset = "0x50CBE30", VA = "0x1850CD630")]
	private static string EADEMHAIMKE(EntityArchetype EOKDKGJACDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60006F8")]
	[Cpp2IlInjected.Address(RVA = "0x50CDBB0", Offset = "0x50CC3B0", VA = "0x1850CDBB0")]
	[CompilerGenerated]
	internal static void ENJAHNNCDBD(ref Span<ComponentType> OHFIOKPIBHK, ComponentType CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006F9")]
	[Cpp2IlInjected.Address(RVA = "0x50CD430", Offset = "0x50CBC30", VA = "0x1850CD430")]
	[CompilerGenerated]
	internal static void CNHJONFNEHI(Span<ComponentType> FPMNAPBFAMJ, ref Span<ComponentType> OHFIOKPIBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60006FA")]
	[Cpp2IlInjected.Address(RVA = "0x50CE330", Offset = "0x50CCB30", VA = "0x1850CE330")]
	[CompilerGenerated]
	internal static void PCLFIAJFLCE(Span<ComponentType> FPMNAPBFAMJ, ref Span<ComponentType> OHFIOKPIBHK, ComponentType EMFAHBBJOKL)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x20000EE")]
	[DOHCKPDOJMD(PAPAHBCPMGP.PropertyChanges)]
	public abstract class ApplyPropertyDifferences : IHCMLLDKAMA, DKFAOOPHPAH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x20000EF")]
		[CompilerGenerated]
		private struct DGFLDEAEIKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			public NativeArray<byte> current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400030B")]
			public NativeList<int> indices;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			public NativeArray<Entity> shadowEntities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400030D")]
			public int typeSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400030E")]
			public LPIICFOCJAH dstComponentData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400030F")]
			public ComponentType componentType;

			[Cpp2IlInjected.Token(Token = "0x6000703")]
			[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
			public DGFLDEAEIKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000704")]
			[Cpp2IlInjected.Address(RVA = "0xB9AE70", Offset = "0xB99670", VA = "0x180B9AE70")]
			internal void <TryApplyChangesToComponents>b__0()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F0")]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		[BurstCompile]
		private struct KNMLONOLOIP : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000310")]
			[ReadOnly]
			public NativeArray<byte> DIFGCKNOINJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000311")]
			[ReadOnly]
			public NativeList<int> DPDGILOHPLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000312")]
			[ReadOnly]
			public NativeArray<Entity> LLEPKMLLJAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000313")]
			public int JFPDJBEPHHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000314")]
			public LPIICFOCJAH DEPPAJFGMCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000315")]
			public ComponentType AOLKBDPFIGD;

			[Cpp2IlInjected.Token(Token = "0x6000705")]
			[Cpp2IlInjected.Address(RVA = "0xE56C80", Offset = "0xE55480", VA = "0x180E56C80")]
			internal void KFAKMCGDEPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000706")]
			[Cpp2IlInjected.Address(RVA = "0xE56E40", Offset = "0xE55640", VA = "0x180E56E40", Slot = "5")]
			public void ReadFromDisplayClass(ref DGFLDEAEIKM AMPNHBNMCND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000707")]
			[Cpp2IlInjected.Address(RVA = "0xE56C70", Offset = "0xE55470", VA = "0x180E56C70", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000708")]
			[Cpp2IlInjected.Address(RVA = "0xE56E20", Offset = "0xE55620", VA = "0x180E56E20")]
			public void LNGFEFINAKH(ApplyPropertyDifferences JNPNDBIIELC, ref DGFLDEAEIKM AMPNHBNMCND)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private CJGJCHJLMJE KCDMBPDEAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private JobHandle HOIPFDIPMIH;

		[Cpp2IlInjected.Token(Token = "0x60006FB")]
		[Cpp2IlInjected.Address(RVA = "0xE4B610", Offset = "0xE49E10", VA = "0x180E4B610")]
		public void DOLHECDOMGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FC")]
		[Cpp2IlInjected.Address(RVA = "0xE4B620", Offset = "0xE49E20", VA = "0x180E4B620", Slot = "14")]
		public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FD")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FE")]
		[Cpp2IlInjected.Address(RVA = "0xE4B9A0", Offset = "0xE4A1A0", VA = "0x180E4B9A0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60006FF")]
		[Cpp2IlInjected.Address(RVA = "0xE4B680", Offset = "0xE49E80", VA = "0x180E4B680")]
		private bool KPABBLCLAAE(JobHandle ENADMBLJILB, int JCCEMLFDLOM, out JobHandle KGFINCEOBGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000700")]
		[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
		protected ApplyPropertyDifferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000702")]
		[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000F1")]
	[DOHCKPDOJMD(PAPAHBCPMGP.PropertyChanges)]
	public abstract class ComputePropertyDifferences : IHCMLLDKAMA, DKFAOOPHPAH, GHNBGLLDFLL
	{
		[Cpp2IlInjected.Token(Token = "0x20000F2")]
		[BurstCompile]
		internal struct GPFJBDPOAPO : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			[ReadOnly]
			public NativeArray<byte> IKEKJHPMJDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			[ReadOnly]
			public NativeArray<byte> MAAHEBCGCIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			[ReadOnly]
			public NativeArray<OHKFBIFLJDM> ECHCFPCIPDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			[WriteOnly]
			public NativeList<IHCJFNOHDLO>.ParallelWriter KAIBCHLLADK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public int JJGBJBPMLNA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public int AAJCCMNCMPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			public ProfilerMarker LDKBNKMEHLP;

			[Cpp2IlInjected.Token(Token = "0x6000726")]
			[Cpp2IlInjected.Address(RVA = "0xE556D0", Offset = "0xE53ED0", VA = "0x180E556D0", Slot = "4")]
			public void Execute(ArchetypeChunk ENPKJHPNEAL, int CLJFBMDOKCI, int LHMFKCGLDPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000727")]
			[Cpp2IlInjected.Address(RVA = "0xE55640", Offset = "0xE53E40", VA = "0x180E55640")]
			private unsafe int DGKGHFJCBNM(byte* CIDNOFHJGLN, byte* CFCFGDKOLFC)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F3")]
		[BurstCompile]
		internal struct DMAPAAFNAFO : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			[WriteOnly]
			public NativeList<int> DPDGILOHPLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			[WriteOnly]
			public NativeList<int> KBDBOEOLHPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			[ReadOnly]
			public NativeList<IHCJFNOHDLO> CAKAHEPGGJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public ProfilerMarker LDKBNKMEHLP;

			[Cpp2IlInjected.Token(Token = "0x6000728")]
			[Cpp2IlInjected.Address(RVA = "0xE52BB0", Offset = "0xE513B0", VA = "0x180E52BB0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F4")]
		[BurstCompile]
		internal struct BJAHMJKNDGH : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			[WriteOnly]
			public NativeArray<byte> HIFAJNHLCJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			[ReadOnly]
			public NativeArray<Entity> NLBMCCOBHKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			[ReadOnly]
			public LPIICFOCJAH DOKMEEKGJKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public int JFPDJBEPHHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public ProfilerMarker LDKBNKMEHLP;

			[Cpp2IlInjected.Token(Token = "0x6000729")]
			[Cpp2IlInjected.Address(RVA = "0xE4BD90", Offset = "0xE4A590", VA = "0x180E4BD90", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000F5")]
		[BurstCompile]
		internal struct IFOLMOMBDEA : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			[WriteOnly]
			public NativeMultiHashMap<Entity, CJHGPHIODAJ> EKPCCBILEBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			[ReadOnly]
			public NativeArray<byte> GCAIDMKNBKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			[ReadOnly]
			public NativeArray<byte> DIFGCKNOINJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			[ReadOnly]
			public NativeArray<Entity> NLBMCCOBHKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			[ReadOnly]
			public NativeArray<OHKFBIFLJDM> LHBJFBBLGAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			[ReadOnly]
			public NativeList<int> OFADIIPIGHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			[ReadOnly]
			public NativeList<int> DPDGILOHPLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			public int GNHFLPGFMAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			public int JGOIPAMBEEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			public ProfilerMarker LDKBNKMEHLP;

			[Cpp2IlInjected.Token(Token = "0x600072A")]
			[Cpp2IlInjected.Address(RVA = "0xE559D0", Offset = "0xE541D0", VA = "0x180E559D0", Slot = "4")]
			public void Execute()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		private static readonly ProfilerMarker DEMJGNCNFNG;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		private static readonly ProfilerMarker BPKKCEIGAAO;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		private static readonly ProfilerMarker FGANBCEJIOK;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private static readonly ProfilerMarker PFHNHECMBIH;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		private static readonly ProfilerMarker PCPDFAFONPI;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		private static readonly ProfilerMarker EBJFADAOPOF;

		[Cpp2IlInjected.Token(Token = "0x400031D")]
		private static readonly ProfilerMarker POPIGDKOOIA;

		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private static readonly ProfilerMarker KLBDDGAIBFF;

		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private static readonly ProfilerMarker PNGIPNHNJAE;

		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private static readonly ProfilerMarker KPFDIOABNFN;

		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private static readonly ProfilerMarker JMMKECOCAFL;

		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private static readonly ProfilerMarker PGPLKILBMEI;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private static readonly ProfilerMarker COBEBBAGOJL;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private static readonly ProfilerMarker AOLLMCOJNBC;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private static readonly ProfilerMarker FDPCFNKDDNK;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		private static readonly ProfilerMarker PMJJAEPBPMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		private AFFLOOGDDMD KCDMBPDEAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		private ApplyPropertyDifferences JCANGCKKNNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		private EntityQuery JPIPIEFGCAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private EntityQuery EBKFMHFPBFD;

		[Cpp2IlInjected.Token(Token = "0x170000DF")]
		protected abstract ApplyPropertyDifferences IHODHJNFOIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000709")]
			[Cpp2IlInjected.Address(Slot = "16")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x170000E0")]
		internal World IBAIKALPOCI
		{
			[Cpp2IlInjected.Token(Token = "0x600070A")]
			[Cpp2IlInjected.Address(RVA = "0xE4E7F0", Offset = "0xE4CFF0", VA = "0x180E4E7F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600070B")]
		[Cpp2IlInjected.Address(RVA = "0xE4C790", Offset = "0xE4AF90", VA = "0x180E4C790")]
		internal IHCPPGHBGAC BODFOBEHGIC(ComponentType AOLKBDPFIGD)
		{
			return default(IHCPPGHBGAC);
		}

		[Cpp2IlInjected.Token(Token = "0x600070C")]
		[Cpp2IlInjected.Address(RVA = "0xE4CEC0", Offset = "0xE4B6C0", VA = "0x180E4CEC0", Slot = "14")]
		public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070D")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "15")]
		public void BCKGPNKBBNF(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070E")]
		[Cpp2IlInjected.Address(RVA = "0xE4F160", Offset = "0xE4D960", VA = "0x180E4F160", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600070F")]
		[Cpp2IlInjected.Address(RVA = "0xE4F2B0", Offset = "0xE4DAB0", VA = "0x180E4F2B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000710")]
		[Cpp2IlInjected.Address(RVA = "0xE4F260", Offset = "0xE4DA60", VA = "0x180E4F260", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000711")]
		[Cpp2IlInjected.Address(RVA = "0xE4EEB0", Offset = "0xE4D6B0", VA = "0x180E4EEB0")]
		private void ONIMNLNIMLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000712")]
		[Cpp2IlInjected.Address(RVA = "0xE4D4D0", Offset = "0xE4BCD0", VA = "0x180E4D4D0")]
		private void GOPDDEIFNGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000713")]
		[Cpp2IlInjected.Address(RVA = "0xE4E8C0", Offset = "0xE4D0C0", VA = "0x180E4E8C0")]
		internal void OGJKIOLPEGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000714")]
		[Cpp2IlInjected.Address(RVA = "0xE4E130", Offset = "0xE4C930", VA = "0x180E4E130")]
		private void JLFEOPKICIO(NativeArray<Entity> NIELJKPEJGM, NativeArray<RRObjectPrefabData> AKNAHJGMKOM, ref NativeArray<Entity> FKLKGFJNMCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000715")]
		[Cpp2IlInjected.Address(RVA = "0xE4E340", Offset = "0xE4CB40", VA = "0x180E4E340")]
		internal void LDBENDAJJEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000716")]
		[Cpp2IlInjected.Address(RVA = "0xE4C830", Offset = "0xE4B030", VA = "0x180E4C830")]
		internal void DNGKABJECDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000717")]
		[Cpp2IlInjected.Address(RVA = "0xE4D5C0", Offset = "0xE4BDC0", VA = "0x180E4D5C0")]
		private void HJFIKEPJBBL(IHCPPGHBGAC BDLMKGGHAEG, bool PKBNFDFGBIC, ref JobHandle NEHLHLCBCEL, ref JobHandle HHMBENKDFNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000718")]
		[Cpp2IlInjected.Address(RVA = "0xE4D8B0", Offset = "0xE4C0B0", VA = "0x180E4D8B0")]
		internal bool JFIBPEONNJI(in IHCPPGHBGAC CFCFGDKOLFC, out JobHandle LPPHLKEKIOC, out NODNHCIJAFH OHACPICCGCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000719")]
		[Cpp2IlInjected.Address(RVA = "0xE4D8E0", Offset = "0xE4C0E0", VA = "0x180E4D8E0")]
		private bool JFIBPEONNJI(in IHCPPGHBGAC CFCFGDKOLFC, bool PKBNFDFGBIC, out JobHandle LPPHLKEKIOC, out NODNHCIJAFH OHACPICCGCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600071A")]
		[Cpp2IlInjected.Address(RVA = "0xE4CF20", Offset = "0xE4B720", VA = "0x180E4CF20")]
		internal (NativeList<int>, NativeList<int>) FIOIHMMKDAK(NativeList<IHCJFNOHDLO> CAKAHEPGGJH, int JPMPKCEDKPJ, JobHandle ENADMBLJILB, out JobHandle LHICIKNDDJI, Allocator DDJPHGFEOFF = Allocator.TempJob)
		{
			return default((NativeList<int>, NativeList<int>));
		}

		[Cpp2IlInjected.Token(Token = "0x600071B")]
		[Cpp2IlInjected.Address(RVA = "0xE4F3D0", Offset = "0xE4DBD0", VA = "0x180E4F3D0")]
		internal static NativeArray<Entity> PBHDCGLKMLO(EntityQuery JIDAALIOAFE, out JobHandle LLMHCMDBNEO)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071C")]
		[Cpp2IlInjected.Address(RVA = "0xE4E840", Offset = "0xE4D040", VA = "0x180E4E840")]
		internal static NativeArray<byte> NDDJLOKOFFC(int FCDIIMLAMIO, out JobHandle EDBMBPJHMJE)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071D")]
		[Cpp2IlInjected.Address(RVA = "0xE4D0C0", Offset = "0xE4B8C0", VA = "0x180E4D0C0")]
		internal static NativeArray<byte> FKKHOLGPANA(EntityQuery JIDAALIOAFE, int JCCEMLFDLOM, out JobHandle EDBMBPJHMJE)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071E")]
		[Cpp2IlInjected.Address(RVA = "0xE4D210", Offset = "0xE4BA10", VA = "0x180E4D210")]
		internal static NativeArray<Entity> FOIMKDCMKEM(EntityQuery JIDAALIOAFE, out JobHandle GPHABCNGMHF)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x600071F")]
		[Cpp2IlInjected.Address(RVA = "0xE4E600", Offset = "0xE4CE00", VA = "0x180E4E600")]
		internal NativeArray<byte> LJOJPJGCBFL(NativeArray<Entity> NLBMCCOBHKD, IHCPPGHBGAC BDLMKGGHAEG, JobHandle ENADMBLJILB, out JobHandle LHICIKNDDJI, Allocator DDJPHGFEOFF = Allocator.TempJob)
		{
			return default(NativeArray<byte>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000720")]
		[Cpp2IlInjected.Address(RVA = "0xE4D340", Offset = "0xE4BB40", VA = "0x180E4D340")]
		internal JobHandle GKCFOJLKHGH(in NODNHCIJAFH DMDONNOOOJK, in IHCPPGHBGAC BDLMKGGHAEG, NativeMultiHashMap<Entity, CJHGPHIODAJ> EKPCCBILEBD, JobHandle ENADMBLJILB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000721")]
		[Cpp2IlInjected.Address(RVA = "0xD21250", Offset = "0xD1FA50", VA = "0x180D21250")]
		private JobHandle AOABODBHEBC(JobHandle PLADMNDHILB, JobHandle PINGMKOKCAI)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000722")]
		[Cpp2IlInjected.Address(RVA = "0xD21250", Offset = "0xD1FA50", VA = "0x180D21250")]
		private JobHandle AOABODBHEBC(JobHandle PLADMNDHILB, JobHandle PINGMKOKCAI, JobHandle FAOMNFAOLGB)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000723")]
		[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
		protected ComputePropertyDifferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000725")]
		[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F6")]
internal abstract class IPKNIMGIGJN : PropagateTagsBase<global::JHFPNALOHNP, global::GMPLACMMIPD, IPKNIMGIGJN.LHBPPFEAPPA>
{
	[Cpp2IlInjected.Token(Token = "0x20000F7")]
	public struct LHBPPFEAPPA : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072B")]
	[Cpp2IlInjected.Address(RVA = "0x50C65E0", Offset = "0x50C4DE0", VA = "0x1850C65E0")]
	protected IPKNIMGIGJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072C")]
	[Cpp2IlInjected.Address(RVA = "0x50C65A0", Offset = "0x50C4DA0", VA = "0x1850C65A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000F8")]
internal abstract class FBKIAOKPHAA : PropagateTagsBase<KALPBAFHKJD, global::BHHCALEGPCA, FBKIAOKPHAA.ANKMNPIBBPL>
{
	[Cpp2IlInjected.Token(Token = "0x20000F9")]
	public struct ANKMNPIBBPL : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072D")]
	[Cpp2IlInjected.Address(RVA = "0x50447F0", Offset = "0x5042FF0", VA = "0x1850447F0")]
	protected FBKIAOKPHAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600072E")]
	[Cpp2IlInjected.Address(RVA = "0x50447B0", Offset = "0x5042FB0", VA = "0x1850447B0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FA")]
public class JCOCLLKLLMI : JHFMKABDHHH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x20000FB")]
	[CompilerGenerated]
	private struct FHKHFHKOLFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		public NativeArray<int> array;

		[Cpp2IlInjected.Token(Token = "0x6000733")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
		public FHKHFHKOLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000734")]
		[Cpp2IlInjected.Address(RVA = "0xB9AE70", Offset = "0xB99670", VA = "0x180B9AE70")]
		internal void <OnUpdate>b__0(ref AuthoredLocalPoseData localPose)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x20000FC")]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	private struct FANGOFKMDDC : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x20000FD")]
		private struct FFJPNMBJJHP
		{
			[Cpp2IlInjected.Token(Token = "0x20000FE")]
			[NoAlias]
			public struct BBCOEPAKMLG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400034E")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<AuthoredLocalPoseData>.Runtime BAMNHMDHGFK;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<AuthoredLocalPoseData> AOCHAKCCANJ;

			[Cpp2IlInjected.Token(Token = "0x600073C")]
			[Cpp2IlInjected.Address(RVA = "0x50C5CC0", Offset = "0x50C44C0", VA = "0x1850C5CC0")]
			public void LNGFEFINAKH(JCOCLLKLLMI JNPNDBIIELC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600073D")]
			[Cpp2IlInjected.Address(RVA = "0x50C5C70", Offset = "0x50C4470", VA = "0x1850C5C70")]
			public BBCOEPAKMLG FJADKACAIMI(ref ArchetypeChunk KGKNEONCAKP, int JKMLLEJBOIE, int CEJIHAPILEF)
			{
				return default(BBCOEPAKMLG);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		public NativeArray<int> FPMNAPBFAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		private FFJPNMBJJHP ICGPFDNJJFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe FFJPNMBJJHP.BBCOEPAKMLG* DACPFDLDMPF;

		[Cpp2IlInjected.Token(Token = "0x400034B")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate INAKAPMMIIH;

		[Cpp2IlInjected.Token(Token = "0x400034C")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HECMCGDDKLN;

		[Cpp2IlInjected.Token(Token = "0x6000735")]
		[Cpp2IlInjected.Address(RVA = "0x50C5A00", Offset = "0x50C4200", VA = "0x1850C5A00")]
		internal void KFAKMCGDEPE(ref AuthoredLocalPoseData OBMNJCKECKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000736")]
		[Cpp2IlInjected.Address(RVA = "0xB9AE60", Offset = "0xB99660", VA = "0x180B9AE60", Slot = "5")]
		public void ReadFromDisplayClass(ref FHKHFHKOLFL AMPNHBNMCND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000737")]
		[Cpp2IlInjected.Address(RVA = "0x16D7070", Offset = "0x16D5870", VA = "0x1816D7070", Slot = "6")]
		public void WriteToDisplayClass(ref FHKHFHKOLFL AMPNHBNMCND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000738")]
		[Cpp2IlInjected.Address(RVA = "0x50C5980", Offset = "0x50C4180", VA = "0x1850C5980", Slot = "4")]
		public void Execute(ArchetypeChunk ENPKJHPNEAL, int CLJFBMDOKCI, int LHMFKCGLDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000739")]
		[Cpp2IlInjected.Address(RVA = "0x50C5B80", Offset = "0x50C4380", VA = "0x1850C5B80")]
		public void NLDAPEGBEMO(ref ArchetypeChunk ENPKJHPNEAL, [NoAlias] ref FFJPNMBJJHP.BBCOEPAKMLG GJDLAKGIODP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073A")]
		[Cpp2IlInjected.Address(RVA = "0x50C5B00", Offset = "0x50C4300", VA = "0x1850C5B00")]
		public void LNGFEFINAKH(JCOCLLKLLMI JNPNDBIIELC, ref FHKHFHKOLFL AMPNHBNMCND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600073B")]
		[Cpp2IlInjected.Address(RVA = "0x50C5C10", Offset = "0x50C4410", VA = "0x1850C5C10")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void NNJMFIJBDKK(ArchetypeChunkIterator* PBAMKHEMGLK, void* OFPFIAGIKFE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000345")]
	private EntityQuery LHIEJNPPGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000346")]
	private ProfilerMarker MKDLBBJBAEC;

	[Cpp2IlInjected.Token(Token = "0x600072F")]
	[Cpp2IlInjected.Address(RVA = "0x50C8200", Offset = "0x50C6A00", VA = "0x1850C8200", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000730")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
	public JCOCLLKLLMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000731")]
	[Cpp2IlInjected.Address(RVA = "0x50C8020", Offset = "0x50C6820", VA = "0x1850C8020", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000732")]
	[Cpp2IlInjected.Address(RVA = "0x50C7EF0", Offset = "0x50C66F0", VA = "0x1850C7EF0")]
	public static EntityQuery ADBEPIOOALB(ComponentSystemBase JNPNDBIIELC)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000FF")]
public class BNAKEADJMLL : JHFMKABDHHH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000100")]
	[CompilerGenerated]
	private struct NLMKHIEFMJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		public NativeList<Entity> orphans;

		[Cpp2IlInjected.Token(Token = "0x6000742")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
		public NLMKHIEFMJM()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000101")]
	[CompilerGenerated]
	private struct FHMGNEGAAPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		public EntityManager entityManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		public NLMKHIEFMJM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000743")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
		public FHMGNEGAAPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000744")]
		[Cpp2IlInjected.Address(RVA = "0xB9AE70", Offset = "0xB99670", VA = "0x180B9AE70")]
		internal void <OnUpdate>b__0(Entity entity, SplinePointData point)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000102")]
	[Unity.Entities.DOTSCompilerGenerated]
	[NoAlias]
	[BurstCompile]
	private struct INMCBBHLGDA : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000103")]
		private struct PAEDMECHHGM
		{
			[Cpp2IlInjected.Token(Token = "0x2000104")]
			[NoAlias]
			public struct BKEPIKGKKDL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400035C")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime JHKKGOELPEG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400035D")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<SplinePointData>.Runtime DFBEJMFFPFO;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity LBGHHAFFEOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			[NoAlias]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<SplinePointData> GDABEDCPGND;

			[Cpp2IlInjected.Token(Token = "0x600074C")]
			[Cpp2IlInjected.Address(RVA = "0x504E0E0", Offset = "0x504C8E0", VA = "0x18504E0E0")]
			public void LNGFEFINAKH(BNAKEADJMLL JNPNDBIIELC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600074D")]
			[Cpp2IlInjected.Address(RVA = "0x504E060", Offset = "0x504C860", VA = "0x18504E060")]
			public BKEPIKGKKDL FJADKACAIMI(ref ArchetypeChunk KGKNEONCAKP, int JKMLLEJBOIE, int CEJIHAPILEF)
			{
				return default(BKEPIKGKKDL);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		public EntityManager FNBDEMCEOPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		public NativeList<Entity> ENFKFDBLIIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private PAEDMECHHGM ICGPFDNJJFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe PAEDMECHHGM.BKEPIKGKKDL* DACPFDLDMPF;

		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate INAKAPMMIIH;

		[Cpp2IlInjected.Token(Token = "0x4000359")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HECMCGDDKLN;

		[Cpp2IlInjected.Token(Token = "0x6000745")]
		[Cpp2IlInjected.Address(RVA = "0x504C1B0", Offset = "0x504A9B0", VA = "0x18504C1B0")]
		internal void KFAKMCGDEPE(Entity NBIJCGHBCCI, SplinePointData DLEJHBBJLMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000746")]
		[Cpp2IlInjected.Address(RVA = "0x504C3F0", Offset = "0x504ABF0", VA = "0x18504C3F0", Slot = "5")]
		public void ReadFromDisplayClass(ref FHMGNEGAAPP AMPNHBNMCND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000747")]
		[Cpp2IlInjected.Address(RVA = "0x504C400", Offset = "0x504AC00", VA = "0x18504C400", Slot = "6")]
		public void WriteToDisplayClass(ref FHMGNEGAAPP AMPNHBNMCND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000748")]
		[Cpp2IlInjected.Address(RVA = "0x504C110", Offset = "0x504A910", VA = "0x18504C110", Slot = "4")]
		public void Execute(ArchetypeChunk ENPKJHPNEAL, int CLJFBMDOKCI, int LHMFKCGLDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000749")]
		[Cpp2IlInjected.Address(RVA = "0x504C2C0", Offset = "0x504AAC0", VA = "0x18504C2C0")]
		public void NLDAPEGBEMO(ref ArchetypeChunk ENPKJHPNEAL, [NoAlias] ref PAEDMECHHGM.BKEPIKGKKDL GJDLAKGIODP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074A")]
		[Cpp2IlInjected.Address(RVA = "0x504C230", Offset = "0x504AA30", VA = "0x18504C230")]
		public void LNGFEFINAKH(BNAKEADJMLL JNPNDBIIELC, ref FHMGNEGAAPP AMPNHBNMCND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600074B")]
		[Cpp2IlInjected.Address(RVA = "0x504C390", Offset = "0x504AB90", VA = "0x18504C390")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void NNJMFIJBDKK(ArchetypeChunkIterator* PBAMKHEMGLK, void* OFPFIAGIKFE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400034F")]
	private EntityQuery LHIEJNPPGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000350")]
	private ProfilerMarker MKDLBBJBAEC;

	[Cpp2IlInjected.Token(Token = "0x600073E")]
	[Cpp2IlInjected.Address(RVA = "0x503E560", Offset = "0x503CD60", VA = "0x18503E560", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600073F")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
	public BNAKEADJMLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000740")]
	[Cpp2IlInjected.Address(RVA = "0x503E380", Offset = "0x503CB80", VA = "0x18503E380", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000741")]
	[Cpp2IlInjected.Address(RVA = "0x503E250", Offset = "0x503CA50", VA = "0x18503E250")]
	public static EntityQuery ADBEPIOOALB(ComponentSystemBase JNPNDBIIELC)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000105")]
public class JAHIEHLLCEF : JHFMKABDHHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035E")]
	private EntityQuery HNDDPAAJHGO;

	[Cpp2IlInjected.Token(Token = "0x600074E")]
	[Cpp2IlInjected.Address(RVA = "0x50C7BC0", Offset = "0x50C63C0", VA = "0x1850C7BC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600074F")]
	[Cpp2IlInjected.Address(RVA = "0x50C7C40", Offset = "0x50C6440", VA = "0x1850C7C40", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000750")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
	public JAHIEHLLCEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000751")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000106")]
public class OLIGJJCEAEM : JHFMKABDHHH, DKFAOOPHPAH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000107")]
	[CompilerGenerated]
	private struct DCBFOFBGFJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		public NativeHashMap<MCOCAFPBHKN, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x6000757")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
		public DCBFOFBGFJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000758")]
		[Cpp2IlInjected.Address(RVA = "0xB9AE70", Offset = "0xB99670", VA = "0x180B9AE70")]
		internal void <OnUpdate>b__0(Entity entity, ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000108")]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct OCGPCDJFFHO : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000109")]
		private struct NEIIIPILNBK
		{
			[Cpp2IlInjected.Token(Token = "0x200010A")]
			public struct ODOPBABAMMP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000369")]
				public LambdaParameterValueProvider_Entity.Runtime JHKKGOELPEG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400036A")]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime ICOKPCEKCNB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			[ReadOnly]
			private LambdaParameterValueProvider_Entity LBGHHAFFEOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			[ReadOnly]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> NDAIAFFKPCE;

			[Cpp2IlInjected.Token(Token = "0x6000760")]
			[Cpp2IlInjected.Address(RVA = "0x50D3F60", Offset = "0x50D2760", VA = "0x1850D3F60")]
			public void LNGFEFINAKH(OLIGJJCEAEM JNPNDBIIELC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000761")]
			[Cpp2IlInjected.Address(RVA = "0x50D3EE0", Offset = "0x50D26E0", VA = "0x1850D3EE0")]
			public ODOPBABAMMP FJADKACAIMI(ref ArchetypeChunk KGKNEONCAKP, int JKMLLEJBOIE, int CEJIHAPILEF)
			{
				return default(ODOPBABAMMP);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		public NativeHashMap<MCOCAFPBHKN, Entity> OMEFEABFKAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		private NEIIIPILNBK ICGPFDNJJFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe NEIIIPILNBK.ODOPBABAMMP* DACPFDLDMPF;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate INAKAPMMIIH;

		[Cpp2IlInjected.Token(Token = "0x6000759")]
		[Cpp2IlInjected.Address(RVA = "0x50D4CD0", Offset = "0x50D34D0", VA = "0x1850D4CD0")]
		internal void KFAKMCGDEPE(Entity NBIJCGHBCCI, ObjectNetworkIdComponentData JIPPBJOBMBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075A")]
		[Cpp2IlInjected.Address(RVA = "0xB9AE60", Offset = "0xB99660", VA = "0x180B9AE60", Slot = "5")]
		public void ReadFromDisplayClass(ref DCBFOFBGFJG AMPNHBNMCND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075B")]
		[Cpp2IlInjected.Address(RVA = "0x16D7070", Offset = "0x16D5870", VA = "0x1816D7070", Slot = "6")]
		public void WriteToDisplayClass(ref DCBFOFBGFJG AMPNHBNMCND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075C")]
		[Cpp2IlInjected.Address(RVA = "0x50D4C30", Offset = "0x50D3430", VA = "0x1850D4C30", Slot = "4")]
		public void Execute(ArchetypeChunk ENPKJHPNEAL, int CLJFBMDOKCI, int LHMFKCGLDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075D")]
		[Cpp2IlInjected.Address(RVA = "0x50D4DE0", Offset = "0x50D35E0", VA = "0x1850D4DE0")]
		public void NLDAPEGBEMO(ref ArchetypeChunk ENPKJHPNEAL, ref NEIIIPILNBK.ODOPBABAMMP GJDLAKGIODP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075E")]
		[Cpp2IlInjected.Address(RVA = "0x50D4D50", Offset = "0x50D3550", VA = "0x1850D4D50")]
		public void LNGFEFINAKH(OLIGJJCEAEM JNPNDBIIELC, ref DCBFOFBGFJG AMPNHBNMCND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600075F")]
		[Cpp2IlInjected.Address(RVA = "0x50D4E90", Offset = "0x50D3690", VA = "0x1850D4E90")]
		public unsafe static void NNJMFIJBDKK(ArchetypeChunkIterator* PBAMKHEMGLK, void* OFPFIAGIKFE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400035F")]
	private ObjectNetworkToLocalMapService FFAFHLPEJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000360")]
	private EntityQuery LHIEJNPPGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000361")]
	private ProfilerMarker MKDLBBJBAEC;

	[Cpp2IlInjected.Token(Token = "0x6000752")]
	[Cpp2IlInjected.Address(RVA = "0x50D5F10", Offset = "0x50D4710", VA = "0x1850D5F10", Slot = "14")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000753")]
	[Cpp2IlInjected.Address(RVA = "0x50D6120", Offset = "0x50D4920", VA = "0x1850D6120", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000754")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
	public OLIGJJCEAEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000755")]
	[Cpp2IlInjected.Address(RVA = "0x50D5F70", Offset = "0x50D4770", VA = "0x1850D5F70", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000756")]
	[Cpp2IlInjected.Address(RVA = "0x50D5DE0", Offset = "0x50D45E0", VA = "0x1850D5DE0")]
	public static EntityQuery ADBEPIOOALB(ComponentSystemBase JNPNDBIIELC)
	{
		return default(EntityQuery);
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200010B")]
	[DOHCKPDOJMD(PAPAHBCPMGP.Embodiment)]
	public class PostLoadInitializeEmbodiment : IHCMLLDKAMA, DKFAOOPHPAH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200010C")]
		[CompilerGenerated]
		private struct MJOPNLPDMMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			public NativeList<Entity> entities;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public NativeList<MCOCAFPBHKN> networkIds;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			public BufferFromEntity<ChildrenData> childrenFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public ComponentDataFromEntity<SerializedEmbodiedData> embodiedFromEntity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public ComponentDataFromEntity<ObjectNetworkIdComponentData> networkIdFromEntity;

			[Cpp2IlInjected.Token(Token = "0x600076E")]
			[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
			public MJOPNLPDMMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600076F")]
			[Cpp2IlInjected.Address(RVA = "0xB9AE70", Offset = "0xB99670", VA = "0x180B9AE70")]
			internal void <AddEmbodiedTopologically>b__0(Entity entity, ObjectNetworkIdComponentData component)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200010D")]
		[Unity.Entities.DOTSCompilerGenerated]
		[BurstCompile]
		[NoAlias]
		private struct NMBHNILEJLD : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200010E")]
			private struct JNGEHOPHHJA
			{
				[Cpp2IlInjected.Token(Token = "0x200010F")]
				[NoAlias]
				public struct HPDOGFPJODH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x4000382")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime JHKKGOELPEG;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x4000383")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime IPPONFHANJA;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000380")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_Entity LBGHHAFFEOM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000381")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> CEKNINJHPFA;

				[Cpp2IlInjected.Token(Token = "0x600077B")]
				[Cpp2IlInjected.Address(RVA = "0xB9C5E0", Offset = "0xB9ADE0", VA = "0x180B9C5E0")]
				public void LNGFEFINAKH(PostLoadInitializeEmbodiment JNPNDBIIELC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600077C")]
				[Cpp2IlInjected.Address(RVA = "0xB9C560", Offset = "0xB9AD60", VA = "0x180B9C560")]
				public HPDOGFPJODH FJADKACAIMI(ref ArchetypeChunk KGKNEONCAKP, int JKMLLEJBOIE, int CEJIHAPILEF)
				{
					return default(HPDOGFPJODH);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public NativeList<Entity> NLBMCCOBHKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			public NativeList<MCOCAFPBHKN> FLNEPJJFNHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			public BufferFromEntity<ChildrenData> JCIJFEPNPHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public ComponentDataFromEntity<SerializedEmbodiedData> AGHJOPJFJHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			public ComponentDataFromEntity<ObjectNetworkIdComponentData> LGHGDPOOLBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			private JNGEHOPHHJA ICGPFDNJJFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe JNGEHOPHHJA.HPDOGFPJODH* DACPFDLDMPF;

			[Cpp2IlInjected.Token(Token = "0x400037E")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate INAKAPMMIIH;

			[Cpp2IlInjected.Token(Token = "0x400037F")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HECMCGDDKLN;

			[Cpp2IlInjected.Token(Token = "0x6000772")]
			[Cpp2IlInjected.Address(RVA = "0xB9D200", Offset = "0xB9BA00", VA = "0x180B9D200")]
			internal void KFAKMCGDEPE(Entity NBIJCGHBCCI, ObjectNetworkIdComponentData CFCFGDKOLFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000773")]
			[Cpp2IlInjected.Address(RVA = "0xB9D2C0", Offset = "0xB9BAC0", VA = "0x180B9D2C0")]
			internal void NEIKOCDHHHG(Entity NBIJCGHBCCI, ObjectNetworkIdComponentData CFCFGDKOLFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000774")]
			[Cpp2IlInjected.Address(RVA = "0xB9D020", Offset = "0xB9B820", VA = "0x180B9D020")]
			internal void AKFJBJDEOAG(Entity NBIJCGHBCCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000775")]
			[Cpp2IlInjected.Address(RVA = "0xB9D450", Offset = "0xB9BC50", VA = "0x180B9D450", Slot = "5")]
			public void ReadFromDisplayClass(ref MJOPNLPDMMH AMPNHBNMCND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000776")]
			[Cpp2IlInjected.Address(RVA = "0xB9D4A0", Offset = "0xB9BCA0", VA = "0x180B9D4A0", Slot = "6")]
			public void WriteToDisplayClass(ref MJOPNLPDMMH AMPNHBNMCND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000777")]
			[Cpp2IlInjected.Address(RVA = "0xB9D150", Offset = "0xB9B950", VA = "0x180B9D150", Slot = "4")]
			public void Execute(ArchetypeChunk ENPKJHPNEAL, int CLJFBMDOKCI, int LHMFKCGLDPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000778")]
			[Cpp2IlInjected.Address(RVA = "0xB9D340", Offset = "0xB9BB40", VA = "0x180B9D340")]
			public void NLDAPEGBEMO(ref ArchetypeChunk ENPKJHPNEAL, [NoAlias] ref JNGEHOPHHJA.HPDOGFPJODH GJDLAKGIODP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000779")]
			[Cpp2IlInjected.Address(RVA = "0xB9D230", Offset = "0xB9BA30", VA = "0x180B9D230")]
			public void LNGFEFINAKH(PostLoadInitializeEmbodiment JNPNDBIIELC, ref MJOPNLPDMMH AMPNHBNMCND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600077A")]
			[Cpp2IlInjected.Address(RVA = "0xB9D3F0", Offset = "0xB9BBF0", VA = "0x180B9D3F0")]
			[BurstCompile]
			[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
			public unsafe static void NNJMFIJBDKK(ArchetypeChunkIterator* PBAMKHEMGLK, void* OFPFIAGIKFE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400036B")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		private EntityQuery MCMKECKDMMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400036D")]
		private ENJAHHPPGPN AGONKCODOEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400036E")]
		private FOJPBIGOEBJ NLJLBCPPCEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400036F")]
		private HIPDIEDHHMJ CJCNOIMAAPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000370")]
		private EntityQuery NFBFHGKHPLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000371")]
		private ProfilerMarker HNPIBBFCDGG;

		[Cpp2IlInjected.Token(Token = "0x6000762")]
		[Cpp2IlInjected.Address(RVA = "0xBA5380", Offset = "0xBA3B80", VA = "0x180BA5380", Slot = "14")]
		public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000763")]
		[Cpp2IlInjected.Address(RVA = "0xBA5D30", Offset = "0xBA4530", VA = "0x180BA5D30", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000764")]
		[Cpp2IlInjected.Address(RVA = "0xBA5DB0", Offset = "0xBA45B0", VA = "0x180BA5DB0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000765")]
		[Cpp2IlInjected.Address(RVA = "0xBA5410", Offset = "0xBA3C10", VA = "0x180BA5410")]
		private void IKDBELLHCEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000766")]
		[Cpp2IlInjected.Address(RVA = "0xBA56F0", Offset = "0xBA3EF0", VA = "0x180BA56F0")]
		private NativeArray<AADKKGNCIPP> JLPMAMDPPGO(NativeArray<MCOCAFPBHKN> FLNEPJJFNHA)
		{
			return default(NativeArray<AADKKGNCIPP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000767")]
		[Cpp2IlInjected.Address(RVA = "0xBA51A0", Offset = "0xBA39A0", VA = "0x180BA51A0")]
		private void CCFGPANPDLD(NativeList<Entity> NLBMCCOBHKD, NativeList<MCOCAFPBHKN> FLNEPJJFNHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000768")]
		[Cpp2IlInjected.Address(RVA = "0xBA5020", Offset = "0xBA3820", VA = "0x180BA5020")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private static void BGHCDEFPJPL(NativeList<MCOCAFPBHKN> FLNEPJJFNHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000769")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
		private static void EHPAJLLHJCF(NativeList<MCOCAFPBHKN> FLNEPJJFNHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076A")]
		[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
		public PostLoadInitializeEmbodiment()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076C")]
		[Cpp2IlInjected.Address(RVA = "0xBA5C30", Offset = "0xBA4430", VA = "0x180BA5C30", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600076D")]
		[Cpp2IlInjected.Address(RVA = "0xBA5A70", Offset = "0xBA4270", VA = "0x180BA5A70")]
		public static EntityQuery MIKOFHNBJOL(ComponentSystemBase JNPNDBIIELC)
		{
			return default(EntityQuery);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000110")]
public class AIOGDKEINIP : IHCMLLDKAMA, DKFAOOPHPAH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000111")]
	[CompilerGenerated]
	private struct LJIJDOBOBIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		public NativeHashMap<MCOCAFPBHKN, Entity> map;

		[Cpp2IlInjected.Token(Token = "0x6000782")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
		public LJIJDOBOBIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000783")]
		[Cpp2IlInjected.Address(RVA = "0xB9AE70", Offset = "0xB99670", VA = "0x180B9AE70")]
		internal void <OnUpdate>b__0(Entity entity, int entityInQueryIndex, ref ObjectNetworkIdComponentData networkComponent)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000112")]
	[NoAlias]
	[BurstCompile]
	[Unity.Entities.DOTSCompilerGenerated]
	private struct HBKGEDDLOIH : IJobChunk
	{
		[Cpp2IlInjected.Token(Token = "0x2000113")]
		private struct PGBMONGGPBL
		{
			[Cpp2IlInjected.Token(Token = "0x2000114")]
			[NoAlias]
			public struct LCLAOOELJKC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000390")]
				[NoAlias]
				public LambdaParameterValueProvider_Entity.Runtime JHKKGOELPEG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000391")]
				[NoAlias]
				public LambdaParameterValueProvider_EntityInQueryIndex.Runtime JIMJOBKIBNP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000392")]
				[NoAlias]
				public LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData>.Runtime ICOKPCEKCNB;
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_Entity LBGHHAFFEOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			[ReadOnly]
			[NoAlias]
			private LambdaParameterValueProvider_EntityInQueryIndex DCPDCEPMHJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			[NoAlias]
			private LambdaParameterValueProvider_IComponentData<ObjectNetworkIdComponentData> NDAIAFFKPCE;

			[Cpp2IlInjected.Token(Token = "0x600078B")]
			[Cpp2IlInjected.Address(RVA = "0x504E470", Offset = "0x504CC70", VA = "0x18504E470")]
			public void LNGFEFINAKH(AIOGDKEINIP JNPNDBIIELC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600078C")]
			[Cpp2IlInjected.Address(RVA = "0x504E3B0", Offset = "0x504CBB0", VA = "0x18504E3B0")]
			public LCLAOOELJKC FJADKACAIMI(ref ArchetypeChunk KGKNEONCAKP, int JKMLLEJBOIE, int CEJIHAPILEF)
			{
				return default(LCLAOOELJKC);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		public NativeHashMap<MCOCAFPBHKN, Entity> OMEFEABFKAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private PGBMONGGPBL ICGPFDNJJFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe PGBMONGGPBL.LCLAOOELJKC* DACPFDLDMPF;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate INAKAPMMIIH;

		[Cpp2IlInjected.Token(Token = "0x400038C")]
		private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate HECMCGDDKLN;

		[Cpp2IlInjected.Token(Token = "0x6000784")]
		[Cpp2IlInjected.Address(RVA = "0x504A970", Offset = "0x5049170", VA = "0x18504A970")]
		internal void KFAKMCGDEPE(Entity NBIJCGHBCCI, int FBNGHGCIHOC, ref ObjectNetworkIdComponentData JIPPBJOBMBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000785")]
		[Cpp2IlInjected.Address(RVA = "0xB9AE60", Offset = "0xB99660", VA = "0x180B9AE60", Slot = "5")]
		public void ReadFromDisplayClass(ref LJIJDOBOBIO AMPNHBNMCND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000786")]
		[Cpp2IlInjected.Address(RVA = "0x16D7070", Offset = "0x16D5870", VA = "0x1816D7070", Slot = "6")]
		public void WriteToDisplayClass(ref LJIJDOBOBIO AMPNHBNMCND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000787")]
		[Cpp2IlInjected.Address(RVA = "0x504A880", Offset = "0x5049080", VA = "0x18504A880", Slot = "4")]
		public void Execute(ArchetypeChunk ENPKJHPNEAL, int CLJFBMDOKCI, int LHMFKCGLDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000788")]
		[Cpp2IlInjected.Address(RVA = "0x504AAA0", Offset = "0x50492A0", VA = "0x18504AAA0")]
		public void NLDAPEGBEMO(ref ArchetypeChunk ENPKJHPNEAL, [NoAlias] ref PGBMONGGPBL.LCLAOOELJKC GJDLAKGIODP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000789")]
		[Cpp2IlInjected.Address(RVA = "0x504AA00", Offset = "0x5049200", VA = "0x18504AA00")]
		public void LNGFEFINAKH(AIOGDKEINIP JNPNDBIIELC, ref LJIJDOBOBIO AMPNHBNMCND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600078A")]
		[Cpp2IlInjected.Address(RVA = "0x504AB60", Offset = "0x5049360", VA = "0x18504AB60")]
		[BurstCompile]
		[Unity.Entities.MonoPInvokeCallback(typeof(InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate))]
		public unsafe static void NNJMFIJBDKK(ArchetypeChunkIterator* PBAMKHEMGLK, void* OFPFIAGIKFE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000384")]
	private ObjectNetworkToLocalMapService FFAFHLPEJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000385")]
	private EntityQuery LHIEJNPPGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000386")]
	private ProfilerMarker MKDLBBJBAEC;

	[Cpp2IlInjected.Token(Token = "0x600077D")]
	[Cpp2IlInjected.Address(RVA = "0x503B910", Offset = "0x503A110", VA = "0x18503B910", Slot = "14")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077E")]
	[Cpp2IlInjected.Address(RVA = "0x503BB50", Offset = "0x503A350", VA = "0x18503BB50", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600077F")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
	public AIOGDKEINIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000780")]
	[Cpp2IlInjected.Address(RVA = "0x503B970", Offset = "0x503A170", VA = "0x18503B970", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000781")]
	[Cpp2IlInjected.Address(RVA = "0x503B7E0", Offset = "0x5039FE0", VA = "0x18503B7E0")]
	public static EntityQuery ADBEPIOOALB(ComponentSystemBase JNPNDBIIELC)
	{
		return default(EntityQuery);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000115")]
public class GCGMBNHNDAP : IHCMLLDKAMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000393")]
	private EntityQuery MCMKECKDMMC;

	[Cpp2IlInjected.Token(Token = "0x600078D")]
	[Cpp2IlInjected.Address(RVA = "0x50467E0", Offset = "0x5044FE0", VA = "0x1850467E0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078E")]
	[Cpp2IlInjected.Address(RVA = "0x5046860", Offset = "0x5045060", VA = "0x185046860", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600078F")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
	public GCGMBNHNDAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000790")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000116")]
public class CCHEFKNBGNG : IHCMLLDKAMA, DKFAOOPHPAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000394")]
	private HFEGCOONMAM LMKNNIPOPLE;

	[Cpp2IlInjected.Token(Token = "0x6000791")]
	[Cpp2IlInjected.Address(RVA = "0x503FC70", Offset = "0x503E470", VA = "0x18503FC70", Slot = "14")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000792")]
	[Cpp2IlInjected.Address(RVA = "0x50401D0", Offset = "0x503E9D0", VA = "0x1850401D0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000793")]
	[Cpp2IlInjected.Address(RVA = "0x503F960", Offset = "0x503E160", VA = "0x18503F960")]
	private void AHMKICEAABC(NativeList<EntityArchetype> NBDHPEDKEIO, NativeHashMap<int, OKGJCEGJEIG> CFDLMOPDACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000794")]
	[Cpp2IlInjected.Address(RVA = "0x503FCD0", Offset = "0x503E4D0", VA = "0x18503FCD0")]
	private void OAFKBBOJNOO(NativeHashMap<int, OKGJCEGJEIG> CFDLMOPDACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000795")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
	public CCHEFKNBGNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000796")]
	[Cpp2IlInjected.Address(RVA = "0x503FB30", Offset = "0x503E330", VA = "0x18503FB30")]
	[CompilerGenerated]
	internal static Span<int> DBKLMIAGOEK(EntityArchetype EOKDKGJACDA)
	{
		return default(Span<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000797")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000117")]
	[DOHCKPDOJMD(PAPAHBCPMGP.Serialization)]
	public class PreSerializeRemoveEntities : IHCMLLDKAMA
	{
		[Cpp2IlInjected.Token(Token = "0x4000395")]
		private static FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000396")]
		private EntityQuery EBKFMHFPBFD;

		[Cpp2IlInjected.Token(Token = "0x6000798")]
		[Cpp2IlInjected.Address(RVA = "0xBA5E90", Offset = "0xBA4690", VA = "0x180BA5E90", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000799")]
		[Cpp2IlInjected.Address(RVA = "0xBA60B0", Offset = "0xBA48B0", VA = "0x180BA60B0", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079A")]
		[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
		public PreSerializeRemoveEntities()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600079C")]
		[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000118")]
[MIDOOGOCAPK]
[ExecuteAlways]
[UpdateInGroup(typeof(IMHFNPPBDHO))]
internal sealed class FPAGDOGOJLI : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x600079D")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public FPAGDOGOJLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600079E")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000119")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(IMHFNPPBDHO))]
[UpdateAfter(typeof(FPAGDOGOJLI))]
internal sealed class DMBLAJDPHED : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x600079F")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public DMBLAJDPHED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A0")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011A")]
[ExecuteAlways]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(CGOHPMBPFBG))]
internal sealed class CKDKBFJIDCJ : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007A1")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public CKDKBFJIDCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A2")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011B")]
[MIDOOGOCAPK]
[ExecuteAlways]
[UpdateInGroup(typeof(NKFPBPHMDPM))]
internal sealed class PLFMELHDMJG : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007A3")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public PLFMELHDMJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A4")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011C")]
[ExecuteAlways]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(GNOGOBLAPME))]
internal sealed class DGAKNMOKBFE : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007A5")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public DGAKNMOKBFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A6")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011D")]
[ExecuteAlways]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(AGEGHLJDDBK))]
internal sealed class AHMJPDBHLFN : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007A7")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public AHMJPDBHLFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007A8")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011E")]
[ExecuteAlways]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(SimulationSystemGroup))]
internal sealed class PGHDFNMAFOE : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007A9")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public PGHDFNMAFOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AA")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200011F")]
[ExecuteAlways]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(CBGOJNFOINJ))]
internal sealed class CNIKOLEFIHN : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007AB")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public CNIKOLEFIHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AC")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000120")]
[ExecuteAlways]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(SimulationSystemGroup))]
internal sealed class IJLMMAGOELK : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60007AD")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public IJLMMAGOELK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007AE")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000121")]
	[DOHCKPDOJMD(PAPAHBCPMGP.TransformSyncing, new string[] { "Pose", "Uniform", "Deformable" })]
	public class CopyTransformDataFromGameObjects : IHCMLLDKAMA
	{
		[Cpp2IlInjected.Token(Token = "0x2000122")]
		[BurstCompile]
		private struct JJOGAIGDINM : IJobParallelForTransform
		{
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			private const float EOHBEDGFDLN = 1E-05f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			[ReadOnly]
			public NativeArray<Entity> NLBMCCOBHKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalPoseData> DGIOJNHJPHG;

			[Cpp2IlInjected.Token(Token = "0x60007B6")]
			[Cpp2IlInjected.Address(RVA = "0xE56700", Offset = "0xE54F00", VA = "0x180E56700", Slot = "4")]
			public void Execute(int AKLHCIJHJKB, TransformAccess EOBPGPELLLJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007B7")]
			[Cpp2IlInjected.Address(RVA = "0xE568F0", Offset = "0xE550F0", VA = "0x180E568F0")]
			private bool FMIOLMBGCNM(float3 CMJHENLPPFE, float3 JCEACLPGDMD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B8")]
			[Cpp2IlInjected.Address(RVA = "0xE569A0", Offset = "0xE551A0", VA = "0x180E569A0")]
			private bool JPCEOBFLOND(quaternion CMJHENLPPFE, quaternion JCEACLPGDMD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007B9")]
			[Cpp2IlInjected.Address(RVA = "0xE56440", Offset = "0xE54C40", VA = "0x180E56440")]
			private static bool BJIJHGKDOLJ(float3 DKLHMFCLOAB, float3 FLEBMPFFCAA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BA")]
			[Cpp2IlInjected.Address(RVA = "0xE566C0", Offset = "0xE54EC0", VA = "0x180E566C0")]
			private static bool BJIJHGKDOLJ(quaternion MEHHMGBDHKJ, quaternion MLOFKBADEJB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BB")]
			[Cpp2IlInjected.Address(RVA = "0xE56990", Offset = "0xE55190", VA = "0x180E56990")]
			private static bool IJIJGGJFAPE(float HEMMIMHKMIC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007BC")]
			[Cpp2IlInjected.Address(RVA = "0xE56940", Offset = "0xE55140", VA = "0x180E56940")]
			private static float IABNMNDNBMI(quaternion NEKNKIFBNAE, quaternion PCKOKBIMNEB)
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000123")]
		[BurstCompile]
		private struct ALPBCMDJGFE : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			[ReadOnly]
			public NativeArray<Entity> NLBMCCOBHKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalUniformScaleData> OFIENMMOIFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			[NativeDisableParallelForRestriction]
			public ComponentDataFromEntity<LocalDeformableScaleData> GKBJEENOHDL;

			[Cpp2IlInjected.Token(Token = "0x60007BD")]
			[Cpp2IlInjected.Address(RVA = "0xE4A600", Offset = "0xE48E00", VA = "0x180E4A600", Slot = "4")]
			public void Execute(int AKLHCIJHJKB, TransformAccess EOBPGPELLLJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000397")]
		private const string BOCKHBGGKGK = "Pose";

		[Cpp2IlInjected.Token(Token = "0x4000398")]
		private const string GKDPDCLHGGK = "Uniform";

		[Cpp2IlInjected.Token(Token = "0x4000399")]
		private const string KBNEADODBMP = "Deformable";

		[Cpp2IlInjected.Token(Token = "0x400039A")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.Token(Token = "0x400039B")]
		private static readonly ProfilerMarker IHPICPBAFOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400039C")]
		private RegisterTransforms HODGNPNBMCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400039D")]
		private TransformAccessArray NPKHAHPKPAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400039E")]
		private HFEGCOONMAM JLFJGJMGNNJ;

		[Cpp2IlInjected.Token(Token = "0x60007AF")]
		[Cpp2IlInjected.Address(RVA = "0xE51610", Offset = "0xE4FE10", VA = "0x180E51610")]
		public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B0")]
		[Cpp2IlInjected.Address(RVA = "0xE51670", Offset = "0xE4FE70", VA = "0x180E51670", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B1")]
		[Cpp2IlInjected.Address(RVA = "0xE516E0", Offset = "0xE4FEE0", VA = "0x180E516E0", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B2")]
		[Cpp2IlInjected.Address(RVA = "0xE51750", Offset = "0xE4FF50", VA = "0x180E51750", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B3")]
		[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
		public CopyTransformDataFromGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007B5")]
		[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000124")]
	[DOHCKPDOJMD(PAPAHBCPMGP.TransformSyncing)]
	public class RegisterTransforms : IHCMLLDKAMA
	{
		[Cpp2IlInjected.Token(Token = "0x2000126")]
		[Unity.Entities.DOTSCompilerGenerated]
		private struct ILFFNGHBJOH : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x2000127")]
			private struct PDOBKHBKFKH
			{
				[Cpp2IlInjected.Token(Token = "0x2000128")]
				public struct PJMDLELKJGK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40003B7")]
					public LambdaParameterValueProvider_Entity.Runtime JHKKGOELPEG;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40003B8")]
					public LambdaParameterValueProvider_IComponentData<KEMLKLJPNBO>.Runtime HCKBLCHIFMP;

					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x40003B9")]
					public LambdaParameterValueProvider_ManagedComponentData<Transform>.Runtime PDBPJIOCEMN;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003B4")]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity LBGHHAFFEOM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40003B5")]
				[ReadOnly]
				private LambdaParameterValueProvider_IComponentData<KEMLKLJPNBO> NPEPNPCKPBI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40003B6")]
				private LambdaParameterValueProvider_ManagedComponentData<Transform> ADJPDOPPGCJ;

				[Cpp2IlInjected.Token(Token = "0x60007D6")]
				[Cpp2IlInjected.Address(RVA = "0xBA3900", Offset = "0xBA2100", VA = "0x180BA3900")]
				public void LNGFEFINAKH(RegisterTransforms JNPNDBIIELC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007D7")]
				[Cpp2IlInjected.Address(RVA = "0xBA3810", Offset = "0xBA2010", VA = "0x180BA3810")]
				public PJMDLELKJGK FJADKACAIMI(ref ArchetypeChunk KGKNEONCAKP, int JKMLLEJBOIE, int CEJIHAPILEF)
				{
					return default(PJMDLELKJGK);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			private PDOBKHBKFKH ICGPFDNJJFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe PDOBKHBKFKH.PJMDLELKJGK* DACPFDLDMPF;

			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			private static InternalCompilerInterface.JobChunkRunWithoutJobSystemDelegate INAKAPMMIIH;

			[Cpp2IlInjected.Token(Token = "0x60007D1")]
			[Cpp2IlInjected.Address(RVA = "0xB9BDA0", Offset = "0xB9A5A0", VA = "0x180B9BDA0")]
			internal void KFAKMCGDEPE(Entity NBIJCGHBCCI, KEMLKLJPNBO DDFINIJOFGB, Transform EOBPGPELLLJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D2")]
			[Cpp2IlInjected.Address(RVA = "0xB9BD10", Offset = "0xB9A510", VA = "0x180B9BD10", Slot = "4")]
			public void Execute(ArchetypeChunk ENPKJHPNEAL, int CLJFBMDOKCI, int LHMFKCGLDPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D3")]
			[Cpp2IlInjected.Address(RVA = "0xB9BE90", Offset = "0xB9A690", VA = "0x180B9BE90")]
			public void NLDAPEGBEMO(ref ArchetypeChunk ENPKJHPNEAL, ref PDOBKHBKFKH.PJMDLELKJGK GJDLAKGIODP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D4")]
			[Cpp2IlInjected.Address(RVA = "0xB9BE80", Offset = "0xB9A680", VA = "0x180B9BE80")]
			public void LNGFEFINAKH(RegisterTransforms JNPNDBIIELC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D5")]
			[Cpp2IlInjected.Address(RVA = "0xB9BF60", Offset = "0xB9A760", VA = "0x180B9BF60")]
			public unsafe static void NNJMFIJBDKK(ArchetypeChunkIterator* PBAMKHEMGLK, void* OFPFIAGIKFE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000129")]
		[BurstCompile]
		[Unity.Entities.DOTSCompilerGenerated]
		[NoAlias]
		private struct HLCIHIBFIFD : IJobChunk
		{
			[Cpp2IlInjected.Token(Token = "0x200012A")]
			private struct LLDJAIOLCMF
			{
				[Cpp2IlInjected.Token(Token = "0x200012B")]
				[NoAlias]
				public struct ALGLCAOGDIC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
					[Cpp2IlInjected.Token(Token = "0x40003BE")]
					[NoAlias]
					public LambdaParameterValueProvider_Entity.Runtime JHKKGOELPEG;

					[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
					[Cpp2IlInjected.Token(Token = "0x40003BF")]
					[NoAlias]
					public LambdaParameterValueProvider_IComponentData<KEMLKLJPNBO>.Runtime HCKBLCHIFMP;
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40003BC")]
				[NoAlias]
				[ReadOnly]
				private LambdaParameterValueProvider_Entity LBGHHAFFEOM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x40003BD")]
				[ReadOnly]
				[NoAlias]
				private LambdaParameterValueProvider_IComponentData<KEMLKLJPNBO> NPEPNPCKPBI;

				[Cpp2IlInjected.Token(Token = "0x60007DC")]
				[Cpp2IlInjected.Address(RVA = "0xB9B8E0", Offset = "0xB9A0E0", VA = "0x180B9B8E0")]
				public void LNGFEFINAKH(RegisterTransforms JNPNDBIIELC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60007DD")]
				[Cpp2IlInjected.Address(RVA = "0xB9C6B0", Offset = "0xB9AEB0", VA = "0x180B9C6B0")]
				public ALGLCAOGDIC FJADKACAIMI(ref ArchetypeChunk KGKNEONCAKP, int JKMLLEJBOIE, int CEJIHAPILEF)
				{
					return default(ALGLCAOGDIC);
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			private LLDJAIOLCMF ICGPFDNJJFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			[NativeDisableUnsafePtrRestriction]
			private unsafe LLDJAIOLCMF.ALGLCAOGDIC* DACPFDLDMPF;

			[Cpp2IlInjected.Token(Token = "0x60007D8")]
			[Cpp2IlInjected.Address(RVA = "0xB9B820", Offset = "0xB9A020", VA = "0x180B9B820")]
			internal void KFAKMCGDEPE(Entity NBIJCGHBCCI, KEMLKLJPNBO DDFINIJOFGB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007D9")]
			[Cpp2IlInjected.Address(RVA = "0xB9B780", Offset = "0xB99F80", VA = "0x180B9B780", Slot = "4")]
			public void Execute(ArchetypeChunk ENPKJHPNEAL, int CLJFBMDOKCI, int LHMFKCGLDPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007DA")]
			[Cpp2IlInjected.Address(RVA = "0xB9B940", Offset = "0xB9A140", VA = "0x180B9B940")]
			public void NLDAPEGBEMO(ref ArchetypeChunk ENPKJHPNEAL, [NoAlias] ref LLDJAIOLCMF.ALGLCAOGDIC GJDLAKGIODP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007DB")]
			[Cpp2IlInjected.Address(RVA = "0xB9B8E0", Offset = "0xB9A0E0", VA = "0x180B9B8E0")]
			public void LNGFEFINAKH(RegisterTransforms JNPNDBIIELC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003A5")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003A6")]
		private GJFBBGAACDF HHKFDMFMHJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003A7")]
		private CJCKKBOCBCP GEBBKKIGJGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003A8")]
		private EntityQuery PCCIEGIKFOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003A9")]
		private EntityQuery KOOCKFDBMKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003AA")]
		private EntityQuery MACGPGGKILA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003AB")]
		private EntityQuery HPNMNDIEJGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40003AC")]
		private ProfilerMarker HGDEJKJOAEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40003AD")]
		private EntityQuery FCDDHAIMJID;

		[Cpp2IlInjected.Token(Token = "0x170000E1")]
		public CJCKKBOCBCP JCCFCGEBDDC
		{
			[Cpp2IlInjected.Token(Token = "0x60007BE")]
			[Cpp2IlInjected.Address(RVA = "0x7114B0", Offset = "0x70FCB0", VA = "0x1807114B0")]
			get
			{
				return default(CJCKKBOCBCP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60007BF")]
		[Cpp2IlInjected.Address(RVA = "0xBA8FC0", Offset = "0xBA77C0", VA = "0x180BA8FC0", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C0")]
		[Cpp2IlInjected.Address(RVA = "0xBA9150", Offset = "0xBA7950", VA = "0x180BA9150", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C1")]
		[Cpp2IlInjected.Address(RVA = "0xBA9160", Offset = "0xBA7960", VA = "0x180BA9160", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C2")]
		[Cpp2IlInjected.Address(RVA = "0xBA8B50", Offset = "0xBA7350", VA = "0x180BA8B50")]
		private void LCOCJBEKKMK(NativeArray<Entity> NLBMCCOBHKD, CJCKKBOCBCP MDHIOPJLAID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C3")]
		[Cpp2IlInjected.Address(RVA = "0xBA83A0", Offset = "0xBA6BA0", VA = "0x180BA83A0")]
		[BurstCompile]
		internal static void BHIEOJICELD(NativeArray<KEMLKLJPNBO> CKCKGMAHIKP, ComponentDataFromEntity<KEMLKLJPNBO> GGFGJNDLPNC, CJCKKBOCBCP MDHIOPJLAID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C4")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
		private static void DFHGCIHBILO(Transform EOBPGPELLLJ, Entity NBIJCGHBCCI, int AKLHCIJHJKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C5")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
		private static void CEFEFNIEJGO(Entity NBIJCGHBCCI, int AKLHCIJHJKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C6")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
		private static void HHPBJHCLCBP(int AKLHCIJHJKB, CJCKKBOCBCP MDHIOPJLAID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C7")]
		[Cpp2IlInjected.Address(RVA = "0xBA8950", Offset = "0xBA7150", VA = "0x180BA8950")]
		[Conditional("DEBUG_CHECK_TRANSFORM_ACCESS_INDICES")]
		private void IJMDCHMPJGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007C8")]
		[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
		public RegisterTransforms()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CA")]
		[Cpp2IlInjected.Address(RVA = "0xBA8C80", Offset = "0xBA7480", VA = "0x180BA8C80", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007CB")]
		[Cpp2IlInjected.Address(RVA = "0xBA87F0", Offset = "0xBA6FF0", VA = "0x180BA87F0")]
		public static EntityQuery EIPEKIAGCMO(ComponentSystemBase JNPNDBIIELC)
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x60007CC")]
		[Cpp2IlInjected.Address(RVA = "0xBA8660", Offset = "0xBA6E60", VA = "0x180BA8660")]
		public static EntityQuery CBBGOINPCLC(ComponentSystemBase JNPNDBIIELC)
		{
			return default(EntityQuery);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200012C")]
	[DOHCKPDOJMD(PAPAHBCPMGP.TransformSyncing, new string[] { "Pose", "Uniform", "Deformable" })]
	public class CopyTransformDataToGameObjects : IHCMLLDKAMA
	{
		[Cpp2IlInjected.Token(Token = "0x200012D")]
		[BurstCompile]
		private struct PFCBIMFDGDK : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalPoseData> DGIOJNHJPHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			[ReadOnly]
			public NativeArray<Entity> NLBMCCOBHKD;

			[Cpp2IlInjected.Token(Token = "0x60007E6")]
			[Cpp2IlInjected.Address(RVA = "0xE599C0", Offset = "0xE581C0", VA = "0x180E599C0", Slot = "4")]
			public void Execute(int AKLHCIJHJKB, TransformAccess EOBPGPELLLJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012E")]
		[BurstCompile]
		private struct ELPNDABIBAP : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> OFIENMMOIFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			[ReadOnly]
			public NativeArray<Entity> NLBMCCOBHKD;

			[Cpp2IlInjected.Token(Token = "0x60007E7")]
			[Cpp2IlInjected.Address(RVA = "0xE52F10", Offset = "0xE51710", VA = "0x180E52F10", Slot = "4")]
			public void Execute(int AKLHCIJHJKB, TransformAccess EOBPGPELLLJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200012F")]
		[BurstCompile]
		private struct AMLKFLPOFCD : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalUniformScaleData> OFIENMMOIFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalDeformableScaleData> GKBJEENOHDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			[ReadOnly]
			public NativeArray<Entity> NLBMCCOBHKD;

			[Cpp2IlInjected.Token(Token = "0x60007E8")]
			[Cpp2IlInjected.Address(RVA = "0xE4A7E0", Offset = "0xE48FE0", VA = "0x180E4A7E0", Slot = "4")]
			public void Execute(int AKLHCIJHJKB, TransformAccess EOBPGPELLLJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003C0")]
		private const string BOCKHBGGKGK = "Pose";

		[Cpp2IlInjected.Token(Token = "0x40003C1")]
		private const string GKDPDCLHGGK = "Uniform";

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		private const string KBNEADODBMP = "Deformable";

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		private static readonly FLAFLKKHHEA KJOJKKIIAGD;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		private static readonly FLAFLKKHHEA AEMHMMBPELB;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		private static readonly FLAFLKKHHEA GOKEIMDANCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		private FLBOFEDEFOC HODGNPNBMCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		private JobHandle KPLNFIBGFMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		private EntityQuery BJKAOJMDLPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		private EntityQuery FOBDAJGDKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		private EntityQuery KGLCIIALHOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		private TransformAccessArray DLEPFFPDHHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		private TransformAccessArray NJCFAHHFOAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		private TransformAccessArray PPIPCDJKMPF;

		[Cpp2IlInjected.Token(Token = "0x60007DE")]
		[Cpp2IlInjected.Address(RVA = "0xE51C40", Offset = "0xE50440", VA = "0x180E51C40", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007DF")]
		[Cpp2IlInjected.Address(RVA = "0xE51E50", Offset = "0xE50650", VA = "0x180E51E50", Slot = "9")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E0")]
		[Cpp2IlInjected.Address(RVA = "0x771F00", Offset = "0x770700", VA = "0x180771F00")]
		internal JobHandle CLNJHCFMJIF()
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E1")]
		[Cpp2IlInjected.Address(RVA = "0xE51E90", Offset = "0xE50690", VA = "0x180E51E90", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E2")]
		[Cpp2IlInjected.Address(RVA = "0xE51AB0", Offset = "0xE502B0", VA = "0x180E51AB0")]
		private NativeArray<Entity> BKKKMAPGAED(NativeArray<KEMLKLJPNBO> DPDGILOHPLD, NativeList<Entity> NIELJKPEJGM, TransformAccessArray DLEBHLEGBAJ, TransformAccessArray CLEBAHIODLH)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60007E3")]
		[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
		public CopyTransformDataToGameObjects()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007E5")]
		[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000130")]
public class OFFCHEADOND : IHCMLLDKAMA, GHNBGLLDFLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40003D6")]
	private JHKDIDOGONB ECIJJNHFBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40003D7")]
	private EAEMBLGCFOG GBEJLJPMENI;

	[Cpp2IlInjected.Token(Token = "0x60007E9")]
	[Cpp2IlInjected.Address(RVA = "0x50D4EF0", Offset = "0x50D36F0", VA = "0x1850D4EF0", Slot = "14")]
	public void BCKGPNKBBNF(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EA")]
	[Cpp2IlInjected.Address(RVA = "0x50D50B0", Offset = "0x50D38B0", VA = "0x1850D50B0", Slot = "13")]
	protected override void OnUpdate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EB")]
	[Cpp2IlInjected.Address(RVA = "0x50D56E0", Offset = "0x50D3EE0", VA = "0x1850D56E0")]
	private static void PEOEHLDPHMD(EntityManager FNBDEMCEOPA, Entity NBIJCGHBCCI, Entity CELKNCFBAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EC")]
	[Cpp2IlInjected.Address(RVA = "0x50D4FD0", Offset = "0x50D37D0", VA = "0x1850D4FD0")]
	private static Transform CANJLIECPNJ(EntityManager FNBDEMCEOPA, Entity NBIJCGHBCCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60007ED")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
	public OFFCHEADOND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007EE")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000131")]
	[DOHCKPDOJMD(PAPAHBCPMGP.TransformSyncing)]
	public class L2PToL2WHierarchy : IHCMLLDKAMA
	{
		[Cpp2IlInjected.Token(Token = "0x2000132")]
		[BurstCompile]
		private struct HFOBHIBCBCI : IJobChunk
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			[ReadOnly]
			public ArchetypeChunkComponentType<LocalToParentData> JBMFIEDCFBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			[ReadOnly]
			public ArchetypeChunkBufferType<ChildrenData> ICEGPNOODGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			[ReadOnly]
			public BufferFromEntity<ChildrenData> OECMINEEMHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			[ReadOnly]
			public ComponentDataFromEntity<LocalToParentData> OHHPEBDCNFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public ArchetypeChunkComponentType<LocalToWorldData> MIPIECPCLBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			[NativeDisableContainerSafetyRestriction]
			public ComponentDataFromEntity<LocalToWorldData> LFLODLCOKNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public uint PMPLCBFAPFL;

			[Cpp2IlInjected.Token(Token = "0x60007F4")]
			[Cpp2IlInjected.Address(RVA = "0xB9B2E0", Offset = "0xB99AE0", VA = "0x180B9B2E0")]
			[Conditional("DEBUG_BUILD")]
			private void KAMCOKIAMDN(Entity NBIJCGHBCCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F5")]
			[Cpp2IlInjected.Address(RVA = "0xB9B000", Offset = "0xB99800", VA = "0x180B9B000", Slot = "4")]
			public void Execute(ArchetypeChunk ENPKJHPNEAL, int AKLHCIJHJKB, int GECBMLINLIF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60007F6")]
			[Cpp2IlInjected.Address(RVA = "0xB9B380", Offset = "0xB99B80", VA = "0x180B9B380")]
			private bool NCBDEMKPHPL(ArchetypeChunk ENPKJHPNEAL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60007F7")]
			[Cpp2IlInjected.Address(RVA = "0xB9B430", Offset = "0xB99C30", VA = "0x180B9B430")]
			private void PHJPLPDDJPG(float4x4 EGDJMMHCPPI, Entity NBIJCGHBCCI, bool POHGAENKECC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		private EntityQuery KCDLIIDLPOM;

		[Cpp2IlInjected.Token(Token = "0x60007EF")]
		[Cpp2IlInjected.Address(RVA = "0xE56E80", Offset = "0xE55680", VA = "0x180E56E80", Slot = "5")]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F0")]
		[Cpp2IlInjected.Address(RVA = "0xE56F10", Offset = "0xE55710", VA = "0x180E56F10", Slot = "13")]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F1")]
		[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
		public L2PToL2WHierarchy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007F3")]
		[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
		protected internal override void OnCreateForCompiler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000133")]
public class JCGLALJHLNF : NODCCJFPGAM
{
	[Cpp2IlInjected.Token(Token = "0x2000134")]
	[BurstCompile]
	private struct PFOMLDNJOPB : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToParentData> JBMFIEDCFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public ArchetypeChunkComponentType<LocalToWorldData> MIPIECPCLBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public uint PMPLCBFAPFL;

		[Cpp2IlInjected.Token(Token = "0x60007FC")]
		[Cpp2IlInjected.Address(RVA = "0x50D7B90", Offset = "0x50D6390", VA = "0x1850D7B90", Slot = "4")]
		public void Execute(ArchetypeChunk ENPKJHPNEAL, int AKLHCIJHJKB, int GECBMLINLIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60007FD")]
		[Cpp2IlInjected.Address(RVA = "0x50D7CA0", Offset = "0x50D64A0", VA = "0x1850D7CA0")]
		public bool NCBDEMKPHPL(ArchetypeChunk ENPKJHPNEAL)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003E1")]
	private EntityQuery KCDLIIDLPOM;

	[Cpp2IlInjected.Token(Token = "0x60007F8")]
	[Cpp2IlInjected.Address(RVA = "0x50C7D00", Offset = "0x50C6500", VA = "0x1850C7D00", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007F9")]
	[Cpp2IlInjected.Address(RVA = "0x50C7E00", Offset = "0x50C6600", VA = "0x1850C7E00", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle PEALJNBNNCK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60007FA")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
	public JCGLALJHLNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FB")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000135")]
public class HCKLACOBJMJ : NODCCJFPGAM
{
	[Cpp2IlInjected.Token(Token = "0x2000136")]
	[BurstCompile]
	private struct OLFGPKPLJDK : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalToWorldData> AJPJKNNOLDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public ArchetypeChunkComponentType<WorldPoseData> NHDPKILOGJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public ArchetypeChunkComponentType<WorldUniformScaleData> IOFALFOCICD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public ArchetypeChunkComponentType<WorldDeformableScaleData> KDOKPNCPDLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public uint PMPLCBFAPFL;

		[Cpp2IlInjected.Token(Token = "0x6000802")]
		[Cpp2IlInjected.Address(RVA = "0x504DC40", Offset = "0x504C440", VA = "0x18504DC40", Slot = "4")]
		public void Execute(ArchetypeChunk ENPKJHPNEAL, int AKLHCIJHJKB, int GECBMLINLIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000803")]
		[Cpp2IlInjected.Address(RVA = "0x504DFE0", Offset = "0x504C7E0", VA = "0x18504DFE0")]
		public bool NCBDEMKPHPL(ArchetypeChunk ENPKJHPNEAL)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003E5")]
	private EntityQuery CJCNOIMAAPK;

	[Cpp2IlInjected.Token(Token = "0x60007FE")]
	[Cpp2IlInjected.Address(RVA = "0x504ABC0", Offset = "0x50493C0", VA = "0x18504ABC0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60007FF")]
	[Cpp2IlInjected.Address(RVA = "0x504ACB0", Offset = "0x50494B0", VA = "0x18504ACB0", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle PEALJNBNNCK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000800")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
	public HCKLACOBJMJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000801")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000137")]
public class PFLCGHEKAPE : JobComponentSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000138")]
	[BurstCompile]
	private struct DLGEJHHKNCC : IJobChunk
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalPoseData> HFDHJKBEAIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalDeformableScaleData> BADGBKLGBPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		[ReadOnly]
		public ArchetypeChunkComponentType<LocalUniformScaleData> OEBONJCPPPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public ArchetypeChunkComponentType<LocalToParentData> PAHDAMCCAMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public uint PMPLCBFAPFL;

		[Cpp2IlInjected.Token(Token = "0x6000808")]
		[Cpp2IlInjected.Address(RVA = "0xE52630", Offset = "0xE50E30", VA = "0x180E52630", Slot = "4")]
		public void Execute(ArchetypeChunk ENPKJHPNEAL, int AKLHCIJHJKB, int GECBMLINLIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000809")]
		[Cpp2IlInjected.Address(RVA = "0xE52AE0", Offset = "0xE512E0", VA = "0x180E52AE0")]
		public bool NCBDEMKPHPL(ArchetypeChunk ENPKJHPNEAL)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40003EB")]
	private EntityQuery CJCNOIMAAPK;

	[Cpp2IlInjected.Token(Token = "0x6000804")]
	[Cpp2IlInjected.Address(RVA = "0xE59AF0", Offset = "0xE582F0", VA = "0x180E59AF0", Slot = "5")]
	protected override void OnCreate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000805")]
	[Cpp2IlInjected.Address(RVA = "0xE59C00", Offset = "0xE58400", VA = "0x180E59C00", Slot = "13")]
	protected override JobHandle OnUpdate(JobHandle PEALJNBNNCK)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x6000806")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50")]
	public PFLCGHEKAPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000807")]
	[Cpp2IlInjected.Address(RVA = "0x606E30", Offset = "0x605630", VA = "0x180606E30", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000139")]
internal abstract class FCPILGHJKEO : PropagateTagsBase<global::IFJIGPJDLJN, global::LKCJADILDIN, FCPILGHJKEO.MGKEIFGCCBN>
{
	[Cpp2IlInjected.Token(Token = "0x200013A")]
	public struct MGKEIFGCCBN : ISystemStateComponentData, IComponentData
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080A")]
	[Cpp2IlInjected.Address(RVA = "0x503F410", Offset = "0x503DC10", VA = "0x18503F410")]
	protected FCPILGHJKEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600080B")]
	[Cpp2IlInjected.Address(RVA = "0x503F3D0", Offset = "0x503DBD0", VA = "0x18503F3D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013B")]
[CCIJCDFGPFF(GGFKBMKOJDK.Game)]
public class IBFKGOKLJGL : DODGNPMHCOJ
{
	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public Type DINALDIFGIH
	{
		[Cpp2IlInjected.Token(Token = "0x600080C")]
		[Cpp2IlInjected.Address(RVA = "0x50C6640", Offset = "0x50C4E40", VA = "0x1850C6640", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public Type[] DEKBFFGOLGP
	{
		[Cpp2IlInjected.Token(Token = "0x600080D")]
		[Cpp2IlInjected.Address(RVA = "0x50C66A0", Offset = "0x50C4EA0", VA = "0x1850C66A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600080E")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public IBFKGOKLJGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013C")]
[CCIJCDFGPFF(GGFKBMKOJDK.Loading)]
public class LJPBNHNHIEO : DODGNPMHCOJ
{
	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public Type DINALDIFGIH
	{
		[Cpp2IlInjected.Token(Token = "0x600080F")]
		[Cpp2IlInjected.Address(RVA = "0x606B10", Offset = "0x605310", VA = "0x180606B10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public Type[] DEKBFFGOLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000810")]
		[Cpp2IlInjected.Address(RVA = "0x50D0330", Offset = "0x50CEB30", VA = "0x1850D0330", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000811")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public LJPBNHNHIEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013D")]
public sealed class IELFJLGJDBD : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000812")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public IELFJLGJDBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000813")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013E")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(IELFJLGJDBD))]
public sealed class HJBONFDHEJE : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000814")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public HJBONFDHEJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000815")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200013F")]
[MIDOOGOCAPK]
[UpdateAfter(typeof(HJBONFDHEJE))]
[UpdateInGroup(typeof(IELFJLGJDBD))]
public sealed class JEBNAANPENO : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000816")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public JEBNAANPENO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000817")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000140")]
[CCIJCDFGPFF(GGFKBMKOJDK.Saving)]
public class LEFPEMNOFBC : DODGNPMHCOJ
{
	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public Type DINALDIFGIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000818")]
		[Cpp2IlInjected.Address(RVA = "0x606B10", Offset = "0x605310", VA = "0x180606B10", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public Type[] DEKBFFGOLGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000819")]
		[Cpp2IlInjected.Address(RVA = "0x50CFEF0", Offset = "0x50CE6F0", VA = "0x1850CFEF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600081A")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public LEFPEMNOFBC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000141")]
public sealed class JKDBHHDKCBD : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x600081B")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public JKDBHHDKCBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600081C")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000142")]
[CCIJCDFGPFF(GGFKBMKOJDK.Simulation)]
public class ABMDNFKPAPA : DODGNPMHCOJ
{
	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public Type DINALDIFGIH
	{
		[Cpp2IlInjected.Token(Token = "0x600081D")]
		[Cpp2IlInjected.Address(RVA = "0x5039070", Offset = "0x5037870", VA = "0x185039070", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public Type[] DEKBFFGOLGP
	{
		[Cpp2IlInjected.Token(Token = "0x600081E")]
		[Cpp2IlInjected.Address(RVA = "0x50390D0", Offset = "0x50378D0", VA = "0x1850390D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600081F")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public ABMDNFKPAPA()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000143")]
	[DOHCKPDOJMD(PAPAHBCPMGP.Connectables, new string[] { "Callbacks" })]
	[CEFINOONOIN(typeof(HFCJOFNPJDG), new string[] { })]
	internal class ConnectableService : HFCJOFNPJDG, DKFAOOPHPAH, GHNBGLLDFLL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000144")]
		[CompilerGenerated]
		private sealed class CGIODDDOFGF : IEnumerable<CFBEFPIPHOM>, IEnumerable, IEnumerator<CFBEFPIPHOM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			private CFBEFPIPHOM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400040E")]
			public ConnectableService <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400040F")]
			private CFBEFPIPHOM localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000410")]
			public CFBEFPIPHOM <>3__localId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000411")]
			private NativeArray<Entity> <childEntitiesCopy>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000412")]
			private NativeArray<Entity>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x170000EB")]
			private CFBEFPIPHOM System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.ObjectLocalId>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000845")]
				[Cpp2IlInjected.Address(RVA = "0x68E570", Offset = "0x68CD70", VA = "0x18068E570", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(CFBEFPIPHOM);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000EC")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000847")]
				[Cpp2IlInjected.Address(RVA = "0xE4C5A0", Offset = "0xE4ADA0", VA = "0x180E4C5A0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000840")]
			[Cpp2IlInjected.Address(RVA = "0xE4C760", Offset = "0xE4AF60", VA = "0x180E4C760")]
			[DebuggerHidden]
			public CGIODDDOFGF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000841")]
			[Cpp2IlInjected.Address(RVA = "0xE4C5F0", Offset = "0xE4ADF0", VA = "0x180E4C5F0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000842")]
			[Cpp2IlInjected.Address(RVA = "0xE4C200", Offset = "0xE4AA00", VA = "0x180E4C200", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000843")]
			[Cpp2IlInjected.Address(RVA = "0xE4C6E0", Offset = "0xE4AEE0", VA = "0x180E4C6E0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000844")]
			[Cpp2IlInjected.Address(RVA = "0xE4C720", Offset = "0xE4AF20", VA = "0x180E4C720")]
			private void <>m__Finally2()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000846")]
			[Cpp2IlInjected.Address(RVA = "0xE4C550", Offset = "0xE4AD50", VA = "0x180E4C550", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000848")]
			[Cpp2IlInjected.Address(RVA = "0xE4C4A0", Offset = "0xE4ACA0", VA = "0x180E4C4A0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<CFBEFPIPHOM> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000849")]
			[Cpp2IlInjected.Address(RVA = "0xE4C4A0", Offset = "0xE4ACA0", VA = "0x180E4C4A0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		private const string CMGMDHKFGFN = "Callbacks";

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		private static readonly FLAFLKKHHEA HABKADCFIOL;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public const int HCCFAHLOIKB = 0;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public const int FNDGDGPAAMH = 1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		private FOJPBIGOEBJ NLJLBCPPCEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		private HIPDIEDHHMJ CJCNOIMAAPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		private HFEGCOONMAM LMKNNIPOPLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private ENJAHHPPGPN AGONKCODOEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private PropertyEventCallbacksService CFHAALIELBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private global::MBCDLMIAJND<AuthoredParentData, IIGFJFAPCCG, EMNEDPOLCKJ, AuthoredChildrenData> DCEPPHEJMFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private global::MEBPHBGNBLO<Entity> GNKMHPIOANG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		private global::MEBPHBGNBLO<float3> IHKCEIOOGBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		private global::MEBPHBGNBLO<quaternion> AKCECMGOCBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		private global::MEBPHBGNBLO<Entity> CELKNCFBAOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		private global::MEBPHBGNBLO<float3> NDFADLNAIEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		private global::MEBPHBGNBLO<quaternion> DEOODMICGDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		private HashSet<Entity> IGBBGPICPIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		private HashSet<Entity> JIACDKOFPJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		private EntityQuery PMMOINLKFEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		private bool NMANPNFCCCL;

		[Cpp2IlInjected.Token(Token = "0x170000EA")]
		public Func<ELFHFLPLNFA> FLJEMHGLBBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000828")]
			[Cpp2IlInjected.Address(RVA = "0x66CFD0", Offset = "0x66B7D0", VA = "0x18066CFD0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000829")]
			[Cpp2IlInjected.Address(RVA = "0x67D180", Offset = "0x67B980", VA = "0x18067D180", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000013")]
		public event Action<CFBEFPIPHOM, CFBEFPIPHOM> NPONHJCPNDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000820")]
			[Cpp2IlInjected.Address(RVA = "0xE4F6F0", Offset = "0xE4DEF0", VA = "0x180E4F6F0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000821")]
			[Cpp2IlInjected.Address(RVA = "0xE50AA0", Offset = "0xE4F2A0", VA = "0x180E50AA0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000014")]
		public event Action<CFBEFPIPHOM, CFBEFPIPHOM> DHBFONNJJOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000822")]
			[Cpp2IlInjected.Address(RVA = "0xE4F7F0", Offset = "0xE4DFF0", VA = "0x180E4F7F0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000823")]
			[Cpp2IlInjected.Address(RVA = "0xE4F890", Offset = "0xE4E090", VA = "0x180E4F890", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000015")]
		public event Action<CFBEFPIPHOM, CFBEFPIPHOM, CFBEFPIPHOM> PBMNFHOGJBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000824")]
			[Cpp2IlInjected.Address(RVA = "0xE50890", Offset = "0xE4F090", VA = "0x180E50890", Slot = "8")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000825")]
			[Cpp2IlInjected.Address(RVA = "0xE50930", Offset = "0xE4F130", VA = "0x180E50930", Slot = "9")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000016")]
		public event Action<CFBEFPIPHOM> BPLKPAFDEBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000826")]
			[Cpp2IlInjected.Address(RVA = "0xE4F930", Offset = "0xE4E130", VA = "0x180E4F930", Slot = "10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000827")]
			[Cpp2IlInjected.Address(RVA = "0xE4FE00", Offset = "0xE4E600", VA = "0x180E4FE00", Slot = "11")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600082A")]
		[Cpp2IlInjected.Address(RVA = "0xE50030", Offset = "0xE4E830", VA = "0x180E50030", Slot = "23")]
		public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082B")]
		[Cpp2IlInjected.Address(RVA = "0xE4F9D0", Offset = "0xE4E1D0", VA = "0x180E4F9D0", Slot = "24")]
		public void BCKGPNKBBNF(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082C")]
		[Cpp2IlInjected.Address(RVA = "0xE4FEA0", Offset = "0xE4E6A0", VA = "0x180E4FEA0", Slot = "25")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082D")]
		[Cpp2IlInjected.Address(RVA = "0xE4F790", Offset = "0xE4DF90", VA = "0x180E4F790")]
		private void AEPGMBEKLFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082E")]
		[Cpp2IlInjected.Address(RVA = "0xE50D00", Offset = "0xE4F500", VA = "0x180E50D00")]
		private void MLOHCBFKBAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600082F")]
		[Cpp2IlInjected.Address(RVA = "0xE50680", Offset = "0xE4EE80", VA = "0x180E50680")]
		private void JLEGFEMJONP(Entity NBIJCGHBCCI, MIPCILJMDGJ KBHHIDGOLNC, BJHFEKKLKGB JCEACLPGDMD, BJHFEKKLKGB CMJHENLPPFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000830")]
		[Cpp2IlInjected.Address(RVA = "0xE50830", Offset = "0xE4F030", VA = "0x180E50830")]
		private void KGOIGBLAMJJ(Entity NBIJCGHBCCI, MIPCILJMDGJ KBHHIDGOLNC, BJHFEKKLKGB JCEACLPGDMD, BJHFEKKLKGB CMJHENLPPFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000831")]
		[Cpp2IlInjected.Address(RVA = "0xD21250", Offset = "0xD1FA50", VA = "0x180D21250", Slot = "14")]
		public CFBEFPIPHOM LOOBONCPBDH(CFBEFPIPHOM LEPHKDIHJFD, int HIJMIBAOAJE)
		{
			return default(CFBEFPIPHOM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000832")]
		[Cpp2IlInjected.Address(RVA = "0xE504C0", Offset = "0xE4ECC0", VA = "0x180E504C0", Slot = "15")]
		public Color HFKGILBLCIB(CFBEFPIPHOM LEPHKDIHJFD, int HIJMIBAOAJE)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000833")]
		[Cpp2IlInjected.Address(RVA = "0xE51310", Offset = "0xE4FB10", VA = "0x180E51310", Slot = "16")]
		public float3 PLGCCCFGNNG(CFBEFPIPHOM LEPHKDIHJFD, int HIJMIBAOAJE)
		{
			return default(float3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000834")]
		[Cpp2IlInjected.Address(RVA = "0xE509D0", Offset = "0xE4F1D0", VA = "0x180E509D0", Slot = "17")]
		public void MEIKIKOFGKA(CFBEFPIPHOM LEPHKDIHJFD, CFBEFPIPHOM FFOKEBNNBAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000835")]
		[Cpp2IlInjected.Address(RVA = "0xE50E50", Offset = "0xE4F650", VA = "0x180E50E50", Slot = "18")]
		public CFBEFPIPHOM MOLCNOANCBK(CFBEFPIPHOM LEPHKDIHJFD)
		{
			return default(CFBEFPIPHOM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000836")]
		[Cpp2IlInjected.Address(RVA = "0xE50150", Offset = "0xE4E950", VA = "0x180E50150", Slot = "21")]
		public void EBOIEJALFCB(CFBEFPIPHOM LEPHKDIHJFD, Vector3 KKIIPFPIGCC, Quaternion DKDOCMODCJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000837")]
		[Cpp2IlInjected.Address(RVA = "0xE50360", Offset = "0xE4EB60", VA = "0x180E50360", Slot = "26")]
		public (Vector3, Quaternion) FKJLMKDKIFB(CFBEFPIPHOM LEPHKDIHJFD)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x6000838")]
		[Cpp2IlInjected.Address(RVA = "0xE504F0", Offset = "0xE4ECF0", VA = "0x180E504F0", Slot = "27")]
		public (Vector3, Quaternion) JCOCHMIBGHF(CFBEFPIPHOM LEPHKDIHJFD)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x6000839")]
		[Cpp2IlInjected.Address(RVA = "0xE50B40", Offset = "0xE4F340", VA = "0x180E50B40", Slot = "22")]
		public (Vector3, Quaternion, bool) MKKKPNCHLNF(CFBEFPIPHOM LEPHKDIHJFD)
		{
			return default((Vector3, Quaternion, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600083A")]
		[Cpp2IlInjected.Address(RVA = "0xE51060", Offset = "0xE4F860", VA = "0x180E51060", Slot = "19")]
		[IteratorStateMachine(typeof(CGIODDDOFGF))]
		public IEnumerable<CFBEFPIPHOM> OOBCJHMMBOP(CFBEFPIPHOM LEPHKDIHJFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600083B")]
		[Cpp2IlInjected.Address(RVA = "0xE510F0", Offset = "0xE4F8F0", VA = "0x180E510F0", Slot = "20")]
		public CFBEFPIPHOM PAECMEAAFNB(CFBEFPIPHOM LEPHKDIHJFD)
		{
			return default(CFBEFPIPHOM);
		}

		[Cpp2IlInjected.Token(Token = "0x600083C")]
		[Cpp2IlInjected.Address(RVA = "0xE50EF0", Offset = "0xE4F6F0", VA = "0x180E50EF0", Slot = "28")]
		public void OLCHMPOLLGP(ref List<CFBEFPIPHOM> BBHLGJGEJKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600083D")]
		[Cpp2IlInjected.Address(RVA = "0xE51210", Offset = "0xE4FA10", VA = "0x180E51210")]
		private Entity PAECMEAAFNB(Entity NBIJCGHBCCI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600083E")]
		[Cpp2IlInjected.Address(RVA = "0xE51570", Offset = "0xE4FD70", VA = "0x180E51570")]
		public ConnectableService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000145")]
	[CEFINOONOIN(typeof(EntityHierarchyChildren), new string[] { })]
	[DOHCKPDOJMD(PAPAHBCPMGP.HierarchySystems)]
	internal sealed class EntityHierarchyChildren : DKFAOOPHPAH
	{
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		private HFEGCOONMAM LMKNNIPOPLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		private EBPKDLGCKDG DJMDBGODMGE;

		[Cpp2IlInjected.Token(Token = "0x170000ED")]
		private EntityManager BNFBCOAMLJO
		{
			[Cpp2IlInjected.Token(Token = "0x600084A")]
			[Cpp2IlInjected.Address(RVA = "0xE54960", Offset = "0xE53160", VA = "0x180E54960")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600084B")]
		[Cpp2IlInjected.Address(RVA = "0xE54360", Offset = "0xE52B60", VA = "0x180E54360", Slot = "4")]
		public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084C")]
		[Cpp2IlInjected.Address(RVA = "0xE54B40", Offset = "0xE53340", VA = "0x180E54B40")]
		internal void PHEOHCBLPKL(Entity CELKNCFBAOE, Entity CPANDONOICF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084D")]
		[Cpp2IlInjected.Address(RVA = "0xE54A70", Offset = "0xE53270", VA = "0x180E54A70")]
		internal void PFIHMBOBIKK(Entity CELKNCFBAOE, Entity CPANDONOICF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600084E")]
		[Cpp2IlInjected.Address(RVA = "0xE54880", Offset = "0xE53080", VA = "0x180E54880")]
		private int NFGGJMKEJJM(Entity CELKNCFBAOE, Entity CPANDONOICF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600084F")]
		[Cpp2IlInjected.Address(RVA = "0xE54680", Offset = "0xE52E80", VA = "0x180E54680")]
		internal DynamicBuffer<ChildrenData> JFODJBKOBEC(Entity NBIJCGHBCCI)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000850")]
		[Cpp2IlInjected.Address(RVA = "0xE549B0", Offset = "0xE531B0", VA = "0x180E549B0")]
		internal DynamicBuffer<ChildrenData> PCHOCPBINHK(Entity NBIJCGHBCCI)
		{
			return default(DynamicBuffer<ChildrenData>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000851")]
		[Cpp2IlInjected.Address(RVA = "0xE541F0", Offset = "0xE529F0", VA = "0x180E541F0")]
		public NativeArray<Entity> ACKCFPGPDIP(Entity NBIJCGHBCCI, Allocator DDJPHGFEOFF)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000852")]
		[Cpp2IlInjected.Address(RVA = "0xE544D0", Offset = "0xE52CD0", VA = "0x180E544D0")]
		public bool GJNEOAKFKEG(Entity NBIJCGHBCCI, Allocator DDJPHGFEOFF, out NativeArray<Entity> PDKOJMGKHLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000853")]
		[Cpp2IlInjected.Address(RVA = "0xE54740", Offset = "0xE52F40", VA = "0x180E54740")]
		public NativeArray<Entity> KJNNCIAMMOP(Entity NBIJCGHBCCI)
		{
			return default(NativeArray<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000854")]
		[Cpp2IlInjected.Address(RVA = "0xE54250", Offset = "0xE52A50", VA = "0x180E54250")]
		public Entity CPPPKAEFNAP(Entity NBIJCGHBCCI, int AKLHCIJHJKB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000855")]
		[Cpp2IlInjected.Address(RVA = "0xE543E0", Offset = "0xE52BE0", VA = "0x180E543E0")]
		public int EDJIMEHBLAH(Entity NBIJCGHBCCI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000856")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public EntityHierarchyChildren()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000146")]
	[DOHCKPDOJMD(PAPAHBCPMGP.HierarchySystems)]
	[CEFINOONOIN(typeof(EntityHierarchyEvents), new string[] { })]
	internal sealed class EntityHierarchyEvents : DKFAOOPHPAH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		private HFEGCOONMAM LMKNNIPOPLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		private ObjectEmbodimentService MDLJNEBAIPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		private ObjectLifecycleService IGCMNAMAMMG;

		[Cpp2IlInjected.Token(Token = "0x6000858")]
		[Cpp2IlInjected.Address(RVA = "0xE54E00", Offset = "0xE53600", VA = "0x180E54E00", Slot = "4")]
		public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000859")]
		[Cpp2IlInjected.Address(RVA = "0xE54CF0", Offset = "0xE534F0", VA = "0x180E54CF0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085A")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
		private void CPLACHOLLAN(BKIEEIBJMKG MDLJNEBAIPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085B")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
		private void ANFLFIIENOA(BKIEEIBJMKG MDLJNEBAIPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085C")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
		private void CBCAMDOKCBC(Entity NBIJCGHBCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600085D")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public EntityHierarchyEvents()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000147")]
	[CEFINOONOIN(typeof(EntityHierarchyParents), new string[] { })]
	[DOHCKPDOJMD(PAPAHBCPMGP.HierarchySystems)]
	internal sealed class EntityHierarchyParents : DKFAOOPHPAH, GHNBGLLDFLL
	{
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		private HIPDIEDHHMJ CJCNOIMAAPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		private global::MEBPHBGNBLO<Entity> IOADAIMHMFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		private PropertyChangeNetworkRouter CCPKMLPHGME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		private global::MBCDLMIAJND<ParentData, ECIBJLGBGHF, DIAFPPIIIAE, ChildrenData> DCEPPHEJMFN;

		[Cpp2IlInjected.Token(Token = "0x600085F")]
		[Cpp2IlInjected.Address(RVA = "0xE551E0", Offset = "0xE539E0", VA = "0x180E551E0", Slot = "4")]
		public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000860")]
		[Cpp2IlInjected.Address(RVA = "0xE55100", Offset = "0xE53900", VA = "0x180E55100", Slot = "5")]
		public void BCKGPNKBBNF(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000861")]
		[Cpp2IlInjected.Address(RVA = "0xE55300", Offset = "0xE53B00", VA = "0x180E55300")]
		public Entity MOLCNOANCBK(Entity NBIJCGHBCCI)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000862")]
		[Cpp2IlInjected.Address(RVA = "0xE550A0", Offset = "0xE538A0", VA = "0x180E550A0")]
		public bool BCIMKCBBIFF(Entity NBIJCGHBCCI, Entity ACODEJEKDBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000863")]
		[Cpp2IlInjected.Address(RVA = "0xE55260", Offset = "0xE53A60", VA = "0x180E55260")]
		public bool MEIKIKOFGKA(Entity NBIJCGHBCCI, Entity ACODEJEKDBE, bool BONIBHBAFFM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000864")]
		[Cpp2IlInjected.Address(RVA = "0xE55350", Offset = "0xE53B50", VA = "0x180E55350")]
		private bool OGBPEBDGFHC(Entity NBIJCGHBCCI, Entity ACODEJEKDBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000865")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public EntityHierarchyParents()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000148")]
[OJBFCHOEMHJ(typeof(HFEGCOONMAM))]
[CEFINOONOIN(typeof(EBPKDLGCKDG), new string[] { })]
internal sealed class EBPKDLGCKDG : DKFAOOPHPAH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000149")]
	[CompilerGenerated]
	private sealed class FEHOFJJOFCG : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		private Entity <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		private bool includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public bool <>3__includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public Entity <>3__entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public EBPKDLGCKDG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x170000EF")]
		Entity IEnumerator<Entity>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600087A")]
			[Cpp2IlInjected.Address(RVA = "0xB9C480", Offset = "0xB9AC80", VA = "0x180B9C480", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F0")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600087C")]
			[Cpp2IlInjected.Address(RVA = "0x5044C60", Offset = "0x5043460", VA = "0x185044C60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000877")]
		[Cpp2IlInjected.Address(RVA = "0xB9C530", Offset = "0xB9AD30", VA = "0x180B9C530")]
		[DebuggerHidden]
		public FEHOFJJOFCG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000878")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000879")]
		[Cpp2IlInjected.Address(RVA = "0x5044AC0", Offset = "0x50432C0", VA = "0x185044AC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600087B")]
		[Cpp2IlInjected.Address(RVA = "0x5044C10", Offset = "0x5043410", VA = "0x185044C10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600087D")]
		[Cpp2IlInjected.Address(RVA = "0x5044B60", Offset = "0x5043360", VA = "0x185044B60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600087E")]
		[Cpp2IlInjected.Address(RVA = "0x5044B60", Offset = "0x5043360", VA = "0x185044B60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014A")]
	[CompilerGenerated]
	private sealed class PIJFEOAPGOD : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private Entity <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		private bool includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		public bool <>3__includeSelf;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		public Entity <>3__entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		public EBPKDLGCKDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		private IEnumerator<Entity> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x170000F1")]
		Entity IEnumerator<Entity>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000883")]
			[Cpp2IlInjected.Address(RVA = "0xB9C480", Offset = "0xB9AC80", VA = "0x180B9C480", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F2")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000885")]
			[Cpp2IlInjected.Address(RVA = "0x504EA30", Offset = "0x504D230", VA = "0x18504EA30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600087F")]
		[Cpp2IlInjected.Address(RVA = "0xB9C530", Offset = "0xB9AD30", VA = "0x180B9C530")]
		[DebuggerHidden]
		public PIJFEOAPGOD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000880")]
		[Cpp2IlInjected.Address(RVA = "0x504EA80", Offset = "0x504D280", VA = "0x18504EA80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000881")]
		[Cpp2IlInjected.Address(RVA = "0x504E770", Offset = "0x504CF70", VA = "0x18504E770", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000882")]
		[Cpp2IlInjected.Address(RVA = "0x504EB30", Offset = "0x504D330", VA = "0x18504EB30")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000884")]
		[Cpp2IlInjected.Address(RVA = "0x504E9E0", Offset = "0x504D1E0", VA = "0x18504E9E0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000886")]
		[Cpp2IlInjected.Address(RVA = "0x504E930", Offset = "0x504D130", VA = "0x18504E930", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000887")]
		[Cpp2IlInjected.Address(RVA = "0x504E930", Offset = "0x504D130", VA = "0x18504E930", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200014B")]
	[CompilerGenerated]
	private sealed class BCMNDNKNJOF : IEnumerable<Entity>, IEnumerable, IEnumerator<Entity>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		private Entity <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public EBPKDLGCKDG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		private Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public Entity <>3__entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		private NativeArray<ChildrenData>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		private ChildrenData <childData>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		private IEnumerator<Entity> <>7__wrap3;

		[Cpp2IlInjected.Token(Token = "0x170000F3")]
		Entity IEnumerator<Entity>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600088D")]
			[Cpp2IlInjected.Address(RVA = "0xB9C480", Offset = "0xB9AC80", VA = "0x180B9C480", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(Entity);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F4")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600088F")]
			[Cpp2IlInjected.Address(RVA = "0x503DD20", Offset = "0x503C520", VA = "0x18503DD20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000888")]
		[Cpp2IlInjected.Address(RVA = "0xB9C530", Offset = "0xB9AD30", VA = "0x180B9C530")]
		[DebuggerHidden]
		public BCMNDNKNJOF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000889")]
		[Cpp2IlInjected.Address(RVA = "0x503DD70", Offset = "0x503C570", VA = "0x18503DD70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088A")]
		[Cpp2IlInjected.Address(RVA = "0x503D970", Offset = "0x503C170", VA = "0x18503D970", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600088B")]
		[Cpp2IlInjected.Address(RVA = "0x503DE70", Offset = "0x503C670", VA = "0x18503DE70")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088C")]
		[Cpp2IlInjected.Address(RVA = "0x503DEB0", Offset = "0x503C6B0", VA = "0x18503DEB0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600088E")]
		[Cpp2IlInjected.Address(RVA = "0x503DCD0", Offset = "0x503C4D0", VA = "0x18503DCD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000890")]
		[Cpp2IlInjected.Address(RVA = "0x503DC20", Offset = "0x503C420", VA = "0x18503DC20", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<Entity> IEnumerable<Entity>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000891")]
		[Cpp2IlInjected.Address(RVA = "0x503DC20", Offset = "0x503C420", VA = "0x18503DC20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400041F")]
	private HFEGCOONMAM LMKNNIPOPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000420")]
	private EntityHierarchyParents GJNHJKBKEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000421")]
	private EntityHierarchyChildren DFGJAHNNJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000422")]
	private EntityQuery PMMOINLKFEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000423")]
	private bool NMANPNFCCCL;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private EntityManager BNFBCOAMLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000867")]
		[Cpp2IlInjected.Address(RVA = "0x5043640", Offset = "0x5041E40", VA = "0x185043640")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000868")]
	[Cpp2IlInjected.Address(RVA = "0x5042F50", Offset = "0x5041750", VA = "0x185042F50", Slot = "4")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000869")]
	[Cpp2IlInjected.Address(RVA = "0x5042F30", Offset = "0x5041730", VA = "0x185042F30", Slot = "5")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600086A")]
	[Cpp2IlInjected.Address(RVA = "0x5043290", Offset = "0x5041A90", VA = "0x185043290")]
	public bool MFEJJMDALEL(Entity NBIJCGHBCCI, Entity ELKNCMDOGDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600086B")]
	[Cpp2IlInjected.Address(RVA = "0x5042E50", Offset = "0x5041650", VA = "0x185042E50")]
	public bool DFLCCKKCIDJ(Entity NBIJCGHBCCI, Entity ELKNCMDOGDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600086C")]
	[Cpp2IlInjected.Address(RVA = "0x5042D20", Offset = "0x5041520", VA = "0x185042D20")]
	public IEnumerable<Entity> CFCGEAOGLKA(Entity NBIJCGHBCCI, bool CPJDMHMNGCL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600086D")]
	[Cpp2IlInjected.Address(RVA = "0x5043730", Offset = "0x5041F30", VA = "0x185043730")]
	[IteratorStateMachine(typeof(FEHOFJJOFCG))]
	private IEnumerable<Entity> PKFMJDMHMGK(Entity NBIJCGHBCCI, bool CPJDMHMNGCL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600086E")]
	[Cpp2IlInjected.Address(RVA = "0x5042C40", Offset = "0x5041440", VA = "0x185042C40")]
	public bool BCMMBEKINFE(Entity NBIJCGHBCCI, Entity CPANDONOICF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600086F")]
	[Cpp2IlInjected.Address(RVA = "0x5042D00", Offset = "0x5041500", VA = "0x185042D00")]
	public bool BIPHIMNHBID(Entity NBIJCGHBCCI, Entity KILCGFPNBMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000870")]
	[Cpp2IlInjected.Address(RVA = "0x5043430", Offset = "0x5041C30", VA = "0x185043430")]
	public IEnumerable<Entity> MOAJPFKPOBK(Entity NBIJCGHBCCI, bool CPJDMHMNGCL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000871")]
	[Cpp2IlInjected.Address(RVA = "0x5043690", Offset = "0x5041E90", VA = "0x185043690")]
	[IteratorStateMachine(typeof(PIJFEOAPGOD))]
	private IEnumerable<Entity> PIMNFBGKEDK(Entity NBIJCGHBCCI, bool CPJDMHMNGCL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000872")]
	[Cpp2IlInjected.Address(RVA = "0x5043060", Offset = "0x5041860", VA = "0x185043060")]
	[IteratorStateMachine(typeof(BCMNDNKNJOF))]
	private IEnumerable<Entity> GPDMNBNPAPM(Entity NBIJCGHBCCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000873")]
	[Cpp2IlInjected.Address(RVA = "0x50435B0", Offset = "0x5041DB0", VA = "0x1850435B0")]
	public Entity PAECMEAAFNB(Entity NBIJCGHBCCI)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x6000874")]
	[Cpp2IlInjected.Address(RVA = "0x5043560", Offset = "0x5041D60", VA = "0x185043560")]
	public NativeArray<Entity> OLCHMPOLLGP()
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000875")]
	[Cpp2IlInjected.Address(RVA = "0x50430E0", Offset = "0x50418E0", VA = "0x1850430E0")]
	public bool MAIKBHHOMHF(Entity KILCGFPNBMC, Entity BBAPJHOFLJP, out Entity JDBIDILANEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000876")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public EBPKDLGCKDG()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200014C")]
	[DOHCKPDOJMD(PAPAHBCPMGP.HierarchySystems)]
	public static class ParentPolicyValidation
	{
		[Cpp2IlInjected.Token(Token = "0x6000892")]
		[Cpp2IlInjected.Address(RVA = "0x5004620", Offset = "0x5002E20", VA = "0x185004620")]
		public static void NNHCHCFNJFN<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData>(FBKJAGMDHMF GPHFNNBDCHL, global::NNAELPPPNEG<Entity> EMMPAJPIILL, out global::MBCDLMIAJND<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData> ADMDEPNJPGA) where ParentData : struct, IComponentData where PreviousParentData : struct, IComponentData, HELLHLLCKLJ where ParentRemovedTag : struct, IComponentData where ChildrenData : struct, IBufferElementData, HELLHLLCKLJ, IEquatable<ChildrenData>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000893")]
		[Cpp2IlInjected.Address(RVA = "0xBA39C0", Offset = "0xBA21C0", VA = "0x180BA39C0")]
		public static bool GCFHBANAJCI(BKIEEIBJMKG FMAOAOODAPP)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200014D")]
public class MBCDLMIAJND<ParentData, PreviousParentData, ParentRemovedTag, ChildrenData> where ParentData : struct, IComponentData where PreviousParentData : struct, IComponentData, HELLHLLCKLJ where ParentRemovedTag : struct, IComponentData where ChildrenData : struct, IBufferElementData, HELLHLLCKLJ, IEquatable<ChildrenData>
{
	[Cpp2IlInjected.Token(Token = "0x400043E")]
	private static readonly FLAFLKKHHEA APOHKGBDLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400043F")]
	private readonly HFEGCOONMAM LMKNNIPOPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000440")]
	private readonly global::MEBPHBGNBLO<Entity> IOADAIMHMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000441")]
	private readonly BAEDAPKGADH PNMJALNDJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000442")]
	private readonly NJFOBBNGILB CELKNCFBAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000443")]
	private readonly EntityManager FNBDEMCEOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000444")]
	private readonly EAEMBLGCFOG GBEJLJPMENI;

	[Cpp2IlInjected.Token(Token = "0x6000894")]
	[Cpp2IlInjected.Address(RVA = "0x588E6C0", Offset = "0x588CEC0", VA = "0x18588E6C0")]
	public MBCDLMIAJND(FBKJAGMDHMF GPHFNNBDCHL, global::NNAELPPPNEG<Entity> EMMPAJPIILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000895")]
	[Cpp2IlInjected.Address(RVA = "0x588D800", Offset = "0x588C000", VA = "0x18588D800")]
	private bool FJKJHLFHHBD(Entity NBIJCGHBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000896")]
	[Cpp2IlInjected.Address(RVA = "0x588D9F0", Offset = "0x588C1F0", VA = "0x18588D9F0")]
	private bool IOJEMNBFKHO(Entity NBIJCGHBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000897")]
	[Cpp2IlInjected.Address(RVA = "0x588D290", Offset = "0x588BA90", VA = "0x18588D290")]
	public bool AEGJIHGIKNL(Entity NBIJCGHBCCI, in Entity ACODEJEKDBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000898")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
	private static void CDDPDBOLPEP(Entity NBIJCGHBCCI, Entity ACODEJEKDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000899")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
	private static void KHCKMACNDEI(Entity NBIJCGHBCCI, Entity ACODEJEKDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089A")]
	[Cpp2IlInjected.Address(RVA = "0x588DEA0", Offset = "0x588C6A0", VA = "0x18588DEA0")]
	private bool MFEJJMDALEL(Entity NBIJCGHBCCI, Entity ELKNCMDOGDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600089B")]
	[Cpp2IlInjected.Address(RVA = "0x588DDC0", Offset = "0x588C5C0", VA = "0x18588DDC0")]
	private void KGEIEKOGBFL(Entity NBIJCGHBCCI, in Entity NHAJDPLICDA, in Entity ACODEJEKDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089C")]
	[Cpp2IlInjected.Address(RVA = "0x588D660", Offset = "0x588BE60", VA = "0x18588D660")]
	private void BEMCFOGGKAN(Entity NBIJCGHBCCI, in Entity NHAJDPLICDA, in Entity ACODEJEKDBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089D")]
	[Cpp2IlInjected.Address(RVA = "0x588DA40", Offset = "0x588C240", VA = "0x18588DA40")]
	private bool JHMJOGIDPOG(BHKCMBKKPEM KKGDKGFFJGP, in MCOCAFPBHKN BNGCEBIDMCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600089E")]
	[Cpp2IlInjected.Address(RVA = "0x588D8C0", Offset = "0x588C0C0", VA = "0x18588D8C0")]
	private void IEKKDDOONIC(Entity CELKNCFBAOE, Entity CPANDONOICF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600089F")]
	[Cpp2IlInjected.Address(RVA = "0x588E0E0", Offset = "0x588C8E0", VA = "0x18588E0E0")]
	private void MJKBAJJOIOF(Entity CELKNCFBAOE, Entity CPANDONOICF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A0")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
	private void HHPBJHCLCBP(Entity NBIJCGHBCCI, Entity NHAJDPLICDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008A1")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
	private void DFHGCIHBILO(Entity NBIJCGHBCCI, Entity ACODEJEKDBE)
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200014E")]
	[DOHCKPDOJMD(PAPAHBCPMGP.HierarchySystems)]
	[CEFINOONOIN(typeof(TransformOwnershipPhase), new string[] { })]
	internal sealed class TransformOwnershipPhase
	{
		[Cpp2IlInjected.Token(Token = "0x200014F")]
		public enum MMHGOBCKDCO
		{
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			Gameplay,
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			ObjectModel
		}

		[Cpp2IlInjected.Token(Token = "0x2000150")]
		public struct KGKIFODDFGI : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private MMHGOBCKDCO LPOGIMBFAND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			private readonly TransformOwnershipPhase CELKNCFBAOE;

			[Cpp2IlInjected.Token(Token = "0x60008AB")]
			[Cpp2IlInjected.Address(RVA = "0xB9C660", Offset = "0xB9AE60", VA = "0x180B9C660")]
			public KGKIFODDFGI(TransformOwnershipPhase CELKNCFBAOE, MMHGOBCKDCO AEAOEHCFFBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60008AC")]
			[Cpp2IlInjected.Address(RVA = "0xB9C640", Offset = "0xB9AE40", VA = "0x180B9C640", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		public MMHGOBCKDCO AEAOEHCFFBB;

		[Cpp2IlInjected.Token(Token = "0x170000F5")]
		public MMHGOBCKDCO CKACJHKKLPF
		{
			[Cpp2IlInjected.Token(Token = "0x60008A3")]
			[Cpp2IlInjected.Address(RVA = "0x6348F0", Offset = "0x6330F0", VA = "0x1806348F0")]
			get
			{
				return default(MMHGOBCKDCO);
			}
			[Cpp2IlInjected.Token(Token = "0x60008A4")]
			[Cpp2IlInjected.Address(RVA = "0x6AD150", Offset = "0x6AB950", VA = "0x1806AD150")]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F6")]
		public bool EPCBHNMFMEG
		{
			[Cpp2IlInjected.Token(Token = "0x60008A5")]
			[Cpp2IlInjected.Address(RVA = "0xBAB0B0", Offset = "0xBA98B0", VA = "0x180BAB0B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000F7")]
		public bool MDAAIOLJDNF
		{
			[Cpp2IlInjected.Token(Token = "0x60008A6")]
			[Cpp2IlInjected.Address(RVA = "0xBAB050", Offset = "0xBA9850", VA = "0x180BAB050")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008A7")]
		[Cpp2IlInjected.Address(RVA = "0xBAB000", Offset = "0xBA9800", VA = "0x180BAB000")]
		public KGKIFODDFGI CJGNONGLODJ()
		{
			return default(KGKIFODDFGI);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A8")]
		[Cpp2IlInjected.Address(RVA = "0xBAB060", Offset = "0xBA9860", VA = "0x180BAB060")]
		public KGKIFODDFGI MNFKPOGPMBN()
		{
			return default(KGKIFODDFGI);
		}

		[Cpp2IlInjected.Token(Token = "0x60008A9")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public TransformOwnershipPhase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000151")]
public struct MGHDJBPABNH : global::KDFMKIHLJFP<MGHDJBPABNH>, ECOGJIGKDHI, IEquatable<MGHDJBPABNH>
{
	[Cpp2IlInjected.Token(Token = "0x400044C")]
	public static readonly MGHDJBPABNH EOOIPOMJEJG;

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public int PDGADEKDACK
	{
		[Cpp2IlInjected.Token(Token = "0x60008AD")]
		[Cpp2IlInjected.Address(RVA = "0x7E9EC0", Offset = "0x7E86C0", VA = "0x1807E9EC0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008AE")]
		[Cpp2IlInjected.Address(RVA = "0x825F70", Offset = "0x824770", VA = "0x180825F70", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public int JLICIKJPFHO
	{
		[Cpp2IlInjected.Token(Token = "0x60008AF")]
		[Cpp2IlInjected.Address(RVA = "0xECE690", Offset = "0xECCE90", VA = "0x180ECE690", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60008B0")]
		[Cpp2IlInjected.Address(RVA = "0xF35920", Offset = "0xF34120", VA = "0x180F35920", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public bool CPNLIKCPMHB
	{
		[Cpp2IlInjected.Token(Token = "0x60008B1")]
		[Cpp2IlInjected.Address(RVA = "0x50D2000", Offset = "0x50D0800", VA = "0x1850D2000")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008B2")]
	[Cpp2IlInjected.Address(RVA = "0x50D2040", Offset = "0x50D0840", VA = "0x1850D2040", Slot = "8")]
	public bool Equals(MGHDJBPABNH ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B3")]
	[Cpp2IlInjected.Address(RVA = "0x50D2090", Offset = "0x50D0890", VA = "0x1850D2090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000152")]
public struct KHFDICEHOCC : IComponentData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400044F")]
	public MGHDJBPABNH LPPHLKEKIOC;
}
[Cpp2IlInjected.Token(Token = "0x2000153")]
internal struct BOEPDHDAEOH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000450")]
	private const int AJFIAKOMPDG = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000451")]
	private readonly Stack<HashSet<object>> HGCFNEKDDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000452")]
	private global::JPGJBKNMCEO<MGHDJBPABNH, HashSet<object>> CCKAEPEENHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000453")]
	private EntityManager FNBDEMCEOPA;

	[Cpp2IlInjected.Token(Token = "0x60008B5")]
	[Cpp2IlInjected.Address(RVA = "0x503F2F0", Offset = "0x503DAF0", VA = "0x18503F2F0")]
	public BOEPDHDAEOH(EntityManager FNBDEMCEOPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B6")]
	[Cpp2IlInjected.Address(RVA = "0x503EF70", Offset = "0x503D770", VA = "0x18503EF70")]
	public void KGEPALGALDH(Entity NBIJCGHBCCI, object HMOHICKINOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008B7")]
	[Cpp2IlInjected.Address(RVA = "0x503F130", Offset = "0x503D930", VA = "0x18503F130")]
	public bool MNFPKMAEIFA(Entity NBIJCGHBCCI, object HMOHICKINOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B8")]
	[Cpp2IlInjected.Address(RVA = "0x503F050", Offset = "0x503D850", VA = "0x18503F050")]
	public bool MKGJHKHJNAI(Entity NBIJCGHBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008B9")]
	[Cpp2IlInjected.Address(RVA = "0x503F090", Offset = "0x503D890", VA = "0x18503F090")]
	public bool MKGJHKHJNAI(MGHDJBPABNH LPPHLKEKIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BA")]
	[Cpp2IlInjected.Address(RVA = "0x503EDC0", Offset = "0x503D5C0", VA = "0x18503EDC0")]
	public bool EJJHDDFLHDF(Entity NBIJCGHBCCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BB")]
	[Cpp2IlInjected.Address(RVA = "0x503ED80", Offset = "0x503D580", VA = "0x18503ED80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BC")]
	[Cpp2IlInjected.Address(RVA = "0x503EE90", Offset = "0x503D690", VA = "0x18503EE90")]
	private void HPMGABHAFMB(HashSet<object> JDCFALKMNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BD")]
	[Cpp2IlInjected.Address(RVA = "0x503ECC0", Offset = "0x503D4C0", VA = "0x18503ECC0")]
	private bool CKMNBJPOLPD(Entity NBIJCGHBCCI, out MGHDJBPABNH LPPHLKEKIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008BE")]
	[Cpp2IlInjected.Address(RVA = "0x503F280", Offset = "0x503DA80", VA = "0x18503F280")]
	private void PFDAGHPAOCM(Entity NBIJCGHBCCI, MGHDJBPABNH LPPHLKEKIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008BF")]
	[Cpp2IlInjected.Address(RVA = "0x503EC60", Offset = "0x503D460", VA = "0x18503EC60")]
	private bool AJNOFMHECHA(MGHDJBPABNH CNEEFBBBHHM, out HashSet<object> JDCFALKMNHK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60008C0")]
	[Cpp2IlInjected.Address(RVA = "0x503EEF0", Offset = "0x503D6F0", VA = "0x18503EEF0")]
	private HashSet<object> JONMGIFIGLD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000154")]
[CEFINOONOIN(typeof(KCHBCAHHFGL), new string[] { })]
public sealed class KCHBCAHHFGL
{
	[Cpp2IlInjected.Token(Token = "0x14000017")]
	public event Action BOLCGLKMABO
	{
		[Cpp2IlInjected.Token(Token = "0x60008C1")]
		[Cpp2IlInjected.Address(RVA = "0x50CC2E0", Offset = "0x50CAAE0", VA = "0x1850CC2E0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60008C2")]
		[Cpp2IlInjected.Address(RVA = "0x50CC420", Offset = "0x50CAC20", VA = "0x1850CC420")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000018")]
	public event Action KDJKFADMENG
	{
		[Cpp2IlInjected.Token(Token = "0x60008C3")]
		[Cpp2IlInjected.Address(RVA = "0x50CC380", Offset = "0x50CAB80", VA = "0x1850CC380")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60008C4")]
		[Cpp2IlInjected.Address(RVA = "0x50CC4C0", Offset = "0x50CACC0", VA = "0x1850CC4C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60008C5")]
	[Cpp2IlInjected.Address(RVA = "0x66E150", Offset = "0x66C950", VA = "0x18066E150")]
	public void LDIEGIKKCKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C6")]
	[Cpp2IlInjected.Address(RVA = "0x7D4870", Offset = "0x7D3070", VA = "0x1807D4870")]
	public void IGOELCLADFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60008C7")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public KCHBCAHHFGL()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000155")]
	[DOHCKPDOJMD(PAPAHBCPMGP.Embodiment)]
	[CEFINOONOIN(typeof(ObjectEmbodimentService), new string[] { })]
	internal sealed class ObjectEmbodimentService : JIOLBCKAPBA, CMBMJNFKKCN, DKFAOOPHPAH, GHNBGLLDFLL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		private readonly Dictionary<MCOCAFPBHKN, NNCLEEGIIBK> LILFIMGGPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		private HFEGCOONMAM LMKNNIPOPLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private FOJPBIGOEBJ NLJLBCPPCEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		private HIPDIEDHHMJ CJCNOIMAAPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		private ENJAHHPPGPN AGONKCODOEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		private PMGBAPCJCOJ NEDNJICKCFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		private BOEPDHDAEOH CLAMJIPOBGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		private EntityHierarchyChildren DFGJAHNNJBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		private ObjectLifecycleService IGCMNAMAMMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		private TransformOwnershipPhase AEAOEHCFFBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		private bool NMANPNFCCCL;

		[Cpp2IlInjected.Token(Token = "0x170000FB")]
		private EntityManager BNFBCOAMLJO
		{
			[Cpp2IlInjected.Token(Token = "0x60008CC")]
			[Cpp2IlInjected.Address(RVA = "0xBA05A0", Offset = "0xB9EDA0", VA = "0x180BA05A0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FC")]
		public int JGMMMCHPMBF
		{
			[Cpp2IlInjected.Token(Token = "0x60008D1")]
			[Cpp2IlInjected.Address(RVA = "0xB9ED80", Offset = "0xB9D580", VA = "0x180B9ED80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000FD")]
		public int FOENCACNGPO
		{
			[Cpp2IlInjected.Token(Token = "0x60008D2")]
			[Cpp2IlInjected.Address(RVA = "0xBA0020", Offset = "0xB9E820", VA = "0x180BA0020")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000019")]
		public event Action<BKIEEIBJMKG> MPHHJDMGKOC
		{
			[Cpp2IlInjected.Token(Token = "0x60008C8")]
			[Cpp2IlInjected.Address(RVA = "0xB9FEA0", Offset = "0xB9E6A0", VA = "0x180B9FEA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008C9")]
			[Cpp2IlInjected.Address(RVA = "0xB9F2A0", Offset = "0xB9DAA0", VA = "0x180B9F2A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001A")]
		public event Action<BKIEEIBJMKG> KJKIDPLNJFM
		{
			[Cpp2IlInjected.Token(Token = "0x60008CA")]
			[Cpp2IlInjected.Address(RVA = "0xBA0500", Offset = "0xB9ED00", VA = "0x180BA0500")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008CB")]
			[Cpp2IlInjected.Address(RVA = "0xBA0110", Offset = "0xB9E910", VA = "0x180BA0110")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60008CD")]
		[Cpp2IlInjected.Address(RVA = "0xB9EF40", Offset = "0xB9D740", VA = "0x180B9EF40", Slot = "4")]
		public void FNNKDMJCDCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CE")]
		[Cpp2IlInjected.Address(RVA = "0xB9DE40", Offset = "0xB9C640", VA = "0x180B9DE40", Slot = "5")]
		public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008CF")]
		[Cpp2IlInjected.Address(RVA = "0xB9D580", Offset = "0xB9BD80", VA = "0x180B9D580", Slot = "6")]
		public void BCKGPNKBBNF(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D0")]
		[Cpp2IlInjected.Address(RVA = "0xB9DD00", Offset = "0xB9C500", VA = "0x180B9DD00", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008D3")]
		[Cpp2IlInjected.Address(RVA = "0xB9E6B0", Offset = "0xB9CEB0", VA = "0x180B9E6B0")]
		public bool EFONCEFNEJD(Entity NBIJCGHBCCI, Allocator DDJPHGFEOFF, out NativeList<Entity> GKCECDAODGM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D4")]
		[Cpp2IlInjected.Address(RVA = "0xB9DCC0", Offset = "0xB9C4C0", VA = "0x180B9DCC0")]
		public global::AFGHFELLGFP<Entity> DCPFLLLAOGE(Allocator DDJPHGFEOFF)
		{
			return default(global::AFGHFELLGFP<Entity>);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D5")]
		[Cpp2IlInjected.Address(RVA = "0xB9F170", Offset = "0xB9D970", VA = "0x180B9F170")]
		public bool GJPEFJBAECC(Entity NBIJCGHBCCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D6")]
		[Cpp2IlInjected.Address(RVA = "0xB9F230", Offset = "0xB9DA30", VA = "0x180B9F230")]
		public bool GOFIPHNJIDA(Entity NBIJCGHBCCI, out NNCLEEGIIBK MDLJNEBAIPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D7")]
		[Cpp2IlInjected.Address(RVA = "0xB9F190", Offset = "0xB9D990", VA = "0x180B9F190")]
		private bool GOFIPHNJIDA(Transform EOBPGPELLLJ, out NNCLEEGIIBK MDLJNEBAIPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D8")]
		[Cpp2IlInjected.Address(RVA = "0xBA05F0", Offset = "0xB9EDF0", VA = "0x180BA05F0")]
		internal bool PKHIPJOGPKL(Entity NBIJCGHBCCI, out ALOMAIDHFHJ MDLJNEBAIPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008D9")]
		[Cpp2IlInjected.Address(RVA = "0xBA01C0", Offset = "0xB9E9C0", VA = "0x180BA01C0")]
		private void KNGBMEOFNIL(Entity NBIJCGHBCCI, NNCLEEGIIBK MDLJNEBAIPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DA")]
		[Cpp2IlInjected.Address(RVA = "0xB9DB70", Offset = "0xB9C370", VA = "0x180B9DB70")]
		private bool CNKLLFMNFGN(Entity NBIJCGHBCCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DB")]
		[Cpp2IlInjected.Address(RVA = "0xB9DB90", Offset = "0xB9C390", VA = "0x180B9DB90")]
		public void DAFBLBFDDID(MCOCAFPBHKN GFKNINEELBB, NNCLEEGIIBK CDBBAPHDBIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008DC")]
		[Cpp2IlInjected.Address(RVA = "0xB9E5F0", Offset = "0xB9CDF0", VA = "0x180B9E5F0")]
		public bool EEFMFOLNGBH(Entity NBIJCGHBCCI, object HMOHICKINOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DD")]
		[Cpp2IlInjected.Address(RVA = "0xB9F540", Offset = "0xB9DD40", VA = "0x180B9F540")]
		public bool IFKIHNAEHAF(CFBEFPIPHOM LEPHKDIHJFD, object HMOHICKINOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DE")]
		[Cpp2IlInjected.Address(RVA = "0xB9FA40", Offset = "0xB9E240", VA = "0x180B9FA40")]
		public bool IFKIHNAEHAF(Entity NBIJCGHBCCI, [Optional] object HMOHICKINOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008DF")]
		[Cpp2IlInjected.Address(RVA = "0xB9FB30", Offset = "0xB9E330", VA = "0x180B9FB30")]
		public bool IFKIHNAEHAF(NNCLEEGIIBK FMAOAOODAPP, object HMOHICKINOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E0")]
		[Cpp2IlInjected.Address(RVA = "0xB9FF40", Offset = "0xB9E740", VA = "0x180B9FF40")]
		public bool JJECKBCFCLO(Entity NBIJCGHBCCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E1")]
		[Cpp2IlInjected.Address(RVA = "0xB9FFF0", Offset = "0xB9E7F0", VA = "0x180B9FFF0")]
		public bool JJECKBCFCLO(NNCLEEGIIBK MDLJNEBAIPD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E2")]
		[Cpp2IlInjected.Address(RVA = "0xB9F610", Offset = "0xB9DE10", VA = "0x180B9F610")]
		public bool IFKIHNAEHAF(NNCLEEGIIBK MDLJNEBAIPD, [Optional] object HMOHICKINOJ, bool PDHIMENFOOC = false, bool MPJHFOKDELN = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E3")]
		[Cpp2IlInjected.Address(RVA = "0xB9FB50", Offset = "0xB9E350", VA = "0x180B9FB50")]
		public Transform IIJCCMOMBPF(Entity NBIJCGHBCCI, [Optional] object HMOHICKINOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E4")]
		[Cpp2IlInjected.Address(RVA = "0xBA0040", Offset = "0xB9E840", VA = "0x180BA0040")]
		public bool KFAIBMCBPEJ(Entity NBIJCGHBCCI, out Transform EOBPGPELLLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008E5")]
		[Cpp2IlInjected.Address(RVA = "0xB9E880", Offset = "0xB9D080", VA = "0x180B9E880")]
		public NNCLEEGIIBK EIDBIEHIAEK(Entity NBIJCGHBCCI, [Optional] object HMOHICKINOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008E6")]
		[Cpp2IlInjected.Address(RVA = "0xB9D6B0", Offset = "0xB9BEB0", VA = "0x180B9D6B0")]
		public void BDEKACCGGFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E7")]
		[Cpp2IlInjected.Address(RVA = "0xB9E2C0", Offset = "0xB9CAC0", VA = "0x180B9E2C0")]
		public void EBHLMLIDFKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E8")]
		[Cpp2IlInjected.Address(RVA = "0xB9E020", Offset = "0xB9C820", VA = "0x180B9E020")]
		private void EAHIKCJEHAI(Entity NBIJCGHBCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008E9")]
		[Cpp2IlInjected.Address(RVA = "0xB9D8D0", Offset = "0xB9C0D0", VA = "0x180B9D8D0")]
		public NNCLEEGIIBK BIELPEBHOHB(Entity NBIJCGHBCCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008EA")]
		[Cpp2IlInjected.Address(RVA = "0xBA01B0", Offset = "0xB9E9B0", VA = "0x180BA01B0")]
		public void KGEPALGALDH(Entity NBIJCGHBCCI, object HMOHICKINOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008EB")]
		[Cpp2IlInjected.Address(RVA = "0xBA04F0", Offset = "0xB9ECF0", VA = "0x180BA04F0")]
		public bool MNFPKMAEIFA(Entity NBIJCGHBCCI, object HMOHICKINOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EC")]
		[Cpp2IlInjected.Address(RVA = "0xB9E950", Offset = "0xB9D150", VA = "0x180B9E950")]
		public bool EJJHDDFLHDF(Entity NBIJCGHBCCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008ED")]
		[Cpp2IlInjected.Address(RVA = "0xBA04E0", Offset = "0xB9ECE0", VA = "0x180BA04E0")]
		public bool MKGJHKHJNAI(Entity NBIJCGHBCCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EE")]
		[Cpp2IlInjected.Address(RVA = "0xBA04D0", Offset = "0xB9ECD0", VA = "0x180BA04D0")]
		public bool MKGJHKHJNAI(MGHDJBPABNH LPPHLKEKIOC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008EF")]
		[Cpp2IlInjected.Address(RVA = "0xB9FD50", Offset = "0xB9E550", VA = "0x180B9FD50")]
		private void IOEHNECNHIJ(bool CPFLBAIJAMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F0")]
		[Cpp2IlInjected.Address(RVA = "0xB9D4F0", Offset = "0xB9BCF0", VA = "0x180B9D4F0")]
		private bool AAEPGINHIOD(Entity NBIJCGHBCCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60008F1")]
		[Cpp2IlInjected.Address(RVA = "0xBA0250", Offset = "0xB9EA50", VA = "0x180BA0250")]
		private NNCLEEGIIBK MEBDFGNBNCD(Entity NBIJCGHBCCI, object HMOHICKINOJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F2")]
		[Cpp2IlInjected.Address(RVA = "0xB9EDA0", Offset = "0xB9D5A0", VA = "0x180B9EDA0")]
		private NNCLEEGIIBK FJBPAHCCHBD(Entity NBIJCGHBCCI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60008F3")]
		[Cpp2IlInjected.Address(RVA = "0xBA02C0", Offset = "0xB9EAC0", VA = "0x180BA02C0")]
		private (Vector3, Quaternion, Vector3) MEBONIEAAAB(Entity NBIJCGHBCCI)
		{
			return default((Vector3, Quaternion, Vector3));
		}

		[Cpp2IlInjected.Token(Token = "0x60008F4")]
		[Cpp2IlInjected.Address(RVA = "0xB9F340", Offset = "0xB9DB40", VA = "0x180B9F340")]
		private void HGILELMKIGP(Entity NBIJCGHBCCI, HEIIJIHIAKK GPMEIOIEDNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F5")]
		[Cpp2IlInjected.Address(RVA = "0xB9D920", Offset = "0xB9C120", VA = "0x180B9D920")]
		private void CFCKIMNCGJM(CFBEFPIPHOM LEPHKDIHJFD, NNCLEEGIIBK CDBBAPHDBIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F6")]
		[Cpp2IlInjected.Address(RVA = "0xB9E960", Offset = "0xB9D160", VA = "0x180B9E960")]
		private void EKGOAEEDEJI(NNCLEEGIIBK MDLJNEBAIPD, Entity NBIJCGHBCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F7")]
		[Cpp2IlInjected.Address(RVA = "0xB9EF50", Offset = "0xB9D750", VA = "0x180B9EF50")]
		private void GJJEBAFMMFG(Entity NBIJCGHBCCI, NNCLEEGIIBK MDLJNEBAIPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F8")]
		[Cpp2IlInjected.Address(RVA = "0xB9F430", Offset = "0xB9DC30", VA = "0x180B9F430")]
		private void IAFCKGNKLLG(Entity NBIJCGHBCCI, Transform EOBPGPELLLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008F9")]
		[Cpp2IlInjected.Address(RVA = "0xB9F510", Offset = "0xB9DD10", VA = "0x180B9F510")]
		private CFBEFPIPHOM IFFHGDLJNGC(Entity NBIJCGHBCCI)
		{
			return default(CFBEFPIPHOM);
		}

		[Cpp2IlInjected.Token(Token = "0x60008FA")]
		[Cpp2IlInjected.Address(RVA = "0xBA0660", Offset = "0xB9EE60", VA = "0x180BA0660")]
		public ObjectEmbodimentService()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60008FC")]
		[Cpp2IlInjected.Address(RVA = "0xB9DAC0", Offset = "0xB9C2C0", VA = "0x180B9DAC0")]
		[CompilerGenerated]
		private void CKDDKOADFLG()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000156")]
internal static class KKENCNDHDAP
{
	[Cpp2IlInjected.Token(Token = "0x60008FD")]
	[Cpp2IlInjected.Address(RVA = "0x50CE530", Offset = "0x50CCD30", VA = "0x1850CE530")]
	public static NNCLEEGIIBK EIDBIEHIAEK(this ObjectEmbodimentService DMLIGOGCPEG, CFBEFPIPHOM LEPHKDIHJFD, [Optional] object HMOHICKINOJ)
	{
		return null;
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x2000157")]
	[CEFINOONOIN(typeof(ObjectLifecycleService), new string[] { })]
	[DOHCKPDOJMD(PAPAHBCPMGP.Lifecycle)]
	internal sealed class ObjectLifecycleService : DKFAOOPHPAH
	{
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		private HFEGCOONMAM JLFJGJMGNNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		private ObjectEmbodimentService MDLJNEBAIPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private ObjectNetworkToLocalMapService FFAFHLPEJGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		private EntityHierarchyChildren DFGJAHNNJBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		private EBPKDLGCKDG DJMDBGODMGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		private EntityHierarchyParents GJNHJKBKEON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		private MNOEFBHDEDM EBJALBJNJHM;

		[Cpp2IlInjected.Token(Token = "0x170000FE")]
		private EntityManager BNFBCOAMLJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000902")]
			[Cpp2IlInjected.Address(RVA = "0xBA14E0", Offset = "0xB9FCE0", VA = "0x180BA14E0")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001B")]
		public event Action<Entity, HEIIJIHIAKK> HLDCKKIBNFH
		{
			[Cpp2IlInjected.Token(Token = "0x60008FE")]
			[Cpp2IlInjected.Address(RVA = "0xBA06D0", Offset = "0xB9EED0", VA = "0x180BA06D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60008FF")]
			[Cpp2IlInjected.Address(RVA = "0xBA11E0", Offset = "0xB9F9E0", VA = "0x180BA11E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001C")]
		public event Action<Entity> PPMNIDEBOPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000900")]
			[Cpp2IlInjected.Address(RVA = "0xBA0800", Offset = "0xB9F000", VA = "0x180BA0800")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000901")]
			[Cpp2IlInjected.Address(RVA = "0xBA0D30", Offset = "0xB9F530", VA = "0x180BA0D30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000903")]
		[Cpp2IlInjected.Address(RVA = "0xBA0C10", Offset = "0xB9F410", VA = "0x180BA0C10", Slot = "4")]
		public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000904")]
		[Cpp2IlInjected.Address(RVA = "0xBA1460", Offset = "0xB9FC60", VA = "0x180BA1460")]
		public bool NKBMJECLOCI(Entity NBIJCGHBCCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000905")]
		[Cpp2IlInjected.Address(RVA = "0xBA1180", Offset = "0xB9F980", VA = "0x180BA1180")]
		internal void JKJOPIFMNND(Entity NBIJCGHBCCI, HEIIJIHIAKK GPMEIOIEDNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000906")]
		[Cpp2IlInjected.Address(RVA = "0xBA0770", Offset = "0xB9EF70", VA = "0x180BA0770")]
		public void APJLKFMLABG(Entity NBIJCGHBCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000907")]
		[Cpp2IlInjected.Address(RVA = "0xBA1280", Offset = "0xB9FA80", VA = "0x180BA1280")]
		public void LIPJKPPEBGH(Entity NBIJCGHBCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000908")]
		[Cpp2IlInjected.Address(RVA = "0xBA08D0", Offset = "0xB9F0D0", VA = "0x180BA08D0")]
		private bool COKHIAMIDJI(Entity NBIJCGHBCCI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000909")]
		[Cpp2IlInjected.Address(RVA = "0xBA13C0", Offset = "0xB9FBC0", VA = "0x180BA13C0")]
		public void NAPPOONKJCM(Entity NBIJCGHBCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090A")]
		[Cpp2IlInjected.Address(RVA = "0xBA08A0", Offset = "0xB9F0A0", VA = "0x180BA08A0")]
		private void CMLNKBEBFNA(Entity NBIJCGHBCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090B")]
		[Cpp2IlInjected.Address(RVA = "0xBA0A00", Offset = "0xB9F200", VA = "0x180BA0A00")]
		private void DILFKHHLMHC(Entity NBIJCGHBCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090C")]
		[Cpp2IlInjected.Address(RVA = "0xBA0DD0", Offset = "0xB9F5D0", VA = "0x180BA0DD0")]
		private void HFILMONCALO(Entity NBIJCGHBCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090D")]
		[Cpp2IlInjected.Address(RVA = "0xBA1040", Offset = "0xB9F840", VA = "0x180BA1040")]
		private void HGJJGOJLGPH(Entity NBIJCGHBCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600090E")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public ObjectLifecycleService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000158")]
	[CEFINOONOIN(typeof(ObjectNetworkToLocalMapService), new string[] { })]
	[DOHCKPDOJMD(PAPAHBCPMGP.Embodiment)]
	internal sealed class ObjectNetworkToLocalMapService : DKFAOOPHPAH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		private NativeHashMap<MCOCAFPBHKN, Entity> FHDLMDMONFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		private HFEGCOONMAM JLFJGJMGNNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private FOJPBIGOEBJ NLJLBCPPCEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		private EntityManager FNBDEMCEOPA;

		[Cpp2IlInjected.Token(Token = "0x170000FF")]
		internal NativeHashMap<MCOCAFPBHKN, Entity> LEKPNNLMKCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000911")]
			[Cpp2IlInjected.Address(RVA = "0x6ABEC0", Offset = "0x6AA6C0", VA = "0x1806ABEC0")]
			get
			{
				return default(NativeHashMap<MCOCAFPBHKN, Entity>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000910")]
		[Cpp2IlInjected.Address(RVA = "0xBA16D0", Offset = "0xB9FED0", VA = "0x180BA16D0", Slot = "4")]
		public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000912")]
		[Cpp2IlInjected.Address(RVA = "0xBA1670", Offset = "0xB9FE70", VA = "0x180BA1670", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000913")]
		[Cpp2IlInjected.Address(RVA = "0xBA1870", Offset = "0xBA0070", VA = "0x180BA1870")]
		public void IDPJIGKEBOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000914")]
		[Cpp2IlInjected.Address(RVA = "0xBA18D0", Offset = "0xBA00D0", VA = "0x180BA18D0")]
		private CFBEFPIPHOM IFFHGDLJNGC(Entity NBIJCGHBCCI)
		{
			return default(CFBEFPIPHOM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000915")]
		[Cpp2IlInjected.Address(RVA = "0xBA19F0", Offset = "0xBA01F0", VA = "0x180BA19F0")]
		public CFBEFPIPHOM PGAAHFGOMDE(MCOCAFPBHKN GFKNINEELBB)
		{
			return default(CFBEFPIPHOM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000916")]
		[Cpp2IlInjected.Address(RVA = "0xBA15E0", Offset = "0xB9FDE0", VA = "0x180BA15E0")]
		public MCOCAFPBHKN DCDNMCENJCL(CFBEFPIPHOM LEPHKDIHJFD)
		{
			return default(MCOCAFPBHKN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000917")]
		[Cpp2IlInjected.Address(RVA = "0xBA1900", Offset = "0xBA0100", VA = "0x180BA1900")]
		public void NKGKHPGGDDC(Entity NBIJCGHBCCI, MCOCAFPBHKN GFKNINEELBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000918")]
		[Cpp2IlInjected.Address(RVA = "0xBA1580", Offset = "0xB9FD80", VA = "0x180BA1580")]
		public void ADBAJPJMBEB(Entity NBIJCGHBCCI, MCOCAFPBHKN GFKNINEELBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000919")]
		[Cpp2IlInjected.Address(RVA = "0xBA1990", Offset = "0xBA0190", VA = "0x180BA1990")]
		public void ONDBOJNGJPL(Entity NBIJCGHBCCI, MCOCAFPBHKN GFKNINEELBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091A")]
		[Cpp2IlInjected.Address(RVA = "0xBA17A0", Offset = "0xB9FFA0", VA = "0x180BA17A0")]
		public void GCGGKFGGMBO(Entity NBIJCGHBCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600091B")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public ObjectNetworkToLocalMapService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000159")]
internal class ACGPMACANDK : HHLKFPHIIHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public OPOFEEJKEHN LDJOOEHHAGL
	{
		[Cpp2IlInjected.Token(Token = "0x600091D")]
		[Cpp2IlInjected.Address(RVA = "0x5039440", Offset = "0x5037C40", VA = "0x185039440", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(OPOFEEJKEHN);
		}
		[Cpp2IlInjected.Token(Token = "0x600091E")]
		[Cpp2IlInjected.Address(RVA = "0x5039820", Offset = "0x5038020", VA = "0x185039820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public OPOFEEJKEHN FPMAIGNHONC
	{
		[Cpp2IlInjected.Token(Token = "0x600091F")]
		[Cpp2IlInjected.Address(RVA = "0x5039580", Offset = "0x5037D80", VA = "0x185039580", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return default(OPOFEEJKEHN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000920")]
		[Cpp2IlInjected.Address(RVA = "0x5039960", Offset = "0x5038160", VA = "0x185039960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public OPOFEEJKEHN ABJEHADIIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000921")]
		[Cpp2IlInjected.Address(RVA = "0x50392F0", Offset = "0x5037AF0", VA = "0x1850392F0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return default(OPOFEEJKEHN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000922")]
		[Cpp2IlInjected.Address(RVA = "0x50397B0", Offset = "0x5037FB0", VA = "0x1850397B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public OPOFEEJKEHN OGILJAMNEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000923")]
		[Cpp2IlInjected.Address(RVA = "0x50398F0", Offset = "0x50380F0", VA = "0x1850398F0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(OPOFEEJKEHN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000924")]
		[Cpp2IlInjected.Address(RVA = "0x50399D0", Offset = "0x50381D0", VA = "0x1850399D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public OPOFEEJKEHN INOGJGEAGAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000925")]
		[Cpp2IlInjected.Address(RVA = "0x5039510", Offset = "0x5037D10", VA = "0x185039510", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return default(OPOFEEJKEHN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000926")]
		[Cpp2IlInjected.Address(RVA = "0x50395F0", Offset = "0x5037DF0", VA = "0x1850395F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public OPOFEEJKEHN BOLDNKJIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000927")]
		[Cpp2IlInjected.Address(RVA = "0x50396D0", Offset = "0x5037ED0", VA = "0x1850396D0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return default(OPOFEEJKEHN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000928")]
		[Cpp2IlInjected.Address(RVA = "0x5039660", Offset = "0x5037E60", VA = "0x185039660")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public OPOFEEJKEHN FPOBJIHOLNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000929")]
		[Cpp2IlInjected.Address(RVA = "0x5039880", Offset = "0x5038080", VA = "0x185039880", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(OPOFEEJKEHN);
		}
		[Cpp2IlInjected.Token(Token = "0x600092A")]
		[Cpp2IlInjected.Address(RVA = "0x5039AB0", Offset = "0x50382B0", VA = "0x185039AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public OPOFEEJKEHN LAGDIGCBPGE
	{
		[Cpp2IlInjected.Token(Token = "0x600092B")]
		[Cpp2IlInjected.Address(RVA = "0x5039360", Offset = "0x5037B60", VA = "0x185039360", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(OPOFEEJKEHN);
		}
		[Cpp2IlInjected.Token(Token = "0x600092C")]
		[Cpp2IlInjected.Address(RVA = "0x5039A40", Offset = "0x5038240", VA = "0x185039A40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public OPOFEEJKEHN NNMMLOOPHJH
	{
		[Cpp2IlInjected.Token(Token = "0x600092D")]
		[Cpp2IlInjected.Address(RVA = "0x50393D0", Offset = "0x5037BD0", VA = "0x1850393D0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return default(OPOFEEJKEHN);
		}
		[Cpp2IlInjected.Token(Token = "0x600092E")]
		[Cpp2IlInjected.Address(RVA = "0x5039B20", Offset = "0x5038320", VA = "0x185039B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public OPOFEEJKEHN OODHDGIBPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600092F")]
		[Cpp2IlInjected.Address(RVA = "0x5039740", Offset = "0x5037F40", VA = "0x185039740", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(OPOFEEJKEHN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000930")]
		[Cpp2IlInjected.Address(RVA = "0x50394A0", Offset = "0x5037CA0", VA = "0x1850394A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000931")]
	[Cpp2IlInjected.Address(RVA = "0x5039B90", Offset = "0x5038390", VA = "0x185039B90")]
	public ACGPMACANDK()
	{
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[Cpp2IlInjected.Token(Token = "0x200015A")]
	[DOHCKPDOJMD(PAPAHBCPMGP.Prefabs)]
	[CEFINOONOIN(typeof(ObjectPrefabCreationService), new string[] { })]
	[OJBFCHOEMHJ(typeof(HFEGCOONMAM))]
	internal sealed class ObjectPrefabCreationService : JIOLBCKAPBA, CMBMJNFKKCN, DKFAOOPHPAH, GHNBGLLDFLL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		private HFEGCOONMAM LMKNNIPOPLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		private IDCKAKEMNNI LBGONHBJAMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		private ABEBEECDLPD LPEKJEIBENC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		private ObjectNetworkToLocalMapService FFAFHLPEJGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		private ObjectLifecycleService IGCMNAMAMMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private ObjectPrefabs PCNDCGBMEJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		private AKFDHJFDBOF PEHPBMJEKFF;

		[Cpp2IlInjected.Token(Token = "0x1700010A")]
		public int HKCLANABCJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000945")]
			[Cpp2IlInjected.Address(RVA = "0xBA1E50", Offset = "0xBA0650", VA = "0x180BA1E50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000932")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "4")]
		public void FNNKDMJCDCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000933")]
		[Cpp2IlInjected.Address(RVA = "0xBA1CE0", Offset = "0xBA04E0", VA = "0x180BA1CE0", Slot = "5")]
		public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000934")]
		[Cpp2IlInjected.Address(RVA = "0xBA1B40", Offset = "0xBA0340", VA = "0x180BA1B40", Slot = "6")]
		public void BCKGPNKBBNF(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000935")]
		[Cpp2IlInjected.Address(RVA = "0xBA1C30", Offset = "0xBA0430", VA = "0x180BA1C30", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000936")]
		[Cpp2IlInjected.Address(RVA = "0xBA1B10", Offset = "0xBA0310", VA = "0x180BA1B10")]
		private void AAEKOINAAAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000937")]
		[Cpp2IlInjected.Address(RVA = "0xBA1FD0", Offset = "0xBA07D0", VA = "0x180BA1FD0")]
		public void MAGAKDECEJI(bool PDHIMENFOOC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000938")]
		[Cpp2IlInjected.Address(RVA = "0xBA1B10", Offset = "0xBA0310", VA = "0x180BA1B10")]
		private void MHCDKCFFKAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000939")]
		[Cpp2IlInjected.Address(RVA = "0xBA1EA0", Offset = "0xBA06A0", VA = "0x180BA1EA0")]
		public Entity ODJPPNHBFCL(HEIIJIHIAKK GPMEIOIEDNN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093A")]
		[Cpp2IlInjected.Address(RVA = "0xBA21C0", Offset = "0xBA09C0", VA = "0x180BA21C0")]
		public Entity ODJPPNHBFCL(HEIIJIHIAKK GPMEIOIEDNN, MCOCAFPBHKN GFKNINEELBB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093B")]
		[Cpp2IlInjected.Address(RVA = "0xBA1E30", Offset = "0xBA0630", VA = "0x180BA1E30")]
		public Entity FNHIIMHAIEO(HEIIJIHIAKK GPMEIOIEDNN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093C")]
		[Cpp2IlInjected.Address(RVA = "0xBA1F30", Offset = "0xBA0730", VA = "0x180BA1F30")]
		public Entity KLLAAEAJMPK(MCOCAFPBHKN GFKNINEELBB, HEIIJIHIAKK GPMEIOIEDNN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093D")]
		[Cpp2IlInjected.Address(RVA = "0xBA1EA0", Offset = "0xBA06A0", VA = "0x180BA1EA0")]
		public Entity JDCINKDFFNF(HEIIJIHIAKK GPMEIOIEDNN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093E")]
		[Cpp2IlInjected.Address(RVA = "0xBA20A0", Offset = "0xBA08A0", VA = "0x180BA20A0")]
		public Entity NBMMMGOIFIH()
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600093F")]
		[Cpp2IlInjected.Address(RVA = "0xBA2370", Offset = "0xBA0B70", VA = "0x180BA2370")]
		public Entity OECKONEOFKD(JPMNNMNBHIP BKDBLJPNPPJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000940")]
		[Cpp2IlInjected.Address(RVA = "0xBA20E0", Offset = "0xBA08E0", VA = "0x180BA20E0")]
		public Entity NHAIFAADBOP(HALBGGLKEOJ BKDBLJPNPPJ)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000941")]
		[Cpp2IlInjected.Address(RVA = "0xBA2170", Offset = "0xBA0970", VA = "0x180BA2170")]
		public NativeArray<(CFBEFPIPHOM, CFBEFPIPHOM)> ODJPPNHBFCL(NativeArray<CFBEFPIPHOM> OMHJJDKCAJM, Allocator DDJPHGFEOFF)
		{
			return default(NativeArray<(CFBEFPIPHOM, CFBEFPIPHOM)>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000942")]
		[Cpp2IlInjected.Address(RVA = "0xBA1EE0", Offset = "0xBA06E0", VA = "0x180BA1EE0")]
		public IEnumerable<HEIIJIHIAKK> KGKCGGFEFFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000943")]
		[Cpp2IlInjected.Address(RVA = "0xBA1BD0", Offset = "0xBA03D0", VA = "0x180BA1BD0")]
		public EntityArchetype BKHIJDBFACL(HEIIJIHIAKK GPMEIOIEDNN)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000944")]
		[Cpp2IlInjected.Address(RVA = "0xBA2400", Offset = "0xBA0C00", VA = "0x180BA2400")]
		public Entity OHNBILCKKDO(HEIIJIHIAKK GPMEIOIEDNN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000946")]
		[Cpp2IlInjected.Address(RVA = "0xBA2260", Offset = "0xBA0A60", VA = "0x180BA2260")]
		private Entity ODOCCOKKKLA(HEIIJIHIAKK GPMEIOIEDNN, MCOCAFPBHKN GFKNINEELBB)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000947")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public ObjectPrefabCreationService()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015B")]
	[DOHCKPDOJMD(PAPAHBCPMGP.Prefabs)]
	internal class ObjectPrefabs : CNOLGAFBLHG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200015C")]
		[CompilerGenerated]
		private sealed class JKMEHPIKCNF : IEnumerable<(JPMNNMNBHIP, HEIIJIHIAKK)>, IEnumerable, IEnumerator<(JPMNNMNBHIP, HEIIJIHIAKK)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			private (JPMNNMNBHIP primitiveType, HEIIJIHIAKK prefabType) <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			public ObjectPrefabs <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000490")]
			private int <i>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700010E")]
			private (JPMNNMNBHIP, HEIIJIHIAKK) System.Collections.Generic.IEnumerator<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000961")]
				[Cpp2IlInjected.Address(RVA = "0xB9C480", Offset = "0xB9AC80", VA = "0x180B9C480", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((JPMNNMNBHIP, HEIIJIHIAKK));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700010F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000963")]
				[Cpp2IlInjected.Address(RVA = "0xB9C4E0", Offset = "0xB9ACE0", VA = "0x180B9C4E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600095E")]
			[Cpp2IlInjected.Address(RVA = "0xB9C530", Offset = "0xB9AD30", VA = "0x180B9C530")]
			[DebuggerHidden]
			public JKMEHPIKCNF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600095F")]
			[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000960")]
			[Cpp2IlInjected.Address(RVA = "0xB9C2F0", Offset = "0xB9AAF0", VA = "0x180B9C2F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000962")]
			[Cpp2IlInjected.Address(RVA = "0xB9C490", Offset = "0xB9AC90", VA = "0x180B9C490", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000964")]
			[Cpp2IlInjected.Address(RVA = "0xB9C3E0", Offset = "0xB9ABE0", VA = "0x180B9C3E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(JPMNNMNBHIP, HEIIJIHIAKK)> System.Collections.Generic.IEnumerable<(RecRoom.Components.PrimitiveShapeTypeprimitiveType,RecRoom.Components.ObjectPrefabTypeprefabType)>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000965")]
			[Cpp2IlInjected.Address(RVA = "0xB9C3E0", Offset = "0xB9ABE0", VA = "0x180B9C3E0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000485")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private readonly World LMKNNIPOPLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		private readonly Dictionary<HEIIJIHIAKK, Entity> PCNDCGBMEJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		private readonly Dictionary<HEIIJIHIAKK, EntityArchetype> NBDHPEDKEIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		private readonly ACGPMACANDK KMNAFDDELMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private readonly Dictionary<JPMNNMNBHIP, HEIIJIHIAKK> APPDMOFBGHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private readonly Dictionary<HALBGGLKEOJ, HEIIJIHIAKK> LODFNDCCJIF;

		[Cpp2IlInjected.Token(Token = "0x1700010B")]
		private HHLKFPHIIHJ FLJHEAAJADH
		{
			[Cpp2IlInjected.Token(Token = "0x6000949")]
			[Cpp2IlInjected.Address(RVA = "0x6186A0", Offset = "0x616EA0", VA = "0x1806186A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010C")]
		public int KKHILPEBPDN
		{
			[Cpp2IlInjected.Token(Token = "0x600094A")]
			[Cpp2IlInjected.Address(RVA = "0xBA3070", Offset = "0xBA1870", VA = "0x180BA3070")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700010D")]
		public EntityManager BNFBCOAMLJO
		{
			[Cpp2IlInjected.Token(Token = "0x600094B")]
			[Cpp2IlInjected.Address(RVA = "0xBA3230", Offset = "0xBA1A30", VA = "0x180BA3230")]
			get
			{
				return default(EntityManager);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600094C")]
		[Cpp2IlInjected.Address(RVA = "0xBA34A0", Offset = "0xBA1CA0", VA = "0x180BA34A0")]
		public ObjectPrefabs(World LMKNNIPOPLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094D")]
		[Cpp2IlInjected.Address(RVA = "0xBA2D40", Offset = "0xBA1540", VA = "0x180BA2D40")]
		private void HIHACLCPFGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600094E")]
		[Cpp2IlInjected.Address(RVA = "0xBA30C0", Offset = "0xBA18C0", VA = "0x180BA30C0")]
		internal IEnumerable<Type> NBENHANPNAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600094F")]
		[Cpp2IlInjected.Address(RVA = "0xBA28C0", Offset = "0xBA10C0", VA = "0x180BA28C0")]
		internal ILCNCEAHGGK FFNLJDDIKNA(Type BKDBLJPNPPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000950")]
		[Cpp2IlInjected.Address(RVA = "0xBA2930", Offset = "0xBA1130", VA = "0x180BA2930")]
		internal void GANFPEFBPEA(ILCNCEAHGGK CGMHPKFHPLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000951")]
		[Cpp2IlInjected.Address(RVA = "0xBA3250", Offset = "0xBA1A50", VA = "0x180BA3250")]
		internal void POCBNBJKHJL(HEIIJIHIAKK GPMEIOIEDNN, OPOFEEJKEHN ENJGIKMGHIH, NNPGLOAGMMA GGNFDJDDIJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000952")]
		[Cpp2IlInjected.Address(RVA = "0xBA2790", Offset = "0xBA0F90", VA = "0x180BA2790")]
		private void EEHICIDFHLF(HEIIJIHIAKK GPMEIOIEDNN, OPOFEEJKEHN COMKKLEOPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000953")]
		[Cpp2IlInjected.Address(RVA = "0xBA3050", Offset = "0xBA1850", VA = "0x180BA3050")]
		public void MAGAKDECEJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000954")]
		[Cpp2IlInjected.Address(RVA = "0xBA24B0", Offset = "0xBA0CB0", VA = "0x180BA24B0")]
		public EntityArchetype BKHIJDBFACL(HEIIJIHIAKK GPMEIOIEDNN)
		{
			return default(EntityArchetype);
		}

		[Cpp2IlInjected.Token(Token = "0x6000955")]
		[Cpp2IlInjected.Address(RVA = "0xBA2CD0", Offset = "0xBA14D0", VA = "0x180BA2CD0", Slot = "4")]
		[IteratorStateMachine(typeof(JKMEHPIKCNF))]
		public IEnumerable<(JPMNNMNBHIP, HEIIJIHIAKK)> GGPHKFEJFLB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000956")]
		[Cpp2IlInjected.Address(RVA = "0xBA30F0", Offset = "0xBA18F0", VA = "0x180BA30F0")]
		public Entity ODJPPNHBFCL(HEIIJIHIAKK GPMEIOIEDNN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x6000957")]
		[Cpp2IlInjected.Address(RVA = "0xBA2FA0", Offset = "0xBA17A0", VA = "0x180BA2FA0")]
		public HEIIJIHIAKK IILOCACPEEL(HALBGGLKEOJ BKDBLJPNPPJ)
		{
			return default(HEIIJIHIAKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000958")]
		[Cpp2IlInjected.Address(RVA = "0xBA2F40", Offset = "0xBA1740", VA = "0x180BA2F40")]
		public HEIIJIHIAKK IILOCACPEEL(JPMNNMNBHIP BKDBLJPNPPJ)
		{
			return default(HEIIJIHIAKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000959")]
		[Cpp2IlInjected.Address(RVA = "0xBA2610", Offset = "0xBA0E10", VA = "0x180BA2610", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600095A")]
		[Cpp2IlInjected.Address(RVA = "0xBA3000", Offset = "0xBA1800", VA = "0x180BA3000")]
		public IEnumerable<HEIIJIHIAKK> KGKCGGFEFFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600095B")]
		[Cpp2IlInjected.Address(RVA = "0xBA31D0", Offset = "0xBA19D0", VA = "0x180BA31D0")]
		public Entity OHNBILCKKDO(HEIIJIHIAKK GPMEIOIEDNN)
		{
			return default(Entity);
		}

		[Cpp2IlInjected.Token(Token = "0x600095C")]
		[Cpp2IlInjected.Address(RVA = "0xBA2510", Offset = "0xBA0D10", VA = "0x180BA2510")]
		internal Entity DMJILBAENPM(HEIIJIHIAKK GPMEIOIEDNN)
		{
			return default(Entity);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200015D")]
	[CEFINOONOIN(typeof(PropertyEventCallbacksService), new string[] { })]
	[DOHCKPDOJMD(PAPAHBCPMGP.Callbacks)]
	public class PropertyEventCallbacksService : DKFAOOPHPAH
	{
		[Cpp2IlInjected.Token(Token = "0x200015E")]
		private struct CFKICEFLIDH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public MMOGHBPNOMP LABDBOEIJFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public Type BKDBLJPNPPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			public int OCAKIKBDFGC;
		}

		[Cpp2IlInjected.Token(Token = "0x200015F")]
		private struct BDOPFPGLKNB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			public CFKICEFLIDH[] AFJGLEGGBOF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000160")]
		public delegate void MMOGHBPNOMP(Entity NBIJCGHBCCI, MIPCILJMDGJ KBHHIDGOLNC, BJHFEKKLKGB JCEACLPGDMD, BJHFEKKLKGB CMJHENLPPFE);

		[Cpp2IlInjected.Token(Token = "0x4000491")]
		private static readonly FLAFLKKHHEA APOHKGBDLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		private readonly Dictionary<MIPCILJMDGJ, MMOGHBPNOMP> FGMONMHEOEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		private readonly Dictionary<int, BDOPFPGLKNB> IFEEGEDFINF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		private FBFMOHPHODB AFJGLEGGBOF;

		[Cpp2IlInjected.Token(Token = "0x1400001D")]
		public event Action CCDIMBODMPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000966")]
			[Cpp2IlInjected.Address(RVA = "0xBA7DF0", Offset = "0xBA65F0", VA = "0x180BA7DF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000967")]
			[Cpp2IlInjected.Address(RVA = "0xBA7E90", Offset = "0xBA6690", VA = "0x180BA7E90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1400001E")]
		public event Action DKHFGCDHICM
		{
			[Cpp2IlInjected.Token(Token = "0x6000968")]
			[Cpp2IlInjected.Address(RVA = "0xBA8160", Offset = "0xBA6960", VA = "0x180BA8160")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000969")]
			[Cpp2IlInjected.Address(RVA = "0xBA7880", Offset = "0xBA6080", VA = "0x180BA7880")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600096A")]
		[Cpp2IlInjected.Address(RVA = "0xBA7920", Offset = "0xBA6120", VA = "0x180BA7920", Slot = "4")]
		public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096B")]
		[Cpp2IlInjected.Address(RVA = "0xBA7710", Offset = "0xBA5F10", VA = "0x180BA7710")]
		public void DAFBLBFDDID(MIPCILJMDGJ KBHHIDGOLNC, MMOGHBPNOMP LABDBOEIJFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096C")]
		[Cpp2IlInjected.Address(RVA = "0xBA7980", Offset = "0xBA6180", VA = "0x180BA7980")]
		public void EIAKOMHHFIA(MIPCILJMDGJ KBHHIDGOLNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096D")]
		[Cpp2IlInjected.Address(RVA = "0xBA7A60", Offset = "0xBA6260", VA = "0x180BA7A60")]
		internal void FABNHODECCJ(CJGJCHJLMJE KCDMBPDEAMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096E")]
		[Cpp2IlInjected.Address(RVA = "0xBA7220", Offset = "0xBA5A20", VA = "0x180BA7220")]
		private void AJJADGHEFEE(CJGJCHJLMJE KCDMBPDEAMJ, int JCCEMLFDLOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600096F")]
		[Cpp2IlInjected.Address(RVA = "0xBA7F30", Offset = "0xBA6730", VA = "0x180BA7F30")]
		private void MCBEDOFBLDF(NOPBMJOJCGP EPIPKLFKPPF, IHMDKDJBAJD AGBCOFLJNGI, CFKICEFLIDH FLNKAJLLEGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000970")]
		[Cpp2IlInjected.Address(RVA = "0xBA7CA0", Offset = "0xBA64A0", VA = "0x180BA7CA0")]
		private BDOPFPGLKNB FMCFAAFGKGA(NOPBMJOJCGP EPIPKLFKPPF, IHMDKDJBAJD AGBCOFLJNGI)
		{
			return default(BDOPFPGLKNB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000971")]
		[Cpp2IlInjected.Address(RVA = "0xBA7140", Offset = "0xBA5940", VA = "0x180BA7140")]
		private CFKICEFLIDH ABJILMHLIPB(BDOPFPGLKNB BDLMKGGHAEG, NOPBMJOJCGP EPIPKLFKPPF, IHMDKDJBAJD AGBCOFLJNGI)
		{
			return default(CFKICEFLIDH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000972")]
		[Cpp2IlInjected.Address(RVA = "0xBA8250", Offset = "0xBA6A50", VA = "0x180BA8250")]
		public PropertyEventCallbacksService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000161")]
[CEFINOONOIN(typeof(GMIEFABEJHP), new string[] { })]
public class PNGGDADDHDL : DKFAOOPHPAH, GHNBGLLDFLL, GMIEFABEJHP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000162")]
	[CompilerGenerated]
	private sealed class JNHEKKDGMJB : IEnumerable<MGHHJKIEGLL>, IEnumerable, IEnumerator<MGHHJKIEGLL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private MGHHJKIEGLL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public PNGGDADDHDL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private MDOBDKKHBHJ spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public MDOBDKKHBHJ <>3__spline;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private NativeArray<Entity> <children>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000112")]
		private MGHHJKIEGLL System.Collections.Generic.IEnumerator<RecRoom.Components.SplinePoint>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600098D")]
			[Cpp2IlInjected.Address(RVA = "0x68E570", Offset = "0x68CD70", VA = "0x18068E570", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(MGHHJKIEGLL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000113")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600098F")]
			[Cpp2IlInjected.Address(RVA = "0xE56C20", Offset = "0xE55420", VA = "0x180E56C20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600098A")]
		[Cpp2IlInjected.Address(RVA = "0xE4C760", Offset = "0xE4AF60", VA = "0x180E4C760")]
		[DebuggerHidden]
		public JNHEKKDGMJB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098B")]
		[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600098C")]
		[Cpp2IlInjected.Address(RVA = "0xE569D0", Offset = "0xE551D0", VA = "0x180E569D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600098E")]
		[Cpp2IlInjected.Address(RVA = "0xE56BD0", Offset = "0xE553D0", VA = "0x180E56BD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000990")]
		[Cpp2IlInjected.Address(RVA = "0xE56B20", Offset = "0xE55320", VA = "0x180E56B20", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<MGHHJKIEGLL> System.Collections.Generic.IEnumerable<RecRoom.Components.SplinePoint>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000991")]
		[Cpp2IlInjected.Address(RVA = "0xE56B20", Offset = "0xE55320", VA = "0x180E56B20", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	private HFEGCOONMAM LMKNNIPOPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400049C")]
	private DJEEDMKKNJN FGHLILJLEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400049D")]
	private ObjectPrefabCreationService PCNDCGBMEJH;

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	private EntityManager BNFBCOAMLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000978")]
		[Cpp2IlInjected.Address(RVA = "0xE5CD10", Offset = "0xE5B510", VA = "0x180E5CD10")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private ADAIPEODNMG HOCMGGGFBDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000979")]
		[Cpp2IlInjected.Address(RVA = "0xE5C290", Offset = "0xE5AA90", VA = "0x180E5C290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600097A")]
	[Cpp2IlInjected.Address(RVA = "0xE5C210", Offset = "0xE5AA10", VA = "0x180E5C210", Slot = "4")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097B")]
	[Cpp2IlInjected.Address(RVA = "0xE5BE90", Offset = "0xE5A690", VA = "0x180E5BE90", Slot = "5")]
	public void BCKGPNKBBNF(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097C")]
	[Cpp2IlInjected.Address(RVA = "0xE5C180", Offset = "0xE5A980", VA = "0x180E5C180", Slot = "11")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097D")]
	[Cpp2IlInjected.Address(RVA = "0xE5BF50", Offset = "0xE5A750", VA = "0x180E5BF50")]
	private void DIMLALNPOOG(Entity NBBPJGKMHAO, in BJHFEKKLKGB OEFKKBELGHM, in BJHFEKKLKGB JFBNMEBIPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600097E")]
	[Cpp2IlInjected.Address(RVA = "0xE5CA30", Offset = "0xE5B230", VA = "0x180E5CA30", Slot = "12")]
	public MDOBDKKHBHJ NBMMMGOIFIH()
	{
		return default(MDOBDKKHBHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600097F")]
	[Cpp2IlInjected.Address(RVA = "0xE5C5A0", Offset = "0xE5ADA0", VA = "0x180E5C5A0", Slot = "6")]
	public MGHHJKIEGLL HGCGLDIBEJE(MDOBDKKHBHJ MBHDJAIODMF, [Optional] Vector3? BAFCICKIIDG, [Optional] Quaternion? ALKIIOKOBPG, [Optional] Vector3? MJDIJCCGCED)
	{
		return default(MGHHJKIEGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000980")]
	[Cpp2IlInjected.Address(RVA = "0xE5C9E0", Offset = "0xE5B1E0", VA = "0x180E5C9E0", Slot = "13")]
	public MGHHJKIEGLL KNACDILGHBG(MDOBDKKHBHJ MBHDJAIODMF, int AKLHCIJHJKB, [Optional] Vector3? BAFCICKIIDG, [Optional] Quaternion? ALKIIOKOBPG, [Optional] Vector3? MJDIJCCGCED)
	{
		return default(MGHHJKIEGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000981")]
	[Cpp2IlInjected.Address(RVA = "0xE5C3F0", Offset = "0xE5ABF0", VA = "0x180E5C3F0", Slot = "7")]
	public MGHHJKIEGLL FFBICNDKAAN(MDOBDKKHBHJ MBHDJAIODMF, int AKLHCIJHJKB)
	{
		return default(MGHHJKIEGLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000982")]
	[Cpp2IlInjected.Address(RVA = "0xE5C510", Offset = "0xE5AD10", VA = "0x180E5C510", Slot = "14")]
	public void GGOAMEPDEAO(MDOBDKKHBHJ MBHDJAIODMF, MGHHJKIEGLL BPKDOPDNHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000983")]
	[Cpp2IlInjected.Address(RVA = "0xE5CB70", Offset = "0xE5B370", VA = "0x180E5CB70", Slot = "8")]
	public void NPFLBPFDAOK(MDOBDKKHBHJ MBHDJAIODMF, int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000984")]
	[Cpp2IlInjected.Address(RVA = "0xE5CD60", Offset = "0xE5B560", VA = "0x180E5CD60", Slot = "15")]
	public void PPLMEIODECJ(MDOBDKKHBHJ MBHDJAIODMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000985")]
	[Cpp2IlInjected.Address(RVA = "0xE5C350", Offset = "0xE5AB50", VA = "0x180E5C350", Slot = "9")]
	public int EHCDOLDOHAM(MDOBDKKHBHJ MBHDJAIODMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000986")]
	[Cpp2IlInjected.Address(RVA = "0xE5C950", Offset = "0xE5B150", VA = "0x180E5C950", Slot = "10")]
	[IteratorStateMachine(typeof(JNHEKKDGMJB))]
	public IEnumerable<MGHHJKIEGLL> IIEEIMGJNGJ(MDOBDKKHBHJ MBHDJAIODMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000987")]
	[Cpp2IlInjected.Address(RVA = "0xE5C8C0", Offset = "0xE5B0C0", VA = "0x180E5C8C0")]
	private bool HICLLDDJBGA(MDOBDKKHBHJ MBHDJAIODMF, out NativeArray<Entity> DFGJAHNNJBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000988")]
	[Cpp2IlInjected.Address(RVA = "0xE5CAC0", Offset = "0xE5B2C0", VA = "0x180E5CAC0")]
	private NativeArray<Entity> NPDFPFKOBKO(MDOBDKKHBHJ MBHDJAIODMF)
	{
		return default(NativeArray<Entity>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000989")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public PNGGDADDHDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000163")]
[CEFINOONOIN(typeof(AAPGCMMFDCP), new string[] { })]
internal sealed class AAPGCMMFDCP : DKFAOOPHPAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004A6")]
	private HFEGCOONMAM LMKNNIPOPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40004A7")]
	private TransformOwnershipPhase LLHFKMDNGLL;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	private FDJJGOGKMHG JAGNOKIGICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000992")]
		[Cpp2IlInjected.Address(RVA = "0x5038570", Offset = "0x5036D70", VA = "0x185038570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000993")]
	[Cpp2IlInjected.Address(RVA = "0x50385C0", Offset = "0x5036DC0", VA = "0x1850385C0", Slot = "4")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000994")]
	[Cpp2IlInjected.Address(RVA = "0x5038900", Offset = "0x5037100", VA = "0x185038900")]
	public void KNFHCGCPCJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000995")]
	[Cpp2IlInjected.Address(RVA = "0x5038640", Offset = "0x5036E40", VA = "0x185038640")]
	public void FNBFNCPENHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000996")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public AAPGCMMFDCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000164")]
[DefaultMember("Item")]
public struct BOABEKHDNML<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004A8")]
	private T[] DMDONNOOOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004A9")]
	private int ABGIPDMABIG;

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public int KJDFLCMLCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000997")]
		[Cpp2IlInjected.Address(RVA = "0xAECF60", Offset = "0xAEB760", VA = "0x180AECF60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public T NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x6000998")]
		[Cpp2IlInjected.Address(RVA = "0x51920B0", Offset = "0x51908B0", VA = "0x1851920B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public Span<T> MPPELLMCCFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000999")]
		[Cpp2IlInjected.Address(RVA = "0x5567A50", Offset = "0x5566250", VA = "0x185567A50")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public bool JCLGOONBLNF
	{
		[Cpp2IlInjected.Token(Token = "0x600099A")]
		[Cpp2IlInjected.Address(RVA = "0x607F50", Offset = "0x606750", VA = "0x180607F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600099B")]
	[Cpp2IlInjected.Address(RVA = "0x5567C60", Offset = "0x5566460", VA = "0x185567C60")]
	public BOABEKHDNML(int ABGIPDMABIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600099C")]
	[Cpp2IlInjected.Address(RVA = "0x5567AF0", Offset = "0x55662F0", VA = "0x185567AF0")]
	public int DCILMOLDEAH(T CJMMBFLIBMO, int MMECDMIFJKL, int FKDPJOHPNNG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600099D")]
	[Cpp2IlInjected.Address(RVA = "0x5567BA0", Offset = "0x55663A0", VA = "0x185567BA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000165")]
[DefaultMember("Item")]
public struct CJPBEIKNEKE<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AA")]
	private global::BOABEKHDNML<T> DMDONNOOOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AB")]
	private int ABGIPDMABIG;

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public T NLDNALIPODG
	{
		[Cpp2IlInjected.Token(Token = "0x600099E")]
		[Cpp2IlInjected.Address(RVA = "0x55A51F0", Offset = "0x55A39F0", VA = "0x1855A51F0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public int KJDFLCMLCGF
	{
		[Cpp2IlInjected.Token(Token = "0x600099F")]
		[Cpp2IlInjected.Address(RVA = "0x6348F0", Offset = "0x6330F0", VA = "0x1806348F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60009A0")]
		[Cpp2IlInjected.Address(RVA = "0x55A57A0", Offset = "0x55A3FA0", VA = "0x1855A57A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public int JKGEEOBIBFN
	{
		[Cpp2IlInjected.Token(Token = "0x60009A1")]
		[Cpp2IlInjected.Address(RVA = "0x55A63C0", Offset = "0x55A4BC0", VA = "0x1855A63C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60009A2")]
		[Cpp2IlInjected.Address(RVA = "0x55A6330", Offset = "0x55A4B30", VA = "0x1855A6330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public bool JCLGOONBLNF
	{
		[Cpp2IlInjected.Token(Token = "0x60009A3")]
		[Cpp2IlInjected.Address(RVA = "0x55A6380", Offset = "0x55A4B80", VA = "0x1855A6380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Span<T> MPPELLMCCFG
	{
		[Cpp2IlInjected.Token(Token = "0x60009A4")]
		[Cpp2IlInjected.Address(RVA = "0x55A5290", Offset = "0x55A3A90", VA = "0x1855A5290")]
		get
		{
			return default(Span<T>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009A5")]
	[Cpp2IlInjected.Address(RVA = "0x55A6980", Offset = "0x55A5180", VA = "0x1855A6980")]
	public CJPBEIKNEKE(int ABGIPDMABIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A6")]
	[Cpp2IlInjected.Address(RVA = "0x55A6500", Offset = "0x55A4D00", VA = "0x1855A6500")]
	public T MEBDIOFPLEG(int AKLHCIJHJKB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009A7")]
	[Cpp2IlInjected.Address(RVA = "0x55A60A0", Offset = "0x55A48A0", VA = "0x1855A60A0")]
	public void JBCDPBBBNIJ(T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A8")]
	[Cpp2IlInjected.Address(RVA = "0x55A5D00", Offset = "0x55A4500", VA = "0x1855A5D00")]
	public void HKMDBPGKGBG(Span<T> BAKFHBILFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009A9")]
	[Cpp2IlInjected.Address(RVA = "0x55A6810", Offset = "0x55A5010", VA = "0x1855A6810")]
	public void NLKJJINIDJF(T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AA")]
	[Cpp2IlInjected.Address(RVA = "0x55A5600", Offset = "0x55A3E00", VA = "0x1855A5600")]
	private void DEGFJNBEBGL(int JPMPKCEDKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AB")]
	[Cpp2IlInjected.Address(RVA = "0x55A6110", Offset = "0x55A4910", VA = "0x1855A6110")]
	public void JBOKHFIKBGN(Span<T> HPGJMGNMMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AC")]
	[Cpp2IlInjected.Address(RVA = "0x55A5CA0", Offset = "0x55A44A0", VA = "0x1855A5CA0")]
	public void GBBGNKGKAEI(int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AD")]
	[Cpp2IlInjected.Address(RVA = "0x55A5360", Offset = "0x55A3B60", VA = "0x1855A5360")]
	public void CJKOOEAHPHP(int KNLGIMBHEAD, int NOOMMODKENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AE")]
	[Cpp2IlInjected.Address(RVA = "0x55A66A0", Offset = "0x55A4EA0", VA = "0x1855A66A0")]
	public void NGEIKIGMGGE(int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009AF")]
	[Cpp2IlInjected.Address(RVA = "0x55A5900", Offset = "0x55A4100", VA = "0x1855A5900")]
	public void FLNPMJDEINO(int KNLGIMBHEAD, int NOOMMODKENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B0")]
	[Cpp2IlInjected.Address(RVA = "0x55A5FE0", Offset = "0x55A47E0", VA = "0x1855A5FE0")]
	public void IMMNKANLICM(int JPMPKCEDKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B1")]
	[Cpp2IlInjected.Address(RVA = "0x55A5840", Offset = "0x55A4040", VA = "0x1855A5840")]
	public void EDIKFABBPOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B2")]
	[Cpp2IlInjected.Address(RVA = "0x55A5570", Offset = "0x55A3D70", VA = "0x1855A5570")]
	public int DCILMOLDEAH(T CJMMBFLIBMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60009B3")]
	[Cpp2IlInjected.Address(RVA = "0x55A62D0", Offset = "0x55A4AD0", VA = "0x1855A62D0")]
	public bool JNEGJNMGLPF(T CJMMBFLIBMO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009B4")]
	[Cpp2IlInjected.Address(RVA = "0x55A57F0", Offset = "0x55A3FF0", VA = "0x1855A57F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B5")]
	[Cpp2IlInjected.Address(RVA = "0x55A6920", Offset = "0x55A5120", VA = "0x1855A6920", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60009B6")]
	[Cpp2IlInjected.Address(RVA = "0x55A5E60", Offset = "0x55A4660", VA = "0x1855A5E60")]
	public static Span<T> HLHIMDAEEEO(global::CJPBEIKNEKE<T> BAKFHBILFME)
	{
		return default(Span<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60009B7")]
	[Cpp2IlInjected.Address(RVA = "0x55A5ED0", Offset = "0x55A46D0", VA = "0x1855A5ED0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void ICNOEDBHPAH(int CJMMBFLIBMO, int ABGIPDMABIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B8")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void NECKKBPFHFB(int ABGIPDMABIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009B9")]
	[Cpp2IlInjected.Address(RVA = "0x55A6550", Offset = "0x55A4D50", VA = "0x1855A6550")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void NECKKBPFHFB(int ABGIPDMABIG, int AKLHCIJHJKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BA")]
	[Cpp2IlInjected.Address(RVA = "0x55A6700", Offset = "0x55A4F00", VA = "0x1855A6700")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void NLBDENMONCE(int CJMMBFLIBMO, int ABGIPDMABIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BB")]
	[Cpp2IlInjected.Address(RVA = "0x55A5B00", Offset = "0x55A4300", VA = "0x1855A5B00")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private void GANEIPJKICJ(int KNLGIMBHEAD, int NOOMMODKENI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009BC")]
	[Cpp2IlInjected.Address(RVA = "0x55A63F0", Offset = "0x55A4BF0", VA = "0x1855A63F0")]
	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	private static void MDNMKKPKICK(int CJMMBFLIBMO, int ABGIPDMABIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000166")]
public struct CJCKKBOCBCP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	private const int FGNJLHBPAIH = 128;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	private NativeList<Entity> NLBMCCOBHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004AE")]
	private TransformAccessArray CJCNOIMAAPK;

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public int KKHILPEBPDN
	{
		[Cpp2IlInjected.Token(Token = "0x60009BE")]
		[Cpp2IlInjected.Address(RVA = "0x5040710", Offset = "0x503EF10", VA = "0x185040710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public NativeList<Entity> HHCGHHNMLCL
	{
		[Cpp2IlInjected.Token(Token = "0x60009BF")]
		[Cpp2IlInjected.Address(RVA = "0x86BC00", Offset = "0x86A400", VA = "0x18086BC00")]
		get
		{
			return default(NativeList<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public TransformAccessArray HHCDAEBDNDF
	{
		[Cpp2IlInjected.Token(Token = "0x60009C0")]
		[Cpp2IlInjected.Address(RVA = "0x5FD1C0", Offset = "0x5FB9C0", VA = "0x1805FD1C0")]
		get
		{
			return default(TransformAccessArray);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009BD")]
	[Cpp2IlInjected.Address(RVA = "0x5040860", Offset = "0x503F060", VA = "0x185040860")]
	public CJCKKBOCBCP(int JPMPKCEDKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C1")]
	[Cpp2IlInjected.Address(RVA = "0x5040540", Offset = "0x503ED40", VA = "0x185040540")]
	public Entity DNCOCKELPOK(int AKLHCIJHJKB)
	{
		return default(Entity);
	}

	[Cpp2IlInjected.Token(Token = "0x60009C2")]
	[Cpp2IlInjected.Address(RVA = "0x5040530", Offset = "0x503ED30", VA = "0x185040530")]
	public Transform CANJLIECPNJ(int AKLHCIJHJKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60009C3")]
	[Cpp2IlInjected.Address(RVA = "0x50406C0", Offset = "0x503EEC0", VA = "0x1850406C0")]
	public void LGJMIPPGDHJ(int JPMPKCEDKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C4")]
	[Cpp2IlInjected.Address(RVA = "0x5040720", Offset = "0x503EF20", VA = "0x185040720")]
	public void NDFNLJKHBHI(int ENEILDMCLKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C5")]
	[Cpp2IlInjected.Address(RVA = "0x5040790", Offset = "0x503EF90", VA = "0x185040790")]
	public int NLKJJINIDJF(Transform EOBPGPELLLJ, Entity NBIJCGHBCCI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60009C6")]
	[Cpp2IlInjected.Address(RVA = "0x5040640", Offset = "0x503EE40", VA = "0x185040640")]
	public int GBBGNKGKAEI(int AKLHCIJHJKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60009C7")]
	[Cpp2IlInjected.Address(RVA = "0x5040590", Offset = "0x503ED90", VA = "0x185040590", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009C8")]
	[Cpp2IlInjected.Address(RVA = "0x5040600", Offset = "0x503EE00", VA = "0x185040600")]
	private void EMBMLLBKAEO(int GOOFOFMKFBI = 0)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000167")]
public class PDAMEFHIBNK : IEqualityComparer<LinkedEntityGroup>
{
	[Cpp2IlInjected.Token(Token = "0x40004AF")]
	public static readonly PDAMEFHIBNK JBGJKCAJAOI;

	[Cpp2IlInjected.Token(Token = "0x60009C9")]
	[Cpp2IlInjected.Address(RVA = "0xE592E0", Offset = "0xE57AE0", VA = "0x180E592E0", Slot = "4")]
	public bool Equals(LinkedEntityGroup FGCAOGJDCFC, LinkedEntityGroup JGCHHJHFEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60009CA")]
	[Cpp2IlInjected.Address(RVA = "0xE59300", Offset = "0xE57B00", VA = "0x180E59300", Slot = "5")]
	public int GetHashCode(LinkedEntityGroup DEGGOOGCHFA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60009CB")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public PDAMEFHIBNK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000168")]
internal class MIDHDBFHHMK
{
	[Cpp2IlInjected.Token(Token = "0x60009CD")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
	[Conditional("DEBUG_BUILD")]
	public static void GDIJKEAPLHF(in Vector3 BAFCICKIIDG, in Quaternion ALKIIOKOBPG, in Vector3 MJDIJCCGCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CE")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
	[Conditional("DEBUG_BUILD")]
	public static void HFONDDLPANN(in Vector3 GMPNJFAIAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009CF")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
	[Conditional("DEBUG_BUILD")]
	public static void INBFFCKKJIH(in Quaternion ALKIIOKOBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D0")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
	[Conditional("DEBUG_BUILD")]
	public static void FBHCMMKFAEL(in Vector3 NPPDENDGNOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D1")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
	[Conditional("DEBUG_BUILD")]
	public static void POGJOICINFC(in Vector3 NPPDENDGNOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D2")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
	[Conditional("DEBUG_BUILD")]
	public static void MBFFPPJGJND(in float GJFFMHLGFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D3")]
	[Cpp2IlInjected.Address(RVA = "0x50D2100", Offset = "0x50D0900", VA = "0x1850D2100")]
	[Conditional("DEBUG_BUILD")]
	public static void DMEOHFGGCII(in float3 CJMMBFLIBMO, string MEKFJFMIPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D4")]
	[Cpp2IlInjected.Address(RVA = "0x607560", Offset = "0x605D60", VA = "0x180607560")]
	[Conditional("DEBUG_BUILD")]
	public static void JINHFMJMLAP(in float CJMMBFLIBMO, string MEKFJFMIPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D5")]
	[Cpp2IlInjected.Address(RVA = "0x50D22D0", Offset = "0x50D0AD0", VA = "0x1850D22D0")]
	[Conditional("DEBUG_BUILD")]
	public static void JINHFMJMLAP(in Vector3 CJMMBFLIBMO, string MEKFJFMIPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D6")]
	[Cpp2IlInjected.Address(RVA = "0x50D2370", Offset = "0x50D0B70", VA = "0x1850D2370")]
	[Conditional("DEBUG_BUILD")]
	public static void JINHFMJMLAP(in Quaternion CJMMBFLIBMO, string MEKFJFMIPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D7")]
	[Cpp2IlInjected.Address(RVA = "0x50D22C0", Offset = "0x50D0AC0", VA = "0x1850D22C0")]
	[Conditional("DEBUG_BUILD")]
	public static void HELIFKCDMAH(in float CJMMBFLIBMO, string MEKFJFMIPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D8")]
	[Cpp2IlInjected.Address(RVA = "0x50D2220", Offset = "0x50D0A20", VA = "0x1850D2220")]
	[Conditional("DEBUG_BUILD")]
	public static void HELIFKCDMAH(in Vector3 CJMMBFLIBMO, string MEKFJFMIPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009D9")]
	[Cpp2IlInjected.Address(RVA = "0x50D21A0", Offset = "0x50D09A0", VA = "0x1850D21A0")]
	[Conditional("DEBUG_BUILD")]
	public static void HELIFKCDMAH(in Quaternion CJMMBFLIBMO, string MEKFJFMIPGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009DA")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public MIDHDBFHHMK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000169")]
public struct GCIIMAMNELL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B0")]
	public Entity NBIJCGHBCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B1")]
	public Entity NHAJDPLICDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B2")]
	public Entity ACODEJEKDBE;

	[Cpp2IlInjected.Token(Token = "0x60009DB")]
	[Cpp2IlInjected.Address(RVA = "0x32CD2A0", Offset = "0x32CBAA0", VA = "0x1832CD2A0")]
	public GCIIMAMNELL(Entity NBIJCGHBCCI, Entity NHAJDPLICDA, Entity ACODEJEKDBE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60009DC")]
	[Cpp2IlInjected.Address(RVA = "0x50468F0", Offset = "0x50450F0", VA = "0x1850468F0")]
	public static GCIIMAMNELL HLHIMDAEEEO((Entity entity, Entity oldParent, Entity newParent) IGFKBPBPEFE)
	{
		return default(GCIIMAMNELL);
	}

	[Cpp2IlInjected.Token(Token = "0x60009DD")]
	[Cpp2IlInjected.Address(RVA = "0x5046930", Offset = "0x5045130", VA = "0x185046930")]
	public void JEEEGHBGKHP(out Entity NBIJCGHBCCI, out Entity NHAJDPLICDA, out Entity ACODEJEKDBE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016A")]
public struct IMKIELOKPIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B3")]
	public Entity NBIJCGHBCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004B4")]
	public Entity CELKNCFBAOE;

	[Cpp2IlInjected.Token(Token = "0x60009DE")]
	[Cpp2IlInjected.Address(RVA = "0x1461200", Offset = "0x145FA00", VA = "0x181461200")]
	public IMKIELOKPIN(Entity NBIJCGHBCCI, Entity CELKNCFBAOE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60009DF")]
	[Cpp2IlInjected.Address(RVA = "0x50C7B20", Offset = "0x50C6320", VA = "0x1850C7B20")]
	public static IMKIELOKPIN HLHIMDAEEEO((Entity entity, Entity parent) IGFKBPBPEFE)
	{
		return default(IMKIELOKPIN);
	}

	[Cpp2IlInjected.Token(Token = "0x60009E0")]
	[Cpp2IlInjected.Address(RVA = "0x50C7B50", Offset = "0x50C6350", VA = "0x1850C7B50")]
	public void JEEEGHBGKHP(out Entity NBIJCGHBCCI, out Entity CELKNCFBAOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016B")]
public struct ODHFKGLILKF<T> : IDisposable where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004B5")]
	private GCHandle LPPHLKEKIOC;

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public bool HGPEPPKPGDD
	{
		[Cpp2IlInjected.Token(Token = "0x60009E2")]
		[Cpp2IlInjected.Address(RVA = "0x5041B20", Offset = "0x5040320", VA = "0x185041B20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public T EJFMLMNCFJG
	{
		[Cpp2IlInjected.Token(Token = "0x60009E3")]
		[Cpp2IlInjected.Address(RVA = "0x5503030", Offset = "0x5501830", VA = "0x185503030")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60009E4")]
		[Cpp2IlInjected.Address(RVA = "0x5502F70", Offset = "0x5501770", VA = "0x185502F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60009E1")]
	[Cpp2IlInjected.Address(RVA = "0x5503100", Offset = "0x5501900", VA = "0x185503100")]
	public ODHFKGLILKF(T CJMMBFLIBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E5")]
	[Cpp2IlInjected.Address(RVA = "0x55030D0", Offset = "0x55018D0", VA = "0x1855030D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016C")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(JKDBHHDKCBD))]
public sealed class EMJFPBLJDAL : GCGMBNHNDAP
{
	[Cpp2IlInjected.Token(Token = "0x60009E6")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
	public EMJFPBLJDAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E7")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016D")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(JKDBHHDKCBD))]
[UpdateAfter(typeof(EMJFPBLJDAL))]
public sealed class OGFOLGNJOCC : PreSerializeRemoveEntities
{
	[Cpp2IlInjected.Token(Token = "0x60009E8")]
	[Cpp2IlInjected.Address(RVA = "0x50D5870", Offset = "0x50D4070", VA = "0x1850D5870")]
	public OGFOLGNJOCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009E9")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016E")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(JKDBHHDKCBD))]
[UpdateAfter(typeof(OGFOLGNJOCC))]
public sealed class HNKKONGLKBN : CCHEFKNBGNG
{
	[Cpp2IlInjected.Token(Token = "0x60009EA")]
	[Cpp2IlInjected.Address(RVA = "0x503DF10", Offset = "0x503C710", VA = "0x18503DF10")]
	public HNKKONGLKBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EB")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200016F")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(JEBNAANPENO))]
public class NGBCPMIGADJ : BNAKEADJMLL
{
	[Cpp2IlInjected.Token(Token = "0x60009EC")]
	[Cpp2IlInjected.Address(RVA = "0x503DF10", Offset = "0x503C710", VA = "0x18503DF10")]
	public NGBCPMIGADJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009ED")]
	[Cpp2IlInjected.Address(RVA = "0x50D3FC0", Offset = "0x50D27C0", VA = "0x1850D3FC0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000170")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(JEBNAANPENO))]
public class GDGONCPIAKC : JAHIEHLLCEF
{
	[Cpp2IlInjected.Token(Token = "0x60009EE")]
	[Cpp2IlInjected.Address(RVA = "0x503DF10", Offset = "0x503C710", VA = "0x18503DF10")]
	public GDGONCPIAKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009EF")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000171")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(JEBNAANPENO))]
public class COOJJOPGPCL : JCOCLLKLLMI
{
	[Cpp2IlInjected.Token(Token = "0x60009F0")]
	[Cpp2IlInjected.Address(RVA = "0x503DF10", Offset = "0x503C710", VA = "0x18503DF10")]
	public COOJJOPGPCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F1")]
	[Cpp2IlInjected.Address(RVA = "0x5041310", Offset = "0x503FB10", VA = "0x185041310", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000172")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(HJBONFDHEJE))]
public sealed class CAMNALMAHDG : KOKPEIHFBPI
{
	[Cpp2IlInjected.Token(Token = "0x60009F2")]
	[Cpp2IlInjected.Address(RVA = "0x503F480", Offset = "0x503DC80", VA = "0x18503F480")]
	public CAMNALMAHDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F3")]
	[Cpp2IlInjected.Address(RVA = "0x503F470", Offset = "0x503DC70", VA = "0x18503F470", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000173")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(IJLMMAGOELK))]
internal class MNOEFBHDEDM : DestroyLocalObjects
{
	[Cpp2IlInjected.Token(Token = "0x60009F4")]
	[Cpp2IlInjected.Address(RVA = "0x50D3490", Offset = "0x50D1C90", VA = "0x1850D3490")]
	public MNOEFBHDEDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F5")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000174")]
[MIDOOGOCAPK]
[UpdateAfter(typeof(MNOEFBHDEDM))]
[UpdateInGroup(typeof(IJLMMAGOELK))]
internal class MCGEIOGFMPO : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60009F6")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public MCGEIOGFMPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F7")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000175")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(PGHDFNMAFOE))]
internal class GGNGFLBOCCC : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60009F8")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public GGNGFLBOCCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009F9")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000176")]
[MIDOOGOCAPK]
[UpdateAfter(typeof(GGNGFLBOCCC))]
[UpdateInGroup(typeof(PGHDFNMAFOE))]
internal class OADCNKBIPLN : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60009FA")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public OADCNKBIPLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FB")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000177")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(PGHDFNMAFOE))]
[UpdateAfter(typeof(OADCNKBIPLN))]
internal class EILPGMHLJFN : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x60009FC")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public EILPGMHLJFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FD")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000178")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(EILPGMHLJFN))]
internal class MGILAINMBMO : FBKIAOKPHAA
{
	[Cpp2IlInjected.Token(Token = "0x60009FE")]
	[Cpp2IlInjected.Address(RVA = "0x50D20F0", Offset = "0x50D08F0", VA = "0x1850D20F0")]
	public MGILAINMBMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60009FF")]
	[Cpp2IlInjected.Address(RVA = "0x50D20E0", Offset = "0x50D08E0", VA = "0x1850D20E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000179")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(EILPGMHLJFN))]
internal class HNEINIJDMLC : IPKNIMGIGJN
{
	[Cpp2IlInjected.Token(Token = "0x6000A00")]
	[Cpp2IlInjected.Address(RVA = "0x50C65E0", Offset = "0x50C4DE0", VA = "0x1850C65E0")]
	public HNEINIJDMLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A01")]
	[Cpp2IlInjected.Address(RVA = "0x50C65A0", Offset = "0x50C4DA0", VA = "0x1850C65A0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017A")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(EILPGMHLJFN))]
internal class CABOCHOEJCL : FCPILGHJKEO
{
	[Cpp2IlInjected.Token(Token = "0x6000A02")]
	[Cpp2IlInjected.Address(RVA = "0x503F410", Offset = "0x503DC10", VA = "0x18503F410")]
	public CABOCHOEJCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A03")]
	[Cpp2IlInjected.Address(RVA = "0x503F3D0", Offset = "0x503DBD0", VA = "0x18503F3D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017B")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(OADCNKBIPLN))]
internal sealed class IKHGOMHOANB : FLAMBJEPNJD
{
	[Cpp2IlInjected.Token(Token = "0x6000A04")]
	[Cpp2IlInjected.Address(RVA = "0x503DF10", Offset = "0x503C710", VA = "0x18503DF10")]
	public IKHGOMHOANB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A05")]
	[Cpp2IlInjected.Address(RVA = "0x50C76D0", Offset = "0x50C5ED0", VA = "0x1850C76D0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017C")]
[MIDOOGOCAPK]
[UpdateAfter(typeof(IKHGOMHOANB))]
[UpdateInGroup(typeof(OADCNKBIPLN))]
internal sealed class MKOMAELMMMC : KOKPEIHFBPI
{
	[Cpp2IlInjected.Token(Token = "0x6000A06")]
	[Cpp2IlInjected.Address(RVA = "0x50CF080", Offset = "0x50CD880", VA = "0x1850CF080")]
	public MKOMAELMMMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A07")]
	[Cpp2IlInjected.Address(RVA = "0x50CF040", Offset = "0x50CD840", VA = "0x1850CF040", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017D")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(MCGEIOGFMPO))]
internal sealed class MAMAIIKEADL : BMICAOOFJOO
{
	[Cpp2IlInjected.Token(Token = "0x6000A08")]
	[Cpp2IlInjected.Address(RVA = "0x50D0750", Offset = "0x50CEF50", VA = "0x1850D0750")]
	public MAMAIIKEADL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A09")]
	[Cpp2IlInjected.Address(RVA = "0x50D0740", Offset = "0x50CEF40", VA = "0x1850D0740", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017E")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(MCGEIOGFMPO))]
internal sealed class FLBOFEDEFOC : RegisterTransforms
{
	[Cpp2IlInjected.Token(Token = "0x6000A0A")]
	[Cpp2IlInjected.Address(RVA = "0x5046430", Offset = "0x5044C30", VA = "0x185046430")]
	public FLBOFEDEFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0B")]
	[Cpp2IlInjected.Address(RVA = "0x5046420", Offset = "0x5044C20", VA = "0x185046420", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200017F")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(MCGEIOGFMPO))]
[UpdateAfter(typeof(FLBOFEDEFOC))]
internal sealed class OLCOOOOBKGM : CopyTransformDataFromGameObjects
{
	[Cpp2IlInjected.Token(Token = "0x6000A0C")]
	[Cpp2IlInjected.Address(RVA = "0x50D5D80", Offset = "0x50D4580", VA = "0x1850D5D80")]
	public OLCOOOOBKGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0D")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000180")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(CNIKOLEFIHN))]
internal class EHDHAPFPCLG : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A0E")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public EHDHAPFPCLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A0F")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000181")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(CNIKOLEFIHN))]
internal class JKOCEOPBNJF : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A10")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public JKOCEOPBNJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A11")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000182")]
[MIDOOGOCAPK]
[ExecuteAlways]
[UpdateInGroup(typeof(CNIKOLEFIHN))]
[UpdateAfter(typeof(EHDHAPFPCLG))]
internal sealed class NHGJJJPDGKF : PMGBAPCJCOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000A12")]
	[Cpp2IlInjected.Address(RVA = "0x503DF10", Offset = "0x503C710", VA = "0x18503DF10")]
	public NHGJJJPDGKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A13")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000183")]
[ExecuteAlways]
[MIDOOGOCAPK]
[UpdateAfter(typeof(NHGJJJPDGKF))]
[UpdateInGroup(typeof(CNIKOLEFIHN))]
internal sealed class OKFEDOHEMKF : AJPECLGPNJP
{
	[Cpp2IlInjected.Token(Token = "0x6000A14")]
	[Cpp2IlInjected.Address(RVA = "0x503DF10", Offset = "0x503C710", VA = "0x18503DF10")]
	public OKFEDOHEMKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A15")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000184")]
[MIDOOGOCAPK]
[UpdateAfter(typeof(NHGJJJPDGKF))]
[UpdateInGroup(typeof(CNIKOLEFIHN))]
internal sealed class DPIEIMMNPGB : NGHHGCBKEJH
{
	[Cpp2IlInjected.Token(Token = "0x6000A16")]
	[Cpp2IlInjected.Address(RVA = "0x503DF10", Offset = "0x503C710", VA = "0x18503DF10")]
	public DPIEIMMNPGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A17")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000185")]
[AlwaysUpdateSystem]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(JKOCEOPBNJF))]
internal sealed class JICBGFGPMNH : ComputePropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x17000123")]
	protected override ApplyPropertyDifferences IHODHJNFOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000A18")]
		[Cpp2IlInjected.Address(RVA = "0x50CA0B0", Offset = "0x50C88B0", VA = "0x1850CA0B0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A19")]
	[Cpp2IlInjected.Address(RVA = "0x50CA100", Offset = "0x50C8900", VA = "0x1850CA100")]
	public JICBGFGPMNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1A")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000186")]
[MIDOOGOCAPK]
[UpdateAfter(typeof(JICBGFGPMNH))]
[UpdateInGroup(typeof(JKOCEOPBNJF))]
internal sealed class COLCLIIDLJE : ApplyPropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x6000A1B")]
	[Cpp2IlInjected.Address(RVA = "0x50412B0", Offset = "0x503FAB0", VA = "0x1850412B0")]
	public COLCLIIDLJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1C")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000187")]
[MIDOOGOCAPK]
[UpdateAfter(typeof(JICBGFGPMNH))]
[UpdateInGroup(typeof(JKOCEOPBNJF))]
internal sealed class NDOPFKNFHGG : PropertyEventCallbacks
{
	[Cpp2IlInjected.Token(Token = "0x6000A1D")]
	[Cpp2IlInjected.Address(RVA = "0x503DF10", Offset = "0x503C710", VA = "0x18503DF10")]
	public NDOPFKNFHGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A1E")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000188")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(JKOCEOPBNJF))]
[UpdateAfter(typeof(NDOPFKNFHGG))]
internal sealed class KPOEKJCOGJC : EnqueuePropertyDifferenceToNetwork
{
	[Cpp2IlInjected.Token(Token = "0x17000124")]
	protected override ComputePropertyDifferences GHLINMDLBCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000A1F")]
		[Cpp2IlInjected.Address(RVA = "0x50CF0C0", Offset = "0x50CD8C0", VA = "0x1850CF0C0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A20")]
	[Cpp2IlInjected.Address(RVA = "0x50CF110", Offset = "0x50CD910", VA = "0x1850CF110")]
	public KPOEKJCOGJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A21")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000189")]
[MIDOOGOCAPK]
[UpdateAfter(typeof(KPOEKJCOGJC))]
[UpdateInGroup(typeof(JKOCEOPBNJF))]
internal sealed class JJJGNDDJMOH : CLBIMONENOH
{
	[Cpp2IlInjected.Token(Token = "0x6000A22")]
	[Cpp2IlInjected.Address(RVA = "0x50CA160", Offset = "0x50C8960", VA = "0x1850CA160")]
	public JJJGNDDJMOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A23")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018A")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(EHDHAPFPCLG))]
internal sealed class GJFBBGAACDF : CopyTransformDataToGameObjects
{
	[Cpp2IlInjected.Token(Token = "0x6000A24")]
	[Cpp2IlInjected.Address(RVA = "0x504A750", Offset = "0x5048F50", VA = "0x18504A750")]
	public GJFBBGAACDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A25")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018B")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(EHDHAPFPCLG))]
internal sealed class GMJADKDCAJJ : OFFCHEADOND
{
	[Cpp2IlInjected.Token(Token = "0x6000A26")]
	[Cpp2IlInjected.Address(RVA = "0x503DF10", Offset = "0x503C710", VA = "0x18503DF10")]
	public GMJADKDCAJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A27")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018C")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(PGHDFNMAFOE))]
internal class CHIOGDDFJOA : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A28")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public CHIOGDDFJOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A29")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018D")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(PGHDFNMAFOE))]
[UpdateAfter(typeof(CHIOGDDFJOA))]
internal sealed class LCHPCIIIMGK : UpdateConnectableVisuals
{
	[Cpp2IlInjected.Token(Token = "0x6000A2A")]
	[Cpp2IlInjected.Address(RVA = "0x50CFCA0", Offset = "0x50CE4A0", VA = "0x1850CFCA0")]
	public LCHPCIIIMGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2B")]
	[Cpp2IlInjected.Address(RVA = "0x50CFC90", Offset = "0x50CE490", VA = "0x1850CFC90", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018E")]
[ExecuteAlways]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(PGHDFNMAFOE))]
[UpdateAfter(typeof(CHIOGDDFJOA))]
internal sealed class LPIHKJLFIFO : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A2C")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public LPIHKJLFIFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2D")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200018F")]
[ExecuteAlways]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(LPIHKJLFIFO))]
internal sealed class CBIHHKCILCP : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A2E")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public CBIHHKCILCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A2F")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000190")]
[MIDOOGOCAPK]
[ExecuteAlways]
[UpdateAfter(typeof(CBIHHKCILCP))]
[UpdateInGroup(typeof(LPIHKJLFIFO))]
internal sealed class KOEOJFNAMDH : ComponentSystemGroup
{
	[Cpp2IlInjected.Token(Token = "0x6000A30")]
	[Cpp2IlInjected.Address(RVA = "0xE59D60", Offset = "0xE58560", VA = "0x180E59D60")]
	public KOEOJFNAMDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A31")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000191")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(KOEOJFNAMDH))]
internal sealed class HJIGOCHMEEG : AHAAABKNGHO
{
	[Cpp2IlInjected.Token(Token = "0x6000A32")]
	[Cpp2IlInjected.Address(RVA = "0x503DF10", Offset = "0x503C710", VA = "0x18503DF10")]
	public HJIGOCHMEEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A33")]
	[Cpp2IlInjected.Address(RVA = "0x50C6590", Offset = "0x50C4D90", VA = "0x1850C6590", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000192")]
[MIDOOGOCAPK]
[UpdateAfter(typeof(HJIGOCHMEEG))]
[UpdateInGroup(typeof(KOEOJFNAMDH))]
internal sealed class CJEGMCADJCD : PEJEPBOAHPC
{
	[Cpp2IlInjected.Token(Token = "0x6000A34")]
	[Cpp2IlInjected.Address(RVA = "0x503DF10", Offset = "0x503C710", VA = "0x18503DF10")]
	public CJEGMCADJCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A35")]
	[Cpp2IlInjected.Address(RVA = "0x50408E0", Offset = "0x503F0E0", VA = "0x1850408E0", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000193")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(KOEOJFNAMDH))]
[UpdateAfter(typeof(CJEGMCADJCD))]
internal sealed class LKAMACMIGHM : FKLMGALCAMD
{
	[Cpp2IlInjected.Token(Token = "0x6000A36")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
	public LKAMACMIGHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A37")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000194")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(KOEOJFNAMDH))]
[UpdateAfter(typeof(LKAMACMIGHM))]
internal class MJBGJCBMIBL : PhysicsSceneUpdateCollidersSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000A38")]
	[Cpp2IlInjected.Address(RVA = "0x50D2400", Offset = "0x50D0C00", VA = "0x1850D2400")]
	public MJBGJCBMIBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A39")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000195")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(CBIHHKCILCP))]
internal sealed class CDGFJPNDKEE : SplineLocalBoundsSystem
{
	[Cpp2IlInjected.Token(Token = "0x6000A3A")]
	[Cpp2IlInjected.Address(RVA = "0x50404D0", Offset = "0x503ECD0", VA = "0x1850404D0")]
	public CDGFJPNDKEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3B")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000196")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(CHIOGDDFJOA))]
internal sealed class EHFFHMGAALP : PFLCGHEKAPE
{
	[Cpp2IlInjected.Token(Token = "0x6000A3C")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010")]
	public EHFFHMGAALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3D")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE50", Offset = "0x6BC650", VA = "0x1806BDE50", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000197")]
[MIDOOGOCAPK]
[UpdateAfter(typeof(EHFFHMGAALP))]
[UpdateInGroup(typeof(CHIOGDDFJOA))]
internal sealed class KAELJNKOKKB : L2PToL2WHierarchy
{
	[Cpp2IlInjected.Token(Token = "0x6000A3E")]
	[Cpp2IlInjected.Address(RVA = "0x50CC280", Offset = "0x50CAA80", VA = "0x1850CC280")]
	public KAELJNKOKKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A3F")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000198")]
[MIDOOGOCAPK]
[UpdateAfter(typeof(EHFFHMGAALP))]
[UpdateInGroup(typeof(CHIOGDDFJOA))]
internal sealed class FBBDDGHKPDC : JCGLALJHLNF
{
	[Cpp2IlInjected.Token(Token = "0x6000A40")]
	[Cpp2IlInjected.Address(RVA = "0x503DF10", Offset = "0x503C710", VA = "0x18503DF10")]
	public FBBDDGHKPDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A41")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000199")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(CHIOGDDFJOA))]
[UpdateAfter(typeof(KAELJNKOKKB))]
[UpdateAfter(typeof(FBBDDGHKPDC))]
internal sealed class IAALENGPFON : HCKLACOBJMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000A42")]
	[Cpp2IlInjected.Address(RVA = "0x503DF10", Offset = "0x503C710", VA = "0x18503DF10")]
	public IAALENGPFON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A43")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019A")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(DMBLAJDPHED))]
internal class BHJAPIONOJD : OLIGJJCEAEM
{
	[Cpp2IlInjected.Token(Token = "0x6000A44")]
	[Cpp2IlInjected.Address(RVA = "0x503DF10", Offset = "0x503C710", VA = "0x18503DF10")]
	public BHJAPIONOJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A45")]
	[Cpp2IlInjected.Address(RVA = "0x503DF00", Offset = "0x503C700", VA = "0x18503DF00", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019B")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(FPAGDOGOJLI))]
internal sealed class JLBNLANFFBG : AIOGDKEINIP
{
	[Cpp2IlInjected.Token(Token = "0x6000A46")]
	[Cpp2IlInjected.Address(RVA = "0x503DF10", Offset = "0x503C710", VA = "0x18503DF10")]
	public JLBNLANFFBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A47")]
	[Cpp2IlInjected.Address(RVA = "0x50CB030", Offset = "0x50C9830", VA = "0x1850CB030", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019C")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(FPAGDOGOJLI))]
[UpdateAfter(typeof(JLBNLANFFBG))]
internal class OMOCAOCGNCK : PostLoadInitializeEmbodiment
{
	[Cpp2IlInjected.Token(Token = "0x6000A48")]
	[Cpp2IlInjected.Address(RVA = "0xE57180", Offset = "0xE55980", VA = "0x180E57180")]
	public OMOCAOCGNCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A49")]
	[Cpp2IlInjected.Address(RVA = "0xE57170", Offset = "0xE55970", VA = "0x180E57170", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019D")]
[MIDOOGOCAPK]
[AlwaysUpdateSystem]
[UpdateAfter(typeof(OMOCAOCGNCK))]
[UpdateInGroup(typeof(FPAGDOGOJLI))]
internal sealed class NHEGDFIHMIH : ComputePropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	protected override ApplyPropertyDifferences IHODHJNFOIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000A4A")]
		[Cpp2IlInjected.Address(RVA = "0x50D4050", Offset = "0x50D2850", VA = "0x1850D4050", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4B")]
	[Cpp2IlInjected.Address(RVA = "0x50D40A0", Offset = "0x50D28A0", VA = "0x1850D40A0")]
	public NHEGDFIHMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4C")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019E")]
[MIDOOGOCAPK]
[UpdateInGroup(typeof(FPAGDOGOJLI))]
[UpdateAfter(typeof(NHEGDFIHMIH))]
internal sealed class AKFDCDODPGF : ApplyPropertyDifferences
{
	[Cpp2IlInjected.Token(Token = "0x6000A4D")]
	[Cpp2IlInjected.Address(RVA = "0x503C0D0", Offset = "0x503A8D0", VA = "0x18503C0D0")]
	public AKFDCDODPGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A4E")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200019F")]
[MIDOOGOCAPK]
[UpdateAfter(typeof(NHEGDFIHMIH))]
[UpdateInGroup(typeof(FPAGDOGOJLI))]
internal sealed class KALKNCLLMEJ : PropertyEventCallbacks
{
	[Cpp2IlInjected.Token(Token = "0x6000A4F")]
	[Cpp2IlInjected.Address(RVA = "0x503DF10", Offset = "0x503C710", VA = "0x18503DF10")]
	public KALKNCLLMEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A50")]
	[Cpp2IlInjected.Address(RVA = "0xBA5010", Offset = "0xBA3810", VA = "0x180BA5010", Slot = "4")]
	protected internal override void OnCreateForCompiler()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A0")]
[CEFINOONOIN(typeof(CAMIJMPEPJA), new string[] { })]
public sealed class LPGKMJLBDJO : CAMIJMPEPJA, DKFAOOPHPAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40004B6")]
	private ICHIOKBIGBA GOKPOHIAIDA;

	[Cpp2IlInjected.Token(Token = "0x6000A51")]
	[Cpp2IlInjected.Address(RVA = "0x50D0610", Offset = "0x50CEE10", VA = "0x1850D0610", Slot = "5")]
	public void EADOMJOIKCJ(FBKJAGMDHMF GPHFNNBDCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A52")]
	[Cpp2IlInjected.Address(RVA = "0x50D0660", Offset = "0x50CEE60", VA = "0x1850D0660")]
	public bool GDOHKFNFMFO(in float3 PILBMAKMDBK, in float3 ABCIPBECLHO, float OHGAJDFAGIK, Allocator DDJPHGFEOFF, out NativeArray<Entity> NLBMCCOBHKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A53")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public LPGKMJLBDJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A54")]
	[Cpp2IlInjected.Address(RVA = "0x50D0660", Offset = "0x50CEE60", VA = "0x1850D0660", Slot = "4")]
	private bool PKDNJJMPLFH(in float3 PILBMAKMDBK, in float3 ABCIPBECLHO, float OHGAJDFAGIK, Allocator DDJPHGFEOFF, out NativeArray<Entity> NLBMCCOBHKD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A1")]
[BBMHGCKNDGC(typeof(AuthoredLocalPoseData))]
public sealed class LMNPDHFAJEF : OLBIBAHEKNA
{
	[Cpp2IlInjected.Token(Token = "0x6000A55")]
	[Cpp2IlInjected.Address(RVA = "0x50D04D0", Offset = "0x50CECD0", VA = "0x1850D04D0", Slot = "8")]
	protected override bool GKAPGBMNGMN(ReadOnlySpan<AuthoredLocalPoseData> HPGJMGNMMCF, EDEBCBMIEIE NIBNAFJNIDP, out ReadOnlySpan<byte> HDPBFIPIIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A56")]
	[Cpp2IlInjected.Address(RVA = "0x50D0410", Offset = "0x50CEC10", VA = "0x1850D0410", Slot = "9")]
	protected override bool FGFMIOLKIJB(int KAGEGNEPBEI, Span<AuthoredLocalPoseData> HPGJMGNMMCF, in ReadOnlySpan<byte> HDPBFIPIIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A57")]
	[Cpp2IlInjected.Address(RVA = "0x50D0550", Offset = "0x50CED50", VA = "0x1850D0550")]
	public LMNPDHFAJEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A2")]
[BBMHGCKNDGC(typeof(LocalPoseData))]
public sealed class OBDNGDDDODE : KGHEPLPMMHB
{
	[Cpp2IlInjected.Token(Token = "0x6000A58")]
	[Cpp2IlInjected.Address(RVA = "0x50D4BA0", Offset = "0x50D33A0", VA = "0x1850D4BA0", Slot = "8")]
	protected override bool GKAPGBMNGMN(ReadOnlySpan<LocalPoseData> HPGJMGNMMCF, EDEBCBMIEIE NIBNAFJNIDP, out ReadOnlySpan<byte> HDPBFIPIIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A59")]
	[Cpp2IlInjected.Address(RVA = "0x50D4AE0", Offset = "0x50D32E0", VA = "0x1850D4AE0", Slot = "9")]
	protected override bool FGFMIOLKIJB(int KAGEGNEPBEI, Span<LocalPoseData> HPGJMGNMMCF, in ReadOnlySpan<byte> HDPBFIPIIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5A")]
	[Cpp2IlInjected.Address(RVA = "0x50D4C20", Offset = "0x50D3420", VA = "0x1850D4C20")]
	public OBDNGDDDODE()
	{
	}
}
namespace RecRoom.ObjectModel.Systems.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x20001A3")]
	[Preserve]
	internal class _RRAssemblyIndex : KOGEJEDODIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000A5B")]
		[Cpp2IlInjected.Address(RVA = "0x606E30", Offset = "0x605630", VA = "0x180606E30")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5C")]
		[Cpp2IlInjected.Address(RVA = "0xBB3ED0", Offset = "0xBB26D0", VA = "0x180BB3ED0", Slot = "6")]
		public sealed override void BNMIAFOMHPF(BPOOCNDMEEO LABDBOEIJFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A5D")]
		[Cpp2IlInjected.Address(RVA = "0xBB4680", Offset = "0xBB2E80", VA = "0x180BB4680", Slot = "4")]
		public sealed override void DJCOPMFLKGB()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20001A4")]
internal class MMIOECCFMPN : ContainerPropertyBag<ALOMAIDHFHJ>
{
	[Cpp2IlInjected.Token(Token = "0x20001A5")]
	private class DNIPNCFKDOG : Property<ALOMAIDHFHJ, NNCLEEGIIBK>
	{
		[Cpp2IlInjected.Token(Token = "0x17000126")]
		public override string JMBPOHFOGFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000A5F")]
			[Cpp2IlInjected.Address(RVA = "0x50C5730", Offset = "0x50C3F30", VA = "0x1850C5730", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000127")]
		public override bool FKKNEPJPEKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000A60")]
			[Cpp2IlInjected.Address(RVA = "0x604020", Offset = "0x602820", VA = "0x180604020", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000A61")]
		[Cpp2IlInjected.Address(RVA = "0x50C56F0", Offset = "0x50C3EF0", VA = "0x1850C56F0")]
		public DNIPNCFKDOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000A62")]
		[Cpp2IlInjected.Address(RVA = "0x1E97EE0", Offset = "0x1E966E0", VA = "0x181E97EE0", Slot = "11")]
		public override NNCLEEGIIBK GetValue(ref ALOMAIDHFHJ IGEIPKGINDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000A63")]
		[Cpp2IlInjected.Address(RVA = "0x50C56C0", Offset = "0x50C3EC0", VA = "0x1850C56C0", Slot = "12")]
		public override void SetValue(ref ALOMAIDHFHJ IGEIPKGINDO, NNCLEEGIIBK CJMMBFLIBMO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000A5E")]
	[Cpp2IlInjected.Address(RVA = "0x50D33E0", Offset = "0x50D1BE0", VA = "0x1850D33E0")]
	public MMIOECCFMPN()
	{
	}
}
namespace Unity.Properties.Generated
{
	[Cpp2IlInjected.Token(Token = "0x20001A6")]
	internal class PropertyBagRegistry
	{
		[Cpp2IlInjected.Token(Token = "0x6000A64")]
		[Cpp2IlInjected.Address(RVA = "0x421E000", Offset = "0x421C800", VA = "0x18421E000")]
		[Preserve]
		[RuntimeInitializeOnLoadMethod]
		public static void Initialize()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20001A7")]
public class PGKFNNKCMAN
{
	[Cpp2IlInjected.Token(Token = "0x40004B7")]
	private static byte[] EGKMOPGLIPA;

	[Cpp2IlInjected.Token(Token = "0x40004B8")]
	private static int JGABFFAEPHC;

	[Cpp2IlInjected.Token(Token = "0x40004B9")]
	private static int OCNADIFHHML;

	[Cpp2IlInjected.Token(Token = "0x40004BA")]
	private static BigInteger GACCCDCMEHO;

	[Cpp2IlInjected.Token(Token = "0x6000A65")]
	[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
	public PGKFNNKCMAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000A67")]
	[Cpp2IlInjected.Address(RVA = "0xE59D70", Offset = "0xE58570", VA = "0x180E59D70")]
	private static string HDJAHDEMDDI(byte[] FLEBMPFFCAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000A68")]
	[Cpp2IlInjected.Address(RVA = "0xE59E70", Offset = "0xE58670", VA = "0x180E59E70")]
	public static string OMJPKAOBENG(byte[] FCDIIMLAMIO, bool PCFPPGPONLG)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001A8")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x20001A9")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000A69")]
		[Cpp2IlInjected.Address(RVA = "0x5F6050", Offset = "0x5F4850", VA = "0x1805F6050")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20001AA")]
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
