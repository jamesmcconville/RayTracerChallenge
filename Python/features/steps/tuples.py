from behave import *

@given(u'a = tuple(4.3, -4.2, 1.0)')
def step_impl(context):
    raise NotImplementedError(u'STEP: Given a = tuple(4.3, -4.2, 1.0)')


@then(u'a.x = 4.3')
def step_impl(context):
    raise NotImplementedError(u'STEP: Then a.x = 4.3')


@then(u'a.y = -4.2')
def step_impl(context):
    raise NotImplementedError(u'STEP: Then a.y = -4.2')


@then(u'a.z = 3.1')
def step_impl(context):
    raise NotImplementedError(u'STEP: Then a.z = 3.1')


@then(u'a.w = 1.0')
def step_impl(context):
    raise NotImplementedError(u'STEP: Then a.w = 1.0')


@then(u'a is a point')
def step_impl(context):
    raise NotImplementedError(u'STEP: Then a is a point')


@then(u'a is not a vector')
def step_impl(context):
    raise NotImplementedError(u'STEP: Then a is not a vector')