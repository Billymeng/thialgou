/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.9
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.thialgou.commonWRAP {

using System;
using System.Runtime.InteropServices;

public class CommonError : CommonElt {
  private HandleRef swigCPtr;

  internal CommonError(IntPtr cPtr, bool cMemoryOwn) : base(commonWRAPPINVOKE.CommonError_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(CommonError obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~CommonError() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          commonWRAPPINVOKE.delete_CommonError(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public CommonError(string strDescription) : this(commonWRAPPINVOKE.new_CommonError(strDescription), true) {
    if (commonWRAPPINVOKE.SWIGPendingException.Pending) throw commonWRAPPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string getDescription() {
    string ret = commonWRAPPINVOKE.CommonError_getDescription(swigCPtr);
    return ret;
  }

}

}