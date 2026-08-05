using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Foundation;
using RecRoom.Networking.DataTypes;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Networking
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public interface DWTGDEAVLNW
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HYADYLYDQOK(ViewId a, string b, RHIZVYSCBOY c, RpcCacheOption d, params object[] parameters);

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HYADYLYDQOK(ViewId a, string b, RpcTarget c, RpcCacheOption d, params object[] parameters);

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void IINMLGXJFGC(ViewId a);

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		string TTHLELOONQR(LWCFHEHHVPK a);
	}
}
namespace RecRoom.Networking.RPC
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public interface KNRCWYSSSBZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface FTVZVRKLTVG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RpcAll<T1>(UYVXBSXSYQV.RPCAction<T1> method, T1 arg1);

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void RpcAll<T1, T2>(UYVXBSXSYQV.RPCAction<T1, T2> method, T1 arg1, T2 arg2);

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void RpcAll<T1, T2, T3, T4, T5, T6, T7>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RpcAll<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void RpcAllViaServer<T1, T2>(UYVXBSXSYQV.RPCAction<T1, T2> method, T1 arg1, T2 arg2);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void RpcOthers<T1>(UYVXBSXSYQV.RPCAction<T1> method, T1 arg1);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void RpcOthers<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void RpcPlayer(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction method);

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void RpcPlayer<T1>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1> method, T1 arg1);

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void RpcPlayer<T1, T2>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2> method, T1 arg1, T2 arg2);

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "11")]
		void RpcPlayer<T1, T2, T3>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3> method, T1 arg1, T2 arg2, T3 arg3);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "12")]
		void RpcPlayer<T1, T2, T3, T4>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "13")]
		void RpcPlayer<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> method, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "14")]
		void RpcPlayer<T1, T2>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, RPCInfo> method, T1 arg1, T2 arg2);

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "15")]
		void RpcPlayer<T1, T2, T3>(RHIZVYSCBOY player, UYVXBSXSYQV.RPCAction<T1, T2, T3, RPCInfo> method, T1 arg1, T2 arg2, T3 arg3);
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum BufferedEventCaching
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		DoNotCache = 0,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		AddToRoomCache = 4,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		AddToRoomCacheGlobal = 5
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface ZEGKUGOZUNK
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		(Type, Func<MonoBehaviour, object>)[] AGTFONRJFWE
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface CPMIWLXZEWF
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		FTVZVRKLTVG USELGNSYAYT
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class UYVXBSXSYQV
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public delegate void RPCAction();

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public delegate void RPCAction<T1>(T1 arg1);

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public delegate void RPCAction<T1, T2>(T1 arg1, T2 arg2);

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public delegate void RPCAction<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3);

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public delegate void RPCAction<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4);

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public delegate void RPCAction<T1, T2, T3, T4, T5>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5);

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public delegate void RPCAction<T1, T2, T3, T4, T5, T6>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6);

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public delegate void RPCAction<T1, T2, T3, T4, T5, T6, T7>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7);

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public delegate void RPCAction<T1, T2, T3, T4, T5, T6, T7, T8>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8);

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9);

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate void RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11);

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate void RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public delegate void RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public delegate void RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14);

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public delegate void RPCAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13, T14 arg14, T15 arg15);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public struct RPCInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly int serverTimestampInt;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly RHIZVYSCBOY Sender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly int ViewId;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public double LOAYJWPONNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8455C60", Offset = "0x8454660", VA = "0x188455C60")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8455C80", Offset = "0x8454680", VA = "0x188455C80")]
		public RPCInfo(int serverTimestampInt, RHIZVYSCBOY sender, int viewId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8455AF0", Offset = "0x84544F0", VA = "0x188455AF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
	public class RPCMethod : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
		public RPCMethod()
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
