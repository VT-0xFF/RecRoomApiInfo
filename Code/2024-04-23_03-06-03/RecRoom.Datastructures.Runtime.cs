using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6285DB0", Offset = "0x6284DB0", VA = "0x186285DB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EB340", Offset = "0x7EA340", VA = "0x1807EB340")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7EB380", Offset = "0x7EA380", VA = "0x1807EB380")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MIALFBLFPMJ : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7D00C0", Offset = "0x7CF0C0", VA = "0x1807D00C0")]
	public MIALFBLFPMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, KHGDEAKBPOK, JACPCNMJDLA, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DD0", Offset = "0x7C0DD0", VA = "0x1807C1DD0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DE0", Offset = "0x7C0DE0", VA = "0x1807C1DE0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x882610", Offset = "0x881610", VA = "0x180882610", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash NDPLPLPKLFN);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8AA680", Offset = "0x8A9680", VA = "0x1808AA680")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[ReadOnlyField]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[ReadOnlyField]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6286FF0", Offset = "0x6285FF0", VA = "0x186286FF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6286FB0", Offset = "0x6285FB0", VA = "0x186286FB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6287030", Offset = "0x6286030", VA = "0x186287030")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x62871E0", Offset = "0x62861E0", VA = "0x1862871E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6287150", Offset = "0x6286150", VA = "0x186287150")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9471F0", Offset = "0x9461F0", VA = "0x1809471F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA007F0", Offset = "0x9FF7F0", VA = "0x180A007F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6286F70", Offset = "0x6285F70", VA = "0x186286F70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x62870C0", Offset = "0x62860C0", VA = "0x1862870C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x62869E0", Offset = "0x62859E0", VA = "0x1862869E0")]
	public void CopyBounds(SavedExtents JNHFAFOIKEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6286EC0", Offset = "0x6285EC0", VA = "0x186286EC0")]
	public void SetLocalSpaceBounds(Bounds HMBECIGDFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA39530", Offset = "0xA38530", VA = "0x180A39530")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6286EB0", Offset = "0x6285EB0", VA = "0x186286EB0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6286A10", Offset = "0x6285A10", VA = "0x186286A10")]
	private void FJABLJIBFLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6286C90", Offset = "0x6285C90", VA = "0x186286C90")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6286370", Offset = "0x6285370", VA = "0x186286370")]
	public static void CalculateLocalBoundsFor(GameObject HOHLOJNOGCD, [Out] Bounds HMBECIGDFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6286BD0", Offset = "0x6285BD0", VA = "0x186286BD0")]
	private static void JIGNHJMOMCO(Bounds ABLGCHAEIGE, Color PPMIKHJHPEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6286EE0", Offset = "0x6285EE0", VA = "0x186286EE0")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7BF180", Offset = "0x7BE180", VA = "0x1807BF180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D50", Offset = "0x7C1D50", VA = "0x1807C2D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xE7BC50", Offset = "0xE7AC50", VA = "0x180E7BC50")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x44694E0", Offset = "0x44684E0", VA = "0x1844694E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "4")]
	public virtual void DBPDABNPBCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[MIALFBLFPMJ]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x44690C0", Offset = "0x44680C0", VA = "0x1844690C0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4467D60", Offset = "0x4466D60", VA = "0x184467D60", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4469410", Offset = "0x4468410", VA = "0x184469410")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class FONMNOBNHDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public FONMNOBNHDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x38E3DB0", Offset = "0x38E2DB0", VA = "0x1838E3DB0")]
		internal int GDPCMHDPIIN(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[MIALFBLFPMJ]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x353F980", Offset = "0x353E980", VA = "0x18353F980", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x353F9D0", Offset = "0x353E9D0", VA = "0x18353F9D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x353F880", Offset = "0x353E880", VA = "0x18353F880", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey OHNEPKBBADL]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x353F920", Offset = "0x353E920", VA = "0x18353F920", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x353F760", Offset = "0x353E760", VA = "0x18353F760", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x353F480", Offset = "0x353E480", VA = "0x18353F480", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x353E920", Offset = "0x353D920", VA = "0x18353E920", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x353E7D0", Offset = "0x353D7D0", VA = "0x18353E7D0", Slot = "14")]
	protected virtual string CBKMPHGHGOC(TKeyVal DJGDAECDKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x353E830", Offset = "0x353D830", VA = "0x18353E830", Slot = "4")]
	public bool ContainsKey(TKey OHNEPKBBADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x353F620", Offset = "0x353E620", VA = "0x18353F620", Slot = "5")]
	public bool TryGetValue(TKey OHNEPKBBADL, [Out] TVal LDGMLLMKHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x353E880", Offset = "0x353D880", VA = "0x18353E880", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x353E880", Offset = "0x353D880", VA = "0x18353E880", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x353F670", Offset = "0x353E670", VA = "0x18353F670")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JAPNMCADNNJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class FFJJKOJCNFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float PJHOBHPEKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T DMDNAKDAMMG;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public FFJJKOJCNFL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class AABDFBPJHGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public AABDFBPJHGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3943240", Offset = "0x3942240", VA = "0x183943240")]
		internal bool HHOEFGNKNAP(FFJJKOJCNFL sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly float KELJDPIPNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly float CMDCHGNEMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<FFJJKOJCNFL> MCJOLMLGMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private LELJPPEDFPC<FFJJKOJCNFL> FJPBAHJKDKA;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int PIIEOILGGOO
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3CC2A10", Offset = "0x3CC1A10", VA = "0x183CC2A10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3CC3630", Offset = "0x3CC2630", VA = "0x183CC3630")]
	public JAPNMCADNNJ(float EHEADCPEAHM, float OHBOGMBAECJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3CC3150", Offset = "0x3CC2150", VA = "0x183CC3150")]
	public bool GGPAJFBILHO(float DLFOHOFCHIO, T LDGMLLMKHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3CC2AF0", Offset = "0x3CC1AF0", VA = "0x183CC2AF0")]
	public IEnumerable<T> CCBLEDANACO(float DLFOHOFCHIO, [Optional] float? NGBLKCNKODG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3CC3460", Offset = "0x3CC2460", VA = "0x183CC3460")]
	public void HCLIMFMHPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3CC34D0", Offset = "0x3CC24D0", VA = "0x183CC34D0")]
	private void PPMCPEOFACM(float DLFOHOFCHIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class IEDHOJCDCLM<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct FKGEKKCMBFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public T DMDNAKDAMMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public float AHGFBGLJHGC;
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static float BJJHINBLNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private List<T> DDOJAKPJIGJ;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private const int EFCBGBPDGJJ = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private FKGEKKCMBFE[] PAFIMPMPKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int IIILAFOLLLL;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float GNAIKHADJLG
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x858EA0", Offset = "0x857EA0", VA = "0x180858EA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x87AB30", Offset = "0x879B30", VA = "0x18087AB30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE550", Offset = "0x3AED550", VA = "0x183AEE550")]
	public IEDHOJCDCLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE570", Offset = "0x3AED570", VA = "0x183AEE570")]
	public IEDHOJCDCLM(int GFFAGBDKDAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3AED730", Offset = "0x3AEC730", VA = "0x183AED730")]
	public void BGLDHBEBEIE(float DLFOHOFCHIO, T LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE030", Offset = "0x3AED030", VA = "0x183AEE030")]
	public void HCLIMFMHPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3AEDBB0", Offset = "0x3AECBB0", VA = "0x183AEDBB0")]
	public bool GOKPLBDJDPC(float BGLHBBHPGOI, float MANOKJNBFON, [Out] T LDGMLLMKHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3AED7F0", Offset = "0x3AEC7F0", VA = "0x183AED7F0")]
	public bool DMOONLNGNGJ(float BGLHBBHPGOI, float MANOKJNBFON, [Out] T LDGMLLMKHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE260", Offset = "0x3AED260", VA = "0x183AEE260")]
	public void PHMCBJOBKDM(float BGLHBBHPGOI, float MANOKJNBFON, List<T> IDAJCEMIFPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3AEDB80", Offset = "0x3AECB80", VA = "0x183AEDB80")]
	private int DNKHJIBAEGK(int MOLGHIAMJIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3AEE210", Offset = "0x3AED210", VA = "0x183AEE210")]
	private void JALKNOEJGLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T KNOMDKNACGE();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T LPLKHMLMMNO(T LDGMLLMKHLF, float DCCCOAOAGBH);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T JFKCMLEKCMK(T LEGDDGHJEMC, T KNJHKKJANOJ);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T JLDLLBDBBLA(T LEGDDGHJEMC, T KNJHKKJANOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ALHBIADBBAD : IEDHOJCDCLM<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7D0950", Offset = "0x7CF950", VA = "0x1807D0950", Slot = "4")]
	protected override Vector3 KNOMDKNACGE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6282A70", Offset = "0x6281A70", VA = "0x186282A70", Slot = "5")]
	protected override Vector3 LPLKHMLMMNO(Vector3 LDGMLLMKHLF, float DCCCOAOAGBH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x62829A0", Offset = "0x62819A0", VA = "0x1862829A0", Slot = "6")]
	protected override Vector3 JFKCMLEKCMK(Vector3 LEGDDGHJEMC, Vector3 KNJHKKJANOJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x62829F0", Offset = "0x62819F0", VA = "0x1862829F0", Slot = "7")]
	protected override Vector3 JLDLLBDBBLA(Vector3 LEGDDGHJEMC, Vector3 KNJHKKJANOJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6282AB0", Offset = "0x6281AB0", VA = "0x186282AB0")]
	public ALHBIADBBAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class OEBAPJEJGIJ
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2A40720", Offset = "0x2A3F720", VA = "0x182A40720")]
	public static ICCNAAKNKGE<T1, T2> EOFBBDOECDH<T1, T2>(T1 CKCFEILEIOM, T2 CFMNIFADLHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2A407A0", Offset = "0x2A3F7A0", VA = "0x182A407A0")]
	public static FLMCOKGNGMG<T1, T2, T3> EOFBBDOECDH<T1, T2, T3>(T1 CKCFEILEIOM, T2 CFMNIFADLHA, T3 JODEJFBGOFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4091DA0", Offset = "0x4090DA0", VA = "0x184091DA0")]
	internal static int BOFLMALHBJM(int GIHICDHKBLM, int GFODPGABMIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5699900", Offset = "0x5698900", VA = "0x185699900")]
	internal static int BOFLMALHBJM(int GIHICDHKBLM, int GFODPGABMIJ, int IADLOGPCIKJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class ICCNAAKNKGE<T1, T2> : IComparable<ICCNAAKNKGE<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T1 HJIJLNADHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly T2 LFNHHJBOJGP;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3AE6480", Offset = "0x3AE5480", VA = "0x183AE6480")]
	public ICCNAAKNKGE(T1 CKCFEILEIOM, T2 CFMNIFADLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3AE4F20", Offset = "0x3AE3F20", VA = "0x183AE4F20", Slot = "4")]
	public int CompareTo(ICCNAAKNKGE<T1, T2> JNHFAFOIKEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3AE5180", Offset = "0x3AE4180", VA = "0x183AE5180", Slot = "0")]
	public override bool Equals(object JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3AE5BB0", Offset = "0x3AE4BB0", VA = "0x183AE5BB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3AE5E60", Offset = "0x3AE4E60", VA = "0x183AE5E60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FLMCOKGNGMG<T1, T2, T3> : IComparable<FLMCOKGNGMG<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T1 HJIJLNADHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T2 LFNHHJBOJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T3 AGNNMPPBNOI;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x38A4DE0", Offset = "0x38A3DE0", VA = "0x1838A4DE0")]
	public FLMCOKGNGMG(T1 CKCFEILEIOM, T2 CFMNIFADLHA, T3 JODEJFBGOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x38A45F0", Offset = "0x38A35F0", VA = "0x1838A45F0", Slot = "4")]
	public int CompareTo(FLMCOKGNGMG<T1, T2, T3> JNHFAFOIKEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x38A4830", Offset = "0x38A3830", VA = "0x1838A4830", Slot = "0")]
	public override bool Equals(object JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x38A4A70", Offset = "0x38A3A70", VA = "0x1838A4A70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x38A4B10", Offset = "0x38A3B10", VA = "0x1838A4B10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T DMDNAKDAMMG
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x21B5CE0", Offset = "0x21B4CE0", VA = "0x1821B5CE0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x21B5D80", Offset = "0x21B4D80", VA = "0x1821B5D80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float EPFGEMLJJID
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8C4590", Offset = "0x8C3590", VA = "0x1808C4590")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4666E80", Offset = "0x4665E80", VA = "0x184666E80")]
	public T HDLJCIBAOOM(float DCCCOAOAGBH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4667040", Offset = "0x4666040", VA = "0x184667040")]
	public T HNMDJMAGKGK(float DCCCOAOAGBH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T IDDJOCNAMBM(T LEGDDGHJEMC, T KNJHKKJANOJ, float DCCCOAOAGBH);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6282C90", Offset = "0x6281C90", VA = "0x186282C90", Slot = "4")]
	protected override float IDDJOCNAMBM(float LEGDDGHJEMC, float KNJHKKJANOJ, float DCCCOAOAGBH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6282CD0", Offset = "0x6281CD0", VA = "0x186282CD0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xD09DB0", Offset = "0xD08DB0", VA = "0x180D09DB0", Slot = "4")]
	protected override Vector3 IDDJOCNAMBM(Vector3 LEGDDGHJEMC, Vector3 KNJHKKJANOJ, float DCCCOAOAGBH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6287EF0", Offset = "0x6286EF0", VA = "0x186287EF0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6282B10", Offset = "0x6281B10", VA = "0x186282B10", Slot = "4")]
	protected override Color IDDJOCNAMBM(Color LEGDDGHJEMC, Color KNJHKKJANOJ, float DCCCOAOAGBH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6282BD0", Offset = "0x6281BD0", VA = "0x186282BD0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class IOHMEMBCAHK : LHMFDCIIDCM<string>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x62843F0", Offset = "0x62833F0", VA = "0x1862843F0")]
	public IOHMEMBCAHK(int AFDLPCPCHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6284380", Offset = "0x6283380", VA = "0x186284380", Slot = "6")]
	protected override uint DBJOAHNDFOO(uint NDPLPLPKLFN, string LDGMLLMKHLF)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EPPDKKHMKDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly IDisposable AFPJCELPLKK;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	public EPPDKKHMKDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct ENDEAGHNKOH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> ONEKNGOKKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int HKHGPNGOOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int HAGNIEAHPAJ;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3524660", Offset = "0x3523660", VA = "0x183524660")]
	private ENDEAGHNKOH(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> ENJNNPGEDJN, int NEJONAIEIIG, int CFKKHALFKIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3522A60", Offset = "0x3521A60", VA = "0x183522A60")]
	public static ENDEAGHNKOH<T> MGIIAIMPALM()
	{
		return default(ENDEAGHNKOH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3523FA0", Offset = "0x3522FA0", VA = "0x183523FA0")]
	public (int, int, Task<T>) PMCGLFACBPG(int BFJJJMDOJBG, [Optional] CancellationToken GHLJDIEPICD, double FHPCLBOOPLN = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3522680", Offset = "0x3521680", VA = "0x183522680")]
	public void IIALHKNDIDK(int BFJJJMDOJBG, int CFKKHALFKIN, [In] T NIKEINPNLMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class HOKPGIFMFKM
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6284330", Offset = "0x6283330", VA = "0x186284330")]
	public static ENDEAGHNKOH<KLKJPNNICPF> MGIIAIMPALM()
	{
		return default(ENDEAGHNKOH<KLKJPNNICPF>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x62842B0", Offset = "0x62832B0", VA = "0x1862842B0")]
	public static void IIALHKNDIDK([In] this ENDEAGHNKOH<KLKJPNNICPF> HFLBADIEKAM, int BFJJJMDOJBG, int CFKKHALFKIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class LGAMCOELBAN<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TVal> LGHIBJHIOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly Dictionary<TVal, TKey> EDEBBEOGOBD;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int JFLFCJGPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x329FD00", Offset = "0x329ED00", VA = "0x18329FD00", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool CNGKFBOLNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> DKCBCEDMAAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3A288E0", Offset = "0x3A278E0", VA = "0x183A288E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> DIPPIPHGCOB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3E2D5C0", Offset = "0x3E2C5C0", VA = "0x183E2D5C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal EAGDGAFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3E2D510", Offset = "0x3E2C510", VA = "0x183E2D510", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3E2D620", Offset = "0x3E2C620", VA = "0x183E2D620", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey EAGDGAFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3E2D210", Offset = "0x3E2C210", VA = "0x183E2D210")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3E2CAC0", Offset = "0x3E2BAC0", VA = "0x183E2CAC0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3E2D2F0", Offset = "0x3E2C2F0", VA = "0x183E2D2F0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3E2CA90", Offset = "0x3E2BA90", VA = "0x183E2CA90", Slot = "9")]
	public void Add(TKey OHNEPKBBADL, TVal LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3E2CA20", Offset = "0x3E2BA20", VA = "0x183E2CA20", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LLMAIFIKIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3E2CB20", Offset = "0x3E2BB20", VA = "0x183E2CB20", Slot = "8")]
	public bool ContainsKey(TKey OHNEPKBBADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3E2CB90", Offset = "0x3E2BB90", VA = "0x183E2CB90", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> LLMAIFIKIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3E2D290", Offset = "0x3E2C290", VA = "0x183E2D290", Slot = "10")]
	public bool Remove(TKey OHNEPKBBADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3E2D2C0", Offset = "0x3E2C2C0", VA = "0x183E2D2C0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> LLMAIFIKIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3E2D3E0", Offset = "0x3E2C3E0", VA = "0x183E2D3E0", Slot = "11")]
	public bool TryGetValue(TKey OHNEPKBBADL, [Out] TVal LDGMLLMKHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3E2CD10", Offset = "0x3E2BD10", VA = "0x183E2CD10", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3E2CBF0", Offset = "0x3E2BBF0", VA = "0x183E2CBF0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] PAFIMPMPKHD, int PKIBMLHJLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3E2CC70", Offset = "0x3E2BC70", VA = "0x183E2CC70")]
	public bool DKPMPOAPJNG(TVal OHNEPKBBADL, [Out] TKey LDGMLLMKHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3E2D120", Offset = "0x3E2C120", VA = "0x183E2D120")]
	private void LNELJHJLNKB(TKey OHNEPKBBADL, TVal PAFHPJKJPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3E2CE40", Offset = "0x3E2BE40", VA = "0x183E2CE40")]
	private void JALDCFANOEM(TKey OHNEPKBBADL, TVal PAFHPJKJPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3E2C850", Offset = "0x3E2B850", VA = "0x183E2C850")]
	private bool AAMKDMIEKPG(TKey OHNEPKBBADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3E2D420", Offset = "0x3E2C420", VA = "0x183E2D420")]
	public LGAMCOELBAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public class FKEADACHLOD<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private FKEADACHLOD<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x35888F0", Offset = "0x35878F0", VA = "0x1835888F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x3596350", Offset = "0x3595350", VA = "0x183596350", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x35977A0", Offset = "0x35967A0", VA = "0x1835977A0")]
		public Enumerator(FKEADACHLOD<T> IDAJCEMIFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x35935E0", Offset = "0x35925E0", VA = "0x1835935E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3595050", Offset = "0x3594050", VA = "0x183595050", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x35932F0", Offset = "0x35922F0", VA = "0x1835932F0")]
		private void AAFJLFBLNIN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private T[] APMPJCBODOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int GOABEOHPNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int HBLCAIEOHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int OECHNNBOAGJ;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int JFLFCJGPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x389BEC0", Offset = "0x389AEC0", VA = "0x18389BEC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T EAGDGAFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x389BFE0", Offset = "0x389AFE0", VA = "0x18389BFE0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x389B4D0", Offset = "0x389A4D0", VA = "0x18389B4D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x389C550", Offset = "0x389B550", VA = "0x18389C550")]
	public FKEADACHLOD(int AFDLPCPCHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x389B1F0", Offset = "0x389A1F0", VA = "0x18389B1F0")]
	public void BGLDHBEBEIE(T DCCCOAOAGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x389B6E0", Offset = "0x389A6E0", VA = "0x18389B6E0")]
	public void HCLIMFMHPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x389C1B0", Offset = "0x389B1B0", VA = "0x18389C1B0")]
	public void PDKHCNDMKAG(int MJMIIGGLEFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x389A900", Offset = "0x3899900", VA = "0x18389A900")]
	public void BBJAIFPKNAJ(T[] PAFIMPMPKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x389B740", Offset = "0x389A740", VA = "0x18389B740")]
	public Enumerator IEKFBOGGJFJ()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x389C2E0", Offset = "0x389B2E0", VA = "0x18389C2E0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x389C2E0", Offset = "0x389B2E0", VA = "0x18389C2E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x389BA50", Offset = "0x389AA50", VA = "0x18389BA50")]
	private int JJHDOJCFJGI(int GPEHCABDGEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x389BE90", Offset = "0x389AE90", VA = "0x18389BE90")]
	private int KDBGHDFHNLI(int GPEHCABDGEJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class IENAPFDHOBP<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate Task<TResult> HOPGGCMNLML(TRequest MJJCOLDOFAC, CancellationToken GHLJDIEPICD);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum ACINAJKOJOG
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class JIDPECLJIFD
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float PALPFJCBOBL = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TimeSpan KIPOLILAJCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int DGNDLJHJMEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public ACINAJKOJOG KECJLBFOPMD;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly JIDPECLJIFD FNEBJKDLGHG;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float OLEPHLADLLP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x3CD14C0", Offset = "0x3CD04C0", VA = "0x183CD14C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public TimeSpan KPMIKDNOGKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x3CD15A0", Offset = "0x3CD05A0", VA = "0x183CD15A0")]
		public JIDPECLJIFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private readonly struct MDPAJGKNCAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly TRequest MJJCOLDOFAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly CancellationToken GHLJDIEPICD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly TaskCompletionSource<TResult> JJEONHGCOBI;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4021BD0", Offset = "0x4020BD0", VA = "0x184021BD0")]
		public MDPAJGKNCAM(TRequest MJJCOLDOFAC, TaskCompletionSource<TResult> JJEONHGCOBI, CancellationToken GHLJDIEPICD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct MHBBLLECMHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IENAPFDHOBP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4033C20", Offset = "0x4032C20", VA = "0x184033C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4034060", Offset = "0x4033060", VA = "0x184034060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct CIKIBBNBEGD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IENAPFDHOBP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private MDPAJGKNCAM <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x4CAEE30", Offset = "0x4CADE30", VA = "0x184CAEE30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4CAFFA0", Offset = "0x4CAEFA0", VA = "0x184CAFFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CancellationTokenSource JDPIDALIHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<MDPAJGKNCAM> CBIIBICAKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly JIDPECLJIFD BHNKNBKHHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly HOPGGCMNLML OHOAIJKBLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Task OEAKNKONGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int PMGOJFHACML;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3AF1000", Offset = "0x3AF0000", VA = "0x183AF1000")]
	public IENAPFDHOBP(HOPGGCMNLML OHOAIJKBLNJ, [Optional] JIDPECLJIFD BHNKNBKHHOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3AEF6D0", Offset = "0x3AEE6D0", VA = "0x183AEF6D0")]
	public Task<TResult> GAGHHIHGMNG(TRequest MJJCOLDOFAC, CancellationToken GHLJDIEPICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3AEF550", Offset = "0x3AEE550", VA = "0x183AEF550")]
	private void DJNECBCMGPH(MDPAJGKNCAM CENPAOLFNIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3AEFFF0", Offset = "0x3AEEFF0", VA = "0x183AEFFF0")]
	[AsyncStateMachine(typeof(IENAPFDHOBP<, >.MHBBLLECMHI))]
	private Task HIKOOHGNHAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0530", Offset = "0x3AEF530", VA = "0x183AF0530")]
	private MDPAJGKNCAM PJGAIJBGFIH()
	{
		return default(MDPAJGKNCAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3AEFF00", Offset = "0x3AEEF00", VA = "0x183AEFF00")]
	[AsyncStateMachine(typeof(IENAPFDHOBP<, >.CIKIBBNBEGD))]
	private Task GPOMKHAMPOK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3AF0350", Offset = "0x3AEF350", VA = "0x183AF0350")]
	private void MGCEDDJGPNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3AEF690", Offset = "0x3AEE690", VA = "0x183AEF690", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class GAKOBKMNCNK<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly List<T> FKIBLLNGEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<T> DLNDAKEELGE;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int JFLFCJGPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x329FD00", Offset = "0x329ED00", VA = "0x18329FD00", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool CNGKFBOLNJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T EAGDGAFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x394AC00", Offset = "0x3949C00", VA = "0x18394AC00", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3994390", Offset = "0x3993390", VA = "0x183994390", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x353B4B0", Offset = "0x353A4B0", VA = "0x18353B4B0", Slot = "11")]
	public void Add(T LLMAIFIKIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3993A70", Offset = "0x3992A70", VA = "0x183993A70")]
	public bool EHKMNAJLKME(T LLMAIFIKIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3994120", Offset = "0x3993120", VA = "0x183994120", Slot = "15")]
	public bool Remove(T LLMAIFIKIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3993BF0", Offset = "0x3992BF0", VA = "0x183993BF0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3909A20", Offset = "0x3908A20", VA = "0x183909A20", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x39939A0", Offset = "0x39929A0", VA = "0x1839939A0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3993A00", Offset = "0x3992A00", VA = "0x183993A00", Slot = "13")]
	public bool Contains(T LLMAIFIKIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3993A40", Offset = "0x3992A40", VA = "0x183993A40", Slot = "14")]
	public void CopyTo(T[] PAFIMPMPKHD, int PKIBMLHJLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3993C80", Offset = "0x3992C80", VA = "0x183993C80", Slot = "6")]
	public int IndexOf(T LLMAIFIKIOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3993CD0", Offset = "0x3992CD0", VA = "0x183993CD0", Slot = "7")]
	public void Insert(int GPEHCABDGEJ, T LLMAIFIKIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3993F90", Offset = "0x3992F90", VA = "0x183993F90", Slot = "8")]
	public void RemoveAt(int GPEHCABDGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x39941C0", Offset = "0x39931C0", VA = "0x1839941C0")]
	public GAKOBKMNCNK()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x200FF20", Offset = "0x200EF20", VA = "0x18200FF20")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6287580", Offset = "0x6286580", VA = "0x186287580")]
		public SerializedGuid([In] Guid KAABLCGOLKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x62872A0", Offset = "0x62862A0", VA = "0x1862872A0")]
		public static SerializedGuid DGEPOOPKPKK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6287320", Offset = "0x6286320", VA = "0x186287320")]
		public static SerializedGuid EHKDKLOGIKP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6287470", Offset = "0x6286470", VA = "0x186287470")]
		public bool JEAENFCBEFE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6287550", Offset = "0x6286550", VA = "0x186287550", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x62874D0", Offset = "0x62864D0", VA = "0x1862874D0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6287390", Offset = "0x6286390", VA = "0x186287390", Slot = "7")]
		public bool Equals(SerializedGuid JNHFAFOIKEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x62873D0", Offset = "0x62863D0", VA = "0x1862873D0", Slot = "0")]
		public override bool Equals(object KDEEPMDJGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6287460", Offset = "0x6286460", VA = "0x186287460", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6287270", Offset = "0x6286270", VA = "0x186287270", Slot = "6")]
		public int CompareTo(SerializedGuid JNHFAFOIKEO)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class HNFIGECNLJD : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly Type EPLHKCLKJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string GODMAMDCODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool CGKNOLDPCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool GIFNOJBDGHP;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6284240", Offset = "0x6283240", VA = "0x186284240")]
	public HNFIGECNLJD(Type LPICPHCBBGJ, string DOEEMGMPDDL, bool FJACKIHLCCF = false, bool IPCNEHEMDKH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class NENCAGLHEIB<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public readonly struct HBOOKNHAKDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly long OGGDCCDGLHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly long NBALOFFCAEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly int JEACHJENPLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly int IDKDEBNCAGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool OODMNMJHMBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly string OINILNFLOPK;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x3A03160", Offset = "0x3A02160", VA = "0x183A03160")]
		public HBOOKNHAKDH(long OGGDCCDGLHC, int JEACHJENPLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x3A031D0", Offset = "0x3A021D0", VA = "0x183A031D0")]
		public HBOOKNHAKDH(long OGGDCCDGLHC, long NBALOFFCAEI, int JEACHJENPLO, int IDKDEBNCAGP, bool OODMNMJHMBK, string OINILNFLOPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x3A02FF0", Offset = "0x3A01FF0", VA = "0x183A02FF0")]
		public int ABDGFLMFKGC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3A03140", Offset = "0x3A02140", VA = "0x183A03140")]
		public int PJLDKDLHJKM(int NEDAIIJGIJG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x3A03040", Offset = "0x3A02040", VA = "0x183A03040")]
		public double DIJBIFPMJDN()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3A030A0", Offset = "0x3A020A0", VA = "0x183A030A0")]
		public HBOOKNHAKDH IONJMHALODP(long NBALOFFCAEI, int IDKDEBNCAGP)
		{
			return default(HBOOKNHAKDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class OGJMFKKDMDA : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct JKOFEKJHKCK<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public OGJMFKKDMDA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Func<OGJMFKKDMDA, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private OGJMFKKDMDA <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x3CF9560", Offset = "0x3CF8560", VA = "0x183CF9560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3519210", Offset = "0x3518210", VA = "0x183519210", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly TKey KFDLNEFCHIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NENCAGLHEIB<TKey> OCBBLMCOHCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly NDLEKAMCBHL LAGKGKDNMJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private List<OGJMFKKDMDA> IEKMCKEGLJE;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string HMFBHGJFNNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x41C9030", Offset = "0x41C8030", VA = "0x1841C9030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IEnumerable<OGJMFKKDMDA> CLDMIFOOGLI
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x41C9080", Offset = "0x41C8080", VA = "0x1841C9080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public HBOOKNHAKDH NMPFGDFPCFF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x41C9060", Offset = "0x41C8060", VA = "0x1841C9060")]
			[CompilerGenerated]
			get
			{
				return default(HBOOKNHAKDH);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x41C8CA0", Offset = "0x41C7CA0", VA = "0x1841C8CA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x41C90C0", Offset = "0x41C80C0", VA = "0x1841C90C0")]
		internal OGJMFKKDMDA(NENCAGLHEIB<TKey> OCBBLMCOHCB, TKey OHNEPKBBADL, NDLEKAMCBHL LAGKGKDNMJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x41C8CD0", Offset = "0x41C7CD0", VA = "0x1841C8CD0")]
		public OGJMFKKDMDA DDJAPDMANCP(TKey OHNEPKBBADL, [Optional] NDLEKAMCBHL? KPPLLDNCAAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2886B10", Offset = "0x2885B10", VA = "0x182886B10")]
		[AsyncStateMachine(typeof(JKOFEKJHKCK<>))]
		public Task<T> OKFHCKPCLHG<T>(TKey OHNEPKBBADL, Func<OGJMFKKDMDA, Task<T>> DCLBDAHBMFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x41C8E30", Offset = "0x41C7E30", VA = "0x1841C8E30", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class GKFBOMPGOLC : IEnumerable<(TKey, List<TKey>, HBOOKNHAKDH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, HBOOKNHAKDH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private (TKey key, List<TKey> path, HBOOKNHAKDH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public NENCAGLHEIB<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<(TKey key, List<TKey> path, HBOOKNHAKDH timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private (TKey, List<TKey>, HBOOKNHAKDH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x201B8A0", Offset = "0x201A8A0", VA = "0x18201B8A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, HBOOKNHAKDH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x39B6650", Offset = "0x39B5650", VA = "0x1839B6650", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x201B990", Offset = "0x201A990", VA = "0x18201B990")]
		[DebuggerHidden]
		public GKFBOMPGOLC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x368B020", Offset = "0x368A020", VA = "0x18368B020", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x39B61A0", Offset = "0x39B51A0", VA = "0x1839B61A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x39B6150", Offset = "0x39B5150", VA = "0x1839B6150")]
		private void HPAIKACEAJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x39B6600", Offset = "0x39B5600", VA = "0x1839B6600", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x39B6540", Offset = "0x39B5540", VA = "0x1839B6540", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, HBOOKNHAKDH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x37E47F0", Offset = "0x37E37F0", VA = "0x1837E47F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class JAMMBODGJLP : IEnumerable<(TKey, List<TKey>, HBOOKNHAKDH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, HBOOKNHAKDH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private (TKey key, List<TKey> path, HBOOKNHAKDH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private OGJMFKKDMDA timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public OGJMFKKDMDA <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public NENCAGLHEIB<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IEnumerator<OGJMFKKDMDA> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IEnumerator<(TKey key, List<TKey> path, HBOOKNHAKDH timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, HBOOKNHAKDH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x201B8A0", Offset = "0x201A8A0", VA = "0x18201B8A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, HBOOKNHAKDH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x3CC2850", Offset = "0x3CC1850", VA = "0x183CC2850", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x201B990", Offset = "0x201A990", VA = "0x18201B990")]
		[DebuggerHidden]
		public JAMMBODGJLP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3CC28B0", Offset = "0x3CC18B0", VA = "0x183CC28B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3CC1F40", Offset = "0x3CC0F40", VA = "0x183CC1F40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3CC1EE0", Offset = "0x3CC0EE0", VA = "0x183CC1EE0")]
		private void HPAIKACEAJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3CC1E80", Offset = "0x3CC0E80", VA = "0x183CC1E80")]
		private void DGKIMGJJCCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3CC2800", Offset = "0x3CC1800", VA = "0x183CC2800", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3CC26F0", Offset = "0x3CC16F0", VA = "0x183CC26F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, HBOOKNHAKDH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3CC27D0", Offset = "0x3CC17D0", VA = "0x183CC27D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Action<TKey, HBOOKNHAKDH, NDLEKAMCBHL> DKAJBMDLMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Action<TKey, HBOOKNHAKDH, NDLEKAMCBHL> LKCHBMAINJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Action<NENCAGLHEIB<TKey>, NDLEKAMCBHL> PJEFPKCPHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly NDLEKAMCBHL LAGKGKDNMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly OGJMFKKDMDA PDLFGMIJKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool OBBFCMJHMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int BLNBGFAKFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Stopwatch OHMJIOEBGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly int DDLDJPOLMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string CAPGJFAONLP;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public OGJMFKKDMDA FMNPDMOMLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7C5860", Offset = "0x7C4860", VA = "0x1807C5860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	[NotNull]
	public string HMFBHGJFNNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7C79B0", Offset = "0x7C69B0", VA = "0x1807C79B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x40B8900", Offset = "0x40B7900", VA = "0x1840B8900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x40B8B40", Offset = "0x40B7B40", VA = "0x1840B8B40")]
	public NENCAGLHEIB(TKey APJFECJBOIA, NDLEKAMCBHL LAGKGKDNMJM, [Optional] int? JEACHJENPLO, [Optional][CanBeNull] Stopwatch OHMJIOEBGLB, [Optional] Action<TKey, HBOOKNHAKDH, NDLEKAMCBHL> DKAJBMDLMAI, [Optional] Action<TKey, HBOOKNHAKDH, NDLEKAMCBHL> LKCHBMAINJA, [Optional] Action<NENCAGLHEIB<TKey>, NDLEKAMCBHL> PJEFPKCPHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x40B8870", Offset = "0x40B7870", VA = "0x1840B8870", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x40B8AB0", Offset = "0x40B7AB0", VA = "0x1840B8AB0")]
	[IteratorStateMachine(typeof(NENCAGLHEIB<>.GKFBOMPGOLC))]
	public IEnumerable<(TKey, List<TKey>, HBOOKNHAKDH)> MGBKNCNHHDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x40B89E0", Offset = "0x40B79E0", VA = "0x1840B89E0")]
	[IteratorStateMachine(typeof(NENCAGLHEIB<>.JAMMBODGJLP))]
	private IEnumerable<(TKey, List<TKey>, HBOOKNHAKDH)> MGBKNCNHHDD(List<TKey> OCKDOKGOPLB, OGJMFKKDMDA KAGGJMJEOKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x40B8960", Offset = "0x40B7960", VA = "0x1840B8960")]
	private (long, int) KBCNOBGBPHP()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public abstract class EEELIKLEIDM<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut HBJCPOFMLKN(NENCAGLHEIB<TKey> OCBBLMCOHCB);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	protected EEELIKLEIDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class CCLFDLAFNKJ<TKey> : EEELIKLEIDM<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate string KLJHKLNEGEL(TKey OHNEPKBBADL);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4BDEB50", Offset = "0x4BDDB50", VA = "0x184BDEB50")]
	private static string BDBEOBAPDAO(TKey OHNEPKBBADL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x4BDECE0", Offset = "0x4BDDCE0", VA = "0x184BDECE0", Slot = "4")]
	public override string HBJCPOFMLKN(NENCAGLHEIB<TKey> OCBBLMCOHCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4BDEB90", Offset = "0x4BDDB90", VA = "0x184BDEB90")]
	public string HBJCPOFMLKN(NENCAGLHEIB<TKey> OCBBLMCOHCB, [NotNull] KLJHKLNEGEL BKLCBABAONP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string EFFFHBCPGIP(NENCAGLHEIB<TKey> OCBBLMCOHCB, [NotNull] KLJHKLNEGEL BKLCBABAONP);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x34E8EC0", Offset = "0x34E7EC0", VA = "0x1834E8EC0")]
	protected CCLFDLAFNKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class EFNHBEGDEDB<TKey> : EEELIKLEIDM<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate string GNPNDFBAIIK(TKey OHNEPKBBADL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly string GHHAJFIMAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly double GKHDJIKCHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly bool IEEBNIGHLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly int NGFCOGKOADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ISet<string> HDEPFKCJCFP;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x350AA50", Offset = "0x3509A50", VA = "0x18350AA50")]
	private static string BDBEOBAPDAO(TKey OHNEPKBBADL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x350B5C0", Offset = "0x350A5C0", VA = "0x18350B5C0")]
	public EFNHBEGDEDB(string GHHAJFIMAMF = "F2", double GKHDJIKCHLP = double.MaxValue, bool IEEBNIGHLKB = false, int NGFCOGKOADO = int.MaxValue, [Optional] ISet<string> HDEPFKCJCFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x350B080", Offset = "0x350A080", VA = "0x18350B080", Slot = "4")]
	public override Dictionary<string, string> HBJCPOFMLKN(NENCAGLHEIB<TKey> OCBBLMCOHCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x350B140", Offset = "0x350A140", VA = "0x18350B140")]
	private bool HKKFADFCHFG(string IAFFCCHLNKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x350AA90", Offset = "0x3509A90", VA = "0x18350AA90")]
	public Dictionary<string, string> HBJCPOFMLKN(NENCAGLHEIB<TKey> OCBBLMCOHCB, GNPNDFBAIIK BKLCBABAONP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x350B220", Offset = "0x350A220", VA = "0x18350B220")]
	private string LMDHGNEBPHI(StringBuilder CDGCGHAGBME, List<TKey> NAPLIFKKHAK, GNPNDFBAIIK BKLCBABAONP, bool HKAPGFFJHLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x350B460", Offset = "0x350A460", VA = "0x18350B460")]
	private static void LOIGMKPJMNP(StringBuilder FJKGGDCIJGL, string BBKFMCOIEKH, bool JMNEAMABOCF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class LGCEJAIJOLP<TKey> : CCLFDLAFNKJ<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct CBCOFMFANGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public KLJHKLNEGEL keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static LGCEJAIJOLP<TKey> AFPJCELPLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly string[] JMMJHLODNJJ;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3E2E6D0", Offset = "0x3E2D6D0", VA = "0x183E2E6D0")]
	private LGCEJAIJOLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3E2D740", Offset = "0x3E2C740", VA = "0x183E2D740", Slot = "5")]
	protected override string EFFFHBCPGIP(NENCAGLHEIB<TKey> OCBBLMCOHCB, KLJHKLNEGEL BKLCBABAONP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3E2D650", Offset = "0x3E2C650", VA = "0x183E2D650")]
	[CompilerGenerated]
	internal static string CLOMIAGGMDG(string LMKHAEFNNPK, TKey OHNEPKBBADL, CBCOFMFANGJ P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class JLCHBIEDNJM : NENCAGLHEIB<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class NHAEKCDFOLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action<JLCHBIEDNJM, NDLEKAMCBHL> callback;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public NHAEKCDFOLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6285D20", Offset = "0x6284D20", VA = "0x186285D20")]
		internal void CPDFFKADMPF(NENCAGLHEIB<string> timer, NDLEKAMCBHL log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6284500", Offset = "0x6283500", VA = "0x186284500")]
	public JLCHBIEDNJM(NDLEKAMCBHL LAGKGKDNMJM, [Optional] string BADANOADNKG, [Optional] int? JEACHJENPLO, [Optional] Stopwatch OHMJIOEBGLB, [Optional] Action<string, HBOOKNHAKDH, NDLEKAMCBHL> DKAJBMDLMAI, [Optional] Action<string, HBOOKNHAKDH, NDLEKAMCBHL> LKCHBMAINJA, [Optional] Action<JLCHBIEDNJM, NDLEKAMCBHL> PJEFPKCPHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6284440", Offset = "0x6283440", VA = "0x186284440")]
	private static Action<NENCAGLHEIB<string>, NDLEKAMCBHL> BOEKCMPEBMO(Action<JLCHBIEDNJM, NDLEKAMCBHL> HLFIKKGGCCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class KIBMBAIGEMH
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private class JNMKHHBBJGP : KIBMBAIGEMH
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static KIBMBAIGEMH AFPJCELPLKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x6284650", Offset = "0x6283650", VA = "0x186284650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override float HMIKKHILAFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x85ACE0", Offset = "0x859CE0", VA = "0x18085ACE0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6284750", Offset = "0x6283750", VA = "0x186284750")]
		public JNMKHHBBJGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static KIBMBAIGEMH APLLLOBEBCJ;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static KIBMBAIGEMH FNEBJKDLGHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x62847A0", Offset = "0x62837A0", VA = "0x1862847A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public abstract float HMIKKHILAFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
	protected KIBMBAIGEMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface GHIFGBAJKGA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool NPKMANILOIC
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface DBHPMDCPDMB<T> : GHIFGBAJKGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> LGFPBBDHJOF
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	MLBHOBCFFDI<T> OKGNACLGNGC
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class IPCBDJKHEKD
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private sealed class BELPOPBKIOK<T> : JLHBIPGOHJN<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override Task<T?> LGFPBBDHJOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override MLBHOBCFFDI<T?> OKGNACLGNGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x48F4A80", Offset = "0x48F3A80", VA = "0x1848F4A80")]
		public BELPOPBKIOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "10")]
		protected override void KAAFCIFHHIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private sealed class OFGDJDFANKJ<T> : JLHBIPGOHJN<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T> LGFPBBDHJOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override MLBHOBCFFDI<T> OKGNACLGNGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x41BBBF0", Offset = "0x41BABF0", VA = "0x1841BBBF0")]
		public OFGDJDFANKJ(Exception BDHJMINHKON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "10")]
		protected override void KAAFCIFHHIB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private sealed class HJOLEJMNMFP<T> : JLHBIPGOHJN<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private struct EPBEHELOGHC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public Task<DBHPMDCPDMB<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private TaskAwaiter<DBHPMDCPDMB<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x353AC90", Offset = "0x3539C90", VA = "0x18353AC90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x353B180", Offset = "0x353A180", VA = "0x18353B180", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private struct EEMIHJLFBKP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public Task<DBHPMDCPDMB<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private TaskAwaiter<DBHPMDCPDMB<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x34E8EE0", Offset = "0x34E7EE0", VA = "0x1834E8EE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x34E9110", Offset = "0x34E8110", VA = "0x1834E9110", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Task<DBHPMDCPDMB<T>> JADMCDLDPOC;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> LGFPBBDHJOF
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override MLBHOBCFFDI<T> OKGNACLGNGC
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x7C3F20", Offset = "0x7C2F20", VA = "0x1807C3F20", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3A17AF0", Offset = "0x3A16AF0", VA = "0x183A17AF0")]
		public HJOLEJMNMFP(Task<DBHPMDCPDMB<T>> BKJCIFOIBEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3A17A60", Offset = "0x3A16A60", VA = "0x183A17A60", Slot = "10")]
		protected override void KAAFCIFHHIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3A17900", Offset = "0x3A16900", VA = "0x183A17900")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(HJOLEJMNMFP<>.EPBEHELOGHC))]
		internal static Task<T> EEINBKJBBFH(Task<DBHPMDCPDMB<T>> BKJCIFOIBEF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3A17810", Offset = "0x3A16810", VA = "0x183A17810")]
		[AsyncStateMachine(typeof(HJOLEJMNMFP<>.EEMIHJLFBKP))]
		[CompilerGenerated]
		internal static Task CHCEFHPOOGO(Task<DBHPMDCPDMB<T>> BKJCIFOIBEF)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2929220", Offset = "0x2928220", VA = "0x182929220")]
	public static DBHPMDCPDMB<T> LGJIMEKOCEB<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2774FA0", Offset = "0x2773FA0", VA = "0x182774FA0")]
	public static DBHPMDCPDMB<T> KNGPGOLPHEH<T>(Exception BDHJMINHKON) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2774FA0", Offset = "0x2773FA0", VA = "0x182774FA0")]
	public static DBHPMDCPDMB<T> EDOBBGBIBFF<T>(Task<DBHPMDCPDMB<T>> BKJCIFOIBEF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public abstract class JLHBIPGOHJN<T> : DBHPMDCPDMB<T>, GHIFGBAJKGA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly string FJMLFBLOOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly LGMKGIJNBAN IFAFCODAHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private bool OBBFCMJHMOD;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool NPKMANILOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA1F950", Offset = "0xA1E950", VA = "0x180A1F950", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public abstract Task<T> LGFPBBDHJOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public abstract MLBHOBCFFDI<T> OKGNACLGNGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3D14360", Offset = "0x3D13360", VA = "0x183D14360")]
	public JLHBIPGOHJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3D14060", Offset = "0x3D13060", VA = "0x183D14060", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void KAAFCIFHHIB();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public abstract class BJJCGKGJCML<TTask, T> : JLHBIPGOHJN<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class LNLLOPNFIHO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public LNLLOPNFIHO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x328F980", Offset = "0x328E980", VA = "0x18328F980", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x328FC50", Offset = "0x328EC50", VA = "0x18328FC50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public BJJCGKGJCML<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public LNLLOPNFIHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x3E55770", Offset = "0x3E54770", VA = "0x183E55770")]
		[AsyncStateMachine(typeof(BJJCGKGJCML<, >.LNLLOPNFIHO.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> CLBEJEKPLPM(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly Task<T> BKJCIFOIBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	protected readonly CancellationTokenSource EILAHEEOMFB;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public override Task<T> LGFPBBDHJOF
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public override MLBHOBCFFDI<T> OKGNACLGNGC
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x48FDF60", Offset = "0x48FCF60", VA = "0x1848FDF60")]
	protected BJJCGKGJCML(TTask BKJCIFOIBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x48FDF10", Offset = "0x48FCF10", VA = "0x1848FDF10", Slot = "10")]
	protected override void KAAFCIFHHIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T HPKMFDJLPHL(TTask PLBHIDMHFCE);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void JMIGDEBPOAC();
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class JOGNFEGCBIA<T> : JLHBIPGOHJN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly IDLDPOIKMNH<Task<T>> NNKLIHPKOFE;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public override Task<T> LGFPBBDHJOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3D18F00", Offset = "0x3D17F00", VA = "0x183D18F00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public override MLBHOBCFFDI<T> OKGNACLGNGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3D18F40", Offset = "0x3D17F40", VA = "0x183D18F40")]
	public JOGNFEGCBIA(IDLDPOIKMNH<Task<T>> DMHNHEJPPGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3D18EE0", Offset = "0x3D17EE0", VA = "0x183D18EE0", Slot = "10")]
	protected override void KAAFCIFHHIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class KNOMEJPPBFF
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6284D60", Offset = "0x6283D60", VA = "0x186284D60")]
	[NotNull]
	public static byte[] JHCAMPNHLCA(this KHGDEAKBPOK IHCKOMEGCMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6284DD0", Offset = "0x6283DD0", VA = "0x186284DD0")]
	[NotNull]
	public static byte[] JHCAMPNHLCA(this KHGDEAKBPOK IHCKOMEGCMD, HashAlgorithmName JKIJFEAGDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6284910", Offset = "0x6283910", VA = "0x186284910")]
	public static bool DHALDAAIPEO([CanBeNull] this KHGDEAKBPOK IHCKOMEGCMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6284AA0", Offset = "0x6283AA0", VA = "0x186284AA0")]
	public static bool DHALDAAIPEO([CanBeNull] this KHGDEAKBPOK IHCKOMEGCMD, [Out] string FKMKCMGJCIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6284C40", Offset = "0x6283C40", VA = "0x186284C40")]
	private static bool IACEGIFLAEN([NotNull] KHGDEAKBPOK IHCKOMEGCMD, [Out][CanBeNull] byte[] MOPCFDBHDNJ, [Out][CanBeNull] byte[] IKPGAAANHNE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class NFAGNNFMCCO
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6285AE0", Offset = "0x6284AE0", VA = "0x186285AE0")]
	[NotNull]
	public static byte[] JHCAMPNHLCA(this JACPCNMJDLA LPMOHNACCMC, HashAlgorithmName JKIJFEAGDGO, byte[] NKNCHGJJNOD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface JACPCNMJDLA
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash NDPLPLPKLFN);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface KHGDEAKBPOK : JACPCNMJDLA
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[CanBeNull]
	byte[] CHPCIJPKHLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	[CanBeNull]
	byte[] OLIHMPKJGIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class MFFIMFPHPAM
{
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly ArrayPool<byte> AFBEAKBLLID;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static bool AHFDDCIDKJJ;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x297EEF0", Offset = "0x297DEF0", VA = "0x18297EEF0")]
	public static void LAJCGKDFAPG<T>(this IncrementalHash MHJLJJAPNCJ, [CanBeNull] T MPHIHJDJBKC) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x297E310", Offset = "0x297D310", VA = "0x18297E310")]
	public static void EDKCLGHDCDG<T>(this IncrementalHash MHJLJJAPNCJ, [CanBeNull] T LPMOHNACCMC) where T : JACPCNMJDLA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x297E3A0", Offset = "0x297D3A0", VA = "0x18297E3A0")]
	public static void IKNLGNDCDII<T>(this IncrementalHash MHJLJJAPNCJ, [CanBeNull] IList<T> GOGJOLLANKD) where T : JACPCNMJDLA
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6285650", Offset = "0x6284650", VA = "0x186285650")]
	private static bool IHICJKMEFPM([CanBeNull] JACPCNMJDLA LPMOHNACCMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x62856E0", Offset = "0x62846E0", VA = "0x1862856E0")]
	public static void IPPBGJOPGHD(this IncrementalHash NDPLPLPKLFN, [CanBeNull] string GHEEIPOEHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6285310", Offset = "0x6284310", VA = "0x186285310")]
	public static void FKHDBOBPLPI(this IncrementalHash NDPLPLPKLFN, long LFHMOLKKLKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6285140", Offset = "0x6284140", VA = "0x186285140")]
	public static void FCLJKOKPPAD(this IncrementalHash NDPLPLPKLFN, int CLNJBIANJIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x62857A0", Offset = "0x62847A0", VA = "0x1862857A0")]
	public static void PEHFOJHGCKA(this IncrementalHash NDPLPLPKLFN, short GLKECHLOBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6284FD0", Offset = "0x6283FD0", VA = "0x186284FD0")]
	public static void DJKOBAHMJAD(this IncrementalHash NDPLPLPKLFN, byte IKFGANODDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x62854E0", Offset = "0x62844E0", VA = "0x1862854E0")]
	public static void FPELJPDCBPA(this IncrementalHash NDPLPLPKLFN, bool EEDJDAFHIMA, bool DAHJGAPJHFB = false, bool FLCLPPLEODN = false, bool GCHJNIBOALC = false, bool NDHFMGIFEKK = false, bool EGCGIFKDKKF = false, bool CPMAMGOIIDJ = false, bool PAFHGAPLAIM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x297E8C0", Offset = "0x297D8C0", VA = "0x18297E8C0")]
	public static void KEFNIDDBJON<T>(this IncrementalHash NDPLPLPKLFN, T PAFEMMFOAKC) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6285970", Offset = "0x6284970", VA = "0x186285970")]
	public static void PKNDJCCBPEK(this IncrementalHash NDPLPLPKLFN, float NPFBNIDIAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6285740", Offset = "0x6284740", VA = "0x186285740")]
	public static void KGJNNAEODCL(this IncrementalHash NDPLPLPKLFN, ulong LGNPLICLFIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6284F70", Offset = "0x6283F70", VA = "0x186284F70")]
	public static void CIPJJOODNEM(this IncrementalHash NDPLPLPKLFN, uint HBHOEFPGCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x62850E0", Offset = "0x62840E0", VA = "0x1862850E0")]
	public static void EOGKOJAGDNE(this IncrementalHash NDPLPLPKLFN, ushort OCJDKBLANDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6284E40", Offset = "0x6283E40", VA = "0x186284E40")]
	public static void AOFIGPJGBDJ(this IncrementalHash NDPLPLPKLFN, Vector3 CJINKICAICL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class HIHJIPLMLKH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x62841E0", Offset = "0x62831E0", VA = "0x1862841E0")]
	public HIHJIPLMLKH(string JJJNODJJIFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class GCELMDCNFHD<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	internal class LCJAJNLFHLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TNode HFLBADIEKAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public TNode NNHBJFPLAAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public DHNBBINCCHI MMCALBDPLAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public List<DHNBBINCCHI> AJBPJANEPFN;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public LCJAJNLFHLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal struct DHNBBINCCHI : IComparable<DHNBBINCCHI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int NPHBPMHKILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public TClaimant LAPHLLDHBCP;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xC3D550", Offset = "0xC3C550", VA = "0x180C3D550")]
		public DHNBBINCCHI(int NPHBPMHKILI, TClaimant LAPHLLDHBCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x51F8900", Offset = "0x51F7900", VA = "0x1851F8900")]
		public bool ICOKGOBLLLF([In] DHNBBINCCHI JNHFAFOIKEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x51F88E0", Offset = "0x51F78E0", VA = "0x1851F88E0")]
		public bool BOBNPHABBLM([In] DHNBBINCCHI JNHFAFOIKEO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x51F88F0", Offset = "0x51F78F0", VA = "0x1851F88F0", Slot = "4")]
		public int CompareTo(DHNBBINCCHI JNHFAFOIKEO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x51F8960", Offset = "0x51F7960", VA = "0x1851F8960", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public enum AGHLIFPPAAE
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class DHBNOJLFNPJ : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public GCELMDCNFHD<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8164C0", Offset = "0x8154C0", VA = "0x1808164C0")]
		[DebuggerHidden]
		public DHBNOJLFNPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x51F47F0", Offset = "0x51F37F0", VA = "0x1851F47F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x51F49B0", Offset = "0x51F39B0", VA = "0x1851F49B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x51F48D0", Offset = "0x51F38D0", VA = "0x1851F48D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x37DDB30", Offset = "0x37DCB30", VA = "0x1837DDB30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly LELJPPEDFPC<LCJAJNLFHLL> LEJCIFOEHLF;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly LELJPPEDFPC<List<DHNBBINCCHI>> FBLHEJEHAOI;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static int FABJPMIGABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	internal readonly Dictionary<TClaimant, TNode> OJIMPGCJNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	internal readonly Dictionary<TNode, LCJAJNLFHLL> BJLDEPBAIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private AGHLIFPPAAE FGOIHKAPIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool FFEBLLHHGBH;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode GLPADCHGGOB(TNode CDMAFKOHEPF);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void CDAGELALPJM(TNode CDMAFKOHEPF, TClaimant HNCICFLFMAH, TClaimant DLHOBAJPJLM);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3998F90", Offset = "0x3997F90", VA = "0x183998F90")]
	public GCELMDCNFHD(AGHLIFPPAAE FGOIHKAPIEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3997C20", Offset = "0x3996C20", VA = "0x183997C20")]
	public void DFNFIFCLLFK(TNode CDMAFKOHEPF, TNode GFOFKCGAIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3998A40", Offset = "0x3997A40", VA = "0x183998A40")]
	public void MEJLHDHELPE(TClaimant LAPHLLDHBCP, TNode KOFCJLCKBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3997FF0", Offset = "0x3996FF0", VA = "0x183997FF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3998C50", Offset = "0x3997C50", VA = "0x183998C50")]
	private void PMOMGKDKCFH(TClaimant LAPHLLDHBCP, TNode JAPHOELACDF, TNode KOFCJLCKBFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x39984A0", Offset = "0x39974A0", VA = "0x1839984A0")]
	private int GEJDDDJGPBF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3997CB0", Offset = "0x3996CB0", VA = "0x183997CB0")]
	private void DPLDKJKFFAJ(TClaimant LAPHLLDHBCP, TNode JJDHNCCAEPL, TNode MCFHNMHDGHK, int DNOFEIFAMPM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x3998620", Offset = "0x3997620", VA = "0x183998620")]
	private void KIGHGKIPLMB(DHNBBINCCHI AMCLCAEFDGO, LCJAJNLFHLL ECPKNLIIEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x39981C0", Offset = "0x39971C0", VA = "0x1839981C0")]
	private void EJKMMOGDDJL(TClaimant LAPHLLDHBCP, TNode JJDHNCCAEPL, TNode MCFHNMHDGHK, int DNOFEIFAMPM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3998510", Offset = "0x3997510", VA = "0x183998510")]
	private void IGKLGCBMLNP(DHNBBINCCHI AMCLCAEFDGO, TNode CDMAFKOHEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3998950", Offset = "0x3997950", VA = "0x183998950")]
	private void MDFELHAAGHF(DHNBBINCCHI AMCLCAEFDGO, LCJAJNLFHLL ECPKNLIIEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x39986B0", Offset = "0x39976B0", VA = "0x1839986B0")]
	private void KOFMCNHHECC(LCJAJNLFHLL ECPKNLIIEJD, bool EANCJDFFJOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x39978E0", Offset = "0x39968E0", VA = "0x1839978E0")]
	private void CMMHHGFJJCA(LCJAJNLFHLL ECPKNLIIEJD, TNode GFOFKCGAIPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3998CF0", Offset = "0x3997CF0", VA = "0x183998CF0")]
	[IteratorStateMachine(typeof(GCELMDCNFHD<, >.DHBNOJLFNPJ))]
	private IEnumerable<TNode> PNKNPCKFNMH(TNode JJDHNCCAEPL, TNode MCFHNMHDGHK, bool LAPPBMKDNGP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x3998B60", Offset = "0x3997B60", VA = "0x183998B60")]
	private LCJAJNLFHLL NDPFBEKPPBN(TNode CDMAFKOHEPF, TNode NNHBJFPLAAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3997770", Offset = "0x3996770", VA = "0x183997770")]
	private LCJAJNLFHLL ANABOALMNAI(TNode CDMAFKOHEPF, TNode NNHBJFPLAAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x39987E0", Offset = "0x39977E0", VA = "0x1839987E0")]
	private void LMDKMDBMHMI(LCJAJNLFHLL ECPKNLIIEJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class LHMFDCIIDCM<T> : IEnumerable<LHMFDCIIDCM<T>.HFNHBNLLKHL>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct HFNHBNLLKHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public T LDGMLLMKHLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int GPEHCABDGEJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class JDFGFJEKALE : IEnumerator<HFNHBNLLKHL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private LHMFDCIIDCM<T> KBBJLBLDOLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private int GPEHCABDGEJ;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x3540150", Offset = "0x353F150", VA = "0x183540150", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public HFNHBNLLKHL DGGBFKFKJBG
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x3CC5E70", Offset = "0x3CC4E70", VA = "0x183CC5E70", Slot = "4")]
			get
			{
				return default(HFNHBNLLKHL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3CC5E30", Offset = "0x3CC4E30", VA = "0x183CC5E30")]
		public JDFGFJEKALE(LHMFDCIIDCM<T> KBBJLBLDOLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3CC5D30", Offset = "0x3CC4D30", VA = "0x183CC5D30", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3591310", Offset = "0x3590310", VA = "0x183591310", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x86A520", Offset = "0x869520", VA = "0x18086A520", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct CIEANMLGFKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public bool KNACPKNKKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public T LDGMLLMKHLF;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private const int GOKBFLOLFID = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly Dictionary<T, int> BCIHCFCIGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private CIEANMLGFKM[] PPGDOJOLEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int CBCNOMKBOGP;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int IHKOFCKDGHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7FFEA0", Offset = "0x7FEEA0", VA = "0x1807FFEA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7FFB10", Offset = "0x7FEB10", VA = "0x1807FFB10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int JFLFCJGPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x329FD00", Offset = "0x329ED00", VA = "0x18329FD00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3E36F20", Offset = "0x3E35F20", VA = "0x183E36F20")]
	public LHMFDCIIDCM(int AFDLPCPCHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3E37000", Offset = "0x3E36000", VA = "0x183E37000")]
	public LHMFDCIIDCM(HFNHBNLLKHL[] FJGLEOFJEFF, bool MCOCMGKDJFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3E36990", Offset = "0x3E35990", VA = "0x183E36990")]
	public int KPGGPFKNMEM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x3E36C10", Offset = "0x3E35C10", VA = "0x183E36C10")]
	private int NEDPBBPHPGF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x3E36220", Offset = "0x3E35220", VA = "0x183E36220", Slot = "6")]
	protected virtual uint DBJOAHNDFOO(uint NDPLPLPKLFN, T LDGMLLMKHLF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x3E36E50", Offset = "0x3E35E50", VA = "0x183E36E50")]
	public bool OJMEBDDGEHJ(T LDGMLLMKHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x3E362B0", Offset = "0x3E352B0", VA = "0x183E362B0")]
	public int DIPEJLFDPHF(T LDGMLLMKHLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x3E36880", Offset = "0x3E35880", VA = "0x183E36880")]
	public T HKPHBEPBONO(int GPEHCABDGEJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3E36790", Offset = "0x3E35790", VA = "0x183E36790")]
	public bool EHKMNAJLKME(T LDGMLLMKHLF, bool AGJPKDDMPJB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3E36320", Offset = "0x3E35320", VA = "0x183E36320")]
	public bool EHKMNAJLKME(T LDGMLLMKHLF, int GPEHCABDGEJ, bool AGJPKDDMPJB = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3E368F0", Offset = "0x3E358F0", VA = "0x183E368F0")]
	private int IHHKNJJMKHK(int GOABEOHPNBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3E36EA0", Offset = "0x3E35EA0", VA = "0x183E36EA0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3E36EA0", Offset = "0x3E35EA0", VA = "0x183E36EA0", Slot = "4")]
	private IEnumerator<HFNHBNLLKHL> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class LELJPPEDFPC<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly Stack<T> DJPBDLLODHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly List<T> BNBPDAKMCDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly int FONIMBNPGOG;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3E28390", Offset = "0x3E27390", VA = "0x183E28390")]
	public static LELJPPEDFPC<T> HOBKGIKJCGO(int AFDLPCPCHIJ = 0, int FONIMBNPGOG = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3E28110", Offset = "0x3E27110", VA = "0x183E28110")]
	public static LELJPPEDFPC<T> EFNCMHCIJAE(int AFDLPCPCHIJ = 0, int FONIMBNPGOG = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3E28820", Offset = "0x3E27820", VA = "0x183E28820")]
	public LELJPPEDFPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x3E28850", Offset = "0x3E27850", VA = "0x183E28850")]
	public LELJPPEDFPC(int AFDLPCPCHIJ, int FONIMBNPGOG = int.MaxValue, bool CDEGFIMBMNN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3E281F0", Offset = "0x3E271F0", VA = "0x183E281F0")]
	public T FPIGBFIIFEB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3E28670", Offset = "0x3E27670", VA = "0x183E28670")]
	public void OMHEABKHJKG(T LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3E28740", Offset = "0x3E27740", VA = "0x183E28740")]
	private void PFEPNOALOCE(T LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x3E28370", Offset = "0x3E27370", VA = "0x183E28370")]
	private void HJGDECAFCJO(T LDGMLLMKHLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x3E27FD0", Offset = "0x3E26FD0", VA = "0x183E27FD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x3E28470", Offset = "0x3E27470", VA = "0x183E28470")]
	private void JJPNNGLJBOK(IEnumerable<T> AGKDCPLPFCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class CNBNJPNNMCP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private Dictionary<int, T> AMCBEDPOHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private T BBMNABCFCOH;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T BEPMCFMHKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7C1DD0", Offset = "0x7C0DD0", VA = "0x1807C1DD0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x503CEF0", Offset = "0x503BEF0", VA = "0x18503CEF0")]
	public bool MKPEGPHPFHD(T LDGMLLMKHLF, int NPHBPMHKILI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x399DEC0", Offset = "0x399CEC0", VA = "0x18399DEC0")]
	public bool DBJOBDAELPE(int NPHBPMHKILI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x503CC90", Offset = "0x503BC90", VA = "0x18503CC90")]
	public T LEICANEFHEN(int LHNAMINAHLB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x503CF70", Offset = "0x503BF70", VA = "0x18503CF70")]
	private bool MPBEPHKHBNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x503CA50", Offset = "0x503BA50", VA = "0x18503CA50")]
	public bool DKPMPOAPJNG(int NPHBPMHKILI, [Out] T LDGMLLMKHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x503D120", Offset = "0x503C120", VA = "0x18503D120")]
	public CNBNJPNNMCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class FKEEIDAAMCC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	protected struct OBDOLJFDBCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public T DMDNAKDAMMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public int MCBPBILMIBN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	protected readonly List<OBDOLJFDBCA> APMPJCBODOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private T FIMHLJNLNOJ;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int JFLFCJGPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x329FD00", Offset = "0x329ED00", VA = "0x18329FD00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x389C8B0", Offset = "0x389B8B0", VA = "0x18389C8B0")]
	public bool LFLBPCGHIFM(T LDGMLLMKHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x389C5D0", Offset = "0x389B5D0", VA = "0x18389C5D0")]
	public void BGLDHBEBEIE(T LDGMLLMKHLF, int NPHBPMHKILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x389CA30", Offset = "0x389BA30", VA = "0x18389CA30")]
	public bool NCLCGNJGAKA(T LDGMLLMKHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x389C850", Offset = "0x389B850", VA = "0x18389C850")]
	public void HCLIMFMHPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x389C7D0", Offset = "0x389B7D0", VA = "0x18389C7D0")]
	public T GPEBAAGBNGB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x389C670", Offset = "0x389B670", VA = "0x18389C670")]
	private void GAHADDPHBJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x389CB80", Offset = "0x389BB80", VA = "0x18389CB80")]
	public FKEEIDAAMCC()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		[KDKBJHCHPNA(PHHCCEMPGEN.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x6285F70", Offset = "0x6284F70", VA = "0x186285F70")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x6286240", Offset = "0x6285240", VA = "0x186286240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x6286150", Offset = "0x6285150", VA = "0x186286150")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x6285EC0", Offset = "0x6284EC0", VA = "0x186285EC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x6286190", Offset = "0x6285190", VA = "0x186286190")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x62860A0", Offset = "0x62850A0", VA = "0x1862860A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6285E30", Offset = "0x6284E30", VA = "0x186285E30")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x4430F30", Offset = "0x442FF30", VA = "0x184430F30", Slot = "4")]
		public virtual T HJIDOPEAFLN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class GMJEKGCADEL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Dictionary<byte, GENGJOIJDJK> BLGJCONFGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly LELJPPEDFPC<GENGJOIJDJK> DJGEHAOMKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly bool GJPHHBLNGMG;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public GENGJOIJDJK APNHKNHBJJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C35E0", Offset = "0x7C25E0", VA = "0x1807C35E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7C35D0", Offset = "0x7C25D0", VA = "0x1807C35D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Vector2 JCONINJKEFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xBBD2A0", Offset = "0xBBC2A0", VA = "0x180BBD2A0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xEAC130", Offset = "0xEAB130", VA = "0x180EAC130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Vector2 JFAMMBEFGJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xF226D0", Offset = "0xF216D0", VA = "0x180F226D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Vector2 HEBLBKOAEPG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x62831A0", Offset = "0x62821A0", VA = "0x1862831A0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C6580", Offset = "0x7C5580", VA = "0x1807C6580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public int HNONJIHGNIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7C4310", Offset = "0x7C3310", VA = "0x1807C4310")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7C3F30", Offset = "0x7C2F30", VA = "0x1807C3F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6284120", Offset = "0x6283120", VA = "0x186284120")]
	public GMJEKGCADEL(Bounds BLDNEOMKMOG, Vector2[] KAJLDAFKKEA, int HGOHDOKAFOK, byte GOABEOHPNBP, float LKPBBBAHFCG = 0f, [Optional] LELJPPEDFPC<GENGJOIJDJK> DJGEHAOMKFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x62832F0", Offset = "0x62822F0", VA = "0x1862832F0")]
	public void EFIHJFJLHFE(Bounds BLDNEOMKMOG, Vector2[] KAJLDAFKKEA, int HGOHDOKAFOK, byte GOABEOHPNBP, float LKPBBBAHFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6283BB0", Offset = "0x6282BB0", VA = "0x186283BB0")]
	public GENGJOIJDJK INGCOEHPLGI(byte GPEHCABDGEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x62831C0", Offset = "0x62821C0", VA = "0x1862831C0")]
	public void DIEJJIMNHDB(Vector3 BJIKBOECFPB, float ELOEMDKCDOJ, float MEKAJFOKOEO, List<byte> CKCJIJLKBFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x59F7250", Offset = "0x59F6250", VA = "0x1859F7250")]
	public void JFLFGMDDIAM(GENGJOIJDJK.CCAAKAILMBI AIEMICGLFKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6284030", Offset = "0x6283030", VA = "0x186284030")]
	public static int PLCJOAEKKDN(Vector2[] KAJLDAFKKEA, int HGOHDOKAFOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6283C10", Offset = "0x6282C10", VA = "0x186283C10")]
	private GENGJOIJDJK MEJPIKJJLEM(byte GPEHCABDGEJ, GENGJOIJDJK.EAFFKFONJAI OIBPFIBMFCI, GENGJOIJDJK NNHBJFPLAAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x62837A0", Offset = "0x62827A0", VA = "0x1862837A0")]
	private void FIDKDLNJLIK(GENGJOIJDJK NNHBJFPLAAA, Vector2[] KAJLDAFKKEA, int OKBGCKAMKLL, int LADLNLLAOAP, int BBLCKDPIAOA, int ICBAFPDAMAI, float LKPBBBAHFCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6283E10", Offset = "0x6282E10", VA = "0x186283E10")]
	private void NJHMAGMMEPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6283290", Offset = "0x6282290", VA = "0x186283290", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x6283B50", Offset = "0x6282B50", VA = "0x186283B50", Slot = "1")]
	~GMJEKGCADEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class GENGJOIJDJK
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public enum EAFFKFONJAI
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public enum CCAAKAILMBI
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte MNFBEPHEHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public Vector3 MMJFEJFPKPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public Vector3 BMODBHJLIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public Vector3 PLFOFCMLCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public Vector3 AMFJHOKDKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public EAFFKFONJAI EHCDPOIEDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public GENGJOIJDJK MILAJCEOCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public List<GENGJOIJDJK> ALCJHOMLEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public bool HGLOPPKBFHN;

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x6283180", Offset = "0x6282180", VA = "0x186283180")]
	public GENGJOIJDJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6283030", Offset = "0x6282030", VA = "0x186283030")]
	public void JGINDGHHPNF(GENGJOIJDJK HJKHNDILIPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
	public void JFLFGMDDIAM(int DGNGLELHEAK, CCAAKAILMBI AIEMICGLFKK, int FHAIKNGJHJA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6282DD0", Offset = "0x6281DD0", VA = "0x186282DD0")]
	public void DIEJJIMNHDB(List<byte> CKCJIJLKBFC, Vector3 BJIKBOECFPB, float ELOEMDKCDOJ, float MEKAJFOKOEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6282D10", Offset = "0x6281D10", VA = "0x186282D10")]
	public bool BMJAEGMJKDA(Vector3 FCJBPODALAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6283150", Offset = "0x6282150", VA = "0x186283150")]
	public bool MPFMDMCPIPJ(Vector3 FCJBPODALAO, float HLOPOBKCJKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6282D40", Offset = "0x6281D40", VA = "0x186282D40")]
	public void CJMKLAKCCOG()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		public struct IELJCFFBBJG<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			private readonly List<Component> FKIBLLNGEAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			private readonly bool BIOENALHCAJ;

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x387F510", Offset = "0x387E510", VA = "0x18387F510")]
			public IELJCFFBBJG(List<Component> FKIBLLNGEAG, bool BIOENALHCAJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x3AEF360", Offset = "0x3AEE360", VA = "0x183AEF360")]
			public AACIBCPBJJF<T> IEKFBOGGJFJ()
			{
				return default(AACIBCPBJJF<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x3AEF3D0", Offset = "0x3AEE3D0", VA = "0x183AEF3D0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x3AEF3D0", Offset = "0x3AEE3D0", VA = "0x183AEF3D0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public struct AACIBCPBJJF<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			private readonly List<Component> FKIBLLNGEAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private readonly bool BIOENALHCAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			private int GPEHCABDGEJ;

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public T DGGBFKFKJBG
			{
				[Cpp2IlInjected.Token(Token = "0x60001F9")]
				[Cpp2IlInjected.Address(RVA = "0x3943450", Offset = "0x3942450", VA = "0x183943450", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001FA")]
				[Cpp2IlInjected.Address(RVA = "0x39433E0", Offset = "0x39423E0", VA = "0x1839433E0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x3943420", Offset = "0x3942420", VA = "0x183943420")]
			public AACIBCPBJJF(List<Component> FKIBLLNGEAG, bool BIOENALHCAJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x3943320", Offset = "0x3942320", VA = "0x183943320", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x3943330", Offset = "0x3942330", VA = "0x183943330", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x3584550", Offset = "0x3583550", VA = "0x183584550", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x62875B0", Offset = "0x62865B0", VA = "0x1862875B0")]
		private void CJMKLAKCCOG(GameObject JEDPLPDPMGC, bool CLNMAALIOEC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x6287720", Offset = "0x6286720", VA = "0x186287720")]
		public static void CJMKLAKCCOG(GameObject JEDPLPDPMGC, ToolHierarchyCache JLHONOEJKBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0E00", Offset = "0x2B9FE00", VA = "0x182BA0E00")]
		public void FCIIJFIDKMM<T>(Action<T> LNMJHEPMAAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0D90", Offset = "0x2B9FD90", VA = "0x182BA0D90")]
		public T BJJEGBOJCLG<T>(bool BIOENALHCAJ = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2BA0CD0", Offset = "0x2B9FCD0", VA = "0x182BA0CD0")]
		public IELJCFFBBJG<T> ACEPHCDJGAF<T>(bool BIOENALHCAJ = false) where T : class
		{
			return default(IELJCFFBBJG<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x62878E0", Offset = "0x62868E0", VA = "0x1862878E0")]
		public List<Component> CKCCDGEOEOE(Type KBCNAJKPHNL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6287C30", Offset = "0x6286C30", VA = "0x186287C30", Slot = "4")]
		public bool Equals(ToolHierarchyCache DLGLHFDHDLB, ToolHierarchyCache ANLBKHHFCFE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6287CB0", Offset = "0x6286CB0", VA = "0x186287CB0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache KDEEPMDJGFD)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class CCAMKKAJGPL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int AFDLPCPCHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private int ABJOFDCGIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private List<T> MAINFAOCHKE;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int JFLFCJGPPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3D18F00", Offset = "0x3D17F00", VA = "0x183D18F00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public T IINBOPDCMHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x4BDDBD0", Offset = "0x4BDCBD0", VA = "0x184BDDBD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public T JHANHALFKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x4BDE150", Offset = "0x4BDD150", VA = "0x184BDE150")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public T IBGEGLMOOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x4BDE010", Offset = "0x4BDD010", VA = "0x184BDE010")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4BDE260", Offset = "0x4BDD260", VA = "0x184BDE260")]
	public CCAMKKAJGPL(int AFDLPCPCHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4BDDE10", Offset = "0x4BDCE10", VA = "0x184BDDE10")]
	public void BGLDHBEBEIE(T LCEPBCIJLKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4BDE1C0", Offset = "0x4BDD1C0", VA = "0x184BDE1C0")]
	public void HCLIMFMHPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4BDDD40", Offset = "0x4BDCD40", VA = "0x184BDDD40")]
	public void BFKBMDPLCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4BDE200", Offset = "0x4BDD200", VA = "0x184BDE200")]
	public void OLKJIFJNBEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4BDE000", Offset = "0x4BDD000", VA = "0x184BDE000")]
	public void BOMANHLEGIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class GHPMPJCELLG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private struct CBAJPAOLCCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int MCBPBILMIBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public T DMDNAKDAMMG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly Dictionary<object, CBAJPAOLCCA> AMCBEDPOHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly EqualityComparer<T> LFNPEKBJCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private T BBMNABCFCOH;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public virtual T BEPMCFMHKEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x105F1C0", Offset = "0x105E1C0", VA = "0x18105F1C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x39A0C40", Offset = "0x399FC40", VA = "0x1839A0C40", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool JOEGNPKCEFH
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x39A0CD0", Offset = "0x399FCD0", VA = "0x1839A0CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public object FLAKDCGFKKE
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7C5860", Offset = "0x7C4860", VA = "0x1807C5860")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7C5840", Offset = "0x7C4840", VA = "0x1807C5840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x39A1060", Offset = "0x39A0060", VA = "0x1839A1060")]
	public bool MKPEGPHPFHD(T LDGMLLMKHLF, object KONODCHOCOG, int NPHBPMHKILI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x39A07D0", Offset = "0x399F7D0", VA = "0x1839A07D0")]
	public bool DBJOBDAELPE(object KONODCHOCOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x39A0A40", Offset = "0x399FA40", VA = "0x1839A0A40")]
	public bool DKPMPOAPJNG(object KONODCHOCOG, [Out] T LDGMLLMKHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x39A0C70", Offset = "0x399FC70", VA = "0x1839A0C70")]
	public void HCLIMFMHPCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x39A2250", Offset = "0x39A1250", VA = "0x1839A2250")]
	private bool MPBEPHKHBNP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x39A2840", Offset = "0x39A1840", VA = "0x1839A2840")]
	public GHPMPJCELLG()
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
