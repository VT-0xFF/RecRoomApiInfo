using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Foundation;
using RecRoom.Networking.DataTypes;
using RecRoom.ObjectModel;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[ServiceLifetime(Lifetime.Application)]
	public interface QCQQKPQMXYA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool WFTUHJPDYLJ(InstantiateParameters a, bool b = false);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int KBIETJLSQIX(InstantiateParameters[] a);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool CCAMKAMHWRY();

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool AKVGQAMEEGH(int a, int b, bool c, GameObject d);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void BEHFCRCWJZM(int a, [Optional] int? b);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool GZEIONHAEQK(PKPJICLPGZO a, [Out] InstantiateParameters b, bool c = true);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool FVPSLSGELYH(PKPJICLPGZO a, [Out] int b, [Out] InstantiateParameters[] c);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool NSUOOFOKWZG(PKPJICLPGZO a, [Out] int b);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void FKGQOJMPAUE(PKPJICLPGZO a, [Out] int b, [Out] int[] c);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void ZVYPBPUNJDJ(int a);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void PELSGCAICFB(int a, int[] b);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void BRTKNHINJQV(int[] a);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void KXWNQFEVTNG(int[] a);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void NYNAORKTXBE(int a, int b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[ServiceLifetime(Lifetime.Application)]
	public interface DPLXUVLYZMC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void YKKMAAEYPDE(ViewId a);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool OMHJWBJTTIC(PKPJICLPGZO a, [Out] ViewId b, [Out] string c, [Out] int d, [Out] object[] e);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ROXOIDBZCUY(ViewId a, string b, RpcTarget c, HNNNRVHBOIU d, RpcCacheOption e, object[] f);
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
